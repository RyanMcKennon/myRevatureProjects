using MonsterApp.dataAccess;
using Model = MonsterApp.dataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace MonsterApp.Tests
{   /// <summary>
    /// 
    /// </summary>
    public class efDataTest
    {
        private Gender gender;
        private Monster monster;

        [Fact]
        public void Test_GetGender()
        {
            var data = new EfData();
            var actual = data.GetGenders();

            Assert.NotNull(actual);
        }


        [Fact]
        public void Test_ChangeGender()
        {
            var data = new EfData();
            var expected = new Gender() { GenderName = "Martian", Active = false };
            var actual = data.ChangeGender(expected, System.Data.Entity.EntityState.Added);

            Assert.True(actual);
        }

        [Fact]
        public void Test_DeleteGender()
        {
            var data = new EfData();
            var expected = new Gender() { GenderId = 3 };
            var actual = data.ChangeGender(expected, System.Data.Entity.EntityState.Deleted);

            Assert.True(actual);
        }

        [Fact]
        public void Test_InsertMonster()
        {
            var data = new EfData();
            var expected = new Monster() { GenderId = 3, TitleId = 1, TypeId = 1, Name = "rawr", PicturePath = "path", Active = true };
            var actual = data.InsertMonster(expected);

            Assert.True(actual);
            
        }

        [Fact]
        public void TestBadData_InsertMonster()
        {
            var data = new EfData();
            var expected = new Monster() { GenderId = 1, TitleId = 1, TypeId = 1, Name = "rawr", PicturePath = "path", Active = false };
            var actual = data.InsertMonster(expected);

            Assert.False(actual);
        }

        [Fact]
        public void Test_SearchGender()
        {
            var data = new EfData();
            var expected = 21;
            var actual = data.SearchGender();

            Assert.Equal(actual,expected);
        }
    }
}
