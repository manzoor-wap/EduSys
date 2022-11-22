using Datastore.Abstract.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Datastore.Abstract.Models.Impl
{
   public class User : BaseModel,IUser
    {
        
        

        public string Email { get; set; }

        public string Phone { get; set; }
    }
}
