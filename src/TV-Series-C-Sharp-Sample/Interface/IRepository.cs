namespace TV_Series_C_Sharp_Sample{

    public interface IRepository<T> {

        T GetById(int id);
        T Load(int id);
        void Save(T entity);
        void Delete(T entity);
        Ienumerable<T> GetAll();

    }

}
