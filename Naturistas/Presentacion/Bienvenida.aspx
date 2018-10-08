<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Bienvenida.aspx.cs" Inherits="Naturistas.Presentacion.Bienvenida" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div align="Center" >
        <table align="Center" width="100%" >
            <tr align="Center" >
                <td align="Center" >
                    <asp:Image width="100%" ID="Image1" align="center" runat="server" ImageUrl="~/Recursos/Bienvenidos.png" />
                </td>
            </tr>
        </table>
    </div>
</asp:Content>
