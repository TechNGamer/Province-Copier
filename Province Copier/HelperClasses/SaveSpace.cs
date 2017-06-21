using System;
using System.Windows.Forms;
using System.IO;

namespace ProvinceCopier.HelperClasses {
	static class SaveSpace {

		public static void LoadSaveSpace( string path, TextBox installDir, RichTextBox provinceToCopy, TextBox copyTo ) {
			try {
				foreach( string line in File.ReadLines( path ) ) {
					string[] split = line.Split( '=' );
					if( split[0].ToLower().Equals( "installdir" ) ) {
						installDir.Text = split[1];
					} else if( split[0].ToLower().Equals( "provnumbers" ) ) {
						provinceToCopy.Text = split[1];
					} else if( split[0].ToLower().Equals( "copydir" ) ) {
						copyTo.Text = split[1];
					}
				}
			} catch ( DirectoryNotFoundException e ) {
#if DEBUG
				Console.Error.Write( e.Message + "\n" + e.StackTrace );
#endif
				MessageBox.Show( "An error occured while loading up the .savespace.\nMessage is " + e.Message );
			}
		}

		public static void CreateSaveSpace(bool isUniversal, string path, string installDirText, string provinceToCopyText, string copyToText ) {
			if( File.Exists( path ) ) {
				File.Delete( path );
			}

			if( isUniversal ) {
				File.WriteAllText( path, "provNumbers=" + provinceToCopyText );
			} else {
				string[] strings = { "installDir=" + installDirText, "provNumbers=" + provinceToCopyText,
					"copyDir=" + copyToText };
				File.WriteAllLines( path, strings );
			}
		}

		public static void CreateSaveSpace( bool isUniversal, string path, TextBox installDir, RichTextBox provinceToCopy, TextBox copyTo ) {
			CreateSaveSpace( isUniversal, path, installDir.Text, provinceToCopy.Text, copyTo.Text );
		}
	}
}