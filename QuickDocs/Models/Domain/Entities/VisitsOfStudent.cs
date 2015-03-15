using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuickDocs.Models.Domain.Entities
{
    public class VisitsOfStudent
    {
        public virtual Guid ID { get; protected set; }
        public virtual StudentInLesson StudentInLesson { get; set; }
        public virtual bool Visit { get; set; }
        public virtual DateTime Date { get; set; }
    }
}