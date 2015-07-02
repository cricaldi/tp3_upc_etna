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
    public partial class PageRegistrarProveedor : System.Web.UI.Page
    {

          DistritoBL objDisBL = new  DistritoBL();
    ProveedorBL objProBL = new ProveedorBL();
    ProveedorBE objProBE = new ProveedorBE();


        protected void Page_Load(object sender, EventArgs e)
        {
            ddlDistrito.DataSource = objDisBL.getDistritos();
            ddlDistrito.DataTextField = "nom_dis";
            ddlDistrito.DataValueField = "cod_dis";
            ddlDistrito.DataBind();

             //enlazar datos a el gridview
             gvProveedores.DataSource = objProBL.getProveedores();
            gvProveedores.AllowPaging = true;
                gvProveedores.PageSize = 10;
                gvProveedores.DataBind();
             
        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
              objProBE.Codigo = txtCodigo.Text;
           objProBE .Razon = txtRazon.Text;
           objProBE .Direccion = txtDireccion.Text;
           objProBE .Telefono = txtTelefono.Text;
            objProBE.Distrito = ddlDistrito.SelectedValue;
            objProBE.Representante = txtRepresentante.Text;
        
        Response.Write("<font color=blue><b>" + objProBL.RegistrarProveedor(objProBE) + "</b></font>");


        gvProveedores.DataSource = objProBL.getProveedores();
           gvProveedores.DataBind();
      
        }

        protected void gvProveedores_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
             gvProveedores.PageIndex = e.NewPageIndex;
            gvProveedores.DataSource = objProBL.getProveedores();
            gvProveedores.DataBind();
        
        }
    }
}