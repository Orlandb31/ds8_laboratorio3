<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registro
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
        Me.l1 = New Guna.UI.WinForms.GunaLabel()
        Me.txt_cedula = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txt_nombre = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txt_apellido = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txt_direccion = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txt_telefono = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.btn_registrar = New Guna.UI.WinForms.GunaButton()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_registrar)
        Me.GroupBox1.Controls.Add(Me.txt_telefono)
        Me.GroupBox1.Controls.Add(Me.txt_direccion)
        Me.GroupBox1.Controls.Add(Me.txt_apellido)
        Me.GroupBox1.Controls.Add(Me.txt_nombre)
        Me.GroupBox1.Controls.Add(Me.txt_cedula)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Silver
        Me.GroupBox1.Location = New System.Drawing.Point(255, 140)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(515, 399)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingrese Datos"
        '
        'l1
        '
        Me.l1.AutoSize = True
        Me.l1.Font = New System.Drawing.Font("Segoe UI", 25.0!, System.Drawing.FontStyle.Bold)
        Me.l1.ForeColor = System.Drawing.Color.Silver
        Me.l1.Location = New System.Drawing.Point(312, 57)
        Me.l1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.l1.Name = "l1"
        Me.l1.Size = New System.Drawing.Size(393, 57)
        Me.l1.TabIndex = 7
        Me.l1.Text = "Registro de cliente"
        Me.l1.Visible = False
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
        Me.txt_cedula.Location = New System.Drawing.Point(42, 28)
        Me.txt_cedula.Margin = New System.Windows.Forms.Padding(5)
        Me.txt_cedula.Name = "txt_cedula"
        Me.txt_cedula.Size = New System.Drawing.Size(206, 54)
        Me.txt_cedula.TabIndex = 8
        Me.txt_cedula.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txt_nombre
        '
        Me.txt_nombre.AutoValidate = System.Windows.Forms.AutoValidate.Disable
        Me.txt_nombre.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_nombre.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txt_nombre.ForeColor = System.Drawing.Color.Silver
        Me.txt_nombre.HintForeColor = System.Drawing.Color.Silver
        Me.txt_nombre.HintText = "Nombre"
        Me.txt_nombre.isPassword = False
        Me.txt_nombre.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.txt_nombre.LineIdleColor = System.Drawing.Color.Gray
        Me.txt_nombre.LineMouseHoverColor = System.Drawing.Color.Silver
        Me.txt_nombre.LineThickness = 3
        Me.txt_nombre.Location = New System.Drawing.Point(283, 28)
        Me.txt_nombre.Margin = New System.Windows.Forms.Padding(5)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(206, 54)
        Me.txt_nombre.TabIndex = 14
        Me.txt_nombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txt_apellido
        '
        Me.txt_apellido.AutoValidate = System.Windows.Forms.AutoValidate.Disable
        Me.txt_apellido.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_apellido.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txt_apellido.ForeColor = System.Drawing.Color.Silver
        Me.txt_apellido.HintForeColor = System.Drawing.Color.Silver
        Me.txt_apellido.HintText = "Cedula"
        Me.txt_apellido.isPassword = False
        Me.txt_apellido.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.txt_apellido.LineIdleColor = System.Drawing.Color.Gray
        Me.txt_apellido.LineMouseHoverColor = System.Drawing.Color.Silver
        Me.txt_apellido.LineThickness = 3
        Me.txt_apellido.Location = New System.Drawing.Point(42, 92)
        Me.txt_apellido.Margin = New System.Windows.Forms.Padding(5)
        Me.txt_apellido.Name = "txt_apellido"
        Me.txt_apellido.Size = New System.Drawing.Size(206, 54)
        Me.txt_apellido.TabIndex = 15
        Me.txt_apellido.Text = "Apellido"
        Me.txt_apellido.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txt_direccion
        '
        Me.txt_direccion.AutoValidate = System.Windows.Forms.AutoValidate.Disable
        Me.txt_direccion.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_direccion.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txt_direccion.ForeColor = System.Drawing.Color.Silver
        Me.txt_direccion.HintForeColor = System.Drawing.Color.Silver
        Me.txt_direccion.HintText = "Cedula"
        Me.txt_direccion.isPassword = False
        Me.txt_direccion.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.txt_direccion.LineIdleColor = System.Drawing.Color.Gray
        Me.txt_direccion.LineMouseHoverColor = System.Drawing.Color.Silver
        Me.txt_direccion.LineThickness = 3
        Me.txt_direccion.Location = New System.Drawing.Point(283, 92)
        Me.txt_direccion.Margin = New System.Windows.Forms.Padding(5)
        Me.txt_direccion.Name = "txt_direccion"
        Me.txt_direccion.Size = New System.Drawing.Size(206, 54)
        Me.txt_direccion.TabIndex = 16
        Me.txt_direccion.Text = "Dirección"
        Me.txt_direccion.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txt_telefono
        '
        Me.txt_telefono.AutoValidate = System.Windows.Forms.AutoValidate.Disable
        Me.txt_telefono.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_telefono.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txt_telefono.ForeColor = System.Drawing.Color.Silver
        Me.txt_telefono.HintForeColor = System.Drawing.Color.Silver
        Me.txt_telefono.HintText = "Cedula"
        Me.txt_telefono.isPassword = False
        Me.txt_telefono.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.txt_telefono.LineIdleColor = System.Drawing.Color.Gray
        Me.txt_telefono.LineMouseHoverColor = System.Drawing.Color.Silver
        Me.txt_telefono.LineThickness = 3
        Me.txt_telefono.Location = New System.Drawing.Point(42, 156)
        Me.txt_telefono.Margin = New System.Windows.Forms.Padding(5)
        Me.txt_telefono.Name = "txt_telefono"
        Me.txt_telefono.Size = New System.Drawing.Size(206, 54)
        Me.txt_telefono.TabIndex = 17
        Me.txt_telefono.Text = "Telefono"
        Me.txt_telefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
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
        Me.btn_registrar.Location = New System.Drawing.Point(96, 287)
        Me.btn_registrar.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_registrar.Name = "btn_registrar"
        Me.btn_registrar.OnHoverBaseColor = System.Drawing.Color.SpringGreen
        Me.btn_registrar.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_registrar.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_registrar.OnHoverImage = Nothing
        Me.btn_registrar.OnPressedColor = System.Drawing.Color.Black
        Me.btn_registrar.Size = New System.Drawing.Size(336, 52)
        Me.btn_registrar.TabIndex = 18
        Me.btn_registrar.Text = "Aceptar"
        Me.btn_registrar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Registro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1067, 554)
        Me.Controls.Add(Me.l1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Registro"
        Me.Text = "Registro"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents l1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txt_cedula As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txt_telefono As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txt_direccion As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txt_apellido As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txt_nombre As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents btn_registrar As Guna.UI.WinForms.GunaButton
End Class
