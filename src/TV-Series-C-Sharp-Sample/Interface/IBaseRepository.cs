using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using TV_Series_C_Sharp_Sample.Domain;

namespace TV_Series_C_Sharp_Sample.Interface{

    public interface IBaseRepository<T> where T : BaseEntity
    {

        Task<T> GetById(int id);
        Task<T> FirstOrDefault(Expression<Func<T, bool>> predicate);
        
        Task Add(T entity);
        Task Update(T entity);
        Task Delete(int id);
        
        Task <IEnumerable<T>> GetAll();
        Task<IEnumerable<T>> GetWhere(Expression<Func<T, bool>> predicate);

        Task<int> CountAll();
        Task<int> CountWhere(Expression<Func<T, bool>> predicate);
        
    }

}
