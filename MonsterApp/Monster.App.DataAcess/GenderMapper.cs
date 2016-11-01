using Monster.App.DataAcess.Models;
using MonsterApp.dataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Monster.App.DataAcess
{
    public class GenderMapper
    {
        public static GenderDAO MapToGenderDAO(Gender gender)
        {
            var g = new GenderDAO();

            g.id = gender.GenderID;
            g.Name = gender.Name;
            return g;
        }

        public static Gender MapToGender(GenderDAO gender)
        {
            return null;
        }
    }
}