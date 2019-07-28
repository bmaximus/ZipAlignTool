namespace ZipAlignTool
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtZipAlignPath = new System.Windows.Forms.TextBox();
            this.txtInApkFullPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOutApkFilePath = new System.Windows.Forms.TextBox();
            this.btnAlign = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Zip Align Exe path";
            // 
            // txtZipAlignPath
            // 
            this.txtZipAlignPath.Location = new System.Drawing.Point(142, 13);
            this.txtZipAlignPath.Name = "txtZipAlignPath";
            this.txtZipAlignPath.Size = new System.Drawing.Size(607, 22);
            this.txtZipAlignPath.TabIndex = 1;
            // 
            // txtInApkFullPath
            // 
            this.txtInApkFullPath.Location = new System.Drawing.Point(142, 42);
            this.txtInApkFullPath.Name = "txtInApkFullPath";
            this.txtInApkFullPath.Size = new System.Drawing.Size(607, 22);
            this.txtInApkFullPath.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "In APK Full Paht";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Out APK Full Paht";
            // 
            // txtOutApkFilePath
            // 
            this.txtOutApkFilePath.Enabled = false;
            this.txtOutApkFilePath.Location = new System.Drawing.Point(142, 70);
            this.txtOutApkFilePath.Name = "txtOutApkFilePath";
            this.txtOutApkFilePath.Size = new System.Drawing.Size(607, 22);
            this.txtOutApkFilePath.TabIndex = 4;
            // 
            // btnAlign
            // 
            this.btnAlign.Location = new System.Drawing.Point(628, 100);
            this.btnAlign.Name = "btnAlign";
            this.btnAlign.Size = new System.Drawing.Size(121, 31);
            this.btnAlign.TabIndex = 6;
            this.btnAlign.Text = "Align";
            this.btnAlign.UseVisualStyleBackColor = true;
            this.btnAlign.Click += new System.EventHandler(this.BtnAlign_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 143);
            this.Controls.Add(this.btnAlign);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtOutApkFilePath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtInApkFullPath);
            this.Controls.Add(this.txtZipAlignPath);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zip Align Tool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtZipAlignPath;
        private System.Windows.Forms.TextBox txtInApkFullPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOutApkFilePath;
        private System.Windows.Forms.Button btnAlign;
    }
}

