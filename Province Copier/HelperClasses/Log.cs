using System;
using System.IO;
using System.Collections;
using System.Windows.Forms;

namespace ProvinceCopier.HelperClasses {
	class Log {

		private static Log instence;

		public static Log GetInstence() {
			if(instence == null ) {
				instence = new Log();
			}

			return instence;
		}

		private StreamWriter LogFile;

		private string[] LogFiles = new string[255];
		private FileInfo[] LogFilesInfo = new FileInfo[255];
		private UInt16 index = 0;
		private bool errorMessageDisplayed = false;

		public Log() {

			if( !Directory.Exists( Program.AppData ) ) {
				Directory.CreateDirectory( Program.AppData );
			}

			for( uint i = 0; i < 255; i++ ) {
				LogFiles[i] = Path.Combine( Program.AppData, i + ".log" );

				if( File.Exists( LogFiles[i] ) ) {
					File.Delete( LogFiles[i] );
					//File.Create( LogFiles[i] );
				}

				LogFilesInfo[i] = new FileInfo( LogFiles[i] );
			}

			LogFile = File.CreateText( LogFiles[0] );
			LogFile.AutoFlush = true;
		}

		public void Write( string text ) {
			if( index + 1 > UInt16.MaxValue ) {
				if( !errorMessageDisplayed ) {
					MessageBox.Show( "Logging has been disabled." );
				}
				return;
			}

			if( LogFilesInfo[index].Length > 267386880 ) {
				LogFile.WriteLine( "End of log file " + index + ". Move to log file " + ( index + 1 ) + "." );
				LogFile = File.CreateText( LogFiles[++index] );
			}

			LogFile.Write( DateTime.Now.ToString( "yyyy-MM-dd HH:mm:sszzz" ) + ": " + text );
			LogFilesInfo[index].Refresh();
		}

		public void Write( byte number ) {
			Write( number.ToString() );
		}

		public void Write( sbyte number ) {
			Write( number.ToString() );
		}

		public void Write( ushort number ) {
			Write( number.ToString() );
		}

		public void Write( short number ) {
			Write( number.ToString() );
		}

		public void Write( uint number ) {
			Write( number.ToString() );
		}

		public void Write( int number ) {
			Write( number.ToString() );
		}

		public void Write( ulong number ) {
			Write( number.ToString() );
		}

		public void Write( long number ) {
			Write( number.ToString() );
		}

		public void Write( float number ) {
			Write( number.ToString() );
		}

		public void Write( double number ) {
			Write( number.ToString() );
		}

		public void Write( decimal number ) {
			Write( number.ToString() );
		}

		public void Write( char charector ) {
			Write( charector.ToString() );
		}

		public void Write( bool boolean ) {
			Write( boolean.ToString() );
		}

		public void WriteLine( string text ) {
			Write( text + "\n" );
		}

		public void WriteLine( byte number ) {
			WriteLine( number.ToString() );
		}

		public void WriteLine( sbyte number ) {
			WriteLine( number.ToString() );
		}

		public void WriteLine( ushort number ) {
			WriteLine( number.ToString() );
		}

		public void WriteLine( short number ) {
			WriteLine( number.ToString() );
		}

		public void WriteLine( uint number ) {
			WriteLine( number.ToString() );
		}

		public void WriteLine( int number ) {
			WriteLine( number.ToString() );
		}

		public void WriteLine( ulong number ) {
			WriteLine( number.ToString() );
		}

		public void WriteLine( long number ) {
			WriteLine( number.ToString() );
		}

		public void WriteLine( float number ) {
			WriteLine( number.ToString() );
		}

		public void WriteLine( double number ) {
			WriteLine( number.ToString() );
		}

		public void WriteLine( decimal number ) {
			WriteLine( number.ToString() );
		}

		public void WriteLine( char charector ) {
			WriteLine( charector.ToString() );
		}

		public void WriteLine( bool boolean ) {
			WriteLine( boolean.ToString() );
		}

		public void Close() {
			LogFile.Close();
		}

	}
}