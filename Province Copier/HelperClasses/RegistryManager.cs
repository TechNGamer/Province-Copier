using System;
using System.Diagnostics;
using System.Windows.Forms;
using Microsoft.Win32;

namespace ProvinceCopier.HelperClasses {
	class RegistryManager {
		public static readonly string OpenWithRegPath = "Applications\\Province Copier.exe\\shell\\open\\command",
			DefaultValue = System.Reflection.Assembly.GetEntryAssembly().Location + " -savespace \"%1\"";

		//Method for checking to see if the default key is there.
		public static bool IsOpenWithThere() {
			string regObject;

			try {
				regObject = Registry.ClassesRoot.OpenSubKey( RegistryManager.OpenWithRegPath ).GetValue( null ).ToString();
			} catch {
				regObject = "";
			}

			return regObject != null && regObject.Equals( DefaultValue );
		}
		//Method for fixing Province Copier's open with menu item.
		public static void FixOpenWith() {
			//Checks to see if program has admin access and if so, create the registry key.
			if( Program.isAdminAccess() ) {
				//Creates the open registry folder and grants it read/write access.
				Registry.ClassesRoot.CreateSubKey( RegistryManager.OpenWithRegPath, RegistryKeyPermissionCheck.ReadWriteSubTree );
				//Open's the default key and set's it's value to DefaultValue.
				Registry.ClassesRoot.OpenSubKey( RegistryManager.OpenWithRegPath, true ).SetValue( "", RegistryManager.DefaultValue );
				//Closes the admin version of Province Copier.
				Environment.Exit( 0 );
			} else {
				//Opens a dialog error response to not being admin.
				DialogResult errorMessageResponse = MessageBox.Show( "The program is not running as an adminastrator and cannot add. Would you like to" +
					" try in admin mode?", "An Error!", MessageBoxButtons.YesNo );
				//Checks to see if the yes button was clicked.
				if( errorMessageResponse == DialogResult.Yes ) {
					//Creates a new Process that will launch as admin.
					Process elivated = new Process();
					elivated.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
					//Get's the location of the current executable.
					elivated.StartInfo.FileName = System.Reflection.Assembly.GetEntryAssembly().Location;
					elivated.StartInfo.UseShellExecute = true;
					elivated.StartInfo.RedirectStandardError = false;
					elivated.StartInfo.RedirectStandardOutput = false;
					//Set's a launch verb as runas to launch as admin.
					elivated.StartInfo.Verb = "runas";
					//Checks to see if the new process started or not.
					if( !elivated.Start() ) {
						MessageBox.Show( "An error occured while trying to launch the program as admin.", "Error", MessageBoxButtons.OK );
					}
				}
			}
		}
	}
}
