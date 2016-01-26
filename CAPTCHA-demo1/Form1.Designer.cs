namespace CAPTCHA_demo1
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.picVcode = new System.Windows.Forms.PictureBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnRefresh1 = new System.Windows.Forms.Button();
            this.picVcode1 = new System.Windows.Forms.PictureBox();
            this.btnRefresh2 = new System.Windows.Forms.Button();
            this.picVcode2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picVcode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVcode1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVcode2)).BeginInit();
            this.SuspendLayout();
            // 
            // picVcode
            // 
            this.picVcode.BackColor = System.Drawing.Color.White;
            this.picVcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picVcode.Location = new System.Drawing.Point(120, 12);
            this.picVcode.Name = "picVcode";
            this.picVcode.Size = new System.Drawing.Size(139, 50);
            this.picVcode.TabIndex = 0;
            this.picVcode.TabStop = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(276, 12);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(104, 50);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "刷新";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnRefresh1
            // 
            this.btnRefresh1.Location = new System.Drawing.Point(276, 105);
            this.btnRefresh1.Name = "btnRefresh1";
            this.btnRefresh1.Size = new System.Drawing.Size(104, 50);
            this.btnRefresh1.TabIndex = 3;
            this.btnRefresh1.Text = "刷新";
            this.btnRefresh1.UseVisualStyleBackColor = true;
            this.btnRefresh1.Click += new System.EventHandler(this.btnRefresh1_Click);
            // 
            // picVcode1
            // 
            this.picVcode1.BackColor = System.Drawing.Color.White;
            this.picVcode1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picVcode1.Location = new System.Drawing.Point(120, 105);
            this.picVcode1.Name = "picVcode1";
            this.picVcode1.Size = new System.Drawing.Size(139, 50);
            this.picVcode1.TabIndex = 2;
            this.picVcode1.TabStop = false;
            // 
            // btnRefresh2
            // 
            this.btnRefresh2.Location = new System.Drawing.Point(276, 199);
            this.btnRefresh2.Name = "btnRefresh2";
            this.btnRefresh2.Size = new System.Drawing.Size(104, 50);
            this.btnRefresh2.TabIndex = 5;
            this.btnRefresh2.Text = "刷新";
            this.btnRefresh2.UseVisualStyleBackColor = true;
            this.btnRefresh2.Click += new System.EventHandler(this.btnRefresh2_Click);
            // 
            // picVcode2
            // 
            this.picVcode2.BackColor = System.Drawing.Color.White;
            this.picVcode2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picVcode2.Location = new System.Drawing.Point(120, 199);
            this.picVcode2.Name = "picVcode2";
            this.picVcode2.Size = new System.Drawing.Size(139, 50);
            this.picVcode2.TabIndex = 4;
            this.picVcode2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "数字验证码：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "数字字母验证码：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "汉字验证码：";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(197, 286);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(119, 12);
            this.linkLabel1.TabIndex = 9;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "happynetlife@qq.com";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "2016-01-24  点石网络 王兴民";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 310);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRefresh2);
            this.Controls.Add(this.picVcode2);
            this.Controls.Add(this.btnRefresh1);
            this.Controls.Add(this.picVcode1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.picVcode);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "验证码生成";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picVcode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVcode1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVcode2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picVcode;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnRefresh1;
        private System.Windows.Forms.PictureBox picVcode1;
        private System.Windows.Forms.Button btnRefresh2;
        private System.Windows.Forms.PictureBox picVcode2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label4;
    }
}

