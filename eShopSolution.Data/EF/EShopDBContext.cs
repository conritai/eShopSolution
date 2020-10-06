using Microsoft.EntityFrameworkCore;
using System;

namespace eShopSolution.Data
{
    public class EShopDBContext : DbContext
    {
        public EShopDBContext(DbContextOptions options) : base(options)
        {
            options.UseSqlServer
        }

        prot
    }
}
