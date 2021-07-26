using System;
using System.Collections;
using System.Collections.Generic;
using TV_Series_C_Sharp_Sample.Domain;
using TV_Series_C_Sharp_Sample.Interface;
using TV_Series_C_Sharp_Sample.Infra.Data;

namespace TV_Series_C_Sharp_Sample.Infra{
    public class SerieRepository : MemoryDataBaseRepository, ISerieRepository<Serie>, IBaseRepository<Serie>
    {
       
    }
}