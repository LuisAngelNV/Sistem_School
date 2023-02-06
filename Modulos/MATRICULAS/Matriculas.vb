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

    Sub mostrar_Tipo_de_documentos_para_insertar_en_MATRICULAS()
        Dim dtComprobante As New DataTable
        Dim da As SqlDataAdapter
        Try
            da = New SqlDataAdapter("", connection)
            da.Fill(dtComprobante)
            txtComprobante.DisplayMember = "COMPROBANTE"
            txtComprobante.ValueMember = "Id_serializacion"
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

    ' eventos

    Private Sub Matriculas_Load(sender As Object, e As EventArgs) Handles Me.Load
        LocacionPanelMatriculasX = PanelFormulario.Location.X
        LocacionPanelMatriculasy = PanelFormulario.Location.Y
        TamañoPanelMatriculasX = PanelFormulario.Width
        TamañoPanelMatriculasy = PanelFormulario.Height
        mostrar_Tipo_de_documentos_para_insertar_en_MATRICULAS()
        DataListadoAlumnos.Size = New Point(PanelFormulario.Width, PanelFormulario.Height)
        DataListadoAlumnos.Location = New Point(LocacionPanelMatriculasX, LocacionPanelMatriculasy)

        PanelPrincipal.Location = New Point((Width - PanelPrincipal.Width) / 2, (Height - PanelPrincipal.Height) / 2)

    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtComprobante.SelectedIndexChanged
        Mostrar_numero_de_recibo()
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
        Dispose()
    End Sub


    Private Sub txtBuscaralumno_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        If txtBuscar.Text = "" Then
            DataListadoAlumnos.Visible = True
        ElseIf txtBuscar.Text <> "" Then
            DataListadoAlumnos.Visible = True
        End If

    End Sub

    Private Sub DataListadoAlumnos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataListadoAlumnos.CellClick
        Try
            idAlumno = DataListadoAlumnos.SelectedCells.Item(1).Value
            txtBuscar.Text = DataListadoAlumnos.SelectedCells.Item(8).Value
            DataListadoAlumnos.Visible = False
        Catch ex As Exception

        End Try
    End Sub
End Class