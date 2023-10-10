using System;
using System.Collections.Generic;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;

namespace FormApps
{
    public partial class VehicleStartUp : System.Web.UI.Page
    {
        string content = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (!IsPostBack)
            //{
            //  lblMsg.Visible = false;
            //}

        }

        protected void BtnContinue_Click(object sender, EventArgs e)
        {
            DataTable dt;
            string idNum="";
     
            if(!ValidateData())
            {
                //Response.Write("<script language='javascript'>alert('Please fill required fields with valid value!.'); window.close();</script>");
               //lblMsg.Text = "Please fill required fields with valid value!";
                lblMsg.Visible = true;
                // ClientScript.RegisterStartupScript(GetType(), "script", "showMyDialog('" + lblMsg.Text + "','error" + "');", true);
                //this.RegisterClientScriptBlock(typeof(string), "key", string.Format("alert('{0}');", "Please fill required fields with valid value!"), true);
                // this.Page.ClientScript.RegisterStartupScript(this.GetType(), "ex", "alert('" + "Please fill required fields with valid value!" + "');", true);

            }
            else
            {
                //lblMsg.Text = " ";
                //lblMsg.Visible = false;

               

                dt = SQL.Run("SELECT IDENT_CURRENT('[VehicleInspection]')+1 as ID");

                if (dt.Rows.Count > 0)
                {
                    idNum = dt.Rows[0]["ID"].ToString();

                    // VehicleInspection
                    SQL sql = new SQL("insert into VehicleInspection (vehicle,date,odometer,operator) values (@VEHICLE,@DATE,@ODOMETER,@OPERATOR)");
                    sql.AddParameter("@VEHICLE", Request.Form["vehicle"]);
                    sql.AddParameter("@DATE", DateTime.Now);
                    sql.AddParameter("@ODOMETER", decimal.Parse(Request.Form["odometer"]));
                    sql.AddParameter("@OPERATOR", Request.Form["operator"]);
                    sql.Run();

                    // VehicleInspection_detail

                    sql = new SQL("insert into VehicleInspection_detail (id,ok,element) values (@ID,@OK,@ELEMENT)");
                    sql.AddParameter("@ID", idNum);
                    sql.AddParameter("@OK", radiobutton1.Checked? 1:0);
                    sql.AddParameter("@ELEMENT", description1.InnerText);
                    sql.Run();

                    sql = new SQL("insert into VehicleInspection_detail (id,ok,element) values (@ID,@OK,@ELEMENT)");
                    sql.AddParameter("@ID", idNum);
                    sql.AddParameter("@OK", radiobutton3.Checked ? 1 : 0);
                    sql.AddParameter("@ELEMENT", description2.InnerText);

                    sql.Run();

                }

                log("Vehicle Circle Check Success " ,idNum.ToString());

                Response.Redirect(Request.Url.AbsoluteUri);
                content += "Your details have been saved" + "');window.location='" + Request.Url.AbsoluteUri + "';}";
                ClientScript.RegisterStartupScript(this.GetType(), "SuccessMessage", content, true);



            }
        }

        private Boolean  ValidateData()
        {
            Boolean result = false;

                 

            if (Request.Form["vehicle"] != "" && Request.Form["odometer"] != "" && Request.Form["operator"] != "")
            {
              
                    result = true;
            }
            else
            {
                lblMsg.Text = "Please fill required fields with valid value!";
                result = false;
            }

            return result;

        }

   

        public void log(string bn, string bl)
        {
            string ipaddress = Request.ServerVariables["HTTP_X_FORWARDED_FOR"];

            if (ipaddress == "" || ipaddress == null)
                ipaddress = Request.ServerVariables["REMOTE_ADDR"];

            SQL.Run("insert into log values ( @TIMESTAMP,@IP, @BN,@LN)", DateTime.Now, ipaddress, bn, bl);
        }

       
    }


}