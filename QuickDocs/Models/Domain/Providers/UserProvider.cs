using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using QuickDocs.Models.Domain.Entities;

namespace QuickDocs.Models.Domain.Providers
{
    public class UserProvider: BaseProvider<User>
    {
        public new void Add(User user)
        {
            if (user.Roles.Count == 0)
                throw new Exception(String.Format("Юзер {0} с ID {1} не прикреплен ни к одной роли", user.Surname, user.ID));
            if (GetByID(user.ID) != null)
                throw new Exception(String.Format("Юзер {0} с ID {1} уже существует", user.Surname, user.ID));
            
            base.Add(user);
            for (int i = 0; i < user.Roles.Count; i++)
            {
                AddUserToRole(user, user.Roles[i]);
            }
        }

        public void AddUserToRole(User user, Role role)
        {
            if ((new RoleProvider()).GetByID(role.ID) == null)
                throw new Exception(String.Format("Роли {0} c ID {1} не найдено в базе", role.Name, role.ID));
            if (GetByID(user.ID) != null)
            {
                if (user.Roles.FirstOrDefault(x => x.ID == role.ID) != null)
                    return;
                user.Roles.Add(role);
                Update(user);
            }
            else
            { 
                user.Roles.Add(role);
                this.Add(user);
            }
        }
    }
}