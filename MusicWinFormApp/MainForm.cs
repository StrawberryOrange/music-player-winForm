using MusicWinFormApp.Models;
using MusicWinFormApp.routes;
using MusicWinFormApp.Routes;
using MusicWinFormApp.XmlRepositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace MusicWinFormApp
{
    public partial class MainForm : Form
    {
        private LastMusic _last = new LastMusic();
        private bool isPlay = false;
        private int index = 0;
        private double max = 0;
        private double value = 0;
        public MainForm()
        {
            InitializeComponent();
        }

        public void Clear() => routePanel.Controls.Clear();
        public void Home() => routePanel.Controls.Add(new Home(this));
        public void MusicList() => routePanel.Controls.Add(new MusicList(this));
        public void MusicFavorite() => routePanel.Controls.Add(new MusicFavorite());
        public void MusicHistory() => routePanel.Controls.Add(new MusicHistory());
        public void MusicCollection() => routePanel.Controls.Add(new MusicCollection());

        private void exitLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _last.LoadXMLFile();
            Clear();
            Home();
        }

        private void minLabel_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void titleLabel_Click(object sender, EventArgs e)
        {
            Clear();
            Home();
        }

        private void PlayOrPause_Click(object sender, EventArgs e)
        {
            if (!isPlay)
            {
                if (MusicTemp.PlayList.Count != 0)
                {
                    axWMP.URL = MusicTemp.PlayList[index].LocalPath;
                    axWMP.Ctlcontrols.play();
                    PlayOrPause.Image = global::MusicWinFormApp.Properties.Resources.pause;
                    isPlay = true;
                    _last.ModifyXMLElement(0, MusicTemp.PlayList[index]);
                }
                
                else
                {
                    MessageBox.Show("还未添加歌曲");
                }
            }
            else
            {
                axWMP.Ctlcontrols.pause();
                PlayOrPause.Image = global::MusicWinFormApp.Properties.Resources.play;
                isPlay = false;
            }
        }

        private void Previous_Click(object sender, EventArgs e)
        {
            index--;
            if (index < 0)
            {
                index = MusicTemp.PlayList.Count - 1;
            }
            axWMP.URL = MusicTemp.PlayList[index].LocalPath;
            axWMP.Ctlcontrols.play();
            _last.ModifyXMLElement(0, MusicTemp.PlayList[index]);
        }

        private void Next_Click(object sender, EventArgs e)
        {
            index++;
            if (index == MusicTemp.PlayList.Count)
            {
                index = 0;
            }
            axWMP.URL = MusicTemp.PlayList[index].LocalPath;
            axWMP.Ctlcontrols.play();
            _last.ModifyXMLElement(0, MusicTemp.PlayList[index]);
        }

        private void ProgressTimer_Tick(object sender, EventArgs e)
        {
            max = axWMP.currentMedia.duration;
            value = axWMP.Ctlcontrols.currentPosition;

            MusicBar.Maximum = (int)max;
            MusicBar.Value = (int)value;

            if (axWMP.playState == WMPPlayState.wmppsStopped)
            {
                index++;
                if (index == MusicTemp.PlayList.Count)
                {
                    index = 0;
                }
                axWMP.URL = MusicTemp.PlayList[index].LocalPath;
                axWMP.Ctlcontrols.play();
            }
        }

        private void PlaylistLabel_Click(object sender, EventArgs e)
        {
            Clear();
            MusicList();
        }

        private void HistoryBtn_Click(object sender, EventArgs e)
        {
            Clear();
            MusicList();
        }

        private void FavoriteBtn_Click(object sender, EventArgs e)
        {
            Clear();
            MusicFavorite();
        }

        private void CollectionBtn_Click(object sender, EventArgs e)
        {
            Clear();
            MusicCollection();
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            Clear();
            Home();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void MusicBar_Click(object sender, EventArgs e)
        {

        }

        private void axWMP_Enter(object sender, EventArgs e)
        {

        }
    }
}
