Imports System.Data.SqlClient
Imports System.Net
Public Class Registro

    Private Sub btn_registrar_Click(sender As Object, e As EventArgs) Handles btn_registrar.Click
        If txt_cedula.Text = String.Empty Or txt_nombre.Text = String.Empty Or txt_apellido.Text = String.Empty Or txt_telefono.Text = String.Empty Or txt_direccion.Text = String.Empty Then
            MessageBox.Show("No se puede dejar campos en blanco")
            Return

        End If
        Dim ossCommand As New SqlCommand
        ''Dim dtordenes As New DataTable

        ossCommand.Connection = SQLConect
        '' glcomand.Parameters.AddWithValue("@id_empleado", cboempleado.SelectedValue)
        ossCommand.CommandTimeout = 0
        ossCommand.CommandType = CommandType.StoredProcedure
        ossCommand.CommandText = "SP_InsertarCliente"

        ossCommand.Parameters.AddWithValue("@idCliente", txt_cedula.Text)
        ossCommand.Parameters.AddWithValue("@nombre", txt_nombre.Text)
        ossCommand.Parameters.AddWithValue("@apellido", txt_apellido.Text)
        ossCommand.Parameters.AddWithValue("@telefono_movil", txt_telefono.Text)
        ossCommand.Parameters.AddWithValue("@direccion", txt_cedula.Text)

        Try

            SQLConect.Open()
            ossCommand.ExecuteNonQuery()
            Me.Visible = False
            RegistraCuenta.MdiParent = Cuentas
            RegistraCuenta.WindowState = FormWindowState.Maximized
            RegistraCuenta.Show()


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If SQLConect.State <> ConnectionState.Closed Then SQLConect.Close()

        End Try
    End Sub
End Class