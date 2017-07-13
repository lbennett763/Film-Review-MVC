using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FilmReview_MVC_Website.Models
{
    public class Cast
    {
        public virtual int CastID { get; set; }
        public virtual int FilmID { get; set; }
        public virtual int ActorID { get; set; }
        public virtual string CastName { get; set; }
    }
}