using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuickDocs.Models.Domain.Entities
{
    public class Student
    {
        public virtual User User { get; set; } 
        public virtual Guid ID { get; set; }
        public virtual StudentGroup StudentGroup { get; set; } 
    }
}