<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Informe.aspx.cs" Inherits="UPC.IFCDC.UI.WebForm2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <script type = "text/javascript">
        $(document).ready(function () {
            cargarUltimaPestania1();
        });

        function Confirm()
        {
            var confirm_value = document.createElement("INPUT");
            confirm_value.type = "hidden";
            confirm_value.name = "confirm_value";

            if (confirm("La información ingresada ha sido almacenada. ¿Desea finalizar y enviar el Informe de Fin de Ciclo?")) {
                confirm_value.value = "YES";
            }
            else{
                confirm_value.value = "NO";
            }

            document.forms[0].appendChild(confirm_value);
        }
        function ConfirmDeleteHallazgo() {
            var confirm_value = document.createElement("INPUT");
            confirm_value.type = "hidden";
            confirm_value.name = "confirm_value";

            if (confirm("Al eliminar el hallazgo se eliminarán las acciones de mejora relacionadas al hallazgo. ¿Desea eliminar el hallazgo?")) {
                confirm_value.value = "YES";
            }
            else {
                confirm_value.value = "NO";
            }

            document.forms[0].appendChild(confirm_value);
        }
    </script>

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="Contenido" runat="server">
    <br />
<div class="box-central">
    <h1>INFORME DE FIN DE CICLO</h1>
    <p>Ciclo: <asp:Label ID="texto_PeriodoActual" runat ="server" Text="TextoCiclo"></asp:Label></p>
    <p>Fecha Límite: <asp:Label ID="texto_FechaLimite" Text="FechaLímite" runat ="server"></asp:Label></p>
    <p>Curso: <asp:Label ID="texto_DescripcionCurso" runat="server" Text="TextoCurso" ></asp:Label></p>
</div>
<ul class="tabs">
    <li onclick="change_view('#logros');" >Logros</li>
    <li onclick="change_view('#accionesPrevias');" >Acciones Previas</li>
    <li onclick="change_view('#hallazgos');" >Hallazgos</li>
    <li onclick="change_view('#accionesMejora');" >Acciones de Mejora</li>
    <li onclick="change_view('#comentario');" >Comentarios</li>
    <li onclick="change_view('#antecedentes');">Antecedentes</li>
 </ul>

<!--ZONA DE LOGROS-->
<div id="logros" class="box-central">
    <h4>El Curso contribuye a alcanzar los siguientes Student Outcomes</h4>
    <table class="TablaNested">
    <tbody>
        <tr>
        <td colspan="2" align="center" >
            <asp:GridView ID="grdOutcomes" runat="server" Width="100%"
             CellPadding="4" CellSpacing="1" Border="0" AutoGenerateColumns="false"> 
                <RowStyle CssClass="grdFilas"/>
                <HeaderStyle CssClass="grdCabecera"/>
                <AlternatingRowStyle CssClass="grdFilasAlternas"/>
             
                <Columns>                    
                    <asp:BoundField HeaderText="Student Outcome" DataField="Outcome" HeaderStyle-HorizontalAlign="Center" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="20%"/>
                    <asp:BoundField HeaderText="Descripción" DataField="Descricpion" HeaderStyle-HorizontalAlign="Center" ItemStyle-HorizontalAlign="Left" ItemStyle-Width="80%"/>                    
                </Columns>
             
            </asp:GridView>
        </td>
    </tr>
    </tbody>
    </table>
    <h4>El Curso tiene planteado el siguiente logro terminal</h4>
    <asp:Label CssClass="disabled" Width="99%" ID="texto_LogroTerminal" Text="Logro terminal del curso" runat="server"></asp:Label>
</div>

<!--ZONA DE ACCIONES PREVIAS-->
<div id="accionesPrevias" class="box-central">
    <table class="TablaNested">
    <tbody>
        <tr>
        <td colspan="2" align="center" >
            <asp:GridView ID="grdAccionesPrevias" runat="server" Width="100%" CellPadding="4" CellSpacing="1" Border="0" AutoGenerateColumns="false"
                OnRowDataBound="grdvAccionesPrevias_RowDataBound" OnRowEditing="gvAccionesPrevias_RowEditing"> 
                <RowStyle CssClass="grdFilas"/>
                <HeaderStyle CssClass="grdCabecera"/>
                <AlternatingRowStyle CssClass="grdFilasAlternas"/>  
             
                <Columns>                    
                    <asp:BoundField HeaderText="Código"  DataField="Codigo" HeaderStyle-HorizontalAlign="Center" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="20%"/>
                    <asp:BoundField HeaderText="Descripción" DataField="Descripcion" HeaderStyle-HorizontalAlign="Center" ItemStyle-HorizontalAlign="Left" ItemStyle-Width="60%"/>                
                    
                    <asp:TemplateField HeaderText="Estado" HeaderStyle-HorizontalAlign="Center" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="20%">
                        <ItemTemplate>
                            <asp:DropDownList ID="dpdListEstatus" runat="server" OnSelectedIndexChanged="dpdListEstatus_SelectedIndexChanged" AutoPostBack="true">
                                <asp:ListItem >NO REALIZADO</asp:ListItem>
                                <asp:ListItem>EN PROCESO</asp:ListItem>
                                <asp:ListItem>IMPLEMENTADO</asp:ListItem>
                            </asp:DropDownList>                    
                        </ItemTemplate>
                    </asp:TemplateField>
                
                </Columns>
                     
            </asp:GridView>
        </td>
        </tr>
    </tbody>
    </table>
