using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuickDocs.Models.Domain.Entities
{
    public class ProgressOfStudent
    {
        public virtual StudentInLesson ID_StudentInLesson { get; set; }
        public virtual Control ID_Control { get; set; }
        public virtual int Points { get; set; }
        public virtual DateTime Date { get; set; }
    }
}