Public Class Selector

    Private Sub Selector_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            If My.Settings.OfflineMode = False Then
                AppService.StartAppService(False, False, True, False, True)
                Threading.Thread.Sleep(150)
            End If
        Catch ex As Exception
            'MsgBox("ERROR CRITICO CON 'AppService'", MsgBoxStyle.Critical, "Worcome Security")
        End Try
        Button5.Focus()
    End Sub

    Sub SecureCloser(ByVal ShowForm As Form, ByVal CloseForm As Form)
        Try
            ShowForm.Show()
            ShowForm.Focus()
            CloseForm.Dispose()
        Catch ex As Exception
            Console.WriteLine("[Selector@SecureCloser]Error: " & ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        EazyCAM.Show()
        EazyCAM.Focus()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        DeteccionMovimiento.Show()
        DeteccionMovimiento.Focus()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Video.Show()
        Video.Focus()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Fotomaton.Show()
        Fotomaton.Focus()
        Me.Hide()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        CAMPro.Show()
        CAMPro.Focus()
        Me.Hide()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        FastCam.Show()
        FastCam.Focus()
        Me.Hide()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        DosCameras.Show()
        DosCameras.Focus()
        Me.Hide()
    End Sub

    Private Sub Label9_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label9.Click
        About.Show()
    End Sub
End Class