using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Threading.Tasks;

namespace restApi.config
{
    internal class Configuration
    {
        public static string getLogoUserName()
        {
            return ConfigurationManager.AppSettings["LogoUserName"];
        }
        public static string getLogoPassword()
        {
            return ConfigurationManager.AppSettings["LogoPassword"];
        }
        public static string getCompanyCode()
        {
            return ConfigurationManager.AppSettings["CompanyCode"];
        }
        public static string getSeason()
        {
            return ConfigurationManager.AppSettings["Season"];
        }
        public static string getLogoConnection()
        {
            return ConfigurationManager.AppSettings["logoConnection"];
        }
        public static string getDepartment()
        {
            return ConfigurationManager.AppSettings["Department"];
        }
        public static bool getXMLTransferInfo()
        {
            return Convert.ToBoolean(ConfigurationManager.AppSettings["XMLTransfer"]);
        }
        public static string getUrl()
        {
            return ConfigurationManager.AppSettings["URL"];
        }
    }
}
