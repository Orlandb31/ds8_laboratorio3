Public Class Inicio
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Try

            Conexion()
            SQLConect.Open()
            Me.Visible = False
            Cuentas.Visible = True
            'MsgBox("Conexion Exitosa")
        Catch ex As Exception
            MessageBox.Show("Error al conectarse a la Base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Console.WriteLine(ex)
        Finally
            If SQLConect.State <> ConnectionState.Closed Then
                SQLConect.Close()
            End If
        End Try
    End Sub

    Private Sub Inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class