namespace WavPlayer
{
    partial class Player
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Player));
            this.ChooseFile = new System.Windows.Forms.Button();
            this.ChosenFileText = new System.Windows.Forms.Label();
            this.OpenFile = new System.Windows.Forms.OpenFileDialog();
            this.FilePathText = new System.Windows.Forms.Label();
            this.PlayButton = new System.Windows.Forms.Button();
            this.PauseButton = new System.Windows.Forms.Button();
            this.FilePath = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ChooseFile
            // 
            resources.ApplyResources(this.ChooseFile, "ChooseFile");
            this.ChooseFile.Name = "ChooseFile";
            this.ChooseFile.UseVisualStyleBackColor = true;
            this.ChooseFile.Click += new System.EventHandler(this.ChooseFile_Click);
            // 
            // ChosenFileText
            // 
            resources.ApplyResources(this.ChosenFileText, "ChosenFileText");
            this.ChosenFileText.Name = "ChosenFileText";
            // 
            // OpenFile
            // 
            this.OpenFile.FileName = "openFileDialog1";
            // 
            // FilePathText
            // 
            resources.ApplyResources(this.FilePathText, "FilePathText");
            this.FilePathText.Name = "FilePathText";
            // 
            // PlayButton
            // 
            resources.ApplyResources(this.PlayButton, "PlayButton");
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.UseVisualStyleBackColor = true;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // PauseButton
            // 
            resources.ApplyResources(this.PauseButton, "PauseButton");
            this.PauseButton.Name = "PauseButton";
            this.PauseButton.UseVisualStyleBackColor = true;
            this.PauseButton.Click += new System.EventHandler(this.PauseButton_Click);
            // 
            // FilePath
            // 
            resources.ApplyResources(this.FilePath, "FilePath");
            this.FilePath.Name = "FilePath";
            // 
            // Player
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.FilePath);
            this.Controls.Add(this.PauseButton);
            this.Controls.Add(this.PlayButton);
            this.Controls.Add(this.FilePathText);
            this.Controls.Add(this.ChosenFileText);
            this.Controls.Add(this.ChooseFile);
            this.KeyPreview = true;
            this.Name = "Player";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ChooseFile;
        private System.Windows.Forms.Label ChosenFileText;
        private System.Windows.Forms.OpenFileDialog OpenFile;
        private System.Windows.Forms.Label FilePathText;
        private System.Windows.Forms.Button PlayButton;
        private System.Windows.Forms.Button PauseButton;
        private System.Windows.Forms.TextBox FilePath;
    }
}

