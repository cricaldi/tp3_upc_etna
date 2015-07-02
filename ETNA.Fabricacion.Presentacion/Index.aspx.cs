using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessEntitiesLayer;
using BusinessLayer;

namespace PresentationLayer
{
    public partial class Index : System.Web.UI.Page
    {
        VendedorBL objVenBL = new VendedorBL();

        protected void Page_Load(object sender, EventArgs e)
        {

            this.gvVendedores.DataSource = objVenBL.getVendedores();
            this.gvVendedores.AllowPaging = true;
            this.gvVendedores.PageSize = 3;
            this.gvVendedores.DataBind();


        }

        protected void gvVendedores_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            this.gvVendedores.PageIndex = e.NewPageIndex;
            this.gvVendedores.DataSource = objVenBL.getVendedores();
            this.gvVendedores.DataBind();
        }

        protected void gvVendedores_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       // protected void btnIr_Click(object sender, EventArgs e)
      //  {
       //     Response.Redirect("PageData.aspx");
       // }
    }
}