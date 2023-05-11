
namespace SeleniumTest
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
            this.btnOpenBrw = new System.Windows.Forms.Button();
            this.btnOpenBrw2 = new System.Windows.Forms.Button();
            this.txbURL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGetMail = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOpenBrw
            // 
            this.btnOpenBrw.Location = new System.Drawing.Point(398, 135);
            this.btnOpenBrw.Name = "btnOpenBrw";
            this.btnOpenBrw.Size = new System.Drawing.Size(234, 73);
            this.btnOpenBrw.TabIndex = 0;
            this.btnOpenBrw.Text = "CLose Browser";
            this.btnOpenBrw.UseVisualStyleBackColor = true;
            this.btnOpenBrw.Click += new System.EventHandler(this.btnOpenBrw_Click);
            // 
            // btnOpenBrw2
            // 
            this.btnOpenBrw2.Location = new System.Drawing.Point(50, 130);
            this.btnOpenBrw2.Name = "btnOpenBrw2";
            this.btnOpenBrw2.Size = new System.Drawing.Size(263, 78);
            this.btnOpenBrw2.TabIndex = 1;
            this.btnOpenBrw2.Text = "Open Browser 2";
            this.btnOpenBrw2.UseVisualStyleBackColor = true;
            this.btnOpenBrw2.Click += new System.EventHandler(this.btnOpenBrw2_Click);
            // 
            // txbURL
            // 
            this.txbURL.Location = new System.Drawing.Point(108, 80);
            this.txbURL.Name = "txbURL";
            this.txbURL.Size = new System.Drawing.Size(566, 20);
            this.txbURL.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "URL";
            // 
            // btnGetMail
            // 
            this.btnGetMail.Location = new System.Drawing.Point(78, 282);
            this.btnGetMail.Name = "btnGetMail";
            this.btnGetMail.Size = new System.Drawing.Size(75, 23);
            this.btnGetMail.TabIndex = 4;
            this.btnGetMail.Text = "Get mail";
            this.btnGetMail.UseVisualStyleBackColor = true;
            this.btnGetMail.Click += new System.EventHandler(this.btnGetMail_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 360);
            this.Controls.Add(this.btnGetMail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbURL);
            this.Controls.Add(this.btnOpenBrw2);
            this.Controls.Add(this.btnOpenBrw);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpenBrw;
        private System.Windows.Forms.Button btnOpenBrw2;
        private System.Windows.Forms.TextBox txbURL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGetMail;
    }
}

