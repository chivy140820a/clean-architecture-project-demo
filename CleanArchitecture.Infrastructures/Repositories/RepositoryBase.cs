using CleanArchitecture.Domains.Interfaces;
using CleanArchitecture.Infrastructures.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Infrastructures.Repositories
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected readonly AppDbContext _context; 
        public RepositoryBase(AppDbContext context) 
        {
            _context = context; 
        }
        public IEnumerable<T> GetAll() 
        { 
            return _context.Set<T>().ToList(); 
        }
        public T GetById(Guid id) 
        {
            return _context.Set<T>().Find(id); 
        }
        public void Add(T entity) 
        { 
            _context.Set<T>().Add(entity); _context.SaveChanges(); 
        }
        public void Update(T entity) 
        { 
            _context.Set<T>().Update(entity); _context.SaveChanges(); 
        }
        public void Delete(T entity) 
        { 
            _context.Set<T>().Remove(entity); _context.SaveChanges(); 
        }
    }
}
