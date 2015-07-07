<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="manUser.aspx.cs" Inherits="RegistroAsientos.manUser" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Mantenimiento Usuarios</h1>
        <asp:TextBox ID="txb_name" runat="server"></asp:TextBox>
        <asp:TextBox ID="txb_email" runat="server"></asp:TextBox>
        <asp:TextBox ID="txb_carne" runat="server"></asp:TextBox>
        <asp:TextBox ID="txb_password" runat="server"></asp:TextBox>
        <asp:Button ID="btn_guardar" runat="server" Text="Guardar" OnClick="btn_guardar_Click" />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Id" DataSourceID="manUsers" AllowPaging="True" AllowSorting="True">
            <Columns>
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                <asp:BoundField DataField="Id" HeaderText="Id" InsertVisible="False" ReadOnly="True" SortExpression="Id" />
                <asp:BoundField DataField="name" HeaderText="name" SortExpression="name" />
                <asp:BoundField DataField="email" HeaderText="email" SortExpression="email" />
                <asp:BoundField DataField="carne" HeaderText="carne" SortExpression="carne" />
                <asp:BoundField DataField="password" HeaderText="password" SortExpression="password" />
            </Columns>
        </asp:GridView>
        
        <asp:SqlDataSource ID="manUsers" runat="server" ConnectionString="<%$ ConnectionStrings:ProyectoConnectionString %>" DeleteCommand="DELETE FROM [dbo].[User] where @Id=Id;" SelectCommand="SELECT * FROM [dbo].[User]" UpdateCommand="UPDATE [dbo].[User]  SET name=@name ,email=@email,carne=@carne,password=@password where @Id=Id">
            <DeleteParameters>
                <asp:Parameter Name="Id" />
            </DeleteParameters>
            <UpdateParameters>
                <asp:Parameter Name="name" />
                <asp:Parameter Name="email" />
                <asp:Parameter Name="carne" />
                <asp:Parameter Name="password" />
                <asp:Parameter Name="Id" />
            </UpdateParameters>
        </asp:SqlDataSource>
    </div>
    </form>
</body>
</html>
