using System;
using System.Net;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SR
{
    public partial class Downloader : Form
    {
        public Downloader()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(url.Text) ||
                (String.IsNullOrEmpty(path.Text)||
                 (string.IsNullOrEmpty(fname.Text))))
            {
                status.Text = "Field id empty!";
                return;
            }
            string Your_Link = url.Text;
                string FolderPath = path.Text+"\\";
                string FileName = fname.Text;
                string FileExtension = Your_Link.Substring(Your_Link.LastIndexOf("."));

                Download();

                void Download()
                {
                    using (var client = new WebClient())
                    {
                        try
                        {
                            client.DownloadFile(new Uri(Your_Link), FolderPath + FileName + FileExtension);
                            Console.WriteLine($"File {FileName + FileExtension} downloaded to {FolderPath}");
                            status.Text = "Download complete";
                    }
                        catch (Exception exc)
                        {
                            Console.WriteLine(exc.Message);
                        }
                    }
                }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            url.Text = string.Empty;
            path.Text = string.Empty;
            fname.Text = string.Empty;
            status.Text = string.Empty;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Close program?", "Exit", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                Application.Exit();
        }

        private void btnpath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbdp = new FolderBrowserDialog();
            fbdp.Description = "Choose destination folder";
            if (fbdp.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                path.Text = fbdp.SelectedPath;
            }

        }

        private void strpbtninfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Програма для скачування файлів\nРозробленна Чумаченко Дмитром");
        }
    }
}
