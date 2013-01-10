/*
 * Created by SharpDevelop.
 * User: Admin
 * Date: 16.12.2012
 * Time: 01:11
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace C_Ext
{
	partial class DlgAbout
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DlgAbout));
			this.AssemblyDate = new System.Windows.Forms.Label();
			this.DateLabel = new System.Windows.Forms.Label();
			this.Version = new System.Windows.Forms.Label();
			this.VersionLabel = new System.Windows.Forms.Label();
			this.AuthorEmail = new System.Windows.Forms.LinkLabel();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.buttonClose = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// AssemblyDate
			// 
			this.AssemblyDate.Location = new System.Drawing.Point(142, 113);
			this.AssemblyDate.Name = "AssemblyDate";
			this.AssemblyDate.Size = new System.Drawing.Size(100, 23);
			this.AssemblyDate.TabIndex = 25;
			this.AssemblyDate.Text = "AssemblyDate";
			// 
			// DateLabel
			// 
			this.DateLabel.Location = new System.Drawing.Point(84, 113);
			this.DateLabel.Name = "DateLabel";
			this.DateLabel.Size = new System.Drawing.Size(100, 23);
			this.DateLabel.TabIndex = 24;
			this.DateLabel.Text = "Date:";
			// 
			// Version
			// 
			this.Version.Location = new System.Drawing.Point(142, 100);
			this.Version.Name = "Version";
			this.Version.Size = new System.Drawing.Size(100, 23);
			this.Version.TabIndex = 23;
			this.Version.Text = "assemblyVersion";
			// 
			// VersionLabel
			// 
			this.VersionLabel.Location = new System.Drawing.Point(84, 100);
			this.VersionLabel.Name = "VersionLabel";
			this.VersionLabel.Size = new System.Drawing.Size(100, 23);
			this.VersionLabel.TabIndex = 22;
			this.VersionLabel.Text = "Version:";
			// 
			// AuthorEmail
			// 
			this.AuthorEmail.Location = new System.Drawing.Point(216, 76);
			this.AuthorEmail.Name = "AuthorEmail";
			this.AuthorEmail.Size = new System.Drawing.Size(134, 23);
			this.AuthorEmail.TabIndex = 21;
			this.AuthorEmail.TabStop = true;
			this.AuthorEmail.Text = "g-makulik@t-online,de";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(83, 76);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(158, 17);
			this.label2.TabIndex = 20;
			this.label2.Text = "© 2012 Günther Makulik\r\n";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(79, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(305, 53);
			this.label1.TabIndex = 19;
			this.label1.Text = "C_Ext Enterprise Architect \r\nC/C++ Code Engineering";
			// 
			// buttonClose
			// 
			this.buttonClose.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buttonClose.Location = new System.Drawing.Point(299, 108);
			this.buttonClose.Name = "buttonClose";
			this.buttonClose.Size = new System.Drawing.Size(70, 23);
			this.buttonClose.TabIndex = 18;
			this.buttonClose.Text = "&Close";
			this.buttonClose.UseVisualStyleBackColor = true;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
			this.pictureBox1.Location = new System.Drawing.Point(9, 9);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(64, 64);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox1.TabIndex = 17;
			this.pictureBox1.TabStop = false;
			// 
			// DlgAbout
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(383, 141);
			this.Controls.Add(this.AssemblyDate);
			this.Controls.Add(this.DateLabel);
			this.Controls.Add(this.Version);
			this.Controls.Add(this.VersionLabel);
			this.Controls.Add(this.AuthorEmail);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.buttonClose);
			this.Controls.Add(this.pictureBox1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "DlgAbout";
			this.Text = "DlgAbout";
			this.Load += new System.EventHandler(this.DlgAboutLoad);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button buttonClose;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.LinkLabel AuthorEmail;
		private System.Windows.Forms.Label VersionLabel;
		private System.Windows.Forms.Label Version;
		private System.Windows.Forms.Label DateLabel;
		private System.Windows.Forms.Label AssemblyDate;
	}
}
