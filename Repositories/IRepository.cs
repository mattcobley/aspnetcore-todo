using System;
using System.Linq;
using System.Linq.Expressions;
using aspnetcore_todo.Models;

namespace aspnetcore_todo.Repositories {
    public interface IRepository<T> where T: EntityBase
    {
        IQueryable<T> GetAll();
        IQueryable<T> GetAll(Expression<Func<T, bool>> predicate);
        T GetById(int id);
        void Add(T entity);
        void Delete(T entity);
        void Edit(T entity);
    }
}