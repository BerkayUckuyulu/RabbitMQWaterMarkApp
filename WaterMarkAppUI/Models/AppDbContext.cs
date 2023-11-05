using System;
using Microsoft.EntityFrameworkCore;
using WaterMarkAppUI.Models;

namespace WaterMarkAppUI.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<WaterMarkAppUI.Models.Product> Product { get; set; } = default!;
    }
}






