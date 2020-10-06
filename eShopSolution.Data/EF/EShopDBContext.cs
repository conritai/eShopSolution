using eShopSolution.Data.EF.Entity;
using Microsoft.EntityFrameworkCore;
using System;

namespace eShopSolution.Data
{
    public class EShopDBContext : DbContext
    {
        public EShopDBContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Product> Products { set; get; }
        public DbSet<Category> Categories { set; get; }

    }
}
