<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PageActualizarProveedor.aspx.cs" Inherits="PresentationLayer.PageActualizarProveedor" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
        .style2
        {
            font-size: x-large;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="style1">
            <tr>
                <td style="font-family: Algerian; font-size: xx-large">
                    <span lang="es-pe">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <span class="style2">ACTUALIZAR DATOS PROVEEDOR</span></span></td>
            </tr>
            <tr>
                <td>
                    <asp:GridView ID="gvProveedores" runat="server" AutoGenerateColumns="False" 
                        CellPadding="4" ForeColor="#333333" GridLines="None" Width="100%" OnPageIndexChanging="gvProveedores_PageIndexChanging" OnRowCancelingEdit="gvProveedores_RowCancelingEdit" OnRowDeleting="gvProveedores_RowDeleting" OnRowEditing="gvProveedores_RowEditing" OnRowUpdating="gvProveedores_RowUpdating">
                        <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
                        <Columns>
                            <asp:BoundField DataField="COD_PRV" HeaderText="CODIGO" ReadOnly="True" />
                            <asp:BoundField DataField="RAZ_SOC_PRV" HeaderText="RAZON SOCIAL" />
                            <asp:BoundField DataField="DIR_PRV" HeaderText="DIRECCION" />
                            <asp:BoundField DataField="TEL_PRV" HeaderText="TELEFONO" 
                                NullDisplayText="No tiene" />
                            <asp:BoundField DataField="COD_DIS" HeaderText="DISTRITO" />
                            <asp:BoundField DataField="REP_VEN" HeaderText="REPRESENTANTE" />
                            <asp:CommandField ShowEditButton="True" />
                            <asp:CommandField ShowDeleteButton="True" />
                        </Columns>
                        <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
                        <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
                        <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                        <AlternatingRowStyle BackColor="White" />
                    </asp:GridView>
                </td>
            </tr>
        </table>
    
    </div>
    <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnCerrar" runat="server" style="text-align: center" 
            Text="CERRAR" />
    </p>
    </form>
</body>
</html>

