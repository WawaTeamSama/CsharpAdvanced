namespace Program17
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblplayer = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblcomputer = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblresult = new System.Windows.Forms.Label();
            this.btnRock = new System.Windows.Forms.Button();
            this.btn = new System.Windows.Forms.Button();
            this.brnPeper = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(68, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "玩家手势";
            // 
            // lblplayer
            // 
            this.lblplayer.AutoSize = true;
            this.lblplayer.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblplayer.ForeColor = System.Drawing.Color.Blue;
            this.lblplayer.Location = new System.Drawing.Point(159, 38);
            this.lblplayer.Name = "lblplayer";
            this.lblplayer.Size = new System.Drawing.Size(0, 21);
            this.lblplayer.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(402, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "电脑手势";
            // 
            // lblcomputer
            // 
            this.lblcomputer.AutoSize = true;
            this.lblcomputer.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblcomputer.ForeColor = System.Drawing.Color.Red;
            this.lblcomputer.Location = new System.Drawing.Point(502, 38);
            this.lblcomputer.Name = "lblcomputer";
            this.lblcomputer.Size = new System.Drawing.Size(0, 21);
            this.lblcomputer.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(228, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "裁判:";
            // 
            // lblresult
            // 
            this.lblresult.AutoSize = true;
            this.lblresult.Location = new System.Drawing.Point(340, 134);
            this.lblresult.Name = "lblresult";
            this.lblresult.Size = new System.Drawing.Size(0, 12);
            this.lblresult.TabIndex = 5;
            // 
            // btnRock
            // 
            this.btnRock.Location = new System.Drawing.Point(70, 241);
            this.btnRock.Name = "btnRock";
            this.btnRock.Size = new System.Drawing.Size(99, 37);
            this.btnRock.TabIndex = 6;
            this.btnRock.Text = "石头";
            this.btnRock.UseVisualStyleBackColor = true;
            this.btnRock.Click += new System.EventHandler(this.btnRock_Click);
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(263, 241);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(88, 37);
            this.btn.TabIndex = 7;
            this.btn.Text = "剪刀";
            this.btn.UseVisualStyleBackColor = true;
            // 
            // brnPeper
            // 
            this.brnPeper.Location = new System.Drawing.Point(455, 241);
            this.brnPeper.Name = "brnPeper";
            this.brnPeper.Size = new System.Drawing.Size(91, 37);
            this.brnPeper.TabIndex = 8;
            this.brnPeper.Text = "布";
            this.brnPeper.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 349);
            this.Controls.Add(this.brnPeper);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.btnRock);
            this.Controls.Add(this.lblresult);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblcomputer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblplayer);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "剪刀石头布";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblplayer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblcomputer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblresult;
        private System.Windows.Forms.Button btnRock;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Button brnPeper;
    }
}

