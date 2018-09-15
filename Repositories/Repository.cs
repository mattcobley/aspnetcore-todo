using System;
using System.Linq;
using System.Linq.Expressions;
using aspnetcore_todo.Database;
using aspnetcore_todo.Models;

namespace aspnetcore_todo.Repositories
{
    public class Repository<T> : IRepository<T> where T : EntityBase
    {
        private readonly AppDbContext _context;
        public Repository(AppDbContext context){
            _context = context;
        }
        public IQueryable<T> GetAll(){
            return _context.Set<T>().AsQueryable();
        }
        public IQueryable<T> GetAll(Expression<Func<T, bool>> predicate){
            return _context.Set<T>()
                .Where(predicate)
                .AsQueryable();
        }
        public T GetById(int id){
            return _context.Set<T>().Find(id);
        }
        public void Add(T entity){
            _context.Set<T>().Add(entity);
            _context.SaveChanges();
        }
        public void Delete(T entity){
            _context.Set<T>().Remove(entity);
            _context.SaveChanges();
        }
        public void Edit(T entity){
            _context.Set<T>().Update(entity);
            _context.SaveChanges();
        }
    }
}