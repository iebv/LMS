using LMSProject.Core;
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
        public DbSet<Section> Sections { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Module> Modules { get; set; }
        public DbSet<Lesson> Lessons { get; set; }
    }
}
