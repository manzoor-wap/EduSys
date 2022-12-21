using Datastore.Abstract.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Datastore.Abstract.Models.Impl
{
    public class Attendance : BaseModel, IAttendance
    {

        public string Percentage { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }
    }
}
