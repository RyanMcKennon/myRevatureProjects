using MonsterApp.dataAccess;
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
        public void NegativeTest_GetTitle()
        {
            AdoData data = new AdoData();
            var expected = 0;
            var actual = data.GetTitles();

            Assert.Equal(expected, actual.Count);
        }

        [Fact]
        public void NegativeTest_GetMonsterType()
        {
            AdoData data = new AdoData();
            var expected = 1;
            var actual = data.GetMonsterTypes();

            Assert.Equal(expected, actual.Count);
        }

        [Fact]
        public void NegativeTest_GetGenders()
        {

            AdoData data = new AdoData();
            var expected = 2;

            var actual = data.GetGender();

            Assert.Equal(expected, actual.Count);
        }
    }
}
