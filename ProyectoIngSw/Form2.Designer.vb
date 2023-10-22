<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.TurnoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IndexToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InventarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SimulacionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CajaYVentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TurnoToolStripMenuItem, Me.IndexToolStripMenuItem, Me.InventarioToolStripMenuItem, Me.SimulacionToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(324, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'TurnoToolStripMenuItem
        '
        Me.TurnoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VentasToolStripMenuItem})
        Me.TurnoToolStripMenuItem.Image = Global.ProyectoIngSw.My.Resources.Resources.book
        Me.TurnoToolStripMenuItem.Name = "TurnoToolStripMenuItem"
        Me.TurnoToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.TurnoToolStripMenuItem.Text = "Turno"
        '
        'VentasToolStripMenuItem
        '
        Me.VentasToolStripMenuItem.Name = "VentasToolStripMenuItem"
        Me.VentasToolStripMenuItem.Size = New System.Drawing.Size(108, 22)
        Me.VentasToolStripMenuItem.Text = "Ventas"
        '
        'IndexToolStripMenuItem
        '
        Me.IndexToolStripMenuItem.Image = Global.ProyectoIngSw.My.Resources.Resources.cylinder_solid_24
        Me.IndexToolStripMenuItem.Name = "IndexToolStripMenuItem"
        Me.IndexToolStripMenuItem.Size = New System.Drawing.Size(64, 20)
        Me.IndexToolStripMenuItem.Text = "Index"
        '
        'InventarioToolStripMenuItem
        '
        Me.InventarioToolStripMenuItem.Image = Global.ProyectoIngSw.My.Resources.Resources.clipboard_regular_24
        Me.InventarioToolStripMenuItem.Name = "InventarioToolStripMenuItem"
        Me.InventarioToolStripMenuItem.Size = New System.Drawing.Size(88, 20)
        Me.InventarioToolStripMenuItem.Text = "Inventario"
        '
        'SimulacionToolStripMenuItem
        '
        Me.SimulacionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CajaYVentasToolStripMenuItem})
        Me.SimulacionToolStripMenuItem.Image = Global.ProyectoIngSw.My.Resources.Resources.face_solid_24
        Me.SimulacionToolStripMenuItem.Name = "SimulacionToolStripMenuItem"
        Me.SimulacionToolStripMenuItem.Size = New System.Drawing.Size(94, 20)
        Me.SimulacionToolStripMenuItem.Text = "Simulacion"
        '
        'CajaYVentasToolStripMenuItem
        '
        Me.CajaYVentasToolStripMenuItem.Name = "CajaYVentasToolStripMenuItem"
        Me.CajaYVentasToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.CajaYVentasToolStripMenuItem.Text = "Caja y Ventas"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Brown
        Me.ClientSize = New System.Drawing.Size(324, 340)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form2"
        Me.Text = "Menu"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents TurnoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IndexToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VentasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InventarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SimulacionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CajaYVentasToolStripMenuItem As ToolStripMenuItem
End Class
