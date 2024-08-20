<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Agenda
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
        Me.contactos = New System.Windows.Forms.Button()
        Me.consultar = New System.Windows.Forms.Button()
        Me.salir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'contactos
        '
        Me.contactos.Location = New System.Drawing.Point(12, 12)
        Me.contactos.Name = "contactos"
        Me.contactos.Size = New System.Drawing.Size(82, 30)
        Me.contactos.TabIndex = 0
        Me.contactos.Text = "Contactos"
        Me.contactos.UseVisualStyleBackColor = True
        '
        'consultar
        '
        Me.consultar.Location = New System.Drawing.Point(12, 48)
        Me.consultar.Name = "consultar"
        Me.consultar.Size = New System.Drawing.Size(82, 25)
        Me.consultar.TabIndex = 1
        Me.consultar.Text = "Consultar"
        Me.consultar.UseVisualStyleBackColor = True
        '
        'salir
        '
        Me.salir.Location = New System.Drawing.Point(12, 81)
        Me.salir.Name = "salir"
        Me.salir.Size = New System.Drawing.Size(82, 22)
        Me.salir.TabIndex = 2
        Me.salir.Text = "salir"
        Me.salir.UseVisualStyleBackColor = True
        '
        'Agenda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.salir)
        Me.Controls.Add(Me.consultar)
        Me.Controls.Add(Me.contactos)
        Me.Name = "Agenda"
        Me.Text = "Agenda"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents contactos As System.Windows.Forms.Button
    Friend WithEvents consultar As System.Windows.Forms.Button
    Friend WithEvents salir As System.Windows.Forms.Button

End Class
