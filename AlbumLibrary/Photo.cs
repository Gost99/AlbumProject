using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlbumLibrary
{
    public enum Tags { None, Holiday, Travels, Party, Family };

    public class Photo : PhotoObject
    {
        public string Description { get; set; }
        public string Path { get; private set; }
        public DateTime Date { get; set; }
        public Tags Tag { get; set; }
        

        public Photo() : base()
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