</div>

<!--ZONA DE HALLAZGOS-->
<div id="hallazgos" class="box-central">
    <table class="TablaNested">
    <tbody>
        <tr>
        <td colspan="2" align="center" >
            <asp:GridView ID="grdHallazgos" runat="server" Width="100%" CellPadding="4" CellSpacing="1" Border="0" AutoGenerateColumns="false"
                OnRowCommand="grdHallazgos_RowCommand"> 
                <RowStyle CssClass="grdFilas"/>
                <HeaderStyle CssClass="grdCabecera"/>
                <AlternatingRowStyle CssClass="grdFilasAlternas"/>
             
                <Columns>                    
                    <asp:BoundField HeaderText="Código" DataField="Codigo" HeaderStyle-HorizontalAlign="Center" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="15%"/>
                    <asp:BoundField HeaderText="Descripción" DataField="Descripcion" HeaderStyle-HorizontalAlign="Center" ItemStyle-HorizontalAlign="Left" ItemStyle-Width="40%"/>
                
                    <asp:TemplateField HeaderText="Acción de Mejora" HeaderStyle-HorizontalAlign="Center" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="15%">
                        <ItemTemplate>
                            <asp:LinkButton ID="lnkAddAccionMejora" CommandName="cmdAgregarAccionMejora" CommandArgument='<%#Eval("HallazgoId")%>'>
                                <img src="Imagenes/add.png" width="16" height="16" alt="addaccionmejora" border="0"  onclick="llamarpopupNuevaAcciondeMejora('#pAccionesMejoraRegistrar','<%#Eval("Codigo")%>','<%#Eval("HallazgoId")%>');"/>
                            </asp:LinkButton>                       
                        </ItemTemplate>
                    </asp:TemplateField>
                    
                    <asp:TemplateField HeaderText="Editar" HeaderStyle-HorizontalAlign="Center" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="15%">
                        <ItemTemplate>
                            <asp:LinkButton ID="lnkEditarHallazgo" CommandName="cmdEditarHallazgo" CommandArgument='<%#Eval("HallazgoId")%>'>
                                <img src="Imagenes/edit.png" width="16" height="16" alt="edithallazgo" border="0" onclick="llamarpopupEditarHallazgo('#pHallazgoEditar','<%#Eval("Descripcion")%>','<%#Eval("HallazgoId")%>');"/>
                            </asp:LinkButton>                        
                        </ItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Eliminar" HeaderStyle-HorizontalAlign="Center" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="15%">
                        <ItemTemplate>
                            <asp:LinkButton ID="lnkEliminarHallazgo" runat="server" CommandName="cmdEliminarHallazgo" CommandArgument='<%#Eval("HallazgoId")%>'>
                                <img src="Imagenes/delete.png" width="16" height="16" alt="deletehallazgo" border="0"
                                    onclick="if(confirm('Si elimina el Hallazgos, tambíen se eliminarán las Acciones de Mejora correspondientes. ¿Está Ud. seguro que desea eliminar estes regitro?')){return true;} else{return false;}"/>
                            </asp:LinkButton>                        
                        </ItemTemplate>
                    </asp:TemplateField>

                </Columns>
                   
            </asp:GridView>
        </td>
        </tr>
    </tbody>
    </table>
    <button type="button" onclick="popup('#pHallazgoRegistrar');">Nuevo Hallazgo</button>
</div>

