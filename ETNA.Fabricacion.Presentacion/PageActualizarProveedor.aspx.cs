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
    public partial class PageActualizarProveedor : System.Web.UI.Page
    {

        
        ProveedorBL objProBL = new ProveedorBL();
        ProveedorBE objProBE = new ProveedorBE();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack) 
            { 
                gvProveedores.DataSource = objProBL.getProveedores();
                gvProveedores.AllowPaging = true;
                gvProveedores.PageSize = 10;
                gvProveedores.DataBind();
           
            }
        }

        protected void gvProveedores_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
           gvProveedores.PageIndex = e.NewPageIndex;
           gvProveedores .DataSource = objProBL.getProveedores();
           gvProveedores.DataBind();
       
        }

        protected void gvProveedores_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
             gvProveedores.EditIndex = -1 ;
            gvProveedores.DataSource = objProBL.getProveedores();
           gvProveedores .DataBind();
        
        }

        protected void gvProveedores_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
           
            var i  = e.RowIndex;
             
             var cod  = gvProveedores.Rows[i].Cells[0].Text;
    
                Response.Write(objProBL.EliminarProveedor(cod));
        
             gvProveedores.EditIndex = -1;
              gvProveedores .DataSource = objProBL.getProveedores();
             gvProveedores .DataBind();
        
        }

        protected void gvProveedores_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
              
        var i  = e.RowIndex;
        
        var cod  = this.gvProveedores.Rows[i].Cells[0].Text;
       
        var raz  =   ( (TextBox)(this.gvProveedores.Rows[i].Cells[1].Controls[0])).Text;
        var dir  =   ( (TextBox)(this.gvProveedores.Rows[i].Cells[2].Controls[0])).Text;
        var tel  =   ( (TextBox)(this.gvProveedores.Rows[i].Cells[3].Controls[0])).Text;
        var dis  =   ( (TextBox)(this.gvProveedores.Rows[i].Cells[4].Controls[0])).Text;
        var rep  =   ( (TextBox)(this.gvProveedores.Rows[i].Cells[5].Controls[0])).Text;


               
        objProBE .Codigo = cod;
        objProBE   .Razon = raz;
        objProBE    .Direccion = dir;
        objProBE   .Telefono = tel;
        objProBE   .Distrito = dis;
        objProBE  .Representante = rep;
       

        Response.Write(objProBL.ActualizarProveedor(objProBE));


        
         gvProveedores.EditIndex = -1;
          gvProveedores  .DataSource = objProBL.getProveedores();
          gvProveedores.DataBind();
       
        
        }

        protected void gvProveedores_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gvProveedores.EditIndex = e.NewEditIndex;
            gvProveedores.DataSource = objProBL.getProveedores();
            gvProveedores.DataBind();
        }
    }
}