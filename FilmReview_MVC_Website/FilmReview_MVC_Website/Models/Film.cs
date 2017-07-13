using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FilmReview_MVC_Website.Models
{
    public class Film
    {
        public virtual int FilmID { get; set; }
        public virtual string Film_Title { get; set; }
        public virtual int Runninig_Time { get; set; }
        public virtual DateTime Year_Released { get; set; }
        public virtual string Film_Language { get; set; }
        public virtual string Description { get; set; }
        public virtual int AgeRatingID { get; set; }
    }
}