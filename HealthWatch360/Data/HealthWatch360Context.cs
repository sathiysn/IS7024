﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HealthWatch360.Models;

namespace HealthWatch360.Data
{
    public class HealthWatch360Context : DbContext
    {
        public HealthWatch360Context (DbContextOptions<HealthWatch360Context> options)
            : base(options)
        {
        }

        public DbSet<HealthWatch360.Models.Program> HealthReport { get; set; } = default!;
        public DbSet<HealthWatch360.Models.User> User { get; set; } = default!;
        public DbSet<HealthWatch360.Models.ExerciseLog> ExerciseLog { get; set; } = default!;
        public DbSet<Library> Library { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Mark Library as keyless
            modelBuilder.Entity<Library>().HasNoKey();

            base.OnModelCreating(modelBuilder);
        }
    }
}
