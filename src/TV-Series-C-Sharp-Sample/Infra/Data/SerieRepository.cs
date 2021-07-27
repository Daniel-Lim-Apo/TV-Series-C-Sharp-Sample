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

        List<Serie> seriesList = new List<Serie>();

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

        public async Task<List<Serie>> GetAll()
        {
            await Task.Delay(1);
            return seriesList;
        }

        public Task<Serie> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Serie>> GetWhere(Expression<Func<Serie, bool>> predicate)
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
            seriesList.Add(entity);
            return Task.CompletedTask;
        }

        Task IBaseRepository<Serie>.Delete(int id)
        {
            throw new NotImplementedException();
        }

        Task<int> IBaseRepository<Serie>.CountAll()
        {
            return Task.FromResult(seriesList.Count);
        }

        Task<int> IBaseRepository<Serie>.CountWhere(Expression<Func<Serie, bool>> predicate)
        {
            throw new NotImplementedException();
        }
    }
}