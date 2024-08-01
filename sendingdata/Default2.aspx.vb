
Partial Class Default2
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Label1.Text = "Your Name is: " + Request.QueryString("Name")
        Label2.Text = "Your Password is: " + Request.QueryString("Password")

    End Sub
End Class
