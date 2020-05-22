<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="TP3_RoccaFederico._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <%-- Row de navbar superior --%>
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
                            <a href="index.aspx?artID=<% = item.id.ToString() %>" class="btn btn-primary btn-block">Agregar al carrito</a>
                        </div>
                    </div>
            
            <%}%>
            </div>
        </div>
</asp:Content>
