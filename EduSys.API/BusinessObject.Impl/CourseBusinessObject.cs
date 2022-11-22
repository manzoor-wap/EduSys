using BusinessObject.Abstract;
using Datastore.Abstract;
using Datastore.Abstract.Models.Abstract;
using Datastore.Abstract.Models.Impl;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject.Impl
{
    public class CourseBusinessObject : ICourseBusinessObject
    {
        public IDataFactory _DataFactory { get; set; }
        public CourseBusinessObject(IDataFactory dataFactory)
        {
            _DataFactory = dataFactory;
        }
        public async Task<bool> CreateCourse(Course course)
        {
            return await _DataFactory.CreateCourse(course);
        }

        public async Task<bool> DeleteCourse(Course course)
        {
            return await _DataFactory.DeleteCourse(course);
        }

        public async Task<ICourse> GetCourse(int id)
        {
            return await _DataFactory.GetCourse(id);
        }

        public async Task<IEnumerable<ICourse>> GetCourses()
        {
            return await _DataFactory.GetCourses();
        }

        public async Task<bool> UpdateCourse(Course course)
        {
            return await _DataFactory.UpdateCourse(course);
        }
    }
}

