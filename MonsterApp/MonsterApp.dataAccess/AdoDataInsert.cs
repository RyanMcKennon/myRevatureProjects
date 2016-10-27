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
        #region insert
        /// <summary>
        /// Inserting a gender type into the database
        /// </summary>
        /// <param name="gender"></param>
        /// <returns></returns>
        public bool InsertGender(Gender gender)
        {
            var n = new SqlParameter("name", gender.Name);
            var query = "insert into Monster.Gender(GenderName, Active) values (@name,1)";
            return InsertData(query,n) ==1;
        }


        private int InsertData(string query, params SqlParameter[] parameters)
        {
            int result;
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddRange(parameters);
                result = cmd.ExecuteNonQuery();
            }
            return result;
        }
        #endregion

    }
}
