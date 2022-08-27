Imports AForge.Video
Imports AForge.Video.DirectShow
Public Class Options_CAM
    Public UserClose As Boolean = True

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click
        Label4.ForeColor = Color.Green
        EazyCAM.Width = Val(TextBox1.Text)
        EazyCAM.Height = Val(TextBox2.Text)
        If CheckBox1.CheckState = CheckState.Checked Then
            EazyCAM.TopMost = True
        Else
            EazyCAM.TopMost = False
        End If
        EazyCAM.Refresh()
    End Sub

    Private Sub Options_CAM_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox1.Text = EazyCAM.Width
        TextBox2.Text = EazyCAM.Height
        Label7.Text = EazyCAM.Opacity
        If EazyCAM.TopMost = True Then
            CheckBox1.CheckState = CheckState.Checked
        Else
            CheckBox1.CheckState = CheckState.Unchecked
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.CheckState = CheckState.Checked Then
            EazyCAM.TopMost = True
        Else
            EazyCAM.TopMost = False
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        EazyCAM.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        EazyCAM.MovementActive = True
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        EazyCAM.FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable
        EazyCAM.MovementActive = False
    End Sub

    'Zona de Ayuda para el Usuario "AYUDA(ToolTip1, Control, "Mensaje de Ayuda")"

    Sub AYUDA(ByVal Globo As ToolTip, ByVal Boton As Object, ByVal Mensaje As String)
        Globo.RemoveAll()
        Globo.SetToolTip(Boton, Mensaje)
        Globo.InitialDelay = 1000
        Globo.IsBalloon = False
    End Sub

    Private Sub TextBox1_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.MouseEnter
        AYUDA(ToolTip1, TextBox1, "Anchura del Formulario, Servira para la Resolucion de la Imagen")
    End Sub

    Private Sub TextBox2_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox2.MouseEnter
        AYUDA(ToolTip1, TextBox2, "Altura del Formulario, Servira para la Resolucion de la Imagen")
    End Sub

    Private Sub Button1_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.MouseEnter
        AYUDA(ToolTip1, Button1, "Formulario sin Bordes, Formulario Estatico")
    End Sub

    Private Sub Button2_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.MouseEnter
        AYUDA(ToolTip1, Button2, "Formulario con Bordes, Formulario Libre")
    End Sub

    Private Sub CheckBox1_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBox1.MouseEnter
        AYUDA(ToolTip1, CheckBox1, "Mostrar Formulario por Sobre todo")
    End Sub

    Private Sub Label4_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label4.MouseEnter
        AYUDA(ToolTip1, Label4, "Guardar Todo, Guarda lo que has Modificado")
    End Sub

    Private Sub TrackBar1_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBar1.Scroll
        EazyCAM.Opacity = 0.1 + Me.TrackBar1.Value / 100
        Label7.Text = TrackBar1.Value & "%"
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        If Button3.Text = "Control WebCam" Then
            Panel1.Visible = True
            Button3.Text = "Control Formulario"
        Else
            Panel1.Visible = False
            Button3.Text = "Control WebCam"
        End If
    End Sub

    Private Sub TrackBar2_Scroll(sender As Object, e As EventArgs) Handles TrackBar2.Scroll
        Label8.Text = "Zoom " & TrackBar2.Value
        EazyCAM.CAMARA.SetCameraProperty(CameraControlProperty.Zoom, TrackBar2.Value, CameraControlFlags.Manual)
    End Sub

    Private Sub TrackBar3_Scroll(sender As Object, e As EventArgs) Handles TrackBar3.Scroll
        Label9.Text = "Enfoque " & TrackBar3.Value
        EazyCAM.CAMARA.SetCameraProperty(CameraControlProperty.Focus, TrackBar3.Value, CameraControlFlags.Manual)
    End Sub

    Private Sub TrackBar4_Scroll(sender As Object, e As EventArgs) Handles TrackBar4.Scroll
        Label10.Text = "Exposicion " & TrackBar4.Value
        EazyCAM.CAMARA.SetCameraProperty(CameraControlProperty.Exposure, TrackBar4.Value, CameraControlFlags.Manual)
    End Sub

    Private Sub TrackBar5_Scroll(sender As Object, e As EventArgs) Handles TrackBar5.Scroll
        Label11.Text = "Inclinacion " & TrackBar5.Value
        EazyCAM.CAMARA.SetCameraProperty(CameraControlProperty.Tilt, TrackBar5.Value, CameraControlFlags.Manual)
    End Sub
End Class