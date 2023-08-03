using Datastore.Abstract.Models.Abstract;
using Datastore.Abstract.Models.Impl;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject.Abstract
{
    public interface ITimeTableBusinessObject
    {
        Task<ITimeTable> GetTimeTable(int id);
        Task<IEnumerable<ITimeTable>> GetTimeTables();
        Task<bool> CreateTimeTable(TimeTable timetable);
        Task<bool> DeleteTimeTable(TimeTable timetable);
        Task<bool> UpdateTimeTable(TimeTable timetable);
    }
}