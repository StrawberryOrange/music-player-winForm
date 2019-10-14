using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicWinFormApp.Models
{
    public class MusicTemp
    {
        public static List<Music> Musics =new List<Music>();
        public static List<Music> PlayList=new List<Music>();
        public static Music LastMusic = new Music();
    }
}
