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
                        UserId = 1,
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
                        UserId = 2,
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
                        BookId = 1,
                        CompanyId = 1,
                        CreatedBy = 1,
                        CreatedDate = DateTime.Now.AddDays(-10),
                       
                        Name = "C++",
                        
                        Status = StatusType.Active
                    },
                    new Book()
                    {
                        BookId = 2,
                        CompanyId = 1,
                        CreatedBy = 1,
                        CreatedDate = DateTime.Now.AddDays(-9),
                        
                        Name = "C",
                        
                        Status = StatusType.Active
                    }
        };
    }
}
