using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuickDocs.Models.Domain.Entities
{
    public class StudentInLesson
    {
        public virtual Schedule Schedule { get; set; }
        public virtual Guid ID { get; set; }
        public virtual Discipline Discipline { get; set; }
        public virtual StudentGroup StudentGroup { get; set; }
        public virtual Teacher Teacher { get; set; }
        public virtual LessonType LessonType { get; set; }
        public virtual LessonNum LessonNum { get; set; }
        public virtual int LectureRoom { get; set; }
    }
}