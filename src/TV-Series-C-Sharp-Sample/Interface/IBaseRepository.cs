using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using TV_Series_C_Sharp_Sample.Domain;

namespace TV_Series_C_Sharp_Sample.Interface{

    public interface IBaseRepository<T> where T : BaseEntity
    {

        public Task<T> GetById(int id);
        public Task<T> FirstOrDefault(Expression<Func<T, bool>> predicate);
        public Task Add(T entity);
        public Task Update(T entity);
        public Task Delete(int id);
        
        public Task <List<T>> GetAll();
        public Task<List<T>> GetWhere(Expression<Func<T, bool>> predicate);

        public Task<int> CountAll();
        public Task<int> CountWhere(Expression<Func<T, bool>> predicate);
        
    }

}
