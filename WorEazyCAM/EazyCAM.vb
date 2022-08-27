Imports AForge.Video
Imports AForge.Video.DirectShow
Public Class EazyCAM
    Public CAMARA As VideoCaptureDevice
    Dim BMP As Bitmap
    Dim SEGUNDOS As Integer

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CAPTURAR(ByVal sender As Object, ByVal eventArgs As NewFrameEventArgs)
        BMP = DirectCast(eventArgs.Frame.Clone(), Bitmap)
        PictureBox1.Image = DirectCast(eventArgs.Frame.Clone(), Bitmap)
    End Sub

    Public Sub CAPTURANDO()
        CAPTURA.PCAPTURA.Image = PictureBox1.Image
        CAPTURA.Show()
    End Sub

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Selector.Show()
        Me.Dispose()
        Try
            CAMARA.Stop()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub PictureBox1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox1.DoubleClick
        CAPTURANDO()
    End Sub

    Dim CAMERA As Boolean = False
    Private Sub IniciarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IniciarToolStripMenuItem.Click
        If CAMERA = False Then
            CAMERA = True
            EazyCAM(True)
        Else
            CAMERA = False
            EazyCAM(False)
        End If
    End Sub

    Sub EazyCAM(ByVal DATA As Boolean)
        Try
            If DATA = True Then
                Dim CAMARAS As VideoCaptureDeviceForm = New VideoCaptureDeviceForm()
                If CAMARAS.ShowDialog() = DialogResult.OK Then
                    CAMARA = CAMARAS.VideoDevice
                    AddHandler CAMARA.NewFrame, New NewFrameEventHandler(AddressOf CAPTURAR)
                    CAMARA.Start()
                    CAMERA = True
                    IniciarToolStripMenuItem.Text = "Detener"
                End If
            ElseIf DATA = False Then
                Try
                    CAMARA.Stop()
                    CAMARA.SignalToStop()
                Catch ex As Exception
                End Try
                DATA = False
                CAMERA = False
                PictureBox1.Image = Nothing
                PictureBox1.Image = My.Resources.No_TV_Signal
                IniciarToolStripMenuItem.Text = "Iniciar"
            End If
        Catch ex As Exception
            Console.WriteLine("Error al Iniciar/Detener la Transmision: " & ex.Message)
        End Try
    End Sub

    Private Sub CapturarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CapturarToolStripMenuItem.Click
        CAPTURANDO()
    End Sub

    Private Sub ModoConcentradoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModoConcentradoToolStripMenuItem.Click
        If ModoConcentradoToolStripMenuItem.Text = "Activar Modo Concentrado" Then
            Me.TopMost = True
            ModoConcentradoToolStripMenuItem.Text = "Desactiva Modo Concentrado"
        Else
            Me.TopMost = False
            ModoConcentradoToolStripMenuItem.Text = "Activar Modo Concentrado"
        End If
    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub NoneToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NoneToolStripMenuItem.Click
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        MovementActive = True
    End Sub

    Private Sub SToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SToolStripMenuItem.Click
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable
        MovementActive = False
    End Sub

    Private Arrastrar As Boolean = False
    Private MouseDownX As Integer
    Private MouseDownY As Integer
    Public MovementActive As Boolean = False
    Private Sub PictureBox1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseDown
        If MovementActive = False Then
            PictureBox1.Cursor = Cursors.Default
        Else
            PictureBox1.Cursor = Cursors.SizeAll
            If e.Button = MouseButtons.Left Then
                Arrastrar = True
                MouseDownX = e.X
                MouseDownY = e.Y
            End If
        End If
    End Sub

    Private Sub PictureBox1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseMove
        If Arrastrar = True Then
            Dim temp As Point = New Point()
            temp.X = Me.Location.X + (e.X - MouseDownX)
            temp.Y = Me.Location.Y + (e.Y - MouseDownY)
            Me.Location = temp
            temp = Nothing
        End If
    End Sub

    Private Sub PictureBox1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseUp
        If e.Button = MouseButtons.Left Then
            Arrastrar = False
        End If
    End Sub

    Private Sub OcultarAppToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OcultarAppToolStripMenuItem.Click
        If OcultarAppToolStripMenuItem.Text = "Ocultar App" Then
            Me.ShowInTaskbar = False
            OcultarAppToolStripMenuItem.Text = "Mostrar App"
        Else
            Me.ShowInTaskbar = True
            OcultarAppToolStripMenuItem.Text = "Ocultar App"
        End If
    End Sub

    Private Sub OpcionesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpcionesToolStripMenuItem.Click
        Options_CAM.Show()
    End Sub
End Class
