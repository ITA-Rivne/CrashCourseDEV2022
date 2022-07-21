using System;
using MySqlConnector;
//using System.Data.SqlClient;

namespace Lesson4
{
    public static class Database
    {
        private static readonly string _connectionString = "server=localhost; userid=root; password=123456; database=bitnami_opencart";
        public static void ExecuteQuery(string queryString, string message = "")
        {
            using (var connection = new MySqlConnection(_connectionString))
            {
                var command = new MySqlCommand(queryString, connection);
                command.Connection.Open();
                command.ExecuteNonQuery();

                Console.WriteLine(message);
            }
        }

        public static string GetSortOrderByOCCategory(int category_id)
        {
            //var queryString = $@" SELECT `sort_order`, `top`, `category_id`, `image`, `parent_id`,  `column`, `status`, `date_added`, `date_modified` FROM `oc_category` WHERE `category_id`= {category_id}";
            var queryString = $@" SELECT `sort_order` FROM `oc_category` WHERE `category_id`= {category_id}";

            using (var connection = new MySqlConnection(_connectionString))
            {
                var command = new MySqlCommand(queryString, connection);
                
                connection.Open();

                var value = command.ExecuteScalar().ToString();

                Console.WriteLine($"value from DB  = {value}");

                return value.ToString();
            }
        }

        #region SurveysNew
        public static void AddSurveyTemplate(string name, string templateJson)
        {
            var queryString = $@" INSERT INTO  surveys.tblSurveyDefinition
                        ([Name]
                        ,[Title]
                        ,[Json]
                        ,[Version]
                        ,[CreatedBy]
                        ,[CreatedDate])
                 VALUES('{name}'
                        ,'{name}'
                        ,'{templateJson}'
                        ,1
                        ,'Tester'
                        ,'06-23-1981')";

            ExecuteQuery(queryString, "SurveyTemplate was added");
        } 

        public static void CleanContacts(string scholarID)
        {
            var queryClearScholarContacts = $"DELETE FROM tblxScholarContact WHERE ScholarID ='{scholarID}';";
            ExecuteQuery(queryClearScholarContacts);

            var queryClearContacts = $"DELETE FROM tblContact WHERE Email = 'Tester@invalid.com';";
            ExecuteQuery(queryClearContacts, "tblContact is cleaned");
        }
        #endregion
    }
}
