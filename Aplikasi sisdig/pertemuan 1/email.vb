Imports System.Net.Mail
Public Class email

    Private Sub email_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Dim Smtp_Server As New SmtpClient
            Dim e_mail As New MailMessage()

            Smtp_Server.UseDefaultCredentials = False
            Smtp_Server.Credentials = New Net.NetworkCredential("hmmpolines20142015@gmail.com", "20152014hmmpolines")
            Smtp_Server.Port = 587
            Smtp_Server.EnableSsl = True
            Smtp_Server.Host = "smtp.gmail.com"
            e_mail = New MailMessage()
            e_mail.From = New MailAddress(TextBox1.Text)
            e_mail.To.Add(Label3.Text)
            e_mail.Subject = "Email Terkirim"
            e_mail.IsBodyHtml = False
            e_mail.Body = RichTextBox1.Text
            Smtp_Server.Send(e_mail)
            MsgBox("Email terkirim. Terima kasih Atas Saran dan kritiknya!")
        Catch error_t As Exception
            MsgBox(error_t.ToString)
            Exit Sub
        End Try
    End Sub

    Private Sub RichTextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RichTextBox1.TextChanged

    End Sub
End Class