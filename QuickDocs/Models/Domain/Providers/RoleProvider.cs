using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NHibernate;
using NHibernate.Criterion;
using QuickDocs.Models.Domain.Entities;

namespace QuickDocs.Models.Domain.Providers
{
    public class RoleProvider:BaseProvider<Role>
    {
        public Role GetByName(string name)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    var entity = session.CreateCriteria(typeof(Role))
                        .Add(Expression.Eq("Name", name)).List<Role>().FirstOrDefault();
                    return entity;
                }
            }
        }
    }
}