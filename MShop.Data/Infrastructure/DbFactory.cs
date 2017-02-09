namespace MShop.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private MShopDBContext dbContext;

        public MShopDBContext Init()
        {
            return dbContext ?? (dbContext = new MShopDBContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}