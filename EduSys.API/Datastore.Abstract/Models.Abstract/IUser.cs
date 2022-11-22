using System;
using System.Collections.Generic;
using System.Text;

namespace Datastore.Abstract.Models.Abstract
{
   public interface IUser : IBaseModel
    {
         
         

         string Email { get; set; }

         string Phone { get; set; }
    }
}
