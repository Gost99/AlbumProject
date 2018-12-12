using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace AlbumLibrary
{
    [DataContract]
    public class Album : PhotoObject, IEnumerable
    {
        private int _photoCounter;
        [DataMember]
        public Photo FrontImage;
        [DataMember]
        public List<Photo> Photos;
        [DataMember]
        public int Count
        {
            get { return _photoCounter; }
            private set { _photoCounter = value; }
        }

        ~Album()
        {

        }

        public Album() : base() { }
        
        public Album(string _albumTitle) : base(_albumTitle)
        {
            Photos = new List<Photo>();
            this._photoCounter = 0;
        }

        public void AddNewPhoto(Photo _newPhoto)
        {
            Photos.Add(_newPhoto);
            _photoCounter++;
            if (Photos.Count == 1)
                FrontImage = Photos[0];
        }

        public void DeletePhoto(Guid idToDelete)
        {
            var indexToDelete = Photos.FindIndex(x => x.Id == idToDelete);
            if (indexToDelete >= 0)
                Photos.RemoveAt(indexToDelete);
        }

        // Overload method to delete photo(lab4)
        public void DeletePhoto(string photoTitleToDelete)
        {
            var indexToDelte = Photos.FindIndex(x => x.Title == photoTitleToDelete);
            if (indexToDelte != 0)
                Photos.RemoveAt(indexToDelte);

        }

        public override string ToString()
        {
            return Title;
        }

        // IEnumerable implement (lab4).
        public IEnumerator GetEnumerator()
        {
            return Photos.GetEnumerator();
        }
    }
}
