/*
 * Created by SharpDevelop.
 * User: Admin
 * Date: 16.12.2012
 * Time: 00:42
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;
using System.Security.Authentication;
using EA;
using System.Collections.Generic;
using System.Windows.Forms;
using UML = TSF.UmlToolingFramework.UML;
using UTF_EA = TSF.UmlToolingFramework.Wrappers.EA;
using EA_Utils = EAAddinFramework.Utilities;

namespace C_Ext
{
	/// <summary>
	/// Description of C_ExtClass.
	/// </summary>
	public class C_ExtClass
	: EAAddinFramework.EAAddinBase
	{

        // define menu constants
        const string menuName = "-C_Ext";
        const string menuAbout = "&About";

	    private UTF_EA.Model model = null;
	    private bool fullyLoaded = false;
	    private EA.Repository currentRepository = null;
	    private bool inSyncUmlItem;

        /// <summary>
        /// constructor where we set the menuheader and menuOptions
        /// </summary>
        public C_ExtClass()
        : base()
		{
			this.menuHeader = menuName;
			this.menuOptions = new string[]{menuAbout};
			inSyncUmlItem = false;
		}

		/// <summary>
        /// EA_Connect events enable Add-Ins to identify their type and to respond to Enterprise Architect start up.
        /// This event occurs when Enterprise Architect first loads your Add-In. Enterprise Architect itself is loading at this time so that while a Repository object is supplied, there is limited information that you can extract from it.
        /// The chief uses for EA_Connect are in initializing global Add-In data and for identifying the Add-In as an MDG Add-In.
        /// Also look at EA_Disconnect.
        /// </summary>	
        /// <param name="Repository">An EA.Repository object representing the currently open Enterprise Architect model.
        /// Poll its members to retrieve model data and user interface status information.</param>
        /// <returns>String identifying a specialized type of Add-In: 
        /// - "MDG" : MDG Add-Ins receive MDG Events and extra menu options.
        /// - "" : None-specialized Add-In.</returns>
		public override string EA_Connect(EA.Repository Repository)
		{
			currentRepository = Repository;
			return base.EA_Connect(Repository);
		}
		
		public override void EA_OnPostInitialized(EA.Repository Repository)
		{
			// initialize the model
	        this.model = new UTF_EA.Model(Repository);
	        fullyLoaded = true;
			base.EA_OnPostInitialized(Repository);
		}
		
		public override void EA_FileClose(EA.Repository Repository)
		{
			fullyLoaded = false;
			currentRepository = null;
			base.EA_FileClose(Repository);
		}
		
        /// <summary>
        /// Called once Menu has been opened to see what menu items should active.
        /// </summary>
        /// <param name="Repository">the repository</param>
        /// <param name="Location">the location of the menu</param>
        /// <param name="MenuName">the name of the menu</param>
        /// <param name="ItemName">the name of the menu item</param>
        /// <param name="IsEnabled">boolean indicating whethe the menu item is enabled</param>
        /// <param name="IsChecked">boolean indicating whether the menu is checked</param>
        public override void EA_GetMenuState(EA.Repository Repository, string Location, string MenuName, string ItemName, ref bool IsEnabled, ref bool IsChecked)
        {
            switch (ItemName)
            {
                // define the state of the about menu option
                case menuAbout:
                	IsEnabled = true;
                    return;
            }
            if (IsProjectOpen(Repository))
            {
                switch (ItemName)
                {
                    default:
                        IsEnabled = false;
                        break;
                }
            }
        }

        /// <summary>
        /// Called when user makes a selection in the menu.
        /// This is your main exit point to the rest of your Add-in
        /// </summary>
        /// <param name="Repository">the repository</param>
        /// <param name="Location">the location of the menu</param>
        /// <param name="MenuName">the name of the menu</param>
        /// <param name="ItemName">the name of the selected menu item</param>
        public override void EA_MenuClick(EA.Repository Repository, string Location, string MenuName, string ItemName)
        {
            switch (ItemName)
            {
                case menuAbout:
                    this.showAboutDialog();
                    break;
            }
        }
        
		public override bool EA_OnPostNewElement(Repository Repository, EventProperties Info)
		{
	        this.model = new UTF_EA.Model(Repository);
			bool changedElement = base.EA_OnPostNewElement(Repository, Info);
        	EA_Utils.EventPropertiesHelper evProp = new EA_Utils.EventPropertiesHelper(Repository,Info);
        	EA.Element element;
        	if(evProp.GetElement(out element)) {
	        	UML.UMLItem umlItem = model.getElementByGUID(element.ElementGUID);
				if(umlItem != null)
				{
					if(IsTrackedUmlItem(umlItem))
					{
						SynchronizeUmlItem(umlItem);
						changedElement = true;
					}
				}
    	    }
        	Repository.RefreshOpenDiagrams(true);
        	return changedElement;
		}
		
		public override void EA_OnNotifyContextItemModified(Repository Repository, string GUID, ObjectType ot)
		{
	        this.model = new UTF_EA.Model(Repository);
	        
			base.EA_OnNotifyContextItemModified(Repository, GUID, ot);
			UML.UMLItem umlItem = model.getElementByGUID(GUID);
			if(umlItem != null)
			{
				if(IsTrackedUmlItem(umlItem))
				{
					SynchronizeUmlItem(umlItem);
				}
			}
        	Repository.RefreshOpenDiagrams(true);
		}
		
		public override void EA_OnElementTagEdit(Repository Repository, long ObjectID, ref string TagName, ref string TagValue, ref string TagNotes)
		{
	        this.model = new UTF_EA.Model(Repository);
			base.EA_OnElementTagEdit(Repository, ObjectID, ref TagName, ref TagValue, ref TagNotes);
			UML.UMLItem umlItem = model.getElementWrapperByID((int)ObjectID);
			if(umlItem != null)
			{
				if(IsTrackedUmlItem(umlItem))
				{
					SynchronizeUmlItemTags(umlItem, ref TagName, ref TagValue, ref TagNotes);
				}
			}
        	Repository.RefreshOpenDiagrams(true);
		}
		
		/// <summary>
        /// Show the About dialog.
        /// </summary>
        private void showAboutDialog()
        {
        	DlgAbout dlgAbout = new DlgAbout();
        	dlgAbout.ShowDialog();
        }
        
        private bool IsTrackedUmlItem(UML.UMLItem umlItem)
        {
        	if(umlItem is UML.Classes.Kernel.Class)
        	{
        		UML.Classes.Kernel.Class classItem = umlItem as UML.Classes.Kernel.Class;
        	}
        	else if(umlItem is UML.Classes.Interfaces.Interface)
        	{
        		UML.Classes.Interfaces.Interface interfaceItem = umlItem as UML.Classes.Interfaces.Interface;
        		if(HasSterotype(C_ExtStereotypes.funptr,interfaceItem.stereotypes)) {
	        		return true;
        		}
        	}
        	else if(umlItem is UML.Classes.Kernel.Operation)
        	{
        		UML.Classes.Kernel.Operation opItem = umlItem as UML.Classes.Kernel.Operation;
        		if(HasSterotype(C_ExtStereotypes.funptr,opItem.stereotypes)) {
	        		return true;
        		}
        	}
        	return false;
        }
        
        private bool SynchronizeUmlItem(UML.UMLItem umlItem)
        {
        	if(inSyncUmlItem) {
        		return false;
        	}
        	
        	try {
	        	inSyncUmlItem = true;
        		
	        	string TagName = null;
				string TagValue = null;
				string TagNotes = null;
	        	if(umlItem is UML.Classes.Kernel.Class)
	        	{
	        		UML.Classes.Kernel.Class classItem = umlItem as UML.Classes.Kernel.Class;
	        	}
	        	else if(umlItem is UML.Classes.Interfaces.Interface)
	        	{
	        		return SynchronizeUmlItemTags(umlItem as UML.Classes.Interfaces.Interface,ref TagName, ref TagValue, ref TagNotes);
	        	}
	        	else if(umlItem is UML.Classes.Kernel.Operation)
	        	{
	        		return SynchronizeUmlItemTags(umlItem as UML.Classes.Kernel.Operation,ref TagName, ref TagValue, ref TagNotes);
	        	}
        	}
        	catch(Exception ex) {
	        	inSyncUmlItem = false;
        		throw ex;
        	}
        	finally {
	        	inSyncUmlItem = false;
        	}
        	
        	return false;
        }
                        
        private bool SynchronizeUmlItemTags(UML.UMLItem umlItem, ref string TagName, ref string TagValue, ref string TagNotes)
        {
        	inSyncUmlItem = true;
        	try {
	        	if(umlItem is UML.Classes.Kernel.Class)
	        	{
	        		UML.Classes.Kernel.Class classItem = umlItem as UML.Classes.Kernel.Class;
	        	}
	        	else if(umlItem is UML.Classes.Interfaces.Interface)
	        	{
	        		return SynchronizeUmlItemTags(umlItem as UML.Classes.Interfaces.Interface, ref TagName, ref TagValue, ref TagNotes);
	        	}
	        	else if(umlItem is UML.Classes.Kernel.Operation)
	        	{
	        		return SynchronizeUmlItemTags(umlItem as UML.Classes.Kernel.Operation, ref TagName, ref TagValue, ref TagNotes);
	        	}
        	}
        	catch(Exception ex) {
	        	inSyncUmlItem = false;
        		throw ex;
        	}
        	finally {
	        	inSyncUmlItem = false;
        	}
        	
        	return false;
        }
        
        private bool SynchronizeUmlItemTags(UML.Classes.Interfaces.Interface interfaceItem, ref string TagName, ref string TagValue, ref string TagNotes)
        {
        	if(HasSterotype(C_ExtStereotypes.funptr,interfaceItem.stereotypes))
        	{
        		FunptrInterface funptr = new FunptrInterface(interfaceItem);
        		string defaultTypeSynonymsTag = interfaceItem.name;
        		EA.Element eaElem = (interfaceItem as UTF_EA.ElementWrapper).WrappedElement;
        		bool changedElement = false;
        		
        		// Synchronize tagged values
        		for(short i = 0; i < eaElem.TaggedValues.Count; ++i) {
	        		EA.TaggedValue currentTag = eaElem.TaggedValues.GetAt(i) as EA.TaggedValue;
	        		bool changedTag = false;
	        		switch(currentTag.Name) {
	        			case C_ExtTags.typeSynonyms:
			        		if(currentTag.Value != defaultTypeSynonymsTag) {
			        			currentTag.Value = defaultTypeSynonymsTag;
			        			changedTag = true;
			        		}
	        			break;
	        			case C_ExtTags.static_:
			        		if((currentTag.Value == "false") && 
			        		   !((interfaceItem.owner is UML.Classes.Kernel.Class) ||
	        			         (interfaceItem.owner is UML.Classes.Interfaces.Interface))) {
			        			TagValue = "true";
			        			changedTag = true;
			        		}
	        			break;
	        		}
	        		if(changedTag) {
	        			currentTag.Update();
	        			eaElem.TaggedValues.Refresh();
	        			changedElement = true;
	        		}
        		}
        		        		
        		// Synchronize element Alias
        		string alias = funptr.GetAliasFromTags(TagName,TagValue);
        		if(eaElem.Alias != alias) {
        			eaElem.Alias = alias;
        			changedElement = true;
        		}

        		if(changedElement) {
        			eaElem.Update();
        		}
        		return changedElement;
        	}
        	
        	return false;
        }
                
        private bool SynchronizeUmlItemTags(UML.Classes.Kernel.Operation opItem, ref string TagName, ref string TagValue, ref string TagNotes)
        {
        	return false;
        }

        private bool HasSterotype(string name, HashSet<UML.Profiles.Stereotype> stereotypes)
		{
			foreach(UML.Profiles.Stereotype stereotype in stereotypes) {
				if(stereotype.name == name) {
					return true;
				}
			}
			return false;
		}

	}
}