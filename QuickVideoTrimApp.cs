/**
 * QuickVideoTrim
 * Copyright (c) Simon Raichl 2025
 */

using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace QuickVideoTrim
{
    public partial class QuickVideoTrimApp : Form
    {
        public QuickVideoTrimApp()
        {
            InitializeComponent();
        }

        private void ImportVideoButtonOnClick(object sender, EventArgs e)
        {
            DialogResult importVideoResult = importVideoDialog.ShowDialog();

            if (importVideoResult != DialogResult.OK)
            {
                return;
            }

            exportVideoDialog.FileName = importVideoDialog.FileName.Split('\\').Last();
        }

        private void ExportVideoButtonOnClick(object sender, EventArgs e)
        {
            DialogResult saveVideoResult = exportVideoDialog.ShowDialog();

            if (saveVideoResult == DialogResult.OK)
            {
                Process videoRenderer = new Process()
                {
                    StartInfo = new ProcessStartInfo
                    {
                        FileName = "ffmpeg.exe",
                        Arguments = GetTrimArguments(),
                    }
                };

                videoRenderer.Start();
            }
        }

        private string GetTrimArguments()
        {
            string extension = ".mp4";

            try
            {
                FileInfo videoInfo = new FileInfo(importVideoDialog.FileName);
                extension = videoInfo.Extension;
            }
            catch (Exception e)
            {
                MessageBox.Show($"Cannot get video extension: {e.Message}");
            }

            string arguments = $"-i \"{importVideoDialog.FileName}\" " +
                $"-ss {trimStart.Text} " +
                $"-to {trimEnd.Text} " +
                $"-c:v copy -c:a " +
                $"copy \"{exportVideoDialog.FileName.Replace(extension, "")}" +
                $"{extension}\"";

            Clipboard.SetText("ffmpeg " + arguments);

            return arguments;
        }
    }
}

