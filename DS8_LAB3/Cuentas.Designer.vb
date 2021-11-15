<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Cuentas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.error_cliente = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.error_monto = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.RegistrarClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CrearNuevaCuentaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActualizarCuentaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AuditoriaDeCuentaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        CType(Me.error_cliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.error_monto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'error_cliente
        '
        Me.error_cliente.ContainerControl = Me
        '
        'error_monto
        '
        Me.error_monto.ContainerControl = Me
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegistrarClienteToolStripMenuItem, Me.CrearNuevaCuentaToolStripMenuItem, Me.ActualizarCuentaToolStripMenuItem, Me.AuditoriaDeCuentaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(5, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1067, 28)
        Me.MenuStrip1.TabIndex = 7
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'RegistrarClienteToolStripMenuItem
        '
        Me.RegistrarClienteToolStripMenuItem.Name = "RegistrarClienteToolStripMenuItem"
        Me.RegistrarClienteToolStripMenuItem.Size = New System.Drawing.Size(132, 24)
        Me.RegistrarClienteToolStripMenuItem.Text = "Registrar Cliente"
        '
        'CrearNuevaCuentaToolStripMenuItem
        '
        Me.CrearNuevaCuentaToolStripMenuItem.Name = "CrearNuevaCuentaToolStripMenuItem"
        Me.CrearNuevaCuentaToolStripMenuItem.Size = New System.Drawing.Size(154, 24)
        Me.CrearNuevaCuentaToolStripMenuItem.Text = "Crear Nueva Cuenta"
        '
        'ActualizarCuentaToolStripMenuItem
        '
        Me.ActualizarCuentaToolStripMenuItem.Name = "ActualizarCuentaToolStripMenuItem"
        Me.ActualizarCuentaToolStripMenuItem.Size = New System.Drawing.Size(139, 24)
        Me.ActualizarCuentaToolStripMenuItem.Text = "Actualizar Cuenta"
        '
        'AuditoriaDeCuentaToolStripMenuItem
        '
        Me.AuditoriaDeCuentaToolStripMenuItem.Name = "AuditoriaDeCuentaToolStripMenuItem"
        Me.AuditoriaDeCuentaToolStripMenuItem.Size = New System.Drawing.Size(156, 24)
        Me.AuditoriaDeCuentaToolStripMenuItem.Text = "Auditoria de Cuenta"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'Cuentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 887)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Cuentas"
        Me.Text = "Form1"
        CType(Me.error_cliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.error_monto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents error_cliente As ErrorProvider
    Friend WithEvents error_monto As ErrorProvider
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents RegistrarClienteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents CrearNuevaCuentaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ActualizarCuentaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AuditoriaDeCuentaToolStripMenuItem As ToolStripMenuItem
End Class
