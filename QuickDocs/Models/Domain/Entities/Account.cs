using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuickDocs.Models.Domain.Entities
{
    public class Account
    {
        public virtual Guid ID { get; protected set; }
        public virtual DateTime CreateDate { get; set; }
        public virtual int ConfirmationToken { get; set; }
        public virtual bool IsConfirmed { get; set; }
        public virtual string Password { get; set; }
        public virtual string Login { get; set; }
        public virtual User User { get; set; }
    }
}