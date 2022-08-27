Imports AForge
Imports AForge.Imaging
Imports AForge.Video
Imports AForge.Video.DirectShow
Imports AForge.Vision.Motion

Public Class DeteccionMovimiento
    'DETECTOR Y CAMARA
    Dim DETECTOR As New MotionDetector(New TwoFramesDifferenceDetector(), New MotionAreaHighlighting())
    Dim FUENTES As FilterInfoCollection
    Dim FUENTE As VideoCaptureDevice = Nothing
    'MARCO
    Dim MARCOX As Integer = 0
    Dim MARCOY As Integer = 50
    Dim MARCOANCHO As Integer = 782
    Dim MARCOALTO As Integer = 632
    'COMPARACION COORDENADAS
    Dim ANTERIORX As Integer
    Dim ANTERIORY As Integer
    Dim IMAGEN2 As Bitmap

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'PONE EL FORM EN LA PARTE SUPERIOR DE LA PANTALLA
        Me.Location = New System.Drawing.Point(Me.Location.X, 0)
        'CARGA LAS CAMARAS DISPONIBLES EN EL COMBOBOX
        CheckForIllegalCrossThreadCalls = False 'PERMITE QUE SE ESCRIBA EN LAS ETIQUETAS DURANTE EL THREAD Video_NewFrame
        FUENTES = New FilterInfoCollection(FilterCategory.VideoInputDevice)
        If FUENTES.Count > 0 Then
            For Each ITEM In FUENTES
                ComboBox1.Items.Add(ITEM.Name.ToString())
            Next
        Else
            MsgBox("No hay Camaras Disponibles para su Uso", MsgBoxStyle.Critical, "Worcome Security")
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        'INICIA LA CAPTURA DE IMAGENES DE LA CAMARA Y EL THREAD Video_NewFrame
        FUENTE = New VideoCaptureDevice(FUENTES(ComboBox1.SelectedIndex).MonikerString)
        AddHandler FUENTE.NewFrame, New NewFrameEventHandler(AddressOf Video_NewFrame)
        FUENTE.Start()
        ComboBox1.Visible = False
        ButtonDETECTAR.Visible = True
        ButtonMARCO.Visible = True
        NumericUpDown1.Visible = True
        Label1.Visible = True
    End Sub

    Private Sub Video_NewFrame(ByVal sender As Object, ByVal eventArgs As AForge.Video.NewFrameEventArgs)
        'PRESENTA LAS IMAGENES DE LA CAMARA EN EL PICTUREBOX 
        Dim IMAGEN As Bitmap = DirectCast(eventArgs.Frame.Clone(), Bitmap)
        If DETECTOR IsNot Nothing And ButtonDETECTAR.BackColor = Color.Red Then 'SI SE HA PULSADO DETECTAR MOSTRARA LOS MOVIMIENTOS EN LA MISMA IMAGEN
            Dim NIVEL As Single = DETECTOR.ProcessFrame(IMAGEN)
            IMAGEN2 = IMAGEN.Clone
        End If
        Picturebox1.Image = IMAGEN
    End Sub

    Private Sub ButtonMARCO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonMARCO.Click
        'INICIA EL MARCO DONDE SE DETERMINARA LA DIRECCION DEL MOVIMIENTO
        Timer1.Interval = 10
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        'DIBUJA EL MARCO SOBRE EL PICTUREBOX
        Dim MARCO As New Pen(Brushes.Blue, 2)
        Dim CUADRADO As Graphics = Picturebox1.CreateGraphics
        CUADRADO.DrawRectangle(MARCO, MARCOX, MARCOY, MARCOANCHO, MARCOALTO)
    End Sub

    Private Sub ButtonDETECTAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonDETECTAR.Click
        'INICIA LA DETERMINACION DE LA DIRECCION DEL MOVIMIENTO
        If ButtonDETECTAR.BackColor = Color.Red Then
            ButtonDETECTAR.BackColor = Color.Gainsboro
            Timer2.Stop()
        Else
            ButtonDETECTAR.BackColor = Color.Red
            LabelDIRX.Visible = True
            LabelDIRY.Visible = True
            Timer2.Interval = NumericUpDown1.Value
            Timer2.Start()
        End If
    End Sub

    Private Sub NumericUpDown1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumericUpDown1.ValueChanged
        'DETERMINA EL INTERVALO DE LECTURAS DE LA DIRECCION DEL MOVIMIENTO
        Timer2.Interval = NumericUpDown1.Value
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        'BUSCA DENTRO DEL MARCO LA VARIACION DE LAS COORDENADAS EN LAS QUE ENCONTRO LA ULTIMA VEZ EL COLOR BUSCADO
        Try
            Dim ENCONTRADO As Boolean = False 'PARA DETERMINAR SI HA ENCONTRADO EL COLOR BUSCADO
            For Y = MARCOY To MARCOY + MARCOALTO Step 5 'RECORRE EL EJE Y DEL MARCO
                For X = MARCOX To MARCOX + MARCOANCHO Step 5 'RECORRE EL EJE X DEL MARCO
                    If IMAGEN2.GetPixel(X, Y) = Color.FromArgb(255, 255, 0, 0) Then 'SI ENCUENTRA EL COLOR BUSCADO....
                        If ANTERIORY - Y > 10 Then '.... Y ESTA POR ENCIMA DE LA ULTIMA LECTURA EN EL EJE Y .....
                            LabelDIRY.Text = "ARRIBA" 'ES QUE LA DETECCION ESTA MAS ARRIBA
                            'AQUI CODIGO PARA ACCION(CURSOR, ARDUINO, PIC,.....)
                        ElseIf Y - ANTERIORY > 10 Then '.... Y ESTA POR DEBAJO DE LA ULTIMA LECTURA EN EL EJE Y .....
                            LabelDIRY.Text = "ABAJO" 'ES QUE LA DETECCION ESTA MAS ABAJO
                            'AQUI CODIGO PARA ACCION(CURSOR, ARDUINO, PIC,.....)
                        End If
                        If X - ANTERIORX > 20 Then '.... Y ESTA MAS A LA IZQUIERDA QUE LA ULTIMA LECTURA EN EL EJE X .....
                            LabelDIRX.Text = "IZQUIERDA" 'ES QUE LA DETECCION ESTA MAS A LA IZQUIERDA
                            'AQUI CODIGO PARA ACCION(CURSOR, ARDUINO, PIC,.....)
                        ElseIf ANTERIORX - X > 20 Then '.... Y ESTA MAS A LA DERECHA QUE LA ULTIMA LECTURA EN EL EJE X .....
                            LabelDIRX.Text = "DERECHA" 'ES QUE LA DETECCION ESTA MAS A LA DERECHA
                            'AQUI CODIGO PARA ACCION(CURSOR, ARDUINO, PIC,.....)
                        End If
                        ANTERIORX = X 'ACTUALIZA CON EL NUEVO VALOR
                        ANTERIORY = Y 'ACTUALIZA CON EL NUEVO VALOR
                        ENCONTRADO = True
                        Exit For 'SALE DEL BUCLE X
                    End If
                Next
                If ENCONTRADO = True Then 'SI YA HA ENCONTRADO EL COLOR.....
                    Exit For '....SALE DEL BUCLE Y
                End If
            Next
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Selector.Show()
        Me.Dispose()
        Try
            FUENTE.SignalToStop() 'CIERRA EL THREAD Video_NewFrame
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Picturebox1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Picturebox1.DoubleClick
        CAPTURA.PCAPTURA.Image = Picturebox1.Image
        CAPTURA.Show()
    End Sub
End Class

