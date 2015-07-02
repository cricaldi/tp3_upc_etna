<%@ Page Language="C#" MasterPageFile="~/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="ListadoSolicitudProduccion.aspx.cs" Inherits="PresentationLayer.ListadoSolicitudProduccion" %>


<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <form id="form1" runat="server" method="post" >
    <div align="rigth">
    
        <table class="style1">
            <tr>
                <td class="barramenu " align="center" >
                     <b id="lblTitulo" runat="server" class="textoSubtitulo"/>

                 </td>
            </tr>
            <tr>
                <td>

                </td>
            </tr>
            <tr>
                <td>
                    <asp:GridView ID="gvSolicitudesProduccion" runat="server" AutoGenerateColumns="False" 
                        CellPadding="3"  GridLines="Vertical" Width="100%" class="tabla"
                         OnPageIndexChanging="gvProveedores_PageIndexChanging"
                         BorderStyle="Solid" BorderWidth="1px"  OnRowCommand="gvSolicitudesProduccion_RowCommand">
                        <Columns>

                            <asp:CommandField ShowSelectButton="True" HeaderText="ver" >
                            <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                            <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                            </asp:CommandField>

                            <asp:BoundField DataField="COD_SOL" HeaderText="Id_Solicit" ReadOnly="True" >
                            <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                            </asp:BoundField>                            
                            
                            <asp:BoundField DataField="FEC_SOL" HeaderText="Fecha_Solicit">
                            <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                            </asp:BoundField>  

                            <asp:BoundField DataField="DESCRIPCION" HeaderText="Descripcion"  NullDisplayText="No tiene">
                             <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                            </asp:BoundField>  

                            <asp:BoundField DataField="COD_PLAN" HeaderText="Cod_Plan">
                             <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                            </asp:BoundField>  

                            <asp:BoundField DataField="CANT_PERSONAL" HeaderText="Cant_Personal">
                             <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                            </asp:BoundField>  

                            <asp:BoundField DataField="CANT_INSUMOS" HeaderText="Cant_Insumos">
                             <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                            </asp:BoundField>  

                            <asp:BoundField DataField="CANT_MAQUINARIA" HeaderText="Cant_Maquinaria">
                             <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                            </asp:BoundField>  

                        </Columns>
                        <FooterStyle BackColor="#CCCCCC" />
                        <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                        <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                        <HeaderStyle  CssClass="barramenu" />
                        <RowStyle CssClass="textoContenido"/>
                        <AlternatingRowStyle BackColor="#CCCCCC" />
                        <SortedAscendingCellStyle BackColor="#F1F1F1" />
                        <SortedAscendingHeaderStyle BackColor="#808080" />
                        <SortedDescendingCellStyle BackColor="#CAC9C9" />
                        <SortedDescendingHeaderStyle BackColor="#383838" />
                    </asp:GridView>
                </td>
            </tr>
        </table>
    
    </div>
   
    </form>
    </asp:Content>


