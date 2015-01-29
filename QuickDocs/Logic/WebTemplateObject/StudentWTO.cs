using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using QuickDocs.Models.Domain.Entities;

namespace QuickDocs.Logic.WebTemplateObject
{
    public class StudentWTO : UserWTO
    {
        string group;

        public StudentWTO(Student student)
            : base(student.User)
        {
            group = student.StudentGroup.Name;
        }

        public string Group
        {
            get { return group; }
        }

        
    }
}