using System;

namespace LMSProject.Core.Models
{
    public abstract class Section
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Duration { get; set; }
    }
}
