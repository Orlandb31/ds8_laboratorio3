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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rbt_Retiro = New System.Windows.Forms.RadioButton()
        Me.rbt_Deposito = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btn_actualizar = New Guna.UI.WinForms.GunaButton()
        Me.txt_Monto = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbox_cuentas = New System.Windows.Forms.ComboBox()
        Me.btn_buscarCliente = New Guna.UI.WinForms.GunaButton()
        Me.txt_idcliente = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.l1 = New Guna.UI.WinForms.GunaLabel()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rbt_Retiro)
        Me.GroupBox2.Controls.Add(Me.rbt_Deposito)
        Me.GroupBox2.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Silver
        Me.GroupBox2.Location = New System.Drawing.Point(67, 388)
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
        Me.rbt_Retiro.Size = New System.Drawing.Size(78, 25)
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
        Me.rbt_Deposito.Size = New System.Drawing.Size(106, 25)
        Me.rbt_Deposito.TabIndex = 0
        Me.rbt_Deposito.TabStop = True
        Me.rbt_Deposito.Text = "Deposito"
        Me.rbt_Deposito.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btn_actualizar)
        Me.GroupBox3.Controls.Add(Me.txt_Monto)
        Me.GroupBox3.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.GroupBox3.ForeColor = System.Drawing.Color.Silver
        Me.GroupBox3.Location = New System.Drawing.Point(154, 510)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(460, 197)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Deposito/Retiro"
        '
        'btn_actualizar
        '
        Me.btn_actualizar.Animated = True
        Me.btn_actualizar.AnimationHoverSpeed = 0.07!
        Me.btn_actualizar.AnimationSpeed = 0.03!
        Me.btn_actualizar.BaseColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.btn_actualizar.BorderColor = System.Drawing.Color.Black
        Me.btn_actualizar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_actualizar.FocusedColor = System.Drawing.Color.Empty
        Me.btn_actualizar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btn_actualizar.ForeColor = System.Drawing.Color.White
        Me.btn_actualizar.Image = Nothing
        Me.btn_actualizar.ImageSize = New System.Drawing.Size(20, 20)
        Me.btn_actualizar.Location = New System.Drawing.Point(130, 128)
        Me.btn_actualizar.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_actualizar.Name = "btn_actualizar"
        Me.btn_actualizar.OnHoverBaseColor = System.Drawing.Color.SpringGreen
        Me.btn_actualizar.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_actualizar.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_actualizar.OnHoverImage = Nothing
        Me.btn_actualizar.OnPressedColor = System.Drawing.Color.Black
        Me.btn_actualizar.Size = New System.Drawing.Size(196, 42)
        Me.btn_actualizar.TabIndex = 19
        Me.btn_actualizar.Text = "Actualizar"
        Me.btn_actualizar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_Monto
        '
        Me.txt_Monto.AutoValidate = System.Windows.Forms.AutoValidate.Disable
        Me.txt_Monto.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_Monto.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txt_Monto.ForeColor = System.Drawing.Color.Silver
        Me.txt_Monto.HintForeColor = System.Drawing.Color.Silver
        Me.txt_Monto.HintText = "Monto"
        Me.txt_Monto.isPassword = False
        Me.txt_Monto.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.txt_Monto.LineIdleColor = System.Drawing.Color.Gray
        Me.txt_Monto.LineMouseHoverColor = System.Drawing.Color.Silver
        Me.txt_Monto.LineThickness = 3
        Me.txt_Monto.Location = New System.Drawing.Point(20, 32)
        Me.txt_Monto.Margin = New System.Windows.Forms.Padding(5)
        Me.txt_Monto.Name = "txt_Monto"
        Me.txt_Monto.Size = New System.Drawing.Size(206, 54)
        Me.txt_Monto.TabIndex = 9
        Me.txt_Monto.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.cbox_cuentas)
        Me.GroupBox4.Controls.Add(Me.btn_buscarCliente)
        Me.GroupBox4.Controls.Add(Me.txt_idcliente)
        Me.GroupBox4.ForeColor = System.Drawing.Color.Silver
        Me.GroupBox4.Location = New System.Drawing.Point(130, 117)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Size = New System.Drawing.Size(499, 254)
        Me.GroupBox4.TabIndex = 13
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Datos del Cliente"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Label4.Location = New System.Drawing.Point(43, 119)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(142, 21)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Tipo De Cuenta"
        '
        'cbox_cuentas
        '
        Me.cbox_cuentas.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.cbox_cuentas.ForeColor = System.Drawing.Color.Silver
        Me.cbox_cuentas.FormattingEnabled = True
        Me.cbox_cuentas.Location = New System.Drawing.Point(205, 119)
        Me.cbox_cuentas.Name = "cbox_cuentas"
        Me.cbox_cuentas.Size = New System.Drawing.Size(216, 29)
        Me.cbox_cuentas.TabIndex = 19
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
        Me.btn_buscarCliente.Location = New System.Drawing.Point(143, 180)
        Me.btn_buscarCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_buscarCliente.Name = "btn_buscarCliente"
        Me.btn_buscarCliente.OnHoverBaseColor = System.Drawing.Color.SpringGreen
        Me.btn_buscarCliente.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_buscarCliente.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_buscarCliente.OnHoverImage = Nothing
        Me.btn_buscarCliente.OnPressedColor = System.Drawing.Color.Black
        Me.btn_buscarCliente.Size = New System.Drawing.Size(196, 42)
        Me.btn_buscarCliente.TabIndex = 18
        Me.btn_buscarCliente.Text = "Buscar"
        Me.btn_buscarCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_idcliente
        '
        Me.txt_idcliente.AutoValidate = System.Windows.Forms.AutoValidate.Disable
        Me.txt_idcliente.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_idcliente.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txt_idcliente.ForeColor = System.Drawing.Color.Silver
        Me.txt_idcliente.HintForeColor = System.Drawing.Color.Silver
        Me.txt_idcliente.HintText = "Cedula"
        Me.txt_idcliente.isPassword = False
        Me.txt_idcliente.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.txt_idcliente.LineIdleColor = System.Drawing.Color.Gray
        Me.txt_idcliente.LineMouseHoverColor = System.Drawing.Color.Silver
        Me.txt_idcliente.LineThickness = 3
        Me.txt_idcliente.Location = New System.Drawing.Point(38, 36)
        Me.txt_idcliente.Margin = New System.Windows.Forms.Padding(5)
        Me.txt_idcliente.Name = "txt_idcliente"
        Me.txt_idcliente.Size = New System.Drawing.Size(206, 54)
        Me.txt_idcliente.TabIndex = 8
        Me.txt_idcliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'l1
        '
        Me.l1.AutoSize = True
        Me.l1.Font = New System.Drawing.Font("Segoe UI", 25.0!, System.Drawing.FontStyle.Bold)
        Me.l1.ForeColor = System.Drawing.Color.Silver
        Me.l1.Location = New System.Drawing.Point(133, 24)
        Me.l1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.l1.Name = "l1"
        Me.l1.Size = New System.Drawing.Size(491, 57)
        Me.l1.TabIndex = 14
        Me.l1.Text = "Deposito/Retiro Cliente"
        Me.l1.Visible = False
        '
        'ClienteMovimientos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(818, 750)
        Me.Controls.Add(Me.l1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ClienteMovimientos"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Text = "ClienteMovimientos"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents rbt_Retiro As RadioButton
    Friend WithEvents rbt_Deposito As RadioButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cbox_cuentas As ComboBox
    Friend WithEvents btn_buscarCliente As Guna.UI.WinForms.GunaButton
    Friend WithEvents txt_idcliente As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents l1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txt_Monto As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents btn_actualizar As Guna.UI.WinForms.GunaButton
End Class
