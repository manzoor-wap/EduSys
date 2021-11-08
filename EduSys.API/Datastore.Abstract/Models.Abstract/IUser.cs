using System;
using System.Collections.Generic;
using System.Text;

namespace Datastore.Abstract.Models.Abstract
{
   public interface IUser : IBaseModel
    {
         int UserId { get; set; }
         string Name { get; set; }

         string Email { get; set; }

         string Phone { get; set; }
    }
}
