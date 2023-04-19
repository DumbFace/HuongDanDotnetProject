using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CMS.Core.Domain.Lessons;
using CMS.Data.EFCore;

namespace CMS.Service.LessonServices
{
    public interface ILessonService : IRepository<Lesson>
    {
        
    }
}