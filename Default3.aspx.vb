
Partial Class Default3
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub
    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles But.Click
        Response.Redirect("Default4.aspx?" + but.Text)
    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Response.Redirect("Default4.aspx?" + Button6.Text)
    End Sub
    Protected Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Response.Redirect("Default4.aspx?" + Button3.Text)
    End Sub
    Protected Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Response.Redirect("Default4.aspx?" + Button4.Text)
    End Sub
    Protected Sub but_Click(sender As Object, e As EventArgs) Handles but.Click

    End Sub
    Protected Sub Button1_Click1(sender As Object, e As EventArgs) Handles Button1.Click
        Response.Redirect("Default4.aspx?" + Button1.Text)
    End Sub
End Class
