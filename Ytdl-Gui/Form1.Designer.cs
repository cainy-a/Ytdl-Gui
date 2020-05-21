namespace Ytdl_Gui
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}

			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.linkLabelCain = new System.Windows.Forms.LinkLabel();
			this.linkLabelYTDL = new System.Windows.Forms.LinkLabel();
			this.listBoxSelected = new System.Windows.Forms.ListBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textBoxAdd = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.buttonAdd = new System.Windows.Forms.Button();
			this.buttonClear = new System.Windows.Forms.Button();
			this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
			this.label4 = new System.Windows.Forms.Label();
			this.textBoxPath = new System.Windows.Forms.TextBox();
			this.buttonBrowse = new System.Windows.Forms.Button();
			this.buttonDownload = new System.Windows.Forms.Button();
			this.linkLabelSites = new System.Windows.Forms.LinkLabel();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(246, 36);
			this.label1.TabIndex = 0;
			this.label1.Text = "Youtube-DL GUI";
			// 
			// linkLabelCain
			// 
			this.linkLabelCain.Location = new System.Drawing.Point(264, 32);
			this.linkLabelCain.Name = "linkLabelCain";
			this.linkLabelCain.Size = new System.Drawing.Size(112, 21);
			this.linkLabelCain.TabIndex = 1;
			this.linkLabelCain.TabStop = true;
			this.linkLabelCain.Text = "GUI by Cain Atkinson";
			this.linkLabelCain.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelCain_LinkClicked);
			// 
			// linkLabelYTDL
			// 
			this.linkLabelYTDL.Location = new System.Drawing.Point(264, 9);
			this.linkLabelYTDL.Name = "linkLabelYTDL";
			this.linkLabelYTDL.Size = new System.Drawing.Size(180, 19);
			this.linkLabelYTDL.TabIndex = 2;
			this.linkLabelYTDL.TabStop = true;
			this.linkLabelYTDL.Text = "Powered by the Youtube-DL Project\r\n";
			this.linkLabelYTDL.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelYTDL_LinkClicked);
			// 
			// listBoxSelected
			// 
			this.listBoxSelected.FormattingEnabled = true;
			this.listBoxSelected.Location = new System.Drawing.Point(12, 68);
			this.listBoxSelected.Name = "listBoxSelected";
			this.listBoxSelected.Size = new System.Drawing.Size(532, 121);
			this.listBoxSelected.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(12, 45);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(144, 20);
			this.label2.TabIndex = 4;
			this.label2.Text = "Selected URLs";
			// 
			// textBoxAdd
			// 
			this.textBoxAdd.Location = new System.Drawing.Point(12, 245);
			this.textBoxAdd.Name = "textBoxAdd";
			this.textBoxAdd.Size = new System.Drawing.Size(532, 20);
			this.textBoxAdd.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(12, 221);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(71, 21);
			this.label3.TabIndex = 6;
			this.label3.Text = "URL to add";
			// 
			// buttonAdd
			// 
			this.buttonAdd.Location = new System.Drawing.Point(12, 271);
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Size = new System.Drawing.Size(532, 23);
			this.buttonAdd.TabIndex = 7;
			this.buttonAdd.Text = "Add URL";
			this.buttonAdd.UseVisualStyleBackColor = true;
			this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
			// 
			// buttonClear
			// 
			this.buttonClear.Location = new System.Drawing.Point(12, 195);
			this.buttonClear.Name = "buttonClear";
			this.buttonClear.Size = new System.Drawing.Size(532, 23);
			this.buttonClear.TabIndex = 8;
			this.buttonClear.Text = "Clear URL List";
			this.buttonClear.UseVisualStyleBackColor = true;
			this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(12, 297);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(121, 20);
			this.label4.TabIndex = 9;
			this.label4.Text = "Choose Save Directory";
			// 
			// textBoxPath
			// 
			this.textBoxPath.Location = new System.Drawing.Point(12, 320);
			this.textBoxPath.Name = "textBoxPath";
			this.textBoxPath.Size = new System.Drawing.Size(451, 20);
			this.textBoxPath.TabIndex = 10;
			this.textBoxPath.TextChanged += new System.EventHandler(this.textBoxPath_TextChanged);
			// 
			// buttonBrowse
			// 
			this.buttonBrowse.Location = new System.Drawing.Point(469, 320);
			this.buttonBrowse.Name = "buttonBrowse";
			this.buttonBrowse.Size = new System.Drawing.Size(75, 20);
			this.buttonBrowse.TabIndex = 11;
			this.buttonBrowse.Text = "Browse";
			this.buttonBrowse.UseVisualStyleBackColor = true;
			this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
			// 
			// buttonDownload
			// 
			this.buttonDownload.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
			this.buttonDownload.Location = new System.Drawing.Point(12, 346);
			this.buttonDownload.Name = "buttonDownload";
			this.buttonDownload.Size = new System.Drawing.Size(532, 48);
			this.buttonDownload.TabIndex = 12;
			this.buttonDownload.Text = "DOWNLOAD FILES!!!";
			this.buttonDownload.UseVisualStyleBackColor = true;
			this.buttonDownload.Click += new System.EventHandler(this.buttonDownload_Click);
			// 
			// linkLabelSites
			// 
			this.linkLabelSites.Location = new System.Drawing.Point(89, 221);
			this.linkLabelSites.Name = "linkLabelSites";
			this.linkLabelSites.Size = new System.Drawing.Size(151, 21);
			this.linkLabelSites.TabIndex = 13;
			this.linkLabelSites.TabStop = true;
			this.linkLabelSites.Text = "Click for list of supported sites";
			this.linkLabelSites.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelSites_LinkClicked);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(556, 406);
			this.Controls.Add(this.linkLabelSites);
			this.Controls.Add(this.buttonDownload);
			this.Controls.Add(this.buttonBrowse);
			this.Controls.Add(this.textBoxPath);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.buttonClear);
			this.Controls.Add(this.buttonAdd);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textBoxAdd);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.listBoxSelected);
			this.Controls.Add(this.linkLabelYTDL);
			this.Controls.Add(this.linkLabelCain);
			this.Controls.Add(this.label1);
			this.Location = new System.Drawing.Point(15, 15);
			this.Name = "Form1";
			this.Text = "Youtube Downloader GUI";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		private System.Windows.Forms.Button buttonAdd;
		private System.Windows.Forms.Button buttonBrowse;
		private System.Windows.Forms.Button buttonClear;
		private System.Windows.Forms.Button buttonDownload;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.LinkLabel linkLabelCain;
		private System.Windows.Forms.LinkLabel linkLabelSites;
		private System.Windows.Forms.LinkLabel linkLabelYTDL;
		private System.Windows.Forms.ListBox listBoxSelected;
		private System.Windows.Forms.TextBox textBoxAdd;
		private System.Windows.Forms.TextBox textBoxPath;

		#endregion
	}
}