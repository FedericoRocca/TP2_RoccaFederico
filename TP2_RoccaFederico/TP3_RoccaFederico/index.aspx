<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="TP3_RoccaFederico._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <%-- Row de navbar superior --%>
    </div>
    <div class="row">
        <%-- Row tarjetas --%>
        <div class="card-deck">
            <asp:Repeater runat="server" ID="articulosRepeater">
                <ItemTemplate>
                    <div class="card">
                        <img src="<%#Eval("imagen") %>" class="card-img-top">
                        <div class="card-body">
                            <h5 class="card-title"><%#Eval("nombre")%></h5>
                            <p class="card-text"><%#Eval("descripcion")%></p>
                        </div>
                        <asp:Button 
                            ID="btnAgregarAlCarrito" 
                            CssClass="btn btn-primary"
                            Text="Comprar" 
                            CommandArgument='<%#Eval("id")%>'
                            CommandName="articuloSeleccionado" 
                            runat="server"
                            onclick="btnAgregarAlCarrito_Click"/>
                    </div>
                </ItemTemplate>
            </asp:Repeater>

        </div>
    </div>
</asp:Content>
