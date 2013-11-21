<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Administrativo.aspx.cs" Inherits="UPC.IFCDC.UI.WebForm4" %>
<asp:Content ID="Content2" ContentPlaceHolderID="Contenido" runat="server">
<script type="text/javascript">
    $(document).ready(function () {
        cargarUltimaPestania2();
    });
</script>

<ul class="tabs">
    <li onclick="change_view2('#informesFinCiclo');" >Informes de Fin de Ciclo</li><li onclick="change_view2('#hallazgos_ad');" >Hallazgos</li><li onclick="change_view2('#accionesMejora_ad');" >Acciones de Mejora</li>
 </ul>

 <div id="informesFinCiclo" class="box-central">
    <p> Curso:
        <asp:DropDownList ID="combo_InformeFinCicloCurso" runat ="server"></asp:DropDownList>
    </p>
    <p> Ciclo: 
        <asp:DropDownList ID="combo_InformeFinCicloCiclo"  runat ="server"></asp:DropDownList>
    </p>
    <p> Estado: 
        <asp:DropDownList ID="combo_InformeFinCicloEstado" runat="server" >
            <asp:ListItem>TODOS</asp:ListItem>
            <asp:ListItem>NO REALIZADO</asp:ListItem>
            <asp:ListItem>EN PROCESO</asp:ListItem>
            <asp:ListItem>FINALIZADO</asp:ListItem>
        </asp:DropDownList>
    </p>
   
   <asp:Button CssClass="btn-buscar" ID="btnBuscaInformesFinCiclo" runat="server" onclick="btnBuscaInformesFinCiclo_Click"/>
  
    <table class="TablaNested">
    <tbody>
        <tr>
        <td colspan="2" align="center" >
            <asp:GridView ID="grdInformes" OnRowCommand="grdInformes_RowCommand" runat="server" Width="100%"
             CellPadding="4" CellSpacing="1" Border="0" AutoGenerateColumns="false"> 
                <RowStyle CssClass="grdFilas"/>
                <HeaderStyle CssClass="grdCabecera"/>
                <AlternatingRowStyle CssClass="grdFilasAlternas"/>
             
                <Columns>                    
                    <asp:BoundField HeaderText="Codigo" DataField="CodigoCurso" HeaderStyle-HorizontalAlign="Center" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="5%"/>
                    <asp:BoundField HeaderText="Curso" DataField="NombreCurso" HeaderStyle-HorizontalAlign="Center" ItemStyle-HorizontalAlign="Left" ItemStyle-Width="25%"/> 
                    <asp:BoundField HeaderText="Profesor" DataField="NombreProfesor" HeaderStyle-HorizontalAlign="Center" ItemStyle-HorizontalAlign="Left" ItemStyle-Width="25%"/>
                    <asp:BoundField HeaderText="Ciclo" DataField="Periodo" HeaderStyle-HorizontalAlign="Center" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="10%"/>
                    <asp:BoundField HeaderText="Ultima Actualizacion" DataField="FechaActualizacion" HeaderStyle-HorizontalAlign="Center" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="10%"/>
                    <asp:BoundField HeaderText="Estado" DataField="Estado" HeaderStyle-HorizontalAlign="Center" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="15%"/>
                
                    <asp:TemplateField HeaderText="Exportar" HeaderStyle-HorizontalAlign="Center" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="10%">
                        <ItemTemplate>
                            <asp:LinkButton ID="lnkInforme" runat="server" CommandName="cmdIniciar" CommandArgument='<%#Eval("InformeFinCicloId")%>'>
                                <img src="Imagenes/icono/icono-editar.png" width="16" height="16" alt="iniciar" border="0"/>
                            </asp:LinkButton>                        
                        </ItemTemplate>
                    </asp:TemplateField>
                
                </Columns>
             
            </asp:GridView>
        </td>
    </tr>
    </tbody>
    </table>
 </div>
 
 <div id="hallazgos_ad" class="box-central">
    <p>Curso: 
        <asp:DropDownList ID="combo_HallazgoCurso" runat ="server" ></asp:DropDownList>
    </p>
    <p>Ciclo:
        <asp:DropDownList ID="combo_HallazgoCiclo" runat="server" ></asp:DropDownList>
    </p>
    
    <asp:Button CssClass="btn-buscar" ID="btnBuscaHallazgos" runat="server" OnClick="btnBuscaHallazgos_Click"/>
    
    <table class="TablaNested">
    <tbody>
        <tr>
        <td colspan="2" align="center" >
            <asp:GridView ID="grdHallazgos" runat="server" Width="100%"
             CellPadding="4" CellSpacing="1" Border="0" AutoGenerateColumns="false"> 
                <RowStyle CssClass="grdFilas"/>
                <HeaderStyle CssClass="grdCabecera"/>
                <AlternatingRowStyle CssClass="grdFilasAlternas"/>
             
                <Columns>                    
                    <asp:BoundField HeaderText="Codigo" DataField="CodigoHallazgo" HeaderStyle-HorizontalAlign="Center" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="15%"/>
                    <asp:BoundField HeaderText="Descripcion" DataField="Descripcion" HeaderStyle-HorizontalAlign="Center" ItemStyle-HorizontalAlign="Left" ItemStyle-Width="60%"/> 
                    <asp:BoundField HeaderText="Curso" DataField="NombreCurso" HeaderStyle-HorizontalAlign="Center" ItemStyle-HorizontalAlign="Left" ItemStyle-Width="35%"/>
                </Columns>
             
            </asp:GridView>
        </td>
    </tr>
    </tbody>
    </table>
    <asp:Button runat="server" ID="btnExportaHallazgo" Text="Exportar a PDF" OnClick="btnExportaHallazgo_Click"/>
 </div>
 
 <div id="accionesMejora_ad" class="box-central">
    
    <p>Curso:
        <asp:DropDownList ID="combo_AccionMejoraCurso" runat ="server" ></asp:DropDownList>
    </p>
    <p>Ciclo:
        <asp:DropDownList ID="combo_AccionMejoraCiclo" runat="server" ></asp:DropDownList>
    </p>
    <p>Estado:
        <asp:DropDownList ID="combo_AccionMejoraEstado" runat="server" >
            <asp:ListItem>TODOS</asp:ListItem>
            <asp:ListItem>NO REALIZADO</asp:ListItem>
            <asp:ListItem>EN PROCESO</asp:ListItem>
            <asp:ListItem>IMPLEMENTADO</asp:ListItem>
        </asp:DropDownList>
    </p>
   
    <asp:Button CssClass="btn-buscar" ID="btnBuscaAcciones" runat="server" OnClick="btnBuscaAcciones_Click"/>

    <table class="TablaNested">
    <tbody>
        <tr>
        <td colspan="2" align="center" >
            <asp:GridView ID="grdAccionesMejora" runat="server" Width="100%" CellPadding="4" CellSpacing="1" Border="0" AutoGenerateColumns="false"> 
                <RowStyle CssClass="grdFilas"/>
                <HeaderStyle CssClass="grdCabecera"/>
                <AlternatingRowStyle CssClass="grdFilasAlternas"/>
             
                <Columns>                    
                    <asp:BoundField HeaderText="Codigo" DataField="CodigoAccionMejora" HeaderStyle-HorizontalAlign="Center" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="15%"/>
                    <asp:BoundField HeaderText="Hallazgo" DataField="CodigoHallazgo" HeaderStyle-HorizontalAlign="Center" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="15%"/> 
                    <asp:BoundField HeaderText="Descripcion" DataField="Descripcion" HeaderStyle-HorizontalAlign="Center" ItemStyle-HorizontalAlign="Left" ItemStyle-Width="35%"/>
                    <asp:BoundField HeaderText="Curso" DataField="NombreCurso" HeaderStyle-HorizontalAlign="Center" ItemStyle-HorizontalAlign="Left" ItemStyle-Width="20%"/>
                    <asp:BoundField HeaderText="Estado" DataField="Estado" HeaderStyle-HorizontalAlign="Center" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="15%"/>
                </Columns>
             
            </asp:GridView>
        </td>
        </tr>
    </tbody>
    </table>
    <asp:Button runat="server" ID="btnExportaAcciones" Text="Exportar a PDF" OnClick="btnExportaAcciones_Click"/>
 </div>
 
</asp:Content>
