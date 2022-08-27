Imports AForge.Video
Imports AForge.Video.DirectShow

Public Class FastCam

    Dim CAMARA As VideoCaptureDevice 'CAMARA QUE ESTAMOS USANDO
    Dim BMP As Bitmap 'PARA GENERACION DE IMAGENES
    Dim SEGUNDOS As Integer 'PARA DETERMINAR LOS TIEMPOS DE CAPTURA DE IMAGENES

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ButtonCAMARA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCAMARA.Click
        If ButtonCAMARA.BackColor = Color.White Then
            Dim CAMARAS As VideoCaptureDeviceForm = New VideoCaptureDeviceForm() 'DIALOGO CAMARAS DISPONIBLES
            If CAMARAS.ShowDialog() = DialogResult.OK Then
                ButtonCAMARA.Enabled = False
                CAMARA = CAMARAS.VideoDevice 'CAMARA ELEGIDA
                AddHandler CAMARA.NewFrame, New NewFrameEventHandler(AddressOf CAPTURAR) ' EJECUTARA CADA VEZ QUE SE GENERE UNA IMAGEN
                CAMARA.Start() 'INICIA LA PRESENTACION DE IMAGENES EN EL PICTUREBOX
                ButtonCAMARA.BackColor = Color.Red 'ESTA PRESENTANDO IMAGENES
            Else
                Try
                    CAMARA.Stop() 'CIERRA LA CAMARA Y EL THREAD ASOCIADO
                Catch ex As Exception
                End Try
                ButtonCAMARA.BackColor = Color.White ' NO ESTA PRESENTANDO IMAGENES
            End If
        End If
    End Sub

    Private Sub CAPTURAR(ByVal sender As Object, ByVal eventArgs As NewFrameEventArgs)
        BMP = DirectCast(eventArgs.Frame.Clone(), Bitmap) 'PONE LA IMAGEN EN EL BITMAP
        PictureBox1.Image = DirectCast(eventArgs.Frame.Clone(), Bitmap) 'LA PRESENTA EN EL PICTURE BOX  
    End Sub

    Dim PIC1 As Boolean = False
    Dim PIC2 As Boolean = False
    Dim PIC3 As Boolean = False
    Dim PIC4 As Boolean = False
    Dim PIC5 As Boolean = False
    Private Sub ButtonCAPTURAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCAPTURAR.Click
        If PIC1 = False Then
            PictureBox2.Image = BMP
            PIC1 = True
        ElseIf PIC2 = False Then
            PictureBox3.Image = BMP
            PIC2 = True
        ElseIf PIC3 = False Then
            PictureBox4.Image = BMP
            PIC3 = True
        ElseIf PIC4 = False Then
            PictureBox5.Image = BMP
            PIC4 = True
        ElseIf PIC5 = False Then
            PictureBox6.Image = BMP
            PIC5 = True
            PIC1 = False
            PIC2 = False
            PIC3 = False
            PIC4 = False
            PIC5 = False
        End If
    End Sub

    '+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++ ENVIO DE LA IMAGEN DESDE LOS PICTUREBOXES DEL FORM1 AL PICTUREBOX DEL FORM CAPTURA
    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        CAPTURA.PCAPTURA.Image = PictureBox2.Image
        CAPTURANDO()
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        CAPTURA.PCAPTURA.Image = PictureBox3.Image
        CAPTURANDO()
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        CAPTURA.PCAPTURA.Image = PictureBox4.Image
        CAPTURANDO()
    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        CAPTURA.PCAPTURA.Image = PictureBox5.Image
        CAPTURANDO()
    End Sub

    Private Sub PictureBox6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox6.Click
        CAPTURA.PCAPTURA.Image = PictureBox6.Image
        CAPTURANDO()
    End Sub

    Public Sub CAPTURANDO()
        ButtonCAMARA.BackColor = Color.White
        ButtonCAPTURAR.BackColor = Color.White
        ButtonCAMARA.Enabled = True
        CAPTURA.Show()
    End Sub

    'CIERRA LA CAMARA Y EL THREAD ASOCIADO
    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Selector.Show()
        Me.Dispose()
        'DESCONECTA LA CAMARA
        Try
            CAMARA.Stop()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.CheckState = CheckState.Checked Then
            Me.TopMost = True
        Else
            Me.TopMost = False
        End If
    End Sub

    Private Sub PictureBox1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox1.DoubleClick
        CAPTURA.PCAPTURA.Image = PictureBox1.Image
        CAPTURANDO()
    End Sub

    Private Sub AsdasdToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AsdasdToolStripMenuItem.Click
        If AsdasdToolStripMenuItem.Text = "Ocultar Barra de Herramientas" Then
            PictureBox1.Dock = DockStyle.Fill
            Panel1.Visible = False
            Panel2.Visible = False
            AsdasdToolStripMenuItem.Text = "Mostrar Barra de Herramientas"
        ElseIf AsdasdToolStripMenuItem.Text = "Mostrar Barra de Herramientas" Then
            PictureBox1.Dock = DockStyle.Fill
            Panel1.Visible = True
            Panel2.Visible = True
            AsdasdToolStripMenuItem.Text = "Ocultar Barra de Herramientas"
        End If
    End Sub
End Class
