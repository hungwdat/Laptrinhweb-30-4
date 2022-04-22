#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TranHungDat.Models;

    public class DataContext : DbContext
    {
        public DataContext (DbContextOptions<DataContext> options)
            : base(options)
        {
        }

        public DbSet<TranHungDat.Models.Category> Category { get; set; }

        public DbSet<TranHungDat.Models.Comment> Comment { get; set; }

        public DbSet<TranHungDat.Models.News> News { get; set; }
    }
