using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NHibernate;
using NHibernate.Criterion;
using QuickDocs.Models.Domain.Entities;
using QuickDocs.Models.Domain.Filters;

namespace QuickDocs.Models.Domain.Providers
{
    public class AccountProvider : BaseProvider<Account>
    {
        public IList<AuthenticationFilter> GetListAuthentication()
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    List<AuthenticationFilter> listAuth = new List<AuthenticationFilter>();
                    foreach (var item in session.CreateCriteria(typeof(Account))
                        .List<Account>())
                    {
                        listAuth.Add(new AuthenticationFilter() { IDUser = item.ID, Password = item.Password, EMail = item.User.Email });
                    }
                    return listAuth;
                }
            }
        }
        public new void Add(Account account)
        {  
            if (account.User==null )
                throw new Exception(String.Format("При добавлении нового аккаунта произошла ошибка, свойство User не заполнено"));
        }

        public Account Search(string login)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    var account = session.CreateCriteria(typeof(Account))
                    .Add(Expression.Like("Login", login)).List<Account>().First();
                    return account;
                }
            }
        }            
    }
}