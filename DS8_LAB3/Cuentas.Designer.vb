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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cuentas))
        Me.error_cliente = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.error_monto = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.RegistrarClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CrearNuevaCuentaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActualizarCuentaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AuditoriaDeCuentaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.panel_principal = New System.Windows.Forms.Panel()
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
        Me.MenuStrip1.AllowDrop = True
        Me.MenuStrip1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegistrarClienteToolStripMenuItem, Me.CrearNuevaCuentaToolStripMenuItem, Me.ActualizarCuentaToolStripMenuItem, Me.AuditoriaDeCuentaToolStripMenuItem})
        Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(142, 600)
        Me.MenuStrip1.TabIndex = 7
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'RegistrarClienteToolStripMenuItem
        '
        Me.RegistrarClienteToolStripMenuItem.Name = "RegistrarClienteToolStripMenuItem"
        Me.RegistrarClienteToolStripMenuItem.Size = New System.Drawing.Size(112, 19)
        Me.RegistrarClienteToolStripMenuItem.Text = "Registrar Cliente"
        '
        'CrearNuevaCuentaToolStripMenuItem
        '
        Me.CrearNuevaCuentaToolStripMenuItem.Name = "CrearNuevaCuentaToolStripMenuItem"
        Me.CrearNuevaCuentaToolStripMenuItem.Size = New System.Drawing.Size(130, 19)
        Me.CrearNuevaCuentaToolStripMenuItem.Text = "Crear Nueva Cuenta"
        '
        'ActualizarCuentaToolStripMenuItem
        '
        Me.ActualizarCuentaToolStripMenuItem.Name = "ActualizarCuentaToolStripMenuItem"
        Me.ActualizarCuentaToolStripMenuItem.Size = New System.Drawing.Size(116, 19)
        Me.ActualizarCuentaToolStripMenuItem.Text = "Actualizar Cuenta"
        '
        'AuditoriaDeCuentaToolStripMenuItem
        '
        Me.AuditoriaDeCuentaToolStripMenuItem.Name = "AuditoriaDeCuentaToolStripMenuItem"
        Me.AuditoriaDeCuentaToolStripMenuItem.Size = New System.Drawing.Size(129, 19)
        Me.AuditoriaDeCuentaToolStripMenuItem.Text = "Auditoria de Cuenta"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'panel_principal
        '
        Me.panel_principal.Location = New System.Drawing.Point(145, 0)
        Me.panel_principal.Name = "panel_principal"
        Me.panel_principal.Size = New System.Drawing.Size(653, 600)
        Me.panel_principal.TabIndex = 8
        '
        'Cuentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 600)
        Me.Controls.Add(Me.panel_principal)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Cuentas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.error_cliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.error_monto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents error_cliente As ErrorProvider
    Friend WithEvents error_monto As ErrorProvider
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents RegistrarClienteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents CrearNuevaCuentaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ActualizarCuentaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AuditoriaDeCuentaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents panel_principal As Panel
End Class
