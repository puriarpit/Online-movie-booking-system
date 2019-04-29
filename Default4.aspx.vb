
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Partial Class Default4
    Inherits System.Web.UI.Page

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ConnectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\wipro\App_Data\Database.mdf;Integrated Security=True;"
        Dim con2 As New SqlConnection(ConnectionString)
        con2.Open()
        Dim theQuery2 As String = "INSERT INTO  userinfo2(UserId,MovieName,TheatreName,Time_And_Date) VALUES (@LastName,@FirstName,@TheatreName,@Time)"
        Dim cmd1 As SqlCommand = New SqlCommand(theQuery2, con2)
        cmd1.Parameters.AddWithValue("@FirstName", Request.QueryString().ToString())
        cmd1.Parameters.AddWithValue("@LastName", Session("textBoxValue"))
        cmd1.Parameters.AddWithValue("@TheatreName", Identity1.Text)
        cmd1.Parameters.AddWithValue("@Time", Button1.Text)
        cmd1.ExecuteReader()
        Session("textBoxValue2") = Request.QueryString().ToString()
        Session("textBoxValue3") = Identity1.Text
        Session("textBoxValue4") = Button1.Text
        Response.Redirect("Default8.aspx")
        con2.Close()
    End Sub
    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim ConnectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\wipro\App_Data\Database.mdf;Integrated Security=True;"
        Dim con2 As New SqlConnection(ConnectionString)
        con2.Open()
        Dim theQuery2 As String = "INSERT INTO  userinfo2(UserId,MovieName,TheatreName,Time_And_Date) VALUES (@LastName,@FirstName,@TheatreName,@Time)"
        Dim cmd1 As SqlCommand = New SqlCommand(theQuery2, con2)
        cmd1.Parameters.AddWithValue("@FirstName", Request.QueryString().ToString())
        cmd1.Parameters.AddWithValue("@LastName", Session("textBoxValue"))
        cmd1.Parameters.AddWithValue("@TheatreName", Identity1.Text)
        cmd1.Parameters.AddWithValue("@Time", Button2.Text)
        cmd1.ExecuteReader()
        Session("textBoxValue2") = Request.QueryString().ToString()
        Session("textBoxValue3") = Identity1.Text
        Session("textBoxValue4") = Button1.Text
        Response.Redirect("Default8.aspx")
        con2.Close()
    End Sub
    Protected Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim ConnectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\wipro\App_Data\Database.mdf;Integrated Security=True;"
        Dim con2 As New SqlConnection(ConnectionString)
        con2.Open()
        Dim theQuery2 As String = "INSERT INTO  userinfo2(UserId,MovieName,TheatreName,Time_And_Date) VALUES (@LastName,@FirstName,@TheatreName,@Time)"
        Dim cmd1 As SqlCommand = New SqlCommand(theQuery2, con2)
        cmd1.Parameters.AddWithValue("@FirstName", Request.QueryString().ToString())
        cmd1.Parameters.AddWithValue("@LastName", Session("textBoxValue"))
        cmd1.Parameters.AddWithValue("@TheatreName", Identity1.Text)
        cmd1.Parameters.AddWithValue("@Time", Button3.Text)
        cmd1.ExecuteReader()
        Session("textBoxValue2") = Request.QueryString().ToString()
        Session("textBoxValue3") = Identity1.Text
        Session("textBoxValue4") = Button1.Text
        Response.Redirect("Default8.aspx")
        con2.Close()
    End Sub
    Protected Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim ConnectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\wipro\App_Data\Database.mdf;Integrated Security=True;"
        Dim con2 As New SqlConnection(ConnectionString)
        con2.Open()
        Dim theQuery2 As String = "INSERT INTO  userinfo2(UserId,MovieName,TheatreName,Time_And_Date) VALUES (@LastName,@FirstName,@TheatreName,@Time)"
        Dim cmd1 As SqlCommand = New SqlCommand(theQuery2, con2)
        cmd1.Parameters.AddWithValue("@FirstName", Request.QueryString().ToString())
        cmd1.Parameters.AddWithValue("@LastName", Session("textBoxValue"))
        cmd1.Parameters.AddWithValue("@TheatreName", Identity1.Text)
        cmd1.Parameters.AddWithValue("@Time", Button4.Text)
        cmd1.ExecuteReader()
        Session("textBoxValue2") = Request.QueryString().ToString()
        Session("textBoxValue3") = Identity1.Text
        Session("textBoxValue4") = Button1.Text
        Response.Redirect("Default8.aspx")
        con2.Close()
    End Sub

    Protected Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim ConnectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\wipro\App_Data\Database.mdf;Integrated Security=True;"
        Dim con2 As New SqlConnection(ConnectionString)
        con2.Open()
        Dim theQuery2 As String = "INSERT INTO  userinfo2(UserId,MovieName,TheatreName,Time_And_Date) VALUES (@LastName,@FirstName,@TheatreName,@Time)"
        Dim cmd1 As SqlCommand = New SqlCommand(theQuery2, con2)
        cmd1.Parameters.AddWithValue("@FirstName", Request.QueryString().ToString())
        cmd1.Parameters.AddWithValue("@LastName", Session("textBoxValue"))
        cmd1.Parameters.AddWithValue("@TheatreName", Identity1.Text)
        cmd1.Parameters.AddWithValue("@Time", Button5.Text)
        cmd1.ExecuteReader()
        Session("textBoxValue2") = Request.QueryString().ToString()
        Session("textBoxValue3") = Identity1.Text
        Session("textBoxValue4") = Button1.Text
        Response.Redirect("Default8.aspx")
        con2.Close()
    End Sub
    Protected Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim ConnectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\wipro\App_Data\Database.mdf;Integrated Security=True;"
        Dim con2 As New SqlConnection(ConnectionString)
        con2.Open()
        Dim theQuery2 As String = "INSERT INTO  userinfo2(UserId,MovieName,TheatreName,Time_And_Date) VALUES (@LastName,@FirstName,@TheatreName,@Time)"
        Dim cmd1 As SqlCommand = New SqlCommand(theQuery2, con2)
        cmd1.Parameters.AddWithValue("@FirstName", Request.QueryString().ToString())
        cmd1.Parameters.AddWithValue("@LastName", Session("textBoxValue"))
        cmd1.Parameters.AddWithValue("@TheatreName", Identity2.Text)
        cmd1.Parameters.AddWithValue("@Time", Button6.Text)
        cmd1.ExecuteReader()
        Response.Redirect("Default8.aspx")
        con2.Close()
    End Sub
    Protected Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim ConnectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\wipro\App_Data\Database.mdf;Integrated Security=True;"
        Dim con2 As New SqlConnection(ConnectionString)
        con2.Open()
        Dim theQuery2 As String = "INSERT INTO  userinfo2(UserId,MovieName,TheatreName,Time_And_Date) VALUES (@LastName,@FirstName,@TheatreName,@Time)"
        Dim cmd1 As SqlCommand = New SqlCommand(theQuery2, con2)
        cmd1.Parameters.AddWithValue("@FirstName", Request.QueryString().ToString())
        cmd1.Parameters.AddWithValue("@LastName", Session("textBoxValue"))
        cmd1.Parameters.AddWithValue("@TheatreName", Identity2.Text)
        cmd1.Parameters.AddWithValue("@Time", Button7.Text)
        cmd1.ExecuteReader()
        Session("textBoxValue2") = Request.QueryString().ToString()
        Session("textBoxValue3") = Identity1.Text
        Session("textBoxValue4") = Button1.Text
        Response.Redirect("Default8.aspx")
        con2.Close()
    End Sub
    Protected Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim ConnectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\wipro\App_Data\Database.mdf;Integrated Security=True;"
        Dim con2 As New SqlConnection(ConnectionString)
        con2.Open()
        Dim theQuery2 As String = "INSERT INTO  userinfo2(UserId,MovieName,TheatreName,Time_And_Date) VALUES (@LastName,@FirstName,@TheatreName,@Time)"
        Dim cmd1 As SqlCommand = New SqlCommand(theQuery2, con2)
        cmd1.Parameters.AddWithValue("@FirstName", Request.QueryString().ToString())
        cmd1.Parameters.AddWithValue("@LastName", Session("textBoxValue"))
        cmd1.Parameters.AddWithValue("@TheatreName", Identity2.Text)
        cmd1.Parameters.AddWithValue("@Time", Button8.Text)
        cmd1.ExecuteReader()
        Session("textBoxValue2") = Request.QueryString().ToString()
        Session("textBoxValue3") = Identity1.Text
        Session("textBoxValue4") = Button1.Text
        Response.Redirect("Default8.aspx")
        con2.Close()
    End Sub
    Protected Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim ConnectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\wipro\App_Data\Database.mdf;Integrated Security=True;"
        Dim con2 As New SqlConnection(ConnectionString)
        con2.Open()
        Dim theQuery2 As String = "INSERT INTO  userinfo2(UserId,MovieName,TheatreName,Time_And_Date) VALUES (@LastName,@FirstName,@TheatreName,@Time)"
        Dim cmd1 As SqlCommand = New SqlCommand(theQuery2, con2)
        cmd1.Parameters.AddWithValue("@FirstName", Request.QueryString().ToString())
        cmd1.Parameters.AddWithValue("@LastName", Session("textBoxValue"))
        cmd1.Parameters.AddWithValue("@TheatreName", Identity2.Text)
        cmd1.Parameters.AddWithValue("@Time", Button9.Text)
        cmd1.ExecuteReader()
        Session("textBoxValue2") = Request.QueryString().ToString()
        Session("textBoxValue3") = Identity1.Text
        Session("textBoxValue4") = Button1.Text
        Response.Redirect("Default8.aspx")
        con2.Close()
    End Sub
    Protected Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Dim ConnectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\wipro\App_Data\Database.mdf;Integrated Security=True;"
        Dim con2 As New SqlConnection(ConnectionString)
        con2.Open()
        Dim theQuery2 As String = "INSERT INTO  userinfo2(UserId,MovieName,TheatreName,Time_And_Date) VALUES (@LastName,@FirstName,@TheatreName,@Time)"
        Dim cmd1 As SqlCommand = New SqlCommand(theQuery2, con2)
        cmd1.Parameters.AddWithValue("@FirstName", Request.QueryString().ToString())
        cmd1.Parameters.AddWithValue("@LastName", Session("textBoxValue"))
        cmd1.Parameters.AddWithValue("@TheatreName", Identity2.Text)
        cmd1.Parameters.AddWithValue("@Time", Button10.Text)
        cmd1.ExecuteReader()
        Session("textBoxValue2") = Request.QueryString().ToString()
        Session("textBoxValue3") = Identity1.Text
        Session("textBoxValue4") = Button1.Text
        Response.Redirect("Default8.aspx")
        con2.Close()
    End Sub
    Protected Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Dim ConnectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\wipro\App_Data\Database.mdf;Integrated Security=True;"
        Dim con2 As New SqlConnection(ConnectionString)
        con2.Open()
        Dim theQuery2 As String = "INSERT INTO  userinfo2(UserId,MovieName,TheatreName,Time_And_Date) VALUES (@LastName,@FirstName,@TheatreName,@Time)"
        Dim cmd1 As SqlCommand = New SqlCommand(theQuery2, con2)
        cmd1.Parameters.AddWithValue("@FirstName", Request.QueryString().ToString())
        cmd1.Parameters.AddWithValue("@LastName", Session("textBoxValue"))
        cmd1.Parameters.AddWithValue("@TheatreName", Identity3.Text)
        cmd1.Parameters.AddWithValue("@Time", Button11.Text)
        cmd1.ExecuteReader()
        Session("textBoxValue2") = Request.QueryString().ToString()
        Session("textBoxValue3") = Identity1.Text
        Session("textBoxValue4") = Button1.Text
        Response.Redirect("Default8.aspx")
        con2.Close()
    End Sub
    Protected Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Dim ConnectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\wipro\App_Data\Database.mdf;Integrated Security=True;"
        Dim con2 As New SqlConnection(ConnectionString)
        con2.Open()
        Dim theQuery2 As String = "INSERT INTO  userinfo2(UserId,MovieName,TheatreName,Time_And_Date) VALUES (@LastName,@FirstName,@TheatreName,@Time)"
        Dim cmd1 As SqlCommand = New SqlCommand(theQuery2, con2)
        cmd1.Parameters.AddWithValue("@FirstName", Request.QueryString().ToString())
        cmd1.Parameters.AddWithValue("@LastName", Session("textBoxValue"))
        cmd1.Parameters.AddWithValue("@TheatreName", Identity3.Text)
        cmd1.Parameters.AddWithValue("@Time", Button12.Text)
        cmd1.ExecuteReader()
        Session("textBoxValue2") = Request.QueryString().ToString()
        Session("textBoxValue3") = Identity1.Text
        Session("textBoxValue4") = Button1.Text
        Response.Redirect("Default8.aspx")
        con2.Close()
    End Sub
    Protected Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Dim ConnectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\wipro\App_Data\Database.mdf;Integrated Security=True;"
        Dim con2 As New SqlConnection(ConnectionString)
        con2.Open()
        Dim theQuery2 As String = "INSERT INTO  userinfo2(UserId,MovieName,TheatreName,Time_And_Date) VALUES (@LastName,@FirstName,@TheatreName,@Time)"
        Dim cmd1 As SqlCommand = New SqlCommand(theQuery2, con2)
        cmd1.Parameters.AddWithValue("@FirstName", Request.QueryString().ToString())
        cmd1.Parameters.AddWithValue("@LastName", Session("textBoxValue"))
        cmd1.Parameters.AddWithValue("@TheatreName", Identity3.Text)
        cmd1.Parameters.AddWithValue("@Time", Button13.Text)
        cmd1.ExecuteReader()
        Session("textBoxValue2") = Request.QueryString().ToString()
        Session("textBoxValue3") = Identity1.Text
        Session("textBoxValue4") = Button1.Text
        Response.Redirect("Default8.aspx")
        con2.Close()
    End Sub
    Protected Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Dim ConnectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\wipro\App_Data\Database.mdf;Integrated Security=True;"
        Dim con2 As New SqlConnection(ConnectionString)
        con2.Open()
        Dim theQuery2 As String = "INSERT INTO  userinfo2(UserId,MovieName,TheatreName,Time_And_Date) VALUES (@LastName,@FirstName,@TheatreName,@Time)"
        Dim cmd1 As SqlCommand = New SqlCommand(theQuery2, con2)
        cmd1.Parameters.AddWithValue("@FirstName", Request.QueryString().ToString())
        cmd1.Parameters.AddWithValue("@LastName", Session("textBoxValue"))
        cmd1.Parameters.AddWithValue("@TheatreName", Identity3.Text)
        cmd1.Parameters.AddWithValue("@Time", Button14.Text)
        cmd1.ExecuteReader()
        Session("textBoxValue2") = Request.QueryString().ToString()
        Session("textBoxValue3") = Identity1.Text
        Session("textBoxValue4") = Button1.Text
        Response.Redirect("Default8.aspx")
        con2.Close()
    End Sub
    Protected Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Dim ConnectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\wipro\App_Data\Database.mdf;Integrated Security=True;"
        Dim con2 As New SqlConnection(ConnectionString)
        con2.Open()
        Dim theQuery2 As String = "INSERT INTO  userinfo2(UserId,MovieName,TheatreName,Time_And_Date) VALUES (@LastName,@FirstName,@TheatreName,@Time)"
        Dim cmd1 As SqlCommand = New SqlCommand(theQuery2, con2)
        cmd1.Parameters.AddWithValue("@FirstName", Request.QueryString().ToString())
        cmd1.Parameters.AddWithValue("@LastName", Session("textBoxValue"))
        cmd1.Parameters.AddWithValue("@TheatreName", Identity3.Text)
        cmd1.Parameters.AddWithValue("@Time", Button15.Text)
        cmd1.ExecuteReader()
        Session("textBoxValue2") = Request.QueryString().ToString()
        Session("textBoxValue3") = Identity1.Text
        Session("textBoxValue4") = Button1.Text
        Response.Redirect("Default8.aspx")
        con2.Close()
    End Sub
    Protected Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Dim ConnectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\wipro\App_Data\Database.mdf;Integrated Security=True;"
        Dim con2 As New SqlConnection(ConnectionString)
        con2.Open()
        Dim theQuery2 As String = "INSERT INTO  userinfo2(UserId,MovieName,TheatreName,Time_And_Date) VALUES (@LastName,@FirstName,@TheatreName,@Time)"
        Dim cmd1 As SqlCommand = New SqlCommand(theQuery2, con2)
        cmd1.Parameters.AddWithValue("@FirstName", Request.QueryString().ToString())
        cmd1.Parameters.AddWithValue("@LastName", Session("textBoxValue"))
        cmd1.Parameters.AddWithValue("@TheatreName", Identity4.Text)
        cmd1.Parameters.AddWithValue("@Time", Button16.Text)
        cmd1.ExecuteReader()
        Session("textBoxValue2") = Request.QueryString().ToString()
        Session("textBoxValue3") = Identity1.Text
        Session("textBoxValue4") = Button1.Text
        Response.Redirect("Default8.aspx")
        con2.Close()
    End Sub
    Protected Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Dim ConnectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\wipro\App_Data\Database.mdf;Integrated Security=True;"
        Dim con2 As New SqlConnection(ConnectionString)
        con2.Open()
        Dim theQuery2 As String = "INSERT INTO  userinfo2(UserId,MovieName,TheatreName,Time_And_Date) VALUES (@LastName,@FirstName,@TheatreName,@Time)"
        Dim cmd1 As SqlCommand = New SqlCommand(theQuery2, con2)
        cmd1.Parameters.AddWithValue("@FirstName", Request.QueryString().ToString())
        cmd1.Parameters.AddWithValue("@LastName", Session("textBoxValue"))
        cmd1.Parameters.AddWithValue("@TheatreName", Identity4.Text)
        cmd1.Parameters.AddWithValue("@Time", Button17.Text)
        cmd1.ExecuteReader()
        Session("textBoxValue2") = Request.QueryString().ToString()
        Session("textBoxValue3") = Identity1.Text
        Session("textBoxValue4") = Button1.Text
        Response.Redirect("Default8.aspx")
        con2.Close()
    End Sub
    Protected Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        Dim ConnectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\wipro\App_Data\Database.mdf;Integrated Security=True;"
        Dim con2 As New SqlConnection(ConnectionString)
        con2.Open()
        Dim theQuery2 As String = "INSERT INTO  userinfo2(UserId,MovieName,TheatreName,Time_And_Date) VALUES (@LastName,@FirstName,@TheatreName,@Time)"
        Dim cmd1 As SqlCommand = New SqlCommand(theQuery2, con2)
        cmd1.Parameters.AddWithValue("@FirstName", Request.QueryString().ToString())
        cmd1.Parameters.AddWithValue("@LastName", Session("textBoxValue"))
        cmd1.Parameters.AddWithValue("@TheatreName", Identity4.Text)
        cmd1.Parameters.AddWithValue("@Time", Button18.Text)
        cmd1.ExecuteReader()
        Session("textBoxValue2") = Request.QueryString().ToString()
        Session("textBoxValue3") = Identity1.Text
        Session("textBoxValue4") = Button1.Text
        Response.Redirect("Default8.aspx")
        con2.Close()
    End Sub
    Protected Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        Dim ConnectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\wipro\App_Data\Database.mdf;Integrated Security=True;"
        Dim con2 As New SqlConnection(ConnectionString)
        con2.Open()
        Dim theQuery2 As String = "INSERT INTO  userinfo2(UserId,MovieName,TheatreName,Time_And_Date) VALUES (@LastName,@FirstName,@TheatreName,@Time)"
        Dim cmd1 As SqlCommand = New SqlCommand(theQuery2, con2)
        cmd1.Parameters.AddWithValue("@FirstName", Request.QueryString().ToString())
        cmd1.Parameters.AddWithValue("@LastName", Session("textBoxValue"))
        cmd1.Parameters.AddWithValue("@TheatreName", Identity4.Text)
        cmd1.Parameters.AddWithValue("@Time", Button19.Text)
        cmd1.ExecuteReader()
        Session("textBoxValue2") = Request.QueryString().ToString()
        Session("textBoxValue3") = Identity1.Text
        Session("textBoxValue4") = Button1.Text
        Response.Redirect("Default8.aspx")
        con2.Close()
    End Sub
    Protected Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        Dim ConnectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\wipro\App_Data\Database.mdf;Integrated Security=True;"
        Dim con2 As New SqlConnection(ConnectionString)
        con2.Open()
        Dim theQuery2 As String = "INSERT INTO  userinfo2(UserId,MovieName,TheatreName,Time_And_Date) VALUES (@LastName,@FirstName,@TheatreName,@Time)"
        Dim cmd1 As SqlCommand = New SqlCommand(theQuery2, con2)
        cmd1.Parameters.AddWithValue("@FirstName", Request.QueryString().ToString())
        cmd1.Parameters.AddWithValue("@LastName", Session("textBoxValue"))
        cmd1.Parameters.AddWithValue("@TheatreName", Identity4.Text)
        cmd1.Parameters.AddWithValue("@Time", Button20.Text)
        cmd1.ExecuteReader()
        Session("textBoxValue2") = Request.QueryString().ToString()
        Session("textBoxValue3") = Identity1.Text
        Session("textBoxValue4") = Button1.Text
        Response.Redirect("Default8.aspx")
        con2.Close()
    End Sub
    Protected Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        Dim ConnectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\wipro\App_Data\Database.mdf;Integrated Security=True;"
        Dim con2 As New SqlConnection(ConnectionString)
        con2.Open()
        Dim theQuery2 As String = "INSERT INTO  userinfo2(UserId,MovieName,TheatreName,Time_And_Date) VALUES (@LastName,@FirstName,@TheatreName,@Time)"
        Dim cmd1 As SqlCommand = New SqlCommand(theQuery2, con2)
        cmd1.Parameters.AddWithValue("@FirstName", Request.QueryString().ToString())
        cmd1.Parameters.AddWithValue("@LastName", Session("textBoxValue"))
        cmd1.Parameters.AddWithValue("@TheatreName", Identity5.Text)
        cmd1.Parameters.AddWithValue("@Time", Button21.Text)
        cmd1.ExecuteReader()
        Session("textBoxValue2") = Request.QueryString().ToString()
        Session("textBoxValue3") = Identity1.Text
        Session("textBoxValue4") = Button1.Text
        Response.Redirect("Default8.aspx")
        con2.Close()
    End Sub
    Protected Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        Dim ConnectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\wipro\App_Data\Database.mdf;Integrated Security=True;"
        Dim con2 As New SqlConnection(ConnectionString)
        con2.Open()
        Dim theQuery2 As String = "INSERT INTO  userinfo2(UserId,MovieName,TheatreName,Time_And_Date) VALUES (@LastName,@FirstName,@TheatreName,@Time)"
        Dim cmd1 As SqlCommand = New SqlCommand(theQuery2, con2)
        cmd1.Parameters.AddWithValue("@FirstName", Request.QueryString().ToString())
        cmd1.Parameters.AddWithValue("@LastName", Session("textBoxValue"))
        cmd1.Parameters.AddWithValue("@TheatreName", Identity5.Text)
        cmd1.Parameters.AddWithValue("@Time", Button21.Text)
        cmd1.ExecuteReader()
        Session("textBoxValue2") = Request.QueryString().ToString()
        Session("textBoxValue3") = Identity1.Text
        Session("textBoxValue4") = Button1.Text
        Response.Redirect("Default8.aspx")
        con2.Close()
    End Sub
    Protected Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        Dim ConnectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\wipro\App_Data\Database.mdf;Integrated Security=True;"
        Dim con2 As New SqlConnection(ConnectionString)
        con2.Open()
        Dim theQuery2 As String = "INSERT INTO  userinfo2(UserId,MovieName,TheatreName,Time_And_Date) VALUES (@LastName,@FirstName,@TheatreName,@Time)"
        Dim cmd1 As SqlCommand = New SqlCommand(theQuery2, con2)
        cmd1.Parameters.AddWithValue("@FirstName", Request.QueryString().ToString())
        cmd1.Parameters.AddWithValue("@LastName", Session("textBoxValue"))
        cmd1.Parameters.AddWithValue("@TheatreName", Identity5.Text)
        cmd1.Parameters.AddWithValue("@Time", Button23.Text)
        cmd1.ExecuteReader()
        Session("textBoxValue2") = Request.QueryString().ToString()
        Session("textBoxValue3") = Identity1.Text
        Session("textBoxValue4") = Button1.Text
        Response.Redirect("Default8.aspx")
        con2.Close()
    End Sub
    Protected Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        Dim ConnectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\wipro\App_Data\Database.mdf;Integrated Security=True;"
        Dim con2 As New SqlConnection(ConnectionString)
        con2.Open()
        Dim theQuery2 As String = "INSERT INTO  userinfo2(UserId,MovieName,TheatreName,Time_And_Date) VALUES (@LastName,@FirstName,@TheatreName,@Time)"
        Dim cmd1 As SqlCommand = New SqlCommand(theQuery2, con2)
        cmd1.Parameters.AddWithValue("@FirstName", Request.QueryString().ToString())
        cmd1.Parameters.AddWithValue("@LastName", Session("textBoxValue"))
        cmd1.Parameters.AddWithValue("@TheatreName", Identity5.Text)
        cmd1.Parameters.AddWithValue("@Time", Button24.Text)
        cmd1.ExecuteReader()
        Session("textBoxValue2") = Request.QueryString().ToString()
        Session("textBoxValue3") = Identity1.Text
        Session("textBoxValue4") = Button1.Text
        Response.Redirect("Default8.aspx")
        con2.Close()
    End Sub
    Protected Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        Dim ConnectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\wipro\App_Data\Database.mdf;Integrated Security=True;"
        Dim con2 As New SqlConnection(ConnectionString)
        con2.Open()
        Dim theQuery2 As String = "INSERT INTO  userinfo2(UserId,MovieName,TheatreName,Time_And_Date) VALUES (@LastName,@FirstName,@TheatreName,@Time)"
        Dim cmd1 As SqlCommand = New SqlCommand(theQuery2, con2)
        cmd1.Parameters.AddWithValue("@FirstName", Request.QueryString().ToString())
        cmd1.Parameters.AddWithValue("@LastName", Session("textBoxValue"))
        cmd1.Parameters.AddWithValue("@TheatreName", Identity5.Text)
        cmd1.Parameters.AddWithValue("@Time", Button25.Text)
        cmd1.ExecuteReader()
        Session("textBoxValue2") = Request.QueryString().ToString()
        Session("textBoxValue3") = Identity1.Text
        Session("textBoxValue4") = Button1.Text
        Response.Redirect("Default8.aspx")
        con2.Close()
    End Sub

End Class
