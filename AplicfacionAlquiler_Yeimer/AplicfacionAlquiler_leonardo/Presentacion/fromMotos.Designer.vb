<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fromMotos
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtKilometraje = New System.Windows.Forms.TextBox()
        Me.txtModelo = New System.Windows.Forms.TextBox()
        Me.txtPlaca = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.txtKilometraje)
        Me.GroupBox1.Controls.Add(Me.txtModelo)
        Me.GroupBox1.Controls.Add(Me.txtPlaca)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(29, 69)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(318, 128)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'txtKilometraje
        '
        Me.txtKilometraje.Location = New System.Drawing.Point(134, 86)
        Me.txtKilometraje.Name = "txtKilometraje"
        Me.txtKilometraje.Size = New System.Drawing.Size(144, 20)
        Me.txtKilometraje.TabIndex = 5
        '
        'txtModelo
        '
        Me.txtModelo.Location = New System.Drawing.Point(134, 54)
        Me.txtModelo.Name = "txtModelo"
        Me.txtModelo.Size = New System.Drawing.Size(144, 20)
        Me.txtModelo.TabIndex = 4
        '
        'txtPlaca
        '
        Me.txtPlaca.Location = New System.Drawing.Point(134, 20)
        Me.txtPlaca.Name = "txtPlaca"
        Me.txtPlaca.Size = New System.Drawing.Size(144, 20)
        Me.txtPlaca.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(32, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "KILOMETRAJE"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "MODELO"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PLACA"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.txtDescripcion)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(30, 203)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(317, 103)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(124, 16)
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(172, 81)
        Me.txtDescripcion.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(23, 49)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "DESCRIPCION"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox3.Controls.Add(Me.btnSalir)
        Me.GroupBox3.Controls.Add(Me.btnModificar)
        Me.GroupBox3.Controls.Add(Me.btnEliminar)
        Me.GroupBox3.Controls.Add(Me.btnBuscar)
        Me.GroupBox3.Controls.Add(Me.btnGuardar)
        Me.GroupBox3.Controls.Add(Me.btnNuevo)
        Me.GroupBox3.Location = New System.Drawing.Point(30, 312)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(317, 94)
        Me.GroupBox3.TabIndex = 7
        Me.GroupBox3.TabStop = False
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(232, 55)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(64, 24)
        Me.btnSalir.TabIndex = 5
        Me.btnSalir.Text = "SALIR"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(124, 55)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(64, 24)
        Me.btnModificar.TabIndex = 4
        Me.btnModificar.Text = "MODIFICAR"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(9, 55)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(64, 24)
        Me.btnEliminar.TabIndex = 3
        Me.btnEliminar.Text = "ELIMINAR"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(230, 9)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(64, 24)
        Me.btnBuscar.TabIndex = 2
        Me.btnBuscar.Text = "BUSCAR"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(124, 9)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(64, 24)
        Me.btnGuardar.TabIndex = 1
        Me.btnGuardar.Text = "GUARDAR"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(9, 9)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(64, 24)
        Me.btnNuevo.TabIndex = 0
        Me.btnNuevo.Text = "NUEVO"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft NeoGothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(88, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(209, 28)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "CAPTURA DE DATOS"
        '
        'fromMotos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(380, 419)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "fromMotos"
        Me.Text = "fromMotos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtKilometraje As System.Windows.Forms.TextBox
    Friend WithEvents txtModelo As System.Windows.Forms.TextBox
    Friend WithEvents txtPlaca As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
