using Dapper;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonProject.Data
{
    public class ExcelDataAcces
    {
        public static string TestDataFileConection()
        {
            var fileName = @"C:\Users\abhib\source\repos\AmazonProject\AmazonProject\Data\Credentials.xlsx";
            var can = string.Format(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source = {0}; Extended Properties=Excel 12.0;", fileName);
            return can;
        }

        public static UsersData AccessDataFromFile(string keyName)
        {
            using (var connection = new OleDbConnection(TestDataFileConection()))
            {
                connection.Open();
                var query = string.Format("select * from [DataSet$] where key='{0}'", keyName);
                var value = connection.Query<UsersData>(query).FirstOrDefault();
                connection.Close();
                return value;
            }
        }
    }
}
