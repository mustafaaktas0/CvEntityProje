using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvEntityProje
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        DBCVENTITYEntities db = new DBCVENTITYEntities();
        protected void Button1_Click(object sender, EventArgs e)
        {
            YETENEKLERIM tbl = new YETENEKLERIM();
            tbl.YETENEK = TextBox1.Text;
            db.YETENEKLERIM.Add(tbl);
            db.SaveChanges();
            Response.Redirect("Yeteneklerim.aspx");
        }
    }
}