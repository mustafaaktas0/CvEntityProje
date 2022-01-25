<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="MesajDetay.aspx.cs" Inherits="CvEntityProje.MesajDetay" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<h4>Mesaj Detayları</h4>
    <asp:TextBox ID="TextAdSoayd" runat="server" CssClass="form-control" Enabled="false"></asp:TextBox>
<br />
     <asp:TextBox ID="TextMail" runat="server" CssClass="form-control" Enabled="false"></asp:TextBox>
<br />
     <asp:TextBox ID="TextKonu" runat="server" CssClass="form-control" Enabled="false"></asp:TextBox>
<br />
     <asp:TextBox ID="TextMesaj" TextMode="MultiLine"  runat="server" CssClass="form-control"  Enabled="false" Height="100"></asp:TextBox>
<br />
</asp:Content>
