using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using CV.ADO;
namespace CV.ADO
{
    public class CRUD : Attributes
    {
        /*
         * Creation date: November of 2021
         * Author : APDI Felipe Granados
         * Descripción: CRUD Conection to database
         */
        private string connectionChain;
        public CRUD()
        {
            connectionChain = ConfigurationManager.ConnectionStrings["HumanResources"].ConnectionString;
        }

        public string connectionDataBase()
        {
            try
            {
                connection = new SqlConnection(connectionChain);
                connection.Open();
                return "ok";
            }
            catch (Exception e)
            {
                return "Ok"+e.Message;
            }
        }
        public string execStoredprocedure(String query)
        {
            try
            {
                command = new SqlCommand(query, connection);
                return "ok";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string parameters(string parameter, string content)
        {
            try
            {
                command.Parameters.AddWithValue(parameter, content);
                return "ok";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string executeSQL()
        {
            try
            {
                command.ExecuteNonQuery();
                return "ok";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public DataTable extractData()
        {
            try
            {
                dataAdapter = new SqlDataAdapter(command);
                table = new DataTable();
                dataAdapter.Fill(table);
                return table;
            }
            catch
            {
                return table;
            }
        }
       
    }
}