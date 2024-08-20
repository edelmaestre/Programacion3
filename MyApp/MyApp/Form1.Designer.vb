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
        Me.BottGuardar = New System.Windows.Forms.Button()
        Me.TextDatos = New System.Windows.Forms.TextBox()
        Me.ButtLeer = New System.Windows.Forms.Button()
        Me.Listado = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'BottGuardar
        '
        Me.BottGuardar.Location = New System.Drawing.Point(188, 24)
        Me.BottGuardar.Name = "BottGuardar"
        Me.BottGuardar.Size = New System.Drawing.Size(75, 23)
        Me.BottGuardar.TabIndex = 0
        Me.BottGuardar.Text = "guardar"
        Me.BottGuardar.UseVisualStyleBackColor = True
        '
        'TextDatos
        '
        Me.TextDatos.Location = New System.Drawing.Point(45, 27)
        Me.TextDatos.Name = "TextDatos"
        Me.TextDatos.Size = New System.Drawing.Size(100, 20)
        Me.TextDatos.TabIndex = 1
        '
        'ButtLeer
        '
        Me.ButtLeer.Location = New System.Drawing.Point(188, 70)
        Me.ButtLeer.Name = "ButtLeer"
        Me.ButtLeer.Size = New System.Drawing.Size(75, 23)
        Me.ButtLeer.TabIndex = 2
        Me.ButtLeer.Text = "leer"
        Me.ButtLeer.UseVisualStyleBackColor = True
        '
        'Listado
        '
        Me.Listado.FormattingEnabled = True
        Me.Listado.Location = New System.Drawing.Point(25, 82)
        Me.Listado.Name = "Listado"
        Me.Listado.Size = New System.Drawing.Size(138, 134)
        Me.Listado.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.Listado)
        Me.Controls.Add(Me.ButtLeer)
        Me.Controls.Add(Me.TextDatos)
        Me.Controls.Add(Me.BottGuardar)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BottGuardar As System.Windows.Forms.Button
    Friend WithEvents TextDatos As System.Windows.Forms.TextBox
    Friend WithEvents ButtLeer As System.Windows.Forms.Button
    Friend WithEvents Listado As System.Windows.Forms.ListBox

End Class
