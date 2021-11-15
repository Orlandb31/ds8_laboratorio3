<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inicio
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
        Dim Animation1 As Guna.UI.Animation.Animation = New Guna.UI.Animation.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Inicio))
        Me.Label5 = New System.Windows.Forms.Label()
        Me.p1 = New Guna.UI.WinForms.GunaPanel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.l2 = New Guna.UI.WinForms.GunaLabel()
        Me.l3 = New Guna.UI.WinForms.GunaLabel()
        Me.l1 = New Guna.UI.WinForms.GunaLabel()
        Me.anima1 = New Guna.UI.WinForms.GunaTransition(Me.components)
        Me.p2 = New Guna.UI.WinForms.GunaPanel()
        Me.GunaButton1 = New Guna.UI.WinForms.GunaButton()
        Me.BunifuMaterialTextbox2 = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BunifuMaterialTextbox1 = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.p1.SuspendLayout()
        Me.p2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.anima1.SetDecoration(Me.Label5, Guna.UI.Animation.DecorationType.None)
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.Label5.ForeColor = System.Drawing.Color.Silver
        Me.Label5.Location = New System.Drawing.Point(67, 390)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(221, 36)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Castillo,Wencers"
        '
        'p1
        '
        Me.p1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.p1.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.p1.Controls.Add(Me.l3)
        Me.p1.Controls.Add(Me.l2)
        Me.p1.Controls.Add(Me.Label12)
        Me.p1.Controls.Add(Me.Label11)
        Me.p1.Controls.Add(Me.Label10)
        Me.p1.Controls.Add(Me.GunaLabel1)
        Me.p1.Controls.Add(Me.Label5)
        Me.p1.Controls.Add(Me.l1)
        Me.anima1.SetDecoration(Me.p1, Guna.UI.Animation.DecorationType.None)
        Me.p1.Location = New System.Drawing.Point(172, 61)
        Me.p1.Margin = New System.Windows.Forms.Padding(4)
        Me.p1.Name = "p1"
        Me.p1.Size = New System.Drawing.Size(436, 601)
        Me.p1.TabIndex = 11
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.anima1.SetDecoration(Me.Label12, Guna.UI.Animation.DecorationType.None)
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.Label12.ForeColor = System.Drawing.Color.Silver
        Me.Label12.Location = New System.Drawing.Point(67, 498)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(221, 36)
        Me.Label12.TabIndex = 9
        Me.Label12.Text = "Guitierrez,Luis"
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.anima1.SetDecoration(Me.Label11, Guna.UI.Animation.DecorationType.None)
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.Label11.ForeColor = System.Drawing.Color.Silver
        Me.Label11.Location = New System.Drawing.Point(67, 462)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(221, 36)
        Me.Label11.TabIndex = 8
        Me.Label11.Text = "Green,Abraham"
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.anima1.SetDecoration(Me.Label10, Guna.UI.Animation.DecorationType.None)
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.Label10.ForeColor = System.Drawing.Color.Silver
        Me.Label10.Location = New System.Drawing.Point(67, 426)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(221, 36)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "Borrero,Orlando"
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.anima1.SetDecoration(Me.GunaLabel1, Guna.UI.Animation.DecorationType.None)
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.GunaLabel1.ForeColor = System.Drawing.Color.Silver
        Me.GunaLabel1.Location = New System.Drawing.Point(67, 351)
        Me.GunaLabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(111, 25)
        Me.GunaLabel1.TabIndex = 3
        Me.GunaLabel1.Text = "Integrantes:"
        Me.GunaLabel1.Visible = False
        '
        'l2
        '
        Me.l2.AutoSize = True
        Me.anima1.SetDecoration(Me.l2, Guna.UI.Animation.DecorationType.None)
        Me.l2.Font = New System.Drawing.Font("Segoe UI", 18.0!)
        Me.l2.ForeColor = System.Drawing.Color.Silver
        Me.l2.Location = New System.Drawing.Point(211, 233)
        Me.l2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.l2.Name = "l2"
        Me.l2.Size = New System.Drawing.Size(93, 41)
        Me.l2.TabIndex = 2
        Me.l2.Text = "LAB 3"
        Me.l2.Visible = False
        '
        'l3
        '
        Me.l3.AutoSize = True
        Me.anima1.SetDecoration(Me.l3, Guna.UI.Animation.DecorationType.None)
        Me.l3.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.l3.ForeColor = System.Drawing.Color.Silver
        Me.l3.Location = New System.Drawing.Point(209, 274)
        Me.l3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.l3.Name = "l3"
        Me.l3.Size = New System.Drawing.Size(128, 25)
        Me.l3.TabIndex = 1
        Me.l3.Text = "Autenticacíon"
        Me.l3.Visible = False
        '
        'l1
        '
        Me.l1.AutoSize = True
        Me.anima1.SetDecoration(Me.l1, Guna.UI.Animation.DecorationType.None)
        Me.l1.Font = New System.Drawing.Font("Segoe UI", 40.0!, System.Drawing.FontStyle.Bold)
        Me.l1.ForeColor = System.Drawing.Color.Silver
        Me.l1.Location = New System.Drawing.Point(57, 222)
        Me.l1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.l1.Name = "l1"
        Me.l1.Size = New System.Drawing.Size(166, 89)
        Me.l1.TabIndex = 0
        Me.l1.Text = "UTP"
        Me.l1.Visible = False
        '
        'anima1
        '
        Me.anima1.AnimationType = Guna.UI.Animation.AnimationType.Scale
        Me.anima1.Cursor = Nothing
        Animation1.AnimateOnlyDifferences = True
        Animation1.BlindCoeff = CType(resources.GetObject("Animation1.BlindCoeff"), System.Drawing.PointF)
        Animation1.LeafCoeff = 0!
        Animation1.MaxTime = 1.0!
        Animation1.MinTime = 0!
        Animation1.MosaicCoeff = CType(resources.GetObject("Animation1.MosaicCoeff"), System.Drawing.PointF)
        Animation1.MosaicShift = CType(resources.GetObject("Animation1.MosaicShift"), System.Drawing.PointF)
        Animation1.MosaicSize = 0
        Animation1.Padding = New System.Windows.Forms.Padding(0)
        Animation1.RotateCoeff = 0!
        Animation1.RotateLimit = 0!
        Animation1.ScaleCoeff = CType(resources.GetObject("Animation1.ScaleCoeff"), System.Drawing.PointF)
        Animation1.SlideCoeff = CType(resources.GetObject("Animation1.SlideCoeff"), System.Drawing.PointF)
        Animation1.TimeCoeff = 0!
        Animation1.TransparencyCoeff = 0!
        Me.anima1.DefaultAnimation = Animation1
        '
        'p2
        '
        Me.p2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.p2.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.p2.Controls.Add(Me.GunaButton1)
        Me.p2.Controls.Add(Me.BunifuMaterialTextbox2)
        Me.p2.Controls.Add(Me.BunifuMaterialTextbox1)
        Me.anima1.SetDecoration(Me.p2, Guna.UI.Animation.DecorationType.None)
        Me.p2.Location = New System.Drawing.Point(609, 61)
        Me.p2.Margin = New System.Windows.Forms.Padding(4)
        Me.p2.Name = "p2"
        Me.p2.Size = New System.Drawing.Size(436, 601)
        Me.p2.TabIndex = 12
        Me.p2.Visible = False
        '
        'GunaButton1
        '
        Me.GunaButton1.Animated = True
        Me.GunaButton1.AnimationHoverSpeed = 0.07!
        Me.GunaButton1.AnimationSpeed = 0.03!
        Me.GunaButton1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.GunaButton1.BorderColor = System.Drawing.Color.Black
        Me.anima1.SetDecoration(Me.GunaButton1, Guna.UI.Animation.DecorationType.None)
        Me.GunaButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaButton1.ForeColor = System.Drawing.Color.White
        Me.GunaButton1.Image = Nothing
        Me.GunaButton1.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaButton1.Location = New System.Drawing.Point(55, 405)
        Me.GunaButton1.Margin = New System.Windows.Forms.Padding(4)
        Me.GunaButton1.Name = "GunaButton1"
        Me.GunaButton1.OnHoverBaseColor = System.Drawing.Color.SpringGreen
        Me.GunaButton1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton1.OnHoverImage = Nothing
        Me.GunaButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton1.Size = New System.Drawing.Size(336, 52)
        Me.GunaButton1.TabIndex = 2
        Me.GunaButton1.Text = "Sign in"
        Me.GunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BunifuMaterialTextbox2
        '
        Me.BunifuMaterialTextbox2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.anima1.SetDecoration(Me.BunifuMaterialTextbox2, Guna.UI.Animation.DecorationType.None)
        Me.BunifuMaterialTextbox2.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.BunifuMaterialTextbox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuMaterialTextbox2.HintForeColor = System.Drawing.Color.Silver
        Me.BunifuMaterialTextbox2.HintText = "Password"
        Me.BunifuMaterialTextbox2.isPassword = False
        Me.BunifuMaterialTextbox2.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.BunifuMaterialTextbox2.LineIdleColor = System.Drawing.Color.Gray
        Me.BunifuMaterialTextbox2.LineMouseHoverColor = System.Drawing.Color.Silver
        Me.BunifuMaterialTextbox2.LineThickness = 3
        Me.BunifuMaterialTextbox2.Location = New System.Drawing.Point(55, 170)
        Me.BunifuMaterialTextbox2.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuMaterialTextbox2.Name = "BunifuMaterialTextbox2"
        Me.BunifuMaterialTextbox2.Size = New System.Drawing.Size(336, 54)
        Me.BunifuMaterialTextbox2.TabIndex = 1
        Me.BunifuMaterialTextbox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuMaterialTextbox1
        '
        Me.BunifuMaterialTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.anima1.SetDecoration(Me.BunifuMaterialTextbox1, Guna.UI.Animation.DecorationType.None)
        Me.BunifuMaterialTextbox1.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.BunifuMaterialTextbox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuMaterialTextbox1.HintForeColor = System.Drawing.Color.Silver
        Me.BunifuMaterialTextbox1.HintText = "Username"
        Me.BunifuMaterialTextbox1.isPassword = False
        Me.BunifuMaterialTextbox1.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.BunifuMaterialTextbox1.LineIdleColor = System.Drawing.Color.Gray
        Me.BunifuMaterialTextbox1.LineMouseHoverColor = System.Drawing.Color.Silver
        Me.BunifuMaterialTextbox1.LineThickness = 3
        Me.BunifuMaterialTextbox1.Location = New System.Drawing.Point(55, 106)
        Me.BunifuMaterialTextbox1.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuMaterialTextbox1.Name = "BunifuMaterialTextbox1"
        Me.BunifuMaterialTextbox1.Size = New System.Drawing.Size(336, 54)
        Me.BunifuMaterialTextbox1.TabIndex = 0
        Me.BunifuMaterialTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1321, 802)
        Me.Controls.Add(Me.p1)
        Me.Controls.Add(Me.p2)
        Me.anima1.SetDecoration(Me, Guna.UI.Animation.DecorationType.None)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Inicio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        Me.p1.ResumeLayout(False)
        Me.p1.PerformLayout()
        Me.p2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label5 As Label
    Friend WithEvents p1 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents l2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents l3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents l1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents anima1 As Guna.UI.WinForms.GunaTransition
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents p2 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaButton1 As Guna.UI.WinForms.GunaButton
    Friend WithEvents BunifuMaterialTextbox2 As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BunifuMaterialTextbox1 As Bunifu.Framework.UI.BunifuMaterialTextbox
End Class
