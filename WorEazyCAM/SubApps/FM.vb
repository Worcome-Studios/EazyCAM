Imports AForge.Video
Imports AForge.Video.DirectShow

Public Class Fotomaton

    Dim CAMARA As VideoCaptureDevice 'CAMARA QUE ESTAMOS USANDO
    Dim BMP As Bitmap 'PARA GENERACION DE IMAGENES
    Dim SEGUNDOS As Integer 'PARA DETERMINAR LOS TIEMPOS DE CAPTURA DE IMAGENES

    Private Sub ButtonCAMARA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCAMARA.Click
        If ButtonCAMARA.BackColor = Color.White Then
            Dim CAMARAS As VideoCaptureDeviceForm = New VideoCaptureDeviceForm() 'DIALOGO CAMARAS DISPONIBLES
            If CAMARAS.ShowDialog() = DialogResult.OK Then
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

    Private Sub ButtonCAPTURAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCAPTURAR.Click
        If ButtonCAPTURAR.BackColor = Color.White Then
            PictureBox2.Image = Nothing 'ELIMINA LA IMAGEN ANTERIOR SI LA HAY
            PictureBox3.Image = Nothing 'ELIMINA LA IMAGEN ANTERIOR SI LA HAY
            PictureBox4.Image = Nothing 'ELIMINA LA IMAGEN ANTERIOR SI LA HAY
            PictureBox5.Image = Nothing 'ELIMINA LA IMAGEN ANTERIOR SI LA HAY
            PictureBox6.Image = Nothing 'ELIMINA LA IMAGEN ANTERIOR SI LA HAY
            SEGUNDOS = 0 'INICIALIZA EL CONTADOR DE SEGUNDOS
            Timer1.Interval = 1000 'INTERVALO DEL TIMER 1 SEGUNDO
            Timer1.Start() 'PONE EN MARCHA EL TIMER
            ButtonCAPTURAR.BackColor = Color.Red 'ESTA CAPTURANDO
        Else
            Timer1.Stop() 'PARA EL TIMER
            ButtonCAPTURAR.BackColor = Color.White 'NO ESTA CAPTURANDO
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        'DETERMINA A CUAL PICTUREBOX LE ASIGNA LA IMAGEN BMP EN FUNCION DEL TIEMPO TRANSCURRIDO
        SEGUNDOS += 1
        If SEGUNDOS = NumericUpDown1.Value Then
            PictureBox2.Image = BMP
        ElseIf SEGUNDOS = NumericUpDown1.Value * 2 Then
            PictureBox3.Image = BMP
        ElseIf SEGUNDOS = NumericUpDown1.Value * 3 Then
            PictureBox4.Image = BMP
        ElseIf SEGUNDOS = NumericUpDown1.Value * 4 Then
            PictureBox5.Image = BMP
        ElseIf SEGUNDOS = NumericUpDown1.Value * 5 Then
            PictureBox6.Image = BMP
            Timer1.Stop() 'HA LLENADO TODOS LOS PICTUREBOX Y DEJA DE CAPTURAR
            ButtonCAPTURAR.BackColor = Color.Gainsboro
        End If
        Me.Text = SEGUNDOS 'PODEMOS VER LOS SEGUNDOS TRANSCURRIDOS EN EL MARCO DEL FORM
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

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub PictureBox1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox1.DoubleClick
        CAPTURA.PCAPTURA.Image = PictureBox1.Image
        CAPTURANDO()
    End Sub
End Class
