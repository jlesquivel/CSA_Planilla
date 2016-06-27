<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cuEmpleado
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.tCedula = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.tNombre = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.tApellidos = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.tContrato = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.tCategoria = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.SuspendLayout()
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX1.Location = New System.Drawing.Point(126, 14)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(75, 23)
        Me.LabelX1.TabIndex = 0
        Me.LabelX1.Text = "Nombre"
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX2.Location = New System.Drawing.Point(14, 14)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(75, 23)
        Me.LabelX2.TabIndex = 1
        Me.LabelX2.Text = "Cédula"
        '
        'LabelX3
        '
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX3.Location = New System.Drawing.Point(270, 14)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(75, 23)
        Me.LabelX3.TabIndex = 2
        Me.LabelX3.Text = "Apellidos"
        '
        'LabelX4
        '
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX4.Location = New System.Drawing.Point(126, 60)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(75, 23)
        Me.LabelX4.TabIndex = 3
        Me.LabelX4.Text = "Catergoria"
        '
        'LabelX5
        '
        '
        '
        '
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX5.Location = New System.Drawing.Point(14, 60)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(75, 23)
        Me.LabelX5.TabIndex = 4
        Me.LabelX5.Text = "Contrato"
        '
        'tCedula
        '
        Me.tCedula.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.tCedula.Border.Class = "TextBoxBorder"
        Me.tCedula.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tCedula.DisabledBackColor = System.Drawing.Color.White
        Me.tCedula.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tCedula.ForeColor = System.Drawing.Color.Black
        Me.tCedula.Location = New System.Drawing.Point(14, 34)
        Me.tCedula.Name = "tCedula"
        Me.tCedula.PreventEnterBeep = True
        Me.tCedula.ReadOnly = True
        Me.tCedula.Size = New System.Drawing.Size(100, 22)
        Me.tCedula.TabIndex = 5
        '
        'tNombre
        '
        Me.tNombre.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.tNombre.Border.Class = "TextBoxBorder"
        Me.tNombre.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tNombre.DisabledBackColor = System.Drawing.Color.White
        Me.tNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tNombre.ForeColor = System.Drawing.Color.Black
        Me.tNombre.Location = New System.Drawing.Point(126, 34)
        Me.tNombre.Name = "tNombre"
        Me.tNombre.PreventEnterBeep = True
        Me.tNombre.ReadOnly = True
        Me.tNombre.Size = New System.Drawing.Size(138, 22)
        Me.tNombre.TabIndex = 6
        '
        'tApellidos
        '
        Me.tApellidos.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.tApellidos.Border.Class = "TextBoxBorder"
        Me.tApellidos.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tApellidos.DisabledBackColor = System.Drawing.Color.White
        Me.tApellidos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tApellidos.ForeColor = System.Drawing.Color.Black
        Me.tApellidos.Location = New System.Drawing.Point(270, 34)
        Me.tApellidos.Name = "tApellidos"
        Me.tApellidos.PreventEnterBeep = True
        Me.tApellidos.ReadOnly = True
        Me.tApellidos.Size = New System.Drawing.Size(138, 22)
        Me.tApellidos.TabIndex = 7
        '
        'tContrato
        '
        Me.tContrato.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.tContrato.Border.Class = "TextBoxBorder"
        Me.tContrato.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tContrato.DisabledBackColor = System.Drawing.Color.White
        Me.tContrato.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tContrato.ForeColor = System.Drawing.Color.Black
        Me.tContrato.Location = New System.Drawing.Point(14, 80)
        Me.tContrato.Name = "tContrato"
        Me.tContrato.PreventEnterBeep = True
        Me.tContrato.ReadOnly = True
        Me.tContrato.Size = New System.Drawing.Size(100, 22)
        Me.tContrato.TabIndex = 8
        '
        'tCategoria
        '
        Me.tCategoria.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.tCategoria.Border.Class = "TextBoxBorder"
        Me.tCategoria.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tCategoria.DisabledBackColor = System.Drawing.Color.White
        Me.tCategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tCategoria.ForeColor = System.Drawing.Color.Black
        Me.tCategoria.Location = New System.Drawing.Point(126, 80)
        Me.tCategoria.Name = "tCategoria"
        Me.tCategoria.PreventEnterBeep = True
        Me.tCategoria.ReadOnly = True
        Me.tCategoria.Size = New System.Drawing.Size(100, 22)
        Me.tCategoria.TabIndex = 9
        '
        'cuEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.tCategoria)
        Me.Controls.Add(Me.tContrato)
        Me.Controls.Add(Me.tApellidos)
        Me.Controls.Add(Me.tNombre)
        Me.Controls.Add(Me.tCedula)
        Me.Controls.Add(Me.LabelX5)
        Me.Controls.Add(Me.LabelX4)
        Me.Controls.Add(Me.LabelX3)
        Me.Controls.Add(Me.LabelX2)
        Me.Controls.Add(Me.LabelX1)
        Me.Name = "cuEmpleado"
        Me.Size = New System.Drawing.Size(476, 119)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents tCedula As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents tNombre As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents tApellidos As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents tContrato As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents tCategoria As DevComponents.DotNetBar.Controls.TextBoxX
End Class
