using System;
using System.Collections;
using System.Collections.Generic;
using TV_Series_C_Sharp_Sample.Domain;
using TV_Series_C_Sharp_Sample.Interface;
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

        public Task<int> CountWhere(Expression<Func<Serie, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            int indexItem = seriesList.FindLastIndex(p => p.GetId() == id);

            if (indexItem == -1){
                return Task.FromResult("Id not found.");
            }
            else
            {
                Console.WriteLine("Are you sure to delete the serie number " + id + " Type yes or no");
                String areYouSure = Console.ReadLine();
                if (areYouSure.ToUpper() == "YES")
                {
                    seriesList.RemoveAt(indexItem);
                }
                else
                {
                    Console.WriteLine("I am not sure that you are sure. So, doing nothing");
                }
                
                return Task.CompletedTask;
            }
        }

        public Task<Serie> FirstOrDefault(Expression<Func<Serie, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Serie>> GetAll()
        {
            await Task.Delay(1);
            return seriesList;
        }


        public async Task<Serie> GetById(int id)
        {
            int indexItem = seriesList.FindLastIndex(p => p.GetId() == id);

            await Task.Delay(1);

            if (indexItem == -1){
                Console.WriteLine("Id not found.");
                return null;
            }
            else
            {
                    return seriesList[indexItem];

                // return Task.Run(() => {
                //     return seriesList[indexItem];
                //     });
            }
        }

        public Task<List<Serie>> GetWhere(Expression<Func<Serie, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        Task<bool> ISerieRepository<Serie>.IsExcluded(int id)
        {
           
            int indexItem = seriesList.FindLastIndex(p => p.GetId() == id);

            if (indexItem == -1){
                throw new Exception("Id not found.");
            }
            else
            {
                return 
                    Task.Run(() => {
                        return seriesList[indexItem].GetExcluded();
                        });
            }
        }

        public Task Update(Serie entity)
        {

            int indexItem = seriesList.FindLastIndex(p => p.GetId() == entity.GetId());

            if (indexItem == -1){
                return Task.FromResult("Id not found.");
            }
            else
            {
                seriesList.RemoveAt(indexItem);
                seriesList.Insert(indexItem, entity);
                return Task.CompletedTask;
            }
        }

        Task<Serie> IBaseRepository<Serie>.FirstOrDefault(Expression<Func<Serie, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        // public async Task<Serie> GetById(int id)
        public async Task IBaseRepository<Serie>.Add(Serie entity)
        {

            seriesList.Add(entity);
       
            return Task.CompletedTask;

        }

        Task IBaseRepository<Serie>.Delete(int id)
        {
            int indexItem = seriesList.FindLastIndex(p => p.GetId() == id);

            if (indexItem == -1){
                return Task.FromResult("Id not found.");
            }
            else
            {
                seriesList.RemoveAt(indexItem);
                return Task.CompletedTask;
            }
        }

        Task<int> IBaseRepository<Serie>.CountAll()
        {
            return Task.FromResult(seriesList.Count);
        }


    }
}