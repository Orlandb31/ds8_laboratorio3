Imports System.Data.SqlClient
Public Class ClienteMovimientos
    Dim validar_data As New Validaciones
    Private Sub btn_Buscar_Cliente_Click(sender As Object, e As EventArgs) Handles btn_Buscar_Cliente.Click


        If validar_data.validar_user(txt_idcliente.Text) = False Then
            MsgBox("No hay registro de este usuario")
        ElseIf txt_idcliente.Text = String.Empty Then
            MsgBox("El campo esta vacio")
        Else
            Dim Glcommand As New SqlCommand
            Dim dtcuentas As New DataTable
            Dim sqlDa As SqlDataAdapter

            Glcommand.Connection = SQLConect
            Glcommand.CommandText = "SP_Mostrar"
            Glcommand.Parameters.AddWithValue("@id_cliente", txt_idcliente.Text)
            Glcommand.CommandTimeout = 0
            Glcommand.CommandType = CommandType.StoredProcedure

            Try
                SQLConect.Open()
                Glcommand.ExecuteNonQuery()
                sqlDa = New SqlDataAdapter(Glcommand)
                sqlDa.Fill(dtcuentas)
                If dtcuentas.Rows.Count <> 0 Then

                    With cbox_cuentas
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
        End If

    End Sub

    Private Sub ClienteMovimientos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rbt_Deposito.Checked = True
    End Sub

    Private Sub btn_Actualizar_Click(sender As Object, e As EventArgs) Handles btn_Actualizar.Click
        Dim opcion As Integer
        Dim Glcommand As New SqlCommand
        Dim dtcuentas As New DataTable
        Dim sqlDa As SqlDataAdapter
        Dim Metrans As SqlTransaction
        Dim validar As Boolean

        If rbt_Deposito.Checked = True Then
            opcion = 0
        ElseIf rbt_Retiro.Checked = True Then
            opcion = 1
        End If

        If opcion = 1 Then
            validar = validar_data.validar_Monto(cbox_cuentas.SelectedValue, txt_Monto.Text)
        Else
            validar = True
        End If

        If validar = True Then
            SQLConect.Open()
            Metrans = SQLConect.BeginTransaction
            Glcommand.Connection = SQLConect
            Glcommand.CommandText = "SP_Cuenta_Update_Deposito"
            Glcommand.Parameters.AddWithValue("@id_cuenta", cbox_cuentas.SelectedValue)
            Glcommand.Parameters.AddWithValue("@deposito_retiro", txt_Monto.Text)
            Glcommand.Parameters.AddWithValue("@opciondr", opcion)
            Glcommand.CommandTimeout = 0
            Glcommand.CommandType = CommandType.StoredProcedure

            Try

                Glcommand.Transaction = Metrans
                Glcommand.ExecuteNonQuery()
                MsgBox("El monto ha sido actualizado")
                Metrans.Commit()

            Catch ex As Exception
                Metrans.Rollback()
                MessageBox.Show(ex.Message)
            Finally
                If SQLConect.State <> ConnectionState.Closed Then SQLConect.Close()
            End Try
        Else
            MsgBox("Cuenta con un saldo menor para realizar el retiro")
        End If

    End Sub
End Class