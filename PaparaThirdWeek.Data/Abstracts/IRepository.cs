using PaparaThirdWeek.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PaparaThirdWeek.Data.Abstracts
{
    public interface IRepository<T> where T : class 
    {
        T Get(Expression<Func<T, bool>> filter);

        IQueryable<T> GetAll(Expression<Func<T, bool>> filter = null);

        void Add(T entity);

        void Update(T entity);

        void Delete(T entity);
    }
}
