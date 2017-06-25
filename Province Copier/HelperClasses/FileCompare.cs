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
			//This is only ment for debugging purposes only.
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

			TextList1.Sort();
			TextList2.Sort();

			mainUI.ChangeProgressBarState( ProgressBarStyle.Continuous, progressBar );

			//StringBuilder is used for it's .Append method.
			StringBuilder ForOutputBox = new StringBuilder( $"Differences in {File1Name} and {File2Name}:" );

			//To see which file is the shorted aand to use it as the length.
			//int progressLength = TextList1.Count < TextList2.Count ? TextList1.Count : TextList2.Count;

			mainUI.SetMaxNumber( TextList1.Count * TextList2.Count, progressBar );

			//To keep track of the line it's on.
			int line = 0;

			//While loop used since a for loop would have to be constantly reset to 0.
			for( int i = 0; i < TextList1.Count; i++ ) {

				//Read MSDev for this line.
				Application.DoEvents();

				//In order to use string comparison, they have to be converted from object to string.
				string string1 = ( string ) TextList1[i], string2 = "";
				bool matchFound = false;
				#if DEBUG
				Log.GetInstence().WriteLine( $"While loop pass numbeer {line++}." );
				#endif
				for( int c = 0; c < TextList2.Count; c++ ) {
					Application.DoEvents();
					#if DEBUG
					Log.GetInstence().WriteLine( $"For loop pass {c}." );
					#endif
					string2 = ( string ) TextList2[c];
					if( string2.Equals( string1 ) ) {
						matchFound = true;
						break;
					}
				}

				if( matchFound ) {
					#if DEBUG
					Log.GetInstence().WriteLine( $"Removing \"{string1}\" from TextList1 and TextList2. " +
						$"Left in TextList1 is {TextList1.Count} and in TextList2 is {TextList2.Count}." );
					#endif
					TextList1.Remove( string1 );
					TextList2.Remove( string1 );
					i--;
				}
				mainUI.IncrementPercentDone( 1, progressBar );
			}

			//Checks to see if either ArrayList is empty, and if not, output their remaining set to the output.
			if(TextList1.Count != 0 ) {
				PrintExtras( TextList1, ForOutputBox, false );
			}
			if(TextList2.Count != 0 ) {
				PrintExtras( TextList1, ForOutputBox, true );
			}

			//Changes the text in the output.
			mainUI.SetMaxNumber( 1, progressBar );
			mainUI.ChangeProgressValue( 1, progressBar );
			Output.Text = ForOutputBox.ToString().Trim();
		}

		private void AddStringToList(string text, ArrayList list ) {
			string[] Remove = { "{[new line]", "}[new line]", "[new line]", "", "#" };
			char[] UnixLineEnding = { '\n' };

			string temp = text.Replace( "\r\n", "\n" ).Replace( "\r", "\n" ).Replace( "\n", $" {Remove[2]}\n" );

			string[] texts = temp.Split( UnixLineEnding, StringSplitOptions.None );

			foreach( string str in texts ) {
					list.Add( str.Trim() );
			}

			//Looks for any [new line] ends along with rouge curly brakets.
			for( int i = 0; i < list.Count; i++ ) {
				Application.DoEvents();
				string str = ( string ) list[i];
				try {
					str = str.Remove( str.LastIndexOf( Remove[2] ) ).Trim() + Remove[2];
#pragma warning disable CS0168 // Variable is declared but never used
				} catch ( Exception e ) {
#pragma warning restore CS0168 // Variable is declared but never used
					str = str.Trim() + Remove[2];
				}
#if DEBUG
				Log.GetInstence().WriteLine( $"Testing if {str} is equal to {Remove[0]} or {Remove[1]} or {Remove[2]} or '{Remove[3]}'" +
					$" or {Remove[4]} and the result is " +
					(str.Equals( Remove[0] ) || str.Equals( Remove[1] ) || str.Equals( Remove[2] ) || str.Equals( Remove[3] )
					|| str.Equals( Remove[4])) + "." );
				System.Threading.Thread.Sleep( 250 );
#endif
				if( str.Equals( Remove[0] ) || str.Equals( Remove[1] ) || str.Equals( Remove[2] )
					|| str.Equals( Remove[3] ) || str.StartsWith( Remove[4] ) || str.Equals( UnixLineEnding[0] + Remove[2] ) ) {
					list.RemoveAt( i );
					i--;
					continue;
				} else if( str.Contains( Remove[2] ) ) {
					list[i] = str.Remove( str.LastIndexOf( Remove[2] ) ).Trim();
				}
			}
		}

		private void PrintExtras(ArrayList list, StringBuilder builder, bool isModified ) {
			if(isModified)
				builder.AppendLine( $"\n\tExtra lines from [modified]{File2Name}:" );
			else
				builder.AppendLine( $"\n\tExtra lines from [original]{File1Name}:" );
			string prevLine = "";
			int appearTime = 0;
			foreach( string str in list ) {
				if( str.Equals( prevLine ) ) {
					appearTime++;
				} else if( appearTime > 0 ) {
					builder.AppendLine( $"\t\t{prevLine} (x{appearTime})" );
				} else {
					builder.AppendLine( $"\t\t{str}" );
				}
			}
		}
	}
}