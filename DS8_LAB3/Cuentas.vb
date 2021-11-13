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

    Private Sub ActualizarCuentaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActualizarCuentaToolStripMenuItem.Click
        ActualizarCuenta.MdiParent = Me
        ActualizarCuenta.WindowState = FormWindowState.Maximized
        ActualizarCuenta.Show()
    End Sub

    Private Sub AuditoriaDeCuentaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AuditoriaDeCuentaToolStripMenuItem.Click
        AuditoriaCuenta.MdiParent = Me
        AuditoriaCuenta.WindowState = FormWindowState.Maximized
        AuditoriaCuenta.Show()
    End Sub
End Class
