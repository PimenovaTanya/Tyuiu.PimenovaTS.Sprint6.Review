
namespace Tyuiu.PimenovaTS.Sprint6.TaskReview.V6
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.pictureBoxMe_PTS = new System.Windows.Forms.PictureBox();
            this.textBoxMe_PTS = new System.Windows.Forms.TextBox();
            this.buttonOK_PTS = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMe_PTS)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxMe_PTS
            // 
            this.pictureBoxMe_PTS.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxMe_PTS.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMe_PTS.Image")));
            this.pictureBoxMe_PTS.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxMe_PTS.Name = "pictureBoxMe_PTS";
            this.pictureBoxMe_PTS.Size = new System.Drawing.Size(192, 267);
            this.pictureBoxMe_PTS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMe_PTS.TabIndex = 0;
            this.pictureBoxMe_PTS.TabStop = false;
            // 
            // textBoxMe_PTS
            // 
            this.textBoxMe_PTS.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxMe_PTS.Location = new System.Drawing.Point(192, 0);
            this.textBoxMe_PTS.Multiline = true;
            this.textBoxMe_PTS.Name = "textBoxMe_PTS";
            this.textBoxMe_PTS.Size = new System.Drawing.Size(337, 226);
            this.textBoxMe_PTS.TabIndex = 1;
            this.textBoxMe_PTS.Text = resources.GetString("textBoxMe_PTS.Text");
            // 
            // buttonOK_PTS
            // 
            this.buttonOK_PTS.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonOK_PTS.Location = new System.Drawing.Point(425, 226);
            this.buttonOK_PTS.Name = "buttonOK_PTS";
            this.buttonOK_PTS.Size = new System.Drawing.Size(104, 41);
            this.buttonOK_PTS.TabIndex = 2;
            this.buttonOK_PTS.Text = "OK";
            this.buttonOK_PTS.UseVisualStyleBackColor = true;
            this.buttonOK_PTS.Click += new System.EventHandler(this.buttonOK_PTS_Click);
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 267);
            this.Controls.Add(this.buttonOK_PTS);
            this.Controls.Add(this.textBoxMe_PTS);
            this.Controls.Add(this.pictureBoxMe_PTS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMe_PTS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxMe_PTS;
        private System.Windows.Forms.TextBox textBoxMe_PTS;
        private System.Windows.Forms.Button buttonOK_PTS;
    }
}