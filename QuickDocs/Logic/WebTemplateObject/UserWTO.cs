using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using QuickDocs.Models.Domain.Entities;

namespace QuickDocs.Logic.WebTemplateObject
{
    public abstract class UserWTO
    {
        string name;
        string surname;
        string secondName;
        IList<string> roles;        
        
        public UserWTO(User user)
        {
            name = user.FirstName;
            surname = user.Surname;
            secondName = user.SecondName;
            roles = getRolesName(user.Roles);
        }

        private IList<string> getRolesName(IList<Role> roles)
        {

            return roles.Select(x => x.Name).ToList();
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

        public IList<String> Roles
        {
            get { return roles; }
        }
    }
}