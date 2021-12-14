using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CV.ADO
{
    public class Attributes
    {
        public SqlConnection connection;
        protected SqlCommand command;
        protected SqlDataAdapter dataAdapter;
        protected DataTable table;

    }
}