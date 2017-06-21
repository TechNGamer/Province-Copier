using System.Text;
using System.IO;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Diagnostics;

namespace ProvinceCopier.HelperClasses {
	class Transfer {

		private string copyTo;
		private List<string> installedProvinceFiles;
		private List<int> provinceNumbers;
		private Log log;
		private ProgressBar progressBar;

		public Transfer( string installDir, string copyTo, string[] provinceNumbers, ProgressBar progressBar ) {
			log = Log.GetInstence();
			this.copyTo = copyTo;
			this.progressBar = progressBar;
			string[] temp = Directory.GetFiles( installDir );

			this.provinceNumbers = new List<int>();
			installedProvinceFiles = new List<string>( temp );

			for( int i = 0; i < provinceNumbers.Length; i++ ) {
				if( provinceNumbers[i].Contains( "-" ) ) {
					string[] numbers = provinceNumbers[i].Split( '-' );
					int start, end, iterator;
					if( int.TryParse( numbers[0].Trim(), out start ) && int.TryParse( numbers[1].Trim(), out end ) ) {
						iterator = start;
						while( iterator <= end ) {
							this.provinceNumbers.Add( iterator );
							iterator++;
						}
					}
				} else {
					int tempInt;
					if( int.TryParse( provinceNumbers[i].Trim(), out tempInt ) ) {
						this.provinceNumbers.Add( tempInt );
					}
				}
			}
			
			for( int i = 0; i < this.provinceNumbers.Count; i++ ) {
				for( int j = i + 1; j < this.provinceNumbers.Count; j++ ) {
					Application.DoEvents();
					log.WriteLine( "Province Num from outer for loop: " + this.provinceNumbers[i] + " outer loop i = " + i +
							" Province number from inner for loop: " + this.provinceNumbers[j] + " inner loop j = " + j + "." );
					if( this.provinceNumbers[i] == this.provinceNumbers[j] ) {
						log.WriteLine( "Their the same." );
						this.provinceNumbers.RemoveAt( j );
						j--;
					}
				}
			}

			this.provinceNumbers.Sort();
			installedProvinceFiles.Sort( new CompareFiles() );

			StringBuilder builder = new StringBuilder();

			builder.AppendLine( "List of everything in installedProvinceFiles:" );
			foreach( string installedProvNumber in installedProvinceFiles ) {
				Application.DoEvents();
				builder.Append( CompareFiles.IsolateFileNumber( installedProvNumber ) ).Append( " " );
			}
			builder.Append( "\nEverything in this.provinceNumbers:\n" );
			foreach( int num in this.provinceNumbers ) {
				Application.DoEvents();
				builder.Append( num ).Append( " " );
			}

			log.Write( builder.ToString() );
		}

		public void StartTransfer(MainUI mainUI) {
			Stopwatch stopwatch = new Stopwatch();

			mainUI.ChangeProgressBarState( ProgressBarStyle.Marquee, progressBar );

			installedProvinceFiles.Sort( new CompareFiles() );
			provinceNumbers.Sort();

			mainUI.SetMaxNumber( installedProvinceFiles.Count, progressBar );
			
			if( !Directory.Exists( copyTo ) ) {
				Directory.CreateDirectory( copyTo );
			}

			log.WriteLine( copyTo );

			mainUI.ChangeProgressBarState( ProgressBarStyle.Continuous, progressBar );
			stopwatch.Start();
			for( int i = 0; i < installedProvinceFiles.Count; i++ ) {
				Application.DoEvents();
				int installedProvinceFileNumber = CompareFiles.IsolateFileNumber( installedProvinceFiles[i] );

				for( int j = 0; j < provinceNumbers.Count; j++ ) {
					Application.DoEvents();
					log.WriteLine( "Comparing " + provinceNumbers[j] + " with " + installedProvinceFileNumber + " and it's " + (installedProvinceFileNumber == provinceNumbers[j]) );
					if( installedProvinceFileNumber == provinceNumbers[j] ) {
						string newFile = Path.Combine( copyTo, installedProvinceFiles[i].Substring( installedProvinceFiles[i].LastIndexOf( '\\' ) + 1 ) );
						log.WriteLine( newFile );
						if( File.Exists( newFile ) ) {
							File.Delete( newFile );
						}

						Application.DoEvents();

						File.Copy( installedProvinceFiles[i], newFile );

						installedProvinceFiles.Remove( installedProvinceFiles[i] );

						int tempHold = provinceNumbers[j];
						for( int k = 0; k < provinceNumbers.Count; k++ ) {
							Application.DoEvents();
							if(provinceNumbers[k] == tempHold ) {
								provinceNumbers.RemoveAt( k );
							}
						}
						i--;
						break;
					} else if( provinceNumbers[j] > installedProvinceFileNumber ) {
						break;
					}
				}

				mainUI.IncrementPercentDone( 1, progressBar );
			}

			if( provinceNumbers.Count != 0 ) {
				StringBuilder builder = new StringBuilder( "Hello User, there was a problem, this file does not appear to be in the install path you provided.\n" +
					"Please launch Steam, right click on Europea Universallies IV and click properties, then go to Local Files, and then click \"Virify" +
					" integraty of game files...\".\nIf it comes back with nothing/1 file missing, then please have a look for yourself.\nIf you cannot" +
					" figure it out, please submit a bug report.\nThe following provinces were not found at all:\n" );
				foreach( int provinceNumber in provinceNumbers ) {
					builder.Append( provinceNumber + " " );
				}

				builder.Append( "\nPlease note, check to see if their aren't any duplicant numbers in the list," +
					" if not and the province does exist in their then please contact the developer." );

				StreamWriter writer = File.CreateText( Path.Combine( copyTo, "1.)IMPORTANT! README.txt" ) );
				writer.Write( builder.ToString() );
				writer.Flush();
				writer.Close();

				MessageBox.Show( "A problem has occured. Please read 1.)IMPORTANT! README.txt located at \"" + copyTo + "\"." );
			}

			stopwatch.Stop();
			log.WriteLine( stopwatch.ElapsedMilliseconds + " milliseconds or " + stopwatch.ElapsedMilliseconds / 1000f + " seconds." );
		}
	}

	public class CompareFiles : Comparer<string> {

		public override int Compare( string x, string y ) {
			int temp1 = IsolateFileNumber( x.Trim() ), temp2 = IsolateFileNumber( y.Trim() );
			return temp1.CompareTo( temp2 );
		}

		public static int IsolateFileNumber( string file ) {
			file = file.Substring( file.LastIndexOf( "\\" ) + 1 );
			int temp;
			int endSubString = file.IndexOf( "-" );
			if(endSubString == -1 ) {
				endSubString = file.IndexOf( " " );
			}
			if( int.TryParse( file.Substring( 0, endSubString ).Trim(), out temp ) || int.TryParse( file.Substring( 0, endSubString ), out temp) ) { 
				return temp;
			}

			return -1;
		}
	}
}