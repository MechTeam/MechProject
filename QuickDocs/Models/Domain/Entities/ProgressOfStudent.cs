using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuickDocs.Models.Domain.Entities
{
    public class ProgressOfStudent
    {
        public virtual StudentInLesson StudentInLesson { get; set; }
        public virtual Control Control { get; set; }
        public virtual int Points { get; set; }
        public virtual DateTime Date { get; set; }
    }
}