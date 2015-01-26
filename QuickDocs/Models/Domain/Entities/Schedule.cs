using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuickDocs.Models.Domain.Entities
{
    public class Schedule
    {
        public virtual Guid ID { get; protected set; }
        public virtual Guid ID_Discipline { get; protected set; }
        public virtual Guid ID_GroupStud { get; protected set; }
        public virtual Guid ID_Teacher { get; protected set; }
        public virtual Guid ID_LessonType { get; protected set; }
        public virtual Guid ID_LessonNum { get; protected set; }
        public virtual int LectureRoom { get; set; }
    }
}