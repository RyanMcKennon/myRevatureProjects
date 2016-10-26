using MonsterApp.dataAccess.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterApp.dataAccess
{
    public class AdoData
    {
        // creating a field to store the connection string
        private string connectionString = ConfigurationManager.ConnectionStrings["MonsterDB"].ConnectionString;


        #region Methods
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        //disconnected architecture
        public List<Gender> GetGender()
        {
            try
            {
                var ds = GetDataDisconnected("select * from Monster.Gender;");
                var genders = new List<Gender>();

                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    genders.Add(new Gender()
                    {
                        // in terms of database its better to cast to a string and then parse to convert
                        GenderID = int.Parse(row[0].ToString()),
                        Name = row[1].ToString(),
                        Active = bool.Parse(row[2].ToString())
                    });
                }
                return genders;
            }
            catch(Exception)
            {
                return null;
            }
           
        }
    

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<MonsterType> GetMonsterTypes()
        {
            return new List<MonsterType>();
        }


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<Title> GetTitles()
        {
            return new List<Title>();
        }

        #endregion


        private DataSet GetDataDisconnected(string query)
        {
            // create adapter
            SqlDataAdapter da;
            // create dataset
            DataSet ds;
            //create a command
            SqlCommand cmd;

            //using statement to keep resource leaks from happening
            using (var connection = new SqlConnection())
            {
                cmd = new SqlCommand(query, connection);
                da = new SqlDataAdapter(cmd);
                ds = new DataSet();

                da.Fill(ds);
                
            }
            return ds;

        }


    }
}
