using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using QuickDocs.Models.Domain.Entities;

namespace QuickDocs.Logic.WebTemplateObject
{
    public class UserWTO
    {
        string name;
        string surname;
        string secondName;
        IList<Role> roles;        
        
        public UserWTO(User user)
        {
            name = user.FirstName;
            surname = user.Surname;
            secondName = user.SecondName;
            roles = user.Roles;
        }

        public string Name
        {
            get { return name; }
        }

        public string Surname
        {
            get { return surname; }
        }

        public string SecondName
        {
            get { return secondName; }
        }

        public IList<Role> Roles
        {
            get { return roles; }
        }
    }
}