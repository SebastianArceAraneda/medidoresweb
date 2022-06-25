<%@ Page Title="" Language="C#" MasterPageFile="~/PrincipalMaster.Master" AutoEventWireup="true" CodeBehind="VerConsumo.aspx.cs" Inherits="medidoresweb.VerConsumo" %>


<asp:Content ID="Content1" ContentPlaceHolderID="Contenido" runat="server">
    <div class="row">
        <div class="col-lg-6 mx-auto">
            <div class="card">
                <div class="card-header bg-danger text-white">
                    <h3>Ver Consumos</h3>
                </div>
                <div class="card-body">
                    <div class="form-group">
                        <label for ="tipo"> Filtrar por Id Medidor: </label>
                        <asp:DropDownList AutoPostBack="true" OnSelectedIndexChanged="nivelDdl_SelectedIndexChanged" runat="server" ID="tipoDdl">
                        </asp:DropDownList>
                        <asp:Button ID="recargar" runat="server" Text="Recargar" OnClick="recargar_Click"/>
                    </div>
                    
  
                    <asp:GridView CssClass="table table-hover table-bordered mt-5" 
                        OnRowCommand="grilla_RowCommand"
                        EmptyDataText="No hay nigún consumo registrado" ShowHeader="true"
                        AutoGenerateColumns="false" runat="server" ID="grilla">
                       <Columns>
                           <asp:BoundField DataField="numeroMedidor" HeaderText="Numero de medidor" />
                           <asp:BoundField DataField="tipo" HeaderText="Tipo" />
                           <asp:BoundField DataField="fecha" HeaderText="Fecha" />
                           <asp:BoundField DataField="consumo" HeaderText="Consumo" />
                           <asp:TemplateField>
                               <ItemTemplate>
                                   <asp:Button CommandName="eliminar" 
                                       CommandArgument='<%# Eval("numeroMedidor") %>'
                                       runat="server" 
                                       CssClass="btn btn-danger" Text="Eliminar" />
                               </ItemTemplate>
                           </asp:TemplateField>
                       </Columns>
                    </asp:GridView>
                
                

 </div>
</div>
    </div>
</asp:Content>