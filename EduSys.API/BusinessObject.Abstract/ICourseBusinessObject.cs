using Datastore.Abstract.Models.Abstract;
using Datastore.Abstract.Models.Impl;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject.Abstract
{
    public interface ICourseBusinessObject
    {
        Task<ICourse> GetCourse(int id);
        Task<IEnumerable<ICourse>> GetCourses();
        Task<bool> CreateCourse(Course course);
        Task<bool> DeleteCourse(Course course);
        Task<bool> UpdateCourse(Course course);
    }
}
