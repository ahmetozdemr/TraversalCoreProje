using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete.Destination
{
    public class Comment
    {
        public int CommentID { get; set; }
        public string CommentUser { get; set; }
        public DateTime CommentDate { get; set; }
        public string CommentContent { get; set; }
        public bool CommentState { get; set; }
        public int DestinationID { get; set; }
        public Destination Destination { get; set; }
    }
}
