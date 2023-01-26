﻿using Microsoft.EntityFrameworkCore;
using SoftwareDesignProject.Data.Models;

namespace SoftwareDesignProject.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Student> Students { get; set; }
      
    }
}
