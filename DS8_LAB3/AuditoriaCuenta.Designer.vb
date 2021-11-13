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
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.dtg_movimientos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(266, 26)
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
        Me.Label2.Size = New System.Drawing.Size(97, 16)
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
        Me.Label3.Location = New System.Drawing.Point(146, 122)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(192, 16)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Cuentas ligadas a este usuario"
        '
        'btn_Seleccionar
        '
        Me.btn_Seleccionar.Location = New System.Drawing.Point(533, 203)
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
        Me.Label4.Location = New System.Drawing.Point(146, 249)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(160, 16)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Movimientos de la cuenta"
        '
        'cbo_cuentas
        '
        Me.cbo_cuentas.FormattingEnabled = True
        Me.cbo_cuentas.Location = New System.Drawing.Point(149, 205)
        Me.cbo_cuentas.Name = "cbo_cuentas"
        Me.cbo_cuentas.Size = New System.Drawing.Size(369, 21)
        Me.cbo_cuentas.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(530, 124)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 52)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Tipos de cuentas" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "   1. ahorro" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "   2. corriente" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "   3. navidad"
        '
        'AuditoriaCuenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label5)
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
    Friend WithEvents Label5 As Label
End Class
