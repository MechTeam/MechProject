using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using QuickDocs.Models.Domain.Entities;
using QuickDocs.Logic.WebTemplateObject;

namespace QuickDocs.Logic.Helpers
{
    public class UserFacade
    {
        public static User getUser(UserWTO p_user)
        {
            User admin = new User();
            admin.Name = p_user.Name;
            admin.SecondName = p_user.SecondName;
            admin.Surname = p_user.Surname;
            admin.Email = p_user.Email;
            return admin;
        }
    }
}