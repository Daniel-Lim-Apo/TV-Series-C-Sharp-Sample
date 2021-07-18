using System;
using TV_Series_C_Sharp_Sample.Class;

namespace TV_Series_C_Sharp_Sample.Infra{
    public class SerieRepository : IRepository<Serie>
    {
        void IRepository<Serie>.Delete(Serie entity)
        {
            throw new NotImplementedException();
        }

        Serie IRepository<Serie>.GetById(int id)
        {
            throw new NotImplementedException();
        }

        Serie IRepository<Serie>.Load(int id)
        {
            throw new NotImplementedException();
        }

        void IRepository<Serie>.Save(Serie entity)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Serie> IRepository<Serie>.GetAll(){
            throw new NotImplementedException();
        }
    }
}