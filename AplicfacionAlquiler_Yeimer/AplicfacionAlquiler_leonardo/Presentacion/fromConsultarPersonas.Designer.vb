<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fromConsultarPersonas
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
        Me.grillaConsultarPersonas = New System.Windows.Forms.DataGridView()
        Me.grillacedula = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grillanombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grillasexo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.grillaConsultarPersonas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grillaConsultarPersonas
        '
        Me.grillaConsultarPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grillaConsultarPersonas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.grillacedula, Me.grillanombre, Me.grillasexo})
        Me.grillaConsultarPersonas.Location = New System.Drawing.Point(22, 81)
        Me.grillaConsultarPersonas.Name = "grillaConsultarPersonas"
        Me.grillaConsultarPersonas.Size = New System.Drawing.Size(343, 137)
        Me.grillaConsultarPersonas.TabIndex = 0
        '
        'grillacedula
        '
        Me.grillacedula.HeaderText = "CEDULA"
        Me.grillacedula.Name = "grillacedula"
        '
        'grillanombre
        '
        Me.grillanombre.HeaderText = "NOMBRE"
        Me.grillanombre.Name = "grillanombre"
        '
        'grillasexo
        '
        Me.grillasexo.HeaderText = "SEXO"
        Me.grillasexo.Name = "grillasexo"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft NeoGothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(76, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(241, 28)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "CONSULTAR PERSONAS"
        '
        'fromConsultarPersonas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(389, 271)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.grillaConsultarPersonas)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "fromConsultarPersonas"
        Me.ShowIcon = False
        Me.Text = "fromConsultarPersonas"
        CType(Me.grillaConsultarPersonas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grillaConsultarPersonas As System.Windows.Forms.DataGridView
    Friend WithEvents grillacedula As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grillanombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grillasexo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
