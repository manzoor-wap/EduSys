using Datastore.Abstract.Models.Abstract;
using Datastore.Abstract.Models.Impl;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject.Abstract
{
    public interface IBookBusinessObject
    {
        Task<IBook> GetBook(int id);
        Task<IEnumerable<IBook>> GetBooks();
        Task<bool> CreateBook(Book book);
        Task<bool> DeleteBook(Book book);
        Task<bool> UpdateBook(Book book);
    }

   
    
}
