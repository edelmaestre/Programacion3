<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fromAlquiler
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
        Me.grillaAlquiler = New System.Windows.Forms.DataGridView()
        Me.grillacedula = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grillanombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grillasexo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grillaseleccinar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.txtPlaca = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnBuscar = New System.Windows.Forms.Button()
        CType(Me.grillaAlquiler, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grillaAlquiler
        '
        Me.grillaAlquiler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grillaAlquiler.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.grillacedula, Me.grillanombre, Me.grillasexo, Me.grillaseleccinar})
        Me.grillaAlquiler.Location = New System.Drawing.Point(50, 166)
        Me.grillaAlquiler.Name = "grillaAlquiler"
        Me.grillaAlquiler.Size = New System.Drawing.Size(447, 159)
        Me.grillaAlquiler.TabIndex = 0
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
        'grillaseleccinar
        '
        Me.grillaseleccinar.HeaderText = "SELECCIONAR"
        Me.grillaseleccinar.Name = "grillaseleccinar"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.txtPlaca)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(65, 35)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(284, 100)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(121, 57)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(133, 20)
        Me.DateTimePicker1.TabIndex = 3
        '
        'txtPlaca
        '
        Me.txtPlaca.Enabled = False
        Me.txtPlaca.Location = New System.Drawing.Point(121, 16)
        Me.txtPlaca.Name = "txtPlaca"
        Me.txtPlaca.Size = New System.Drawing.Size(133, 20)
        Me.txtPlaca.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(43, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "FECHA"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(44, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PLACA"
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(391, 72)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 2
        Me.btnBuscar.Text = "BUSCAR"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'fromAlquiler
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(520, 361)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grillaAlquiler)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "fromAlquiler"
        Me.ShowIcon = False
        Me.Text = "fromAlquiler"
        CType(Me.grillaAlquiler, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grillaAlquiler As System.Windows.Forms.DataGridView
    Friend WithEvents grillacedula As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grillanombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grillasexo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grillaseleccinar As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtPlaca As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
End Class
