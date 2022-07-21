using CloudCustomers.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudCustomers.UnitTests.Fixtures
{
    public static class UsersFixture
    {
        public static List<User> GetTestUsers() =>
            new()
            {
                new User
                {
                    Name = "Test User 1",
                    Email = "test.user.1@product.com",
                    Address = new()
                    {
                        Street = "123 Sofia St",
                        City = "Sofia",
                        ZipCode = "1000"
                    }
                },
                new User
                {
                    Name = "Test User 2",
                    Email = "test.user.2@product.com",
                    Address = new()
                    {
                        Street = "123 Plovdiv St",
                        City = "Plovdiv",
                        ZipCode = "4000"
                    }
                },
                new User
                {
                    Name = "Test User 3",
                    Email = "test.user.3@product.com",
                    Address = new()
                    {
                        Street = "123 Varna St",
                        City = "Maika",
                        ZipCode = "2000"
                    }
                }
            };
    }
}
