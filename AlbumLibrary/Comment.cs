using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace AlbumLibrary
{
    [DataContract]
    public class Comment
    {
        public static List<Comment> Comments = new List<Comment>();

        [DataMember]
        public readonly Guid Id;
        [DataMember]
        public User Sender { get; private set; }
        [DataMember]
        public string MessageText { get; private set; }

        public Comment() : this(null,"") { }

        public Comment(User _sender, string _text)
        {
            Id = Guid.NewGuid();
            Sender = _sender;
            MessageText = _text;
            Comments.Add(this);
        }

        public void Delete()
        {
            Comments.Remove(this);
        }

        public override string ToString()
        {
            return Sender + ": " + MessageText;
        }
    }
}
