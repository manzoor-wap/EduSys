using System;
using System.Collections.Generic;
using System.Text;

namespace Datastore.Abstract.Models.Abstract
{
    public interface IBook : IBaseModel
    {
        public int BookId { get; set; }

        public string Name { get; set; }







       
    }
}
