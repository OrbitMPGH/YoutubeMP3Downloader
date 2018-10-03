using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using YoutubeExtractor;
using NAudio.Wave;

namespace YoutubeMP3Downloader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void DownloadButton_Click(object sender, EventArgs e)
        {
            Download(textBox1.Text);
        }

        private void Download(string link)
        {
            int index = link.IndexOf('=');
            string id = link.Remove(0, index+1);
            label3.Text = "Loading...";
            IEnumerable<VideoInfo> videoinfos = DownloadUrlResolver.GetDownloadUrls("https://www.youtube.com/watch?v=" + id);
            VideoInfo video = videoinfos.First();

            if (video.RequiresDecryption)
                DownloadUrlResolver.DecryptDownloadUrl(video);
            VideoDownloader videoDownloader;
            String name;
            if (String.IsNullOrWhiteSpace(textBox2.Text))
                name = video.Title;
            else
                name = textBox2.Text;
            videoDownloader = new VideoDownloader(video, Path.Combine(Application.StartupPath, name + video.VideoExtension));
            currentlyDownloading.Text = video.Title;
            label3.Text = "Downloading...";
            videoDownloader.DownloadProgressChanged += (sender, args) => barchange(sender, args);
            videoDownloader.DownloadFinished += (sender, args) => Convert(Path.Combine(Application.StartupPath, name + video.VideoExtension), name);
            Thread download = new Thread(() => { videoDownloader.Execute(); }) { IsBackground = true };
            download.Start();
        }
        delegate void StringArgReturningVoidDelegate(string text);

        private void SetText(string text)
        {
            if (this.label3.InvokeRequired)
            {
                StringArgReturningVoidDelegate d = new StringArgReturningVoidDelegate(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.label3.Text = text;
            }
        }

        private void Convert(string path, string name)
        {
            this.SetText("Converting...");
            using (var reader = new MediaFoundationReader(path))
            {
                MediaFoundationEncoder.EncodeToMp3(reader, Path.Combine(Application.StartupPath, name + ".mp3"));
            }
            File.Delete(path);
            this.SetText("Done!");
        }

        private void barchange(object sender, ProgressEventArgs e)
        {
            Invoke(new MethodInvoker(delegate ()
            {
                progressBar1.Value = (int)e.ProgressPercentage;
                procent.Text = (int)e.ProgressPercentage + "%";
            }));
        }
    }
}
