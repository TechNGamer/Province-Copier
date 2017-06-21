using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using Microsoft.Win32;
using ProvinceCopier.HelperClasses;

namespace ProvinceCopier {
    public partial class MainUI : Form {

		private delegate void DELEGATE();

		private static string settingsFile = Path.Combine( Program.AppData, "settings.ini" );

		public MainUI() {
            InitializeComponent();

			if( !RegistryManager.IsOpenWithThere() ) { 
				DialogResult messageResponse = MessageBox.Show( "Province Copier is not found in the registry. Would you like to add it to the Open With menu?",
					"Open With Menu Entry Missing", MessageBoxButtons.YesNo );
				if(messageResponse == DialogResult.Yes ) {
					RegistryManager.FixOpenWith();
				}
			}
        }

		//ProgressBar Helper (Probably should make this a Helper Class)

		public void ChangeProgressBarState( ProgressBarStyle style, ProgressBar progressBar ) {
#if DEBUG
			Log.GetInstence().WriteLine( "ChangeProgressBarState method was activated." );
#endif
			progressBar.Style = style;
		}

		public void SetMaxNumber( int max, ProgressBar progressBar ) {
#if DEBUG
			Log.GetInstence().WriteLine( "SetMaxNumber method was activated. Max number set to " + max );
#endif
			progressBar.Maximum = max;
		}

		public void IncrementPercentDone(int done, ProgressBar progressBar ) {
#if DEBUG
			Log.GetInstence().WriteLine( "IncrementPercentDone method was activated. Increment was " + done + " on " + progressBar.Name
				+ "\nPercent done is now: "	+ ( ( ( float ) transferFileProgressBar.Value / transferFileProgressBar.Maximum ) * 100 )
				.ToString( "###.##" ) + "%" );
#endif
			progressBar.Increment( done );
			//PercentLabel.Text = (( (float)progressBar.Value / progressBar.Maximum ) * 100).ToString("###.##") + "%";
		}

		//Start of the Utilities Tab

		public void LoadSaveSpaceArg(string path) {
#if DEBUG
			Log.GetInstence().WriteLine( "LoadSaveSpaceArg method was activated." );
#endif
			SaveSpace.LoadSaveSpace( path, euivInstallBar, provinceToCopy, userCopyTo );
		}

		private void regularSaveSpaceButton_Click( object sender, EventArgs e ) {
#if DEBUG
			Log.GetInstence().WriteLine( "regularSaveSpaceButton method was activated." );
#endif
			DialogResult result = saveSaveSpaceFileDialog.ShowDialog();

			if( result == DialogResult.OK ) {
				SaveSpace.CreateSaveSpace( false, saveSaveSpaceFileDialog.FileName, euivInstallBar, provinceToCopy, userCopyTo );
			}
		}

		private void universalSaveSpaceButton_Click( object sender, EventArgs e ) {
#if DEBUG
			Log.GetInstence().WriteLine( "universalSaveSpaceButton method was activated." );
#endif
			DialogResult result = saveSaveSpaceFileDialog.ShowDialog();

			if( result == DialogResult.OK ) {
				SaveSpace.CreateSaveSpace( true, saveSaveSpaceFileDialog.FileName, euivInstallBar, provinceToCopy, userCopyTo );
			}
		}

		private void openSaveSpace_Click( object sender, EventArgs e ) {
#if DEBUG
			Log.GetInstence().WriteLine( "loadSaveSpace method was activated." );
#endif
			DialogResult result = openSaveSpaceDialog.ShowDialog();

			if( result == DialogResult.OK ) {
				SaveSpace.LoadSaveSpace( openSaveSpaceDialog.FileName, euivInstallBar, provinceToCopy, userCopyTo );
			}
		}

		private void aboutThisProgramButton_Click( object sender, EventArgs e ) {
#if DEBUG
			Log.GetInstence().WriteLine( "aboutThisProgramButton was activated." );
#endif
			UIClasses.AboutPopup about = new UIClasses.AboutPopup();
			about.ShowDialog();
		}

		private void bugAndFeaturesButton_Click( object sender, EventArgs e ) {
#if DEBUG
			Log.GetInstence().WriteLine( "bugsAndFeaturesButton method was activated." );
			System.Threading.Thread.Sleep( 250 );
#endif
			Process.Start( "http://goo.gl/forms/5sTjdB29GTMSjXUr1" );
		}

		//End of Utilities Tab and start of the Transfer Tab

		private void copyToDialogOpen_Click( object sender, EventArgs e ) {
#if DEBUG
			Log.GetInstence().WriteLine( "copyToDialogOpen method was activated." );
#endif
			SetLocBar( false, userCopyTo );
        }

        private void euivLocationDialogOpen_Click( object sender, EventArgs e ) {
#if DEBUG
			Log.GetInstence().WriteLine( "euivLocationDialogOpen method was activated." );
#endif
			SetLocBar( true, euivInstallBar );
        }

        private void SetLocBar( bool isInstallDir, TextBox locBar ) {
#if DEBUG
			Log.GetInstence().WriteLine( "SetLocBar method was activated." );
#endif
			DialogResult result = FolderOpenDialog.ShowDialog();

            if( result == DialogResult.OK ) {
                locBar.Text = FolderOpenDialog.SelectedPath;

                if( isInstallDir ) {
                    locBar.Text = Path.Combine( locBar.Text, "history", "provinces" );
                    FolderOpenDialog.SelectedPath = locBar.Text;
                }
            }
        }

		private void startButton_Click( object sender, EventArgs e ) {
#if DEBUG
			Log.GetInstence().WriteLine( "startButton method was activated." );
#endif
			if( Directory.Exists( euivInstallBar.Text ) ) {
				ChangeProgressBarState( ProgressBarStyle.Marquee, transferFileProgressBar );
				Invoke( new Action( SetUpTransfer ) );
			} else {
				MessageBox.Show( "Could not find " + euivInstallBar.Text + ".\nPlease make sure that is a valid path and try again.", "Invalid path",
					MessageBoxButtons.OK );
			}
		}

		private void SetUpTransfer() {
#if DEBUG
			Log.GetInstence().WriteLine( "SetUpTransfer method was activated." );
#endif
			Transfer transfer = new Transfer( euivInstallBar.Text, userCopyTo.Text, provinceToCopy.Text.Split( ' ' ), transferFileProgressBar );
			transfer.StartTransfer( this );
		}

		//End of Transfer Tab and start of Comparer Tab

		private void OpenFile(bool is2 ) {
#if DEBUG
			Log.GetInstence().WriteLine( "OpenFile has been called" );
#endif
			FileOpenDialog.Multiselect = false;
			DialogResult result = FileOpenDialog.ShowDialog();

			if(result == DialogResult.OK ) {
				if( is2 ) {
					File2Loc.Text = FileOpenDialog.FileName;
				} else {
					File1Loc.Text = FileOpenDialog.FileName;
				}
			}
		}

		private void OpenFile1_Click( object sender, EventArgs e ) {
			OpenFile( false );
		}

		private void OpenFile2_Click( object sender, EventArgs e ) {
			OpenFile( true );
		}

		private void StartComparing(object sender, EventArgs e ) {
			FileCompare comparer = new FileCompare( File1Loc.Text, File2Loc.Text, OutputBox, ComparerProgressBar, this );
			comparer.StartComparing();
		}
	}
}