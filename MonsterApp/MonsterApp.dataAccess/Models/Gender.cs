using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterApp.dataAccess.Models
{
    /// <summary>
    /// The type of gender the monster can have
    /// </summary>
    public class Gender
    {
        public int GenderID { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }
    }
}
