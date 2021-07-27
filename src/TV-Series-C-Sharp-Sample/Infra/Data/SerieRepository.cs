using System;
using System.Collections;
using System.Collections.Generic;
using TV_Series_C_Sharp_Sample.Domain;
using TV_Series_C_Sharp_Sample.Interface;
using TV_Series_C_Sharp_Sample.Infra.Data;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace TV_Series_C_Sharp_Sample.Infra{
    public class SerieRepository : ISerieRepository<Serie>
    {
        public SerieRepository()
        {
        }

        Task Add(Serie entity)
        {
            throw new NotImplementedException();
        }

        Task<int> CountAll()
        {
            throw new NotImplementedException();
        }

        Task<int> CountWhere(Expression<Func<Serie, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        Task<Serie> FirstOrDefault(Expression<Func<Serie, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Serie>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Serie> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Serie>> GetWhere(Expression<Func<Serie, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        Task<bool> ISerieRepository<Serie>.IsExcluded(int id)
        {
            throw new NotImplementedException();
        }

        public Task Update(Serie entity)
        {
            throw new NotImplementedException();
        }

        Task<Serie> IBaseRepository<Serie>.FirstOrDefault(Expression<Func<Serie, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        Task IBaseRepository<Serie>.Add(Serie entity)
        {
            throw new NotImplementedException();
        }

        Task IBaseRepository<Serie>.Delete(int id)
        {
            throw new NotImplementedException();
        }

        Task<int> IBaseRepository<Serie>.CountAll()
        {
            throw new NotImplementedException();
        }

        Task<int> IBaseRepository<Serie>.CountWhere(Expression<Func<Serie, bool>> predicate)
        {
            throw new NotImplementedException();
        }
    }
}