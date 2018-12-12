using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Xml;

namespace AlbumLibrary
{
    public enum Tags { None, Holiday, Travels, Party, Family };

    [DataContract]
    public class Photo : PhotoObject
    {
        [DataMember]
        public string Description { get; set; }
        
        [DataMember]
        public string Path { get; private set; }
        
        [DataMember]
        public DateTime Date { get; set; }
        
        [DataMember]
        public Tags Tag { get; set; }

        ~Photo()
        {
            //XmlSerializer xmlSerializer = new XmlSerializer(typeof(Photo));

            //using (FileStream fs = new FileStream("C:\\Users\\Гост\\Desktop\\photos.xml",FileMode.OpenOrCreate))
            //{
            //    xmlSerializer.Serialize(fs,this);
            //}

        }


        public Photo()
            : base()
        {
            this.Description = String.Empty;
            this.Path = String.Empty;
            this.Tag = Tags.None;
            this.Date = DateTime.Now;
        }
        public Photo(string _title, string _description, string _path, Tags _tag):base(_title)
        {
            this.Description = _description;
            this.Path = _path;
            this.Tag = _tag;
            this.Date = DateTime.Now;
        }

        public override string ToString()
        {
            return Title;
        }

    }
}
