using System;
using System.Collections.Generic;

namespace Forum.Models
{
    public partial class Post
    {
        public Post()
        {
            Comment = new HashSet<Comment>();
            PostTag = new HashSet<PostTag>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int CreatorId { get; set; }
        public int CategoryId { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? LastEditionDate { get; set; }

        public virtual Category Category { get; set; }
        public virtual User Creator { get; set; }
        public virtual ICollection<Comment> Comment { get; set; }
        public virtual ICollection<PostTag> PostTag { get; set; }
    }
}
