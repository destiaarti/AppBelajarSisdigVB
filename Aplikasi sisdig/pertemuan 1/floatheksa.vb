Public Class floatheksa

    Private Sub float32_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub


    Function dec_to_float(ByVal dec As Decimal) As String
        Dim d1 As Decimal = 0
        Dim d2 As Decimal = 0
        Dim d3 As Decimal = 0
        Dim d4 As Decimal = 0

        Dim i1 As Integer = 0
        Dim i2 As Integer = 0
        Dim i3 As Integer = 0
        Dim i4 As UInteger = 0
        Dim i5 As UInteger = 0
        Dim i6 As UInteger = 0
        Dim i7 As UInteger = 0
        'Dim i8 As UInteger = 0

        Dim s1 As String = ""
        Dim s2 As String = ""
        Dim s3 As String = ""
        Dim s4 As String = ""
        Try

            If dec < 0 Then 'evaluate sign bit
                i7 = 2 ^ 31
                dec = -dec
            End If
            '******************************************************
            If dec <> 0 Then

                '******************************************************
                d1 = dec
                If d1 >= 2 Then
                    Do Until d1 < 2
                        d1 = d1 / 2
                        i1 = i1 + 1
                    Loop

                ElseIf d1 < 1 Then
                    Do Until d1 >= 1
                        d1 = d1 * 2
                        i1 = i1 - 1
                    Loop

                End If
                i1 = i1 + 127 'exponent
                '******************************************************

                d2 = d1
                d3 = Math.Floor(d2)
                Do Until (d3 = d2) Or (d2 > 4294967295) '21474836484294967295 (i3 >= 23) 
                    d4 = Math.Floor(d2)
                    d2 = d2 * 2
                    d3 = Math.Floor(d2)
                    i3 = i3 + 1

                Loop

                If d3 > 4294967295 Then
                    i4 = Convert.ToUInt32(d4)
                Else
                    i4 = Convert.ToUInt32(d3)
                End If

                Do Until (i4 And 2 ^ 31) = 2 ^ 31
                    i4 = i4 << 1
                Loop

                i5 = (i4 << 1)
                i5 = (i5 >> 9) 'mantissa bits 22 -> 0
                '*********************************************************

                i6 = (i1 << 23) + i5 'exponent + mantissa
                i6 = i6 + i7 'sign + exponent + mantissa

                s4 = i6.ToString("X8") ' end result

            ElseIf dec = 0 Then
                'i6 = i6 + i7
                s4 = i6.ToString("X8") ' end result

            End If

        Catch ex As Exception

        End Try

        Return s4
    End Function



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TextBox2.Text = dec_to_float(MaskedTextBox1.Text)
    End Sub
End Class