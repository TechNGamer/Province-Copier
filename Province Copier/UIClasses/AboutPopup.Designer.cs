namespace ProvinceCopier.UIClasses {
	partial class AboutPopup {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing ) {
			if( disposing && ( components != null ) ) {
				components.Dispose();
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.logoPictureBox = new System.Windows.Forms.PictureBox();
			this.labelProductName = new System.Windows.Forms.Label();
			this.LabelCreatedBy = new System.Windows.Forms.Label();
			this.LableVersion = new System.Windows.Forms.Label();
			this.LicensingType = new System.Windows.Forms.Label();
			this.textBoxDescription = new System.Windows.Forms.TextBox();
			this.okButton = new System.Windows.Forms.Button();
			this.tableLayoutPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// tableLayoutPanel
			// 
			this.tableLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.tableLayoutPanel.ColumnCount = 2;
			this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.15447F));
			this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.84553F));
			this.tableLayoutPanel.Controls.Add(this.logoPictureBox, 0, 0);
			this.tableLayoutPanel.Controls.Add(this.labelProductName, 1, 0);
			this.tableLayoutPanel.Controls.Add(this.LabelCreatedBy, 1, 1);
			this.tableLayoutPanel.Controls.Add(this.LableVersion, 1, 2);
			this.tableLayoutPanel.Controls.Add(this.LicensingType, 1, 3);
			this.tableLayoutPanel.Controls.Add(this.textBoxDescription, 1, 4);
			this.tableLayoutPanel.Controls.Add(this.okButton, 1, 5);
			this.tableLayoutPanel.Location = new System.Drawing.Point(9, 9);
			this.tableLayoutPanel.Name = "tableLayoutPanel";
			this.tableLayoutPanel.RowCount = 6;
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.tableLayoutPanel.Size = new System.Drawing.Size(492, 265);
			this.tableLayoutPanel.TabIndex = 0;
			// 
			// logoPictureBox
			// 
			this.logoPictureBox.ErrorImage = global::ProvinceCopier.Properties.Resources.ImageNotFound;
			this.logoPictureBox.Image = global::ProvinceCopier.Properties.Resources.Province_Copier_Image;
			this.logoPictureBox.Location = new System.Drawing.Point(3, 3);
			this.logoPictureBox.Name = "logoPictureBox";
			this.tableLayoutPanel.SetRowSpan(this.logoPictureBox, 6);
			this.logoPictureBox.Size = new System.Drawing.Size(225, 225);
			this.logoPictureBox.TabIndex = 12;
			this.logoPictureBox.TabStop = false;
			// 
			// labelProductName
			// 
			this.labelProductName.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelProductName.Location = new System.Drawing.Point(237, 0);
			this.labelProductName.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
			this.labelProductName.MaximumSize = new System.Drawing.Size(0, 17);
			this.labelProductName.Name = "labelProductName";
			this.labelProductName.Size = new System.Drawing.Size(252, 17);
			this.labelProductName.TabIndex = 19;
			this.labelProductName.Text = "Province Copier";
			this.labelProductName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.labelProductName.Click += new System.EventHandler(this.labelProductName_Click);
			// 
			// LabelCreatedBy
			// 
			this.LabelCreatedBy.Dock = System.Windows.Forms.DockStyle.Fill;
			this.LabelCreatedBy.Location = new System.Drawing.Point(237, 26);
			this.LabelCreatedBy.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
			this.LabelCreatedBy.MaximumSize = new System.Drawing.Size(0, 17);
			this.LabelCreatedBy.Name = "LabelCreatedBy";
			this.LabelCreatedBy.Size = new System.Drawing.Size(252, 17);
			this.LabelCreatedBy.TabIndex = 0;
			this.LabelCreatedBy.Text = "Created by Tech N Gamer";
			this.LabelCreatedBy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// LableVersion
			// 
			this.LableVersion.Dock = System.Windows.Forms.DockStyle.Fill;
			this.LableVersion.Location = new System.Drawing.Point(237, 52);
			this.LableVersion.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
			this.LableVersion.MaximumSize = new System.Drawing.Size(0, 17);
			this.LableVersion.Name = "LableVersion";
			this.LableVersion.Size = new System.Drawing.Size(252, 17);
			this.LableVersion.TabIndex = 21;
			this.LableVersion.Text = "Version 2.1.1";
			this.LableVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// LicensingType
			// 
			this.LicensingType.Dock = System.Windows.Forms.DockStyle.Fill;
			this.LicensingType.Location = new System.Drawing.Point(237, 78);
			this.LicensingType.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
			this.LicensingType.MaximumSize = new System.Drawing.Size(0, 17);
			this.LicensingType.Name = "LicensingType";
			this.LicensingType.Size = new System.Drawing.Size(252, 17);
			this.LicensingType.TabIndex = 22;
			this.LicensingType.Text = "MIT License";
			this.LicensingType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// textBoxDescription
			// 
			this.textBoxDescription.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBoxDescription.Location = new System.Drawing.Point(237, 107);
			this.textBoxDescription.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
			this.textBoxDescription.Multiline = true;
			this.textBoxDescription.Name = "textBoxDescription";
			this.textBoxDescription.ReadOnly = true;
			this.textBoxDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.textBoxDescription.Size = new System.Drawing.Size(252, 126);
			this.textBoxDescription.TabIndex = 23;
			this.textBoxDescription.TabStop = false;
			this.textBoxDescription.Text = "This software was made to help EUIV modders pull provences from the EUIV director" +
    "y. This software is licensed under the MIT License.";
			// 
			// okButton
			// 
			this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.okButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.okButton.Location = new System.Drawing.Point(414, 239);
			this.okButton.Name = "okButton";
			this.okButton.Size = new System.Drawing.Size(75, 23);
			this.okButton.TabIndex = 24;
			this.okButton.Text = "&OK";
			// 
			// AboutPopup
			// 
			this.AcceptButton = this.okButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(510, 278);
			this.Controls.Add(this.tableLayoutPanel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AboutPopup";
			this.Padding = new System.Windows.Forms.Padding(9);
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "About";
			this.tableLayoutPanel.ResumeLayout(false);
			this.tableLayoutPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
		private System.Windows.Forms.PictureBox logoPictureBox;
		private System.Windows.Forms.Label labelProductName;
		private System.Windows.Forms.Label LabelCreatedBy;
		private System.Windows.Forms.Label LableVersion;
		private System.Windows.Forms.Label LicensingType;
		private System.Windows.Forms.TextBox textBoxDescription;
		private System.Windows.Forms.Button okButton;
	}
}
