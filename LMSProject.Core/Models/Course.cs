using System;
using System.Collections.Generic;
using System.Text;

namespace LMSProject.Core.Models
{
    public class Course: Section
    {
        public ICollection<Module> Modules { get; set; }

        public Course()
        {
            this.Id = new Guid();
        }

    }
}
