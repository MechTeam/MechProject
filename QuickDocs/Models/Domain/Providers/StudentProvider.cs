using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using QuickDocs.Models.Domain.Entities;

namespace QuickDocs.Models.Domain.Providers
{
    public class StudentProvider : BaseProvider<Student>
    {
        public new void Add(Student student)
        {
            UserProvider userProvider = new UserProvider();
            StudentProvider studentProvider = new StudentProvider();
            RoleProvider roleProvider = new RoleProvider();

            if (student.User == null)
            {
                throw new Exception(String.Format("Поля не заполнены!"));
            }

            if (userProvider.GetByID(student.ID) == null)
            {
                userProvider.Add(student.User);
            }

            if (GetByID(student.ID) == null)
            {
                studentProvider.Add(student);

                 Role role = roleProvider.GetByName("Student");
                 userProvider.AddUserToRole(student.User, role);
            }
        }
    }
}