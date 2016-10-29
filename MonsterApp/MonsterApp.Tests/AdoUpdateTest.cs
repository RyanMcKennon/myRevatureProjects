using MonsterApp.dataAccess;
using Model = MonsterApp.dataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace MonsterApp.Tests
{
    public partial class AdodataTests
    {
        private Model.Gender gender2;

        public AdodataTests()
        {
            gender2 = new Model.Gender() { GenderID = 1, Name = "updatedName", Active = true };
        }

        [Fact]
        public void Test_UpdateGender()
        {
            var data = new AdoData();
            var actual = data.UpdateGender(gender2);

            Assert.True(actual);
        }
    }
}
