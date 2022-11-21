using BusinessObject.Abstract;
using Datastore.Abstract;
using Datastore.Abstract.Models.Abstract;
using Datastore.Abstract.Models.Impl;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject.Impl
{
    public class BookBusinessObject : IBookBusinessObject
    {
        public IDataFactory _DataFactory { get; set; }
        public BookBusinessObject(IDataFactory dataFactory)
        {
            _DataFactory = dataFactory;
        }
        public async Task<bool> CreateBook(Book book)
        {
            return await _DataFactory.CreateBook(book);
        }

        public async Task<bool> DeleteBook(Book book)
        {
            return await _DataFactory.DeleteBook(book);
        }

        public async Task<IBook> GetBook(int id)
        {
            return await _DataFactory.GetBook(id);
        }

        public async Task<IEnumerable<IBook>> GetBooks()
        {
            return await _DataFactory.GetBooks();
        }

        public async Task<bool> UpdateBook(Book book)
        {
            return await _DataFactory.UpdateBook(book);
        }
    }
}

