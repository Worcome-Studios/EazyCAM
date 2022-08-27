Imports System.Runtime.InteropServices

Public Class CAMPro
    Dim DATOS As IDataObject
    Dim IMAGEN As Image
    Dim DIRCommons As String = "C:\Users\" & Environment.UserName & "\"
    Dim CARPETA_VIDEOS As String = "C:\Users\" & Environment.UserName & "\Videos\"
    Dim CARPETA_IMAGENES As String = "C:\Users\" & Environment.UserName & "\Pictures\"
    Dim FECHA As String = DateTime.Now.ToShortDateString().Replace("/", "_") + "_" + DateTime.Now.ToLongTimeString().Replace(":", "_")
    Dim SUBCARPETA As String
    Dim CARPETAS_DIARIAS As String = "C:\Users\" & Environment.UserName & "\Pictures\"
    Public Const WM_CAP As Short = &H400S
    Public Const WM_CAP_DLG_VIDEOFORMAT As Integer = WM_CAP + 41
    Public Const WM_CAP_DRIVER_CONNECT As Integer = WM_CAP + 10
    Public Const WM_CAP_DRIVER_DISCONNECT As Integer = WM_CAP + 11
    Public Const WM_CAP_EDIT_COPY As Integer = WM_CAP + 30
    Public Const WM_CAP_SEQUENCE As Integer = WM_CAP + 62
    Public Const WM_CAP_FILE_SAVEAS As Integer = WM_CAP + 23
    Public Const WM_CAP_SET_PREVIEW As Integer = WM_CAP + 50
    Public Const WM_CAP_SET_PREVIEWRATE As Integer = WM_CAP + 52
    Public Const WM_CAP_SET_SCALE As Integer = WM_CAP + 53
    Public Const WS_CHILD As Integer = &H40000000
    Public Const WS_VISIBLE As Integer = &H10000000
    Public Const SWP_NOMOVE As Short = &H2S
    Public Const SWP_NOSIZE As Short = 1
    Public Const SWP_NOZORDER As Short = &H4S
    Public Const HWND_BOTTOM As Short = 1
    Public Const WM_CAP_STOP As Integer = WM_CAP + 68

    Public iDevice As Integer = 0 ' Current device ID
    Public hHwnd As Integer ' Handle to preview window

    Public Declare Function SendMessage Lib "user32" Alias "SendMessageA" _
        (ByVal hwnd As Integer, ByVal wMsg As Integer, ByVal wParam As Integer, _
        <MarshalAs(UnmanagedType.AsAny)> ByVal lParam As Object) As Integer

    Public Declare Function SetWindowPos Lib "user32" Alias "SetWindowPos" (ByVal hwnd As Integer, _
        ByVal hWndInsertAfter As Integer, ByVal x As Integer, ByVal y As Integer, _
        ByVal cx As Integer, ByVal cy As Integer, ByVal wFlags As Integer) As Integer

    Public Declare Function DestroyWindow Lib "user32" (ByVal hndw As Integer) As Boolean

    Public Declare Function capCreateCaptureWindowA Lib "avicap32.dll" _
        (ByVal lpszWindowName As String, ByVal dwStyle As Integer, _
        ByVal x As Integer, ByVal y As Integer, ByVal nWidth As Integer, _
        ByVal nHeight As Short, ByVal hWndParent As Integer, _
        ByVal nID As Integer) As Integer

    Public Declare Function capGetDriverDescriptionA Lib "avicap32.dll" (ByVal wDriver As Short, _
        ByVal lpszName As String, ByVal cbName As Integer, ByVal lpszVer As String, _
        ByVal cbVer As Integer) As Boolean


    'Open View
    Public Sub OpenPreviewWindow()

        ' Open Preview window in picturebox
        '
        hHwnd = capCreateCaptureWindowA(iDevice, WS_VISIBLE Or WS_CHILD, 0, 0, 640, _
           480, VISOR.Handle.ToInt32, 0)

        ' Connect to device
        '
        Dim CAMARA As Integer = Nothing
        Try
            For I = 0 To 10 'EN ALGUNOS EQUIPOS HAY QUE LANZAR LA FUNCION VARIAS VECES SI NO SE EJECUTA COMO ADMINISTRADOR
                CAMARA = SendMessage(hHwnd, WM_CAP_DRIVER_CONNECT, iDevice, 0)
                If CAMARA > 0 Then
                    'Set the preview scale

                    SendMessage(hHwnd, WM_CAP_SET_SCALE, True, 0)

                    'Set the preview rate in milliseconds
                    '
                    SendMessage(hHwnd, WM_CAP_SET_PREVIEWRATE, 66, 0)

                    'Start previewing the image from the camera
                    '
                    SendMessage(hHwnd, WM_CAP_SET_PREVIEW, True, 0)

                    ' Resize window to fit in picturebox
                    '
                    SetWindowPos(hHwnd, HWND_BOTTOM, 0, 0, VISOR.Width, VISOR.Height, _
                            SWP_NOMOVE Or SWP_NOZORDER)
                    Exit For
                End If
            Next
        Catch ex As Exception
            DestroyWindow(hHwnd)
            INICIAR.Visible = True
            MsgBox("No se pudo Conectar con la Camara", MsgBoxStyle.Critical, "Worcome Security")
        End Try

    End Sub


    Private Sub INICIAR_Click(ByVal sender As Object, ByVal e As EventArgs) Handles INICIAR.Click
        'Load And Capture Device
        OpenPreviewWindow()
        INICIAR.Enabled = False
    End Sub

    Private Sub CAPTURAR_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CAPTURAR.Click
        CAPTURAR.BackColor = Color.Red
        ' Copy image to clipboard
        '
        SendMessage(hHwnd, WM_CAP_EDIT_COPY, 0, 0)
        ' Get image from clipboard and convert it to a bitmap
        '
        DATOS = Clipboard.GetDataObject()
        IMAGEN = CType(DATOS.GetData(GetType(System.Drawing.Bitmap)), Image)
        CAPTURAR.BackColor = Color.Gainsboro
        PictureBox1.Image = IMAGEN
    End Sub

    Private Sub GUARDAR_Click(ByVal sender As Object, ByVal e As EventArgs) Handles GUARDAR.Click
        Try
            Dim FECHA As String = DateTime.Now.ToShortDateString().Replace("/", "_") + "_" + DateTime.Now.ToLongTimeString().Replace(":", "_")
            Dim CARPETA_CAPTURAS As String = DIRCommons & "Capturas"

            If My.Computer.FileSystem.DirectoryExists(CARPETA_CAPTURAS) = False Then
                My.Computer.FileSystem.CreateDirectory(CARPETA_CAPTURAS)
            End If
            PictureBox1.Image.Save(CARPETA_CAPTURAS & "\" & FECHA & ".jpg", Imaging.ImageFormat.Jpeg)
            MsgBox("Imagen Guardada Correctamente", MsgBoxStyle.Information, "Worcome Security")
        Catch ex As Exception
            MsgBox("Error Interno: " & ex.Message, MsgBoxStyle.Critical, "Worcome Security")
        End Try
    End Sub

    Private Sub GRABAR_Click(ByVal sender As Object, ByVal e As EventArgs) Handles GRABAR.Click
        MsgBox("Clickea 'Aceptar' para Comenzar con la Grabacion", MsgBoxStyle.Information, "Worcome Security")
        GRABAR.Enabled = False
        SendMessage(hHwnd, WM_CAP_DLG_VIDEOFORMAT, 0, 0)
        SendMessage(hHwnd, WM_CAP_SEQUENCE, 0, 0)
        If My.Computer.FileSystem.DirectoryExists(CARPETA_VIDEOS) = False Then
            My.Computer.FileSystem.CreateDirectory(CARPETA_VIDEOS)
        End If
        GRABAR.BackColor = Color.Red
    End Sub

    Private Sub FGRABAR_Click(ByVal sender As Object, ByVal e As EventArgs) Handles FGRABAR.Click
        GRABAR.Enabled = True
        Dim FECHA As String = DateTime.Now.ToShortDateString().Replace("/", "_") + "_" + DateTime.Now.ToLongTimeString().Replace(":", "_")
        SendMessage(hHwnd, WM_CAP_STOP, 0, 0)
        SendMessage(hHwnd, WM_CAP_FILE_SAVEAS, 0, CARPETA_VIDEOS & FECHA & ".avi")
        Try
            My.Computer.FileSystem.DeleteFile(CARPETA_VIDEOS & "CAPTURE.avi")
            MsgBox("Video Guardado", MsgBoxStyle.Information, "Worcome Security")
            GRABAR.BackColor = Color.White
        Catch ex As Exception
            MsgBox("Se Necesitan Permisos de ADMINISTRADOR", MsgBoxStyle.Critical, "Worcome Security")
            GRABAR.BackColor = Color.White
            Console.WriteLine("[CAMPro@FinGRABAR_Click]Error: " & ex.Message)
        End Try
    End Sub

    Private Sub FORMATO_Click(ByVal sender As Object, ByVal e As EventArgs) Handles FORMATO.Click
        SendMessage(hHwnd, WM_CAP_DLG_VIDEOFORMAT, 0, 0)
    End Sub


    Private Sub ButtonSERIEDIARIA_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ButtonSERIEDIARIA.Click
        MsgBox("Clickea en 'Acpetar' para Comenzar la Serie de Imagenes", MsgBoxStyle.Information, "Worcome Security")
        ButtonSERIEDIARIA.Enabled = False
        If My.Computer.FileSystem.DirectoryExists(CARPETAS_DIARIAS) = False Then
            My.Computer.FileSystem.CreateDirectory(CARPETAS_DIARIAS)
        End If

        SUBCARPETA = DateTime.Now.ToShortDateString().Replace("/", "_") & "\"

        If My.Computer.FileSystem.DirectoryExists(CARPETAS_DIARIAS & SUBCARPETA) = False Then
            My.Computer.FileSystem.CreateDirectory(CARPETAS_DIARIAS & SUBCARPETA)
        End If
        Timer1.Enabled = True
        ButtonSERIEDIARIA.BackColor = Color.Red
    End Sub

    Private Sub ButtonFINSERIEDIARIA_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ButtonFINSERIEDIARIA.Click
        ButtonSERIEDIARIA.Enabled = True
        Timer1.Enabled = False
        ButtonSERIEDIARIA.BackColor = Color.Gainsboro
        MsgBox("Serie de Imagenes Finalizada", MsgBoxStyle.Information, "Worcome Security")
    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles Timer1.Tick
        Dim FECHA As String = DateTime.Now.ToShortDateString().Replace("/", "_") + "_" + DateTime.Now.ToLongTimeString().Replace(":", "_")

        ' Copy image to clipboard
        '
        SendMessage(hHwnd, WM_CAP_EDIT_COPY, 0, 0)

        ' Get image from clipboard and convert it to a bitmap
        '
        DATOS = Clipboard.GetDataObject()
        IMAGEN = CType(DATOS.GetData(GetType(System.Drawing.Bitmap)), Image)
        CAPTURA.PCAPTURA.Image = IMAGEN
        Try
            CAPTURA.PCAPTURA.Image.Save(CARPETAS_DIARIAS & SUBCARPETA & FECHA & ".Jpg", Imaging.ImageFormat.Jpeg)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Timer2_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles Timer2.Tick
        SendMessage(hHwnd, WM_CAP_EDIT_COPY, 0, 0)

        ' Get image from clipboard and convert it to a bitmap
        '
        DATOS = Clipboard.GetDataObject()

        IMAGEN = CType(DATOS.GetData(GetType(System.Drawing.Bitmap)), Image)
        PictureBox1.Image = IMAGEN
    End Sub

    Private Sub CAMPro_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Selector.Show()
        Me.Dispose()
    End Sub

    Private Sub CAMPro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MsgBox("Este modo funciona con Permisos de Administrador", MsgBoxStyle.Information, "Worcome Security")
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        CAPTURA.PCAPTURA.Image = PictureBox1.Image
        CAPTURANDO()
    End Sub

    Public Sub CAPTURANDO()
        CAPTURA.Show()
    End Sub

    Private Sub VISOR_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles VISOR.DoubleClick
        CAPTURA.PCAPTURA.Image = VISOR.Image
        CAPTURANDO()
    End Sub
End Class
