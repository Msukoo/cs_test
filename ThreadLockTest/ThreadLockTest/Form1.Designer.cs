
namespace ThreadLockTest
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSetNum = new System.Windows.Forms.Button();
            this.numOfNum = new System.Windows.Forms.NumericUpDown();
            this.lNumberView = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.numOfNum)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSetNum
            // 
            this.btnSetNum.Location = new System.Drawing.Point(289, 29);
            this.btnSetNum.Name = "btnSetNum";
            this.btnSetNum.Size = new System.Drawing.Size(86, 31);
            this.btnSetNum.TabIndex = 0;
            this.btnSetNum.Text = "번호부여";
            this.btnSetNum.UseVisualStyleBackColor = true;
            this.btnSetNum.Click += new System.EventHandler(this.btnSetNum_Click);
            // 
            // numOfNum
            // 
            this.numOfNum.Location = new System.Drawing.Point(176, 35);
            this.numOfNum.Name = "numOfNum";
            this.numOfNum.Size = new System.Drawing.Size(107, 25);
            this.numOfNum.TabIndex = 1;
            // 
            // lNumberView
            // 
            this.lNumberView.FormattingEnabled = true;
            this.lNumberView.ItemHeight = 15;
            this.lNumberView.Location = new System.Drawing.Point(14, 75);
            this.lNumberView.Name = "lNumberView";
            this.lNumberView.Size = new System.Drawing.Size(361, 169);
            this.lNumberView.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 266);
            this.Controls.Add(this.lNumberView);
            this.Controls.Add(this.numOfNum);
            this.Controls.Add(this.btnSetNum);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numOfNum)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSetNum;
        private System.Windows.Forms.NumericUpDown numOfNum;
        private System.Windows.Forms.ListBox lNumberView;
    }
}

