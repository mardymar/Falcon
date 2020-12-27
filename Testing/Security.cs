using Security;
using Shared.Models;
using System;
using System.Diagnostics;
using System.Security.Permissions;
using Xunit;

namespace Testing
{
    public class UnitTest1
    {
        [Fact]
        public void TestPasswordTrue()
        {
            LocalUser user = new LocalUser()
            {
                UserName = "mperry",
                Password = Authentication.GetHashForString("salt", "pass"),
                Salt = "salt",
                FirstName = "Marc",
                LastName = "Perry"
            };

            var test = Authentication.DoLogin("pass", user);

            Assert.True(test);
        }

        [Fact]
        public void TestPasswordFalse()
        {
            LocalUser user = new LocalUser()
            {
                UserName = "mperry",
                Password = Authentication.GetHashForString("salt", "pass"),
                Salt = "salt",
                FirstName = "Marc",
                LastName = "Perry"
            };

            var test = Authentication.DoLogin("password", user);

            Assert.False(test);
        }
    }
}
