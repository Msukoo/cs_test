
namespace ThreadLockTest
{
    partial class Notice
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
            this.lNotice = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lNotice
            // 
            this.lNotice.FormattingEnabled = true;
            this.lNotice.ItemHeight = 15;
            this.lNotice.Location = new System.Drawing.Point(30, 47);
            this.lNotice.Name = "lNotice";
            this.lNotice.Size = new System.Drawing.Size(307, 214);
            this.lNotice.TabIndex = 0;
            // 
            // Notice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 315);
            this.Controls.Add(this.lNotice);
            this.Name = "Notice";
            this.Text = "Notice";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lNotice;
    }
}