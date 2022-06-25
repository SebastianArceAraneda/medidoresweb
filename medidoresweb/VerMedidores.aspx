<%@ Page Title="" Language="C#" MasterPageFile="~/PrincipalMaster.Master" AutoEventWireup="true" CodeBehind="VerMedidores.aspx.cs" Inherits="medidoresweb.VerMedidores" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Contenido" runat="server">
    <div class="row">
        <div class="col-lg-6 mx-auto">
            <div class="card">
                <div class="card-header bg-danger text-white">
                    <h3>Ver Medidores</h3>
                </div>
                <div class="card-body">
                    <div class="form-group">
                        <label for ="tipo"> Filtrar por Medidor: </label>
                        <asp:DropDownList AutoPostBack="true" OnSelectedIndexChanged="nivelDdl_SelectedIndexChanged" runat="server" ID="tipoDdl">
                            <asp:ListItem Value="Medidor de casa" Text="Medidor de casa"></asp:ListItem>
                            <asp:ListItem Value="Medidor de calle" Text="Medidor de calle"></asp:ListItem>
                        </asp:DropDownList>
            
                    </div>
                    
  
                    <asp:GridView CssClass="table table-hover table-bordered mt-5" 
                        OnRowCommand="grilla_RowCommand"
                        EmptyDataText="No hay medidores registrados" ShowHeader="true"
                        AutoGenerateColumns="false" runat="server" ID="grilla">
                       <Columns>
                           <asp:BoundField DataField="tipo" HeaderText="Tipo" />
                           <asp:BoundField DataField="numeroMedidor" HeaderText="Numero de Medidor" />
                       </Columns>
                    </asp:GridView>
                
                
                    </div>
            </div>
        </div>
    </div>
</asp:Content>