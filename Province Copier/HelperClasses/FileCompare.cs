using System;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.IO;

namespace ProvinceCopier.HelperClasses {
	class FileCompare {

		private string File1Loc, File2Loc, File1Name, File2Name;
		private RichTextBox Output;
		private ProgressBar progressBar;
		private MainUI mainUI;

		public FileCompare( string File1Loc, string File2Loc, RichTextBox Output, ProgressBar progressBar, MainUI mainUI ) {
			this.File1Loc = File1Loc;
			File1Name = File1Loc.Substring( File1Loc.LastIndexOf( "\\" ) + 1 );
			this.File2Loc = File2Loc;
			File2Name = File2Loc.Substring( File2Loc.LastIndexOf( "\\" ) + 1 );
			this.Output = Output;
			this.progressBar = progressBar;
			this.mainUI = mainUI;
#if DEBUG
			Log.GetInstence().WriteLine( $"string File1Loc = {this.File1Loc}, File1Name = {File1Name}, string File2Loc =" +
				$" {this.File2Loc}, string File2Name = {File2Name}, this.Output = {this.Output.Name}, this.progressBar =" +
				$" {progressBar.Name}" );
#endif
		}

		public void StartComparing() {
			mainUI.ChangeProgressBarState( ProgressBarStyle.Marquee, progressBar );

			//ArrayList are used to store all the lines later on.
			ArrayList TextList1 = new ArrayList(), TextList2 = new ArrayList();

			//This method splits the text in the files and puts them into the ArrayList.
			AddStringToList( File.ReadAllText( File1Loc ), TextList1 );
			AddStringToList( File.ReadAllText( File2Loc ), TextList2 );

			mainUI.ChangeProgressBarState( ProgressBarStyle.Continuous, progressBar );

			//StringBuilder is used for it's .Append method.
			StringBuilder ForOutputBox = new StringBuilder( $"Differences in {File1Name} and {File2Name}:" );

			//To see which file is the shorted aand to use it as the length.
			int progressLength = TextList1.Count < TextList2.Count ? TextList1.Count : TextList2.Count;

			mainUI.SetMaxNumber( progressLength, progressBar );

			//To keep track of the line it's on.
			int line = 1;

			//While loop used since a for loop would have to be constantly reset to 0.
			while( TextList1.Count != 0 && TextList2.Count != 0 ) {

				//Read MSDev for this line.
				Application.DoEvents();

				//In order to use string comparison, they have to be converted from object to string.
				string string1 = ( string ) TextList1[0], string2 = "";
				bool matchFound = false;

				for( int i = 0; i < TextList2.Count; i++ ) {
					string2 = ( string ) TextList2[i];
					if( string2.Equals( string1 ) ) {
						matchFound = true;
						break;
					}
				}

				if( matchFound ) {
					TextList1.Remove( string1 );
					TextList2.Remove( string1 );
				}

				/*
				//Just logs which lines it's comparing.
				Log.GetInstence().WriteLine( $"Comparing \"{string1}\" and \"{string2}\" together, line is at {line}" );

				//Testing to see if the lines are different and if they are, output it to the output box.
				if(string1.CompareTo(string2) != 0 ) {
					ForOutputBox.Append( $"\nDifferent line {( line++ )}\n\t{File1Name}: {string1}\n\t{File2Name}: {string2}" );
				}
				*/
				//Removes the strings from the ArrayList and increments the progress done.
				//TextList1.Remove( string1 );
				//TextList2.Remove( string2 );
				mainUI.IncrementPercentDone( 1, progressBar );
			}

			//Checks to see if either ArrayList is empty, and if not, output their remaining set to the output.
			if(TextList1.Count != 0 ) {
				ForOutputBox.AppendLine( $"\nExtra lines from [original]{File1Name}:" );
				foreach(string str in TextList1 ) {
					ForOutputBox.Append( $"\n{str}" );
				}
			}
			if(TextList2.Count != 0 ) {
				ForOutputBox.AppendLine( $"\nExtra lines from [modified]{File2Name}:" );
				foreach( string str in TextList2 ) {
					ForOutputBox.Append( $"\n{str}" );
				}
			}

			//Changes the text in the output.
			Output.Text = ForOutputBox.ToString();
		}

		private void AddStringToList(string text, ArrayList list ) {
			char[] UnixLineEnding = { '\n' };

			string temp = text.Replace( "\r\n", "\n" ).Replace( "\r", "\n" ).Replace( "\n", " [new line]\n" );

			string[] texts = temp.Split( UnixLineEnding, StringSplitOptions.None );

			foreach( string str in texts ) {
					list.Add( str.Trim() );
			}

			//Looks for any [new line] ends along with rouge curly brakets.
			for(int i = 0; i < list.Count; i++ ) {
				string str = ( string ) list[i];
				str.Trim();
				if( str.Equals( "} [new line]" ) || str.Equals( "{ [new line]" ) || str.Equals( " [new line]" )
					|| str.Equals( "" ) ) {
					list.RemoveAt( i );
					i-=2;
					continue;
				} else if( str.Contains("[new line]" ) ) {
					list[i] = str.Remove( str.LastIndexOf( "[new line]" ) ).Trim();
				}
			}
		}
	}
}