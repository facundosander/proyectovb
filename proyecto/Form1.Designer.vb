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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btIngresar = New System.Windows.Forms.Button()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.txtContra = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.regBtn = New System.Windows.Forms.Button()
        Me.empBtn = New System.Windows.Forms.Button()
        Me.mtnBtn = New System.Windows.Forms.Button()
        Me.admBtn = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btIngresar
        '
        Me.btIngresar.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.btIngresar.Location = New System.Drawing.Point(10, 188)
        Me.btIngresar.Margin = New System.Windows.Forms.Padding(2)
        Me.btIngresar.Name = "btIngresar"
        Me.btIngresar.Size = New System.Drawing.Size(261, 33)
        Me.btIngresar.TabIndex = 0
        Me.btIngresar.Text = "Ingresar"
        Me.btIngresar.UseVisualStyleBackColor = False
        '
        'txtUsuario
        '
        Me.txtUsuario.BackColor = System.Drawing.Color.Linen
        Me.txtUsuario.Location = New System.Drawing.Point(20, 25)
        Me.txtUsuario.Margin = New System.Windows.Forms.Padding(2)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(251, 20)
        Me.txtUsuario.TabIndex = 1
        '
        'txtContra
        '
        Me.txtContra.BackColor = System.Drawing.Color.Linen
        Me.txtContra.Location = New System.Drawing.Point(20, 102)
        Me.txtContra.Margin = New System.Windows.Forms.Padding(2)
        Me.txtContra.Name = "txtContra"
        Me.txtContra.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtContra.Size = New System.Drawing.Size(251, 20)
        Me.txtContra.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(17, 10)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Usuario"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(17, 87)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Contraseña"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(10, 246)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(261, 33)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Atras"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtContra)
        Me.Panel1.Controls.Add(Me.txtUsuario)
        Me.Panel1.Controls.Add(Me.btIngresar)
        Me.Panel1.Location = New System.Drawing.Point(15, 19)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(295, 336)
        Me.Panel1.TabIndex = 6
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), System.Drawing.Image)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.regBtn)
        Me.Panel2.Controls.Add(Me.empBtn)
        Me.Panel2.Controls.Add(Me.mtnBtn)
        Me.Panel2.Controls.Add(Me.admBtn)
        Me.Panel2.Location = New System.Drawing.Point(-14, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(319, 320)
        Me.Panel2.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(31, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(146, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Seleccione su tipo de usuario"
        '
        'regBtn
        '
        Me.regBtn.BackgroundImage = CType(resources.GetObject("regBtn.BackgroundImage"), System.Drawing.Image)
        Me.regBtn.Location = New System.Drawing.Point(100, 236)
        Me.regBtn.Name = "regBtn"
        Me.regBtn.Size = New System.Drawing.Size(122, 23)
        Me.regBtn.TabIndex = 3
        Me.regBtn.Text = "Registrarse"
        Me.regBtn.UseVisualStyleBackColor = True
        '
        'empBtn
        '
        Me.empBtn.BackgroundImage = CType(resources.GetObject("empBtn.BackgroundImage"), System.Drawing.Image)
        Me.empBtn.Location = New System.Drawing.Point(100, 178)
        Me.empBtn.Name = "empBtn"
        Me.empBtn.Size = New System.Drawing.Size(122, 23)
        Me.empBtn.TabIndex = 2
        Me.empBtn.Text = "Empleado"
        Me.empBtn.UseVisualStyleBackColor = True
        '
        'mtnBtn
        '
        Me.mtnBtn.BackgroundImage = CType(resources.GetObject("mtnBtn.BackgroundImage"), System.Drawing.Image)
        Me.mtnBtn.Location = New System.Drawing.Point(100, 117)
        Me.mtnBtn.Name = "mtnBtn"
        Me.mtnBtn.Size = New System.Drawing.Size(122, 23)
        Me.mtnBtn.TabIndex = 1
        Me.mtnBtn.Text = "Mantenimiento"
        Me.mtnBtn.UseVisualStyleBackColor = True
        '
        'admBtn
        '
        Me.admBtn.BackgroundImage = CType(resources.GetObject("admBtn.BackgroundImage"), System.Drawing.Image)
        Me.admBtn.Location = New System.Drawing.Point(100, 55)
        Me.admBtn.Name = "admBtn"
        Me.admBtn.Size = New System.Drawing.Size(122, 23)
        Me.admBtn.TabIndex = 0
        Me.admBtn.Text = "Administrativo"
        Me.admBtn.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackgroundImage = CType(resources.GetObject("Panel3.BackgroundImage"), System.Drawing.Image)
        Me.Panel3.Location = New System.Drawing.Point(4, 22)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(316, 317)
        Me.Panel3.TabIndex = 7
        '
        'Button2
        '
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(267, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(43, 23)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Atras"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(322, 367)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Iniciar sesión"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btIngresar As Button
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents txtContra As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents regBtn As Button
    Friend WithEvents empBtn As Button
    Friend WithEvents mtnBtn As Button
    Friend WithEvents admBtn As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Button2 As Button
End Class
