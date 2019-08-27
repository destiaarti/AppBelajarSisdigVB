Public Class Form2
    Dim hari As String
    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub Form2_Unload(ByVal Cancel As Integer)
        Dim Konfir As Integer
        Konfir = MsgBox("Anda yakin ingin keluar ?", vbYesNo + vbQuestion, "Konfirmasi")
        If Konfir = vbYes Then
            Cancel = 0
            End
        Else
            Cancel = 1

        End If
    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label3.Text = Today

    End Sub


    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        Form3.Show()
        Me.Close()
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click


    End Sub


    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button20.Click
        Form2_Unload(0)
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label4.Text = TimeOfDay()
    End Sub

 

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Process.Start("D:\PROJECT\TA\Aplikasi sisdig\Aplikasi sisdig\Resources\1.pdf", vbMaximizedFocus)
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        Shell("D:\PROJECT\TA\Aplikasi sisdig\Aplikasi sisdig\Resources\Bmin\bmin.exe", vbMaximizedFocus)
    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        Shell("D:\PROJECT\TA\Aplikasi sisdig\Aplikasi sisdig\Resources\Qucs\bin\qucs.exe", vbMaximizedFocus)
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Process.Start("D:\PROJECT\TA\Aplikasi sisdig\Aplikasi sisdig\Resources\9.pdf", vbMaximizedFocus)
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Process.Start("D:\PROJECT\TA\Aplikasi sisdig\Aplikasi sisdig\Resources\2.pdf", vbMaximizedFocus)
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Process.Start("D:\PROJECT\TA\Aplikasi sisdig\Aplikasi sisdig\Resources\3.pdf", vbMaximizedFocus)
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Process.Start("D:\PROJECT\TA\Aplikasi sisdig\Aplikasi sisdig\Resources\4.pdf", vbMaximizedFocus)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Process.Start("D:\PROJECT\TA\Aplikasi sisdig\Aplikasi sisdig\Resources\5.pdf", vbMaximizedFocus)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Process.Start("D:\PROJECT\TA\Aplikasi sisdig\Aplikasi sisdig\Resources\6.pdf", vbMaximizedFocus)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Process.Start("D:\PROJECT\TA\Aplikasi sisdig\Aplikasi sisdig\Resources\7.pdf", vbMaximizedFocus)
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Process.Start("D:\PROJECT\TA\Aplikasi sisdig\Aplikasi sisdig\Resources\8.pdf", vbMaximizedFocus)
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Process.Start("D:\PROJECT\TA\Aplikasi sisdig\Aplikasi sisdig\Resources\10.pdf", vbMaximizedFocus)
    End Sub

    Private Sub Button19_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button19.Click
        Process.Start("D:\PROJECT\TA\Aplikasi sisdig\Aplikasi sisdig\Resources\11.pdf", vbMaximizedFocus)
    End Sub

    Private Sub Button22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button22.Click
        Process.Start("D:\PROJECT\TA\Aplikasi sisdig\Aplikasi sisdig\Resources\UTS.pdf", vbMaximizedFocus)
    End Sub

    Private Sub Button23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button23.Click
        Process.Start("D:\PROJECT\TA\Aplikasi sisdig\Aplikasi sisdig\Resources\solusi.htm", vbMaximizedFocus)
    End Sub



    Private Sub Button17_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button17.Click
        float64.Show()
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        floatheksa.Show()
    End Sub

    Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button18.Click
        email.Show()
    End Sub

    Private Sub Button24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button24.Click
        float_32bit.Show()
    End Sub


End Class