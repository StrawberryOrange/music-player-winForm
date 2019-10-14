using MusicWinFormApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace MusicWinFormApp.XmlRepositories
{
    public class MusicsRepository
    {
        private string musicXmlFilePath = @"./XmlFiles/Musics.xml";
        public static List<Music> musicList = new List<Music>();
        private static XmlDocument xml = new XmlDocument();

        public void LoadXMLFile()
        {
            musicList.Clear();
            List<Music> musicListTemp = new List<Music>();
            xml.Load(musicXmlFilePath);
            XmlNode xnRoot = xml.SelectSingleNode("musics");
            XmlNodeList xnl = xnRoot.ChildNodes;
            foreach (XmlNode xn in xnl)
            {
                XmlNodeList xnc = xn.ChildNodes;
                Music music = new Music
                {
                    Id = Convert.ToInt16(xnc.Item(0).InnerText),
                    Name = xnc.Item(1).InnerText,
                    LocalPath = xnc.Item(2).InnerText,
                    MusicType = Convert.ToInt16(xnc.Item(3).InnerText)
                };
                musicListTemp.Add(music);
            }
            for (int i = 0; i < musicListTemp.Count; i++)
            {
                musicList.Add(musicListTemp[musicListTemp.Count - i - 1]);
            }
            MusicTemp.Musics = musicList;
        }

        public IEnumerable<Music> FindMusicByType(int musicType)
        {
            var music = MusicTemp.Musics.Where(x => x.MusicType == musicType).ToList();
            return music;
        }

        public bool AddXMLElement(Music music)
        {
            music.Id = (MusicTemp.Musics[0].Id + 1);
            try
            {
                XDocument xdoc = XDocument.Load(musicXmlFilePath);
                xml.Load(musicXmlFilePath);
                XElement xnRoot = xdoc.Root;
                XElement musicElement = new XElement("music");
                xnRoot.Add(musicElement);
                musicElement.SetElementValue("id", music.Id);
                musicElement.SetElementValue("name", music.Name);
                musicElement.SetElementValue("laoclpath", music.LocalPath);
                musicElement.SetElementValue("musictype", music.MusicType);
                xdoc.Save(musicXmlFilePath);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteXMLElement(int _id)
        {
            try
            {
                XDocument xdoc = XDocument.Load(musicXmlFilePath);
                XElement xnRoot = xdoc.Root;
                XElement xnMusic = xnRoot.Elements("music").Where(x => x.Element("id").Value == _id.ToString()).Single();
                xnMusic.Remove();
                xdoc.Save(musicXmlFilePath);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool ModifyXMLElement(int _id, Music music)
        {
            try
            {
                XDocument xdoc = XDocument.Load(musicXmlFilePath);
                XElement xnRoot = xdoc.Root;
                XElement xnMusic = xnRoot.Elements("music").Where(x => x.Element("id").Value == _id.ToString()).Single();
                xnMusic.SetElementValue("id", music.Id);
                xnMusic.SetElementValue("name", music.Name);
                xnMusic.SetElementValue("laoclpath", music.LocalPath);
                xnMusic.SetElementValue("musictype", music.MusicType);
                xdoc.Save(musicXmlFilePath);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
