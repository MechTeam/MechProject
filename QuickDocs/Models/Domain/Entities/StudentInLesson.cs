using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuickDocs.Models.Domain.Entities
{
    public class StudentInLesson
    {
        public virtual Guid ID { get; set; }
        public virtual Lesson Lesson { get; set; }
        public virtual Student Student { get; set; }
    }
}