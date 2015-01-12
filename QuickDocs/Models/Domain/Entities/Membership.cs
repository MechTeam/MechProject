using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuickDocs.Models.Domain.Entities
{
    public class Membership
    {
        public virtual Guid ID { get; protected set; }
        public virtual DateTime CreateDate { get; protected set; }
        public virtual int ConfirmationToken { get; set; }
        public virtual bool IsConfirmed { get; set; }
        public virtual DateTime LastPasswordFailureDate { get; set; }
        public virtual int PasswordFailuresSinceLastSuccess { get; set; }
        public virtual string Password { get; set; }
        public virtual DateTime PasswordChangeDate { get; set; }
        public virtual string PasswordSalt { get; set; }
        public virtual int PasswordVerificationToken { get; set; }
        public virtual bool PasswordVerificationTokenExpiration { get; set; }
    }
}