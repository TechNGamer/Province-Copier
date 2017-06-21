namespace ProvinceCopier {
    partial class MainUI {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainUI));
			this.FolderOpenDialog = new System.Windows.Forms.FolderBrowserDialog();
			this.saveSaveSpaceFileDialog = new System.Windows.Forms.SaveFileDialog();
			this.tabControl = new System.Windows.Forms.TabControl();
			this.Transfer_Tab = new System.Windows.Forms.TabPage();
			this.startButton = new System.Windows.Forms.Button();
			this.transferFileProgressBar = new System.Windows.Forms.ProgressBar();
			this.provinceToCopy = new System.Windows.Forms.RichTextBox();
			this.copyToDialogOpen = new System.Windows.Forms.Button();
			this.euivInstallBar = new System.Windows.Forms.TextBox();
			this.euivLocationDialogOpen = new System.Windows.Forms.Button();
			this.userCopyTo = new System.Windows.Forms.TextBox();
			this.Comparer_Tab = new System.Windows.Forms.TabPage();
			this.StartButton2 = new System.Windows.Forms.Button();
			this.OutputBox = new System.Windows.Forms.RichTextBox();
			this.OpenFile2Button = new System.Windows.Forms.Button();
			this.File2Loc = new System.Windows.Forms.TextBox();
			this.OpenFile1Button = new System.Windows.Forms.Button();
			this.File1Loc = new System.Windows.Forms.TextBox();
			this.ComparerProgressBar = new System.Windows.Forms.ProgressBar();
			this.Utilities_Tab = new System.Windows.Forms.TabPage();
			this.EUIVImageBox = new System.Windows.Forms.PictureBox();
			this.ProvinceCopierImage = new System.Windows.Forms.PictureBox();
			this.aboutThisProgramButton = new System.Windows.Forms.Button();
			this.bugAndFeaturesButton = new System.Windows.Forms.Button();
			this.openSaveSpace = new System.Windows.Forms.Button();
			this.saveSpaveGroupBox = new System.Windows.Forms.GroupBox();
			this.universalSaveSpaceButton = new System.Windows.Forms.Button();
			this.regularSaveSpaceButton = new System.Windows.Forms.Button();
			this.openSaveSpaceDialog = new System.Windows.Forms.OpenFileDialog();
			this.FileOpenDialog = new System.Windows.Forms.OpenFileDialog();
			this.tabControl.SuspendLayout();
			this.Transfer_Tab.SuspendLayout();
			this.Comparer_Tab.SuspendLayout();
			this.Utilities_Tab.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.EUIVImageBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ProvinceCopierImage)).BeginInit();
			this.saveSpaveGroupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// FolderOpenDialog
			// 
			this.FolderOpenDialog.RootFolder = System.Environment.SpecialFolder.MyComputer;
			this.FolderOpenDialog.ShowNewFolderButton = false;
			// 
			// saveSaveSpaceFileDialog
			// 
			this.saveSaveSpaceFileDialog.DefaultExt = "savespace";
			this.saveSaveSpaceFileDialog.Filter = "Savespace files|*.savespace";
			this.saveSaveSpaceFileDialog.Title = "Save Current Workspace";
			// 
			// tabControl
			// 
			this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tabControl.Controls.Add(this.Transfer_Tab);
			this.tabControl.Controls.Add(this.Comparer_Tab);
			this.tabControl.Controls.Add(this.Utilities_Tab);
			this.tabControl.Location = new System.Drawing.Point(4, 3);
			this.tabControl.Name = "tabControl";
			this.tabControl.SelectedIndex = 0;
			this.tabControl.Size = new System.Drawing.Size(476, 456);
			this.tabControl.TabIndex = 5;
			// 
			// Transfer_Tab
			// 
			this.Transfer_Tab.Controls.Add(this.startButton);
			this.Transfer_Tab.Controls.Add(this.transferFileProgressBar);
			this.Transfer_Tab.Controls.Add(this.provinceToCopy);
			this.Transfer_Tab.Controls.Add(this.copyToDialogOpen);
			this.Transfer_Tab.Controls.Add(this.euivInstallBar);
			this.Transfer_Tab.Controls.Add(this.euivLocationDialogOpen);
			this.Transfer_Tab.Controls.Add(this.userCopyTo);
			this.Transfer_Tab.Location = new System.Drawing.Point(4, 22);
			this.Transfer_Tab.Name = "Transfer_Tab";
			this.Transfer_Tab.Padding = new System.Windows.Forms.Padding(3);
			this.Transfer_Tab.Size = new System.Drawing.Size(468, 430);
			this.Transfer_Tab.TabIndex = 0;
			this.Transfer_Tab.Text = "Transfer";
			this.Transfer_Tab.UseVisualStyleBackColor = true;
			// 
			// startButton
			// 
			this.startButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.startButton.Location = new System.Drawing.Point(398, 402);
			this.startButton.Name = "startButton";
			this.startButton.Size = new System.Drawing.Size(63, 22);
			this.startButton.TabIndex = 11;
			this.startButton.Text = "Start";
			this.startButton.UseVisualStyleBackColor = true;
			this.startButton.Click += new System.EventHandler(this.startButton_Click);
			// 
			// transferFileProgressBar
			// 
			this.transferFileProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.transferFileProgressBar.Location = new System.Drawing.Point(7, 402);
			this.transferFileProgressBar.Name = "transferFileProgressBar";
			this.transferFileProgressBar.Size = new System.Drawing.Size(386, 22);
			this.transferFileProgressBar.TabIndex = 10;
			// 
			// provinceToCopy
			// 
			this.provinceToCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.provinceToCopy.Location = new System.Drawing.Point(7, 32);
			this.provinceToCopy.Name = "provinceToCopy";
			this.provinceToCopy.Size = new System.Drawing.Size(455, 341);
			this.provinceToCopy.TabIndex = 7;
			this.provinceToCopy.Text = "";
			// 
			// copyToDialogOpen
			// 
			this.copyToDialogOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.copyToDialogOpen.Location = new System.Drawing.Point(398, 379);
			this.copyToDialogOpen.Name = "copyToDialogOpen";
			this.copyToDialogOpen.Size = new System.Drawing.Size(64, 21);
			this.copyToDialogOpen.TabIndex = 9;
			this.copyToDialogOpen.Text = "Copy To";
			this.copyToDialogOpen.UseVisualStyleBackColor = true;
			this.copyToDialogOpen.Click += new System.EventHandler(this.copyToDialogOpen_Click);
			// 
			// euivInstallBar
			// 
			this.euivInstallBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.euivInstallBar.Location = new System.Drawing.Point(6, 6);
			this.euivInstallBar.Name = "euivInstallBar";
			this.euivInstallBar.ReadOnly = true;
			this.euivInstallBar.Size = new System.Drawing.Size(366, 20);
			this.euivInstallBar.TabIndex = 5;
			// 
			// euivLocationDialogOpen
			// 
			this.euivLocationDialogOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.euivLocationDialogOpen.Location = new System.Drawing.Point(378, 5);
			this.euivLocationDialogOpen.Name = "euivLocationDialogOpen";
			this.euivLocationDialogOpen.Size = new System.Drawing.Size(84, 21);
			this.euivLocationDialogOpen.TabIndex = 6;
			this.euivLocationDialogOpen.Text = "EUIV Location";
			this.euivLocationDialogOpen.UseVisualStyleBackColor = true;
			this.euivLocationDialogOpen.Click += new System.EventHandler(this.euivLocationDialogOpen_Click);
			// 
			// userCopyTo
			// 
			this.userCopyTo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.userCopyTo.Location = new System.Drawing.Point(7, 379);
			this.userCopyTo.Name = "userCopyTo";
			this.userCopyTo.ReadOnly = true;
			this.userCopyTo.Size = new System.Drawing.Size(386, 20);
			this.userCopyTo.TabIndex = 8;
			// 
			// Comparer_Tab
			// 
			this.Comparer_Tab.Controls.Add(this.StartButton2);
			this.Comparer_Tab.Controls.Add(this.OutputBox);
			this.Comparer_Tab.Controls.Add(this.OpenFile2Button);
			this.Comparer_Tab.Controls.Add(this.File2Loc);
			this.Comparer_Tab.Controls.Add(this.OpenFile1Button);
			this.Comparer_Tab.Controls.Add(this.File1Loc);
			this.Comparer_Tab.Controls.Add(this.ComparerProgressBar);
			this.Comparer_Tab.Location = new System.Drawing.Point(4, 22);
			this.Comparer_Tab.Name = "Comparer_Tab";
			this.Comparer_Tab.Size = new System.Drawing.Size(468, 430);
			this.Comparer_Tab.TabIndex = 2;
			this.Comparer_Tab.Text = "Comparer";
			this.Comparer_Tab.UseVisualStyleBackColor = true;
			// 
			// StartButton2
			// 
			this.StartButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.StartButton2.Location = new System.Drawing.Point(389, 404);
			this.StartButton2.Name = "StartButton2";
			this.StartButton2.Size = new System.Drawing.Size(75, 23);
			this.StartButton2.TabIndex = 6;
			this.StartButton2.Text = "Start";
			this.StartButton2.UseVisualStyleBackColor = true;
			this.StartButton2.Click += new System.EventHandler(this.StartComparing);
			// 
			// OutputBox
			// 
			this.OutputBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.OutputBox.Location = new System.Drawing.Point(4, 57);
			this.OutputBox.Name = "OutputBox";
			this.OutputBox.Size = new System.Drawing.Size(460, 341);
			this.OutputBox.TabIndex = 5;
			this.OutputBox.Text = "";
			// 
			// OpenFile2Button
			// 
			this.OpenFile2Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.OpenFile2Button.Location = new System.Drawing.Point(358, 29);
			this.OpenFile2Button.Name = "OpenFile2Button";
			this.OpenFile2Button.Size = new System.Drawing.Size(106, 23);
			this.OpenFile2Button.TabIndex = 4;
			this.OpenFile2Button.Text = "Open Modified";
			this.OpenFile2Button.UseVisualStyleBackColor = true;
			this.OpenFile2Button.Click += new System.EventHandler(this.OpenFile2_Click);
			// 
			// File2Loc
			// 
			this.File2Loc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.File2Loc.Location = new System.Drawing.Point(4, 31);
			this.File2Loc.Name = "File2Loc";
			this.File2Loc.Size = new System.Drawing.Size(348, 20);
			this.File2Loc.TabIndex = 3;
			// 
			// OpenFile1Button
			// 
			this.OpenFile1Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.OpenFile1Button.Location = new System.Drawing.Point(358, 3);
			this.OpenFile1Button.Name = "OpenFile1Button";
			this.OpenFile1Button.Size = new System.Drawing.Size(106, 23);
			this.OpenFile1Button.TabIndex = 2;
			this.OpenFile1Button.Text = "Open Origional";
			this.OpenFile1Button.UseVisualStyleBackColor = true;
			this.OpenFile1Button.Click += new System.EventHandler(this.OpenFile1_Click);
			// 
			// File1Loc
			// 
			this.File1Loc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.File1Loc.Location = new System.Drawing.Point(4, 5);
			this.File1Loc.Name = "File1Loc";
			this.File1Loc.Size = new System.Drawing.Size(348, 20);
			this.File1Loc.TabIndex = 1;
			// 
			// ComparerProgressBar
			// 
			this.ComparerProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ComparerProgressBar.Location = new System.Drawing.Point(4, 404);
			this.ComparerProgressBar.Name = "ComparerProgressBar";
			this.ComparerProgressBar.Size = new System.Drawing.Size(379, 23);
			this.ComparerProgressBar.TabIndex = 0;
			// 
			// Utilities_Tab
			// 
			this.Utilities_Tab.Controls.Add(this.EUIVImageBox);
			this.Utilities_Tab.Controls.Add(this.ProvinceCopierImage);
			this.Utilities_Tab.Controls.Add(this.aboutThisProgramButton);
			this.Utilities_Tab.Controls.Add(this.bugAndFeaturesButton);
			this.Utilities_Tab.Controls.Add(this.openSaveSpace);
			this.Utilities_Tab.Controls.Add(this.saveSpaveGroupBox);
			this.Utilities_Tab.Location = new System.Drawing.Point(4, 22);
			this.Utilities_Tab.Name = "Utilities_Tab";
			this.Utilities_Tab.Padding = new System.Windows.Forms.Padding(3);
			this.Utilities_Tab.Size = new System.Drawing.Size(468, 430);
			this.Utilities_Tab.TabIndex = 1;
			this.Utilities_Tab.Text = "Utilities";
			this.Utilities_Tab.UseVisualStyleBackColor = true;
			// 
			// EUIVImageBox
			// 
			this.EUIVImageBox.ErrorImage = ((System.Drawing.Image)(resources.GetObject("EUIVImageBox.ErrorImage")));
			this.EUIVImageBox.Image = global::ProvinceCopier.Properties.Resources.EU4Icon;
			this.EUIVImageBox.ImageLocation = "";
			this.EUIVImageBox.Location = new System.Drawing.Point(237, 100);
			this.EUIVImageBox.Name = "EUIVImageBox";
			this.EUIVImageBox.Size = new System.Drawing.Size(225, 225);
			this.EUIVImageBox.TabIndex = 7;
			this.EUIVImageBox.TabStop = false;
			// 
			// ProvinceCopierImage
			// 
			this.ProvinceCopierImage.ErrorImage = ((System.Drawing.Image)(resources.GetObject("ProvinceCopierImage.ErrorImage")));
			this.ProvinceCopierImage.Image = global::ProvinceCopier.Properties.Resources.Province_Copier_Image;
			this.ProvinceCopierImage.ImageLocation = "";
			this.ProvinceCopierImage.Location = new System.Drawing.Point(11, 100);
			this.ProvinceCopierImage.Name = "ProvinceCopierImage";
			this.ProvinceCopierImage.Size = new System.Drawing.Size(225, 225);
			this.ProvinceCopierImage.TabIndex = 6;
			this.ProvinceCopierImage.TabStop = false;
			// 
			// aboutThisProgramButton
			// 
			this.aboutThisProgramButton.Location = new System.Drawing.Point(191, 54);
			this.aboutThisProgramButton.Name = "aboutThisProgramButton";
			this.aboutThisProgramButton.Size = new System.Drawing.Size(110, 20);
			this.aboutThisProgramButton.TabIndex = 5;
			this.aboutThisProgramButton.Text = "About this Program";
			this.aboutThisProgramButton.UseVisualStyleBackColor = true;
			this.aboutThisProgramButton.Click += new System.EventHandler(this.aboutThisProgramButton_Click);
			// 
			// bugAndFeaturesButton
			// 
			this.bugAndFeaturesButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.bugAndFeaturesButton.Location = new System.Drawing.Point(308, 28);
			this.bugAndFeaturesButton.Name = "bugAndFeaturesButton";
			this.bugAndFeaturesButton.Size = new System.Drawing.Size(154, 47);
			this.bugAndFeaturesButton.TabIndex = 4;
			this.bugAndFeaturesButton.Text = "Bug and Feature Request Page";
			this.bugAndFeaturesButton.UseVisualStyleBackColor = true;
			this.bugAndFeaturesButton.Click += new System.EventHandler(this.bugAndFeaturesButton_Click);
			// 
			// openSaveSpace
			// 
			this.openSaveSpace.Location = new System.Drawing.Point(188, 27);
			this.openSaveSpace.Name = "openSaveSpace";
			this.openSaveSpace.Size = new System.Drawing.Size(114, 21);
			this.openSaveSpace.TabIndex = 3;
			this.openSaveSpace.Text = "Open Savespace file";
			this.openSaveSpace.UseVisualStyleBackColor = true;
			this.openSaveSpace.Click += new System.EventHandler(this.openSaveSpace_Click);
			// 
			// saveSpaveGroupBox
			// 
			this.saveSpaveGroupBox.AutoSize = true;
			this.saveSpaveGroupBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.saveSpaveGroupBox.Controls.Add(this.universalSaveSpaceButton);
			this.saveSpaveGroupBox.Controls.Add(this.regularSaveSpaceButton);
			this.saveSpaveGroupBox.Location = new System.Drawing.Point(6, 6);
			this.saveSpaveGroupBox.Name = "saveSpaveGroupBox";
			this.saveSpaveGroupBox.Size = new System.Drawing.Size(176, 88);
			this.saveSpaveGroupBox.TabIndex = 2;
			this.saveSpaveGroupBox.TabStop = false;
			this.saveSpaveGroupBox.Text = "Save to Savespace";
			// 
			// universalSaveSpaceButton
			// 
			this.universalSaveSpaceButton.Location = new System.Drawing.Point(6, 48);
			this.universalSaveSpaceButton.Name = "universalSaveSpaceButton";
			this.universalSaveSpaceButton.Size = new System.Drawing.Size(164, 21);
			this.universalSaveSpaceButton.TabIndex = 1;
			this.universalSaveSpaceButton.Text = "PC-Independent Savespaace";
			this.universalSaveSpaceButton.UseVisualStyleBackColor = true;
			this.universalSaveSpaceButton.Click += new System.EventHandler(this.universalSaveSpaceButton_Click);
			// 
			// regularSaveSpaceButton
			// 
			this.regularSaveSpaceButton.Location = new System.Drawing.Point(6, 19);
			this.regularSaveSpaceButton.Name = "regularSaveSpaceButton";
			this.regularSaveSpaceButton.Size = new System.Drawing.Size(164, 23);
			this.regularSaveSpaceButton.TabIndex = 0;
			this.regularSaveSpaceButton.Text = "PC Dependent Savespace";
			this.regularSaveSpaceButton.UseVisualStyleBackColor = true;
			this.regularSaveSpaceButton.Click += new System.EventHandler(this.regularSaveSpaceButton_Click);
			// 
			// openSaveSpaceDialog
			// 
			this.openSaveSpaceDialog.Filter = "SaveSpace files|*.savespace";
			this.openSaveSpaceDialog.ReadOnlyChecked = true;
			// 
			// FileOpenDialog
			// 
			this.FileOpenDialog.FileName = "FileOpenDialog";
			// 
			// MainUI
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(484, 461);
			this.Controls.Add(this.tabControl);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(500, 500);
			this.Name = "MainUI";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Province Copier Test";
			this.tabControl.ResumeLayout(false);
			this.Transfer_Tab.ResumeLayout(false);
			this.Transfer_Tab.PerformLayout();
			this.Comparer_Tab.ResumeLayout(false);
			this.Comparer_Tab.PerformLayout();
			this.Utilities_Tab.ResumeLayout(false);
			this.Utilities_Tab.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.EUIVImageBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ProvinceCopierImage)).EndInit();
			this.saveSpaveGroupBox.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FolderBrowserDialog FolderOpenDialog;
        private System.Windows.Forms.SaveFileDialog saveSaveSpaceFileDialog;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage Transfer_Tab;
        private System.Windows.Forms.RichTextBox provinceToCopy;
        private System.Windows.Forms.Button copyToDialogOpen;
        private System.Windows.Forms.TextBox euivInstallBar;
        private System.Windows.Forms.Button euivLocationDialogOpen;
        private System.Windows.Forms.TextBox userCopyTo;
        private System.Windows.Forms.TabPage Utilities_Tab;
        private System.Windows.Forms.GroupBox saveSpaveGroupBox;
        private System.Windows.Forms.Button regularSaveSpaceButton;
        private System.Windows.Forms.Button universalSaveSpaceButton;
        private System.Windows.Forms.PictureBox EUIVImageBox;
        private System.Windows.Forms.PictureBox ProvinceCopierImage;
        private System.Windows.Forms.Button aboutThisProgramButton;
        private System.Windows.Forms.Button bugAndFeaturesButton;
        private System.Windows.Forms.Button openSaveSpace;
		private System.Windows.Forms.OpenFileDialog openSaveSpaceDialog;
		private System.Windows.Forms.Button startButton;
		private System.Windows.Forms.ProgressBar transferFileProgressBar;
		private System.Windows.Forms.TabPage Comparer_Tab;
		private System.Windows.Forms.RichTextBox OutputBox;
		private System.Windows.Forms.Button OpenFile2Button;
		private System.Windows.Forms.TextBox File2Loc;
		private System.Windows.Forms.Button OpenFile1Button;
		private System.Windows.Forms.TextBox File1Loc;
		private System.Windows.Forms.ProgressBar ComparerProgressBar;
		private System.Windows.Forms.Button StartButton2;
		private System.Windows.Forms.OpenFileDialog FileOpenDialog;
	}
}