using Datastore.Abstract.Constants;
using System;
using System.Collections.Generic;
using System.Text;

namespace Datastore.Abstract.Models.Abstract
{
   public interface IBaseModel
    {
        int Id { get; set; }
        string Name { get; set; }
        int CompanyId { get; set; }
         int CreatedBy { get; set; }
         int? UpdateBy { get; set; }

        DateTime CreatedDate { get; set; }

        DateTime? UpdatedDate { get; set; }
         StatusType Status { get; set; }
    }
}
