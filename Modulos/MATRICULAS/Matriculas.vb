Imports System.Data.SqlClient

Public Class Matriculas
    'vaiables
    Dim idAlumno As Integer
    Dim idGrado As Integer
    Dim LocacionPanelMatriculasX As Integer
    Dim LocacionPanelMatriculasy As Integer
    Dim TamañoPanelMatriculasX As Integer
    Dim TamañoPanelMatriculasy As Integer

    'Procesos
    Sub Mostrar_numero_de_recibo()
        Buscar_tipo_de_docyemnto_para_instertar_matriculas()
    End Sub
    Sub Buscar_tipo_de_docyemnto_para_instertar_matriculas()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            abrir()
            da = New SqlDataAdapter("serializacion_Buscar_tipo_de_documentos_para_insertar_en_matriculas", connection)
            da.SelectCommand.CommandType = 4
            da.SelectCommand.Parameters.AddWithValue("@Tipo_De_comprobante", txtComprobante.Text)
            da.Fill(dt)
            cerrar()
            txtNumeroDeRecibo.Text = dt.Rows(0)(4).ToString()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub CargarGRADOS()
        Dim da As SqlDataAdapter
        Dim dt As New DataTable
        Try
            abrir()
            da = New SqlDataAdapter("mostrar_GRADOS", connection)
            da.Fill(dt)
            txtGrado.DisplayMember = "Grado"
            txtGrado.ValueMember = "Grado"
            txtGrado.DataSource = dt

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub mostrar_COSTO_MATRICULA()
        Dim importe As Double
        Dim com As New SqlCommand("mostrar_Precio_de_MATRICULA", connection)
        com.CommandType = 4
        com.Parameters.AddWithValue("@Grado", txtGrado.Text)
        Try
            abrir()
            importe = com.ExecuteScalar()
            cerrar()
            txtCostoMastriculas.Text = importe
        Catch ex As Exception

        End Try
    End Sub

    Sub mostrar_SECCIONES()
        Dim da As SqlDataAdapter
        Dim dt As New DataTable
        Try
            abrir()
            da = New SqlDataAdapter("mostrar_SECCIONES", connection)
            da.Fill(dt)
            txtSeccion.DisplayMember = "Seccion"
            txtSeccion.ValueMember = "Seccion"
            txtSeccion.DataSource = dt

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub mostrar_HORARIOS()
        Dim da As SqlDataAdapter
        Dim dt As New DataTable
        Try
            abrir()
            da = New SqlDataAdapter("mostrar_HORARIOS", connection)
            da.Fill(dt)
            txtHorario.DisplayMember = "Horario"
            txtHorario.ValueMember = "Horario"
            txtHorario.DataSource = dt

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    'Mostrar
    Sub serializacion_Buscar_tipo_de_documentos_para_insertar_en_matriculas()
        Dim dtComprobante As New DataTable
        Dim da As SqlDataAdapter
        Try
            da = New SqlDataAdapter("serializacion_mostrar_tipo_de_documentos_para_insertar_en_matriculas01", connection)
            da.Fill(dtComprobante)
            txtComprobante.DisplayMember = "COMPROBANTE"
            txtComprobante.ValueMember = "id_serializacion"
            txtComprobante.DataSource = dtComprobante
            cerrar()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub Buscar_Alumno()
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter

        Try
            abrir()
            da = New SqlDataAdapter("alumno_buscar", connection)
            da.SelectCommand.CommandType = 4
            da.SelectCommand.Parameters.AddWithValue("@letra", txtBuscar.Text)
            da.Fill(dt)
            DataListadoAlumnos.DataSource = dt
            DataListadoAlumnos.Columns(0).Visible = False
            DataListadoAlumnos.Columns(1).Visible = False
            DataListadoAlumnos.Columns(2).Visible = False
            DataListadoAlumnos.Columns(3).Visible = False
            DataListadoAlumnos.Columns(4).Visible = False
            DataListadoAlumnos.Columns(5).Visible = False
            DataListadoAlumnos.Columns(6).Visible = False
            DataListadoAlumnos.Columns(7).Visible = False
            DataListadoAlumnos.Columns(8).Visible = DataListadoAlumnos.Width

        Catch ex As Exception

        End Try
    End Sub

    Sub mostrar_Precio_de_PENSION()
        Dim importe As Double
        Dim com As New SqlCommand("mostrar_Precio_de_PENSION", connection)
        com.CommandType = 4
        com.Parameters.AddWithValue("@Grado", txtGrado.Text)
        Try
            abrir()
            importe = com.ExecuteScalar()
            cerrar()
            txtCostoPension.Text = importe
        Catch ex As Exception

        End Try
    End Sub

    Sub INSERTAR_MATRICULA()
        Try
            Dim cmd As New SqlCommand
            abrir()
            cmd = New SqlCommand("insertar_MATRICULA", connection)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@Grado", txtGrado.Text)
            cmd.Parameters.AddWithValue("@Descripcion", "MATRICULA")
            cmd.Parameters.AddWithValue("@Fecha", TXTFECHA.Value)
            cmd.Parameters.AddWithValue("@N_recibo", txtNumeroDeRecibo.Text)
            cmd.Parameters.AddWithValue("@Id_alumno", idAlumno)
            cmd.Parameters.AddWithValue("@Saldo", txtSaldo.Text)
            cmd.Parameters.AddWithValue("@Estado", "DEBE")
            cmd.Parameters.AddWithValue("@Pension", txtCostoPension.Text * 1)

            cmd.Parameters.AddWithValue("@Seccion", txtSeccion.Text)
            cmd.Parameters.AddWithValue("@Numero_de_pension", "MATRICULA")
            cmd.Parameters.AddWithValue("@Tipo_de_Institucion", "COLEGIO CEBA")
            cmd.Parameters.AddWithValue("@Estado_de_matricula", "DEBE")
            cmd.Parameters.AddWithValue("@Saldo_matricula", txtCostoMastriculas.Text * 1)
            cmd.Parameters.AddWithValue("@Horario", txtHorario.Text)
            cmd.Parameters.AddWithValue("@Observacion", "_")
            cmd.Parameters.AddWithValue("@Prioridad", 0)
            cmd.ExecuteNonQuery()
            cerrar()
            MessageBox.Show("Datos guardados correctamente", "Guardando", MessageBoxButtons.OK, MessageBoxIcon.Information)
            PanelFormulario.Visible = False
        Catch ex As Exception

        End Try
    End Sub

    Sub actualizar_serie_mas_uno()
        Try
            Dim cmd As New SqlCommand
            abrir()
            cmd = New SqlCommand("actualizar_serializacion_mas_uno", connection)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@idserie", datalistadoNumero_de_recibo.SelectedCells.Item(4).Value)
            cmd.Parameters.AddWithValue("@numerofin", datalistadoNumero_de_recibo.SelectedCells.Item(3).Value)
            cmd.ExecuteNonQuery()
            cerrar()
        Catch ex As Exception

        End Try
    End Sub

    Sub insertar_detalle_cobro()
        Try
            Dim cmd As New SqlCommand
            abrir()
            cmd = New SqlCommand("insertar_detalles_de_cobro", connection)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@Id_Alumno", idAlumno)
            cmd.Parameters.AddWithValue("@Pago_realizado", txt_cantidad_de_importe.Text)
            cmd.Parameters.AddWithValue("@Fecha_que_pago", Now())
            cmd.Parameters.AddWithValue("@Nro_comprobante", txtNumeroDeRecibo.Text)
            cmd.Parameters.AddWithValue("@Grado", "Grado " & txtGrado.Text)
            cmd.Parameters.AddWithValue("@Detalle", "PAGO DE MATRICULA")
            cmd.Parameters.AddWithValue("@Id_usuario", 1)
            cmd.ExecuteNonQuery()
            cerrar()

        Catch ex As Exception

        End Try
    End Sub

    Sub mostrar_MATRICULAS_YA_HECHAS()
        Dim importe As Double
        Dim com As New SqlCommand("mostrar_MATRICULAS_YA_HECHAS", connection)
        com.CommandType = 4
        com.Parameters.AddWithValue("@Grado", txtGrado.Text)
        com.Parameters.AddWithValue("@Id_alumno", idAlumno)
        Try
            abrir()
            importe = com.ExecuteScalar()
            cerrar()
            idGrado = importe

        Catch ex As Exception

        End Try
    End Sub

    ' eventos

    Private Sub Matriculas_Load(sender As Object, e As EventArgs) Handles Me.Load
        LocacionPanelMatriculasX = PanelFormulario.Location.X
        LocacionPanelMatriculasy = PanelFormulario.Location.Y
        TamañoPanelMatriculasX = PanelFormulario.Width
        TamañoPanelMatriculasy = PanelFormulario.Height
        serializacion_Buscar_tipo_de_documentos_para_insertar_en_matriculas()
        DataListadoAlumnos.Size = New Point(PanelFormulario.Width, PanelFormulario.Height)
        DataListadoAlumnos.Location = New Point(LocacionPanelMatriculasX, LocacionPanelMatriculasy)
        PanelPrincipal.Location = New Point((Width - PanelPrincipal.Width) / 2, (Height - PanelPrincipal.Height) / 2)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
        Dispose()
    End Sub


    Private Sub txtBuscaralumno_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        If txtBuscar.Text = "" Then
            lblBuscarAlumno.Visible = True
        ElseIf txtBuscar.Text <> "" Then
            lblBuscarAlumno.Visible = False
            DataListadoAlumnos.Visible = True
            Buscar_Alumno()
        End If

    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        SERIALIZACION.ShowDialog()
    End Sub

    Private Sub ComboBox4_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles txtComprobante.SelectedIndexChanged
        Mostrar_numero_de_recibo()
    End Sub

    Private Sub DataListadoAlumnos_CellClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DataListadoAlumnos.CellClick
        Try
            idAlumno = DataListadoAlumnos.SelectedCells.Item(1).Value
            txtBuscar.Text = DataListadoAlumnos.SelectedCells.Item(8).Value
            DataListadoAlumnos.Visible = False
            CargarGRADOS()
            mostrar_SECCIONES()
            mostrar_HORARIOS()
            mostrar_COSTO_MATRICULA()
            mostrar_Precio_de_PENSION()
            mostrar_MATRICULAS_YA_HECHAS()
            PanelFormulario.Visible = True

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub GuardarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarToolStripMenuItem.Click
        mostrar_MATRICULAS_YA_HECHAS()
        If idGrado = 0 Then
            Dim nCuotas As Integer
            nCuotas = TXTCANTIDAD_DE_CUOTAS.Text * 1
            Dim x As Integer

            For x = 1 To nCuotas
                Try
                    Dim cmd As SqlCommand
                    abrir()
                    cmd = New SqlCommand("insertar_MATRICULA", connection)
                    cmd.Parameters.AddWithValue("@grado", txtGrado.Text)
                    cmd.Parameters.AddWithValue("@Descripcion", "PENSION" & " " & x)
                    cmd.Parameters.AddWithValue("@Fecha", DateAdd(DateInterval.Month, x, TXTFECHA.Value))
                    cmd.Parameters.AddWithValue("@@N_recibo", "-")
                    cmd.Parameters.AddWithValue("@Id_alumno", idAlumno)
                    cmd.Parameters.AddWithValue("@Saldo", txtCostoPension.Text * 1)
                    cmd.Parameters.AddWithValue("@Estado", "DEBE")
                    cmd.Parameters.AddWithValue("@Pension", txtCostoPension.Text * 1)
                    cmd.Parameters.AddWithValue("@Seccion", txtSeccion.Text)
                    cmd.Parameters.AddWithValue("@Numero_de_pension", "Pension" & " " & x)
                    cmd.Parameters.AddWithValue("@Tipo_de_Institucion", "Colegio LUGEL")
                    cmd.Parameters.AddWithValue("@Estado_de_matricula", "")
                    cmd.Parameters.AddWithValue("@Saldo_matricula", 0)
                    cmd.Parameters.AddWithValue("@horario", txtHorario.Text)
                    cmd.Parameters.AddWithValue("@Observacion", "-")
                    cmd.Parameters.AddWithValue("@Prioridad", x)
                    cmd.ExecuteNonQuery()
                    cerrar()
                Catch ex As Exception

                End Try
            Next
            INSERTAR_MATRICULA()
            actualizar_serie_mas_uno()
            insertar_detalle_cobro()
        Else
            PanelMAtricula_ya_hecha.Visible = True
        PanelMAtricula_ya_hecha.Location = New Point(PanelFormulario.Location.X, PanelFormulario.Location.Y)
        PanelMAtricula_ya_hecha.Size = New Point(PanelFormulario.Size.Width, PanelFormulario.Size.Height)
        PanelFormulario.Visible = False
        DataListadoAlumnos.BringToFront()
        End If
    End Sub

    Private Sub txtGrado_SelectedIndexChanged(sender As Object, e As EventArgs)
        mostrar_COSTO_MATRICULA()
        mostrar_Precio_de_PENSION()
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        PanelOBSERVACION.Visible = True
        PanelFormulario.Visible = False
        txtObservacion.Clear()

        txtObservacion.Focus()
        PanelOBSERVACION.Location = New Point(LocacionPanelMatriculasX, LocacionPanelMatriculasy)
        PanelOBSERVACION.Size = New Point(TamañoPanelMatriculasX, TamañoPanelMatriculasy)

    End Sub

    Private Sub txt_cantidad_de_importe_TextChanged(sender As Object, e As EventArgs) Handles txt_cantidad_de_importe.TextChanged
        Try
            txtSaldo.Text = txtCostoMastriculas.Text * 1 - txt_cantidad_de_importe.Text * 1
        Catch ex As Exception
            txtSaldo.Text = 0
        End Try
    End Sub

    Private Sub txtSaldo_TextChanged(sender As Object, e As EventArgs) Handles txtSaldo.TextChanged
        Try
            txt_cantidad_de_importe.Text = txtCostoMastriculas.Text * 1 - txtSaldo.Text * 1
        Catch ex As Exception
            txtSaldo.Text = 0
        End Try
    End Sub

    Private Sub txtGrado_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles txtGrado.SelectedIndexChanged
        mostrar_COSTO_MATRICULA()
        mostrar_Precio_de_PENSION()
        mostrar_MATRICULAS_YA_HECHAS()
        If idGrado = 0 Then
            PanelMAtricula_ya_hecha.Visible = False
        Else
            PanelMAtricula_ya_hecha.Visible = True
            PanelMAtricula_ya_hecha.Location = New Point(PanelFormulario.Location.X, PanelFormulario.Location.Y)
            PanelMAtricula_ya_hecha.Size = New Point(PanelFormulario.Size.Width, PanelFormulario.Size.Height)
            PanelFormulario.Visible = False
            DataListadoAlumnos.BringToFront()
        End If
    End Sub
End Class