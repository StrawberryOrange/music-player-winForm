using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MusicWinFormApp.Models;
using MusicWinFormApp.XmlRepositories;

namespace MusicWinFormApp.routes
{
    public partial class MusicList : UserControl
    {
        private readonly MainForm _main;
        private MusicsRepository _music = new MusicsRepository();
        private Music music = new Music();
        public MusicList(MainForm main)
        {
            InitializeComponent();
            _main = main;
        }

        private void MusicList_Load(object sender, EventArgs e)
        {
            listBox1.DataSource = MusicTemp.PlayList;
            listBox1.DisplayMember = "Name";
        }

        private void AddCollectionBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(music.Name))
            {
                music.MusicType = 2;
                _music.AddXMLElement(music);
                _music.LoadXMLFile();
            }
            else
            {

            }
        }

        private void ListBox1_MouseClick(object sender, MouseEventArgs e)
        {
            int index = listBox1.IndexFromPoint(e.X, e.Y);
            listBox1.SelectedIndex = index;
            if (listBox1.SelectedIndex != -1)
            {
                 music = listBox1.SelectedItem as Music;
            }
        }

        private void AddFavoriteBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(music.Name))
            {
                music.MusicType = 1;
                _music.AddXMLElement(music);
                _music.LoadXMLFile();
            }
            else
            {

            }
        }
    }
}
