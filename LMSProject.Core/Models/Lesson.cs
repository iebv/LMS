using System;
using System.Collections.Generic;
using System.Text;

namespace LMSProject.Core.Models
{
    public class Lesson: Section
    {

        public ICollection<Module> Modules { get; set; }

        public Lesson()
        {
            this.Id = new Guid();
        }
    }
}
