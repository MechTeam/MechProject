using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using QuickDocs.Models.Domain.Entities;

namespace QuickDocs.Logic.WebTemplateObject
{
    public class SuperAdminWTO : UserWTO
    {
        public SuperAdminWTO(User user) : base(user) { }
    }
}