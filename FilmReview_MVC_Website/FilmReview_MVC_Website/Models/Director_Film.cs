using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FilmReview_MVC_Website.Models
{
    public class Director_Film
    {
        public virtual int DirectorID { get; set; }
        public virtual int FilmID { get; set; }
    }
}