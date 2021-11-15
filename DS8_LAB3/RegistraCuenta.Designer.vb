<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistraCuenta
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
        Me.l1 = New Guna.UI.WinForms.GunaLabel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbox_tipoCuenta = New System.Windows.Forms.ComboBox()
        Me.btn_registrar = New Guna.UI.WinForms.GunaButton()
        Me.txt_saldo = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txt_cedula = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(228, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 0
        '
        'l1
        '
        Me.l1.AutoSize = True
        Me.l1.Font = New System.Drawing.Font("Segoe UI", 25.0!, System.Drawing.FontStyle.Bold)
        Me.l1.ForeColor = System.Drawing.Color.Silver
        Me.l1.Location = New System.Drawing.Point(162, 53)
        Me.l1.Name = "l1"
        Me.l1.Size = New System.Drawing.Size(333, 46)
        Me.l1.TabIndex = 11
        Me.l1.Text = "Apertura de Cuenta"
        Me.l1.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cbox_tipoCuenta)
        Me.GroupBox1.Controls.Add(Me.btn_registrar)
        Me.GroupBox1.Controls.Add(Me.txt_saldo)
        Me.GroupBox1.Controls.Add(Me.txt_cedula)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Silver
        Me.GroupBox1.Location = New System.Drawing.Point(131, 116)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(386, 324)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingrese Datos"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Label2.Location = New System.Drawing.Point(104, 95)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 17)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Tipo De Cuenta"
        '
        'cbox_tipoCuenta
        '
        Me.cbox_tipoCuenta.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.cbox_tipoCuenta.ForeColor = System.Drawing.Color.Silver
        Me.cbox_tipoCuenta.FormattingEnabled = True
        Me.cbox_tipoCuenta.Location = New System.Drawing.Point(107, 123)
        Me.cbox_tipoCuenta.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cbox_tipoCuenta.Name = "cbox_tipoCuenta"
        Me.cbox_tipoCuenta.Size = New System.Drawing.Size(163, 25)
        Me.cbox_tipoCuenta.TabIndex = 19
        '
        'btn_registrar
        '
        Me.btn_registrar.Animated = True
        Me.btn_registrar.AnimationHoverSpeed = 0.07!
        Me.btn_registrar.AnimationSpeed = 0.03!
        Me.btn_registrar.BaseColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.btn_registrar.BorderColor = System.Drawing.Color.Black
        Me.btn_registrar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_registrar.FocusedColor = System.Drawing.Color.Empty
        Me.btn_registrar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btn_registrar.ForeColor = System.Drawing.Color.White
        Me.btn_registrar.Image = Nothing
        Me.btn_registrar.ImageSize = New System.Drawing.Size(20, 20)
        Me.btn_registrar.Location = New System.Drawing.Point(72, 233)
        Me.btn_registrar.Name = "btn_registrar"
        Me.btn_registrar.OnHoverBaseColor = System.Drawing.Color.SpringGreen
        Me.btn_registrar.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_registrar.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_registrar.OnHoverImage = Nothing
        Me.btn_registrar.OnPressedColor = System.Drawing.Color.Black
        Me.btn_registrar.Size = New System.Drawing.Size(252, 42)
        Me.btn_registrar.TabIndex = 18
        Me.btn_registrar.Text = "Crear Cuenta "
        Me.btn_registrar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_saldo
        '
        Me.txt_saldo.AutoValidate = System.Windows.Forms.AutoValidate.Disable
        Me.txt_saldo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_saldo.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txt_saldo.ForeColor = System.Drawing.Color.Silver
        Me.txt_saldo.HintForeColor = System.Drawing.Color.Silver
        Me.txt_saldo.HintText = "Cedula"
        Me.txt_saldo.isPassword = False
        Me.txt_saldo.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.txt_saldo.LineIdleColor = System.Drawing.Color.Gray
        Me.txt_saldo.LineMouseHoverColor = System.Drawing.Color.Silver
        Me.txt_saldo.LineThickness = 3
        Me.txt_saldo.Location = New System.Drawing.Point(107, 152)
        Me.txt_saldo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_saldo.Name = "txt_saldo"
        Me.txt_saldo.Size = New System.Drawing.Size(154, 44)
        Me.txt_saldo.TabIndex = 15
        Me.txt_saldo.Text = "Saldo"
        Me.txt_saldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txt_cedula
        '
        Me.txt_cedula.AutoValidate = System.Windows.Forms.AutoValidate.Disable
        Me.txt_cedula.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_cedula.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txt_cedula.ForeColor = System.Drawing.Color.Silver
        Me.txt_cedula.HintForeColor = System.Drawing.Color.Silver
        Me.txt_cedula.HintText = "Cedula"
        Me.txt_cedula.isPassword = False
        Me.txt_cedula.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.txt_cedula.LineIdleColor = System.Drawing.Color.Gray
        Me.txt_cedula.LineMouseHoverColor = System.Drawing.Color.Silver
        Me.txt_cedula.LineThickness = 3
        Me.txt_cedula.Location = New System.Drawing.Point(107, 31)
        Me.txt_cedula.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_cedula.Name = "txt_cedula"
        Me.txt_cedula.Size = New System.Drawing.Size(154, 44)
        Me.txt_cedula.TabIndex = 8
        Me.txt_cedula.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'RegistraCuenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(663, 475)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.l1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "RegistraCuenta"
        Me.Text = "RegistraCuenta"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents l1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btn_registrar As Guna.UI.WinForms.GunaButton
    Friend WithEvents txt_saldo As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txt_cedula As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents cbox_tipoCuenta As ComboBox
    Friend WithEvents Label2 As Label
End Class
