
namespace BatchZIP
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
            this.BtnOk = new System.Windows.Forms.Button();
            this.BtnOpenEnter = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.EnterPath = new System.Windows.Forms.TextBox();
            this.OutPath = new System.Windows.Forms.TextBox();
            this.BtnOpenOut = new System.Windows.Forms.Button();
            this.ckCustom = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // BtnOk
            // 
            this.BtnOk.Location = new System.Drawing.Point(409, 156);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(75, 33);
            this.BtnOk.TabIndex = 2;
            this.BtnOk.Text = "确定";
            this.BtnOk.UseVisualStyleBackColor = true;
            this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // BtnOpenEnter
            // 
            this.BtnOpenEnter.Location = new System.Drawing.Point(341, 12);
            this.BtnOpenEnter.Name = "BtnOpenEnter";
            this.BtnOpenEnter.Size = new System.Drawing.Size(75, 32);
            this.BtnOpenEnter.TabIndex = 4;
            this.BtnOpenEnter.Text = "浏览...";
            this.BtnOpenEnter.UseVisualStyleBackColor = true;
            this.BtnOpenEnter.Click += new System.EventHandler(this.BtnOpen_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(16, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(387, 60);
            this.label2.TabIndex = 5;
            this.label2.Text = "自定义日期：\r\n1.按照yyyy-mm-dd hh:mm:ss填入ReplaceDateTime.txt\r\n2.若不自定义日期 则为当前日期\r\n3.默认为MD5文" +
    "件加密后名称";
            // 
            // EnterPath
            // 
            this.EnterPath.Location = new System.Drawing.Point(12, 18);
            this.EnterPath.Name = "EnterPath";
            this.EnterPath.Size = new System.Drawing.Size(305, 25);
            this.EnterPath.TabIndex = 6;
            this.EnterPath.Text = "请选择文件输入地址";
            this.EnterPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // OutPath
            // 
            this.OutPath.Location = new System.Drawing.Point(12, 57);
            this.OutPath.Name = "OutPath";
            this.OutPath.Size = new System.Drawing.Size(305, 25);
            this.OutPath.TabIndex = 7;
            this.OutPath.Text = "请选择文件输出地址";
            this.OutPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnOpenOut
            // 
            this.BtnOpenOut.Location = new System.Drawing.Point(341, 56);
            this.BtnOpenOut.Name = "BtnOpenOut";
            this.BtnOpenOut.Size = new System.Drawing.Size(75, 32);
            this.BtnOpenOut.TabIndex = 8;
            this.BtnOpenOut.Text = "浏览...";
            this.BtnOpenOut.UseVisualStyleBackColor = true;
            this.BtnOpenOut.Click += new System.EventHandler(this.BtnOpenOut_Click);
            // 
            // ckCustom
            // 
            this.ckCustom.AutoSize = true;
            this.ckCustom.Location = new System.Drawing.Point(19, 94);
            this.ckCustom.Name = "ckCustom";
            this.ckCustom.Size = new System.Drawing.Size(104, 19);
            this.ckCustom.TabIndex = 9;
            this.ckCustom.Text = "自定义日期";
            this.ckCustom.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 198);
            this.Controls.Add(this.ckCustom);
            this.Controls.Add(this.BtnOpenOut);
            this.Controls.Add(this.OutPath);
            this.Controls.Add(this.EnterPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnOpenEnter);
            this.Controls.Add(this.BtnOk);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "文件夹批量打包";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnOk;
        private System.Windows.Forms.Button BtnOpenEnter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox EnterPath;
        private System.Windows.Forms.TextBox OutPath;
        private System.Windows.Forms.Button BtnOpenOut;
        private System.Windows.Forms.CheckBox ckCustom;
    }
}

