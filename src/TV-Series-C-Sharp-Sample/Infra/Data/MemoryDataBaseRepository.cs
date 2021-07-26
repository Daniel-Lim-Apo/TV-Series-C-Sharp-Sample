using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq.Expressions;
using TV_Series_C_Sharp_Sample.Domain;

using TV_Series_C_Sharp_Sample.Interface;

namespace TV_Series_C_Sharp_Sample.Infra.Data{
    public class MemoryDataBaseRepository : ISerieRepository<Serie>, IBaseRepository<Serie>
    {

       Task<bool> ISerieRepository<Serie>.IsExcluded(int id){
        return null;
       }

       Task<Serie> IBaseRepository<Serie>.GetById(int id){
        return null;
       }

       Task<Serie> IBaseRepository<Serie>.FirstOrDefault(Expression<Func<Serie, bool>> predicate){
        return null;
       }
        
        Task IBaseRepository<Serie>.Add(Serie entity){
return null;
        }
        Task IBaseRepository<Serie>.Update(Serie entity){
return null;
        }
        Task IBaseRepository<Serie>.Delete(Serie entity){
return null;
        }
        
        Task <IEnumerable<Serie>> IBaseRepository<Serie>.GetAll(){
return null;
        }
        Task<IEnumerable<Serie>> IBaseRepository<Serie>.GetWhere(Expression<Func<Serie, bool>> predicate){
return null;
        }

        Task<int> IBaseRepository<Serie>.CountAll(){
return null;
        }
        Task<int> IBaseRepository<Serie>.CountWhere(Expression<Func<Serie, bool>> predicate){
return null;
        }

    }



}