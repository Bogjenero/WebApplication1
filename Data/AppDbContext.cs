﻿using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace WebApplication1.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) :
           base(options)
        { }
        public DbSet<Movie> Movies { get; set; }
    }
}
