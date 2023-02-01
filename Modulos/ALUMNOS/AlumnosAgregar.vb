Imports System.Data.SqlClient

Public Class AlumnosAgregar
    'Declaración de variables
    Dim id_alumno As Integer
    Dim estado As String

    Sub buscar()
        Dim dt As New DataTable
        Dim de As New SqlDataAdapter
        Try
            abrir()
            de = New SqlDataAdapter("alumno_buscar", connection)
            de.SelectCommand.CommandType = 4
            de.SelectCommand.Parameters.AddWithValue("@letra", tbBuscarUsuario.Text)
            de.Fill(dt)
            datalistado.DataSource = dt
            cerrar()

            Multilinea(datalistado)
            datalistado.Columns(1).Visible = True

            For Each row As DataGridViewRow In datalistado.Rows
                If row.Cells("Estado").Value = "ELIMINADO" Then
                    row.DefaultCellStyle.Font = New Font("Segoe UI", 10, FontStyle.Strikeout Or FontStyle.Bold)
                    row.DefaultCellStyle.BackColor = Color.Red
                End If
            Next


        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            Dim cmd As New SqlCommand
            abrir()
            cmd = New SqlCommand("alumnos_insertar", connection)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@ap_paterno", txt_paterno.Text)
            cmd.Parameters.AddWithValue("@ap_materno ", txt_Materno.Text)
            cmd.Parameters.AddWithValue("@nombre", txt_nombre.Text)
            cmd.Parameters.AddWithValue("@curp", txt_Curp.Text)
            cmd.Parameters.AddWithValue("@email", txt_email.Text)
            cmd.Parameters.AddWithValue("@estado", "ACTIVO")
            cmd.ExecuteNonQuery()
            cerrar()
            Mostrar()
            Panel4.Visible = False

        Catch ex As Exception : MsgBox(ex.Message)

        End Try
        txt_Curp.Text = ""
        txt_paterno.Text = ""
        txt_nombre.Text = ""
    End Sub

    Sub Mostrar()
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter
        Try
            abrir()
            da = New SqlDataAdapter("alumnos_mostrar", connection)
            da.Fill(dt)
            datalistado.DataSource = dt
            cerrar()
            Multilinea(datalistado)
            datalistado.Columns(1).Visible = True

            For Each row As DataGridViewRow In datalistado.Rows
                If row.Cells("Estado").Value = "ELIMINADO" Then
                    row.DefaultCellStyle.Font = New Font("Segoe UI", 10, FontStyle.Strikeout Or FontStyle.Bold)
                    row.DefaultCellStyle.BackColor = Color.Red
                End If
            Next

        Catch ex As Exception : MsgBox(ex.Message)

        End Try
    End Sub

    Sub restaurar_alumnos()
        Dim result As DialogResult

        result = MessageBox.Show("Este alumno se ha eliminado. ¿Desea volver a habilitarlo?", "Restauración de Alumno", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If result = DialogResult.OK Then
            Dim cmd As SqlCommand
            Try
                For Each row As DataGridViewRow In datalistado.SelectedRows
                    Dim IdAlumnoSeleccionado As Integer = Convert.ToInt32(row.Cells("id_alumno").Value)
                    Try
                        abrir()
                        cmd = New SqlCommand("alumno_restaurar", connection)
                        cmd.CommandType = 4
                        cmd.Parameters.AddWithValue("@id_alumno", IdAlumnoSeleccionado)
                        cmd.ExecuteNonQuery()
                        cerrar()

                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                    End Try
                Next

                Call Mostrar()
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub AlumnosAgregar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Mostrar()
        Panel4.Visible = False
        tbBuscarUsuario.Text = "Buscar Alumno"
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        Panel4.Visible = True
        txt_paterno.Clear()
        txt_Materno.Clear()
        txt_nombre.Clear()
        txt_email.Clear()
        txt_Curp.Clear()
        btnGuardar.Visible = True
        BTBGuardarCambios.Visible = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Panel4.Visible = False
    End Sub

    Private Sub tbBuscarUsuario_TextChanged(sender As Object, e As EventArgs) Handles tbBuscarUsuario.TextChanged
        If tbBuscarUsuario.Text <> "" And tbBuscarUsuario.Text <> "Buscar Alumno" Then

        End If
        buscar()
    End Sub

    Private Sub BTBGuardarCambios_Click(sender As Object, e As EventArgs) Handles BTBGuardarCambios.Click
        Try
            Dim cmd As New SqlCommand
            abrir()
            cmd = New SqlCommand("alumnos_editar", connection)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@id_alumno", id_alumno)
            cmd.Parameters.AddWithValue("@ap_paterno", txt_paterno.Text)
            cmd.Parameters.AddWithValue("@ap_materno ", txt_Materno.Text)
            cmd.Parameters.AddWithValue("@nombre", txt_nombre.Text)
            cmd.Parameters.AddWithValue("@curp", txt_Curp.Text)
            cmd.Parameters.AddWithValue("@email", txt_email.Text)
            cmd.ExecuteNonQuery()
            BTBGuardarCambios.Visible = True
            cerrar()
            Mostrar()
            Panel4.Visible = False

        Catch ex As Exception : MsgBox(ex.Message)

        End Try
        txt_Curp.Text = ""
        txt_paterno.Text = ""
        txt_nombre.Text = ""
    End Sub

    Private Sub datalistado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellContentClick

    End Sub

    Private Sub datalistado_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellDoubleClick
        Try
            id_alumno = datalistado.SelectedCells.Item(1).Value
            txt_paterno.Text = datalistado.SelectedCells.Item(2).Value
            txt_Materno.Text = datalistado.SelectedCells.Item(3).Value
            txt_nombre.Text = datalistado.SelectedCells.Item(4).Value
            txt_Curp.Text = datalistado.SelectedCells.Item(5).Value
            txt_email.Text = datalistado.SelectedCells.Item(6).Value
            estado = datalistado.SelectedCells.Item(7).Value
            If estado = "ELIMINADO" Then
                restaurar_alumnos()
            Else
                Panel4.Visible = True
            End If
            btnGuardar.Visible = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub datalistado_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellClick
        If e.ColumnIndex = Me.datalistado.Columns.Item("Eli").Index Then
            Dim result As DialogResult
            result = MessageBox.Show("¿Realmente quieres elimina a este alumno?", "Eliminando Registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If result = DialogResult.OK Then
                Dim cmd As SqlCommand
                Try
                    For Each row As DataGridViewRow In datalistado.SelectedRows
                        Dim IdAlumnoSeleccionado As Integer = Convert.ToInt32(row.Cells("id_alumno").Value)
                        Try
                            abrir()
                            cmd = New SqlCommand("alumno_eliminar", connection)
                            cmd.CommandType = 4
                            cmd.Parameters.AddWithValue("@id_alumno", IdAlumnoSeleccionado)
                            cmd.ExecuteNonQuery()
                            cerrar()

                        Catch ex As Exception
                            MessageBox.Show(ex.Message)

                        End Try
                    Next
                    Call Mostrar()

                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try

            End If


        End If
    End Sub

    Private Sub RestaurarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RestaurarToolStripMenuItem.Click
        Try
            id_alumno = datalistado.SelectedCells.Item(1).Value
            txt_paterno.Text = datalistado.SelectedCells.Item(2).Value
            txt_Materno.Text = datalistado.SelectedCells.Item(3).Value
            txt_nombre.Text = datalistado.SelectedCells.Item(4).Value
            txt_Curp.Text = datalistado.SelectedCells.Item(5).Value
            txt_email.Text = datalistado.SelectedCells.Item(6).Value
            estado = datalistado.SelectedCells.Item(7).Value
            If estado = "ELIMINADO" Then
                restaurar_alumnos()
            End If
            btnGuardar.Visible = False
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub tbBuscarUsuario_Click(sender As Object, e As EventArgs) Handles tbBuscarUsuario.Click
        tbBuscarUsuario.SelectAll()
    End Sub
End Class