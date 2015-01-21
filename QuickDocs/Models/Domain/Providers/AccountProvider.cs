using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NHibernate;
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
    }
}