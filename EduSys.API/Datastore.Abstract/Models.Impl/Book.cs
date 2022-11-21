using Datastore.Abstract.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Datastore.Abstract.Models.Impl
{
    public class Book : BaseModel, IBook
    {
        public int BookId { get ; set ; }
        public string Name { get ; set ; }
    }
}
