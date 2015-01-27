using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuickDocs.Models.Domain.Entities
{
    public class Control
    {
        public virtual Guid ID {get; protected set;}
        public virtual string Name { get; set; }
        public virtual int MaxPoints { get; set; }
        public virtual int MinPoints { get; set; }
        public virtual Guid ID_ControlType { get; set; }
        public virtual Guid ID_Discipline { get; set; }
        public virtual int ModuleNum { get; set; }
        public virtual int NumControl { get; set; }
        public virtual int Week { get; set; }
    }
}