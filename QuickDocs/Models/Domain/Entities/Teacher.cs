using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuickDocs.Models.Domain.Entities
{
    public class Teacher
    {
        public virtual Guid ID_User { get; protected set; }
        public virtual string Part { get; set; }
        public virtual string Post { get; set; }
    }
}