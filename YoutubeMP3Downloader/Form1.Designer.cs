namespace YoutubeMP3Downloader
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
            this.textbox0 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.procent = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DownloadButton = new System.Windows.Forms.Button();
            this.currentlyDownloading = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textbox0
            // 
            this.textbox0.AutoSize = true;
            this.textbox0.Location = new System.Drawing.Point(75, 9);
            this.textbox0.Name = "textbox0";
            this.textbox0.Size = new System.Drawing.Size(119, 13);
            this.textbox0.TabIndex = 0;
            this.textbox0.Text = "Currently Downloading: ";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 102);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(260, 23);
            this.progressBar1.TabIndex = 1;
            // 
            // procent
            // 
            this.procent.AutoSize = true;
            this.procent.Location = new System.Drawing.Point(125, 107);
            this.procent.Name = "procent";
            this.procent.Size = new System.Drawing.Size(21, 13);
            this.procent.TabIndex = 2;
            this.procent.Text = "0%";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 187);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Youtube Link";
            // 
            // DownloadButton
            // 
            this.DownloadButton.Location = new System.Drawing.Point(173, 184);
            this.DownloadButton.Name = "DownloadButton";
            this.DownloadButton.Size = new System.Drawing.Size(75, 23);
            this.DownloadButton.TabIndex = 5;
            this.DownloadButton.Text = "Download";
            this.DownloadButton.UseVisualStyleBackColor = true;
            this.DownloadButton.Click += new System.EventHandler(this.DownloadButton_Click);
            // 
            // currentlyDownloading
            // 
            this.currentlyDownloading.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.currentlyDownloading.Location = new System.Drawing.Point(12, 43);
            this.currentlyDownloading.Margin = new System.Windows.Forms.Padding(0);
            this.currentlyDownloading.Name = "currentlyDownloading";
            this.currentlyDownloading.ReadOnly = true;
            this.currentlyDownloading.Size = new System.Drawing.Size(260, 20);
            this.currentlyDownloading.TabIndex = 6;
            this.currentlyDownloading.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Status: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Waiting...";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(148, 229);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.currentlyDownloading);
            this.Controls.Add(this.DownloadButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.procent);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.textbox0);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label textbox0;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label procent;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DownloadButton;
        private System.Windows.Forms.TextBox currentlyDownloading;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
    }
}

