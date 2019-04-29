
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration


Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub

    Private Function AddWithValue(v As String, text As String) As Object
        Throw New NotImplementedException()
    End Function
    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ConnectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\wipro\App_Data\Database.mdf;Integrated Security=True;"
        Dim Con As New SqlConnection(ConnectionString)
        Con.Open()
        If username.Text = "" Or TextBox2.Text = "" Then
            MsgBox("Please fill-up all fields!", MsgBoxStyle.Exclamation, "Add New Customer!")
        Else
            Dim theQuery As String = "SELECT * FROM userinfo WHERE Username=@FirstName AND Password=@LastName"
            Dim cmd1 As SqlCommand = New SqlCommand(theQuery, Con)
            cmd1.Parameters.AddWithValue("@FirstName", username.Text)
            cmd1.Parameters.AddWithValue("@LastName", TextBox2.Text)
            Using reader As SqlDataReader = cmd1.ExecuteReader()
                If reader.HasRows Then
                    ' User already exist
                    Dim id2 As Int16
                    reader.Close()
                    Dim id As String = "SELECT Id FROM userinfo WHERE Username=@FirstName AND Password=@LastName"
                    Dim cmd2 As SqlCommand = New SqlCommand(id, Con)
                    cmd2.Parameters.AddWithValue("@FirstName", username.Text)
                    cmd2.Parameters.AddWithValue("@LastName", TextBox2.Text)
                    Using rdr As SqlClient.SqlDataReader = cmd2.ExecuteReader()
                        While rdr.Read
                            id2 = rdr("Id")
                            Session("textBoxValue") = id2
                        End While
                    End Using
                    Response.Redirect("Default3.aspx")
                Else
                    MsgBox("user not found!", MsgBoxStyle.Information, "sign up")
                End If
            End Using
            Con.Close()
        End If
    End Sub
    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Response.Redirect("Default2.aspx")
    End Sub
    Protected Sub username_TextChanged(sender As Object, e As EventArgs) Handles username.TextChanged

    End Sub
End Class
