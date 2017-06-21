using System;
using System.Linq;
using System.Windows.Forms;
using System.Security.Principal;
using System.IO;

namespace ProvinceCopier {
    static class Program {

		public static string AppData;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args) {
			AppData = Path.Combine( Application.UserAppDataPath.Substring( 0, Application.UserAppDataPath.LastIndexOf( "\\N/A" ) ), Application.ProductName );

			Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault( false );
			MainUI app = new MainUI();

			for( int i = 0; i < args.Count(); i++ ) {
				 if( args[i].Contains( "savespace" ) ) {
					app.LoadSaveSpaceArg( args[++i] );
				 }
			}

			Application.Run( app );

			HelperClasses.Log.GetInstence().WriteLine( "End of program execution." );
			HelperClasses.Log.GetInstence().Close();
		}

		public static bool isAdminAccess() {
			return ( new WindowsPrincipal( WindowsIdentity.GetCurrent() ).IsInRole( WindowsBuiltInRole.Administrator ));
		}
    }
}
