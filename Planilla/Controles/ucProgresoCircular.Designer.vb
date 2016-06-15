<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucProgresoCircular
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
        Me.components = New System.ComponentModel.Container()
        Me.CircularProgress1 = New DevComponents.DotNetBar.Controls.CircularProgress()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'CircularProgress1
        '
        '
        '
        '
        Me.CircularProgress1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.CircularProgress1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CircularProgress1.FocusCuesEnabled = False
        Me.CircularProgress1.Location = New System.Drawing.Point(0, 0)
        Me.CircularProgress1.Name = "CircularProgress1"
        Me.CircularProgress1.ProgressBarType = DevComponents.DotNetBar.eCircularProgressType.Dot
        Me.CircularProgress1.ProgressColor = System.Drawing.Color.SeaGreen
        Me.CircularProgress1.Size = New System.Drawing.Size(150, 150)
        Me.CircularProgress1.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP
        Me.CircularProgress1.TabIndex = 0
        '
        'Timer1
        '
        '
        'ucProgresoCircular
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.CircularProgress1)
        Me.Name = "ucProgresoCircular"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CircularProgress1 As DevComponents.DotNetBar.Controls.CircularProgress
    Friend WithEvents Timer1 As Timer
End Class
