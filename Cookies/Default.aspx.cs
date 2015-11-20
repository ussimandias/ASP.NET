using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cookies
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //create an instance of HttpCookie
            var cookie = new HttpCookie("myCookie", CookieText.Text);

            //Add cookie to user broswer
            Response.Cookies.Add(cookie);
        }
    }
}