<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="bilar.aspx.cs" Inherits="FL.bilar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <asp:TextBox ID="txtMake" runat="server"></asp:TextBox>
        <br />
        <asp:TextBox ID="txtModel" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="btnSave" runat="server" Text="Button" OnClick="btnSave_Click" />
    </div>
    <div id="allabilar" runat="server"></div>
    <div id="allamärken" runat="server"></div>
</asp:Content>
