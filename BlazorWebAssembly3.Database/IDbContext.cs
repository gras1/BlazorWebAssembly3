using Microsoft.EntityFrameworkCore;
using System;

namespace BlazorWebAssembly3.Database
{
    public interface IDbContext : IDisposable
    {
        void RecreateDatabase();

        DbSet<Category> Categories { get; set; }

        DbSet<Product> Products { get; set; }

        int SaveChanges();
    }
}
