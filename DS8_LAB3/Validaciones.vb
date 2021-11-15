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

    Public Function validar_Monto(ByRef idCuenta As Integer, ByRef Monto As Double)
        Dim saldo As String = 0.00
        Dim nm As Double
        Dim Glcommand As New SqlCommand
        Dim dtmonto As New DataTable
        Dim sqlDa As SqlDataAdapter


        Glcommand.Connection = SQLConect
        Glcommand.CommandText = "SP_Mostrar_Monto"
        Glcommand.Parameters.AddWithValue("@id_cuenta", idCuenta)

        Glcommand.CommandTimeout = 0
        Glcommand.CommandType = CommandType.StoredProcedure

        Try
            SQLConect.Open()
            Glcommand.ExecuteNonQuery()
            sqlDa = New SqlDataAdapter(Glcommand)
            sqlDa.Fill(dtmonto)
            Dim row As DataRow = dtmonto.Rows(dtmonto.Rows.Count - 1)
            saldo = CStr(row("monto"))

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If SQLConect.State <> ConnectionState.Closed Then SQLConect.Close()
        End Try

        nm = CDbl(saldo)

        If nm > Monto Then
            Return True
        Else
            Return False
        End If

    End Function

End Class
