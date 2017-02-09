using MShop.Model.Models;
using System.Data.Entity;

namespace MShop.Data
{
    public class MShopDBContext : DbContext
    {
        public MShopDBContext() : base("MShopConnection")
        {
            this.Configuration.LazyLoadingEnabled = false; // khi duyet cha khong sinh ra bang con
        }
        //khai bao cac bang
        public DbSet<Footer> Footers { set; get; }
        public DbSet<Menu> Menus { set; get; }
        public DbSet<MenuGroup> MenuGroups { set; get; }
        public DbSet<Order> Orders { set; get; }
        public DbSet<OrderDetail> OrderDetails { set; get; }
        public DbSet<Page> Pages { set; get; }
        public DbSet<PostCategory> PostCategorys { set; get; }
        public DbSet<PostTag> PostTags { set; get; }
        public DbSet<Product> Products { set; get; }
        public DbSet<ProductCategory> ProductCategorys { set; get; }
        public DbSet<ProductTag> ProductTags { set; get; }
        public DbSet<Slide> Slides { set; get; }
        public DbSet<SupportOnline> SupportOnlines { set; get; }
        public DbSet<SystemConfig> SystemConfigs { set; get; }
        public DbSet<Tag> Tags { set; get; }
        public DbSet<Visitor> Visitors { set; get; }

        protected override void OnModelCreating(DbModelBuilder builder)
        {
            
        }
    }
}