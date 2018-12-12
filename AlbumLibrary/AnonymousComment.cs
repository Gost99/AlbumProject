using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace AlbumLibrary
{
    [DataContract]
    public class AnonymousComment:Comment
    {
        // Создать интерфейс IComentable
        public AnonymousComment(string commentText) : base(null, commentText) { }

        
    }
}
