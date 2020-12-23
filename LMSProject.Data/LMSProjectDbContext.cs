using LMSProject.Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace LMSProject.Data
{
    public class LMSProjectDbContext: DbContext
    {
        public LMSProjectDbContext(DbContextOptions<LMSProjectDbContext> options) 
            : base(options)
        {   
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Lesson> Lessons { get; set; }
    }
}
