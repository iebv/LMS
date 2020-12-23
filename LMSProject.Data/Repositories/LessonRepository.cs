using LMSProject.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LMSProject.Data.Repositories
{
    public class LessonRepository : GenericRepository<Lesson>
    {
        public LessonRepository(LMSProjectDbContext context) : base(context)
        {
        }
    }
}
