using System;
using System.Collections.Generic;
using System.Text;

namespace LMSProject.Core.Models
{
    public class Module: Section
    {
        public Guid CourseId { get; set; }
        public Course Course { get; set; }
        public ICollection<Lesson> Lessons { get; set; }
        public Module()
        {
            this.Id = new Guid();
        }
    }
}
