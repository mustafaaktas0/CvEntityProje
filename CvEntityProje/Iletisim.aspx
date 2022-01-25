<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Iletisim.aspx.cs" Inherits="CvEntityProje.Iletisim" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <table class="table table-bordered" style="margin-left: 20px; margin-right: 50px">

        <tr>
            <th>ID</th>
            <th>AD SOYAD</th>
            <th>MAIL</th>
            <th>KONU</th>
            <th>MESAJ</th>


        </tr>
        <asp:Repeater ID="Repeater1" runat="server">
            <itemtemplate>

                <tr>
                    <td><%#Eval("ID") %></td>
                    <td><%#Eval("ADSOYAD") %></td>
                     <td><%#Eval("MAIL") %></td>
                    <td><%#Eval("KONU") %></td>
                    

                    <td>
                        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl='<%#"MesajDetay.Aspx?ID=" + Eval("ID")%>' CssClass="btn btn-warning">Mesajı Gör</asp:HyperLink>
                    </td>


                </tr>
            </itemtemplate>

        </asp:Repeater>

    </table>

</asp:Content>
