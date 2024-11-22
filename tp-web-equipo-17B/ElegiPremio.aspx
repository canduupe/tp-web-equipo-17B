<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ElegiPremio.aspx.cs" Inherits="tp_web_equipo_17B.ElegiPremio" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h1 class="text-center">Elegí tu premio</h1>
    <br/>


  <%--  <div class="row g-4  gx-4" >  
        <%
            foreach (Dominio.Articulo arti in ListaArticulos)
            {
                %>
        <div class="card mx-3" style="width: 18rem;">

        <div class="card-body">
            <h5 class="card-title"><%: arti.Nombre %></h5>
            <p class="card-text"><%: arti.Descripcion %></p>
            <asp:Button ID="Button1" runat="server" CssClass="btn btn-success" OnClick="BtnCargaDatos_Click" Text="¡Canjeame!" />
        </div>
        </div>
        <%} %>

    </div>--%>




 <div class="row row-cols-1 row-cols-md-3 g-4">

   <%
       foreach (Dominio.Articulo item in ListaArticulos)
       {
           %>

  <div class="col">
    <div class="card">
      <img src="<%: item.URLImagen %>" class="card-img-top" alt="...">
      <div class="card-body">
        <h5 class="card-title"><%: item.Nombre %></h5>
        <p class="card-text"><%: item.Descripcion %></p>
          <a href="IngresaDatos.aspx?ida=<%: item.IdArticulo %>"  class="btn btn-outline-success"  > Canjear </a>
      </div>
    </div>
  </div>

       <%}%>             

</div>
    





    <div class="Boton">
        <a href="CanjeVoucher" class="Boton">Regresar</a>
    </div>


</asp:Content>
