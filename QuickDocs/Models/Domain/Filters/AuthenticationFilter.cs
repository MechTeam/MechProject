using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuickDocs.Models.Domain.Filters
{
    public class AuthenticationFilter
    {
        public Guid IDUser { get; set; }
        public string EMail { get; set; }
        public string Password { get; set; }
    }
}