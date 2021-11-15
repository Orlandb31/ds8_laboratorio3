Imports System.Data.SqlClient
Imports System.Net
Public Class Validaciones
    Public Function validar_user(ByVal UserID As String)

        Dim sqlDa As SqlDataAdapter
        Dim sqlQuery As String
        sqlQuery = "Select id_cliente from tlb_datoscliente where id_cliente ="
        sqlQuery &= "'" & UserID & "'"
        sqlDa = New SqlDataAdapter(sqlQuery, SQLConect)
        Dim dt = New DataTable
        sqlDa.Fill(dt)
        If dt.Rows.Count > 0 Then
            For Each row As DataRow In dt.Rows
                UserID = row("id_cliente").ToString
            Next
            Return True
        Else Return False

        End If

    End Function

End Class
