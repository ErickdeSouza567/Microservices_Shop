using LojaMicro.ApiProduto.Models;
using Microsoft.EntityFrameworkCore;

namespace LojaMicro.ApiProduto.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    
        public DbSet<Category>? Categories { get; set; }
        public DbSet<Product>? Products { get; set; }

    }
}
