using System;
using System.Collections.Generic;
using System.Text;

namespace Datastore.Abstract.Models.Abstract
{
    public interface ITimeTable : IBaseModel
    {


        public string ClassTiming { get; set; }

        public string Subject { get; set; }

         public string Facultyname  { get; set; }





    }
}
