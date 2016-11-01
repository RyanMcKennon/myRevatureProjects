using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterApp.dataAccess.Models
{
    /// <summary>
    /// The type of monster that we have in a movie
    /// </summary>
    public class MonsterType
    {
        public int MonsterTypeID { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }
    }
}
