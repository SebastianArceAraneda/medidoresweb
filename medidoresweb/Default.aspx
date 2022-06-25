<%@ Page Title="" Language="C#" MasterPageFile="~/PrincipalMaster.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="medidoresweb.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Contenido" runat="server">
    <div class="row">
        <div class="col-lg-6 mx-auto">
            <div class="mensajes">
                <asp:Label runat="server" ID="mensaje" CssClass="text-success"></asp:Label>
            </div>
            <div class="card">
                <div class="card-header bg-dark text-white">
                    <h3>Agregar Consumo</h3>
                </div>
               
                <div class="card-body">
                    <div class="form-group">
                        <label for="medidoresDAL"><b>Eligir numero de Medidor:</b></label>
                        <asp:DropDownList runat="server" ID="medidores" CssClass="form-control">
                       
                        </asp:DropDownList>
                    </div>
                    <div class="form-group">
                        <label for="fecha"><b>Fecha: </b></label><br />
                        <asp:Calendar ID="Calendar" runat="server"></asp:Calendar>
                          Hora:<asp:TextBox ID="horaTxt" CssClass="form-control" runat="server"></asp:TextBox> 
                          Minutos:<asp:TextBox ID="minutoTxt" CssClass="form-control" runat="server"></asp:TextBox> 
                    </div>
                 
                    <div class="form-group">
                        <label for="Consumo"><b> Consumo: </b></label>
                        <asp:TextBox ID="consumoTxt" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                    
                    
                    <div class="form-group">
                        <asp:Button runat="server" ID="agregarBtn" Text="Agregar" CssClass="btn btn-primary" OnClick="agregarBtn_Click"/>
                    </div>
                    
                </div>
            </div>
        </div>
    </div>
</asp:Content>