<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CAM
    Inherits System.Windows.Forms.Form

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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CAM))
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.WebCam1 = New WebCAM.WebCam()
        Me.SuspendLayout()
        '
        'SaveFileDialog1
        '
        '
        'WebCam1
        '
        Me.WebCam1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.WebCam1.Imagen = Nothing
        Me.WebCam1.Location = New System.Drawing.Point(12, 12)
        Me.WebCam1.MilisegundosCaptura = 100
        Me.WebCam1.Name = "WebCam1"
        Me.WebCam1.Size = New System.Drawing.Size(460, 438)
        Me.WebCam1.TabIndex = 0
        '
        'CAM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 462)
        Me.Controls.Add(Me.WebCam1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(195, 195)
        Me.Name = "CAM"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EazyCAM | Basico"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents WebCam1 As WebCAM.WebCam

End Class
