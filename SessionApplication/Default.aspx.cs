using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SessionApplication
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SaveButton_Click(object sender, EventArgs e)
        {
            Session["Name"] = YourName.Text;
            Application["Email"] = YourEmail.Text;

            NameAndEmail.Text = YourName.Text + " " + YourEmail.Text;
        }

        protected void RetrieveButton_Click(object sender, EventArgs e)
        {
            string name = "";
            string email = "";

            if (Session["Name"] != null)
            {
                name = Session["Name"].ToString();
            }

            if (Application["Email"] != null)
            {
                email = Application["Email"].ToString();
            }

            RetrievedNameAndEmail.Text = "Retieved: " + name + " " + email;
        }
    }
}