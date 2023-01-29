Public Class LOGIN
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub tbUsuario_Click(sender As Object, e As EventArgs) Handles tbUsuario.Click
        tbUsuario.Text = ""
        tbUsuario.Focus()
    End Sub

    Private Sub tb_Password_Click(sender As Object, e As EventArgs) Handles tb_Password.Click
        tb_Password.Text = ""
        tb_Password.Focus()
    End Sub

    Private Sub LOGIN_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
