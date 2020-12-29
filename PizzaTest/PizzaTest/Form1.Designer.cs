
namespace PizzaTest
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radiobread1 = new System.Windows.Forms.RadioButton();
            this.radiobread2 = new System.Windows.Forms.RadioButton();
            this.radioEdge2 = new System.Windows.Forms.RadioButton();
            this.radioEdge1 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.num = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.order = new System.Windows.Forms.Button();
            this.lBoxOrder = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radiobread2);
            this.groupBox1.Controls.Add(this.radiobread1);
            this.groupBox1.Location = new System.Drawing.Point(23, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(528, 73);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "도우";
            // 
            // radiobread1
            // 
            this.radiobread1.AutoSize = true;
            this.radiobread1.Location = new System.Drawing.Point(17, 36);
            this.radiobread1.Name = "radiobread1";
            this.radiobread1.Size = new System.Drawing.Size(88, 19);
            this.radiobread1.TabIndex = 1;
            this.radiobread1.TabStop = true;
            this.radiobread1.Text = "오리지널";
            this.radiobread1.UseVisualStyleBackColor = true;
            // 
            // radiobread2
            // 
            this.radiobread2.AutoSize = true;
            this.radiobread2.Location = new System.Drawing.Point(167, 36);
            this.radiobread2.Name = "radiobread2";
            this.radiobread2.Size = new System.Drawing.Size(43, 19);
            this.radiobread2.TabIndex = 2;
            this.radiobread2.TabStop = true;
            this.radiobread2.Text = "씬";
            this.radiobread2.UseVisualStyleBackColor = true;
            this.radiobread2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioEdge2
            // 
            this.radioEdge2.AutoSize = true;
            this.radioEdge2.Location = new System.Drawing.Point(167, 36);
            this.radioEdge2.Name = "radioEdge2";
            this.radioEdge2.Size = new System.Drawing.Size(118, 19);
            this.radioEdge2.TabIndex = 2;
            this.radioEdge2.TabStop = true;
            this.radioEdge2.Text = "치즈크러스트";
            this.radioEdge2.UseVisualStyleBackColor = true;
            // 
            // radioEdge1
            // 
            this.radioEdge1.AutoSize = true;
            this.radioEdge1.Location = new System.Drawing.Point(17, 36);
            this.radioEdge1.Name = "radioEdge1";
            this.radioEdge1.Size = new System.Drawing.Size(88, 19);
            this.radioEdge1.TabIndex = 1;
            this.radioEdge1.TabStop = true;
            this.radioEdge1.Text = "리치골드";
            this.radioEdge1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioEdge2);
            this.groupBox2.Controls.Add(this.radioEdge1);
            this.groupBox2.Location = new System.Drawing.Point(23, 134);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(528, 73);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "엣지";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.num);
            this.groupBox3.Controls.Add(this.checkBox3);
            this.groupBox3.Controls.Add(this.checkBox2);
            this.groupBox3.Controls.Add(this.checkBox1);
            this.groupBox3.Location = new System.Drawing.Point(28, 238);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(522, 161);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "토핑";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(26, 32);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(74, 19);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "소세지";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(26, 68);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(59, 19);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "감자";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(26, 105);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(59, 19);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "치즈";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // num
            // 
            this.num.Location = new System.Drawing.Point(336, 128);
            this.num.Name = "num";
            this.num.Size = new System.Drawing.Size(79, 25);
            this.num.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(421, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "ea";
            // 
            // order
            // 
            this.order.Location = new System.Drawing.Point(475, 405);
            this.order.Name = "order";
            this.order.Size = new System.Drawing.Size(75, 23);
            this.order.TabIndex = 8;
            this.order.Text = "order";
            this.order.UseVisualStyleBackColor = true;
            this.order.Click += new System.EventHandler(this.order_Click);
            // 
            // lBoxOrder
            // 
            this.lBoxOrder.FormattingEnabled = true;
            this.lBoxOrder.ItemHeight = 15;
            this.lBoxOrder.Location = new System.Drawing.Point(34, 444);
            this.lBoxOrder.Name = "lBoxOrder";
            this.lBoxOrder.Size = new System.Drawing.Size(516, 184);
            this.lBoxOrder.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 652);
            this.Controls.Add(this.lBoxOrder);
            this.Controls.Add(this.order);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radiobread2;
        private System.Windows.Forms.RadioButton radiobread1;
        private System.Windows.Forms.RadioButton radioEdge2;
        private System.Windows.Forms.RadioButton radioEdge1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown num;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button order;
        private System.Windows.Forms.ListBox lBoxOrder;
    }
}

