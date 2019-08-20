namespace screenshot
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.main_screen = new System.Windows.Forms.Button();
            this.sub_screen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // main_screen
            // 
            this.main_screen.Location = new System.Drawing.Point(12, 12);
            this.main_screen.Name = "main_screen";
            this.main_screen.Size = new System.Drawing.Size(100, 100);
            this.main_screen.TabIndex = 0;
            this.main_screen.Text = "Main";
            this.main_screen.UseVisualStyleBackColor = true;
            this.main_screen.Click += new System.EventHandler(this.main_screen_Click);
            // 
            // sub_screen
            // 
            this.sub_screen.Location = new System.Drawing.Point(124, 12);
            this.sub_screen.Name = "sub_screen";
            this.sub_screen.Size = new System.Drawing.Size(100, 100);
            this.sub_screen.TabIndex = 1;
            this.sub_screen.Text = "Sub";
            this.sub_screen.UseVisualStyleBackColor = true;
            this.sub_screen.Click += new System.EventHandler(this.sub_screen_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(236, 123);
            this.Controls.Add(this.sub_screen);
            this.Controls.Add(this.main_screen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "screenshot";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button main_screen;
        private System.Windows.Forms.Button sub_screen;
    }
}

