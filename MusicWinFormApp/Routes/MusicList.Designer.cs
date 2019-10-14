namespace MusicWinFormApp.routes
{
    partial class MusicList
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.addFavoriteBtn = new System.Windows.Forms.Button();
            this.addCollectionBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // addFavoriteBtn
            // 
            this.addFavoriteBtn.FlatAppearance.BorderSize = 0;
            this.addFavoriteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addFavoriteBtn.Location = new System.Drawing.Point(278, 402);
            this.addFavoriteBtn.Name = "addFavoriteBtn";
            this.addFavoriteBtn.Size = new System.Drawing.Size(102, 30);
            this.addFavoriteBtn.TabIndex = 9;
            this.addFavoriteBtn.Text = "添加到最爱";
            this.addFavoriteBtn.UseVisualStyleBackColor = true;
            this.addFavoriteBtn.Click += new System.EventHandler(this.AddFavoriteBtn_Click);
            // 
            // addCollectionBtn
            // 
            this.addCollectionBtn.FlatAppearance.BorderSize = 0;
            this.addCollectionBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addCollectionBtn.Location = new System.Drawing.Point(64, 402);
            this.addCollectionBtn.Name = "addCollectionBtn";
            this.addCollectionBtn.Size = new System.Drawing.Size(102, 30);
            this.addCollectionBtn.TabIndex = 10;
            this.addCollectionBtn.Text = "添加到收藏";
            this.addCollectionBtn.UseVisualStyleBackColor = true;
            this.addCollectionBtn.Click += new System.EventHandler(this.AddCollectionBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "正在播放";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(64, 59);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(762, 324);
            this.listBox1.TabIndex = 7;
            this.listBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListBox1_MouseClick);
            // 
            // MusicList
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.addFavoriteBtn);
            this.Controls.Add(this.addCollectionBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "MusicList";
            this.Size = new System.Drawing.Size(886, 456);
            this.Load += new System.EventHandler(this.MusicList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addFavoriteBtn;
        private System.Windows.Forms.Button addCollectionBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
    }
}