<!--ZONA DE ACCIONES DE MEJORA-->
<div id="accionesMejora" class="box-central">
    <table class="TablaNested">
    <tbody>
        <tr>
        <td colspan="2" align="center" >
            <asp:GridView ID="grdAccionesdeMejora" runat="server" Width="100%" CellPadding="4" CellSpacing="1" Border="0" AutoGenerateColumns="false"
                OnRowCommand="grdAccionesMejora_RowCommand"> 
                <RowStyle CssClass="grdFilas"/>
                <HeaderStyle CssClass="grdCabecera"/>
                <AlternatingRowStyle CssClass="grdFilasAlternas"/>
             
                <Columns>                    
                    <asp:BoundField HeaderText="Código" DataField="Codigo" HeaderStyle-HorizontalAlign="Center" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="15%"/>
                    <asp:BoundField HeaderText="Descripción" DataField="Descripcion" HeaderStyle-HorizontalAlign="Center" ItemStyle-HorizontalAlign="Left" ItemStyle-Width="40%"/>
                    <asp:BoundField HeaderText="Ciclo" DataField="CicloEjecucion" HeaderStyle-HorizontalAlign="Center" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="10%"/>
                    <asp:BoundField HeaderText="Hallazgo" DataField="CodigoHallazgo" HeaderStyle-HorizontalAlign="Center" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="15%"/>
                
                    <asp:TemplateField HeaderText="Editar" HeaderStyle-HorizontalAlign="Center" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="10%">
                        <ItemTemplate>
                            <asp:LinkButton ID="lnkEditarAccionMejora" CommandName="cmdEditarAccionMejora" CommandArgument='<%#Eval("AccionMejoraId")%>'>
                                <img src="Imagenes/edit.png" width="16" height="16" alt="editaccion" border="0" onclick="llammarpopupEditarAcciondeMejora('#pAccionesMejoraEditar','<%#Eval("Codigo")%>','<%#Eval("Descripcion")%>','<%#Eval("AccionMejoraId")%>');"/>
                            </asp:LinkButton>                        
                        </ItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Eliminar" HeaderStyle-HorizontalAlign="Center" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="10%">
                        <ItemTemplate>
                            <asp:LinkButton ID="lnkEliminarAccionMejora" runat="server" CommandName="cmdEliminarAccionMejora" CommandArgument='<%#Eval("AccionMejoraId")%>'>
                                <img src="Imagenes/delete.png" width="16" height="16" alt="deleteaccion" border="0"
                                    onclick="if(confirm('¿Está Ud. seguro que desea eliminar la Acción de Mejora?')){return true;} else{return false;}"/>
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

<!--ZONA DE COMENTARIOS-->
<div id="comentario" class="box-central">
    <div class="sandbox">
        <p>Desarrollo del Aprendizaje: </p>
        <div class="tooltip"  >?<div id="tp_apr" class="cont_tp">Se indica el nivel de avance logrado para las unidades de aprendizaje del curso</div></div>
        <asp:TextBox ID="txt_DesarrolloAprendizaje" CssClass="textComentarios" runat="server" TextMode="MultiLine"></asp:TextBox>
    </div>
    <div class="sandbox">
        <p>Infraestructura:</p>
        <div class="tooltip"  >?<div id="tp_infr" class="cont_tp">Se describen los requerimientos de infraestructura del curso</div></div>
        <asp:TextBox ID="txt_Infraestructura" CssClass="textComentarios" runat="server" TextMode="MultiLine"></asp:TextBox>
        </div>
    <div class="sandbox">
        <p>Alumnos:</p>
        <div class="tooltip"  >?<div id="tp_alum" class="cont_tp">Se registra la apreciación del docente sobre el nivel de satisfacción de los alumnos con el curso</div></div>
        <asp:TextBox ID="txt_Alumnos" CssClass="textComentarios" runat="server" TextMode="MultiLine"></asp:TextBox>
     </div>
    <div class="sandbox">
        <p>Apreciación del delegado del curso:</p>
        <div class="tooltip"  >?<div id="tp_del" class="cont_tp">Se registra la apreciación del docente sobre el desempeño del delegado del curso</div></div>
        <asp:TextBox ID="txt_Delegados" CssClass="textComentarios" runat="server" TextMode="MultiLine"></asp:TextBox>
    </div>
    <div class="sandbox">
        <p>Comentarios de la encuesta académica:</p>
        <div class="tooltip"  >?<div id="tp_enc" class="cont_tp">Se registra la apreciación del docente sobre el nivel de satisfacción de los alumnos con el curso tomando como base los resultados de la encuesta académica final del curso</div></div>
        <asp:TextBox ID="txt_EncuestaAcademica" CssClass="textComentarios" runat="server" TextMode="MultiLine"></asp:TextBox>
    </div>
    <br />
    <br />
</div>

<!--ZONA DE ANTECEDENTES-->
 <div id="antecedentes" class="box-central">
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
                    <asp:BoundField HeaderText="Codigo" DataField="CodigoCurso" HeaderStyle-HorizontalAlign="Center" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="20%"/>
                    <asp:BoundField HeaderText="Curso" DataField="NombreCurso" HeaderStyle-HorizontalAlign="Center" ItemStyle-HorizontalAlign="Left" ItemStyle-Width="30%"/> 
                    <asp:BoundField HeaderText="Profesor" DataField="NombreProfesor" HeaderStyle-HorizontalAlign="Center" ItemStyle-HorizontalAlign="Left" ItemStyle-Width="30%"/>
                    <asp:BoundField HeaderText="Ciclo" DataField="Periodo" HeaderStyle-HorizontalAlign="Center" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="20%"/>
                
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


