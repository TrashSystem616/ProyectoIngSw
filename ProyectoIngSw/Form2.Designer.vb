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
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.PlanificacionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.InventarioGeneralToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip2
        '
        Me.MenuStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ToolStripMenuItem3, Me.ToolStripMenuItem4, Me.ToolStripMenuItem5})
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip2.Size = New System.Drawing.Size(334, 24)
        Me.MenuStrip2.TabIndex = 1
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem2, Me.ToolStripSeparator1, Me.PlanificacionToolStripMenuItem})
        Me.ToolStripMenuItem1.Image = Global.ProyectoIngSw.My.Resources.Resources.book
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(66, 20)
        Me.ToolStripMenuItem1.Text = "Turno"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Image = Global.ProyectoIngSw.My.Resources.Resources.clipboard_regular_24
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(180, 22)
        Me.ToolStripMenuItem2.Text = "Informe"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(177, 6)
        '
        'PlanificacionToolStripMenuItem
        '
        Me.PlanificacionToolStripMenuItem.Image = Global.ProyectoIngSw.My.Resources.Resources.cylinder_solid_24
        Me.PlanificacionToolStripMenuItem.Name = "PlanificacionToolStripMenuItem"
        Me.PlanificacionToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.PlanificacionToolStripMenuItem.Text = "Planificacion"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VentasToolStripMenuItem})
        Me.ToolStripMenuItem3.Image = Global.ProyectoIngSw.My.Resources.Resources.cylinder_solid_24
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(64, 20)
        Me.ToolStripMenuItem3.Text = "Index"
        '
        'VentasToolStripMenuItem
        '
        Me.VentasToolStripMenuItem.Image = Global.ProyectoIngSw.My.Resources.Resources.cart_regular_24
        Me.VentasToolStripMenuItem.Name = "VentasToolStripMenuItem"
        Me.VentasToolStripMenuItem.Size = New System.Drawing.Size(108, 22)
        Me.VentasToolStripMenuItem.Text = "Ventas"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InventarioGeneralToolStripMenuItem})
        Me.ToolStripMenuItem4.Image = Global.ProyectoIngSw.My.Resources.Resources.clipboard_regular_24
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(88, 20)
        Me.ToolStripMenuItem4.Text = "Inventario"
        '
        'InventarioGeneralToolStripMenuItem
        '
        Me.InventarioGeneralToolStripMenuItem.Image = Global.ProyectoIngSw.My.Resources.Resources.book
        Me.InventarioGeneralToolStripMenuItem.Name = "InventarioGeneralToolStripMenuItem"
        Me.InventarioGeneralToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.InventarioGeneralToolStripMenuItem.Text = "Inventario General"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem6})
        Me.ToolStripMenuItem5.Image = Global.ProyectoIngSw.My.Resources.Resources.face_solid_24
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(94, 20)
        Me.ToolStripMenuItem5.Text = "Simulacion"
        '
        'ToolStripMenuItem6
        '
        Me.ToolStripMenuItem6.Image = Global.ProyectoIngSw.My.Resources.Resources.cart_regular_24
        Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        Me.ToolStripMenuItem6.Size = New System.Drawing.Size(97, 22)
        Me.ToolStripMenuItem6.Text = "Caja"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ProyectoIngSw.My.Resources.Resources.LogoKFC
        Me.PictureBox1.Location = New System.Drawing.Point(24, 37)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(285, 235)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Brown
        Me.ClientSize = New System.Drawing.Size(334, 274)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu"
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem6 As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents VentasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InventarioGeneralToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents PlanificacionToolStripMenuItem As ToolStripMenuItem
End Class
