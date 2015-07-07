<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="manLaboratory.aspx.cs" Inherits="RegistroAsientos.manLaboratory" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Mantenimiento de laboratorios</h1>
        <asp:TextBox ID="txb_name" runat="server"></asp:TextBox>
        <asp:TextBox ID="txb_capacity" runat="server"></asp:TextBox>
        <asp:TextBox ID="txb_type" runat="server"></asp:TextBox>
        <asp:DropDownList ID="ddl_faculties" runat="server" DataSourceID="SqlDataSource1" DataTextField="name" DataValueField="Id">
            <asp:ListItem Selected="True"></asp:ListItem>
        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ProyectoConnectionString %>" SelectCommand="SELECT * FROM [Faculty]"></asp:SqlDataSource>
                <asp:Button ID="btn_guardar" runat="server" Text="Guardar" OnClick="btn_guardar_Click" />
    
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="id" DataSourceID="SqlDataSource3" style="margin-right: 0px" Width="500px" AllowPaging="True" AllowSorting="True">

            <Columns>
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" ReadOnly="True" SortExpression="id" />
                <asp:BoundField DataField="name" HeaderText="name" SortExpression="name" />
                <asp:BoundField DataField="capacity" HeaderText="capacity" SortExpression="capacity" />
                <asp:BoundField DataField="type" HeaderText="type" SortExpression="type" />
                <asp:BoundField DataField="id_Faculty" HeaderText="id_Faculty" SortExpression="id_Faculty" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:ProyectoConnectionString %>" DeleteCommand="DELETE FROM laboratory where @Id=Id;" SelectCommand="SELECT * FROM laboratory" UpdateCommand="UPDATE laboratory SET name=@name ,capacity=@capacity,type=@type,id_Faculty=@id_Faculty">
            <DeleteParameters>
                <asp:Parameter Name="Id" />
            </DeleteParameters>
            <UpdateParameters>
                <asp:Parameter Name="name" />
                <asp:Parameter Name="capacity" />
                <asp:Parameter Name="type" />
                <asp:Parameter Name="id_Faculty" />
            </UpdateParameters>
        </asp:SqlDataSource>
    </div>
    </form>
</body>
</html>
