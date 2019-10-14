using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicWinFormApp.Models
{
    public class Music
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LocalPath { get; set; }
        public int MusicType { get; set; }
    }
}
