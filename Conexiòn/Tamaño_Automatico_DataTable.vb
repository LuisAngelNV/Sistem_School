Module Tamaño_Automatico_DataTable
    Public Sub Multilinea(ByRef List As DataGridView)
        'tamaño correcto de todas las columnas
        'Centrado de tablas
        List.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        List.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        List.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        List.DefaultCellStyle.WrapMode = DataGridViewTriState.True

        'Configuración de cabeceras 
        List.EnableHeadersVisualStyles = False
        Dim styCabecera As DataGridViewCellStyle = New DataGridViewCellStyle()
        styCabecera.BackColor = Color.White
        styCabecera.ForeColor = Color.Black
        styCabecera.Font = New Font("Segoe UI", 10, FontStyle.Regular.Regular Or FontStyle.Bold)
        List.ColumnHeadersDefaultCellStyle = styCabecera
    End Sub
End Module
