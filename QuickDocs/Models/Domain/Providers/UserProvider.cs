using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using QuickDocs.Models.Domain.Entities;
using NHibernate;
using NHibernate.Criterion;

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

        public new void Delete(Guid id)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    StudentProvider sProvider = new StudentProvider();
                    if (sProvider.GetByID(id) != null)
                    {
                        sProvider.Delete(id);
                    }
                    TeacherProvider tProvider = new TeacherProvider();
                    if (tProvider.GetByID(id) != null)
                    {
                        tProvider.Delete(id);
                    }
                    AccountProvider aProvider = new AccountProvider();
                    if (aProvider.GetByID(id) != null)
                    {
                        aProvider.Delete(id);
                    }
                    base.Delete(id);
                }
            }
        }

        public bool UserIsExsist(string login, string password)
        {
            if (login == "")
                throw new Exception(String.Format("Поле Login не заполнено!"));
            if(password=="")
                throw new Exception(String.Format("Поле Password не заполнено!"));

            return (new AccountProvider()).Search(login).Password == password;
        }
    }
}