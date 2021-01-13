using System;
using System.Collections.Generic;

namespace Forum.Models
{
    public partial class Comment
    {
        public Comment()
        {
            Point = new HashSet<Point>();
        }

        public int Id { get; set; }
        public string Content { get; set; }
        public int PostId { get; set; }
        public int CreatorId { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime LastEditionDate { get; set; }

        public virtual User Creator { get; set; }
        public virtual Post Post { get; set; }
        public virtual ICollection<Point> Point { get; set; }
    }
}
