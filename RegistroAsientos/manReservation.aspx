<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="manReservation.aspx.cs" Inherits="RegistroAsientos.manReservation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="txb_startTime" runat="server"></asp:TextBox>
        <asp:TextBox ID="txb_endTime" runat="server"></asp:TextBox>
        <asp:TextBox ID="txb_Course" runat="server"></asp:TextBox>
        <asp:TextBox ID="txb_Observation" runat="server"></asp:TextBox>
        <asp:Calendar ID="Cl_date" runat="server"></asp:Calendar>
        <asp:Button ID="Button1" runat="server" Text="Button" />
    </div>
    </form>
</body>
</html>
