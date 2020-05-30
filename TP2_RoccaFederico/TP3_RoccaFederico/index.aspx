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

        <div class="row" style="margin-bottom: 20px">
            <%-- Row de dropdown --%>
            <div class="dropdown">
                <button class="btn btn-secondary dropdown-toggle"
                    type="button"
                    id="dropdownMenuButton"
                    data-toggle="dropdown"
                    aria-haspopup="true"
                    aria-expanded="false">
                    Filtrar por categoría
                </button>
                <div class="dropdown-menu" aria-labelledby="dropdownMenuButton">
                    <asp:Repeater runat="server" ID="repeaterCategorias">
                        <ItemTemplate>
                            <asp:Button
                                Text='<%#Eval("descripcion")%>'
                                CssClass="dropdown-item"
                                CommandArgument='<%#Eval("id")%>'
                                CommandName="categoriaSeleccionada"
                                OnClick="btnFiltrarCategoria_Click"
                                runat="server" />
                        </ItemTemplate>
                    </asp:Repeater>
                    <asp:Button
                        Text="Todas"
                        CssClass="dropdown-item"
                        OnClick="btnTodasCategorias_Click"
                        runat="server" />
                </div>
            </div>
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

    <!-- Bootstrap Modal -->
    <div class="modal" id="modalArticuloAgregadoAlCarrito" role="dialog" aria-labelledby="myModalLabel" aria-hidden="true">
        <div class="modal-dialog modal-dialog-centered">
            <asp:UpdatePanel ID="upModal" runat="server" ChildrenAsTriggers="false" UpdateMode="Conditional">
                <ContentTemplate>
                    <div class="modal-content">
                        <div class="modal-body">
                            <p>Articulo agregado al carrito</p>
                        </div>
                        <div class="modal-footer">
                            <button class="btn btn-info" data-dismiss="modal" aria-hidden="true">Aceptar</button>
                        </div>
                    </div>
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
    </div>

    <script src="https://code.jquery.com/jquery-3.5.1.slim.min.js" integrity="sha384-DfXdz2htPH0lsSSs5nCTpuj/zy4C+OGpamoFVy38MVBnE+IbbVYUew+OrCXaRkfj" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js" integrity="sha384-Q6E9RHvbIyZFJoft+2mJbHaEWldlvI9IOYy5n3zV9zzTtmI3UksdQRVvoxMfooAo" crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/js/bootstrap.min.js" integrity="sha384-OgVRvuATP1z7JjHLkuOU7Xw704+h835Lr+6QL9UvYjZE3Ipu6Tp75j7Bh/kR0JKI" crossorigin="anonymous"></script>
</asp:Content>
