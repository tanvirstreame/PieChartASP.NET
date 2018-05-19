<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="PieChart.Home" %>

<%@ Register Assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" Namespace="System.Web.UI.DataVisualization.Charting" TagPrefix="asp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>

<body>
    <form id="form1" runat="server"> 
        <asp:FileUpload ID="FileUpload1" runat="server" />
    <div>

      
    </div>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click1" Text="Show Chart" />
        <p>
        <asp:Chart ID="ChartPhone" runat="server">
            <Series>
                <asp:Series Name="Series1" ChartType="Pie"></asp:Series>
            </Series>
            <ChartAreas>
                <asp:ChartArea Name="ChartArea1"></asp:ChartArea>
            </ChartAreas>
        </asp:Chart>
        </p>
    </form>
</body>
</html>
