<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCoopeAnde
    Inherits DevComponents.DotNetBar.Metro.MetroForm

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCoopeAnde))
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.ListBoxAdv1 = New DevComponents.DotNetBar.ListBoxAdv()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb
        Me.ButtonX1.Location = New System.Drawing.Point(12, 166)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(272, 67)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX1.Symbol = ""
        Me.ButtonX1.TabIndex = 0
        Me.ButtonX1.Text = "Enviar Correo Planilla"
        '
        'ListBoxAdv1
        '
        Me.ListBoxAdv1.AutoScroll = True
        '
        '
        '
        Me.ListBoxAdv1.BackgroundStyle.Class = "ListBoxAdv"
        Me.ListBoxAdv1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ListBoxAdv1.ContainerControlProcessDialogKey = True
        Me.ListBoxAdv1.DragDropSupport = True
        Me.ListBoxAdv1.Items.Add("wcamacho@coopeande1.com")
        Me.ListBoxAdv1.Items.Add("pruebas@coopeande1.com")
        Me.ListBoxAdv1.Location = New System.Drawing.Point(13, 13)
        Me.ListBoxAdv1.Name = "ListBoxAdv1"
        Me.ListBoxAdv1.Size = New System.Drawing.Size(271, 147)
        Me.ListBoxAdv1.TabIndex = 1
        Me.ListBoxAdv1.Text = "ListBoxAdv1"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(290, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(38, 37)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'frmCoopeAnde
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(346, 245)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ListBoxAdv1)
        Me.Controls.Add(Me.ButtonX1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.Name = "frmCoopeAnde"
        Me.ShowIcon = False
        Me.Text = "CoopeAnde"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ListBoxAdv1 As DevComponents.DotNetBar.ListBoxAdv
    Friend WithEvents PictureBox1 As PictureBox
End Class
