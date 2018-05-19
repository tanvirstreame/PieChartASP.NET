<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="PieChart.Home" %>

<%@ Register Assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" Namespace="System.Web.UI.DataVisualization.Charting" TagPrefix="asp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css">
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
  <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
</head>

<body>
    <form id="form1" runat="server"> 

        <div style="height:80px;background-color:#0094ff">

        <asp:FileUpload style="margin-left:40%;float:left" ID="FileUpload1" runat="server"  accept=".csv"/>
    <div>

      
    </div>
        <asp:Button ID="Button1" style="margin-left:40%" runat="server" OnClick="Button1_Click1" Text="Show Chart" />
            </div>
        <div>
        <p>
        <asp:Chart ID="ChartPhone" runat="server">
            <Series>
                <asp:Series Name="Series1" ChartType="Pie"></asp:Series>
            </Series>
            <ChartAreas>
                <asp:ChartArea Name="ChartArea1"></asp:ChartArea>
            </ChartAreas>
        </asp:Chart>
            <asp:Chart ID="Chart1" runat="server">
                <Series>
                    <asp:Series ChartType="Pie" Name="Series1">
                    </asp:Series>
                </Series>
                <ChartAreas>
                    <asp:ChartArea Name="ChartArea1">
                    </asp:ChartArea>
                </ChartAreas>
            </asp:Chart>
        </p></div>
    </form>
</body>
</html>
