using MonsterApp.dataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace MonsterApp.Tests
{
    public class AdoDataTests
    {
        [Fact]
        public void Test_GetGenders()
        {

            AdoData data = new AdoData();
            var expected = 3;

            var actual = data.GetGender();

            Assert.Equal(expected, actual.Count);
        }

        [Fact]
        public void Test_GetMonsterType()
        {
            AdoData data = new AdoData();
            var expected = 3;
            var actual = data.GetMonsterTypes();

            Assert.Equal(expected, actual.Count);
        }

        [Fact]
        public void Test_GetTitle()
        {
            AdoData data = new AdoData();
            var expected = 3;
            var actual = data.GetTitles();

            Assert.Equal(expected, actual.Count);
        }
    }
}
