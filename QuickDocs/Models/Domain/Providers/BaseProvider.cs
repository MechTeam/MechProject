using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NHibernate;
using NHibernate.Criterion;

namespace QuickDocs.Models.Domain.Providers
{
    public abstract class BaseProvider<T> : IProvider<T>
    {
        public void Add(T entity)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    session.Save(entity);
                    transaction.Commit();
                }
            }
        }

        public void Delete(Guid id)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    var entity = session.CreateCriteria(typeof(T))
                        .Add(Expression.Eq("ID", id)).List<T>().FirstOrDefault();
                    session.Delete(entity);
                    transaction.Commit();
                }
            }
        }

        public void DeleteAll()
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    session.Delete("delete * from " + typeof(T).Name);
                    transaction.Commit();
                }
            }
        }

        public void Update(T entity)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    session.Update(entity);
                    transaction.Commit();
                }
            }
        }

        public T GetByID(Guid id)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    var entity = session.CreateCriteria(typeof(T))
                        .Add(Expression.Eq("ID", id)).List<T>().FirstOrDefault();
                    return entity;
                }
            }
        }

        public IList<T> GetList()
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    return session.CreateCriteria(typeof(T))
                        .List<T>();
                }
            }
        }


    }
}