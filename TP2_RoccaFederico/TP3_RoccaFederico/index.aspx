<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="TP3_RoccaFederico._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <%-- Row de navbar superior --%>
    </div>

    <div class="row">
        <%-- Row de carousel --%>
        <div id="carouselExampleCaptions" class="carousel slide carousel-fade" data-ride="carousel">
            <div class="carousel-inner" style="width: 500px; height: 500px !important;">

                <% int c = 0;
                    foreach (var item in articulos)
                    {
                        if (c == 0)
                        { %>
                <div class="carousel-item active">
                    <% }
                        else
                        { %>
                    <div class="carousel-item">
                        <% } %>
                        <img src="<% = item.imagen %>" class="d-block w-100">
                        <div class="carousel-caption d-none d-md-block bg-dark">
                            <h5><% = item.nombre %></h5>
                            <p><% = item.descripcion %></p>
                        </div>
                    </div>
                    <% c++; } %>
                </div>
                <a class="carousel-control-prev" href="#carouselExampleCaptions" role="button" data-slide="prev" style="color: darkblue">
                    <span class="carousel-control-prev-icon" aria-hidden="true"></span>
                    <span class="sr-only">Previous</span>
                </a>
                <a class="carousel-control-next" href="#carouselExampleCaptions" role="button" data-slide="next">
                    <span class="carousel-control-next-icon" aria-hidden="true"></span>
                    <span class="sr-only">Next</span>
                </a>
            </div>
        </div>
        <div class="row">
        <%-- Row de carousel --%>
        <div id="carouselExampleCaptions" class="carousel slide carousel-fade" data-ride="carousel">
            <div class="carousel-inner" style="width: 500px; height: 500px !important;">

                <% int c = 0;
                    foreach (var item in articulos)
                    {
                        if (c == 0)
                        { %>
                <div class="carousel-item active">
                    <% }
                        else
                        { %>
                    <div class="carousel-item">
                        <% } %>
                        <img src="<% = item.imagen %>" class="d-block w-100">
                        <div class="carousel-caption d-none d-md-block bg-dark">
                            <h5><% = item.nombre %></h5>
                            <p><% = item.descripcion %></p>
                        </div>
                    </div>
                    <% c++; } %>
                </div>
                <a class="carousel-control-prev" href="#carouselExampleCaptions" role="button" data-slide="prev" style="color: darkblue">
                    <span class="carousel-control-prev-icon" aria-hidden="true"></span>
                    <span class="sr-only">Previous</span>
                </a>
                <a class="carousel-control-next" href="#carouselExampleCaptions" role="button" data-slide="next">
                    <span class="carousel-control-next-icon" aria-hidden="true"></span>
                    <span class="sr-only">Next</span>
                </a>
            </div>
        </div>

        <div class="row">
            <%-- Row tarjetas --%>
            <div class="card-deck">
            <%
                foreach (var item in articulos)
                {%>
                    <div class="card" style="width: 18rem;">
                        <img src="<% = item.imagen %>" class="card-img-top">
                        <div class="card-body">
                            <h5 class="card-title"><% = item.nombre %></h5>
                            <p class="card-text"><% = item.descripcion %></p>
                        </div>
                        <div class="card-body">
                            <a href="#" class="btn btn-primary">Comprar</a>
                        </div>
                    </div>
            
            <%}%>
            </div>
        </div>
</asp:Content>
