using Datastore.Abstract.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Datastore.Abstract.Models.Impl
{
    public class Course : BaseModel , ICourse
    {
        public string CourseName { get; set; }

        public string CourseDuration { get; set; }

        public string CourseAlias { get; set; }

    }
}
