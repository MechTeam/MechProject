using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuickDocs.Models.Domain.Entities
{
    public class Lesson
    {
        public virtual Guid ID { get; protected set; }
        public virtual Discipline Discipline { get;  set; }
        public virtual StudentGroup StudentGroup { get;  set; }
        public virtual Teacher Teacher { get;  set; }
        public virtual LessonType LessonType { get;  set; }
        public virtual LessonNum LessonNum { get;  set; }
        public virtual string LectureRoom { get; set; }
    }
}