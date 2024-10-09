﻿using DashboardGerenciamentoUsuarios.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace DashboardGerenciamentoUsuarios.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
