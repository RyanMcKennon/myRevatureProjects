using Model = MonsterApp.dataAccess.Models;
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
    public partial class AdoData
    {
        // creating a field to store the connection string
        private string connectionString = ConfigurationManager.ConnectionStrings["MonsterDB"].ConnectionString;


        #region Methods
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        //disconnected architecture
        public List<Model.Gender> GetGender()
        {
            try
            {
                var ds = GetDataDisconnected("select * from Monster.Gender;");
                var genders = new List<Model.Gender>();

                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    genders.Add(new Model.Gender()
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
        public List<Model.MonsterType> GetMonsterTypes()
        {
            try
            {
                var ds = GetDataDisconnected("select * from Monster.MonsterType;");
                var monsterTypes = new List<Model.MonsterType>();

                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    monsterTypes.Add(new Model.MonsterType()
                    {
                        MonsterTypeID = int.Parse(row[0].ToString()),
                        Name = row[1].ToString(),
                        Active = bool.Parse(row[2].ToString())
                    });
                }
                return monsterTypes;
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
        public List<Model.Title> GetTitles()
        {
            try
            {
                var ds = GetDataDisconnected("select * from Monster.Title;");
                var monsterTitles = new List<Model.Title>();

                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    monsterTitles.Add(new Model.Title()
                    {
                        TitleID = int.Parse(row[0].ToString()),
                        Name = row[1].ToString(),
                        Active = bool.Parse(row[2].ToString())
                    });
                }
                return monsterTitles;
            }
            catch(Exception)
            {
                return null;
            }
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
            using (var connection = new SqlConnection(connectionString))
            {
                cmd = new SqlCommand(query, connection);
                da = new SqlDataAdapter(cmd);
                ds = new DataSet();

                da.Fill(ds);
                
            }
            return ds;

        }

        public int GetRecentGender()
        {
            try
            {
                var ds = GetDataDisconnected("select top(1) * from Monster.Gender as mg order by mg.GenderId desc;");
                Model.Gender genders = new Model.Gender();
                genders.GenderID = int.Parse(ds.Tables[0].Rows[0][0].ToString());
                genders.Name = ds.Tables[0].Rows[0][1].ToString();
                genders.Active = bool.Parse(ds.Tables[0].Rows[0][2].ToString());
                int result = genders.GenderID;
                return result;
            }
            catch (Exception)
            {
                return 0;
            }

        }
    }
}
