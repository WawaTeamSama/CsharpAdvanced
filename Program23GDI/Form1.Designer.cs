namespace Program23GDI
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
            this.btnLine = new System.Windows.Forms.Button();
            this.btnRect = new System.Windows.Forms.Button();
            this.btnCrile = new System.Windows.Forms.Button();
            this.btnCuv = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLine
            // 
            this.btnLine.Location = new System.Drawing.Point(745, 32);
            this.btnLine.Name = "btnLine";
            this.btnLine.Size = new System.Drawing.Size(89, 26);
            this.btnLine.TabIndex = 0;
            this.btnLine.Text = "直线";
            this.btnLine.UseVisualStyleBackColor = true;
            this.btnLine.Click += new System.EventHandler(this.btnLine_Click);
            // 
            // btnRect
            // 
            this.btnRect.Location = new System.Drawing.Point(745, 87);
            this.btnRect.Name = "btnRect";
            this.btnRect.Size = new System.Drawing.Size(89, 22);
            this.btnRect.TabIndex = 1;
            this.btnRect.Text = "矩形";
            this.btnRect.UseVisualStyleBackColor = true;
            this.btnRect.Click += new System.EventHandler(this.btnRect_Click);
            // 
            // btnCrile
            // 
            this.btnCrile.Location = new System.Drawing.Point(745, 137);
            this.btnCrile.Name = "btnCrile";
            this.btnCrile.Size = new System.Drawing.Size(89, 23);
            this.btnCrile.TabIndex = 2;
            this.btnCrile.Text = "圆形";
            this.btnCrile.UseVisualStyleBackColor = true;
            this.btnCrile.Click += new System.EventHandler(this.btnCrile_Click);
            // 
            // btnCuv
            // 
            this.btnCuv.Location = new System.Drawing.Point(745, 187);
            this.btnCuv.Name = "btnCuv";
            this.btnCuv.Size = new System.Drawing.Size(89, 27);
            this.btnCuv.TabIndex = 3;
            this.btnCuv.Text = "扇形";
            this.btnCuv.UseVisualStyleBackColor = true;
            this.btnCuv.Click += new System.EventHandler(this.btnCuv_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 502);
            this.Controls.Add(this.btnCuv);
            this.Controls.Add(this.btnCrile);
            this.Controls.Add(this.btnRect);
            this.Controls.Add(this.btnLine);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLine;
        private System.Windows.Forms.Button btnRect;
        private System.Windows.Forms.Button btnCrile;
        private System.Windows.Forms.Button btnCuv;
    }
}

