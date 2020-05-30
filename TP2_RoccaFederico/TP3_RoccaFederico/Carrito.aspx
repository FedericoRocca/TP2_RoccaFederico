<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Carrito.aspx.cs" Inherits="TP3_RoccaFederico.Carrito" EnableEventValidation="false" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/css/bootstrap.min.css" integrity="sha384-9aIt2nRpC12Uk9gS9baDl411NQApFmC26EwAOH8WgZl5MYYxFfc+NcPb1dKGj7Sk" crossorigin="anonymous">
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <%-- navbar, cabecera --%>
            <nav class="navbar navbar-expand-lg navbar-light bg-light">
                <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
                    <span class="navbar-toggler-icon"></span>
                </button>
                <a class="navbar-brand" href="index.aspx">
                    <img src="/Miscelaneo/Mercadopreso.png" width="100" height="45" class="d-inline-block align-top">
                </a>
                <div class="collapse navbar-collapse d-flex justify-content-end" id="navbarSupportedContent">
                    <a href="Carrito.aspx" class="btn btn-outline-success my-2 my-sm-0">Mi carrito de compra(<% = carritoArticulos.elementos.Count() %>)</a>
                </div>
            </nav>

            <div class="row">
                <% if (carritoArticulos.elementos.Count > 0)
                    {
                %><h4>Total a pagar: $<% = totalAPagar %></h4>
                <%
                    }%>
            </div>

            <% if (carritoArticulos.elementos.Count <= 0)
                {
            %><h5>No tenés articulos cargados en el carrito</h5>
            <%
                }
                else
                {
            %>
            <div class="row">
                <table class="table">
                    <thead>
                        <tr>
                            <th scope="col">Articulo</th>
                            <th scope="col">Detalle</th>
                            <th scope="col">Precio</th>
                            <th scope="col"></th>
                        </tr>
                    </thead>
                    <tbody>
                        <asp:Repeater runat="server" ID="carritoRepeater">
                            <ItemTemplate>
                                <tr>
                                    <td><%#Eval("nombre")%></td>
                                    <td><%#Eval("descripcion")%></td>
                                    <td>$<%#Eval("precio")%></td>
                                    <td>
                                        <asp:Button
                                            ID="btnQuitarDelCarrito"
                                            CssClass="btn btn-primary"
                                            Text="Quitar del carrito"
                                            CommandArgument='<%#Eval("id")%>'
                                            CommandName="articuloAEliminar"
                                            runat="server"
                                            OnClick="btnQuitarDelCarrito_Click" />
                                </tr>
                                </td>
                            </ItemTemplate>
                        </asp:Repeater>
                    </tbody>
                </table>
            </div>
            <%
                }%>

            <div class="row">
            </div>
        </div>

    </form>
    <script src="https://code.jquery.com/jquery-3.5.1.slim.min.js" integrity="sha384-DfXdz2htPH0lsSSs5nCTpuj/zy4C+OGpamoFVy38MVBnE+IbbVYUew+OrCXaRkfj" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js" integrity="sha384-Q6E9RHvbIyZFJoft+2mJbHaEWldlvI9IOYy5n3zV9zzTtmI3UksdQRVvoxMfooAo" crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/js/bootstrap.min.js" integrity="sha384-OgVRvuATP1z7JjHLkuOU7Xw704+h835Lr+6QL9UvYjZE3Ipu6Tp75j7Bh/kR0JKI" crossorigin="anonymous"></script>
    <script type="text/javascript">
        function openModal() {
            $('#myModal').modal('show');
        }
    </script>
</body>
</html>
