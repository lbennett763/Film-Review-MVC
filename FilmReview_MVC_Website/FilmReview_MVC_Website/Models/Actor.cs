using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FilmReview_MVC_Website.Models
{
    public class Actor
    {
        public virtual int ActorID { get; set; }
        public virtual string ActorName { get; set; }
        public virtual string ActorSurname { get; set; }
    }
}