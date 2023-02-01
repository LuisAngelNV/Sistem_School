Imports System.Data.SqlClient
Public Class UsuariosOk
    Private Sub UsuariosOk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel4.Visible = False
        Mostrar()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Panel4.Visible = True
        txtnombre.Clear()
        txtContraseña.Clear()
        txtUsuario.Clear()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub GuardarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        Try
            Dim cmd As New SqlCommand
            abrir()
            cmd = New SqlCommand("insertar_usuario", connection)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@nombre", txtnombre.Text)
            cmd.Parameters.AddWithValue("@usuario", txtUsuario.Text)
            cmd.Parameters.AddWithValue("@password", txtContraseña.Text)
            cmd.ExecuteNonQuery()
            cerrar()
            Mostrar()
            Panel4.Visible = False

        Catch ex As Exception : MsgBox(ex.Message)

        End Try
        txtContraseña.Text = ""
        txtnombre.Text = ""
        txtUsuario.Text = ""


    End Sub

    Sub Mostrar()
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter
        Try
            abrir()
            da = New SqlDataAdapter("mostrar_usuarios", connection)
            da.Fill(dt)
            datalistado.DataSource = dt
            cerrar()
            datalistado.Columns(1).Visible = False
            'Mandar a llamar al elemento que modiica la tabla modelo(tabla en la que se aplicara)
            Multilinea(datalistado)

        Catch ex As Exception : MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub datalistado_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellDoubleClick

        Try
            Panel4.Visible = True
            btnGuardar.Visible = False
            BTBGuardarCambios.Visible = True
            IdUsuario.Text = datalistado.SelectedCells.Item(1).Value
            txtnombre.Text = datalistado.SelectedCells.Item(2).Value
            txtUsuario.Text = datalistado.SelectedCells.Item(3).Value
            txtContraseña.Text = datalistado.SelectedCells.Item(4).Value
        Catch ex As Exception

        End Try

    End Sub

    Private Sub GuardarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles BTBGuardarCambios.Click
        Try
            Dim cmd As New SqlCommand
            abrir()
            cmd = New SqlCommand("editar_usuario", connection)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@id_usuario", IdUsuario.Text)
            cmd.Parameters.AddWithValue("@nombre", txtnombre.Text)
            cmd.Parameters.AddWithValue("@usuario", txtUsuario.Text)
            cmd.Parameters.AddWithValue("@password", txtContraseña.Text)
            cmd.ExecuteNonQuery()
            cerrar()
            Mostrar()
            Panel4.Visible = False

        Catch ex As Exception : MsgBox(ex.Message)

        End Try
        txtContraseña.Text = ""
        txtnombre.Text = ""
        txtUsuario.Text = ""
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Panel4.Visible = False
    End Sub

    Private Sub datalistado_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellClick

    End Sub

    Sub buscar()
        Dim dt As New DataTable
        Dim de As New SqlDataAdapter
        Try
            abrir()
            de = New SqlDataAdapter("buscar_Usuario", connection)
            de.SelectCommand.CommandType = 4
            de.SelectCommand.Parameters.AddWithValue("@letra", tbBuscarUsuario.Text)
            de.Fill(dt)
            datalistado.DataSource = dt
            cerrar()
        Catch ex As Exception : MsgBox(ex.Message)

        End Try
    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles tbBuscarUsuario.TextChanged
        buscar()
    End Sub

    Private Sub datalistado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellContentClick
        If e.ColumnIndex = Me.datalistado.Columns.Item("Eli").Index Then
            Dim resultado As DialogResult
            resultado = MessageBox.Show("¿Realmnete desea eliminar este usuario?", "Eliminando registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If resultado = DialogResult.OK Then
                Try
                    Dim cmd As New SqlCommand
                    abrir()
                    cmd = New SqlCommand("eliminar_usuario ", connection)
                    cmd.CommandType = 4
                    cmd.Parameters.AddWithValue("@idUsuario", datalistado.SelectedCells.Item(1).Value)
                    cmd.ExecuteNonQuery()
                    cerrar()
                    Mostrar()

                Catch ex As Exception : MsgBox(ex.Message)
                End Try
            End If
        Else
            MessageBox.Show("Cancelando eliminacion de este usuario", "Eliminando registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)

        End If
    End Sub
End Class