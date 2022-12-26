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
    public class MarksBusinessObject : IMarksBusinessObject
    {
        public IDataFactory _DataFactory { get; set; }
        public MarksBusinessObject(IDataFactory dataFactory)
        {
            _DataFactory = dataFactory;
        }
        public async Task<bool> CreateMarks(Marks marks)
        {
            return await _DataFactory.CreateMarks(marks);
        }

        public async Task<bool> DeleteMarks(Marks marks)
        {
            return await _DataFactory.DeleteMarks(marks);
        }

        public async Task<IMarks> GetMarks(int id)
        {
            return await _DataFactory.GetMarks(id);
        }

        public async Task<IEnumerable<IMarks>> GetMarkss()
        {
            return await _DataFactory.GetMarkss();
        }

        public async Task<bool> UpdateMarks(Marks marks)
        {
            return await _DataFactory.UpdateMarks(marks);
        }
    }
}

