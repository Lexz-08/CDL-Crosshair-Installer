using CometUI;
using System;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Windows.Forms;

namespace CDL_Crosshair_Installer
{
	public partial class ProgramPrompt : CometForm
	{
		public ProgramPrompt()
		{
			InitializeComponent();
		}

		private bool confirmed = false;

		private void ExtractResource(string Resource, string File)
		{
			using (Stream s = Assembly.GetExecutingAssembly().GetManifestResourceStream(Resource))
			using (FileStream fs = new FileStream(File, FileMode.OpenOrCreate))
			using (BinaryReader br = new BinaryReader(s))
			using (BinaryWriter bw = new BinaryWriter(fs))
				bw.Write(br.ReadBytes((int)s.Length));
		}

		protected override void OnFormClosing(FormClosingEventArgs e)
		{
			base.OnFormClosing(e);

			if (!confirmed)
			{
				DialogResult result = MessageBox.Show("Cancel path selection?\n\nIf you cancel this prompt, the program will not continue.", "Cancel Path Selection?",
					MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

				if (result == DialogResult.No)
					e.Cancel = true;
				else Application.Exit();
			}
		}

		private void CancelPrompt(object sender, EventArgs e)
		{
			Close();
		}

		private void ConfirmPrompt(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(txtProgramPath.Folder))
			{
				MessageBox.Show("No CDL path was provided so the program will not continue.", "No Path Selected",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			bool exe1 = File.Exists($"{txtProgramPath.Folder}\\CustomDesktopLogo.exe");
			bool exe2 = File.Exists($"{txtProgramPath.Folder}\\Custom Crosshair.exe");
			bool systemFld = Directory.Exists($"{txtProgramPath.Folder}\\System");
			bool imagesFld = Directory.Exists($"{txtProgramPath.Folder}\\System\\Images");
			bool languageFld = Directory.Exists($"{txtProgramPath.Folder}\\System\\Languages");
			bool settingsFld = Directory.Exists($"{txtProgramPath.Folder}\\System\\Settings");

			if (!exe1 && !exe2)
			{
				MessageBox.Show("Path chosen does not contain the CustomDesktopLogo program.", "Program Not Found",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			else if (exe1 || exe2)
			{
				if (!systemFld)
				{
					MessageBox.Show("Path chosen does not contain the 'System' folder.", "'System' Folder Not Found",
						MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				else if (systemFld)
				{
					if (!imagesFld)
					{
						ExtractResource("CDL_Crosshair_Installer.CDL_Files.Images.zip", $"{txtProgramPath.Folder}\\System\\Images.zip");
						ZipFile.ExtractToDirectory($"{txtProgramPath.Folder}\\System\\Images.zip", $"{txtProgramPath.Folder}\\System");
						File.Delete($"{txtProgramPath.Folder}\\System\\Images.zip");
					}

					if (!languageFld)
					{
						Directory.CreateDirectory($"{txtProgramPath.Folder}\\System\\Language");
						ExtractResource("CDL_Crosshair_Installer.CDL_Files.English.ini", $"{txtProgramPath.Folder}\\System\\Language\\English.ini");
					}

					if (!settingsFld)
					{
						Directory.CreateDirectory($"{txtProgramPath.Folder}\\System\\Settings");
						ExtractResource("CDL_Crosshair_Installer.CDL_Files.Config.ini", $"{txtProgramPath.Folder}\\System\\Settings\\Config.ini");
					}
				}
			}

			confirmed = true;
			Close();
		}

		public string GetProgramPath()
		{
			ShowDialog();

			return txtProgramPath.Folder;
		}
	}
}
