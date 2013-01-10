﻿/*
 * Created by SharpDevelop.
 * User: Admin
 * Date: 16.12.2012
 * Time: 01:11
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace C_Ext
{
	/// <summary>
	/// Description of DlgAbout.
	/// </summary>
	public partial class DlgAbout : Form
	{
		public DlgAbout()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			// Set the assembly version
			this.Version.Text = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
			
			// Set the assembly Date
			this.AssemblyDate.Text = System.IO.File.GetLastWriteTime(System.Reflection.Assembly.GetExecutingAssembly().Location).ToShortDateString();

			// Set the author email adress
			this.AuthorEmail.Links.Add(0,this.AuthorEmail.Text.Length,"mailto:g-makulik@t-online.de");
		}
		
		void DlgAboutLoad(object sender, EventArgs e)
		{
			
		}
	}
}
