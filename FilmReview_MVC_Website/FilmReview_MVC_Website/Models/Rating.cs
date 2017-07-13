using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FilmReview_MVC_Website.Models
{
    public class Rating
    {
        public virtual int RatingID { get; set; }
        public virtual int FilmID { get; set; }
        public virtual int UserID { get; set; }
        public virtual int RatingScore { get; set; }
    }
}