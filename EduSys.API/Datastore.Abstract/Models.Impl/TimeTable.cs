using Datastore.Abstract.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Datastore.Abstract.Models.Impl
{
    public class TimeTable : BaseModel, ITimeTable
    {

        public string ClassTiming { get; set; }

        public string Subject { get; set; }

        public string Facultyname { get; set; }
    }
}