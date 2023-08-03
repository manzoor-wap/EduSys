using System;
using System.Collections.Generic;
using System.Text;

namespace Datastore.Abstract.Models.Abstract
{
    public interface IMarks : IBaseModel
    {
        public string InternalMarks { get; set; }

        public string ExternalMarks { get; set; }

    

    }
}
