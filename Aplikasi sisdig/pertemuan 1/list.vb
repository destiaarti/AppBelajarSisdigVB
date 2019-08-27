Public Class list


    Private Sub RichTextBox1_Text(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RichTextBox1.TextChanged
        Dim sTemp As String = ""

        'strings Header
        sTemp = "Decimal" & vbTab & "Hexa" & vbTab & "Okta" & vbTab & "Binary" & vbCrLf
        sTemp = String.Format(" {0, 10} {1, 10} {2, 15}{3, 10}" & vbCrLf, "Dec", "Heksadesimal", "Oktadesimal", "Biner" & vbCrLf)

        'strings equivalents
        For i As Integer = 1 To 350
            sTemp = sTemp & String.Format(" {0,10} {0, 10:X}    {1, 15:C}          {2, 10:C}", i, Convert.ToString(i, 8), Convert.ToString(i, 2)) & vbCrLf



        Next
        
        RichTextBox1.Text = sTemp
    End Sub


    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub
End Class