Imports System.Data.SqlClient

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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnAcceder.Click
        CargarUsuario()
        If datalistado.RowCount > 0 Then
            Dispose()
            MenuPrincipalMatriculas.ShowDialog()
        Else
            MessageBox.Show("Verificar datos de usurio o cantraseña", "Control de aaceso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Sub CargarUsuario()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            abrir()
            da = New SqlDataAdapter("validar_usuario", connection)
            da.SelectCommand.CommandType = 4
            da.SelectCommand.Parameters.AddWithValue("@usuario", tbUsuario.Text)
            da.SelectCommand.Parameters.AddWithValue("@password", tb_Password.Text)
            'Pasar la informacion de los ttbUsuario, tb_Passwors
            da.Fill(dt)
            datalistado.DataSource = dt
            cerrar()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

End Class
