<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="DiceRoller._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    

    <asp:TextBox ID="rand1" runat="server" Width="25px" Enabled="False"></asp:TextBox>

    <asp:TextBox ID="rand2" runat="server" Width="25px" Enabled="False"></asp:TextBox>

    <asp:Button ID="btnCalculate" runat="server" Text="Calculate" OnClick="btnCalculate_Click" />

    

</asp:Content>
