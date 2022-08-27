Imports Emgu.CV
Imports Emgu.CV.OCR
Imports Emgu.CV.Structure
Imports Emgu.Util

Public Class ORC

    Private Sub ButtonIMAGEN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonIMAGEN.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            TextBox1.Clear()
            PictureBox1.ImageLocation = OpenFileDialog1.FileName
            LoadImage()
        End If

    End Sub

    Sub LoadImage()
            TextBox1.Clear()
        ESPERA(3000)
            Try
                Dim BMP As Bitmap = New Bitmap(PictureBox1.Image)
            Dim LECTOR As New Tesseract("tessdata", "eng", Tesseract.OcrEngineMode.OEM_TESSERACT_ONLY)
                LECTOR.Recognize(New Image(Of Bgr, Byte)(BMP))
                TextBox1.Text = LECTOR.GetText
                If TextBox1.Text.Trim = "" Then
                MsgBox("No se a Detectado Nada", MsgBoxStyle.Critical, "Worcome Security")
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
    End Sub

    Public Sub ESPERA(ByVal INTERVALO As Integer)
        Dim PARADA As New Stopwatch
        PARADA.Start()
        Do While PARADA.ElapsedMilliseconds < INTERVALO
            Application.DoEvents()
        Loop
        PARADA.Stop()
    End Sub

    Private Sub ORC_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class

