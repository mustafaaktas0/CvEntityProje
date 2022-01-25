using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvEntityProje
{
    public partial class Istatistik : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DBCVENTITYEntities db = new DBCVENTITYEntities();
            Label1.Text = db.YETENEKLERIM.Count().ToString();
            Label2.Text = db.TBL_ILETISIM.Count().ToString();
            Label3.Text = db.YETENEKLERIM.Average(x => x.DERECE).ToString();
            Label4.Text = db.YETENEKLERIM.Max(x => x.DERECE).ToString();
            
        }
    }
}