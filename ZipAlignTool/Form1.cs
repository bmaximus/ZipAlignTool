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
            FindZipAlignPath();
            FindApkSignPath();
        }
        private string ZipAlignStartPath = @"C:\Program Files (x86)\";
        private string ApkSignStartPath = @"C:\Program Files (x86)\";

        private void FindZipAlignPath()
        {
            if (Directory.Exists(ZipAlignStartPath))
            {
                ZipAlignStartPath += @"Android\";
                if (Directory.Exists(ZipAlignStartPath))
                {
                    ZipAlignStartPath += @"android-sdk\";
                    if (Directory.Exists(ZipAlignStartPath))
                    {
                        ZipAlignStartPath += @"build-tools\";
                        if (Directory.Exists(ZipAlignStartPath))
                        {
                            var latestVersion = Directory.GetDirectories(ZipAlignStartPath).OrderByDescending(d => d).FirstOrDefault();

                            if (!string.IsNullOrWhiteSpace(latestVersion) && Directory.Exists((ZipAlignStartPath = latestVersion + "\\")))
                            {
                                ZipAlignStartPath += @"zipalign.exe";
                                if (File.Exists(ZipAlignStartPath))
                                {
                                    txtZipAlignPath.Text = ZipAlignStartPath;
                                    return;
                                }
                            }
                        }
                    }
                }
            }

        }

        private void FindApkSignPath()
        {
            if (Directory.Exists(ApkSignStartPath))
            {
                ApkSignStartPath += @"Android\";
                if (Directory.Exists(ApkSignStartPath))
                {
                    ApkSignStartPath += @"android-sdk\";
                    if (Directory.Exists(ApkSignStartPath))
                    {
                        ApkSignStartPath += @"build-tools\";
                        if (Directory.Exists(ApkSignStartPath))
                        {
                            var latestVersion = Directory.GetDirectories(ApkSignStartPath).OrderByDescending(d => d).FirstOrDefault();

                            if (!string.IsNullOrWhiteSpace(latestVersion) && Directory.Exists((ApkSignStartPath = latestVersion + "\\")))
                            {
                                ApkSignStartPath += @"apksigner.bat";
                                if (File.Exists(ApkSignStartPath))
                                {
                                    txtApkSignPath.Text = ApkSignStartPath;
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
            outFilePath += @"\" + fName;
            txtOutApkFilePath.Text = outFilePath;


            if (MessageBox.Show("Calculate? ", "", MessageBoxButtons.OK) == DialogResult.OK)
            {
                var args = $"-v 4 \"{inFilePath}\" \"{outFilePath}\"";
                //var pi = new ProcessStartInfo(zipAlignPath, args);
                try
                {
                   var t =  Task.Run(() =>
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
                    });
                    t.Wait();
                    txtInKsPath.Text = outFilePath;
                    //txtOutApkSignPath.Text = outFilePath;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void BtnSign_Click(object sender, EventArgs e)
        {
            string signApkPath;
            if (string.IsNullOrEmpty((signApkPath = txtApkSignPath.Text)) || !File.Exists(signApkPath))
            {
                MessageBox.Show("Please verify that the Apk Sign file path is correct and the ApkSigner.bat exists.");
                return;
            }

            string inKsFilePath;
            if (string.IsNullOrEmpty((inKsFilePath = txtInKsPath.Text)) || !File.Exists(inKsFilePath))
            {
                MessageBox.Show("In Ks file path is empty or file is missing");
                return;
            }


            string inFilePath;
            if (string.IsNullOrEmpty((inFilePath = txtInApkSignPath.Text)) || !File.Exists(inFilePath))
            {
                MessageBox.Show("In APK file path is empty or file is missing");
                return;
            }            

            if (MessageBox.Show("Sign? ", "", MessageBoxButtons.OK) == DialogResult.OK)
            {
                var args = $"sign --ks \"{inKsFilePath}\" \"{inFilePath}\"";
                try
                {
                    var t = Task.Run(() =>
                    {
                        Process process = new Process();
                        ProcessStartInfo startInfo = new ProcessStartInfo
                        {
                            WindowStyle = ProcessWindowStyle.Hidden,
                            FileName = signApkPath,
                            Arguments = "/C " + args
                        };
                        process.StartInfo = startInfo;
                        process.Start();
                        process.WaitForExit();
                    });
                    t.Wait();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
