<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EazyCAM
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EazyCAM))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.IniciarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CapturarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ModoConcentradoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FormStyleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NoneToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OcultarAppToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.OpcionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Black
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(784, 562)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IniciarToolStripMenuItem, Me.CapturarToolStripMenuItem, Me.ToolStripMenuItem1, Me.ModoConcentradoToolStripMenuItem, Me.FormStyleToolStripMenuItem, Me.OcultarAppToolStripMenuItem, Me.ToolStripMenuItem2, Me.OpcionesToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(219, 170)
        '
        'IniciarToolStripMenuItem
        '
        Me.IniciarToolStripMenuItem.Name = "IniciarToolStripMenuItem"
        Me.IniciarToolStripMenuItem.Size = New System.Drawing.Size(218, 22)
        Me.IniciarToolStripMenuItem.Text = "Iniciar"
        '
        'CapturarToolStripMenuItem
        '
        Me.CapturarToolStripMenuItem.Name = "CapturarToolStripMenuItem"
        Me.CapturarToolStripMenuItem.Size = New System.Drawing.Size(218, 22)
        Me.CapturarToolStripMenuItem.Text = "Capturar"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(215, 6)
        '
        'ModoConcentradoToolStripMenuItem
        '
        Me.ModoConcentradoToolStripMenuItem.Name = "ModoConcentradoToolStripMenuItem"
        Me.ModoConcentradoToolStripMenuItem.Size = New System.Drawing.Size(218, 22)
        Me.ModoConcentradoToolStripMenuItem.Text = "Activar Modo Concentrado"
        '
        'FormStyleToolStripMenuItem
        '
        Me.FormStyleToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NoneToolStripMenuItem, Me.SToolStripMenuItem})
        Me.FormStyleToolStripMenuItem.Name = "FormStyleToolStripMenuItem"
        Me.FormStyleToolStripMenuItem.Size = New System.Drawing.Size(218, 22)
        Me.FormStyleToolStripMenuItem.Text = "FormStyle"
        '
        'NoneToolStripMenuItem
        '
        Me.NoneToolStripMenuItem.Name = "NoneToolStripMenuItem"
        Me.NoneToolStripMenuItem.Size = New System.Drawing.Size(110, 22)
        Me.NoneToolStripMenuItem.Text = "None"
        '
        'SToolStripMenuItem
        '
        Me.SToolStripMenuItem.Name = "SToolStripMenuItem"
        Me.SToolStripMenuItem.Size = New System.Drawing.Size(110, 22)
        Me.SToolStripMenuItem.Text = "Sizable"
        '
        'OcultarAppToolStripMenuItem
        '
        Me.OcultarAppToolStripMenuItem.Name = "OcultarAppToolStripMenuItem"
        Me.OcultarAppToolStripMenuItem.Size = New System.Drawing.Size(218, 22)
        Me.OcultarAppToolStripMenuItem.Text = "Ocultar App"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(215, 6)
        '
        'OpcionesToolStripMenuItem
        '
        Me.OpcionesToolStripMenuItem.Name = "OpcionesToolStripMenuItem"
        Me.OpcionesToolStripMenuItem.Size = New System.Drawing.Size(218, 22)
        Me.OpcionesToolStripMenuItem.Text = "Opciones"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(218, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'EazyCAM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(132, 132)
        Me.Name = "EazyCAM"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EazyCAM | Eazy"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents IniciarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CapturarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModoConcentradoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FormStyleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NoneToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OcultarAppToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpcionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
