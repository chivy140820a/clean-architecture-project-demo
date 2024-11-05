using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Domains.Interfaces
{
    public interface IRepositoryBase<T>
    {
        IEnumerable<T> GetAll(); 
        T GetById(Guid id); 
        void Add(T entity); 
        void Update(T entity); 
        void Delete(T entity);
    }
}
