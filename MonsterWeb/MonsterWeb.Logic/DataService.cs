using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MonsterWeb.Logic.ServiceReference1;
using Monster.App.DataAcess.Models;

namespace MonsterWeb.Logic
{
    public class DataService
    {
        private  ServiceReference1.MonsterServiceClient msc = new ServiceReference1.MonsterServiceClient();

        public List<GenderDAO> GetGender()
        {
            return msc.GetGender().ToList();
        }
    }
}
