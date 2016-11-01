using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Monster.App.DataAcess.Models;
using MonsterApp.dataAccess.Models;
using MonsterApp.dataAccess;

namespace Monster.App.DataAcess
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "MonsterService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select MonsterService.svc or MonsterService.svc.cs at the Solution Explorer and start debugging.
    public class MonsterService : IMonsterService
    {
        private AdoData data = new AdoData();

        public List<Models.GenderDAO> GetGender()
        {
            var g = new List<Models.GenderDAO>();

            foreach (var gender in data.GetGender())
            {
                g.Add(GenderMapper.MapToGenderDAO(gender));
            }
            return g;
        }

        public List<MonsterTypeDAO> GetMonsterTypes()
        {
            throw new NotImplementedException();
        }

        public List<TitleDAO> GetTitles()
        {
            throw new NotImplementedException();
        }
    }
}
