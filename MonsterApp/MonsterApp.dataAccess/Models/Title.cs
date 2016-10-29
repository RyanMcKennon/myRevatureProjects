using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterApp.dataAccess.Models
{
    /// <summary>
    /// The prefix that a monster may have on their name
    /// </summary>
    public class Title
    {

        public int TitleID { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }
    }
}
