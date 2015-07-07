<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistroAsientos.aspx.cs" Inherits="RegistroAsientos.RegistroAsientos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Mantenimiento de Reservas</h1>
        <br>
        <asp:TextBox ID="txb_starTime" runat="server"></asp:TextBox>
        <asp:TextBox ID="txb_endTime" runat="server"></asp:TextBox>
        <asp:TextBox ID="txb_course" runat="server"></asp:TextBox>
        <asp:TextBox ID="txb_Observation" runat="server"></asp:TextBox>
        <br>
        <asp:Calendar ID="Cld_Date" runat="server"></asp:Calendar>
        <br>
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="Id" DataSourceID="manReservation" style="margin-right: 2px" Width="904px">
            <Columns>
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                <asp:BoundField DataField="Id" HeaderText="Id" InsertVisible="False" ReadOnly="True" SortExpression="Id" />
                <asp:BoundField DataField="startTime" HeaderText="startTime" SortExpression="startTime" />
                <asp:BoundField DataField="endTime" HeaderText="endTime" SortExpression="endTime" />
                <asp:BoundField DataField="course" HeaderText="course" SortExpression="course" />
                <asp:BoundField DataField="Observation" HeaderText="Observation" SortExpression="Observation" />
                <asp:BoundField DataField="Date" HeaderText="Date" SortExpression="Date" />
                <asp:BoundField DataField="User_id" HeaderText="User_id" SortExpression="User_id" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="manReservation" runat="server" ConnectionString="<%$ ConnectionStrings:ProyectoConnectionString %>" DeleteCommand="DELETE FROM Reservation where @Id=Id;" SelectCommand="SELECT * FROM [Reservation]" UpdateCommand="UPDATE Reservation SET StartTime=@StartTime ,EndTime=@EndTime,Course=@Course,Observation=@Observation,Date=@Date ,User_id=@User_id where @Id=Id">
            <DeleteParameters>
                <asp:Parameter Name="Id" />
            </DeleteParameters>
            <UpdateParameters>
                <asp:Parameter Name="StartTime" />
                <asp:Parameter Name="EndTime" />
                <asp:Parameter Name="Course" />
                <asp:Parameter Name="Observation" />
                <asp:Parameter Name="Date" />
                <asp:Parameter Name="User_id" />
                <asp:Parameter Name="Id" />
            </UpdateParameters>
        </asp:SqlDataSource>
        <asp:Button ID="btn_Guardar" runat="server" Text="Button" OnClick="btn_Guardar_Click" />

        <asp:Label ID="lbl_muestra" runat="server" Text="Label"></asp:Label>
    </div>
    </form>
</body>
</html>
