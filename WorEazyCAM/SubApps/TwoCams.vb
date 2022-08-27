Imports AForge.Video.DirectShow
Imports AForge.Video
Public Class DosCameras
    Dim ENCONTRADO As Boolean = False
    Dim FUENTES As FilterInfoCollection
    Dim WithEvents FUENTE1 As VideoCaptureDevice = Nothing
    Dim WithEvents FUENTE2 As VideoCaptureDevice = Nothing
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FUENTES = New FilterInfoCollection(FilterCategory.VideoInputDevice)
        If FUENTES.Count = 0 Then
            ENCONTRADO = False
        Else
            ENCONTRADO = True
        End If
        For i As Integer = 0 To FUENTES.Count - 1
            ComboBox1.Items.Add(FUENTES(i).Name.ToString())
        Next
        For i As Integer = 0 To FUENTES.Count - 1
            ComboBox2.Items.Add(FUENTES(i).Name.ToString())
        Next
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ENCONTRADO Then
            FUENTE1 = New VideoCaptureDevice(FUENTES(ComboBox1.SelectedIndex).MonikerString)
            AddHandler FUENTE1.NewFrame, New NewFrameEventHandler(AddressOf video_NuevoFrame1)
            FUENTE1.Start()
            ComboBox1.Enabled = False
        End If
    End Sub
    Private Sub video_NuevoFrame1(ByVal sender As Object, ByVal eventArgs As NewFrameEventArgs)
        Dim IMAGEN As Bitmap = DirectCast(eventArgs.Frame.Clone(), Bitmap)
        PictureBox1.Image = IMAGEN
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        If ENCONTRADO Then
            FUENTE2 = New VideoCaptureDevice(FUENTES(ComboBox2.SelectedIndex).MonikerString)
            AddHandler FUENTE2.NewFrame, New NewFrameEventHandler(AddressOf video_NuevoFrame2)
            FUENTE2.Start()
            ComboBox2.Enabled = False
        End If
    End Sub
    Private Sub video_NuevoFrame2(ByVal sender As Object, ByVal eventArgs As NewFrameEventArgs)
        Dim IMAGEN As Bitmap = DirectCast(eventArgs.Frame.Clone(), Bitmap)
        PictureBox2.Image = IMAGEN
    End Sub

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Selector.Show()
        Me.Dispose()
        If Not (FUENTE1 Is Nothing) Then
            If FUENTE1.IsRunning Then
                FUENTE1.SignalToStop()
                FUENTE1 = Nothing
            End If
        End If

        If Not (FUENTE2 Is Nothing) Then
            If FUENTE2.IsRunning Then
                FUENTE2.SignalToStop()
                FUENTE2 = Nothing
            End If
        End If
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub PictureBox1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox1.DoubleClick
        CAPTURA.PCAPTURA.Image = PictureBox1.Image
        CAPTURA.Show()
    End Sub

    Private Sub PictureBox2_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox2.DoubleClick
        CAPTURA.PCAPTURA.Image = PictureBox2.Image
        CAPTURA.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        CAPTURA.PCAPTURA.Image = PictureBox1.Image
        CAPTURA.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        CAPTURA.PCAPTURA.Image = PictureBox2.Image
        CAPTURA.Show()
    End Sub
End Class
