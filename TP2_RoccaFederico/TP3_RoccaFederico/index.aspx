<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="TP3_RoccaFederico._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <%-- navbar, cabecera --%>
        <nav class="navbar navbar-expand-lg navbar-light bg-light">
            <a class="navbar-brand" href="index.aspx">
                <img src="/Miscelaneo/Mercadopreso.png" width="100" height="45" class="d-inline-block align-top">
            </a>

            <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
                <span class="navbar-toggler-icon"></span>
            </button>

            <div class="collapse navbar-collapse d-flex justify-content-end" id="navbarSupportedContent">
                <a href="Carrito.aspx" class="btn btn-outline-success my-2 my-sm-0">Mi carrito de compra (<% = miCarrito.elementos.Count() %>)</a>
            </div>
        </nav>
        <div class="row">
            <%-- Row de navbar superior --%>
        </div>
        <div class="row">
            <%-- Row tarjetas --%>
            <div class="card-columns">
                <asp:Repeater runat="server" ID="articulosRepeater">
                    <ItemTemplate>
                        <div class="card">
                            <img src="<%#Eval("imagen") %>" class="card-img-top">
                            <div class="card-body">
                                <h5 class="card-title"><%#Eval("nombre")%></h5>
                                <p class="card-text"><%#Eval("descripcion")%></p>
                                <p class="card-text">$<%#Eval("precio")%></p>
                            </div>
                            <asp:Button
                                ID="btnAgregarAlCarrito"
                                CssClass="btn btn-primary"
                                Text="Agregar al carrito"
                                CommandArgument='<%#Eval("id")%>'
                                CommandName="articuloSeleccionado"
                                runat="server"
                                OnClick="btnAgregarAlCarrito_Click" />
                        </div>
                    </ItemTemplate>
                </asp:Repeater>

            </div>
        </div>
    </div>
</asp:Content>
