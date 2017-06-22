using System;
using System.Reflection;
using System.Windows.Forms;
using System.Resources;

namespace ProvinceCopier.UIClasses {
	partial class AboutPopup : Form {
		public AboutPopup() {
			InitializeComponent();
			this.Text = String.Format( "About {0}", AssemblyTitle );
			this.labelProductName.Text = "Province Copier";
			this.LabelCreatedBy.Text = "Created by Tech N Gamer";
			this.LableVersion.Text = "Version 2.1.1";
			this.LicensingType.Text = "MIT License";
			this.textBoxDescription.Text = "This software was made to help EUIV modders pull provences from the EUIV" +
				" directory. This software is licensed under the MIT License.";
		}

		#region Assembly Attribute Accessors
		public string AssemblyTitle {
			get {
				object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes( typeof( AssemblyTitleAttribute ), false );
				if( attributes.Length > 0 ) {
					AssemblyTitleAttribute titleAttribute = ( AssemblyTitleAttribute ) attributes[0];
					if( titleAttribute.Title != "" ) {
						return titleAttribute.Title;
					}
				}
				return System.IO.Path.GetFileNameWithoutExtension( Assembly.GetExecutingAssembly().CodeBase );
			}
		}
		#endregion

		private void labelProductName_Click( object sender, EventArgs e ) {

		}
	}
}