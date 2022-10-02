namespace CDL_Crosshair_Installer
{
	partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.lblImageSet = new CometUI.CometLabel();
			this.txtImageSet = new CometUI.CometFileInput();
			this.cometRoundFlatGradientButton1 = new CometUI.CometRoundFlatGradientButton();
			this.chckDeleteOriginalSet = new CometUI.CometToggle();
			this.lblDeleteOriginalSet = new CometUI.CometLabel();
			this.SuspendLayout();
			// 
			// lblImageSet
			// 
			this.lblImageSet.AutoSize = true;
			this.lblImageSet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
			this.lblImageSet.Font = new System.Drawing.Font("Open Sans", 10F);
			this.lblImageSet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
			this.lblImageSet.Location = new System.Drawing.Point(12, 49);
			this.lblImageSet.Name = "lblImageSet";
			this.lblImageSet.Size = new System.Drawing.Size(79, 19);
			this.lblImageSet.TabIndex = 0;
			this.lblImageSet.Text = "Image Set:";
			// 
			// txtImageSet
			// 
			this.txtImageSet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtImageSet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
			this.txtImageSet.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
			this.txtImageSet.Cursor = System.Windows.Forms.Cursors.Default;
			this.txtImageSet.DefaultFilter = 1;
			this.txtImageSet.DialogTitle = "Please choose a file to open...";
			this.txtImageSet.FileChooserColor = System.Drawing.Color.DodgerBlue;
			this.txtImageSet.FileFilter = "All Files|*.*";
			this.txtImageSet.FocusedBorderColor = System.Drawing.Color.DodgerBlue;
			this.txtImageSet.Font = new System.Drawing.Font("Open Sans", 10F);
			this.txtImageSet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
			this.txtImageSet.InputType = CometUI.CometFileInputType.OpenFile;
			this.txtImageSet.Location = new System.Drawing.Point(97, 45);
			this.txtImageSet.Name = "txtImageSet";
			this.txtImageSet.Size = new System.Drawing.Size(264, 27);
			this.txtImageSet.TabIndex = 1;
			this.txtImageSet.UnderlineBorder = false;
			// 
			// cometRoundFlatGradientButton1
			// 
			this.cometRoundFlatGradientButton1.BorderRadius = 4;
			this.cometRoundFlatGradientButton1.BorderWidth = 2;
			this.cometRoundFlatGradientButton1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.cometRoundFlatGradientButton1.Font = new System.Drawing.Font("Open Sans", 10F);
			this.cometRoundFlatGradientButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
			this.cometRoundFlatGradientButton1.GradientAngle = 45F;
			this.cometRoundFlatGradientButton1.GradientColor1 = System.Drawing.Color.SteelBlue;
			this.cometRoundFlatGradientButton1.GradientColor2 = System.Drawing.Color.Coral;
			this.cometRoundFlatGradientButton1.Location = new System.Drawing.Point(239, 85);
			this.cometRoundFlatGradientButton1.Name = "cometRoundFlatGradientButton1";
			this.cometRoundFlatGradientButton1.Size = new System.Drawing.Size(122, 31);
			this.cometRoundFlatGradientButton1.TabIndex = 2;
			this.cometRoundFlatGradientButton1.Text = "Install Image Set";
			this.cometRoundFlatGradientButton1.Click += new System.EventHandler(this.InstallSet);
			// 
			// chckDeleteOriginalSet
			// 
			this.chckDeleteOriginalSet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
			this.chckDeleteOriginalSet.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
			this.chckDeleteOriginalSet.CheckedColor = System.Drawing.Color.DodgerBlue;
			this.chckDeleteOriginalSet.Cursor = System.Windows.Forms.Cursors.Hand;
			this.chckDeleteOriginalSet.Location = new System.Drawing.Point(19, 87);
			this.chckDeleteOriginalSet.Name = "chckDeleteOriginalSet";
			this.chckDeleteOriginalSet.Size = new System.Drawing.Size(37, 26);
			this.chckDeleteOriginalSet.TabIndex = 3;
			this.chckDeleteOriginalSet.UncheckedColor = System.Drawing.Color.Coral;
			this.chckDeleteOriginalSet.UseVisualStyleBackColor = false;
			// 
			// lblDeleteOriginalSet
			// 
			this.lblDeleteOriginalSet.AutoSize = true;
			this.lblDeleteOriginalSet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
			this.lblDeleteOriginalSet.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.lblDeleteOriginalSet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
			this.lblDeleteOriginalSet.Location = new System.Drawing.Point(59, 90);
			this.lblDeleteOriginalSet.Name = "lblDeleteOriginalSet";
			this.lblDeleteOriginalSet.Size = new System.Drawing.Size(123, 19);
			this.lblDeleteOriginalSet.TabIndex = 4;
			this.lblDeleteOriginalSet.Text = "Delete Original Set";
			this.lblDeleteOriginalSet.Click += new System.EventHandler(this.ToggleCheckbox);
			// 
			// MainForm
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.CanResize = false;
			this.ClientSize = new System.Drawing.Size(373, 129);
			this.CloseColor = System.Drawing.Color.SeaGreen;
			this.Controls.Add(this.lblDeleteOriginalSet);
			this.Controls.Add(this.chckDeleteOriginalSet);
			this.Controls.Add(this.cometRoundFlatGradientButton1);
			this.Controls.Add(this.txtImageSet);
			this.Controls.Add(this.lblImageSet);
			this.Font = new System.Drawing.Font("Open Sans", 10F);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.MaximizeColor = System.Drawing.Color.SeaGreen;
			this.MinimizeColor = System.Drawing.Color.SeaGreen;
			this.MinimumSize = new System.Drawing.Size(233, 129);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "CDL Crosshair Installer";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private CometUI.CometLabel lblImageSet;
		private CometUI.CometFileInput txtImageSet;
		private CometUI.CometRoundFlatGradientButton cometRoundFlatGradientButton1;
		private CometUI.CometToggle chckDeleteOriginalSet;
		private CometUI.CometLabel lblDeleteOriginalSet;
	}
}

