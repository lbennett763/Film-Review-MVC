using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FilmReview_MVC_Website.Models
{
    public class AgeRating
    {
        public virtual int AgeRatingID { get; set; }
        public virtual string AgeRatingName { get; set; }
    }
}