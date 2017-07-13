using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FilmReview_MVC_Website.Models
{
    public class Comment
    {
        public virtual int CommentID { get; set; }
        public virtual int FilmID { get; set; }
        public virtual int UserID { get; set; }
        public virtual string CommentReply { get; set; }
    }
}