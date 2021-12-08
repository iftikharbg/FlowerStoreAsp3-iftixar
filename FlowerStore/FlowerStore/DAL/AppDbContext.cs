using FlowerStore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlowerStore.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            :base(options)
        {


        }
        public DbSet<Slider> Sliders { get; set; }

        public DbSet<Valentine> Valentines { get; set; }

        public DbSet<ListItem> LitsItems { get; set; }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        public DbSet<SubscribeTable> subscribeTables { get; set; }
        public DbSet<Expert> Experts { get; set; }
        public DbSet<Title> Titles { get; set; }

        











    }
}
