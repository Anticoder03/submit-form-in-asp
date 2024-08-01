
Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        Response.Redirect("./Default2.aspx?Name=" + TextBox1.Text + "&Password=" + TextBox2.Text)
    End Sub
End Class
