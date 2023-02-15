using restApi.config;
using restApi.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnityObjects;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace restApi.repository
{
    internal class LogoDataReader
    {
        string season = Configuration.getSeason();
        string companyCode = Configuration.getCompanyCode();
        string conString = Configuration.getLogoConnection();
        public int getLogicalRef(String ficheNo)
        {
            int LogicalRef = 0;

            try
            {
                String Qry = "SELECT ORF.LOGICALREF";
                Qry += " FROM LG_" + companyCode + "_" + season + "_ORFICHE ORF WITH (NOLOCK) ";
                Qry += " WHERE ORF.FICHENO = '" + ficheNo + "'";

                SqlConnection conn = new SqlConnection(conString);
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = Qry;
                sqlCmd.Connection = conn;

                conn.Open();

                SqlDataReader dr = sqlCmd.ExecuteReader();

                if (dr.Read())
                {
                    LogicalRef = int.Parse(dr["LOGICALREF"].ToString());
                }
                conn.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            return LogicalRef;
        }
    }
}
