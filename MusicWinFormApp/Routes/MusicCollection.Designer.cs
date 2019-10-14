namespace MusicWinFormApp.Routes
{
    partial class MusicCollection
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.removeFavorite = new System.Windows.Forms.Button();
            this.addFavoriteBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // removeFavorite
            // 
            this.removeFavorite.FlatAppearance.BorderSize = 0;
            this.removeFavorite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeFavorite.Location = new System.Drawing.Point(236, 402);
            this.removeFavorite.Name = "removeFavorite";
            this.removeFavorite.Size = new System.Drawing.Size(102, 30);
            this.removeFavorite.TabIndex = 5;
            this.removeFavorite.Text = "移除";
            this.removeFavorite.UseVisualStyleBackColor = true;
            this.removeFavorite.Click += new System.EventHandler(this.RemoveFavorite_Click);
            // 
            // addFavoriteBtn
            // 
            this.addFavoriteBtn.FlatAppearance.BorderSize = 0;
            this.addFavoriteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addFavoriteBtn.Location = new System.Drawing.Point(63, 402);
            this.addFavoriteBtn.Name = "addFavoriteBtn";
            this.addFavoriteBtn.Size = new System.Drawing.Size(102, 30);
            this.addFavoriteBtn.TabIndex = 6;
            this.addFavoriteBtn.Text = "添加到喜欢";
            this.addFavoriteBtn.UseVisualStyleBackColor = true;
            this.addFavoriteBtn.Click += new System.EventHandler(this.AddFavoriteBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "我收藏的歌曲";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(64, 59);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(762, 324);
            this.listBox1.TabIndex = 3;
            this.listBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListBox1_MouseClick);
            // 
            // MusicCollection
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.removeFavorite);
            this.Controls.Add(this.addFavoriteBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "MusicCollection";
            this.Size = new System.Drawing.Size(886, 456);
            this.Load += new System.EventHandler(this.MusicCollection_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button removeFavorite;
        private System.Windows.Forms.Button addFavoriteBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
    }
}
