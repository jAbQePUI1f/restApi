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
        public string getDataSourceCode(String sourceCode)
        {
            string DataSourceCode="";
            try
            {
                String Qry = "SELECT";
                Qry += "dataSourceCode = CASE WHEN SUBSTRING(CLC.CODE,5,1) IN ('I', 'D', 'M') THEN 'AYKIZM'";
                Qry += "WHEN SUBSTRING(CLC.CODE,5,1) IN('A') THEN 'AYKANT'";
                Qry += "WHEN SUBSTRING(CLC.CODE,5,1) IN('K') THEN 'AYKKNY'";
                Qry += "WHEN SUBSTRING(CLC.CODE,5,1) IN('B') THEN 'AYKIST'";
                Qry += "ELSE 'TANIMSIZ' END";
                Qry += "FROM LG_" + companyCode + "_" + season + "_CLCARD CLC WHERE ACTIVE = 0 AND CLC.CODE NOT LIKE '-%'";
                Qry += "AND CLC.CODE NOT LIKE '0%'";
                Qry += "AND CLC.CODE NOT LIKE '1%'";
                Qry += "AND CLC.CODE NOT LIKE '2%'";
                Qry += "AND CLC.CODE NOT LIKE '3%'";
                Qry += "AND CLC.CODE NOT LIKE '4%'";
                Qry += "AND CLC.CODE NOT LIKE '5%'";
                Qry += "AND CLC.CODE NOT LIKE '6%'";
                Qry += "AND CLC.CODE NOT LIKE 'DC%'";
                Qry += "AND CLC.CODE NOT LIKE 'V%'";


                SqlConnection conn = new SqlConnection(conString);
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = Qry;
                sqlCmd.Connection = conn;

                conn.Open();

                SqlDataReader dr = sqlCmd.ExecuteReader();

                if (dr.Read())
                {
                    DataSourceCode = dr["sourceCode"].ToString();
                }
                conn.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return DataSourceCode;

            //CreateRetailerReqJson postRetailModel = new CreateRetailerReqJson();
            //postRetailModel.address = "";


            //HttpClientHelper helper = new HttpClientHelper();

            //helper.SendPOSTRequest("username", "pass", "Retailers", postRetailModel);
        }
        public string getRetailerCode(String customerCode)
        {
            string RetailerCode="";
            try
            {
                String Qry = "SELECT";
                Qry += "CLC.CODE";
                Qry += "FROM LG_412_CLCARD CLC WHERE ACTIVE = 0 AND CLC.CODE NOT LIKE '-%'";
                Qry += "AND CLC.CODE NOT LIKE '0%'";
                Qry += "AND CLC.CODE NOT LIKE '1%'";
                Qry += "AND CLC.CODE NOT LIKE '2%'";
                Qry += "AND CLC.CODE NOT LIKE '3%'";
                Qry += "AND CLC.CODE NOT LIKE '4%'";
                Qry += "AND CLC.CODE NOT LIKE '5%'";
                Qry += "AND CLC.CODE NOT LIKE '6%'";
                Qry += "AND CLC.CODE NOT LIKE 'DC%'";
                Qry += "AND CLC.CODE NOT LIKE 'V%' AND CLC.ACTIVE = 0";


                SqlConnection conn = new SqlConnection(conString);
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = Qry;
                sqlCmd.Connection = conn;

                conn.Open();

                SqlDataReader dr = sqlCmd.ExecuteReader();

                if (dr.Read())
                {
                    RetailerCode = dr["CODE"].ToString();
                }
                conn.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return RetailerCode;
        }
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
