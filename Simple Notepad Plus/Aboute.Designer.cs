﻿
namespace Simple_Notepad_Plus
{
    partial class Aboute
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
            this.lblProductName = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.lblProductVersion = new System.Windows.Forms.Label();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(12, 23);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(38, 15);
            this.lblProductName.TabIndex = 0;
            this.lblProductName.Text = "label1";
            this.lblProductName.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(116, 176);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "&OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lblProductVersion
            // 
            this.lblProductVersion.AutoSize = true;
            this.lblProductVersion.Location = new System.Drawing.Point(12, 48);
            this.lblProductVersion.Name = "lblProductVersion";
            this.lblProductVersion.Size = new System.Drawing.Size(38, 15);
            this.lblProductVersion.TabIndex = 2;
            this.lblProductVersion.Text = "label2";
            // 
            // lblCopyright
            // 
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.Location = new System.Drawing.Point(12, 75);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(38, 15);
            this.lblCopyright.TabIndex = 3;
            this.lblCopyright.Text = "label3";
            // 
            // Aboute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 211);
            this.Controls.Add(this.lblCopyright);
            this.Controls.Add(this.lblProductVersion);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblProductName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Aboute";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About";
            this.Load += new System.EventHandler(this.Aboute_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblProductVersion;
        private System.Windows.Forms.Label lblCopyright;
    }
}