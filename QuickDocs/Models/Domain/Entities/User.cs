using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuickDocs.Models.Domain.Entities
{
    public class User
    {
        public virtual Guid ID { get; protected set; }
        public virtual string SecondName { get; set; }
        public virtual string FirstName { get; set; }
        public virtual string Email { get; set; }
        public virtual IList<Role> Roles { get; set; }
        public User()
        {
            Roles = new List<Role>();
        }
    }
}