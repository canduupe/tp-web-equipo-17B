<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CanjeVoucher.aspx.cs" Inherits="tp_web_equipo_17B.CanjeVoucher" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div>
        <asp:Label ID="LblVoucher" runat="server" Text="Ingresá el código de tu voucher!"></asp:Label>
    </div>
    <div>
        <asp:TextBox ID="TextVoucher" CssClass="form-control" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Button ID="BtnVoucher" CssClass="btn btn-primary" runat="server" OnClick="BtnVoucher_Click" Text="Ingresar" />
    </div>
    <div>
        <asp:Label ID="LblCanjenado" runat="server"></asp:Label>
    </div>

</asp:Content>
