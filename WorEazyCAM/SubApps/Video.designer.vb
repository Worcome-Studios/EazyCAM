<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Video
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Video))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.NumericUpDownFPS = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NumericUpDownBRT = New System.Windows.Forms.NumericUpDown()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownFPS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownBRT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Gray
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(724, 410)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'NumericUpDownFPS
        '
        Me.NumericUpDownFPS.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.NumericUpDownFPS.Location = New System.Drawing.Point(321, 9)
        Me.NumericUpDownFPS.Margin = New System.Windows.Forms.Padding(2)
        Me.NumericUpDownFPS.Maximum = New Decimal(New Integer() {30, 0, 0, 0})
        Me.NumericUpDownFPS.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDownFPS.Name = "NumericUpDownFPS"
        Me.NumericUpDownFPS.Size = New System.Drawing.Size(53, 20)
        Me.NumericUpDownFPS.TabIndex = 5
        Me.NumericUpDownFPS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NumericUpDownFPS.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(274, 11)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "FPS"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(274, 35)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "BitRate"
        '
        'NumericUpDownBRT
        '
        Me.NumericUpDownBRT.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.NumericUpDownBRT.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.NumericUpDownBRT.Location = New System.Drawing.Point(321, 33)
        Me.NumericUpDownBRT.Margin = New System.Windows.Forms.Padding(2)
        Me.NumericUpDownBRT.Maximum = New Decimal(New Integer() {5000, 0, 0, 0})
        Me.NumericUpDownBRT.Minimum = New Decimal(New Integer() {200, 0, 0, 0})
        Me.NumericUpDownBRT.Name = "NumericUpDownBRT"
        Me.NumericUpDownBRT.Size = New System.Drawing.Size(53, 20)
        Me.NumericUpDownBRT.TabIndex = 7
        Me.NumericUpDownBRT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NumericUpDownBRT.Value = New Decimal(New Integer() {300, 0, 0, 0})
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.NumericUpDownFPS)
        Me.Panel1.Controls.Add(Me.NumericUpDownBRT)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 410)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(724, 62)
        Me.Panel1.TabIndex = 9
        '
        'Button3
        '
        Me.Button3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(476, 15)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(91, 32)
        Me.Button3.TabIndex = 11
        Me.Button3.Text = "Captura"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(379, 15)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(91, 32)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Grabar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(157, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 38)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Ver" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Camara"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Video
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(724, 472)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(450, 310)
        Me.Name = "Video"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EazyCAM | Video"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownFPS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownBRT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents NumericUpDownFPS As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents NumericUpDownBRT As System.Windows.Forms.NumericUpDown
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
