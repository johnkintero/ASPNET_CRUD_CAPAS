<%@ Page Language="C#" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="Paginas_index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 225px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            hola mundo
            <br />
            <br />
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">nid</td>
                    <td>
                        <asp:TextBox ID="txtnid" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">nombre</td>
                    <td>
                        <asp:TextBox ID="txtnombre" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">fecha</td>
                    <td>
                        <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">estado</td>
                    <td>
                        <asp:RadioButton ID="rdbtnsi" runat="server" Checked="True" GroupName="estado" />
                        <asp:RadioButton ID="rdbtnNo" runat="server" GroupName="estado" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td>
                        <asp:Button ID="btnsave" runat="server" OnClick="btnsave_Click" Text="save" />
                        <asp:Button ID="BtnSaveSP" runat="server" OnClick="BtnSaveSP_Click" Text="SaveSP" />
                    </td>
                </tr>
            </table>
            <br />
            <br />
            <br />
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="carga linq" />
            <br />
            <br />
            <br />
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" DataKeyNames="id" OnRowCommand="GridView1_RowCommand" OnRowDeleting="GridView1_RowDeleting">
                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                <Columns>
                    <asp:BoundField DataField="id" HeaderText="ID" />
                    <asp:BoundField DataField="NID" HeaderText="NID" />
                    <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
                    <asp:BoundField DataField="Fecha" HeaderText="Fecha" />
                    <asp:BoundField DataField="activo" HeaderText="activo" />
                    <asp:BoundField DataField="registro" HeaderText="registro" />
                    <asp:ButtonField Text="Delete" CommandName="Delete"/>
                </Columns>
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
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
        </div>
    </form>
</body>
</html>
