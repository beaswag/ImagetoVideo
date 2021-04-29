namespace VideoGenerator
{
    partial class Form1
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
            this.outputBox = new System.Windows.Forms.TextBox();
            this.runButton = new System.Windows.Forms.Button();
            this.fileExportDialog = new System.Windows.Forms.SaveFileDialog();
            this.ImageDialog = new System.Windows.Forms.OpenFileDialog();
            this.AudioDialog = new System.Windows.Forms.OpenFileDialog();
            this.FFmpegOpen = new System.Windows.Forms.OpenFileDialog();
            this.imagePathText = new System.Windows.Forms.TextBox();
            this.imageSelectButton = new System.Windows.Forms.Button();
            this.audioPathButton = new System.Windows.Forms.Button();
            this.audioPathText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.videoPathButton = new System.Windows.Forms.Button();
            this.videoPathText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ffmpegPathButton = new System.Windows.Forms.Button();
            this.ffmpegPathText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // outputBox
            // 
            this.outputBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outputBox.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputBox.Location = new System.Drawing.Point(0, 276);
            this.outputBox.MaxLength = 0;
            this.outputBox.Multiline = true;
            this.outputBox.Name = "outputBox";
            this.outputBox.ReadOnly = true;
            this.outputBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.outputBox.Size = new System.Drawing.Size(612, 141);
            this.outputBox.TabIndex = 0;
            // 
            // runButton
            // 
            this.runButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.runButton.Location = new System.Drawing.Point(265, 198);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(86, 26);
            this.runButton.TabIndex = 1;
            this.runButton.Text = "Run";
            this.runButton.UseVisualStyleBackColor = true;
            this.runButton.Click += new System.EventHandler(this.runButton_Click);
            // 
            // fileExportDialog
            // 
            this.fileExportDialog.Filter = "MP4 file|*.mp4";
            this.fileExportDialog.RestoreDirectory = true;
            // 
            // ImageDialog
            // 
            this.ImageDialog.FileName = "openFileDialog1";
            this.ImageDialog.Filter = "Image file|*.png;*.jpeg;*.jpg;*.bmp;*.tiff;*.gif";
            this.ImageDialog.RestoreDirectory = true;
            // 
            // AudioDialog
            // 
            this.AudioDialog.FileName = "openFileDialog1";
            this.AudioDialog.Filter = "Audio file|*.wav;*.mp3;*.ogg;*.aiff;*.aac";
            this.AudioDialog.RestoreDirectory = true;
            // 
            // FFmpegOpen
            // 
            this.FFmpegOpen.FileName = "openFileDialog1";
            this.FFmpegOpen.Filter = "ffmpeg.exe|ffmpeg.exe";
            // 
            // imagePathText
            // 
            this.imagePathText.Location = new System.Drawing.Point(45, 90);
            this.imagePathText.Name = "imagePathText";
            this.imagePathText.ReadOnly = true;
            this.imagePathText.Size = new System.Drawing.Size(217, 20);
            this.imagePathText.TabIndex = 2;
            this.imagePathText.TextChanged += new System.EventHandler(this.imagePathText_TextChanged);
            // 
            // imageSelectButton
            // 
            this.imageSelectButton.Location = new System.Drawing.Point(268, 90);
            this.imageSelectButton.Name = "imageSelectButton";
            this.imageSelectButton.Size = new System.Drawing.Size(25, 20);
            this.imageSelectButton.TabIndex = 3;
            this.imageSelectButton.Text = "...";
            this.imageSelectButton.UseVisualStyleBackColor = true;
            this.imageSelectButton.Click += new System.EventHandler(this.imageSelectButton_Click);
            // 
            // audioPathButton
            // 
            this.audioPathButton.Location = new System.Drawing.Point(268, 149);
            this.audioPathButton.Name = "audioPathButton";
            this.audioPathButton.Size = new System.Drawing.Size(25, 20);
            this.audioPathButton.TabIndex = 5;
            this.audioPathButton.Text = "...";
            this.audioPathButton.UseVisualStyleBackColor = true;
            this.audioPathButton.Click += new System.EventHandler(this.audioPathButton_Click);
            // 
            // audioPathText
            // 
            this.audioPathText.Location = new System.Drawing.Point(45, 149);
            this.audioPathText.Name = "audioPathText";
            this.audioPathText.ReadOnly = true;
            this.audioPathText.Size = new System.Drawing.Size(217, 20);
            this.audioPathText.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(196, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "Jacko\'s image and audio to video tool\r\n(shitty name, i know)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Image path";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Audio path";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label4.Location = new System.Drawing.Point(286, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Output";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(335, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Video export path";
            // 
            // videoPathButton
            // 
            this.videoPathButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.videoPathButton.Location = new System.Drawing.Point(561, 91);
            this.videoPathButton.Name = "videoPathButton";
            this.videoPathButton.Size = new System.Drawing.Size(25, 20);
            this.videoPathButton.TabIndex = 11;
            this.videoPathButton.Text = "...";
            this.videoPathButton.UseVisualStyleBackColor = true;
            this.videoPathButton.Click += new System.EventHandler(this.videoPathButton_Click);
            // 
            // videoPathText
            // 
            this.videoPathText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.videoPathText.Location = new System.Drawing.Point(338, 91);
            this.videoPathText.Name = "videoPathText";
            this.videoPathText.ReadOnly = true;
            this.videoPathText.Size = new System.Drawing.Size(217, 20);
            this.videoPathText.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(335, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Path to \'ffmpeg.exe\'";
            // 
            // ffmpegPathButton
            // 
            this.ffmpegPathButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ffmpegPathButton.Location = new System.Drawing.Point(561, 149);
            this.ffmpegPathButton.Name = "ffmpegPathButton";
            this.ffmpegPathButton.Size = new System.Drawing.Size(25, 20);
            this.ffmpegPathButton.TabIndex = 14;
            this.ffmpegPathButton.Text = "...";
            this.ffmpegPathButton.UseVisualStyleBackColor = true;
            this.ffmpegPathButton.Click += new System.EventHandler(this.ffmpegPathButton_Click);
            // 
            // ffmpegPathText
            // 
            this.ffmpegPathText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ffmpegPathText.Location = new System.Drawing.Point(338, 149);
            this.ffmpegPathText.Name = "ffmpegPathText";
            this.ffmpegPathText.ReadOnly = true;
            this.ffmpegPathText.Size = new System.Drawing.Size(217, 20);
            this.ffmpegPathText.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 417);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ffmpegPathButton);
            this.Controls.Add(this.ffmpegPathText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.videoPathButton);
            this.Controls.Add(this.videoPathText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.audioPathButton);
            this.Controls.Add(this.audioPathText);
            this.Controls.Add(this.imageSelectButton);
            this.Controls.Add(this.imagePathText);
            this.Controls.Add(this.runButton);
            this.Controls.Add(this.outputBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox outputBox;
        private System.Windows.Forms.Button runButton;
        private System.Windows.Forms.SaveFileDialog fileExportDialog;
        private System.Windows.Forms.OpenFileDialog ImageDialog;
        private System.Windows.Forms.OpenFileDialog AudioDialog;
        private System.Windows.Forms.OpenFileDialog FFmpegOpen;
        private System.Windows.Forms.TextBox imagePathText;
        private System.Windows.Forms.Button imageSelectButton;
        private System.Windows.Forms.Button audioPathButton;
        private System.Windows.Forms.TextBox audioPathText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button videoPathButton;
        private System.Windows.Forms.TextBox videoPathText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button ffmpegPathButton;
        private System.Windows.Forms.TextBox ffmpegPathText;
    }
}