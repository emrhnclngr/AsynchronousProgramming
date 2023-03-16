using AsynchronousProgramming.Models.Entities.Abstract;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace AsynchronousProgramming.Infrastructure.Repositories.Interfaces
{
    //Asenkron Programming (Eş zamansız programlama)
   
    public interface IBaseRepository<T> where T : BaseEntity
    {
        //Bu projede asenkron programlaya alışmak için bütün methodları asenkron yazacağım. Lakin Create, Update ve Delete işlemleri çok aksi bir business olmadığı sürece asenkron programlanmaz. Buna grerek yoktur. Asıl odaklanmamız gereken nokta Read operasyonlarıdır.

        Task Add(T entity);
        Task Update(T entity);
        Task Delete(T entity);

        // _context.Products.Where(x => x.Status != Status.Passive)
        Task<List<T>> GetByDefaults (Expression<Func<T, bool>> expression);
        Task<T> GetByDefault (Expression<Func<T, bool>> expression);

        // Read Operations
        Task<List<TResult>> GetFilteredList<TResult>(Expression<Func<T, TResult>> select,
                                                     Expression<Func<T, bool>> where = null,
                                                     Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
                                                     Func<IQueryable<T>, IIncludableQueryable<T, object>> join = null);

        Task<T> GetById(int id);
        Task<bool> Any(Expression<Func<T, bool>> expression);
    }
}
