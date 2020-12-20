using LMSProject.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace LMSProject.Data
{
    public interface ICourseData
    {
        IEnumerable<Course> GetAllCourses();
    }

    
}
