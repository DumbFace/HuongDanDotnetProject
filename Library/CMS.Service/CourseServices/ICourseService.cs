using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CMS.Core.Domain.Courses;
using CMS.Data.EFCore;

namespace CMS.Service.CourseServices
{
    public interface ICourseService : IRepository<Course>
    {
        
    }
}