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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.PROCESARMOTOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NUEVOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CONSULTARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PROCESARPERSONASToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NUEVOToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CONSULTARToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PROCESARALQUILERToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NUEVOToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CONSULTARToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PROCESARMOTOSToolStripMenuItem, Me.PROCESARPERSONASToolStripMenuItem, Me.PROCESARALQUILERToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(574, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PROCESARMOTOSToolStripMenuItem
        '
        Me.PROCESARMOTOSToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NUEVOToolStripMenuItem, Me.CONSULTARToolStripMenuItem})
        Me.PROCESARMOTOSToolStripMenuItem.Name = "PROCESARMOTOSToolStripMenuItem"
        Me.PROCESARMOTOSToolStripMenuItem.Size = New System.Drawing.Size(122, 20)
        Me.PROCESARMOTOSToolStripMenuItem.Text = "PROCESAR MOTOS"
        '
        'NUEVOToolStripMenuItem
        '
        Me.NUEVOToolStripMenuItem.Name = "NUEVOToolStripMenuItem"
        Me.NUEVOToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.NUEVOToolStripMenuItem.Text = "NUEVO"
        '
        'CONSULTARToolStripMenuItem
        '
        Me.CONSULTARToolStripMenuItem.Name = "CONSULTARToolStripMenuItem"
        Me.CONSULTARToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.CONSULTARToolStripMenuItem.Text = "CONSULTAR"
        '
        'PROCESARPERSONASToolStripMenuItem
        '
        Me.PROCESARPERSONASToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NUEVOToolStripMenuItem1, Me.CONSULTARToolStripMenuItem1})
        Me.PROCESARPERSONASToolStripMenuItem.Name = "PROCESARPERSONASToolStripMenuItem"
        Me.PROCESARPERSONASToolStripMenuItem.Size = New System.Drawing.Size(138, 20)
        Me.PROCESARPERSONASToolStripMenuItem.Text = "PROCESAR PERSONAS"
        '
        'NUEVOToolStripMenuItem1
        '
        Me.NUEVOToolStripMenuItem1.Name = "NUEVOToolStripMenuItem1"
        Me.NUEVOToolStripMenuItem1.Size = New System.Drawing.Size(142, 22)
        Me.NUEVOToolStripMenuItem1.Text = "NUEVO"
        '
        'CONSULTARToolStripMenuItem1
        '
        Me.CONSULTARToolStripMenuItem1.Name = "CONSULTARToolStripMenuItem1"
        Me.CONSULTARToolStripMenuItem1.Size = New System.Drawing.Size(142, 22)
        Me.CONSULTARToolStripMenuItem1.Text = "CONSULTAR"
        '
        'PROCESARALQUILERToolStripMenuItem
        '
        Me.PROCESARALQUILERToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NUEVOToolStripMenuItem2, Me.CONSULTARToolStripMenuItem2})
        Me.PROCESARALQUILERToolStripMenuItem.Name = "PROCESARALQUILERToolStripMenuItem"
        Me.PROCESARALQUILERToolStripMenuItem.Size = New System.Drawing.Size(133, 20)
        Me.PROCESARALQUILERToolStripMenuItem.Text = "PROCESAR ALQUILER"
        '
        'NUEVOToolStripMenuItem2
        '
        Me.NUEVOToolStripMenuItem2.Name = "NUEVOToolStripMenuItem2"
        Me.NUEVOToolStripMenuItem2.Size = New System.Drawing.Size(142, 22)
        Me.NUEVOToolStripMenuItem2.Text = "NUEVO"
        '
        'CONSULTARToolStripMenuItem2
        '
        Me.CONSULTARToolStripMenuItem2.Name = "CONSULTARToolStripMenuItem2"
        Me.CONSULTARToolStripMenuItem2.Size = New System.Drawing.Size(142, 22)
        Me.CONSULTARToolStripMenuItem2.Text = "CONSULTAR"
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(499, 0)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 2
        Me.btnSalir.Text = "SALIR"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.AplicfacionAlquiler_Yeimer.My.Resources.Resources._5FC
        Me.ClientSize = New System.Drawing.Size(574, 452)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.Text = ".:. APLICACION ALQUILER .:."
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents PROCESARMOTOSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NUEVOToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CONSULTARToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PROCESARPERSONASToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NUEVOToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CONSULTARToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PROCESARALQUILERToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NUEVOToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CONSULTARToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnSalir As System.Windows.Forms.Button

End Class
