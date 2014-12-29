using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuickDocs.Models.Domain.Providers
{
    interface IProvider<T>
    {
        void Add(T entity);
        void Delete(Guid id);
        void Update(T entity);
        T GetByID(Guid id);
    }
}