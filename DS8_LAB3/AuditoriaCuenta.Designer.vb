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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_buscar = New System.Windows.Forms.Button()
        Me.cbo_clientes = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_Seleccionar = New System.Windows.Forms.Button()
        Me.dtg_movimientos = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbo_cuentas = New System.Windows.Forms.ComboBox()
        Me.rd_ahorro = New System.Windows.Forms.RadioButton()
        Me.rd_Corriente = New System.Windows.Forms.RadioButton()
        Me.rd_Navidad = New System.Windows.Forms.RadioButton()
        Me.gbox_tipocuenta = New System.Windows.Forms.GroupBox()
        CType(Me.dtg_movimientos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbox_tipocuenta.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(282, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(205, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Auditoria de Cuentas"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(146, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Buscar usuario"
        '
        'btn_buscar
        '
        Me.btn_buscar.Location = New System.Drawing.Point(511, 71)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(75, 23)
        Me.btn_buscar.TabIndex = 3
        Me.btn_buscar.Text = "Buscar"
        Me.btn_buscar.UseVisualStyleBackColor = True
        '
        'cbo_clientes
        '
        Me.cbo_clientes.FormattingEnabled = True
        Me.cbo_clientes.Location = New System.Drawing.Point(260, 73)
        Me.cbo_clientes.Name = "cbo_clientes"
        Me.cbo_clientes.Size = New System.Drawing.Size(245, 21)
        Me.cbo_clientes.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(146, 166)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(191, 16)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Cuentas ligadas a este usuario"
        '
        'btn_Seleccionar
        '
        Me.btn_Seleccionar.Location = New System.Drawing.Point(533, 197)
        Me.btn_Seleccionar.Name = "btn_Seleccionar"
        Me.btn_Seleccionar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Seleccionar.TabIndex = 7
        Me.btn_Seleccionar.Text = "Seleccionar"
        Me.btn_Seleccionar.UseVisualStyleBackColor = True
        '
        'dtg_movimientos
        '
        Me.dtg_movimientos.AllowUserToAddRows = False
        Me.dtg_movimientos.AllowUserToDeleteRows = False
        Me.dtg_movimientos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtg_movimientos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtg_movimientos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dtg_movimientos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dtg_movimientos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal
        Me.dtg_movimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtg_movimientos.Location = New System.Drawing.Point(149, 288)
        Me.dtg_movimientos.Name = "dtg_movimientos"
        Me.dtg_movimientos.ReadOnly = True
        Me.dtg_movimientos.Size = New System.Drawing.Size(437, 150)
        Me.dtg_movimientos.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(146, 255)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(159, 16)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Movimientos de la cuenta"
        '
        'cbo_cuentas
        '
        Me.cbo_cuentas.FormattingEnabled = True
        Me.cbo_cuentas.Location = New System.Drawing.Point(149, 199)
        Me.cbo_cuentas.Name = "cbo_cuentas"
        Me.cbo_cuentas.Size = New System.Drawing.Size(369, 21)
        Me.cbo_cuentas.TabIndex = 10
        '
        'rd_ahorro
        '
        Me.rd_ahorro.AutoSize = True
        Me.rd_ahorro.Location = New System.Drawing.Point(32, 9)
        Me.rd_ahorro.Name = "rd_ahorro"
        Me.rd_ahorro.Size = New System.Drawing.Size(108, 17)
        Me.rd_ahorro.TabIndex = 12
        Me.rd_ahorro.TabStop = True
        Me.rd_ahorro.Text = "Cuenta de Ahorro"
        Me.rd_ahorro.UseVisualStyleBackColor = True
        '
        'rd_Corriente
        '
        Me.rd_Corriente.AutoSize = True
        Me.rd_Corriente.Location = New System.Drawing.Point(182, 9)
        Me.rd_Corriente.Name = "rd_Corriente"
        Me.rd_Corriente.Size = New System.Drawing.Size(104, 17)
        Me.rd_Corriente.TabIndex = 13
        Me.rd_Corriente.TabStop = True
        Me.rd_Corriente.Text = "Cuenta Corriente"
        Me.rd_Corriente.UseVisualStyleBackColor = True
        '
        'rd_Navidad
        '
        Me.rd_Navidad.AutoSize = True
        Me.rd_Navidad.Location = New System.Drawing.Point(312, 9)
        Me.rd_Navidad.Name = "rd_Navidad"
        Me.rd_Navidad.Size = New System.Drawing.Size(117, 17)
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
        Me.gbox_tipocuenta.Location = New System.Drawing.Point(149, 109)
        Me.gbox_tipocuenta.Name = "gbox_tipocuenta"
        Me.gbox_tipocuenta.Size = New System.Drawing.Size(459, 32)
        Me.gbox_tipocuenta.TabIndex = 15
        Me.gbox_tipocuenta.TabStop = False
        '
        'AuditoriaCuenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.gbox_tipocuenta)
        Me.Controls.Add(Me.cbo_cuentas)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dtg_movimientos)
        Me.Controls.Add(Me.btn_Seleccionar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbo_clientes)
        Me.Controls.Add(Me.btn_buscar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "AuditoriaCuenta"
        Me.Text = "AuditoriaCuenta"
        CType(Me.dtg_movimientos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbox_tipocuenta.ResumeLayout(False)
        Me.gbox_tipocuenta.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_buscar As Button
    Friend WithEvents cbo_clientes As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btn_Seleccionar As Button
    Friend WithEvents dtg_movimientos As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents cbo_cuentas As ComboBox
    Friend WithEvents rd_ahorro As RadioButton
    Friend WithEvents rd_Corriente As RadioButton
    Friend WithEvents rd_Navidad As RadioButton
    Friend WithEvents gbox_tipocuenta As GroupBox
End Class
