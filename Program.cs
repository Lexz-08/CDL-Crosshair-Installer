using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace CDL_Crosshair_Installer
{
	internal static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			AppDomain.CurrentDomain.AssemblyResolve += new ResolveEventHandler(CurrentDomain_AssemblyResolve);

			MainForm form = new MainForm();
			
			if (!form.IsDisposed)
				Application.Run(form);
		}

		private static Assembly CurrentDomain_AssemblyResolve(object sender, ResolveEventArgs e)
		{
			if (e.Name.Contains("resources"))
				return e.RequestingAssembly;

			using (Stream s = Assembly.GetExecutingAssembly().GetManifestResourceStream($"CDL_Crosshair_Installer.Libraries.{e.Name.Split(',')[0]}.dll"))
			{
				byte[] buffer = new byte[s.Length];
				s.Read(buffer, 0, buffer.Length);

				return Assembly.Load(buffer);
			}
		}
	}
}
