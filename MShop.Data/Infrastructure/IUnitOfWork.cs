namespace MShop.Data.Infrastructure
{
    public interface IUnitOfWork
    {
        void Commit();
    }
}