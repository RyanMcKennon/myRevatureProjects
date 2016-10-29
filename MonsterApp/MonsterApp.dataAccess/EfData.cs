using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterApp.dataAccess
{
    public class EfData
    {
        private MonsterDBEntities db = new MonsterDBEntities();


        public List<Gender> GetGenders()
        {
            return db.Genders.ToList();
        }

        public bool InsertGender(Gender gender)
        {
            db.Genders.Add(gender);
            return db.SaveChanges() > 0;
        }

        public bool ChangeGender(Gender gender, EntityState state)
        {
            var entry = db.Entry<Gender>(gender);
            entry.State = state;
            return db.SaveChanges() > 0;
        }

        public object ChangeGender(object expected, EntityState added)
        {
            throw new NotImplementedException();
        }

        public int SearchGender()
        {
            var latest = db.Genders.Where(a=> a.Active).Max(a => a.GenderId);
            //var inactive = db.Genders.Select(a => a.Active == false);
            //var ma = db.Genders.Where(m => m.GenderName.ToLower().Contains("ma"));
            return latest;
        }

        public bool InsertMonster(Monster monster)
        {
            try
            {
                db.Monsters.Add(monster);
                var result = db.SaveChanges();
                return result == 1;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
