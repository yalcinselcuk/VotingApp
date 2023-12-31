﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VotingApp.Entities;

namespace VotingApp.Infrastructure.Data
{
    public class VotingDbContext : IdentityDbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Poll> Polls { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Option> Options { get; set; }
        public DbSet<Vote> Votes { get; set; }

        public VotingDbContext(DbContextOptions<VotingDbContext> options) : base(options) { }
    }
}
