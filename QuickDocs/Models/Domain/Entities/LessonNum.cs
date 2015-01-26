using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuickDocs.Models.Domain.Entities
{
    public class LessonNum
    {
        public virtual Guid id { get; protected set; }
        public virtual DateTime StartTime { get; set; }
        public virtual DateTime FinishTime { get; set; }
    }
}