using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZipAlignTool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            FindZipAlignAPath();
        }
        private string StartPath = @"C:\Program Files (x86)\";
        private void FindZipAlignAPath()
        {
           if (Directory.Exists(StartPath))
            {
                StartPath += @"Android\";
                if (Directory.Exists(StartPath))
                {
                    StartPath += @"android-sdk\";
                    if (Directory.Exists(StartPath))
                    {
                        StartPath += @"build-tools\";
                        if (Directory.Exists(StartPath))
                        {
                            var latestVersion = Directory.GetDirectories(StartPath).OrderByDescending(d=>d).FirstOrDefault();

                            if (!string.IsNullOrWhiteSpace(latestVersion) && Directory.Exists((StartPath = latestVersion+"\\")))
                            {
                                StartPath += @"zipalign.exe";
                                if (File.Exists(StartPath))
                                {
                                    txtZipAlignPath.Text = StartPath;
                                    return;
                                }
                            }
                        }
                    }
                }
            }
            
        }

        private void BtnAlign_Click(object sender, EventArgs e)
        {
            string zipAlignPath;
            if (string.IsNullOrEmpty((zipAlignPath = txtZipAlignPath.Text)) || !File.Exists(zipAlignPath))
            {
                MessageBox.Show("Please verify that the Zip Allign file path is correct and the ZipAlign.exe exists.");
                return;
            }

            string inFilePath;
            if (string.IsNullOrEmpty((inFilePath = txtInApkFullPath.Text)) || !File.Exists(inFilePath))
            {
                MessageBox.Show("In APK file path is empty or file is missing");
                return;
            }
            var fName = Path.GetFileName(inFilePath);
            string outFilePath = Directory.CreateDirectory(inFilePath.Substring(0, inFilePath.IndexOf(fName)) + $@"Aligned_{DateTime.Now.ToString("dd-MM-yy HH-mm-ss")}").FullName;
            outFilePath += @"\"+fName;
            txtOutApkFilePath.Text = outFilePath;


            if(MessageBox.Show("Calculate? ", "", MessageBoxButtons.OK) == DialogResult.OK)
            {
                var args = $"-v 4 \"{inFilePath}\" \"{outFilePath}\"";
                //var pi = new ProcessStartInfo(zipAlignPath, args);

                try
                {
                    Process process = new Process();
                    ProcessStartInfo startInfo = new ProcessStartInfo
                    {
                        WindowStyle = ProcessWindowStyle.Hidden,
                        FileName = zipAlignPath,
                        Arguments = "/C " + args
                    };
                    process.StartInfo = startInfo;
                    process.Start();
                    process.WaitForExit();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }
    }
}
