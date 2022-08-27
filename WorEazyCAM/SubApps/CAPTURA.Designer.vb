<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CAPTURA
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CAPTURA))
        Me.PCAPTURA = New System.Windows.Forms.PictureBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.GuardarImagenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BorrarImagenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnviarAEditorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnviarAORCToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AbrirCarpetaDefaultToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.CerrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.PCAPTURA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PCAPTURA
        '
        Me.PCAPTURA.BackColor = System.Drawing.Color.Black
        Me.PCAPTURA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PCAPTURA.ContextMenuStrip = Me.ContextMenuStrip1
        Me.PCAPTURA.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PCAPTURA.Location = New System.Drawing.Point(0, 0)
        Me.PCAPTURA.Name = "PCAPTURA"
        Me.PCAPTURA.Size = New System.Drawing.Size(784, 562)
        Me.PCAPTURA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PCAPTURA.TabIndex = 0
        Me.PCAPTURA.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PCAPTURA, "Captura" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Click Derecho>Guardar Imagen")
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GuardarImagenToolStripMenuItem, Me.BorrarImagenToolStripMenuItem, Me.EnviarAEditorToolStripMenuItem, Me.EnviarAORCToolStripMenuItem, Me.AbrirCarpetaDefaultToolStripMenuItem, Me.ToolStripMenuItem1, Me.CerrarToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(211, 142)
        '
        'GuardarImagenToolStripMenuItem
        '
        Me.GuardarImagenToolStripMenuItem.Name = "GuardarImagenToolStripMenuItem"
        Me.GuardarImagenToolStripMenuItem.Size = New System.Drawing.Size(210, 22)
        Me.GuardarImagenToolStripMenuItem.Text = "Guardar Imagen"
        Me.GuardarImagenToolStripMenuItem.ToolTipText = "Guarda la Imagen donde Desees"
        '
        'BorrarImagenToolStripMenuItem
        '
        Me.BorrarImagenToolStripMenuItem.Name = "BorrarImagenToolStripMenuItem"
        Me.BorrarImagenToolStripMenuItem.Size = New System.Drawing.Size(210, 22)
        Me.BorrarImagenToolStripMenuItem.Text = "Borrar Imagen"
        Me.BorrarImagenToolStripMenuItem.ToolTipText = "Elimina esta Imagen"
        '
        'EnviarAEditorToolStripMenuItem
        '
        Me.EnviarAEditorToolStripMenuItem.Enabled = False
        Me.EnviarAEditorToolStripMenuItem.Name = "EnviarAEditorToolStripMenuItem"
        Me.EnviarAEditorToolStripMenuItem.Size = New System.Drawing.Size(210, 22)
        Me.EnviarAEditorToolStripMenuItem.Text = "Enviar a Editor"
        Me.EnviarAEditorToolStripMenuItem.ToolTipText = "Funcion no Disponible"
        '
        'EnviarAORCToolStripMenuItem
        '
        Me.EnviarAORCToolStripMenuItem.Enabled = False
        Me.EnviarAORCToolStripMenuItem.Name = "EnviarAORCToolStripMenuItem"
        Me.EnviarAORCToolStripMenuItem.Size = New System.Drawing.Size(210, 22)
        Me.EnviarAORCToolStripMenuItem.Text = "Enviar a ORC"
        Me.EnviarAORCToolStripMenuItem.ToolTipText = "Funcion no Disponible"
        '
        'AbrirCarpetaDefaultToolStripMenuItem
        '
        Me.AbrirCarpetaDefaultToolStripMenuItem.Name = "AbrirCarpetaDefaultToolStripMenuItem"
        Me.AbrirCarpetaDefaultToolStripMenuItem.Size = New System.Drawing.Size(210, 22)
        Me.AbrirCarpetaDefaultToolStripMenuItem.Text = "Abrir Carpeta de Capturas"
        Me.AbrirCarpetaDefaultToolStripMenuItem.ToolTipText = "Abre la Carpeta de Capturas"
        Me.AbrirCarpetaDefaultToolStripMenuItem.Visible = False
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(207, 6)
        '
        'CerrarToolStripMenuItem
        '
        Me.CerrarToolStripMenuItem.Name = "CerrarToolStripMenuItem"
        Me.CerrarToolStripMenuItem.Size = New System.Drawing.Size(210, 22)
        Me.CerrarToolStripMenuItem.Text = "Cerrar"
        Me.CerrarToolStripMenuItem.ToolTipText = "Cierra el Visor de Capturas"
        '
        'ToolTip1
        '
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTip1.ToolTipTitle = "Worcome Security"
        '
        'CAPTURA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.Controls.Add(Me.PCAPTURA)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "CAPTURA"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EazyCAM | Visor de Capturas"
        Me.TopMost = True
        CType(Me.PCAPTURA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PCAPTURA As System.Windows.Forms.PictureBox
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents GuardarImagenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BorrarImagenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CerrarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EnviarAORCToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EnviarAEditorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AbrirCarpetaDefaultToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
