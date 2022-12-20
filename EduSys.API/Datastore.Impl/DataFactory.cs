using Datastore.Abstract;
using Datastore.Abstract.Models.Abstract;
using Datastore.Abstract.Models.Impl;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Datastore.Impl
{
    public class DataFactory : IDataFactory
    {
        public MockDatastore datastore { get; set; }
        public DataFactory()
        {
            datastore = new MockDatastore();
        }

        public async Task<bool> CreateUser(User user)
        {
            return await Task.Run(() =>
            {
                datastore.Users.Add(user);
                return true;
            });
        }

        public async Task<bool> DeleteUser(User user)
        {
            return await Task.Run(() =>
            {
                datastore.Users.Remove(user);
                return true;
            });
        }

        public async Task<IUser> GetUser(int id)
        {
            return await Task.Run(() =>
            {
                return datastore.Users.Find(u => u.Id == id);
            });
        }

        public async Task<IEnumerable<IUser>> GetUsers()
        {
            return await Task.Run(() =>
            {
                return datastore.Users;
            });

        }

        public async Task<bool> UpdateUser(User user)
        {
            return await Task.Run(() =>
            {
                User existingUser = datastore.Users.Find(u => u.Id == user.Id);

                ///existingUser.CompanyId = user.CompanyId;

                existingUser.Name = user.Name;
                existingUser.Phone = user.Phone;
                existingUser.Status = user.Status;
                existingUser.UpdateBy = user.UpdateBy;
                existingUser.UpdatedDate = DateTime.Now;


                return true;
            });
        }

        public async Task<IBook> GetBook(int id)
        {
            return await Task.Run(() =>
            {
                return datastore.Books.Find(u => u.Id == id);
            });
        }

        public async Task<IEnumerable<IBook>> GetBooks()
        {
            return await Task.Run(() =>
            {
                return datastore.Books;
            });
        }

        public async Task<bool> CreateBook(Book book)
        {
            return await Task.Run(() =>
            {
                datastore.Books.Add(book);
                return true;
            });
        }

        public async Task<bool> DeleteBook(Book book)
        {
            return await Task.Run(() =>
            {
                datastore.Books.Remove(book);
                return true;
            });
        }

        public async Task<bool> UpdateBook(Book book)
        {
            return await Task.Run(() =>
            {
                Book existingBook = datastore.Books.Find(u => u.Id == book.Id);

                ///existingUser.CompanyId = user.CompanyId;

                existingBook.Name = book.Name;

                existingBook.Status = book.Status;
                existingBook.UpdateBy = book.UpdateBy;
                existingBook.UpdatedDate = DateTime.Now;


                return true;
            });
        }

        public async Task<ICourse> GetCourse(int id)
        {
            return await Task.Run(() =>
            {
                return datastore.Courses.Find(u => u.Id == id);
            });
        }

        public async Task<IEnumerable<ICourse>> GetCourses()
        {
            return await Task.Run(() =>
            {
                return datastore.Courses;
            });
        }

        public async Task<bool> CreateCourse(Course course)
        {
            return await Task.Run(() =>
            {
                datastore.Courses.Add(course);
                return true;
            });
        }

        public async Task<bool> DeleteCourse(Course course)
        {
            return await Task.Run(() =>
            {
                datastore.Courses.Remove(course);
                return true;
            });
        }

        public async Task<bool> UpdateCourse(Course course)
        {
            return await Task.Run(() =>
            {
                Course existingCourse = datastore.Courses.Find(u => u.Id == course.Id);

                ///existingUser.CompanyId = user.CompanyId;

                existingCourse.CourseName = course.CourseName;

                existingCourse.Status = course.Status;
                existingCourse.UpdateBy = course.UpdateBy;
                existingCourse.UpdatedDate = DateTime.Now;


                return true;
            });
        }

        public async Task<IAttendance> GetAttendance(int id)
        {
            return await Task.Run(() =>
            {
                return datastore.Attendances.Find(u => u.Id == id);
            });
        }

        public async Task<IEnumerable<IAttendance>> GetAttendances()
        {
            return await Task.Run(() =>
            {
                return datastore.Attendances;
            });
        }

        public async Task<bool> CreateAttendance(Attendance attendance)
        {
            return await Task.Run(() =>
            {
                datastore.Attendances.Add(attendance);
                return true;
            });
        }

        public async Task<bool> DeleteAttendance(Attendance attendance)
        {
            return await Task.Run(() =>
            {
                datastore.Attendances.Remove(attendance);
                return true;
            });
        }

        public async Task<bool> UpdateAttendance(Attendance attendance)
        {
            return await Task.Run(() =>
            {
                Attendance existingAttendance = datastore.Attendances.Find(u => u.Id == attendance.Id);

                ///existingUser.CompanyId = user.CompanyId;

                existingAttendance.Name = attendance.Name;

                existingAttendance.Status = attendance.Status;
                existingAttendance.UpdateBy = attendance.UpdateBy;
                existingAttendance.UpdatedDate = DateTime.Now;


                return true;
            });
        }

        public async Task<IFees> GetFees(int id)
        {
            return await Task.Run(() =>
            {
                return datastore.Feess.Find(u => u.Id == id);
            });
        }

        public async Task<IEnumerable<IFees>> GetFeess()
        {
            return await Task.Run(() =>
            {
                return datastore.Feess;
            });
        }

        public async Task<bool> CreateFees(Fees fees)
        {
            return await Task.Run(() =>
            {
                datastore.Feess.Add(fees);
                return true;
            });
        }

        public async Task<bool> DeleteFees(Fees fees)
        {
            return await Task.Run(() =>
            {
                datastore.Feess.Remove(fees);
                return true;
            });
        }

        public async Task<bool> UpdateFees(Fees fees)
        {
            return await Task.Run(() =>
            {
                Fees existingFees = datastore.Feess.Find(u => u.Id == fees.Id);

                ///existingUser.CompanyId = user.CompanyId;

                existingFees.Name = fees.Name;

                existingFees.Status = fees.Status;
                existingFees.UpdateBy = fees.UpdateBy;
                existingFees.UpdatedDate = DateTime.Now;


                return true;
            });
        }

        public async Task<ITimeTable> GetTimeTable(int id)
        {
            return await Task.Run(() =>
            {
                return datastore.TimeTables.Find(u => u.Id == id);
            });
        }

        public async Task<IEnumerable<ITimeTable>> GetTimeTables()
        {
            return await Task.Run(() =>
            {
                return datastore.TimeTables;
            });
        }

        public async Task<bool> CreateTimeTable(TimeTable timetable)
        {
            return await Task.Run(() =>
            {
                datastore.TimeTables.Add(timetable);
                return true;
            });
        }

        public async Task<bool> DeleteTimeTable(TimeTable timetable)
        {
            return await Task.Run(() =>
            {
                datastore.TimeTables.Remove(timetable);
                return true;
            });
        }

        public async Task<bool> UpdateTimeTable(TimeTable timetable)
        {
            return await Task.Run(() =>
            {
                TimeTable existingTimeTable = datastore.TimeTables.Find(u => u.Id == timetable.Id);

                ///existingUser.CompanyId = user.CompanyId;

                existingTimeTable.Name = timetable.Name;

                existingTimeTable.Status = timetable.Status;
                existingTimeTable.UpdateBy = timetable.UpdateBy;
                existingTimeTable.UpdatedDate = DateTime.Now;


                return true;
            });
        }

    }
}
