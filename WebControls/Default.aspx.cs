using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebControls
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SubmitButton_Click(object sender, EventArgs e)
        {
            /*
             * For CheckBox control, you assign the variable to boolean 
             * and use a tenery operator for your condition to get
             * the value the user selects.
             */

            bool ssd = SSD1.Checked;
            bool ram = SixteenGB.Checked;
            bool dual = DaulMonitor.Checked;

            Message.Text = "You selcted: ";
            Message.Text += ssd ? " SSD Drive, " : "";
            Message.Text += ram ? " 16GB RAM, " : "";
            Message.Text += dual ? " Dual Monitor, " : "";

            /*
             * For CheckBoxList use a foreach loop to iterate through 
             * the items listCollection
             * 
             */
            foreach (ListItem li in CheckBoxList1.Items)
            {
                if (li.Selected)
                {
                    Message.Text += li.Value.ToString();
                }
            }


            /*
             * 
             */
            Message.Text += "</br> The Customer is ";
            Message.Text += MaleRadioButton.Checked ? "Male" : "Female";

            /*
             * RadioButtonList:
             * Similar how to iterate through CheckBoxList 
             */
            Message.Text += "</br> Your age group is considered as ";
            foreach (ListItem li in RadioButtonList1.Items)
            {
                if (li.Selected)
                {
                    Message.Text += li.Value.ToString() + ". ";
                }
            }

            /*
             * 
             */
            Message.Text += "You selected Item ";
            Message.Text += DropDownList1.SelectedValue.ToString();
        }
    }
}