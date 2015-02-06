using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using QuickDocs.Models.Domain.Entities;

namespace QuickDocs.Models.Domain.Providers
{
    public class TeacherProvider:BaseProvider<Teacher>
    {
        public new void Add(Teacher teacher)
        {
            UserProvider userProvider = new UserProvider();
            TeacherProvider teacherProvider = new TeacherProvider();
            RoleProvider roleProvider = new RoleProvider();

            if (teacher.User == null)
            {
                throw new Exception(String.Format("Поля не заполнены!"));
            }

            if (userProvider.GetByID(teacher.ID) == null)
            {
                userProvider.Add(teacher.User);
            }

            if (GetByID(teacher.ID) == null)
            {
                teacherProvider.Add(teacher);

                Role role = roleProvider.GetByName("Teacher");
                userProvider.AddUserToRole(teacher.User, role);
            }
        }
    }
}