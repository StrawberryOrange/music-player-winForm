namespace MusicWinFormApp
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.toolBarPanel = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.minLabel = new System.Windows.Forms.Label();
            this.CollectionBtn = new System.Windows.Forms.Button();
            this.exitLabel = new System.Windows.Forms.Label();
            this.FavoriteBtn = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.historyBtn = new System.Windows.Forms.Button();
            this.homeBtn = new System.Windows.Forms.Button();
            this.musicPanel = new System.Windows.Forms.Panel();
            this.playlistLabel = new System.Windows.Forms.Label();
            this.MusicBar = new System.Windows.Forms.ProgressBar();
            this.Next = new System.Windows.Forms.Label();
            this.Previous = new System.Windows.Forms.Label();
            this.PlayOrPause = new System.Windows.Forms.Label();
            this.axWMP = new AxWMPLib.AxWindowsMediaPlayer();
            this.routePanel = new System.Windows.Forms.Panel();
            this.progressTimer = new System.Windows.Forms.Timer(this.components);
            this.toolBarPanel.SuspendLayout();
            this.musicPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWMP)).BeginInit();
            this.SuspendLayout();
            // 
            // toolBarPanel
            // 
            this.toolBarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(118)))), ((int)(((byte)(228)))));
            this.toolBarPanel.Controls.Add(this.button4);
            this.toolBarPanel.Controls.Add(this.minLabel);
            this.toolBarPanel.Controls.Add(this.CollectionBtn);
            this.toolBarPanel.Controls.Add(this.exitLabel);
            this.toolBarPanel.Controls.Add(this.FavoriteBtn);
            this.toolBarPanel.Controls.Add(this.titleLabel);
            this.toolBarPanel.Controls.Add(this.historyBtn);
            this.toolBarPanel.Controls.Add(this.homeBtn);
            this.toolBarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.toolBarPanel.Location = new System.Drawing.Point(0, 0);
            this.toolBarPanel.Margin = new System.Windows.Forms.Padding(4);
            this.toolBarPanel.Name = "toolBarPanel";
            this.toolBarPanel.Size = new System.Drawing.Size(901, 40);
            this.toolBarPanel.TabIndex = 0;
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.SystemColors.Window;
            this.button4.Location = new System.Drawing.Point(412, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(85, 40);
            this.button4.TabIndex = 0;
            this.button4.Text = "关  于";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // minLabel
            // 
            this.minLabel.AutoSize = true;
            this.minLabel.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.minLabel.Location = new System.Drawing.Point(847, 8);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(22, 24);
            this.minLabel.TabIndex = 1;
            this.minLabel.Text = "-";
            this.minLabel.Click += new System.EventHandler(this.minLabel_Click);
            // 
            // CollectionBtn
            // 
            this.CollectionBtn.FlatAppearance.BorderSize = 0;
            this.CollectionBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CollectionBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.CollectionBtn.Location = new System.Drawing.Point(327, 0);
            this.CollectionBtn.Name = "CollectionBtn";
            this.CollectionBtn.Size = new System.Drawing.Size(85, 40);
            this.CollectionBtn.TabIndex = 0;
            this.CollectionBtn.Text = "我的收藏";
            this.CollectionBtn.UseVisualStyleBackColor = true;
            this.CollectionBtn.Click += new System.EventHandler(this.CollectionBtn_Click);
            // 
            // exitLabel
            // 
            this.exitLabel.AutoSize = true;
            this.exitLabel.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.exitLabel.Image = ((System.Drawing.Image)(resources.GetObject("exitLabel.Image")));
            this.exitLabel.Location = new System.Drawing.Point(875, 8);
            this.exitLabel.Name = "exitLabel";
            this.exitLabel.Size = new System.Drawing.Size(22, 24);
            this.exitLabel.TabIndex = 1;
            this.exitLabel.Text = " ";
            this.exitLabel.Click += new System.EventHandler(this.exitLabel_Click);
            // 
            // FavoriteBtn
            // 
            this.FavoriteBtn.FlatAppearance.BorderSize = 0;
            this.FavoriteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FavoriteBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.FavoriteBtn.Location = new System.Drawing.Point(242, 0);
            this.FavoriteBtn.Name = "FavoriteBtn";
            this.FavoriteBtn.Size = new System.Drawing.Size(85, 40);
            this.FavoriteBtn.TabIndex = 0;
            this.FavoriteBtn.Text = "我的最爱";
            this.FavoriteBtn.UseVisualStyleBackColor = true;
            this.FavoriteBtn.Click += new System.EventHandler(this.FavoriteBtn_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.titleLabel.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.titleLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.titleLabel.Location = new System.Drawing.Point(15, 10);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(49, 20);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "音乐";
            this.titleLabel.Click += new System.EventHandler(this.titleLabel_Click);
            // 
            // historyBtn
            // 
            this.historyBtn.FlatAppearance.BorderSize = 0;
            this.historyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.historyBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.historyBtn.Location = new System.Drawing.Point(157, 0);
            this.historyBtn.Name = "historyBtn";
            this.historyBtn.Size = new System.Drawing.Size(85, 40);
            this.historyBtn.TabIndex = 0;
            this.historyBtn.Text = "播放列表";
            this.historyBtn.UseVisualStyleBackColor = true;
            this.historyBtn.Click += new System.EventHandler(this.HistoryBtn_Click);
            // 
            // homeBtn
            // 
            this.homeBtn.FlatAppearance.BorderSize = 0;
            this.homeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.homeBtn.Location = new System.Drawing.Point(72, 0);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Size = new System.Drawing.Size(85, 40);
            this.homeBtn.TabIndex = 0;
            this.homeBtn.Text = "主  页";
            this.homeBtn.UseVisualStyleBackColor = true;
            this.homeBtn.Click += new System.EventHandler(this.HomeBtn_Click);
            // 
            // musicPanel
            // 
            this.musicPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(118)))), ((int)(((byte)(231)))));
            this.musicPanel.Controls.Add(this.playlistLabel);
            this.musicPanel.Controls.Add(this.MusicBar);
            this.musicPanel.Controls.Add(this.Next);
            this.musicPanel.Controls.Add(this.Previous);
            this.musicPanel.Controls.Add(this.PlayOrPause);
            this.musicPanel.Controls.Add(this.axWMP);
            this.musicPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.musicPanel.Location = new System.Drawing.Point(0, 512);
            this.musicPanel.Margin = new System.Windows.Forms.Padding(4);
            this.musicPanel.Name = "musicPanel";
            this.musicPanel.Size = new System.Drawing.Size(901, 76);
            this.musicPanel.TabIndex = 1;
            // 
            // playlistLabel
            // 
            this.playlistLabel.AutoSize = true;
            this.playlistLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.playlistLabel.Location = new System.Drawing.Point(823, 32);
            this.playlistLabel.Name = "playlistLabel";
            this.playlistLabel.Size = new System.Drawing.Size(40, 16);
            this.playlistLabel.TabIndex = 9;
            this.playlistLabel.Text = "列表";
            this.playlistLabel.Click += new System.EventHandler(this.PlaylistLabel_Click);
            // 
            // MusicBar
            // 
            this.MusicBar.Location = new System.Drawing.Point(158, 39);
            this.MusicBar.Name = "MusicBar";
            this.MusicBar.Size = new System.Drawing.Size(642, 3);
            this.MusicBar.TabIndex = 8;
            this.MusicBar.Click += new System.EventHandler(this.MusicBar_Click);
            // 
            // Next
            // 
            this.Next.AutoSize = true;
            this.Next.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Next.Image = ((System.Drawing.Image)(resources.GetObject("Next.Image")));
            this.Next.Location = new System.Drawing.Point(102, 31);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(24, 16);
            this.Next.TabIndex = 4;
            this.Next.Text = "  ";
            this.Next.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // Previous
            // 
            this.Previous.AutoSize = true;
            this.Previous.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Previous.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Previous.Image = ((System.Drawing.Image)(resources.GetObject("Previous.Image")));
            this.Previous.Location = new System.Drawing.Point(32, 31);
            this.Previous.Name = "Previous";
            this.Previous.Size = new System.Drawing.Size(24, 16);
            this.Previous.TabIndex = 5;
            this.Previous.Text = "  ";
            this.Previous.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Previous.Click += new System.EventHandler(this.Previous_Click);
            // 
            // PlayOrPause
            // 
            this.PlayOrPause.AutoSize = true;
            this.PlayOrPause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PlayOrPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlayOrPause.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PlayOrPause.Image = global::MusicWinFormApp.Properties.Resources.play;
            this.PlayOrPause.Location = new System.Drawing.Point(64, 29);
            this.PlayOrPause.Name = "PlayOrPause";
            this.PlayOrPause.Size = new System.Drawing.Size(29, 20);
            this.PlayOrPause.TabIndex = 6;
            this.PlayOrPause.Text = "  ";
            this.PlayOrPause.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.PlayOrPause.Click += new System.EventHandler(this.PlayOrPause_Click);
            // 
            // axWMP
            // 
            this.axWMP.Enabled = true;
            this.axWMP.Location = new System.Drawing.Point(674, 47);
            this.axWMP.Name = "axWMP";
            this.axWMP.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWMP.OcxState")));
            this.axWMP.Size = new System.Drawing.Size(49, 32);
            this.axWMP.TabIndex = 0;
            this.axWMP.Visible = false;
            this.axWMP.Enter += new System.EventHandler(this.axWMP_Enter);
            // 
            // routePanel
            // 
            this.routePanel.AutoScroll = true;
            this.routePanel.Location = new System.Drawing.Point(8, 49);
            this.routePanel.Name = "routePanel";
            this.routePanel.Size = new System.Drawing.Size(886, 456);
            this.routePanel.TabIndex = 3;
            // 
            // progressTimer
            // 
            this.progressTimer.Tick += new System.EventHandler(this.ProgressTimer_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(901, 588);
            this.Controls.Add(this.routePanel);
            this.Controls.Add(this.musicPanel);
            this.Controls.Add(this.toolBarPanel);
            this.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "音乐播放器";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.toolBarPanel.ResumeLayout(false);
            this.toolBarPanel.PerformLayout();
            this.musicPanel.ResumeLayout(false);
            this.musicPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWMP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel toolBarPanel;
        private System.Windows.Forms.Panel musicPanel;
        private AxWMPLib.AxWindowsMediaPlayer axWMP;
        private System.Windows.Forms.Button homeBtn;
        private System.Windows.Forms.Button historyBtn;
        private System.Windows.Forms.Button CollectionBtn;
        private System.Windows.Forms.Button FavoriteBtn;
        private System.Windows.Forms.Label minLabel;
        private System.Windows.Forms.Label exitLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Panel routePanel;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ProgressBar MusicBar;
        private System.Windows.Forms.Label Next;
        private System.Windows.Forms.Label Previous;
        private System.Windows.Forms.Label PlayOrPause;
        private System.Windows.Forms.Timer progressTimer;
        private System.Windows.Forms.Label playlistLabel;
    }
}

