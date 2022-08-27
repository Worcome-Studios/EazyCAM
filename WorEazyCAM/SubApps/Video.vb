Imports AForge.Video
Imports AForge.Video.DirectShow
Imports AForge.Video.FFMPEG
Public Class Video
    Dim CAMARA As VideoCaptureDevice
    Dim BMP As Bitmap
    Dim ESCRITOR As New VideoFileWriter()

    Private Sub Video_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
    End Sub

    Private Sub btnVerCamara_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim CAMARAS As VideoCaptureDeviceForm = New VideoCaptureDeviceForm()
        If CAMARAS.ShowDialog() = DialogResult.OK Then
            CAMARA = CAMARAS.VideoDevice
            AddHandler CAMARA.NewFrame, New NewFrameEventHandler(AddressOf CAPTURAR)
            CAMARA.Start()
        End If
    End Sub

    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Button2.BackColor = DefaultBackColor Then
            SaveFileDialog1.DefaultExt = ".avi"
            If SaveFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                Dim ANCHO As Integer = CAMARA.VideoResolution.FrameSize.Width
                Dim ALTO As Integer = CAMARA.VideoResolution.FrameSize.Height
                ESCRITOR.Open(SaveFileDialog1.FileName, ANCHO, ALTO, NumericUpDownFPS.Value, VideoCodec.Default, NumericUpDownBRT.Value * 1000)
                ESCRITOR.WriteVideoFrame(BMP)
                Button2.BackColor = Color.Red
            End If
        Else
            Button2.BackColor = DefaultBackColor
            ESCRITOR.Close()
        End If
    End Sub

    Private Sub CAPTURAR(sender As Object, eventArgs As NewFrameEventArgs)
        If Button2.BackColor = DefaultBackColor Then
            BMP = DirectCast(eventArgs.Frame.Clone(), Bitmap)
            PictureBox1.Image = DirectCast(eventArgs.Frame.Clone(), Bitmap)
        Else
            Try
                BMP = DirectCast(eventArgs.Frame.Clone(), Bitmap)
                PictureBox1.Image = DirectCast(eventArgs.Frame.Clone(), Bitmap)
                ESCRITOR.WriteVideoFrame(BMP)
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub btnCaptura_Click(sender As Object, e As EventArgs) Handles Button3.Click
        CAPTURANDO()
    End Sub

    Public Sub CAPTURANDO()
        CAPTURA.PCAPTURA.Image = PictureBox1.Image
        CAPTURA.Show()
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Selector.Show()
        Me.Dispose()
        Try
            CAMARA.Stop()
            ESCRITOR.Close()
        Catch ex As Exception
        End Try
    End Sub
End Class
