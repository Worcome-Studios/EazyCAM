Public Class CAM

    Private Sub CAM_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Selector.Show()
        Me.Hide()
        WebCam1.Stop()
    End Sub

    Private Sub CAM_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            WebCam1.Start()
            WebCam1.Stop()
            WebCam1.Start()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Worcome Security")
        End Try
    End Sub

    Private Sub WebCam1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs)
        'CAPTURA.PCAPTURA.Image = WebCam1.Imagen
        CAPTURA.Show()
    End Sub

    Private Sub WebCam1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.O Then
            Options_CAM.Show()
        End If

        If e.KeyCode = Keys.G Then
            SaveFileDialog1.Title = "Guardar Imagen..."
            SaveFileDialog1.Filter = "JPG|*.jpg|PNG|*.png|Todos los Archivos|*.*"
            SaveFileDialog1.FileName = "IMG_EazyCAM"
            SaveFileDialog1.ShowDialog()
        End If
    End Sub

    Private Sub SaveFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog1.FileOk
        WebCam1.Imagen.Save(SaveFileDialog1.FileName)
    End Sub

    Private Sub StartToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        WebCam1.Refresh()
    End Sub
End Class