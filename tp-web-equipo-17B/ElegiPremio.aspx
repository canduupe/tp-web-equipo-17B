<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ElegiPremio.aspx.cs" Inherits="tp_web_equipo_17B.ElegiPremio" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h1>Elegí tu premio</h1>

    <table>
        <tr>
            <td>
                <div class="card" style="width: 18rem;">
                    <img src="..." class="card-img-top" alt="...">
                    <div class="card-body">
                        <h5 class="card-title">Card title</h5>
                        <p class="card-text">Some quick example text to build on the card title and make up the bulk of the card's content.</p>
                        <a href="#" class="btn btn-primary">Go somewhere</a>
                    </div>
                </div>
            </td>


            <td>
                <div class="card" style="width: 18rem;">
                    <img src="..." class="card-img-top" alt="...">
                    <div class="card-body">
                        <h5 class="card-title">Card title</h5>
                        <p class="card-text">Some quick example text to build on the card title and make up the bulk of the card's content.</p>
                        <a href="#" class="btn btn-primary">Go somewhere</a>
                    </div>
                </div>
            </td>

            <td>
                <div class="card" style="width: 18rem;">
                    <img src="..." class="card-img-top" alt="...">
                    <div class="card-body">
                        <h5 class="card-title">Card title</h5>
                        <p class="card-text">Some quick example text to build on the card title and make up the bulk of the card's content.</p>
                        <a href="#" class="Boton btn btn-primary">Go somewhere</a>
                    </div>
                </div>
            </td>

        </tr>
    </table>

    <asp:Button ID="BtnCargaDatos" runat="server" CssClass="Botones btn btn-success" OnClick="BtnCargaDatos_Click" Text="Siguente" />

    <a href="CanjeVoucher">Regresar a la página anterior</a>

</asp:Content>
