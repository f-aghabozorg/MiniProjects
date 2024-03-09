<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="rss_webapp.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h3>Your application description page.</h3>
    <p>Use this area to provide additional information.</p>

    <form>
  <label for="rss">RSS Link:</label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br><br>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Read RSS 1" />
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Read RSS 2" Width="135px" />
        <br />
        <br />
        <asp:GridView ID="GridView2" runat="server">
        </asp:GridView>
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Read Database" />
        <br />
        <br />
        <br />
        <br />
    </form>

</asp:Content>
