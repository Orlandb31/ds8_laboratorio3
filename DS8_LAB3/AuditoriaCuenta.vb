Imports System.Data.SqlClient
Public Class AuditoriaCuenta

        Dim tipo_cuenta As Integer

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
        '' gbox_tipocuenta.Visible = False

        rd_ahorro.Checked = True
    End Sub

    Private Sub btn_Seleccionar_Click(sender As Object, e As EventArgs)

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

    Private Sub gbox_tipocuenta_Enter(sender As Object, e As EventArgs) Handles gbox_tipocuenta.Enter

    End Sub

    Private Sub btn_buscarCliente_Click(sender As Object, e As EventArgs) Handles btn_buscarCliente.Click
        btn_Seleccionar.Enabled = True
        Dim tipo_cuenta As Integer
        If rd_ahorro.Checked Then
            tipo_cuenta = 1

        ElseIf rd_Corriente.Checked Then
            tipo_cuenta = 2
        ElseIf rd_Navidad.Checked Then
            tipo_cuenta = 3
        End If

        Label3.Show()
        cbo_cuentas.Show()
        btn_Seleccionar.Show()
        gbox_tipocuenta.Visible = True

        Dim Glcommand As New SqlCommand
        Dim dtcuentas As New DataTable
        Dim sqlDa As SqlDataAdapter

        Glcommand.Connection = SQLConect
        Glcommand.CommandText = "SP_Show_cuentas"
        Glcommand.Parameters.AddWithValue("@id_cliente", cbo_clientes.SelectedValue)
        Glcommand.Parameters.AddWithValue("@tipo_cuenta", tipo_cuenta)
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
            Else
                MsgBox("No tiene cuentas asociadas")
                cbo_cuentas.DataSource = Nothing
                cbo_cuentas.Items.Clear()
                btn_Seleccionar.Enabled = False


            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If SQLConect.State <> ConnectionState.Closed Then SQLConect.Close()
        End Try
    End Sub

    Private Sub rd_Navidad_CheckedChanged(sender As Object, e As EventArgs) Handles rd_Navidad.CheckedChanged

    End Sub

    Private Sub rd_ahorro_CheckedChanged(sender As Object, e As EventArgs) Handles rd_ahorro.CheckedChanged

    End Sub

    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles btn_Seleccionar.Click

    End Sub
End Class