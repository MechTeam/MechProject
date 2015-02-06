using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using QuickDocs.Models.Domain.Entities;
using NHibernate;
using NHibernate.Criterion;

namespace QuickDocs.Models.Domain.Providers
{
    public class LessonNumProvider : BaseProvider<LessonNum>
    {
        public LessonNum GetByID (int ID) 
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    var entity = session.CreateCriteria(typeof(LessonNum))
                        .Add(Expression.Eq("ID",ID)).List<LessonNum>().FirstOrDefault();
                    return entity;
                }
            } 
        }
        public new LessonNum GetByID(Guid ID)
        {
            throw new Exception(String.Format("метод GetByID класса LessonNum принимает только параметр ID типа int"));
        }
    }
}