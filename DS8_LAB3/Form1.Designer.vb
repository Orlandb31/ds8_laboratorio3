<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.gbox_cuenta = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_saldo = New System.Windows.Forms.TextBox()
        Me.btn_nuevo = New System.Windows.Forms.Button()
        Me.lbox_depositos = New System.Windows.Forms.ListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbox_retiro = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.gbox_transaccion = New System.Windows.Forms.GroupBox()
        Me.btn_generar = New System.Windows.Forms.Button()
        Me.rb_retiro = New System.Windows.Forms.RadioButton()
        Me.rb_deposito = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.txt_montoInicial = New System.Windows.Forms.TextBox()
        Me.txt_cliente = New System.Windows.Forms.TextBox()
        Me.btn_abrirCuenta = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.error_cliente = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.error_monto = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.RegistrarClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultaCuentaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.gbox_cuenta.SuspendLayout()
        Me.gbox_transaccion.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.error_cliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.error_monto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbox_cuenta
        '
        Me.gbox_cuenta.Controls.Add(Me.Label5)
        Me.gbox_cuenta.Controls.Add(Me.txt_saldo)
        Me.gbox_cuenta.Controls.Add(Me.btn_nuevo)
        Me.gbox_cuenta.Controls.Add(Me.lbox_depositos)
        Me.gbox_cuenta.Controls.Add(Me.Label4)
        Me.gbox_cuenta.Controls.Add(Me.lbox_retiro)
        Me.gbox_cuenta.Controls.Add(Me.Label3)
        Me.gbox_cuenta.Location = New System.Drawing.Point(200, 471)
        Me.gbox_cuenta.Margin = New System.Windows.Forms.Padding(4)
        Me.gbox_cuenta.Name = "gbox_cuenta"
        Me.gbox_cuenta.Padding = New System.Windows.Forms.Padding(4)
        Me.gbox_cuenta.Size = New System.Drawing.Size(685, 311)
        Me.gbox_cuenta.TabIndex = 6
        Me.gbox_cuenta.TabStop = False
        Me.gbox_cuenta.Text = "Cuenta de Ahorros"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(535, 130)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 17)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Saldo"
        '
        'txt_saldo
        '
        Me.txt_saldo.Location = New System.Drawing.Point(484, 171)
        Me.txt_saldo.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_saldo.Name = "txt_saldo"
        Me.txt_saldo.Size = New System.Drawing.Size(156, 22)
        Me.txt_saldo.TabIndex = 5
        '
        'btn_nuevo
        '
        Me.btn_nuevo.Location = New System.Drawing.Point(484, 224)
        Me.btn_nuevo.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_nuevo.Name = "btn_nuevo"
        Me.btn_nuevo.Size = New System.Drawing.Size(157, 46)
        Me.btn_nuevo.TabIndex = 4
        Me.btn_nuevo.Text = "Nuevo"
        Me.btn_nuevo.UseVisualStyleBackColor = True
        '
        'lbox_depositos
        '
        Me.lbox_depositos.FormattingEnabled = True
        Me.lbox_depositos.ItemHeight = 16
        Me.lbox_depositos.Location = New System.Drawing.Point(233, 69)
        Me.lbox_depositos.Margin = New System.Windows.Forms.Padding(4)
        Me.lbox_depositos.Name = "lbox_depositos"
        Me.lbox_depositos.Size = New System.Drawing.Size(175, 212)
        Me.lbox_depositos.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(289, 39)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 17)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Depositos"
        '
        'lbox_retiro
        '
        Me.lbox_retiro.FormattingEnabled = True
        Me.lbox_retiro.ItemHeight = 16
        Me.lbox_retiro.Location = New System.Drawing.Point(29, 69)
        Me.lbox_retiro.Margin = New System.Windows.Forms.Padding(4)
        Me.lbox_retiro.Name = "lbox_retiro"
        Me.lbox_retiro.Size = New System.Drawing.Size(175, 212)
        Me.lbox_retiro.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(85, 39)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 17)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Retiros"
        '
        'gbox_transaccion
        '
        Me.gbox_transaccion.Controls.Add(Me.btn_generar)
        Me.gbox_transaccion.Controls.Add(Me.rb_retiro)
        Me.gbox_transaccion.Controls.Add(Me.rb_deposito)
        Me.gbox_transaccion.Location = New System.Drawing.Point(200, 363)
        Me.gbox_transaccion.Margin = New System.Windows.Forms.Padding(4)
        Me.gbox_transaccion.Name = "gbox_transaccion"
        Me.gbox_transaccion.Padding = New System.Windows.Forms.Padding(4)
        Me.gbox_transaccion.Size = New System.Drawing.Size(685, 90)
        Me.gbox_transaccion.TabIndex = 5
        Me.gbox_transaccion.TabStop = False
        Me.gbox_transaccion.Text = "Transacciones"
        '
        'btn_generar
        '
        Me.btn_generar.Location = New System.Drawing.Point(541, 30)
        Me.btn_generar.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_generar.Name = "btn_generar"
        Me.btn_generar.Size = New System.Drawing.Size(100, 28)
        Me.btn_generar.TabIndex = 4
        Me.btn_generar.Text = "Generar"
        Me.btn_generar.UseVisualStyleBackColor = True
        '
        'rb_retiro
        '
        Me.rb_retiro.AutoSize = True
        Me.rb_retiro.Location = New System.Drawing.Point(332, 37)
        Me.rb_retiro.Margin = New System.Windows.Forms.Padding(4)
        Me.rb_retiro.Name = "rb_retiro"
        Me.rb_retiro.Size = New System.Drawing.Size(74, 21)
        Me.rb_retiro.TabIndex = 3
        Me.rb_retiro.TabStop = True
        Me.rb_retiro.Text = "Retiros"
        Me.rb_retiro.UseVisualStyleBackColor = True
        '
        'rb_deposito
        '
        Me.rb_deposito.AutoSize = True
        Me.rb_deposito.Location = New System.Drawing.Point(89, 41)
        Me.rb_deposito.Margin = New System.Windows.Forms.Padding(4)
        Me.rb_deposito.Name = "rb_deposito"
        Me.rb_deposito.Size = New System.Drawing.Size(92, 21)
        Me.rb_deposito.TabIndex = 2
        Me.rb_deposito.TabStop = True
        Me.rb_deposito.Text = "Depósitos"
        Me.rb_deposito.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.txt_montoInicial)
        Me.GroupBox1.Controls.Add(Me.txt_cliente)
        Me.GroupBox1.Controls.Add(Me.btn_abrirCuenta)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(200, 124)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(685, 220)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingrese Datos"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(378, 152)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(100, 21)
        Me.CheckBox1.TabIndex = 6
        Me.CheckBox1.Text = "CheckBox1"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(123, 149)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(160, 24)
        Me.ComboBox1.TabIndex = 5
        '
        'txt_montoInicial
        '
        Me.txt_montoInicial.Location = New System.Drawing.Point(123, 106)
        Me.txt_montoInicial.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_montoInicial.Name = "txt_montoInicial"
        Me.txt_montoInicial.Size = New System.Drawing.Size(132, 22)
        Me.txt_montoInicial.TabIndex = 4
        '
        'txt_cliente
        '
        Me.txt_cliente.Location = New System.Drawing.Point(123, 48)
        Me.txt_cliente.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_cliente.Name = "txt_cliente"
        Me.txt_cliente.Size = New System.Drawing.Size(132, 22)
        Me.txt_cliente.TabIndex = 3
        '
        'btn_abrirCuenta
        '
        Me.btn_abrirCuenta.Location = New System.Drawing.Point(559, 68)
        Me.btn_abrirCuenta.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_abrirCuenta.Name = "btn_abrirCuenta"
        Me.btn_abrirCuenta.Size = New System.Drawing.Size(100, 28)
        Me.btn_abrirCuenta.TabIndex = 2
        Me.btn_abrirCuenta.Text = "Abrir Cuenta"
        Me.btn_abrirCuenta.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 110)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Monto Inicial"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 52)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cliente:"
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
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegistrarClienteToolStripMenuItem, Me.ConsultaCuentaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
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
        'ConsultaCuentaToolStripMenuItem
        '
        Me.ConsultaCuentaToolStripMenuItem.Name = "ConsultaCuentaToolStripMenuItem"
        Me.ConsultaCuentaToolStripMenuItem.Size = New System.Drawing.Size(130, 24)
        Me.ConsultaCuentaToolStripMenuItem.Text = "Consulta Cuenta"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 887)
        Me.Controls.Add(Me.gbox_cuenta)
        Me.Controls.Add(Me.gbox_transaccion)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.gbox_cuenta.ResumeLayout(False)
        Me.gbox_cuenta.PerformLayout()
        Me.gbox_transaccion.ResumeLayout(False)
        Me.gbox_transaccion.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.error_cliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.error_monto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gbox_cuenta As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_saldo As TextBox
    Friend WithEvents btn_nuevo As Button
    Friend WithEvents lbox_depositos As ListBox
    Friend WithEvents Label4 As Label
    Friend WithEvents lbox_retiro As ListBox
    Friend WithEvents Label3 As Label
    Friend WithEvents gbox_transaccion As GroupBox
    Friend WithEvents btn_generar As Button
    Friend WithEvents rb_retiro As RadioButton
    Friend WithEvents rb_deposito As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txt_cliente As TextBox
    Friend WithEvents btn_abrirCuenta As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents error_cliente As ErrorProvider
    Friend WithEvents error_monto As ErrorProvider
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents txt_montoInicial As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents RegistrarClienteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultaCuentaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents CheckBox1 As CheckBox
End Class
