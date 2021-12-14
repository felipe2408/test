using CV.ADO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
namespace CV
{
    public partial class AddEmployee : System.Web.UI.Page
    {
        protected int idEmployee;
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void sendEmployee_Click(object sender, EventArgs e)
        {
            if (FileUpload1.HasFile)
            {

                //GET EXTENSION
                string ext = System.IO.Path.GetExtension(FileUpload1.FileName);
                ext = ext.ToLower();

                //bytes
                int tam = FileUpload1.PostedFile.ContentLength;

                Response.Write(ext + ", " + tam);

                //verificaction extension
                if (ext == ".pdf")
                {
                    FileUpload1.SaveAs(Server.MapPath(@"‪C:\pruebas\ " + FileUpload1.FileName));
                    Response.Write("archivo subido");
                }


            }
            else
            {
                Response.Write("Seleccione un archivo");

            }
            /*
            HumanResourcesDB data = new HumanResourcesDB();
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
            var storeProcedureOk = data.saveEmployee(documentTypeEmployee, documentNumberEmployee, surnameEmployee, secondSurnameEmployee, namesEmployee, jobFunctionEmployee, startDateEmployee, endDateEmployee, companyEmployee, stateEmployee);
            if (storeProcedureOk == "ok")
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "alertlns", "alert('¡Empleado agregado con exito!')", true);
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "alertlns", "alert('¡Ouch! Ocurrio un error inesperado')", true);

            }
            Server.Transfer("GetEmployees.aspx");
            */
        }
        
    }
}