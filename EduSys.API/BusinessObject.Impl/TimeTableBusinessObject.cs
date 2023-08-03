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
    public class TimeTableBusinessObject : ITimeTableBusinessObject
    {
        public IDataFactory _DataFactory { get; set; }
        public TimeTableBusinessObject(IDataFactory dataFactory)
        {
            _DataFactory = dataFactory;
        }
        public async Task<bool> CreateTimeTable(TimeTable timetable)
        {
            return await _DataFactory.CreateTimeTable(timetable);
        }

        public async Task<bool> DeleteTimeTable(TimeTable timetable)
        {
            return await _DataFactory.DeleteTimeTable(timetable);
        }

        public async Task<ITimeTable> GetTimeTable(int id)
        {
            return await _DataFactory.GetTimeTable(id);
        }

        public async Task<IEnumerable<ITimeTable>> GetTimeTables()
        {
            return await _DataFactory.GetTimeTables();
        }

        public async Task<bool> UpdateTimeTable(TimeTable timetable)
        {
            return await _DataFactory.UpdateTimeTable(timetable);
        }
    }
}
