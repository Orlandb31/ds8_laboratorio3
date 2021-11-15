Public Class Inicio

    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles GunaButton1.Click

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

        anima1.ShowSync(l1)
        anima1.AnimationType = Guna.UI.Animation.AnimationType.HorizSlide
        anima1.ShowSync(l2)
        anima1.AnimationType = Guna.UI.Animation.AnimationType.HorizBlind
        anima1.ShowSync(l3)
        anima1.AnimationType = Guna.UI.Animation.AnimationType.HorizSlide
        anima1.ShowSync(p2)
    End Sub

End Class