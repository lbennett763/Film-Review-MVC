using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FilmReview_MVC_Website.Models
{
    public class User
    {
        public virtual int UserID { get; set; }
        public virtual string UserFirstName { get; set; }
        public virtual string UserLastName { get; set; }
        public virtual string UserAddressLine1 { get; set; }
        public virtual string UserAddressLine2 { get; set; }
        public virtual string Town_City { get; set; }
        public virtual string UserEmail { get; set; }
        public virtual string UserContactNo { get; set; }
        public virtual int Reported { get; set; }
        public virtual bool Blocked { get; set; }
    }
}