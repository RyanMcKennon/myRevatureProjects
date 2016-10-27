using MonsterApp.dataAccess.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterApp.dataAccess
{
    public partial class AdoData
    {
        public bool UpdateGender(Gender gender)
        {

            var query = "update Monster.Gender set Name = @name, Active = @active where GenderID = @id";
            var name = new SqlParameter("name", gender.Name);
            var active = new SqlParameter("active", gender.Active ? 1 : 0);
            var id = new SqlParameter("id", gender.GenderID);
            int result;

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var cmd = new SqlCommand(query, connection);

                cmd.Parameters.AddRange(new SqlParameter[] { id, name, active });
                result = cmd.ExecuteNonQuery();
            }

            return result == 1;
        }
    }
}
