<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="IngresaDatos.aspx.cs" Inherits="tp_web_equipo_17B.IngresaDatos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h1>Ingresá tus datos</h1>

    <table>
            <tr>
                <td><asp:Label ID="lblDNI" runat="server" Text="DNI"></asp:Label></td>
                <td><asp:TextBox ID="txtDNI"   AutoPostBack="true"  runat="server"></asp:TextBox></td>
            </tr>

            <tr>
                <td><asp:Label ID="lblNombre" runat="server" Text="Nombre"></asp:Label></td>
                <td><asp:TextBox ID="txtNombre"   AutoPostBack="true"    runat="server"></asp:TextBox></td>

                <td><asp:Label ID="lblDireccion" runat="server" Text="Dirección"></asp:Label></td>
                <td><asp:TextBox ID="txtDireccion"   AutoPostBack="true" runat="server"></asp:TextBox></td>

                <td><asp:Label ID="lblMail" runat="server" Text="Mail"></asp:Label></td>
                <td><asp:TextBox ID="txtMail" AutoPostBack="true"  runat ="server"></asp:TextBox></td>
            </tr>

            <tr>
      
                <td><asp:Label ID="lblApellido" runat="server" Text="Apellido"></asp:Label></td>
                <td><asp:TextBox ID="txtApellido"   AutoPostBack="true" runat="server"></asp:TextBox></td>

                <td><asp:Label ID="lblCiudad" runat="server" Text="Ciudad"></asp:Label></td>
                <td><asp:TextBox ID="txtCiudad"  AutoPostBack="true"  runat="server"></asp:TextBox></td>

                <td><asp:Label ID="lblCP" runat="server" Text="CP"></asp:Label></td>
                <td><asp:TextBox ID="txtCP" AutoPostBack="true"  runat="server"></asp:TextBox></td>
            </tr>

            <tr>
                <td><asp:CheckBox ID="CheckBoxAcepto" runat="server" /></td>
                <td><asp:Label ID="lblAceptoTerminos" runat="server" Text="Acepto los términos y condiciones."></asp:Label></td>
            </tr>

            <tr>
                <td><asp:Button ID="btnParticipar" CssClass="Boton btn btn-primary" OnClick="btnParticipar_Click" runat="server" Text="Participar!" /></td>  
            </tr>

    </table>

</asp:Content>
