using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuickDocs.Models.Domain.Entities
{
    public class Role
    {
        public virtual Guid ID { get; protected set; }
        public virtual string Name { get; set; }
        public virtual IList<User> Users { get; set; }
        public Role()
        {
            Users = new List<User>();
        }
    }
}