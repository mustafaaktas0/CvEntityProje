using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvEntityProje
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
            DBCVENTITYEntities db = new DBCVENTITYEntities();

        protected void Button1_Click(object sender, EventArgs e)
        {
            var sorgu = from x in db.TBL_ADMIN where x.KULLANICIADSOYAD == TextBox1.Text && x.SIFRE == TextBox2.Text select x;

            if (sorgu.Any())
            {
                Session.Add("kullanıcı", TextBox1.Text);
                Response.Redirect("Iletisim.Aspx");
            }
            else
            {
                Response.Write("Hatali bilgiler");
            }
        }
    }
}