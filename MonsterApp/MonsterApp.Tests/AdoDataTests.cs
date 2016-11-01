using MonsterApp.dataAccess;
using MonsterApp.dataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace MonsterApp.Tests
{
    public partial class AdoDataTests
    {
        [Fact]
        public void Test_GetGenders()
        {

            AdoData data = new AdoData();
            var actual = data.GetGender();

            Assert.NotNull(actual);
        }

        [Fact]
        public void Test_GetMonsterType()
        {
            AdoData data = new AdoData();
            var actual = data.GetMonsterTypes();

            Assert.NotNull(actual);
        }

        [Fact]
        public void Test_GetTitle()
        {
            AdoData data = new AdoData();
            var actual = data.GetTitles();

            Assert.NotNull(actual);
        }

        [Fact]
        public void Test_GetRecentGender()
        {
            AdoData data = new AdoData();
            var expected = 21;
            var actual = data.GetRecentGender();

            Assert.Equal(expected, actual);
        }
        
    }
}
