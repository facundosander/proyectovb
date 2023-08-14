<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.EwewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IngresarToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MantenimientosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevaMaquinariaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IngresarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConfiguraciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CuentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.Location = New System.Drawing.Point(1, 40)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(998, 512)
        Me.Panel1.TabIndex = 3
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.MenuStrip1)
        Me.Panel2.Location = New System.Drawing.Point(1, 1)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1030, 33)
        Me.Panel2.TabIndex = 4
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackgroundImage = CType(resources.GetObject("MenuStrip1.BackgroundImage"), System.Drawing.Image)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EwewToolStripMenuItem, Me.NuevaMaquinariaToolStripMenuItem, Me.ConfiguraciónToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1030, 24)
        Me.MenuStrip1.TabIndex = 10
        Me.MenuStrip1.Text = "Menu1"
        '
        'EwewToolStripMenuItem
        '
        Me.EwewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IngresarToolStripMenuItem2, Me.EditarToolStripMenuItem2, Me.MantenimientosToolStripMenuItem})
        Me.EwewToolStripMenuItem.Name = "EwewToolStripMenuItem"
        Me.EwewToolStripMenuItem.Size = New System.Drawing.Size(106, 20)
        Me.EwewToolStripMenuItem.Text = "Mantenimientos"
        '
        'IngresarToolStripMenuItem2
        '
        Me.IngresarToolStripMenuItem2.Name = "IngresarToolStripMenuItem2"
        Me.IngresarToolStripMenuItem2.Size = New System.Drawing.Size(116, 22)
        Me.IngresarToolStripMenuItem2.Text = "Ingresar"
        '
        'EditarToolStripMenuItem2
        '
        Me.EditarToolStripMenuItem2.Name = "EditarToolStripMenuItem2"
        Me.EditarToolStripMenuItem2.Size = New System.Drawing.Size(116, 22)
        Me.EditarToolStripMenuItem2.Text = "Editar"
        '
        'MantenimientosToolStripMenuItem
        '
        Me.MantenimientosToolStripMenuItem.Name = "MantenimientosToolStripMenuItem"
        Me.MantenimientosToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.MantenimientosToolStripMenuItem.Text = "Ver"
        '
        'NuevaMaquinariaToolStripMenuItem
        '
        Me.NuevaMaquinariaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IngresarToolStripMenuItem, Me.VerToolStripMenuItem})
        Me.NuevaMaquinariaToolStripMenuItem.Name = "NuevaMaquinariaToolStripMenuItem"
        Me.NuevaMaquinariaToolStripMenuItem.Size = New System.Drawing.Size(73, 20)
        Me.NuevaMaquinariaToolStripMenuItem.Text = "Artefactos"
        '
        'IngresarToolStripMenuItem
        '
        Me.IngresarToolStripMenuItem.Name = "IngresarToolStripMenuItem"
        Me.IngresarToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.IngresarToolStripMenuItem.Text = "Ingresar"
        '
        'VerToolStripMenuItem
        '
        Me.VerToolStripMenuItem.Name = "VerToolStripMenuItem"
        Me.VerToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.VerToolStripMenuItem.Text = "Ver"
        '
        'ConfiguraciónToolStripMenuItem
        '
        Me.ConfiguraciónToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CuentasToolStripMenuItem})
        Me.ConfiguraciónToolStripMenuItem.Name = "ConfiguraciónToolStripMenuItem"
        Me.ConfiguraciónToolStripMenuItem.Size = New System.Drawing.Size(95, 20)
        Me.ConfiguraciónToolStripMenuItem.Text = "Configuración"
        '
        'CuentasToolStripMenuItem
        '
        Me.CuentasToolStripMenuItem.Name = "CuentasToolStripMenuItem"
        Me.CuentasToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.CuentasToolStripMenuItem.Text = "Cuentas"
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.CausesValidation = False
        Me.Button1.Location = New System.Drawing.Point(977, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(23, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "X"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1003, 558)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form2"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menú"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents EwewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IngresarToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents EditarToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents MantenimientosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NuevaMaquinariaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IngresarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConfiguraciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CuentasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Button1 As Button
End Class
