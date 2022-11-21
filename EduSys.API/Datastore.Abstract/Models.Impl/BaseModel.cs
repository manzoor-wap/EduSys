using Datastore.Abstract.Constants;
using Datastore.Abstract.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Datastore.Abstract.Models.Impl
{
    public class BaseModel :IBaseModel
    {
        public int CompanyId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? UpdateBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public StatusType Status { get; set; }       
    }
}
