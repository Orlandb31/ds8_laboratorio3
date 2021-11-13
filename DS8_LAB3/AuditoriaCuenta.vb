Imports System.Data.SqlClient
Public Class AuditoriaCuenta
    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        Label3.Show()
        cbo_cuentas.Show()
        'dtg_pe.Show()
        btn_Seleccionar.Show()
        Label5.Show()
        Dim Glcommand As New SqlCommand
        Dim dtcuentas As New DataTable
        Dim sqlDa As SqlDataAdapter

        Glcommand.Connection = SQLConect
        Glcommand.CommandText = "SP_Show_cuentas"
        Glcommand.Parameters.AddWithValue("@id_cliente", cbo_clientes.SelectedValue)
        Glcommand.CommandTimeout = 0
        Glcommand.CommandType = CommandType.StoredProcedure

        Try
            SQLConect.Open()
            Glcommand.ExecuteNonQuery()
            sqlDa = New SqlDataAdapter(Glcommand)
            sqlDa.Fill(dtcuentas)
            If dtcuentas.Rows.Count <> 0 Then
                With cbo_cuentas
                    .DataSource = dtcuentas
                    .ValueMember = "id_cuenta"
                    .DisplayMember = "impresion"
                End With
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If SQLConect.State <> ConnectionState.Closed Then SQLConect.Close()
        End Try
    End Sub

    Private Sub AuditoriaCuenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Sqlda As SqlDataAdapter
        Dim dtclientes As DataTable = New DataTable
        Dim sqlQuery As String = "SELECT id_cliente, nombre+' '+ apellido+' ID '+ id_cliente as nombre
  FROM [dbo].[tlb_datoscliente]"
        Sqlda = New SqlDataAdapter(sqlQuery, SQLConect)
        Sqlda.Fill(dtclientes)
        If dtclientes.Rows.Count <> 0 Then
            With cbo_clientes
                .DataSource = dtclientes
                .ValueMember = "id_cliente"
                .DisplayMember = "nombre"
            End With
        End If
        Label3.Hide()
        btn_Seleccionar.Hide()
        cbo_cuentas.Hide()
        'dtg_pe.Hide()
        dtg_movimientos.Hide()
        Label4.Hide()
        Label5.Hide()
    End Sub

    Private Sub btn_Seleccionar_Click(sender As Object, e As EventArgs) Handles btn_Seleccionar.Click
        Label4.Show()
        dtg_movimientos.Show()
        Dim Glcommand As New SqlCommand
        Dim dtmovimientos As New DataTable
        Dim sqlDa As SqlDataAdapter

        Glcommand.Connection = SQLConect
        Glcommand.CommandText = "SP_Auditoria"
        Glcommand.Parameters.AddWithValue("@id_cuenta", cbo_cuentas.SelectedValue)
        Glcommand.CommandTimeout = 0
        Glcommand.CommandType = CommandType.StoredProcedure

        Try
            SQLConect.Open()
            Glcommand.ExecuteNonQuery()
            sqlDa = New SqlDataAdapter(Glcommand)
            sqlDa.Fill(dtmovimientos)
            If dtmovimientos.Rows.Count <> 0 Then
                dtg_movimientos.DataSource = dtmovimientos
                dtg_movimientos.AutoResizeColumns()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If SQLConect.State <> ConnectionState.Closed Then SQLConect.Close()
        End Try
    End Sub
End Class