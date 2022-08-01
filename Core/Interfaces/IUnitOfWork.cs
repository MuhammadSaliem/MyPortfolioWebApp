namespace Core.Interfaces
{
    public interface IUnitOfWork<T> where T : class
    {
        IGenericRepository<T> Repository { get; }
        void Save();

    }
}
