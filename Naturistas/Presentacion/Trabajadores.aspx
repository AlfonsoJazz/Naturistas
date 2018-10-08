<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Trabajadores.aspx.cs" Inherits="Naturistas.Presentacion.Trabajadores" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <table>
            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="Nombre del empleado "></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="Tienda"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlTienda" runat="server"></asp:DropDownList>
                </td>
            </tr>
        </table>
        <table>
            <tr>
                <td>
                    <asp:Button ID="btnBuscar" runat="server" Text="Buscar" OnClick="btnBuscar_Click" />
                </td>
            </tr>
        </table>
    </div>
    <div>
        <asp:GridView ID="gvTiendasEmpleados" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#E9E7E2" />
            <SortedAscendingHeaderStyle BackColor="#506C8C" />
            <SortedDescendingCellStyle BackColor="#FFFDF8" />
            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
        </asp:GridView>
    </div>
    <div id="DivTabla" runat ="server" visible="true">
        <asp:GridView ID="gvTrabajadores" runat="server" OnRowCommand="gvTrabajadores_RowCommand" CellPadding="4" ForeColor="#333333" GridLines="None" AutoGenerateColumns="False">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:ButtonField Text="Editar" ButtonType="Button" CommandName="Editar" />
                <asp:BoundField DataField="IdEmpleado" HeaderText="IdEmpleado" />
                <asp:BoundField DataField="Nombre" HeaderText="Nombre" SortExpression="Nombre" />
                <asp:BoundField DataField="Edad" HeaderText="Edad" />
                <asp:BoundField DataField="Direccion" HeaderText="Direccion" />
                <asp:BoundField DataField="Telefono" HeaderText="Telefono" />
                <asp:BoundField DataField="SueldoHora" HeaderText="SueldoHora" />
                <asp:BoundField DataField="IdPuesto" HeaderText="IdPuesto" />
                <asp:BoundField DataField="Puesto" HeaderText="Puesto" />
                <asp:BoundField DataField="HorasTrabajadas" HeaderText="HorasTrabajadas" />
                <asp:BoundField DataField="IdTienda" HeaderText="IdTienda" />
                <asp:BoundField DataField="Tienda" HeaderText="Tienda" />
                <asp:BoundField DataField="Activo" HeaderText="Activo" />
            </Columns>
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
        </asp:GridView>
    </div>
    <div id="DivEdicion" runat="server" visible="false">
        <table>
            <tr>
                <td>

                    <asp:Label ID="Label3" runat="server" Text="Id: "></asp:Label>

                </td>
                <td>
                    <asp:TextBox ID="txtId" runat="server" ReadOnly="True"></asp:TextBox>
                </td>
                <td>
                    <asp:Label ID="Label4" runat="server" Text="Nombre: "></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtNombreE" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:Label ID="Label5" runat="server" Text="Edad"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtEdad" runat="server" TextMode="Number"></asp:TextBox>
                </td>
                <td>
                    <asp:Label ID="Label6" runat="server" Text="Direccion"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtDireccion" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:Label ID="Label7" runat="server" Text="Telefono"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtTelefono" runat="server" TextMode="Number"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label8" runat="server" Text="Sueldo Por Hora"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtSueldo" runat="server" TextMode="Number"></asp:TextBox>
                </td>
                <td>
                    <asp:Label ID="Label9" runat="server" Text="Puesto"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlPuesto" runat="server"></asp:DropDownList>
                </td>
                <td>
                    <asp:Label ID="Label10" runat="server" Text="Horas Trabajadas"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtHorasTrabajadas" runat="server" TextMode="Number"></asp:TextBox>
                </td>
                <td>
                    <asp:Label ID="Label11" runat="server" Text="Tienda"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlTiendaE" runat="server"></asp:DropDownList>
                </td>
                <td>
                    <asp:Label ID="Label12" runat="server" Text="Activo"></asp:Label>
                </td>
                <td>
                    <asp:CheckBox ID="chkActivo" runat="server" />
                </td>
            </tr>
        </table>
        <table>
            <tr>
                <td>
                    <asp:Button ID="btnGuardar" runat="server" Text="Guardar" OnClick="btnGuardar_Click" />
                </td>
                <td>
                    <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" OnClick="btnCancelar_Click" />
                </td>
            </tr>
        </table>
    </div>
</asp:Content>
