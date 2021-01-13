using System;
using System.Collections.Generic;

namespace Forum.Models
{
    public partial class Point
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int CommentId { get; set; }
        public DateTime DateOfAddition { get; set; }

        public virtual Comment Comment { get; set; }
        public virtual User User { get; set; }
    }
}
