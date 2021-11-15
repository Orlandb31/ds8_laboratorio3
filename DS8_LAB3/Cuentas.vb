Public Class Cuentas
    Private formActualHijo As Form
    Private Sub RegistrarClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrarClienteToolStripMenuItem.Click
        ''pbox.Visible = False
        AbrirForm(New Registro)
    End Sub

    Private Sub CrearNuevaCuentaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CrearNuevaCuentaToolStripMenuItem.Click
        '' pbox.Visible = False
        'RegistraCuenta.MdiParent = Me
        'RegistraCuenta.WindowState = FormWindowState.Maximized
        'RegistraCuenta.Show()
        'AuditoriaCuenta.Close()
        AbrirForm(New RegistraCuenta)

    End Sub

    Private Sub ActualizarCuentaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActualizarCuentaToolStripMenuItem.Click
        ' pbox.Visible = False
        AbrirForm(New ClienteMovimientos)
        'ClienteMovimientos.Show()
        'ClienteMovimientos.MdiParent = Me
        'ClienteMovimientos.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub AuditoriaDeCuentaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AuditoriaDeCuentaToolStripMenuItem.Click
        'pbox.Visible = False
        'AuditoriaCuenta.MdiParent = Me
        'AuditoriaCuenta.WindowState = FormWindowState.Maximized

        'AuditoriaCuenta.Show()
        AbrirForm(New AuditoriaCuenta)
    End Sub

    Private Sub AbrirForm(childForm As Form)



        If formActualHijo IsNot Nothing Then
            formActualHijo.Close()
        End If
        formActualHijo = childForm

        formActualHijo.TopLevel = False
        formActualHijo.FormBorderStyle = FormBorderStyle.None
        formActualHijo.Dock = DockStyle.Fill
        panel_principal.Tag = childForm
        formActualHijo.BringToFront()
        formActualHijo.Show()
        panel_principal.Controls.Add(childForm)



    End Sub
End Class
