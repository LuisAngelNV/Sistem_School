Imports System.Data.SqlClient
Public Class SERIALIZACION
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            Dim cmd As New SqlCommand
            abrir()
            cmd = New SqlCommand("serializacion_insertar", connection)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@Serie", txtserie.Text)
            cmd.Parameters.AddWithValue("@Numero_inicio", txtnumerodeinicio.Text)
            cmd.Parameters.AddWithValue("@Numero_fin", txtnumerodefin.Text)
            cmd.Parameters.AddWithValue("@Tipo_De_comprobante", txtcomprobante.Text)
            cmd.ExecuteNonQuery()
            cerrar()
            Listar()
            Panel2.Visible = False
        Catch ex As Exception
        End Try

    End Sub

    Private Sub BTBGuardarCambios_Click(sender As Object, e As EventArgs) Handles BTBGuardarCambios.Click
        Try
            Dim cmd As New SqlCommand
            abrir()
            cmd = New SqlCommand("serializacion_editar", connection)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@serie", txtserie.Text)
            cmd.Parameters.AddWithValue("@numero_inicio", txtnumerodeinicio.Text)
            cmd.Parameters.AddWithValue("@numero_fin", txtnumerodefin.Text)
            cmd.Parameters.AddWithValue("@tipo_de_comprobante", txtcomprobante.Text)
            cmd.Parameters.AddWithValue("@id_serializacion", datalistado.SelectedCells.Item(1).Value)
            cmd.ExecuteNonQuery()
            cerrar()
            Listar()
            Panel2.Visible = False
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Panel2.Visible = True
        btnGuardar.Visible = True
        BTBGuardarCambios.Visible = False
        limpiar()
    End Sub

    Private Sub VolverToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VolverToolStripMenuItem.Click
        Panel2.Visible = False
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim result As DialogResult
        Dim cmd As SqlCommand
        result = MessageBox.Show("¿Realmente quieres elimina a este alumno?", "Eliminando Registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If result = DialogResult.OK Then
            Try
                For Each row As DataGridViewRow In datalistado.SelectedRows
                    Dim onekey As Integer = Convert.ToInt32(row.Cells("id_serializacion").Value)
                    Try
                        abrir()
                        cmd = New SqlCommand("serializacion_eliminar", connection)
                        cmd.CommandType = 4
                        cmd.Parameters.AddWithValue("@id_serializacion", onekey)
                        cmd.ExecuteNonQuery()


                    Catch ex As Exception : MsgBox(ex.Message)

                    End Try
                    cerrar()
                Next
                Call Listar()

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        Else
            MessageBox.Show("Cancelado eliminación de registro", "Eliminando Registro", MessageBoxButtons.OK)

        End If
    End Sub

    Private Sub SERIALIZACION_Load(sender As Object, e As EventArgs) Handles Me.Load
        Panel2.Visible = False
        Listar()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
        Dispose()

    End Sub

    'Sub procesos
    Sub Listar()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            abrir()
            da = New SqlDataAdapter("serializacion_mostrar_tipo_de_docuemntos_para_insertar_estos_mismos", connection)
            da.Fill(dt)
            datalistado.DataSource = dt
            cerrar()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Try
            datalistado.Columns(1).Visible = False
            datalistado.Columns(3).Width = 120
            datalistado.Columns(5).Width = 120
            datalistado.Columns(6).Width = 120
        Catch ex As Exception

        End Try
        Me.datalistado.EnableHeadersVisualStyles = False

        ' estilo para las cabeceras
        Dim styCabeceras As DataGridViewCellStyle = New DataGridViewCellStyle()
        styCabeceras.BackColor = Color.White
        styCabeceras.ForeColor = Color.Black
        styCabeceras.Font = New Font("Segoe UI", 10, FontStyle.Regular Or FontStyle.Bold)

        ' Asignar estilo al grid
        Me.datalistado.ColumnHeadersDefaultCellStyle = styCabeceras
    End Sub

    Sub limpiar()
        txtserie.Clear()
        txtnumerodeinicio.Clear()
        txtnumerodefin.Clear()
        txtcomprobante.Clear()

    End Sub

    Private Sub datalistado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellContentClick

    End Sub

    Private Sub datalistado_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellDoubleClick
        Panel2.Visible = True
        Try
            txtserie.Text = datalistado.SelectedCells.Item(2).Value
            txtnumerodeinicio.Text = datalistado.SelectedCells.Item(3).Value
            txtnumerodefin.Text = datalistado.SelectedCells.Item(4).Value
            txtcomprobante.Text = datalistado.SelectedCells.Item(5).Value
            btnGuardar.Visible = False
            BTBGuardarCambios.Visible = True
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtnumerodeinicio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnumerodeinicio.KeyPress
        numeros_decimales(txtnumerodeinicio, e)
    End Sub

    Sub numeros_decimales(ByVal BoxText As Windows.Forms.TextBox, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "." And Not BoxText.Text.IndexOf(".") Then
            e.Handled = True
        ElseIf e.KeyChar = "," Then
            e.Handled = True
        ElseIf e.KeyChar = "." Then
            e.Handled = True
        Else
            e.Handled = True
        End If

    End Sub

    Private Sub txtnumerodefin_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnumerodefin.KeyPress
        numeros_decimales(txtnumerodefin, e)
    End Sub
End Class