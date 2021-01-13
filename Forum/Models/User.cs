using System;
using System.Collections.Generic;

namespace Forum.Models
{
    public partial class User
    {
        public User()
        {
            Comment = new HashSet<Comment>();
            Point = new HashSet<Point>();
            Post = new HashSet<Post>();
        }

        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Nick { get; set; }
        public DateTime RegistrationDate { get; set; }
        public DateTime LastPasswordChangedDate { get; set; }

        public virtual ICollection<Comment> Comment { get; set; }
        public virtual ICollection<Point> Point { get; set; }
        public virtual ICollection<Post> Post { get; set; }
    }
}
