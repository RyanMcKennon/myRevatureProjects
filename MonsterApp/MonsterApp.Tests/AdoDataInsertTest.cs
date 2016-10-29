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
    public partial class AdoDataTests
    {
        private Model.Gender gender;
        public AdoDataTests()
        {
            gender = new Model.Gender() { Name = "TestGender" };
        }

        [Fact]
        public void Test_InsertGender()
        {
            var data = new AdoData();
            var actual = data.InsertGender(gender);

            Assert.True(actual);
        }

        [Fact]
        public void Test_InsertMonster()
        {
            var data = new AdoData();
            var expected = new Model.Monster() { GenderID = 3, TitleID = 2,TypeID = 2, Name = "AdoInsert", PicturePath = "pathz", Active = false };
            var actual = data.InsertMonster(expected);

            Assert.True(actual);
        }
    }
}
