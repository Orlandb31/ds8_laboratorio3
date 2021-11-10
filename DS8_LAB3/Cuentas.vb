Public Class Cuentas

    Private Sub RegistrarClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrarClienteToolStripMenuItem.Click
        Registro.MdiParent = Me
        Registro.WindowState = FormWindowState.Maximized
        Registro.Show()
    End Sub

    Private Sub CrearNuevaCuentaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CrearNuevaCuentaToolStripMenuItem.Click
        RegistraCuenta.MdiParent = Me
        RegistraCuenta.WindowState = FormWindowState.Maximized
        RegistraCuenta.Show()
    End Sub
End Class
