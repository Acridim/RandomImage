namespace RandomImage
{
    partial class MainForm
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.metroTile = new MetroFramework.Controls.MetroTile();
            this.generateButton = new MetroFramework.Controls.MetroButton();
            this.metroLabelSeed = new MetroFramework.Controls.MetroLabel();
            this.seedTextBox = new MetroFramework.Controls.MetroTextBox();
            this.saveButton = new MetroFramework.Controls.MetroButton();
            this.metroLabelPixelSize = new MetroFramework.Controls.MetroLabel();
            this.pixelSizeComboBox = new MetroFramework.Controls.MetroComboBox();
            this.metroLabelAlpha = new MetroFramework.Controls.MetroLabel();
            this.alphaToggle = new MetroFramework.Controls.MetroToggle();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(115, 77);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(360, 220);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // metroTile
            // 
            this.metroTile.Location = new System.Drawing.Point(25, 60);
            this.metroTile.Name = "metroTile";
            this.metroTile.Size = new System.Drawing.Size(450, 5);
            this.metroTile.Style = MetroFramework.MetroColorStyle.Magenta;
            this.metroTile.TabIndex = 1;
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(25, 77);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(81, 23);
            this.generateButton.TabIndex = 2;
            this.generateButton.Text = "Generate";
            this.generateButton.Click += new System.EventHandler(this.GenerateImage);
            // 
            // metroLabelSeed
            // 
            this.metroLabelSeed.AutoSize = true;
            this.metroLabelSeed.Location = new System.Drawing.Point(25, 113);
            this.metroLabelSeed.Name = "metroLabelSeed";
            this.metroLabelSeed.Size = new System.Drawing.Size(41, 19);
            this.metroLabelSeed.TabIndex = 3;
            this.metroLabelSeed.Text = "Seed:";
            // 
            // seedTextBox
            // 
            this.seedTextBox.Location = new System.Drawing.Point(25, 135);
            this.seedTextBox.Name = "seedTextBox";
            this.seedTextBox.Size = new System.Drawing.Size(81, 23);
            this.seedTextBox.TabIndex = 4;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(25, 274);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(81, 23);
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "Save";
            this.saveButton.Click += new System.EventHandler(this.SaveImage);
            // 
            // metroLabelPixelSize
            // 
            this.metroLabelPixelSize.AutoSize = true;
            this.metroLabelPixelSize.Location = new System.Drawing.Point(25, 161);
            this.metroLabelPixelSize.Name = "metroLabelPixelSize";
            this.metroLabelPixelSize.Size = new System.Drawing.Size(66, 19);
            this.metroLabelPixelSize.TabIndex = 6;
            this.metroLabelPixelSize.Text = "Pixel Size:";
            // 
            // pixelSizeComboBox
            // 
            this.pixelSizeComboBox.FormattingEnabled = true;
            this.pixelSizeComboBox.ItemHeight = 23;
            this.pixelSizeComboBox.Location = new System.Drawing.Point(25, 183);
            this.pixelSizeComboBox.Name = "pixelSizeComboBox";
            this.pixelSizeComboBox.Size = new System.Drawing.Size(81, 29);
            this.pixelSizeComboBox.TabIndex = 7;
            // 
            // metroLabelAlpha
            // 
            this.metroLabelAlpha.AutoSize = true;
            this.metroLabelAlpha.Location = new System.Drawing.Point(25, 215);
            this.metroLabelAlpha.Name = "metroLabelAlpha";
            this.metroLabelAlpha.Size = new System.Drawing.Size(46, 19);
            this.metroLabelAlpha.TabIndex = 8;
            this.metroLabelAlpha.Text = "Alpha:";
            // 
            // alphaToggle
            // 
            this.alphaToggle.AutoSize = true;
            this.alphaToggle.Checked = true;
            this.alphaToggle.CheckState = System.Windows.Forms.CheckState.Checked;
            this.alphaToggle.Location = new System.Drawing.Point(25, 237);
            this.alphaToggle.Name = "alphaToggle";
            this.alphaToggle.Size = new System.Drawing.Size(80, 17);
            this.alphaToggle.Style = MetroFramework.MetroColorStyle.Magenta;
            this.alphaToggle.TabIndex = 9;
            this.alphaToggle.Text = "On";
            this.alphaToggle.Theme = MetroFramework.MetroThemeStyle.Light;
            this.alphaToggle.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 320);
            this.Controls.Add(this.alphaToggle);
            this.Controls.Add(this.metroLabelAlpha);
            this.Controls.Add(this.pixelSizeComboBox);
            this.Controls.Add(this.metroLabelPixelSize);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.seedTextBox);
            this.Controls.Add(this.metroLabelSeed);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.metroTile);
            this.Controls.Add(this.pictureBox);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Magenta;
            this.Text = "Random Image Generator";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private MetroFramework.Controls.MetroTile metroTile;
        private MetroFramework.Controls.MetroButton generateButton;
        private MetroFramework.Controls.MetroLabel metroLabelSeed;
        private MetroFramework.Controls.MetroTextBox seedTextBox;
        private MetroFramework.Controls.MetroButton saveButton;
        private MetroFramework.Controls.MetroLabel metroLabelPixelSize;
        private MetroFramework.Controls.MetroComboBox pixelSizeComboBox;
        private MetroFramework.Controls.MetroLabel metroLabelAlpha;
        private MetroFramework.Controls.MetroToggle alphaToggle;
    }
}

