Imports System.Data.SqlClient

Module CONNECTIONMUESTRA
    Public connection As New SqlConnection("Data Source=PC-ELITE\SERVER;initial Catalog=Colegio;Integrated Security=true")
    ' abrimos el proceso
    Sub abrir()
        If connection.State = 0 Then
            connection.Open()
        End If
    End Sub

    'Cerramos proceso'
    Sub cerrar()
        If connection.State = 1 Then
            connection.Close()
        End If
    End Sub
End Module
