using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ElectronicDiary.SqlConnect
{
    public class SqlConnector
    {
        public string server = "localhost";
        public string userid = "root";
        public string password = "vertrigo";
        public string database = "electronicdiary";

        public string GetConnect()
        {
            return $"server={server};userid={userid};password={password};database={database}";
        }



    }
}
