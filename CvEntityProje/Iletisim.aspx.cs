using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvEntityProje
{
    public partial class Iletisim : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["kullanıcı"] != null) {
            
              DBCVENTITYEntities db = new DBCVENTITYEntities();
            var mesajlar = db.TBL_ILETISIM.ToList();
            Repeater1.DataSource = mesajlar;
            Repeater1.DataBind();
            
            
        }
            else
            {
                Response.Write("Giriş yapılmadı");
                
            }
        }
    }
}