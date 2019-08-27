Public Class Form1
    Private Sub Form1_Unload(ByVal Cancel As Integer)
        Dim Konfir As Integer
        Konfir = MsgBox("Anda yakin ingin keluar ?", vbYesNo + vbQuestion, "Konfirmasi")
        If Konfir = vbYes Then
            Cancel = 0
            End
        Else
            Cancel = 1

        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
 
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        If TextBox1.Text = "" And TextBox2.Text = "" Then
            MessageBox.Show("Silakan isi ID User dan password anda terlebih dahulu!")
        ElseIf TextBox1.Text = "" Then
            MessageBox.Show("Silakan isi ID User anda terlebih dahulu!")
        ElseIf TextBox2.Text = "" Then
            MessageBox.Show("Silakan isi password anda terlebih dahulu!")
        ElseIf TextBox1.Text = "admin" And TextBox2.Text = "123" Then
            MessageBox.Show("Selamat Datang di Aplikasi Sisdig I SISKOM UNDIP!")
            Form2.Show()
            Me.Hide()
        Else
            MessageBox.Show("Masukan ID User dan password dengan benar!")
        End If
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        Form1_Unload(0)
    End Sub
End Class
