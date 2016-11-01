using MonsterWeb.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace MonsterWeb.Tests
{
    class ServiceTests
    {
        [Fact]
        public void Test_GetGender()
        {
            var service = new DataService();
            var actual = service.GetGender();

            Assert.True(actual != null);
        }
    }
}
