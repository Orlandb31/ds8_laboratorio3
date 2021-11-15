<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AuditoriaCuenta
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbo_clientes = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtg_movimientos = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbo_cuentas = New System.Windows.Forms.ComboBox()
        Me.rd_ahorro = New System.Windows.Forms.RadioButton()
        Me.rd_Corriente = New System.Windows.Forms.RadioButton()
        Me.rd_Navidad = New System.Windows.Forms.RadioButton()
        Me.gbox_tipocuenta = New System.Windows.Forms.GroupBox()
        Me.l1 = New Guna.UI.WinForms.GunaLabel()
        Me.btn_buscarCliente = New Guna.UI.WinForms.GunaButton()
        Me.btn_Seleccionar = New Guna.UI.WinForms.GunaButton()
        CType(Me.dtg_movimientos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbox_tipocuenta.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Label2.ForeColor = System.Drawing.Color.Silver
        Me.Label2.Location = New System.Drawing.Point(195, 91)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 21)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Buscar usuario"
        '
        'cbo_clientes
        '
        Me.cbo_clientes.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.cbo_clientes.ForeColor = System.Drawing.Color.Silver
        Me.cbo_clientes.FormattingEnabled = True
        Me.cbo_clientes.Location = New System.Drawing.Point(331, 87)
        Me.cbo_clientes.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbo_clientes.Name = "cbo_clientes"
        Me.cbo_clientes.Size = New System.Drawing.Size(325, 29)
        Me.cbo_clientes.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Label3.ForeColor = System.Drawing.Color.Silver
        Me.Label3.Location = New System.Drawing.Point(195, 204)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(267, 21)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Cuentas ligadas a este usuario"
        '
        'dtg_movimientos
        '
        Me.dtg_movimientos.AllowUserToAddRows = False
        Me.dtg_movimientos.AllowUserToDeleteRows = False
        Me.dtg_movimientos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtg_movimientos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtg_movimientos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dtg_movimientos.BackgroundColor = System.Drawing.Color.Silver
        Me.dtg_movimientos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dtg_movimientos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal
        Me.dtg_movimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtg_movimientos.Location = New System.Drawing.Point(199, 354)
        Me.dtg_movimientos.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dtg_movimientos.Name = "dtg_movimientos"
        Me.dtg_movimientos.ReadOnly = True
        Me.dtg_movimientos.RowHeadersWidth = 51
        Me.dtg_movimientos.Size = New System.Drawing.Size(497, 185)
        Me.dtg_movimientos.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Label4.ForeColor = System.Drawing.Color.Silver
        Me.Label4.Location = New System.Drawing.Point(195, 314)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(230, 21)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Movimientos de la cuenta"
        '
        'cbo_cuentas
        '
        Me.cbo_cuentas.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.cbo_cuentas.ForeColor = System.Drawing.Color.Silver
        Me.cbo_cuentas.FormattingEnabled = True
        Me.cbo_cuentas.Location = New System.Drawing.Point(199, 245)
        Me.cbo_cuentas.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbo_cuentas.Name = "cbo_cuentas"
        Me.cbo_cuentas.Size = New System.Drawing.Size(491, 29)
        Me.cbo_cuentas.TabIndex = 10
        '
        'rd_ahorro
        '
        Me.rd_ahorro.AutoSize = True
        Me.rd_ahorro.Location = New System.Drawing.Point(43, 11)
        Me.rd_ahorro.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rd_ahorro.Name = "rd_ahorro"
        Me.rd_ahorro.Size = New System.Drawing.Size(183, 25)
        Me.rd_ahorro.TabIndex = 12
        Me.rd_ahorro.TabStop = True
        Me.rd_ahorro.Text = "Cuenta de Ahorro"
        Me.rd_ahorro.UseVisualStyleBackColor = True
        '
        'rd_Corriente
        '
        Me.rd_Corriente.AutoSize = True
        Me.rd_Corriente.Location = New System.Drawing.Point(243, 11)
        Me.rd_Corriente.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rd_Corriente.Name = "rd_Corriente"
        Me.rd_Corriente.Size = New System.Drawing.Size(177, 25)
        Me.rd_Corriente.TabIndex = 13
        Me.rd_Corriente.TabStop = True
        Me.rd_Corriente.Text = "Cuenta Corriente"
        Me.rd_Corriente.UseVisualStyleBackColor = True
        '
        'rd_Navidad
        '
        Me.rd_Navidad.AutoSize = True
        Me.rd_Navidad.Location = New System.Drawing.Point(416, 11)
        Me.rd_Navidad.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rd_Navidad.Name = "rd_Navidad"
        Me.rd_Navidad.Size = New System.Drawing.Size(203, 25)
        Me.rd_Navidad.TabIndex = 14
        Me.rd_Navidad.TabStop = True
        Me.rd_Navidad.Text = "Cuenta de Navidad"
        Me.rd_Navidad.UseVisualStyleBackColor = True
        '
        'gbox_tipocuenta
        '
        Me.gbox_tipocuenta.Controls.Add(Me.rd_ahorro)
        Me.gbox_tipocuenta.Controls.Add(Me.rd_Navidad)
        Me.gbox_tipocuenta.Controls.Add(Me.rd_Corriente)
        Me.gbox_tipocuenta.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.gbox_tipocuenta.ForeColor = System.Drawing.Color.Silver
        Me.gbox_tipocuenta.Location = New System.Drawing.Point(199, 134)
        Me.gbox_tipocuenta.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gbox_tipocuenta.Name = "gbox_tipocuenta"
        Me.gbox_tipocuenta.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gbox_tipocuenta.Size = New System.Drawing.Size(644, 56)
        Me.gbox_tipocuenta.TabIndex = 15
        Me.gbox_tipocuenta.TabStop = False
        '
        'l1
        '
        Me.l1.AutoSize = True
        Me.l1.Font = New System.Drawing.Font("Segoe UI", 25.0!, System.Drawing.FontStyle.Bold)
        Me.l1.ForeColor = System.Drawing.Color.Silver
        Me.l1.Location = New System.Drawing.Point(329, 9)
        Me.l1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.l1.Name = "l1"
        Me.l1.Size = New System.Drawing.Size(361, 57)
        Me.l1.TabIndex = 16
        Me.l1.Text = "Auditoria Cliente"
        Me.l1.Visible = False
        '
        'btn_buscarCliente
        '
        Me.btn_buscarCliente.Animated = True
        Me.btn_buscarCliente.AnimationHoverSpeed = 0.07!
        Me.btn_buscarCliente.AnimationSpeed = 0.03!
        Me.btn_buscarCliente.BaseColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.btn_buscarCliente.BorderColor = System.Drawing.Color.Black
        Me.btn_buscarCliente.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_buscarCliente.FocusedColor = System.Drawing.Color.Empty
        Me.btn_buscarCliente.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btn_buscarCliente.ForeColor = System.Drawing.Color.White
        Me.btn_buscarCliente.Image = Nothing
        Me.btn_buscarCliente.ImageSize = New System.Drawing.Size(20, 20)
        Me.btn_buscarCliente.Location = New System.Drawing.Point(689, 84)
        Me.btn_buscarCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_buscarCliente.Name = "btn_buscarCliente"
        Me.btn_buscarCliente.OnHoverBaseColor = System.Drawing.Color.SpringGreen
        Me.btn_buscarCliente.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_buscarCliente.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_buscarCliente.OnHoverImage = Nothing
        Me.btn_buscarCliente.OnPressedColor = System.Drawing.Color.Black
        Me.btn_buscarCliente.Size = New System.Drawing.Size(142, 32)
        Me.btn_buscarCliente.TabIndex = 19
        Me.btn_buscarCliente.Text = "Buscar"
        Me.btn_buscarCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btn_Seleccionar
        '
        Me.btn_Seleccionar.Animated = True
        Me.btn_Seleccionar.AnimationHoverSpeed = 0.07!
        Me.btn_Seleccionar.AnimationSpeed = 0.03!
        Me.btn_Seleccionar.BaseColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.btn_Seleccionar.BorderColor = System.Drawing.Color.Black
        Me.btn_Seleccionar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_Seleccionar.FocusedColor = System.Drawing.Color.Empty
        Me.btn_Seleccionar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btn_Seleccionar.ForeColor = System.Drawing.Color.White
        Me.btn_Seleccionar.Image = Nothing
        Me.btn_Seleccionar.ImageSize = New System.Drawing.Size(20, 20)
        Me.btn_Seleccionar.Location = New System.Drawing.Point(701, 245)
        Me.btn_Seleccionar.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_Seleccionar.Name = "btn_Seleccionar"
        Me.btn_Seleccionar.OnHoverBaseColor = System.Drawing.Color.SpringGreen
        Me.btn_Seleccionar.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_Seleccionar.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_Seleccionar.OnHoverImage = Nothing
        Me.btn_Seleccionar.OnPressedColor = System.Drawing.Color.Black
        Me.btn_Seleccionar.Size = New System.Drawing.Size(142, 32)
        Me.btn_Seleccionar.TabIndex = 20
        Me.btn_Seleccionar.Text = "Seleccionar"
        Me.btn_Seleccionar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'AuditoriaCuenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(981, 605)
        Me.Controls.Add(Me.btn_Seleccionar)
        Me.Controls.Add(Me.btn_buscarCliente)
        Me.Controls.Add(Me.l1)
        Me.Controls.Add(Me.gbox_tipocuenta)
        Me.Controls.Add(Me.cbo_cuentas)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dtg_movimientos)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbo_clientes)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "AuditoriaCuenta"
        Me.Text = "AuditoriaCuenta"
        CType(Me.dtg_movimientos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbox_tipocuenta.ResumeLayout(False)
        Me.gbox_tipocuenta.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents cbo_clientes As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents dtg_movimientos As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents cbo_cuentas As ComboBox
    Friend WithEvents rd_ahorro As RadioButton
    Friend WithEvents rd_Corriente As RadioButton
    Friend WithEvents rd_Navidad As RadioButton
    Friend WithEvents gbox_tipocuenta As GroupBox
    Friend WithEvents l1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents btn_buscarCliente As Guna.UI.WinForms.GunaButton
    Friend WithEvents btn_Seleccionar As Guna.UI.WinForms.GunaButton
End Class
