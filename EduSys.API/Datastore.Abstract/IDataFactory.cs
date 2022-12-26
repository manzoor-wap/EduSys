using Datastore.Abstract.Models;
using Datastore.Abstract.Models.Abstract;
using Datastore.Abstract.Models.Impl;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Datastore.Abstract
{
    public interface IDataFactory
    {
        Task<IUser> GetUser(int id);
        Task<IEnumerable<IUser>> GetUsers();
        Task<bool> CreateUser(User user);
        Task<bool> DeleteUser(User user);
        Task<bool> UpdateUser(User user);


        Task<IBook> GetBook(int id);
        Task<IEnumerable<IBook>> GetBooks();
        Task<bool> CreateBook(Book book);
        Task<bool> DeleteBook(Book book);
        Task<bool> UpdateBook(Book book);


        Task<ICourse> GetCourse(int id);
        Task<IEnumerable<ICourse>> GetCourses();
        Task<bool> CreateCourse(Course course);
        Task<bool> DeleteCourse(Course course);
        Task<bool> UpdateCourse(Course course);


        Task<IAttendance> GetAttendance(int id);
        Task<IEnumerable<IAttendance>> GetAttendances();
        Task<bool> CreateAttendance(Attendance attendance);
        Task<bool> DeleteAttendance(Attendance attendance);
        Task<bool> UpdateAttendance(Attendance attendance);

        Task<IFees> GetFees(int id);
        Task<IEnumerable<IFees>> GetFeess();
        Task<bool> CreateFees(Fees fees);
        Task<bool> DeleteFees(Fees fees);
        Task<bool> UpdateFees(Fees fees);

        Task<ITimeTable> GetTimeTable(int id);
        Task<IEnumerable<ITimeTable>> GetTimeTables();
        Task<bool> CreateTimeTable(TimeTable timetable);
        Task<bool> DeleteTimeTable(TimeTable timetable);
        Task<bool> UpdateTimeTable(TimeTable timetable);

        Task<IMarks> GetMarks(int id);
        Task<IEnumerable<IMarks>> GetMarkss();
        Task<bool> CreateMarks(Marks marks);
        Task<bool> DeleteMarks(Marks marks);
        Task<bool> UpdateMarks(Marks marks);
    }
}

