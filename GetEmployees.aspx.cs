using CV.ADO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CV
{
    public partial class GetEmployees : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }
        protected void employeesTable_SelectedIndexChanged(object sender, EventArgs e)
        {   
            Session["Id"] = employeesTable.SelectedRow.Cells[0].Text;
            Session["documentType"] = employeesTable.SelectedRow.Cells[1].Text;
            Session["documentNumber"] = employeesTable.SelectedRow.Cells[2].Text;
            Session["surname"] = employeesTable.SelectedRow.Cells[3].Text;
            Session["secondSurname"] = employeesTable.SelectedRow.Cells[4].Text;
            Session["names"] = employeesTable.SelectedRow.Cells[5].Text;
            Session["jobFunction"] = employeesTable.SelectedRow.Cells[6].Text;
            Session["startDate"] = employeesTable.SelectedRow.Cells[7].Text;
            Session["endDate"] = employeesTable.SelectedRow.Cells[8].Text;
            Session["company"] = employeesTable.SelectedRow.Cells[9].Text;
            Session["state"] = employeesTable.SelectedRow.Cells[10].Text;
            Response.Redirect("EditEmployee");
        }
    }
}