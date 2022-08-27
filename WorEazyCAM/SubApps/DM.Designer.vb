<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DeteccionMovimiento
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DeteccionMovimiento))
        Me.Picturebox1 = New System.Windows.Forms.PictureBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ButtonDETECTAR = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.LabelDIRY = New System.Windows.Forms.Label()
        Me.LabelDIRX = New System.Windows.Forms.Label()
        Me.ButtonMARCO = New System.Windows.Forms.Button()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.Picturebox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Picturebox1
        '
        Me.Picturebox1.BackColor = System.Drawing.Color.Black
        Me.Picturebox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Picturebox1.Location = New System.Drawing.Point(0, 21)
        Me.Picturebox1.Margin = New System.Windows.Forms.Padding(4)
        Me.Picturebox1.Name = "Picturebox1"
        Me.Picturebox1.Size = New System.Drawing.Size(782, 632)
        Me.Picturebox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Picturebox1.TabIndex = 0
        Me.Picturebox1.TabStop = False
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.Color.White
        Me.ComboBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(0, 0)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(782, 21)
        Me.ComboBox1.TabIndex = 1
        '
        'ButtonDETECTAR
        '
        Me.ButtonDETECTAR.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ButtonDETECTAR.BackColor = System.Drawing.Color.White
        Me.ButtonDETECTAR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonDETECTAR.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonDETECTAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonDETECTAR.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ButtonDETECTAR.Location = New System.Drawing.Point(149, 3)
        Me.ButtonDETECTAR.Name = "ButtonDETECTAR"
        Me.ButtonDETECTAR.Size = New System.Drawing.Size(140, 46)
        Me.ButtonDETECTAR.TabIndex = 2
        Me.ButtonDETECTAR.Text = "DETECTAR"
        Me.ButtonDETECTAR.UseVisualStyleBackColor = False
        Me.ButtonDETECTAR.Visible = False
        '
        'Timer1
        '
        '
        'Timer2
        '
        '
        'LabelDIRY
        '
        Me.LabelDIRY.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelDIRY.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDIRY.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LabelDIRY.Location = New System.Drawing.Point(639, 3)
        Me.LabelDIRY.Name = "LabelDIRY"
        Me.LabelDIRY.Size = New System.Drawing.Size(140, 20)
        Me.LabelDIRY.TabIndex = 4
        Me.LabelDIRY.Text = "0"
        Me.LabelDIRY.Visible = False
        '
        'LabelDIRX
        '
        Me.LabelDIRX.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelDIRX.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDIRX.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LabelDIRX.Location = New System.Drawing.Point(639, 26)
        Me.LabelDIRX.Name = "LabelDIRX"
        Me.LabelDIRX.Size = New System.Drawing.Size(140, 23)
        Me.LabelDIRX.TabIndex = 5
        Me.LabelDIRX.Text = "0"
        Me.LabelDIRX.Visible = False
        '
        'ButtonMARCO
        '
        Me.ButtonMARCO.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ButtonMARCO.BackColor = System.Drawing.Color.White
        Me.ButtonMARCO.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonMARCO.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonMARCO.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonMARCO.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ButtonMARCO.Location = New System.Drawing.Point(3, 3)
        Me.ButtonMARCO.Name = "ButtonMARCO"
        Me.ButtonMARCO.Size = New System.Drawing.Size(140, 46)
        Me.ButtonMARCO.TabIndex = 6
        Me.ButtonMARCO.Text = "MARCO"
        Me.ButtonMARCO.UseVisualStyleBackColor = False
        Me.ButtonMARCO.Visible = False
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.NumericUpDown1.BackColor = System.Drawing.SystemColors.Control
        Me.NumericUpDown1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumericUpDown1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.NumericUpDown1.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.NumericUpDown1.Location = New System.Drawing.Point(295, 3)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.NumericUpDown1.Minimum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(47, 20)
        Me.NumericUpDown1.TabIndex = 7
        Me.NumericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NumericUpDown1.Value = New Decimal(New Integer() {500, 0, 0, 0})
        Me.NumericUpDown1.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DimGray
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.ButtonMARCO)
        Me.Panel1.Controls.Add(Me.LabelDIRX)
        Me.Panel1.Controls.Add(Me.NumericUpDown1)
        Me.Panel1.Controls.Add(Me.LabelDIRY)
        Me.Panel1.Controls.Add(Me.ButtonDETECTAR)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 601)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(782, 52)
        Me.Panel1.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(295, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "FPS (-=+)"
        Me.Label1.Visible = False
        '
        'DeteccionMovimiento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(782, 653)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Picturebox1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Cyan
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimumSize = New System.Drawing.Size(502, 397)
        Me.Name = "DeteccionMovimiento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Eazy CAM | Deteccion de Movimiento"
        CType(Me.Picturebox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Picturebox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents ButtonDETECTAR As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents LabelDIRY As System.Windows.Forms.Label
    Friend WithEvents LabelDIRX As System.Windows.Forms.Label
    Friend WithEvents ButtonMARCO As System.Windows.Forms.Button
    Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
