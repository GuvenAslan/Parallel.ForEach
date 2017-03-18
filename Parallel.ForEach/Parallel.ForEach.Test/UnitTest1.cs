using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace Parallel.ForEach.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var users = Program.FillUsers();
            Assert.IsNotNull(users, "Users list is null");

            if (!users.Any())
                Assert.Fail("There is no element in User List");

            var cities = Program.FillCities();
            Assert.IsNotNull(cities, "Cities list is null");

            if (!cities.Any())
                Assert.Fail("There is no element in Cities List");

            Assert.IsTrue(Program.RunForeach(users, cities));
        }
    }
}
