using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Threading;

public partial class FeaturedProducts : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        System.DateTime start = System.DateTime.Now;
        //Thread.Sleep(3000);

        if (!Page.IsPostBack)
        {
            DataView dw = new DataView(((DataLayer)Application["DataLayer"]).GetFeaturedProducts());
            dlFeatured.DataSource = dw;
            dlFeatured.DataBind();

        }

        System.DateTime end = System.DateTime.Now;
        lblStartTime.Text = start.ToLongTimeString();
        lblExecutionTime.Text = end.Subtract(start).Seconds + "." + end.Subtract(start).Milliseconds;
    }
}
