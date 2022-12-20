using Datastore.Abstract.Constants;
using Datastore.Abstract.Models.Impl;
using System;
using System.Collections.Generic;

namespace Datastore.Impl
{
    public class MockDatastore
    {
        public List<User> Users = new List<User>()
        {
                    new User()
                    {
                        Id = 1,
                        CompanyId = 1,
                        CreatedBy = 1,
                        CreatedDate = DateTime.Now.AddDays(-10),
                        Email = "gmail@rajinikanth.com",
                        Name = "Rajini",
                        Phone = "987654321",
                        Status = StatusType.Active
                    },
                    new User()
                    {
                        Id = 2,
                        CompanyId = 1,
                        CreatedBy = 1,
                        CreatedDate = DateTime.Now.AddDays(-9),
                        Email = "gmail@vijayakanth.com",
                        Name = "vijay",
                        Phone = "987654322",
                        Status = StatusType.Active
                    }
        };




        public List<Book> Books = new List<Book>()
        {
                    new Book()
                    {
                        Id = 1,
                        CompanyId = 1,
                        CreatedBy = 1,
                        CreatedDate = DateTime.Now.AddDays(-10),

                        Name = "C++",

                        Status = StatusType.Active
                    },
                    new Book()
                    {
                        Id = 2,
                        CompanyId = 1,
                        CreatedBy = 1,
                        CreatedDate = DateTime.Now.AddDays(-9),

                        Name = "C",

                        Status = StatusType.Active
                    }
        };

        public List<Course> Courses = new List<Course>()
        {
                    new Course()
                    {
                        Id = 1,
                        CompanyId = 1,
                        CreatedBy = 1,
                        CreatedDate = DateTime.Now.AddDays(-10),

                        CourseName = "BCA",

                        Status = StatusType.Active
                    },
                    new Course()
                    {
                        Id = 2,
                        CompanyId = 1,
                        CreatedBy = 1,
                        CreatedDate = DateTime.Now.AddDays(-9),

                        CourseName = " B.SC",

                        Status = StatusType.Active
                    }
        };
       
        public List<Attendance> Attendances = new List<Attendance>()
        {
                    new Attendance()
                    {
                        Id = 1,
                        CompanyId = 1,
                        CreatedBy = 1,
                        CreatedDate = DateTime.Now.AddDays(-10),
                         Email = "gmail@rajinikanth.com",
                        Name = "Rajini",
                        Phone = "987654321",
                        Status = StatusType.Active
                    },
                    new Attendance()
                    {
                        Id = 2,
                        CompanyId = 1,
                        CreatedBy = 1,
                        CreatedDate = DateTime.Now.AddDays(-9),
                       Email = "gmail@vijayakanth.com",
                        Name = "vijay",
                        Phone = "987654322",
                        Status = StatusType.Active
                    }
        };

        public List<Fees> Feess = new List<Fees>()
        {
                    new Fees()
                    {
                        Id = 1,
                        CompanyId = 1,
                        CreatedBy = 1,
                        CreatedDate = DateTime.Now.AddDays(-10),
                         Email = "gmail@rajinikanth.com",
                        Name = "Rajini",
                        Phone = "987654321",
                        Status = StatusType.Active
                    },
                    new Fees()
                    {
                        Id = 2,
                        CompanyId = 1,
                        CreatedBy = 1,
                        CreatedDate = DateTime.Now.AddDays(-9),
                       Email = "gmail@vijayakanth.com",
                        Name = "vijay",
                        Phone = "987654322",
                        Status = StatusType.Active
                    }
        };

        public List<TimeTable> TimeTables = new List<TimeTable>()
        {
                    new TimeTable()
                    {
                        Id = 1,
                        CompanyId = 1,
                        CreatedBy = 1,
                        CreatedDate = DateTime.Now.AddDays(-10),

                        ClassTiming = "9:00 AM - 10:00 AM",
                        Subject = "Maths",

                        Status = StatusType.Active
                    },
                    new TimeTable()
                    {
                        Id = 2,
                        CompanyId = 1,
                        CreatedBy = 1,
                        CreatedDate = DateTime.Now.AddDays(-9),

                        ClassTiming = "10:00 AM - 11:00 AM",
                        Subject = "Chemistry",

                        Status = StatusType.Active
                    }
        };
    }
}
