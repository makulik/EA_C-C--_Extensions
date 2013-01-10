/*
 * Created by SharpDevelop.
 * User: Admin
 * Date: 19.12.2012
 * Time: 21:44
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;

using UML = TSF.UmlToolingFramework.UML;
using UTF_EA = TSF.UmlToolingFramework.Wrappers.EA;

namespace C_Ext
{
	/// <summary>
	/// Description of FunptrInterface.
	/// </summary>
	public class FunptrInterface
	{
		UML.Classes.Interfaces.Interface funptrInterface_;
		
		public const string tagRetval = "retval";
		public const string tagParams = "params";
		public const string tagStatic = "static";
		public const string tagTypeSynonyms = "typeSynonyms";
		public const string tagTypedef = "typedef";
		
		public FunptrInterface(UML.Classes.Interfaces.Interface funptrInterface)
		{
			funptrInterface_ = funptrInterface;
		}
		
		public string GetAliasFromTags(string tagName = null, string tagValue = null)
		{
			System.Text.StringBuilder sbAlias = new System.Text.StringBuilder();
			
			string retval = GetTaggedValue(tagRetval);
			string paramsTypeList = GetTaggedValue(tagParams);
			bool isStatic = GetTaggedValue(tagStatic) == "true";
			string owner = "";
			if(!isStatic && 
			   (funptrInterface_.owner != null) &&
			   ((funptrInterface_.owner is UML.Classes.Kernel.Class) ||
	        	 (funptrInterface_.owner is UML.Classes.Interfaces.Interface))) {
				owner = funptrInterface_.owner.name;
			}
						
			if(retval == "") {
				retval = "void";
			}
			
			if(tagName != null && tagValue != null) {
				switch(tagName) {
				case tagRetval:
						retval = tagValue;
					break;
				case tagParams:
						paramsTypeList = tagValue;
					break;
				}
			}
			
			sbAlias.Append(retval);
			sbAlias.Append(" (*");
			if(owner != "") {
				sbAlias.Append(owner);
			}
			sbAlias.Append(")(");
			sbAlias.Append(paramsTypeList);
			sbAlias.Append(")");

			return sbAlias.ToString();
		}
	
		private string GetTaggedValue(string name)
		{
			foreach(UML.Profiles.TaggedValue taggedValue in funptrInterface_.taggedValues) {
				if(taggedValue.name == name) {
					return taggedValue.tagValue.ToString();
				}
			}
			
			return "";
		}
	}	
}
