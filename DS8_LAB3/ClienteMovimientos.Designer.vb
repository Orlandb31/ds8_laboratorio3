<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClienteMovimientos
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_Buscar_Cliente = New System.Windows.Forms.Button()
        Me.txt_idcliente = New System.Windows.Forms.TextBox()
        Me.cbox_cuentas = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rbt_Retiro = New System.Windows.Forms.RadioButton()
        Me.rbt_Deposito = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btn_Actualizar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_Monto = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_Buscar_Cliente)
        Me.GroupBox1.Controls.Add(Me.txt_idcliente)
        Me.GroupBox1.Controls.Add(Me.cbox_cuentas)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(69, 41)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(689, 211)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del cliente"
        '
        'btn_Buscar_Cliente
        '
        Me.btn_Buscar_Cliente.Location = New System.Drawing.Point(470, 40)
        Me.btn_Buscar_Cliente.Name = "btn_Buscar_Cliente"
        Me.btn_Buscar_Cliente.Size = New System.Drawing.Size(75, 23)
        Me.btn_Buscar_Cliente.TabIndex = 4
        Me.btn_Buscar_Cliente.Text = "Buscar"
        Me.btn_Buscar_Cliente.UseVisualStyleBackColor = True
        '
        'txt_idcliente
        '
        Me.txt_idcliente.Location = New System.Drawing.Point(256, 40)
        Me.txt_idcliente.Name = "txt_idcliente"
        Me.txt_idcliente.Size = New System.Drawing.Size(121, 22)
        Me.txt_idcliente.TabIndex = 3
        '
        'cbox_cuentas
        '
        Me.cbox_cuentas.FormattingEnabled = True
        Me.cbox_cuentas.Location = New System.Drawing.Point(256, 107)
        Me.cbox_cuentas.Name = "cbox_cuentas"
        Me.cbox_cuentas.Size = New System.Drawing.Size(289, 24)
        Me.cbox_cuentas.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(175, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Cuentas ligadas al usuario"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "cedula"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rbt_Retiro)
        Me.GroupBox2.Controls.Add(Me.rbt_Deposito)
        Me.GroupBox2.Location = New System.Drawing.Point(69, 278)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(688, 97)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Transacciones"
        '
        'rbt_Retiro
        '
        Me.rbt_Retiro.AutoSize = True
        Me.rbt_Retiro.Location = New System.Drawing.Point(382, 55)
        Me.rbt_Retiro.Name = "rbt_Retiro"
        Me.rbt_Retiro.Size = New System.Drawing.Size(67, 21)
        Me.rbt_Retiro.TabIndex = 1
        Me.rbt_Retiro.TabStop = True
        Me.rbt_Retiro.Text = "Retiro"
        Me.rbt_Retiro.UseVisualStyleBackColor = True
        '
        'rbt_Deposito
        '
        Me.rbt_Deposito.AutoSize = True
        Me.rbt_Deposito.Location = New System.Drawing.Point(101, 55)
        Me.rbt_Deposito.Name = "rbt_Deposito"
        Me.rbt_Deposito.Size = New System.Drawing.Size(85, 21)
        Me.rbt_Deposito.TabIndex = 0
        Me.rbt_Deposito.TabStop = True
        Me.rbt_Deposito.Text = "Deposito"
        Me.rbt_Deposito.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btn_Actualizar)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.txt_Monto)
        Me.GroupBox3.Location = New System.Drawing.Point(67, 407)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(690, 139)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Deposito/Retiro"
        '
        'btn_Actualizar
        '
        Me.btn_Actualizar.AutoSize = True
        Me.btn_Actualizar.Location = New System.Drawing.Point(456, 72)
        Me.btn_Actualizar.Name = "btn_Actualizar"
        Me.btn_Actualizar.Size = New System.Drawing.Size(91, 28)
        Me.btn_Actualizar.TabIndex = 2
        Me.btn_Actualizar.Text = "Actualizar"
        Me.btn_Actualizar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(38, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 17)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Monto"
        '
        'txt_Monto
        '
        Me.txt_Monto.Location = New System.Drawing.Point(228, 75)
        Me.txt_Monto.Name = "txt_Monto"
        Me.txt_Monto.Size = New System.Drawing.Size(100, 22)
        Me.txt_Monto.TabIndex = 0
        '
        'ClienteMovimientos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 560)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "ClienteMovimientos"
        Me.Text = "ClienteMovimientos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_Buscar_Cliente As Button
    Friend WithEvents txt_idcliente As TextBox
    Friend WithEvents cbox_cuentas As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents rbt_Retiro As RadioButton
    Friend WithEvents rbt_Deposito As RadioButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btn_Actualizar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_Monto As TextBox
End Class
