using Model = MonsterApp.dataAccess.Models;
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
        public bool InsertGender(Model.Gender gender)
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

        public bool InsertMonster(Model.Monster monster)
        {
            var n0 = new SqlParameter("GenderID", monster.GenderID);
            var n1 = new SqlParameter("TitleID", monster.TitleID);
            var n2 = new SqlParameter("TypeID", monster.TypeID);
            var n3 = new SqlParameter("Name", monster.Name);
            var n4 = new SqlParameter("PicturePath", monster.PicturePath);
            var n5 = new SqlParameter("Active", monster.Active);
            var query = "insert into Monster.Monster(GenderID,TitleID,TypeID,Name,PicturePath,Active) values (@GenderID,@TitleID,@TypeID,@Name,@PicturePath,@Active)";

            return InsertData(query, n0, n1, n2, n3, n4, n5) == 1;
        }
        #endregion

    }
}
