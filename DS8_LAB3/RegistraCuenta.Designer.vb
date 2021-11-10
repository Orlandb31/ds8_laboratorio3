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
        Me.txt_cedula = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbox_tipoCuenta = New System.Windows.Forms.ComboBox()
        Me.txt_saldo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_crearCuenta = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(307, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Apertura de Cuenta"
        '
        'txt_cedula
        '
        Me.txt_cedula.Location = New System.Drawing.Point(305, 85)
        Me.txt_cedula.Name = "txt_cedula"
        Me.txt_cedula.Size = New System.Drawing.Size(121, 20)
        Me.txt_cedula.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(209, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Cedula"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(209, 129)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Tipo de Cuenta"
        '
        'cbox_tipoCuenta
        '
        Me.cbox_tipoCuenta.FormattingEnabled = True
        Me.cbox_tipoCuenta.Location = New System.Drawing.Point(305, 126)
        Me.cbox_tipoCuenta.Name = "cbox_tipoCuenta"
        Me.cbox_tipoCuenta.Size = New System.Drawing.Size(121, 21)
        Me.cbox_tipoCuenta.TabIndex = 7
        '
        'txt_saldo
        '
        Me.txt_saldo.Location = New System.Drawing.Point(305, 165)
        Me.txt_saldo.Name = "txt_saldo"
        Me.txt_saldo.Size = New System.Drawing.Size(121, 20)
        Me.txt_saldo.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(209, 168)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Saldo"
        '
        'btn_crearCuenta
        '
        Me.btn_crearCuenta.Location = New System.Drawing.Point(305, 221)
        Me.btn_crearCuenta.Name = "btn_crearCuenta"
        Me.btn_crearCuenta.Size = New System.Drawing.Size(128, 23)
        Me.btn_crearCuenta.TabIndex = 10
        Me.btn_crearCuenta.Text = "Crear Cuenta"
        Me.btn_crearCuenta.UseVisualStyleBackColor = True
        '
        'RegistraCuenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_crearCuenta)
        Me.Controls.Add(Me.txt_saldo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cbox_tipoCuenta)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_cedula)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "RegistraCuenta"
        Me.Text = "RegistraCuenta"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txt_cedula As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cbox_tipoCuenta As ComboBox
    Friend WithEvents txt_saldo As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btn_crearCuenta As Button
End Class
