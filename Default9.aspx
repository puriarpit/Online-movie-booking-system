<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default9.aspx.cs" Inherits="Default9" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" /><script src="Scripts/jquery-3.3.1.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script><script src="Scripts/popper.min.js"></script><style type="text/css">

        .auto-style1 {
            color: #C0C0C0;
        }

                                                                                                                                                                                                                                                 
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          
        </style><link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.0/css/bootstrap.min.css"><script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script><script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.0/js/bootstrap.min.js"></script>

</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString2 %>" SelectCommand="SELECT * FROM [userinfo5]"></asp:SqlDataSource>
        <br />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:BoundField DataField="userid" HeaderText="userid" SortExpression="userid" />
                <asp:BoundField DataField="name" HeaderText="name" SortExpression="name" />
                <asp:BoundField DataField="MovieName" HeaderText="MovieName" SortExpression="MovieName" />
                <asp:BoundField DataField="TheatreName" HeaderText="TheatreName" SortExpression="TheatreName" />
                <asp:BoundField DataField="tickets" HeaderText="tickets" SortExpression="tickets" />
            </Columns>
        </asp:GridView>
    </form>
</body>
</html>
