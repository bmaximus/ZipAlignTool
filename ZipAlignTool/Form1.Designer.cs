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
            this.btnSign = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtInApkSignPath = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtInKsPath = new System.Windows.Forms.TextBox();
            this.txtApkSignPath = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
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
            this.txtZipAlignPath.Location = new System.Drawing.Point(139, 13);
            this.txtZipAlignPath.Name = "txtZipAlignPath";
            this.txtZipAlignPath.Size = new System.Drawing.Size(610, 22);
            this.txtZipAlignPath.TabIndex = 1;
            // 
            // txtInApkFullPath
            // 
            this.txtInApkFullPath.Location = new System.Drawing.Point(139, 42);
            this.txtInApkFullPath.Name = "txtInApkFullPath";
            this.txtInApkFullPath.Size = new System.Drawing.Size(610, 22);
            this.txtInApkFullPath.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "In APK Full Path";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Out APK Full Path";
            // 
            // txtOutApkFilePath
            // 
            this.txtOutApkFilePath.Enabled = false;
            this.txtOutApkFilePath.Location = new System.Drawing.Point(139, 70);
            this.txtOutApkFilePath.Name = "txtOutApkFilePath";
            this.txtOutApkFilePath.Size = new System.Drawing.Size(610, 22);
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
            // btnSign
            // 
            this.btnSign.Location = new System.Drawing.Point(628, 232);
            this.btnSign.Name = "btnSign";
            this.btnSign.Size = new System.Drawing.Size(121, 31);
            this.btnSign.TabIndex = 13;
            this.btnSign.Text = "Sign";
            this.btnSign.UseVisualStyleBackColor = true;
            this.btnSign.Click += new System.EventHandler(this.BtnSign_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "In APK Full Path";
            // 
            // txtInApkSignPath
            // 
            this.txtInApkSignPath.Location = new System.Drawing.Point(139, 202);
            this.txtInApkSignPath.Name = "txtInApkSignPath";
            this.txtInApkSignPath.Size = new System.Drawing.Size(610, 22);
            this.txtInApkSignPath.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "In .ks Full Path";
            // 
            // txtInKsPath
            // 
            this.txtInKsPath.Location = new System.Drawing.Point(139, 174);
            this.txtInKsPath.Name = "txtInKsPath";
            this.txtInKsPath.Size = new System.Drawing.Size(610, 22);
            this.txtInKsPath.TabIndex = 9;
            // 
            // txtApkSignPath
            // 
            this.txtApkSignPath.Location = new System.Drawing.Point(139, 145);
            this.txtApkSignPath.Name = "txtApkSignPath";
            this.txtApkSignPath.Size = new System.Drawing.Size(610, 22);
            this.txtApkSignPath.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "ApkSign bat path";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 363);
            this.Controls.Add(this.btnSign);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtInApkSignPath);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtInKsPath);
            this.Controls.Add(this.txtApkSignPath);
            this.Controls.Add(this.label6);
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
        private System.Windows.Forms.Button btnSign;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtInApkSignPath;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtInKsPath;
        private System.Windows.Forms.TextBox txtApkSignPath;
        private System.Windows.Forms.Label label6;
    }
}

