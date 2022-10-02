namespace CDL_Crosshair_Installer
{
	partial class ProgramPrompt
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProgramPrompt));
			this.lblWarning = new CometUI.CometLabel();
			this.lblProgramPath = new CometUI.CometLabel();
			this.txtProgramPath = new CometUI.CometFolderInput();
			this.btnConfirmPath = new CometUI.CometRoundFlatButton();
			this.btnCancel = new CometUI.CometRoundFlatButton();
			this.SuspendLayout();
			// 
			// lblWarning
			// 
			this.lblWarning.AutoSize = true;
			this.lblWarning.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
			this.lblWarning.Font = new System.Drawing.Font("Open Sans", 10F);
			this.lblWarning.ForeColor = System.Drawing.Color.Goldenrod;
			this.lblWarning.Location = new System.Drawing.Point(12, 47);
			this.lblWarning.Name = "lblWarning";
			this.lblWarning.Size = new System.Drawing.Size(301, 38);
			this.lblWarning.TabIndex = 0;
			this.lblWarning.Text = "The path for CustomDesktopLogo is not set.\r\nPlease specify the path before contin" +
    "uing...";
			// 
			// lblProgramPath
			// 
			this.lblProgramPath.AutoSize = true;
			this.lblProgramPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
			this.lblProgramPath.Font = new System.Drawing.Font("Open Sans", 10F);
			this.lblProgramPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
			this.lblProgramPath.Location = new System.Drawing.Point(12, 102);
			this.lblProgramPath.Name = "lblProgramPath";
			this.lblProgramPath.Size = new System.Drawing.Size(43, 19);
			this.lblProgramPath.TabIndex = 1;
			this.lblProgramPath.Text = "Path:";
			// 
			// txtProgramPath
			// 
			this.txtProgramPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtProgramPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
			this.txtProgramPath.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
			this.txtProgramPath.Cursor = System.Windows.Forms.Cursors.Default;
			this.txtProgramPath.DialogTitle = "Please choose a folder...";
			this.txtProgramPath.FileChooserColor = System.Drawing.Color.DodgerBlue;
			this.txtProgramPath.FocusedBorderColor = System.Drawing.Color.DodgerBlue;
			this.txtProgramPath.Font = new System.Drawing.Font("Open Sans", 10F);
			this.txtProgramPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
			this.txtProgramPath.Location = new System.Drawing.Point(58, 98);
			this.txtProgramPath.Name = "txtProgramPath";
			this.txtProgramPath.RootFolder = System.Environment.SpecialFolder.Desktop;
			this.txtProgramPath.Size = new System.Drawing.Size(256, 27);
			this.txtProgramPath.TabIndex = 2;
			this.txtProgramPath.UnderlineBorder = false;
			// 
			// btnConfirmPath
			// 
			this.btnConfirmPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnConfirmPath.BorderRadius = 4;
			this.btnConfirmPath.BorderWidth = 2;
			this.btnConfirmPath.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnConfirmPath.Font = new System.Drawing.Font("Open Sans", 10F);
			this.btnConfirmPath.ForeColor = System.Drawing.Color.SeaGreen;
			this.btnConfirmPath.Location = new System.Drawing.Point(213, 140);
			this.btnConfirmPath.Name = "btnConfirmPath";
			this.btnConfirmPath.Size = new System.Drawing.Size(101, 31);
			this.btnConfirmPath.TabIndex = 3;
			this.btnConfirmPath.Text = "Confirm Path";
			this.btnConfirmPath.Click += new System.EventHandler(this.ConfirmPrompt);
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancel.BorderRadius = 4;
			this.btnCancel.BorderWidth = 2;
			this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnCancel.Font = new System.Drawing.Font("Open Sans", 10F);
			this.btnCancel.ForeColor = System.Drawing.Color.Coral;
			this.btnCancel.Location = new System.Drawing.Point(149, 140);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(58, 31);
			this.btnCancel.TabIndex = 4;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.Click += new System.EventHandler(this.CancelPrompt);
			// 
			// ProgramPrompt
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(326, 181);
			this.CloseColor = System.Drawing.Color.SeaGreen;
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnConfirmPath);
			this.Controls.Add(this.txtProgramPath);
			this.Controls.Add(this.lblProgramPath);
			this.Controls.Add(this.lblWarning);
			this.Font = new System.Drawing.Font("Open Sans", 10F);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MaximizeColor = System.Drawing.Color.SeaGreen;
			this.MinimizeColor = System.Drawing.Color.SeaGreen;
			this.MinimumSize = new System.Drawing.Size(199, 105);
			this.Name = "ProgramPrompt";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Specify CDL path...";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private CometUI.CometLabel lblWarning;
		private CometUI.CometLabel lblProgramPath;
		private CometUI.CometFolderInput txtProgramPath;
		private CometUI.CometRoundFlatButton btnConfirmPath;
		private CometUI.CometRoundFlatButton btnCancel;
	}
}