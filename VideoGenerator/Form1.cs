using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace VideoGenerator
{

    public partial class Form1 : Form
    {
        public string ffmpegPath = "";
        public string audioPath = "";
        public string imagePath = "";
        public string videoPath = "";
        private Process _cmd;


        public Form1()
        {
            InitializeComponent();
        }

        private void runButton_Click(object sender, EventArgs e)
        {
            if (!System.IO.File.Exists(ffmpegPath))
            {
                MessageBox.Show("FFmpeg path does not exist!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Path.GetFileName(ffmpegPath) != "ffmpeg.exe")
            {
                MessageBox.Show("FFmpeg path is not 'ffmpeg.exe'!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!System.IO.File.Exists(imagePath))
            {
                MessageBox.Show("Image path does not exist!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //string imageExtension = Path.GetExtension(imagePath);
            //Console.WriteLine(imageExtension);
            /* if (!imagePath.IsOneOf("png", ".jpeg", ".jpg", ".bmp", ".tiff", ".gif"))
            {
                MessageBox.Show("Image path is not picture file!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            } */

            if (!System.IO.File.Exists(audioPath))
            {
                MessageBox.Show("Audio path does not exist!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //doesnt work
            //will probably know the reason why after i have a good sleep

            //update: i still dont know

            //string audioExtension = Path.GetExtension(audioPath);
            /* if (!audioPath.IsOneOf("wav", ".mp3", ".ogg", ".aiff", ".aac"))
            {
                MessageBox.Show("Audio path is not audio file!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            } */

            Bitmap origImg = new Bitmap(imagePath);

            int imgWidth = origImg.Width;
            int imgHeight = origImg.Height;

            int newWidth = (int)Math.Ceiling((double)imgWidth / 2) * 2;
            int newHeight = (int)Math.Ceiling((double)imgHeight / 2) * 2;


            string param = "-y -loop 1 -i \"" + imagePath + "\" -i \"" + audioPath + "\" -c:v libx264 -preset ultrafast -tune stillimage -c:a aac -b:a 192k -pix_fmt yuv420p -vf scale=" + newWidth + ":" + newHeight + " -shortest \"" + videoPath;
            ProcessStartInfo processStartInfo1 = new ProcessStartInfo(ffmpegPath, param);
            ProcessStartInfo processStartInfo =
                processStartInfo1;

            processStartInfo.UseShellExecute = false;
            processStartInfo.ErrorDialog = false;
            processStartInfo.CreateNoWindow = true;

            processStartInfo.RedirectStandardError = true;
            processStartInfo.RedirectStandardInput = true;
            processStartInfo.RedirectStandardOutput = true;

            _cmd = new Process {
                StartInfo = processStartInfo
            };

            outputBox.Text = "\"" + ffmpegPath + "\" " + param + Environment.NewLine + Environment.NewLine;

            if (_cmd.Start())
            {
                _cmd.OutputDataReceived += new DataReceivedEventHandler(_cmd_OutputDataReceived);
                _cmd.ErrorDataReceived += new DataReceivedEventHandler(_cmd_ErrorDataReceived);
                _cmd.Exited += new EventHandler(_cmd_Exited);

                _cmd.BeginOutputReadLine();
                _cmd.BeginErrorReadLine();
            }
            else
            {
                _cmd = null;
            }

        }

        void _cmd_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            outputBox.Invoke(new Action(() => outputBox.AppendText(e.Data + Environment.NewLine)));
        }

        void _cmd_ErrorDataReceived(object sender, DataReceivedEventArgs e)
        {
            outputBox.Invoke(new Action(() => outputBox.AppendText(e.Data + Environment.NewLine)));
        }

        void _cmd_Exited(object sender, EventArgs e)
        {
            _cmd.OutputDataReceived -= new DataReceivedEventHandler(_cmd_OutputDataReceived);
            _cmd.Exited -= new EventHandler(_cmd_Exited);
            MessageBox.Show("Finish");
        }

        private void videoPathButton_Click(object sender, EventArgs e)
        {
            if (fileExportDialog.ShowDialog() == DialogResult.OK)
            {
                videoPath = fileExportDialog.FileName;
                videoPathText.Text = videoPath;
            }
        }

        private void imageSelectButton_Click(object sender, EventArgs e)
        {
            if (ImageDialog.ShowDialog() == DialogResult.OK)
            {
                imagePath = ImageDialog.FileName;
                imagePathText.Text = imagePath;
            }
        }

        private void audioPathButton_Click(object sender, EventArgs e)
        {
            if (AudioDialog.ShowDialog() == DialogResult.OK)
            {
                audioPath = AudioDialog.FileName;
                audioPathText.Text = audioPath;
            }
        }

        private void ffmpegPathButton_Click(object sender, EventArgs e)
        {
            if (FFmpegOpen.ShowDialog() == DialogResult.OK)
            {
                ffmpegPath = FFmpegOpen.FileName;
                ffmpegPathText.Text = ffmpegPath;
            }
        }

        private void imagePathText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
