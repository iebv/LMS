using LMSProject.Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace LMSProject.Data.Repositories
{
    public class CourseRepository : GenericRepository<Course>
    {
        public CourseRepository(LMSProjectDbContext context) : base(context)
        {
        }

       
    }
}
