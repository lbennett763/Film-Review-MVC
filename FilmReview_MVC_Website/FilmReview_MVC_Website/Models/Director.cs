using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FilmReview_MVC_Website.Models
{
    public class Director
    {
        public virtual int DirectorID { get; set; }
        public virtual string DirectorName { get; set; }
        public virtual string DirectorSurname { get; set; }
        public virtual DateTime DirectorDoB { get; set; }
    }
}