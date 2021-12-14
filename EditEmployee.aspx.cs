using CV.ADO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CV
{
    public partial class EditEmployee : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           

            if (!Page.IsPostBack)
            {
                HumanResourcesDB data = new HumanResourcesDB();
                var p = Session["documentType"].ToString().Trim();
                // DataTable documentTypeEmployee = data.getDocumentType(p);
                //string pa = documentTypeEmployee.Rows[0][0].ToString();
                id.Text = (string)Session["Id"];
                //documentType.SelectedValue  = "PA";
                documentNumber.Text = (string)Session["documentNumber"];
                surname.Text = (string)Session["surname"];
                secondSurname.Text = (string)Session["secondSurname"];
                names.Text = (string)Session["names"];
                jobFunction.Text = (string)Session["jobFunction"];
                startDate.Text = (string)Session["startDate"];
                endDate.Text = (string)Session["endDate"];
                //company.SelectedValue = (string)Session["company"];
                //state.SelectedValue = (string)Session["state"];
              
            }

            
       }
        protected void editEmployee_Click(object sender, EventArgs e)
        {
            HumanResourcesDB data = new HumanResourcesDB();
            string idEmployee = id.Text.ToString();
            string documentTypeEmployee = documentType.SelectedValue.ToString();
            string documentNumberEmployee = documentNumber.Text.ToString();
            string surnameEmployee = surname.Text.ToString();
            string secondSurnameEmployee = secondSurname.Text.ToString();
            string namesEmployee = names.Text.ToString();
            string jobFunctionEmployee = jobFunction.Text.ToString();
            string startDateEmployee = startDate.Text.ToString();
            string endDateEmployee = endDate.Text.ToString();
            string companyEmployee = company.SelectedValue.ToString();
            string stateEmployee = state.SelectedValue.ToString();
            var storeProcedureOk = data.updateEmployee(idEmployee,documentTypeEmployee, documentNumberEmployee, surnameEmployee, secondSurnameEmployee, namesEmployee, jobFunctionEmployee, startDateEmployee, endDateEmployee, companyEmployee, stateEmployee);
            if (storeProcedureOk == "ok")
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "alertlns", "alert('¡Empleado editado con exito!')", true);
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "alertlns", "alert('¡Ouch! Ocurrio un error inesperado')", true);

            }
            Server.Transfer("GetEmployees.aspx");


        }
        
    }
}