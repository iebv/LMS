using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LMSProject.Core;
using LMSProject.Data;

namespace LMSProject.Pages.Courses
{
    public class IndexModel : PageModel
    {
        private readonly LMSProject.Data.LMSProjectDbContext _context;

        public IndexModel(LMSProject.Data.LMSProjectDbContext context)
        {
            _context = context;
        }

        public IList<Course> Course { get;set; }

        public async Task OnGetAsync()
        {
            Course = await _context.Courses.ToListAsync();
        }
    }
}
