using System;
using System.Threading.Tasks;
using TV_Series_C_Sharp_Sample.Domain;

namespace TV_Series_C_Sharp_Sample.Interface
{
    public interface ISerieRepository<T> : IBaseRepository<Serie>
    {
        Task<bool> IsExcluded(int id);
    }
    
}