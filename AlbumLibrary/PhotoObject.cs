using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace AlbumLibrary
{
    [DataContract]
    public abstract class PhotoObject
    {
        [DataMember]
        public string Title { get; set; }

        // for lab 4 comments is anonymous comments list
        [DataMember]
        public List<Comment> Comments { get; set; }
        [DataMember]
        public readonly Guid Id;

        public PhotoObject() : this("") { }


        public PhotoObject(string title)
        {
            Id = Guid.NewGuid();
            Title = title;
            Comments = new List<Comment>();
        }

        // Liskov Substitution Principle.
        // Наследующий класс должен дополнять, а не замещать поведение базового класса.
        // Классы должны быть открыты для расширения, но закрыты для изменения.
        public void AddComment(User sender, string commentText)
        {
            Comments.Add(new Comment(sender, commentText));
        }

        // overload method to add anonymous comment(lab4).
        public void AddComment(string commentText)
        {
            Comments.Add(new AnonymousComment(commentText));
        }

        public void DeleteComment(Guid idToDelete)
        {
            var indexToDelete = Comments.FindIndex(x => x.Id == idToDelete);
            Comments.Find(x => x.Id == idToDelete).Delete();
            if (indexToDelete >= 0) Comments.RemoveAt(indexToDelete);
            
        }

    }
}
