﻿using System;
using System.Collections.Generic;
using System.Text;
using CommunityGardenProj.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CommunityGardenProj.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Gardener> Gardeners { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<IdentityRole>().HasData(
                new IdentityRole
                {
                    Name = "Admin",
                    NormalizedName = "ADMIN"
                },
                new IdentityRole
                {
                    Name = "Gardener",
                    NormalizedName = "GARDENER"
                }


            );
        }

        public DbSet<Garden> Garden { get; set; }

        public DbSet<Address> Address { get; set; }

        public DbSet<Discussion> Discussions { get; set; }

        public DbSet<Answers> Answers { get; set; }
    }
}
