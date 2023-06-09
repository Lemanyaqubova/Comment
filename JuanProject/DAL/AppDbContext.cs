﻿using JuanProject.Models;
using Microsoft.EntityFrameworkCore;

namespace JuanProject.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<Blog> Blogs{ get; set; }
        public DbSet<Comment> Comments{ get; set; }

    }
}
