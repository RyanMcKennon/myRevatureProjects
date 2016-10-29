using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterApp.dataAccess.Models
{
    public class Monster
    {
        public int MonsterID { get; set; }
        public int GenderID { get; set; }
        public int TitleID { get; set; }
        public int TypeID { get; set; }
        public string Name { get; set; }
        public string PicturePath { get; set; }
        public bool Active { get; set; }
    }
}
