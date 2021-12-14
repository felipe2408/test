using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace CV.ADO
{
    public class HumanResourcesDB : CRUD
    {
        /*
         * 
         * 
         * 
         * 
         * */

        public DataTable getEmployees()
        {
            string query = "EXEC sp_getEmployee";
            string result = this.connectionDataBase();
            if (result != "ok")
            {
                return table;
            }
            result = this.execStoredprocedure(query);
            if (result != "ok")
            {
                return table;
            }
            return this.extractData();
        }
        public string saveEmployee(string documentTypeId, string documentNumber, string surname, string secondSurname, string names, string jobFunction, string startDate, string endDate, string companyId, string state)
        {

            string query = "EXEC sp_saveEmployee @DocumentTypeId,@DocumentNumber,@Surname,@SecondSurname,@Names,@JobFunction,@StartDate,@EndDate,@CompanyId,@State";

            string result = this.connectionDataBase();
            if (result != "ok")
            {
                return "false";
            }
            result = this.execStoredprocedure(query);
            if (result != "ok")
            {
                return "false";
            }
            result = this.parameters("@DocumentTypeId", documentTypeId);
            result = this.parameters("@DocumentNumber", documentNumber);
            result = this.parameters("@Surname", surname);
            result = this.parameters("@SecondSurname", secondSurname);
            result = this.parameters("@Names", names);
            result = this.parameters("@JobFunction", jobFunction);
            result = this.parameters("@StartDate", startDate);
            result = this.parameters("@EndDate", endDate);
            result = this.parameters("@CompanyId", companyId);
            result = this.parameters("@State", state);
            return this.executeSQL();
        }
        public string updateEmployee(string id,string documentTypeId, string documentNumber, string surname, string secondSurname, string names, string jobFunction, string startDate, string endDate, string companyId, string state)
        {
            string query = "EXEC updateEmployee @id,@documentTypeId,@documentNumber,@surname,@secondSurname,@names,@jobFunction,@startDate,@endDate,@companyId,@state";
            string result = this.connectionDataBase();
            if (result != "ok")
            {
                return "false";
            }
            result = this.execStoredprocedure(query);
            if (result != "ok")
            {
                return "false";
            }
            result = this.parameters("@id", id);
            result = this.parameters("@documentTypeId", documentTypeId);
            result = this.parameters("@documentNumber", documentNumber);
            result = this.parameters("@surname", surname);
            result = this.parameters("@secondSurname", secondSurname);
            result = this.parameters("@names", names);
            result = this.parameters("@jobFunction", jobFunction);
            result = this.parameters("@startDate", startDate);
            result = this.parameters("@endDate", endDate);
            result = this.parameters("@companyId", companyId);
            result = this.parameters("@state", state);
            return this.executeSQL();
        }

        /*
         * 
         * 
         * */
        public DataTable getDocumentType(string documentType)
        {
            string query = "EXEC sp_documentType @documentType";
            string result = this.connectionDataBase();
            if (result != "ok")
            {
                return table;
            }
            result = this.execStoredprocedure(query);
            if (result != "ok")
            {
                return table;
            }
            result = this.parameters("@documentType", documentType);
            executeSQL();
            return this.extractData();
        }
        public DataTable searchEmployee(string type, string data)
        {
            string query = "EXEC  @type,@data";
            string result = this.connectionDataBase();
            if (result != "ok")
            {
                return table;
            }
            result = this.execStoredprocedure(query);
            if (result != "ok")
            {
                return table;
            }
            result = this.parameters("@type", type);
            result = this.parameters("@data", data);
            executeSQL();
            return this.extractData();

        }


    }
}