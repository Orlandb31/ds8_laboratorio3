Imports System.Data.SqlClient

Public Class RegistraCuenta
    Dim validar_data As New Validaciones
    Private Sub RegistraCuenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbox_tipoCuenta.Items.Add("Cuenta de Ahorros")
        cbox_tipoCuenta.Items.Add("Cuenta Corriente")
        cbox_tipoCuenta.Items.Add("Cuenta de Navidad")
    End Sub

    Private Sub btn_crearCuenta_Click(sender As Object, e As EventArgs) Handles btn_crearCuenta.Click

        Dim tipo_cuenta As Integer

        Select Case cbox_tipoCuenta.SelectedItem.ToString
            Case "Cuenta de Ahorros"
                tipo_cuenta = 1
            Case "Cuenta Corriente"
                tipo_cuenta = 2
            Case "Cuenta de Navidad"
                tipo_cuenta = 3
        End Select

        If validar_data.validar_user(txt_cedula.Text) = False Then
            MsgBox("El usuario no existe")
            Return
        ElseIf txt_saldo.Text = String.Empty Or txt_cedula.Text = String.Empty Then
            MsgBox("No puede dejar campos vacios")
        Else
            Dim ossCommand As New SqlCommand
            ossCommand.Connection = SQLConect
            ossCommand.CommandTimeout = 0
            ossCommand.CommandType = CommandType.StoredProcedure
            ossCommand.CommandText = "SP_Insertar_Cuenta"

            ossCommand.Parameters.AddWithValue("@idCliente", txt_cedula.Text)
            ossCommand.Parameters.AddWithValue("@tipo", tipo_cuenta)
            ossCommand.Parameters.AddWithValue("@saldo", txt_saldo.Text)

            Try

                SQLConect.Open()
                ossCommand.ExecuteNonQuery()
                MsgBox("La cuenta se ha creado con éxito")

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                If SQLConect.State <> ConnectionState.Closed Then SQLConect.Close()

            End Try

        End If




    End Sub
End Class