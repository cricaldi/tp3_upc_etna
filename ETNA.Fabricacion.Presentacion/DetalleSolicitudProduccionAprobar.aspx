<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="DetalleSolicitudProduccionAprobar.aspx.cs" Inherits="PresentationLayer.DetalleSolicitudProduccionAprobar" %>


<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>

        <div style="width:100%" align="rigth">

    <div style="width:80%;" align="center" >
        
         <table style="width:62%">
             <tr>
                 <td  colspan="4" class="textoTitulo">                     
                           <div align="center"> SOLICITUD PRODUCCION</div>                                         
                 </td>
             </tr>
             <tr>
                 <td colspan="4" >

                 </td>
             </tr>
             <tr >
                  <td align="center"  colspan="4" class="barramenu " > 
                      <b class="textoSubtitulo">Cabecera</b>
                  </td>                                                                           
             </tr>
             <tr>
                 <td colspan="4" >

                 </td>
             </tr>
             <tr>
                 <td class="textoLabel" > Id Solicitud: </td>
                 <td class="textoContenido">
                     <asp:Label ID="lblIdSolicitud"  runat="server" />
                 </td>
                 <td class="textoLabel"> Nombre Solicitud:</td>
                 <td class="textoContenido">
                     <asp:Label ID="lblNombreSolicitud"  runat="server" />
                 </td>
             </tr>
               <tr>
                 <td class="textoLabel"> Fecha Solicitud: </td>
                    <td class="textoContenido">
                     <asp:Label ID="lblFechaSolicitud"  runat="server" />
                 </td>
                 <td class="textoLabel"> Descripcion de la Solicitud:</td>
                   <td class="textoContenido">
                     <asp:Label ID="lblDescripcionSolicitud"  runat="server" />
                 </td>
             </tr>
         </table>

        <br />

        <table>

              <tr >
                  <td align="center"  colspan="4" class="barramenu " > 
                      <b class="textoSubtitulo">Datos Maquinaria</b>
                  </td>                                                                           
             </tr>

            <tr>
                 <td colspan="4" >

                 </td>
             </tr>

            <tr>
                <td>
                    <asp:GridView ID="gvMaquinaria" runat="server" AutoGenerateColumns="False" 
                        CellPadding="3" ForeColor="Black" GridLines="Vertical" Width="100%" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" OnRowDataBound="gvMaquinaria_RowDataBound" >
                        <Columns>

                            <asp:BoundField DataField="COD_MAQUINA" HeaderText="Cod_maquinaria" ReadOnly="True" >
                            <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                            </asp:BoundField>                            
                            
                            <asp:BoundField DataField="DESCRIPCION" HeaderText="Descripcion">
                            <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                            </asp:BoundField>  

                            <asp:BoundField DataField="STOCK_DISP_MAQUINA" HeaderText="Stock_Dis_Maquinaria"  NullDisplayText="No tiene">
                             <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                            </asp:BoundField>  

                            <asp:BoundField DataField="STOCK_RES_MAQUINA" HeaderText="Stock_Res_Maquinaria">
                             <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                            </asp:BoundField>  

                            <asp:BoundField DataField="OBSERVACION" HeaderText="Observaciones">
                             <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                            </asp:BoundField>    
                            
                            <asp:TemplateField HeaderText="Resultado">
                                    <ItemTemplate>                                      
                                         <asp:Image id="imgCheck"  runat="server" border="0" align="middle" height="15px" Visible="False" ImageUrl="Images/check.jpg" ></asp:Image>  
                                         <asp:Image id="imgX"  runat="server" border="0" align="middle" height="15px" Visible="False" ImageUrl="Images/x.png" ></asp:Image>  
                                    </ItemTemplate>
                                    <HeaderStyle Width="100px" CssClass="barramenu" />
                                    <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                </asp:TemplateField>

                            <asp:BoundField DataField="RESULTADO" Visible="true" ItemStyle-CssClass="hideGridColumn" HeaderStyle-CssClass="hideGridColumn" >

                                <HeaderStyle CssClass="hideGridColumn"></HeaderStyle>

                                <ItemStyle CssClass="hideGridColumn"></ItemStyle>
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

        <br />

        <table>

             <tr >
                  <td align="center"  colspan="4" class="auto-style5" > 
                      <b class="textoSubtitulo">Datos Insumo</b>
                  </td>                                                                           
             </tr>

             <tr>
                 <td colspan="4" class="auto-style5" >

                 </td>
             </tr>

            <tr>
                <td class="auto-style5">
                    <asp:GridView ID="gvInsumo" runat="server" AutoGenerateColumns="False" 
                        CellPadding="3" ForeColor="Black" GridLines="Vertical" Width="100%" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" OnRowDataBound="gvInsumo_RowDataBound" >
                        <Columns>

                            <asp:BoundField DataField="COD_INSUMO" HeaderText="Cod_Insumo" ReadOnly="True" >
                            <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                            </asp:BoundField>                            
                            
                            <asp:BoundField DataField="DESCRIPCION" HeaderText="Descripcion">
                            <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                            </asp:BoundField>  

                            <asp:BoundField DataField="STOCK_DISP_INSUMO" HeaderText="Stock_Dis_Insumo"  NullDisplayText="No tiene">
                             <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                            </asp:BoundField>  

                            <asp:BoundField DataField="STOCK_RES_INSUMO" HeaderText="Stock_Res_Insumo">
                             <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                            </asp:BoundField>  

                            <asp:BoundField DataField="OBSERVACION" HeaderText="Observaciones">
                             <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                            </asp:BoundField>  

                              <asp:TemplateField HeaderText="Resultado">
                                    <ItemTemplate>                                      
                                         <asp:Image id="imgCheck"  runat="server" border="0" align="middle" height="15px" Visible="False" ImageUrl="Images/check.jpg" ></asp:Image>  
                                         <asp:Image id="imgX"  runat="server" border="0" align="middle" height="15px" Visible="False" ImageUrl="Images/x.png" ></asp:Image>  
                                    </ItemTemplate>
                                    <HeaderStyle Width="100px" CssClass="barramenu" />
                                    <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                </asp:TemplateField>

                            <asp:BoundField DataField="RESULTADO" Visible="true" ItemStyle-CssClass="hideGridColumn" HeaderStyle-CssClass="hideGridColumn" >

                          

                                <HeaderStyle CssClass="hideGridColumn"></HeaderStyle>

                                <ItemStyle CssClass="hideGridColumn"></ItemStyle>
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

        <br />

        <table>

             <tr >
                  <td align="center"  colspan="4" class="auto-style4" > 
                      <b class="textoSubtitulo">Datos Personal</b>
                  </td>                                                                           
             </tr>

             <tr>
                 <td colspan="4" class="auto-style4" >

                 </td>
             </tr>

            <tr>
                <td class="auto-style4">
                    <asp:GridView ID="gvPersonal" runat="server" AutoGenerateColumns="False" 
                        CellPadding="3" ForeColor="Black" GridLines="Vertical" Width="100%" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" OnRowDataBound="gvPersonal_RowDataBound" >
                        <Columns>

                            

                            <asp:BoundField DataField="COD_PERSONAL" HeaderText="Cod_Personal" ReadOnly="True" >
                            <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                            </asp:BoundField>                            
                            
                            <asp:BoundField DataField="DESCRIPCION" HeaderText="Descripcion">
                            <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                            </asp:BoundField>  

                            <asp:BoundField DataField="STOCK_DISP_PERSONAL" HeaderText="Stock_Dis_Personal"  NullDisplayText="No tiene">
                             <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                            </asp:BoundField>  

                            <asp:BoundField DataField="STOCK_RES_PERSONAL" HeaderText="Stock_Res_Personal">
                             <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                            </asp:BoundField>  

                            <asp:BoundField DataField="OBSERVACION" HeaderText="Observaciones">
                             <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                            </asp:BoundField>  

                            <asp:TemplateField HeaderText="Resultado">
                                    <ItemTemplate>                                      
                                         <asp:Image id="imgCheck"  runat="server" border="0" align="middle" height="15px" Visible="False" ImageUrl="Images/check.jpg" ></asp:Image>  
                                         <asp:Image id="imgX"  runat="server" border="0" align="middle" height="15px" Visible="False" ImageUrl="Images/x.png" ></asp:Image>  
                                    </ItemTemplate>
                                    <HeaderStyle Width="100px" CssClass="barramenu" />
                                    <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                </asp:TemplateField>

                            <asp:BoundField DataField="RESULTADO" Visible="true" ItemStyle-CssClass="hideGridColumn" HeaderStyle-CssClass="hideGridColumn" >

                                <HeaderStyle CssClass="hideGridColumn"></HeaderStyle>

                                <ItemStyle CssClass="hideGridColumn"></ItemStyle>
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

        <br />

        <table>
            <tr>                
                <td colspan="2">
                    <asp:Button ID="btnAprobar" runat="server" Text="Aprobar" OnClientClick="return confirmar(this);" 
                        OnClick="btnAprobar_Click"  CssClass="btn" />
                </td>
            </tr>
                      
        </table>

    </div>
            </div>

        <div id="dialog-confirm" class="dialog" title="Confirmar...">
                <p>
                    <span class="ui-icon ui-icon-alert" style="float: left; margin: 0 7px 10px 0"></span>
                    ¿Esta Seguro de Aprobar la Solicitud?
                </p>
            </div>

        <div id="dialog-alert" class="dialog" title="Alerta">
                <p>                 
                    <span class="ui-icon ui-icon-alert" style="float: left; margin: 0 7px 10px 0"></span>   
                    <b id="lblMensaje" runat="server" class="textoSubtitulo"/>
                </p>
        </div>

       </form>

</asp:Content>
