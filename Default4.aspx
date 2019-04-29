t54red444<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default4.aspx.vb" Inherits="Default4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <link href="Content/bootstrap.min.css" rel="stylesheet" /><script src="Scripts/jquery-3.3.1.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script><script src="Scripts/popper.min.js"></script><style type="text/css">

        .auto-style1 {
            color: #C0C0C0;
        }

                                                                                                                                                                                                                                                                                                            .auto-style2 {
                                                                                                                                                                                                                                                                                                                color: #000000;
                                                                                                                                                                                                                                                                                                            }

        </style><link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.0/css/bootstrap.min.css"><script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script><script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.0/js/bootstrap.min.js"></script>

</head>
<body style="background-image: url(Capture2.jpg); width:100%; height:100%;background-repeat: no-repeat; background-attachment: fixed; background-size: 1500px 1000px;">
        <nav class="navbar fixed-top navbar-expand-lg navbar-dark bg-dark">
  <a class="navbar-brand" href="Default2.aspx">Sign Up</a>
  <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarNavDropdown" aria-controls="navbarNavDropdown" aria-expanded="false" aria-label="Toggle navigation">
    <span class="navbar-toggler-icon"></span>
  </button>
  <div class="collapse navbar-collapse" id="navbarNavDropdown">
    <ul class="navbar-nav">
      <li class="nav-item active">
        <a class="nav-link" href="Default3.aspx">Home <span class="sr-only">(current)</span></a>
      </li>
      
       <li class="nav-item dropdown">
        <a class="nav-link dropdown-toggle" href="#" id="navbarDropdownMenuLink" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
          Movie Shows
        </a>
        <div class="dropdown-menu" aria-labelledby="navbarDropdownMenuLink">

          <a class="dropdown-item" href="Default4.aspx">Simmba</a>
            <a class="dropdown-item" href="Default4.aspx">Lukka Chuppi</a>
            <a class="dropdown-item" href="Default4.aspx">Kesari</a>
            <a class="dropdown-item" href="Default.aspx">Aquaman</a>
            <a class="dropdown-item" href="Default.aspx">Thugs of Hiindustan</a>
        </div>
      </li>
      <li class="nav-item dropdown">
        <a class="nav-link dropdown-toggle" href="#" id="navbarDropdownMenuLink" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
          More
        </a>
        <div class="dropdown-menu" aria-labelledby="navbarDropdownMenuLink">

          <a class="dropdown-item" href="Default.aspx">Log Out</a>
        </div>
      </li>
    </ul>
  </div>
</nav>
    <form id="form1" runat="server">
        <div id="ID1">
            <br />
            <br />
            <asp:Label ID="Identity1" runat="server" style="color: #C0C0C0" Text="Sri Vishnu"></asp:Label>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="10:30 AM" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" Text="12:15 PM" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button3" runat="server" Text="2:00 PM" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button4" runat="server" Height="30px" Text="4:30 PM" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button5" runat="server" Text="8:30 PM" />
        </div>
        <p id="ID2">
            <asp:Label ID="Identity2" runat="server" style="color: #C0C0C0" Text="Galaxy Cinemas"></asp:Label>
        </p>
        <p>
            <asp:Button ID="Button6" runat="server" Text="9:30 AM" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button7" runat="server" Text="3:30 PM" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button8" runat="server" Text="5:15 PM" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button9" runat="server" Text="7:00PM" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button10" runat="server" Text="9:00 PM" />
        </p>
        <p id="ID3">
            <asp:Label ID="Identity3" runat="server" style="color: #C0C0C0" Text="Ascar Cinemas"></asp:Label>
        </p>
        <p>
            <asp:Button ID="Button11" runat="server" Text="10:00 AM" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button12" runat="server" Text="11:30 AM" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button13" runat="server" Text="1:15 PM" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button14" runat="server" Text="6:00 PM" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button15" runat="server" Text="10:45 PM" />
        </p>
        <p id="ID4">
            <asp:Label ID="Identity4" runat="server" style="color: #C0C0C0" Text="PVR Cinemas"></asp:Label>
        </p>
        <p>
            <asp:Button ID="Button16" runat="server" Text="9:00 AM" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button17" runat="server" Text="12:00 PM" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button18" runat="server" Text="2:30 PM" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button19" runat="server" Text="4:00 PM" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button20" runat="server" Text="7:10 PM" />
        </p>
        <p id="ID5">
            <asp:Label ID="Identity5" runat="server" style="color: #C0C0C0" Text="Fun Republic"></asp:Label>
        </p>
        <p>
            <asp:Button ID="Button21" runat="server" Text="8:00 AM" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button22" runat="server" Text="12:45 PM" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button23" runat="server" Text="3:00 PM" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button24" runat="server" Text="6:00 PM" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button25" runat="server" Text="9:00 PM" />
        </p>
    </form>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
</body>
</html>
