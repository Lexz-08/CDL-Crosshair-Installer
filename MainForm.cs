using CometUI;
using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.IO.Compression;
using System.Windows.Forms;

namespace CDL_Crosshair_Installer
{
	public partial class MainForm : CometForm
	{
		public MainForm()
		{
			InitializeComponent();

			if (!File.Exists($"{Application.StartupPath}\\config.json"))
			{
				progPath = new ProgramPrompt().GetProgramPath();
				File.WriteAllText($"{Application.StartupPath}\\config.json", $"{{\n\t\"cdl_path\": \"{progPath.Replace(@"\", @"\\")}\"\n}}");
			}
			else
			{
				JObject json = JObject.Parse(File.ReadAllText($"{Application.StartupPath}\\config.json"));

				if (!json.ContainsKey("cdl_path"))
				{
					MessageBox.Show($"JSON config file '{Application.StartupPath}\\config.json' has invalid information.", "JSON File Invalid",
						MessageBoxButtons.OK, MessageBoxIcon.Error);
					Close();
				}
				else progPath = json.Value<string>("cdl_path");
			}

			string[] args = Environment.GetCommandLineArgs();
			if (args.Length > 1)
			{
				string set = args[1];
				string folder = $"{progPath}\\System\\Images\\{Path.GetFileNameWithoutExtension(set)}";

				Directory.CreateDirectory(folder);
				ZipFile.ExtractToDirectory(set, folder);

				if (args.Length == 3 && args[2] == "-clean")
					File.Delete(set);
			}
		}

		private string progPath = string.Empty;

		private void InstallSet(object sender, EventArgs e)
		{
			string set = txtImageSet.File;
			string folder = $"{progPath}\\System\\Images\\{Path.GetFileNameWithoutExtension(set)}";

			Directory.CreateDirectory(folder);
			ZipFile.ExtractToDirectory(set, folder);

			if (chckDeleteOriginalSet.Checked)
				File.Delete(set);
		}

		private void ToggleCheckbox(object sender, EventArgs e)
		{
			chckDeleteOriginalSet.Checked = !chckDeleteOriginalSet.Checked;
		}
	}
}
