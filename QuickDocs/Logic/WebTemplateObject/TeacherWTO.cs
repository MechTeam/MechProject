using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using QuickDocs.Models.Domain.Entities;

namespace QuickDocs.Logic.WebTemplateObject
{
    public class TeacherWTO : UserWTO
    {
        string post;

        public TeacherWTO(Teacher teacher)
            : base(teacher.User)
        {
            post = teacher.Post;
        }

        public string Post
        {
            get { return post; }
        }
    }
}