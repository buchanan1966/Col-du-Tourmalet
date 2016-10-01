using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using ColduTourmalet.web.code.data;

namespace ColduTourmalet.web.code.business
{
    public interface IEntityManager<T> where T : IEntity
    {
        List<T> GetAll();
        List<T> GetFiltered(Expression<Func<T, bool>> predicate);
        T Get(Expression<Func<T, bool>>  predicate);
        T Save(T model);
        void Delete(T model);
    }
}