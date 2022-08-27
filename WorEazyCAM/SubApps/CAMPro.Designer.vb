<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CAMPro
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CAMPro))
        Me.VISOR = New System.Windows.Forms.PictureBox()
        Me.INICIAR = New System.Windows.Forms.Button()
        Me.CAPTURAR = New System.Windows.Forms.Button()
        Me.GUARDAR = New System.Windows.Forms.Button()
        Me.GRABAR = New System.Windows.Forms.Button()
        Me.FGRABAR = New System.Windows.Forms.Button()
        Me.FORMATO = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ButtonSERIEDIARIA = New System.Windows.Forms.Button()
        Me.ButtonFINSERIEDIARIA = New System.Windows.Forms.Button()
        Me.SFD = New System.Windows.Forms.SaveFileDialog()
        Me.FBD = New System.Windows.Forms.FolderBrowserDialog()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.VISOR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'VISOR
        '
        Me.VISOR.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.VISOR.BackColor = System.Drawing.Color.Black
        Me.VISOR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.VISOR.Location = New System.Drawing.Point(2, 2)
        Me.VISOR.Name = "VISOR"
        Me.VISOR.Size = New System.Drawing.Size(810, 583)
        Me.VISOR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.VISOR.TabIndex = 0
        Me.VISOR.TabStop = False
        '
        'INICIAR
        '
        Me.INICIAR.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.INICIAR.BackColor = System.Drawing.Color.White
        Me.INICIAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.INICIAR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.INICIAR.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.INICIAR.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.INICIAR.ForeColor = System.Drawing.Color.Black
        Me.INICIAR.Location = New System.Drawing.Point(821, 12)
        Me.INICIAR.Name = "INICIAR"
        Me.INICIAR.Size = New System.Drawing.Size(139, 41)
        Me.INICIAR.TabIndex = 1
        Me.INICIAR.Text = "INICIAR"
        Me.INICIAR.UseVisualStyleBackColor = False
        '
        'CAPTURAR
        '
        Me.CAPTURAR.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CAPTURAR.BackColor = System.Drawing.Color.White
        Me.CAPTURAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CAPTURAR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CAPTURAR.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CAPTURAR.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CAPTURAR.ForeColor = System.Drawing.Color.Black
        Me.CAPTURAR.Location = New System.Drawing.Point(821, 119)
        Me.CAPTURAR.Name = "CAPTURAR"
        Me.CAPTURAR.Size = New System.Drawing.Size(139, 41)
        Me.CAPTURAR.TabIndex = 4
        Me.CAPTURAR.Text = "CAPTURAR"
        Me.CAPTURAR.UseVisualStyleBackColor = False
        '
        'GUARDAR
        '
        Me.GUARDAR.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GUARDAR.BackColor = System.Drawing.Color.White
        Me.GUARDAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GUARDAR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GUARDAR.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GUARDAR.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GUARDAR.ForeColor = System.Drawing.Color.Black
        Me.GUARDAR.Location = New System.Drawing.Point(821, 166)
        Me.GUARDAR.Name = "GUARDAR"
        Me.GUARDAR.Size = New System.Drawing.Size(139, 41)
        Me.GUARDAR.TabIndex = 5
        Me.GUARDAR.Text = "GUARDAR CAPTURA"
        Me.GUARDAR.UseVisualStyleBackColor = False
        '
        'GRABAR
        '
        Me.GRABAR.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GRABAR.BackColor = System.Drawing.Color.White
        Me.GRABAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GRABAR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GRABAR.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GRABAR.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GRABAR.ForeColor = System.Drawing.Color.Black
        Me.GRABAR.Location = New System.Drawing.Point(821, 333)
        Me.GRABAR.Name = "GRABAR"
        Me.GRABAR.Size = New System.Drawing.Size(139, 41)
        Me.GRABAR.TabIndex = 9
        Me.GRABAR.Text = "GRABAR VIDEO"
        Me.GRABAR.UseVisualStyleBackColor = False
        '
        'FGRABAR
        '
        Me.FGRABAR.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FGRABAR.BackColor = System.Drawing.Color.White
        Me.FGRABAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.FGRABAR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FGRABAR.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.FGRABAR.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FGRABAR.ForeColor = System.Drawing.Color.Black
        Me.FGRABAR.Location = New System.Drawing.Point(821, 380)
        Me.FGRABAR.Name = "FGRABAR"
        Me.FGRABAR.Size = New System.Drawing.Size(139, 41)
        Me.FGRABAR.TabIndex = 10
        Me.FGRABAR.Text = "FIN GRABAR VIDEO"
        Me.FGRABAR.UseVisualStyleBackColor = False
        '
        'FORMATO
        '
        Me.FORMATO.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FORMATO.BackColor = System.Drawing.Color.White
        Me.FORMATO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.FORMATO.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FORMATO.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.FORMATO.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FORMATO.ForeColor = System.Drawing.Color.Black
        Me.FORMATO.Location = New System.Drawing.Point(821, 59)
        Me.FORMATO.Name = "FORMATO"
        Me.FORMATO.Size = New System.Drawing.Size(139, 41)
        Me.FORMATO.TabIndex = 11
        Me.FORMATO.Text = "RESOLUCION"
        Me.FORMATO.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'ButtonSERIEDIARIA
        '
        Me.ButtonSERIEDIARIA.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonSERIEDIARIA.BackColor = System.Drawing.Color.White
        Me.ButtonSERIEDIARIA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonSERIEDIARIA.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonSERIEDIARIA.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonSERIEDIARIA.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSERIEDIARIA.ForeColor = System.Drawing.Color.Black
        Me.ButtonSERIEDIARIA.Location = New System.Drawing.Point(821, 226)
        Me.ButtonSERIEDIARIA.Name = "ButtonSERIEDIARIA"
        Me.ButtonSERIEDIARIA.Size = New System.Drawing.Size(139, 41)
        Me.ButtonSERIEDIARIA.TabIndex = 17
        Me.ButtonSERIEDIARIA.Text = "SERIE IMAGENES"
        Me.ButtonSERIEDIARIA.UseVisualStyleBackColor = False
        '
        'ButtonFINSERIEDIARIA
        '
        Me.ButtonFINSERIEDIARIA.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonFINSERIEDIARIA.BackColor = System.Drawing.Color.White
        Me.ButtonFINSERIEDIARIA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonFINSERIEDIARIA.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonFINSERIEDIARIA.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonFINSERIEDIARIA.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonFINSERIEDIARIA.ForeColor = System.Drawing.Color.Black
        Me.ButtonFINSERIEDIARIA.Location = New System.Drawing.Point(821, 273)
        Me.ButtonFINSERIEDIARIA.Name = "ButtonFINSERIEDIARIA"
        Me.ButtonFINSERIEDIARIA.Size = New System.Drawing.Size(139, 41)
        Me.ButtonFINSERIEDIARIA.TabIndex = 18
        Me.ButtonFINSERIEDIARIA.Text = "FIN SERIE IMAGENES"
        Me.ButtonFINSERIEDIARIA.UseVisualStyleBackColor = False
        '
        'Timer2
        '
        Me.Timer2.Interval = 1000
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(815, 424)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(150, 150)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'CAMPro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(969, 587)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ButtonFINSERIEDIARIA)
        Me.Controls.Add(Me.ButtonSERIEDIARIA)
        Me.Controls.Add(Me.FORMATO)
        Me.Controls.Add(Me.FGRABAR)
        Me.Controls.Add(Me.GRABAR)
        Me.Controls.Add(Me.GUARDAR)
        Me.Controls.Add(Me.CAPTURAR)
        Me.Controls.Add(Me.INICIAR)
        Me.Controls.Add(Me.VISOR)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(600, 460)
        Me.Name = "CAMPro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EazyCAM | Pro"
        CType(Me.VISOR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents VISOR As System.Windows.Forms.PictureBox
    Friend WithEvents INICIAR As System.Windows.Forms.Button
    Friend WithEvents CAPTURAR As System.Windows.Forms.Button
    Friend WithEvents GUARDAR As System.Windows.Forms.Button
    Friend WithEvents GRABAR As System.Windows.Forms.Button
    Friend WithEvents FGRABAR As System.Windows.Forms.Button
    Friend WithEvents FORMATO As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ButtonSERIEDIARIA As System.Windows.Forms.Button
    Friend WithEvents ButtonFINSERIEDIARIA As System.Windows.Forms.Button
    Friend WithEvents SFD As System.Windows.Forms.SaveFileDialog
    Friend WithEvents FBD As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
