using Datastore.Abstract.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Datastore.Abstract.Models.Impl
{
    public class Book : BaseModel, IBook
    {
       
        public string Author { get; set; }
    }
}
