using System;
using System.Collections.Generic;
using System.Text;

namespace Datastore.Abstract.Models.Abstract
{
    public interface ICourse : IBaseModel
    {
        public string CourseName { get; set; }

        public string CourseDuration { get; set; }

        public string CourseAlias { get; set; }

    }
}
