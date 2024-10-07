<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CanjeVoucher.aspx.cs" Inherits="tp_web_equipo_17B.CanjeVoucher" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

<div class="row">

    <div class="col-2"></div>   
    <div class="col">
    <div>
        <h1 class="text-center"><b> Canjea tu Voucher :D  </b></h1>
    </div>
    <div class ="Boton">
        <asp:TextBox ID="TextVoucher"  AutoPostBack="true"  CssClass ="form-control" runat="server" ></asp:TextBox>
    </div>
    <div>
        <asp:Button ID="BtnVoucher" CssClass="Boton  btn btn-primary" runat="server" OnClick="BtnVoucher_Click" Text="Ingresar" />
    </div>
    <div>
        <asp:Label ID="LblCanjenado" runat="server"></asp:Label>
    </div>
    </div>   
    <div class="col-2"></div>   
</div>

</asp:Content>
