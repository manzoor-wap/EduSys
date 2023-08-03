using Datastore.Abstract.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Datastore.Abstract.Models.Impl
{
    public class Marks : BaseModel, IMarks
    {
        public string InternalMarks { get; set; }

        public string ExternalMarks { get; set; }

    }
}
