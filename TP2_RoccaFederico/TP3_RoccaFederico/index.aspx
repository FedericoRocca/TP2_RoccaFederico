<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="TP3_RoccaFederico._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <%-- Row de navbar superior --%>
    </div>

    <div class="row">
        <p>row carousel</p>
        <div id="carouselExampleCaptions" class="carousel slide" data-ride="carousel">
            <ol class="carousel-indicators">
                <li data-target="#carouselExampleCaptions" data-slide-to="0" class="active"></li>
            </ol>
            <div class="carousel-inner">

                <% int c = 0;
                    foreach (var item in articulos)
                   {
                %>
                    <% if (c == 0)
                        {%> <div class="carousel-item active"> <% } else { %>
                    <div class="carousel-item"> <% } %>
                        <img src="<% = item.imagen %>" class="d-block w-100">
                        <div class="carousel-caption d-none d-md-block">
                            <h5><% = item.nombre %></h5>
                            <p><% = item.descripcion %></p>
                        </div>
                    </div>
                <% c++; } %>
            </div>
            <a class="carousel-control-prev" href="#carouselExampleCaptions" role="button" data-slide="prev">
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
        <p>row tarjetas</p>
    </div>
</asp:Content>
