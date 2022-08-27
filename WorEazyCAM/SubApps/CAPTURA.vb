Public Class CAPTURA

   
    Private Sub CAPTURA_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'MsgBox("Para Guardar la Imagen 'Click Derecho>Guardar Imagen'", MsgBoxStyle.Information, "Worcome Security")
    End Sub

    Private Sub GuardarImagenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuardarImagenToolStripMenuItem.Click
        Dim SavePic As New SaveFileDialog
        SavePic.Title = "Guardar Captura..."
        SavePic.FileName = Nothing
        SavePic.InitialDirectory = DesktopLocation.ToString
        If SavePic.ShowDialog = Windows.Forms.DialogResult.OK Then
            PCAPTURA.Image.Save(SavePic.FileName & ".jpeg", Imaging.ImageFormat.Jpeg)
        End If
    End Sub

    Private Sub BorrarImagenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BorrarImagenToolStripMenuItem.Click
        PCAPTURA.Image = Nothing
    End Sub

    Private Sub CerrarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CerrarToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub EnviarAORCToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnviarAORCToolStripMenuItem.Click
        ORC.PictureBox1.Image = PCAPTURA.Image
        ORC.LoadImage()
        ORC.Show()
    End Sub

    Private Sub EnviarAEditorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnviarAEditorToolStripMenuItem.Click
        Editor.PictureBoxFOTO.Image = PCAPTURA.Image
        Editor.Show()
    End Sub

    Private Sub AbrirCarpetaDefaultToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AbrirCarpetaDefaultToolStripMenuItem.Click
        Try
            Process.Start("C:\EAZYCAM")
        Catch ex As Exception

        End Try
    End Sub
End Class