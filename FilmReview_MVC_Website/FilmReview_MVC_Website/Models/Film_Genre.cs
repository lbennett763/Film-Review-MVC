using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FilmReview_MVC_Website.Models
{
    public class Film_Genre
    {
        public virtual int FilmID { get; set; }
        public virtual int GenreID { get; set;}
    }
}