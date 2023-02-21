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
using restApi.shared;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace restApi.repository
{
    internal class LogoDataReader
    {
        string season = Configuration.getSeason();
        string companyCode = Configuration.getCompanyCode();
        string conString = Configuration.getLogoConnection();
        public DataTable dataTable = new DataTable();
        public void PullData()
        {  
            string Qry = "SELECT dataSourceCode =  CASE WHEN SUBSTRING(CLC.CODE,5,1) IN ('I','D','M') THEN 'AYKIZM' " +
                "WHEN SUBSTRING(CLC.CODE,5,1) IN ('A') THEN 'AYKANT'  WHEN SUBSTRING(CLC.CODE,5,1) IN ('K') THEN 'AYKKNY' " +
                "WHEN SUBSTRING(CLC.CODE,5,1) IN ('B') THEN 'AYKIST'  ELSE 'TANIMSIZ' END, " +
                "retailerCode = clc.code," +
                "retailerRefId = clc.LOGICALREF," +
                "channelCode = 'HFS'," +
                "title = clc.DEFINITION_," +
                "email = clc.EMAILADDR," +
                "phone = clc.TELNRS1," +
                "taxOffice = clc.TAXOFFICE," +
                "taxNumber = clc.TAXNR," +
                "contactName = clc.INCHARGE," +
                "country = clc.COUNTRY," +
                "city = clc.CITY," +
                "district = clc.DISTRICT," +
                "aaddress = clc. ADDR1 + clc.ADDR1," +
                "zipCode = clc.POSTCODE " +
                "FROM LG_412_CLCARD CLC WHERE ACTIVE = 0 AND CLC.CODE NOT LIKE '-%'" +
                "AND CLC.CODE NOT LIKE '0%'" +
                "AND CLC.CODE NOT LIKE '1%'" +
                "AND CLC.CODE NOT LIKE '2%'" +
                "AND CLC.CODE NOT LIKE '3%'" +
                "AND CLC.CODE NOT LIKE '4%'" +
                "AND CLC.CODE NOT LIKE '5%'" +
                "AND CLC.CODE NOT LIKE '6%'" +
                "AND CLC.CODE NOT LIKE 'DC%'" +
                "AND CLC.CODE NOT LIKE 'V%' AND CLC.ACTIVE=0";

            SqlConnection conn = new SqlConnection(conString);
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = Qry;
            sqlCmd.Connection = conn;
            SqlDataAdapter sda = new SqlDataAdapter(sqlCmd);
            sda.Fill(dataTable);
            conn.Close();
            sda.Dispose();
        }
    }
}
