using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvEntityProje
{
    public partial class Default : System.Web.UI.Page
    {

        DBCVENTITYEntities db = new DBCVENTITYEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            Repeater1.DataSource = db.TBL_HAKKINDA.ToList();
            Repeater1.DataBind();

            Repeater2.DataSource = db.TBL_HAKKINDA.ToList();
            Repeater2.DataBind();

            Repeater3.DataSource = db.TBL_HAKKINDA.ToList();
            Repeater3.DataBind();

            Repeater4.DataSource = db.YETENEKLERIM.ToList();
            Repeater4.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            TBL_ILETISIM t = new TBL_ILETISIM();
            t.ADSOYAD = TextBox1.Text;
            t.MAIL = TextBox2.Text;
            t.KONU = TextBox3.Text;
            t.MESAJ = TextBox4.Text;

            db.TBL_ILETISIM.Add(t);
            db.SaveChanges();
        }
    }
}