using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MusicWinFormApp.XmlRepositories;
using MusicWinFormApp.Models;
using System.IO;

namespace MusicWinFormApp.routes
{
    public partial class Home : UserControl
    {
        private readonly MainForm _main;
        private MusicsRepository _music = new MusicsRepository();
        public Home(MainForm main)
        {
            InitializeComponent();
            _main = main;
        }

        private void Home_Load(object sender, EventArgs e)
        {
            _music.LoadXMLFile();
            List<int> listen = new List<int>() { 5, 41, 32, 100, 35, 10, 22 };
            List<int> week = new List<int>() { 1, 2, 3, 4, 5, 6, 7 };
            chart1.Series[0].Points.DataBindXY(week,listen);
            lastPlayMusicName.Text = MusicTemp.LastMusic.Name;
        }

        private void OpenFileBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "请选择文件";
            ofd.Multiselect = true;
            ofd.InitialDirectory = @"C:\Users\Surface\Desktop\dazuoye";
            ofd.Filter = "mp3文件|*.mp3|音乐文件|*.wav|所有文件|*.*";
            ofd.ShowDialog();
            string[] path = ofd.FileNames;
            for (int i = 0; i < path.Length; i++)
            {
                MusicTemp.PlayList.Add(new Music { Name = Path.GetFileName(path[i]), LocalPath = path[i] });
            }
        }
    }
}
