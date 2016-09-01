namespace ComplexJson
{
    using System;
    using System.Collections.Generic;
    using System.Data;

    using AutoMapper;

    using Newtonsoft.Json;
    using System.Data.SqlClient;
    using System.Configuration;

    public class Program
    {
        public static void Main(string[] args)
        {
            HowTo();
            Console.ReadLine();
        }

        private static void HowTo()
        {
            // Get demo dataset.
            DataSet dataSet = new DataSet(); //  = Seed();

            // Connect to actual database and fill the dataset.
            using (var sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["TestConnection"].ConnectionString))
            {
                var sqlCommand = new SqlCommand("SELECT EmployeeId, EmployeeCode, ManagerId, FirstName, LastName, AverageSalePerDay, TotalSales FROM [dbo].[Demo]", sqlConnection);
                sqlConnection.Open();
                var sqlDataAdpater = new SqlDataAdapter(sqlCommand);
                sqlDataAdpater.Fill(dataSet);
            }

            Mapper.CreateMap<IDataReader, List<Employee>>();
            var datTable = dataSet.Tables[0];
            var result = Mapper.Map<IDataReader, List<Employee>>(datTable.CreateDataReader());
            var resultJson = JsonConvert.SerializeObject(result);

            // Use if you want to serialize with indentation / formatting on.
            //var resultJson = JsonConvert.SerializeObject(result, Formatting.Indented);

            // Counter check by converting it back to original list of employees.
            var originalDataList = JsonConvert.DeserializeObject<List<Employee>>(resultJson);
        }

        private static DataSet Seed()
        {
            var demoDataTable = new DataTable();
            demoDataTable.TableName = "Demo";
            demoDataTable.Columns.Add("EmployeeId", typeof(int));
            demoDataTable.Columns.Add("EmployeeCode", typeof(string));
            demoDataTable.Columns.Add("ManagerId", typeof(int));
            demoDataTable.Columns.Add("FirstName", typeof(string));
            demoDataTable.Columns.Add("LastName", typeof(string));
            demoDataTable.Columns.Add("AverageSalePerDay", typeof(int));
            demoDataTable.Columns.Add("TotalSales", typeof(int));

            demoDataTable.Rows.Add(1, "ABC", 10, "Alex", "Shrute", 12, 100);
            demoDataTable.Rows.Add(2, "COD", 10, "Jasmine", "Roal", 35, 150);
            demoDataTable.Rows.Add(3, "JAS", 12, "Jsinh", "Chauhan", 25, 500);
            demoDataTable.Rows.Add(4, "PAR", 10, "Rex", "Maul", 14, 233);
            demoDataTable.Rows.Add(5, "SUR", 12, "Sam", "Paulo", 21, 200);
            demoDataTable.Rows.Add(6, "RAM", 11, "Remo", "Fernd", 18, 321);
            var dataSet = new DataSet();
            dataSet.Tables.Add(demoDataTable);
            return dataSet;
        }
    }
}