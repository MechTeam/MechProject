using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuickDocs.Models.Domain.Entities
{
    public class Discpline
    {
        public virtual Guid ID { get; protected set; }
        public virtual string Name { get; set; }
    }
}