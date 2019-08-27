Public Class float_32bit

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox1.Text = NumberToBits(text1.Text)
    End Sub

  Function NumberToBits(ByVal n As Double, _
        Optional ByVal TrimLeadingZeros As Boolean = False) As String
        Dim ms As New IO.MemoryStream
        Dim bw As New IO.BinaryWriter(ms)
        Dim br As New IO.BinaryReader(ms)
        bw.Write(n)
        Dim b As Byte
        Dim temp As Int32
        NumberToBits = ""
        For i As Int32 = CType(ms.Length, Int16) - 1 To 0 Step -1
            ms.Position = i
            b = br.ReadByte
            temp = CType(Convert.ToString(b, 2), Int32)
            NumberToBits &= String.Format("{0,2:0##}", temp)
        Next
        If TrimLeadingZeros Then
            If n = 0 Then
                NumberToBits = "0"
            Else
                NumberToBits = NumberToBits.Substring(NumberToBits.IndexOf("1"))
            End If
        End If
        ms.Close()
    End Function
End Class