<br />
<br />

<div style="text-align:center;">
    <asp:Button CssClass="btn-guardar" ID="btnGuardar" runat="server" onclick = "OnConfirm" OnClientClick="Confirm()"/> <!--OnClientClick="Confirm()"-->
    <asp:Button CssClass="btn-cancelar" ID="btnCancelar" runat="server" onClick = "OnCancel"/>
</div>

<!-- ZONA DE POPUPS -->
<div class="dark-side">
    <div class="pop-up" id="pAccionesMejoraRegistrar">
        <div class="pHeader">NUEVA ACCIÓN DE MEJORA
            <div class="pClose" onclick="close_popup('#pAccionesMejoraRegistrar');">&times;</div>
        </div>
        <input type="hidden" id="hiddenAC" />
        <asp:HiddenField ID="hiddenAC2" Value="1" runat="server"/>
        <div class="contentP">Codigo de Hallazgo: 
            <input type="text" id="codigoHallazgoAC" disabled /> 
            <br />
            Ciclo:
            <asp:DropDownList ID="combo_AccionMejoraRegistrar" runat="server">
            </asp:DropDownList>
            <br />
            Descripcion:
            <br />
            <asp:TextBox ID="popup_textoDescripcionAccionMejoraRegistrar" Width="400px" Height="200px" runat="server" TextMode="MultiLine"></asp:TextBox>
            <br />
            <asp:Button ID="popup_buttonRegistrarAccionMejora" runat="server" Text="Registrar" OnClick="popup_buttonRegistrarAccioMejora_Click"/>
            <button type="button" onclick="close_popup('#pAccionesMejoraRegistrar');">Cancelar</button>
        </div>
    </div>
    
    <div class="pop-up" id="pAccionesMejoraEditar">
        <div class="pHeader">EDITAR ACCIÓN DE MEJORA
            <div class="pClose" onclick="close_popup('#pAccionesMejoraEditar');">&times;</div>
        </div>
        <input type="hidden" id="hiddenEAC" />
        <asp:HiddenField ID="hiddenEAC2" Value="1" runat="server"/>
        <div class="contentP">Codigo de Hallazgo: 
            <asp:TextBox Enabled="false" ID="pCodigoHallazgoEditar" Text="SI2014-2012-02" runat="server" />
            <br />
            Ciclo:
            <asp:DropDownList ID="combo_AccionMejoraEditar" runat="server">
            </asp:DropDownList>
            <br />
            Descripcion:
            <br />
            <asp:TextBox ID="popup_textoDescripcionAccionMejoraEditar" Width="400px" Height="200px" runat="server" TextMode="MultiLine"></asp:TextBox>
            <br />
            <asp:Button ID="popup_buttonEditarAccionMejora" runat="server" Text="Editar" OnClick="popup_buttonEditarAccioMejora_Click"/>
            <button type="button" onclick="close_popup('#pAccionesMejoraEditar');">Cancelar</button>
        </div>
    </div>

    <div class="pop-up" id="pHallazgoRegistrar">
        <div class="pHeader">NUEVO HALLAZGO
            <div class="pClose" onclick="close_popup('#pHallazgoRegistrar');">&times;</div>
        </div>
        <div class="contentP">
            <asp:TextBox ID="popup_textoDescripcionHallazgoRegistrar" Width="400px" Height="100px" runat="server" CssClass="CajaTextoNormal" TextMode="MultiLine"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="popup_buttonRegistrarHallazgo" runat="server" Text="Registrar" OnClick="popup_buttonRegistrarHallazgo_Click"/>
            <button type="button" onclick="close_popup('#pHallazgoRegistrar');">Cancelar</button>
        </div>
    </div>

    <div class="pop-up" id="pHallazgoEditar">
        <div class="pHeader">EDITAR HALLAZGO
            <div class="pClose" onclick="close_popup('#pHallazgoEditar');">&times;</div>
        </div>
        <input type="hidden" id="hiddenAE" />
        <asp:HiddenField ID="hiddenAE2" Value="1" runat="server"/>

        <div class="contentP">
            <asp:TextBox ID="popup_textoDescripcionHallazgoEditar" Width="400px" Height="100px" runat="server" CssClass="CajaTextoNormal" TextMode="MultiLine"></asp:TextBox>
            <br />
            
            <br />
            <asp:Button ID="popup_buttonEditarHallazgo" runat="server" Text="Editar" OnClick="popup_buttonEditarHallazgo_Click"/>
            <button type="button" onclick="close_popup('#pHallazgoEditar');">Cancelar</button>
        </div>
    </div>

</div>
</asp:Content>
