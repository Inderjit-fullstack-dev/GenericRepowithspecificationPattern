﻿using GenericRepositoryWithSpecificationExample.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace GenericRepositoryWithSpecificationExample.Core.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
            : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
