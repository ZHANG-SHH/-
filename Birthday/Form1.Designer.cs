namespace Birthday
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
            this.提示输入框 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // 提示输入框
            // 
            this.提示输入框.AutoSize = true;
            this.提示输入框.Location = new System.Drawing.Point(50, 41);
            this.提示输入框.Name = "提示输入框";
            this.提示输入框.Size = new System.Drawing.Size(127, 15);
            this.提示输入框.TabIndex = 0;
            this.提示输入框.Text = "请输入您的生日：";
            this.提示输入框.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 571);
            this.Controls.Add(this.提示输入框);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label 提示输入框;
    }
}

