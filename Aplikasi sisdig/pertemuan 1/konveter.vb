Public Class konveter

    Public Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If ComboBox1.Text = "Desimal" And ComboBox2.Text = "Desimal" Then
            TextBox1.Text = text1.Text
        ElseIf ComboBox1.Text = "Desimal" And ComboBox2.Text = "Heksadesimal" Then
            TextBox1.Text = DesToHex(text1.Text)
        ElseIf ComboBox1.Text = "Desimal" And ComboBox2.Text = "Oktadesimal" Then
            TextBox1.Text = DesToOk(text1.Text)
        ElseIf ComboBox1.Text = "Desimal" And ComboBox2.Text = "Biner" Then
            TextBox1.Text = DesToBin(text1.Text)
        ElseIf ComboBox1.Text = "Biner" And ComboBox2.Text = "Biner" Then
            TextBox1.Text = text1.Text
        ElseIf ComboBox1.Text = "Biner" And ComboBox2.Text = "Desimal" Then
            TextBox1.Text = BinToDes(text1.Text)
        ElseIf ComboBox1.Text = "Biner" And ComboBox2.Text = "Heksadesimal" Then
            TextBox1.Text = BinToHex(text1.Text)
        ElseIf ComboBox1.Text = "Biner" And ComboBox2.Text = "Oktadesimal" Then
            TextBox1.Text = BinToOk(text1.Text)
        ElseIf ComboBox1.Text = "Heksadesimal" And ComboBox2.Text = "Heksadesimal" Then
            TextBox1.Text = text1.Text
        ElseIf ComboBox1.Text = "Oktadesimal" And ComboBox2.Text = "Oktadesimal" Then
            TextBox1.Text = text1.Text
        ElseIf ComboBox1.Text = "Heksadesimal" And ComboBox2.Text = "Desimal" Then
            TextBox1.Text = HexToDes(text1.Text)
        ElseIf ComboBox1.Text = "Oktadesimal" And ComboBox2.Text = "Desimal" Then
            TextBox1.Text = OkToDes(text1.Text)
        ElseIf ComboBox1.Text = "Heksadesimal" And ComboBox2.Text = "Biner" Then
            TextBox1.Text = HexToBin(text1.Text)
        ElseIf ComboBox1.Text = "Heksadesimal" And ComboBox2.Text = "Oktadesimal" Then
            TextBox1.Text = HexToOk(text1.Text)
        ElseIf ComboBox1.Text = "Oktadesimal" And ComboBox2.Text = "Heksadesimal" Then
            TextBox1.Text = OkToHex(text1.Text)
        ElseIf ComboBox1.Text = "Oktadesimal" And ComboBox2.Text = "Biner" Then
            TextBox1.Text = OkToBin(text1.Text)
        Else
            MessageBox.Show("Masukan Pilihan dengan benar!")
        End If
    End Sub
    Public Function DesToHex(ByVal Desimal As Long) As String
        On Error GoTo HexError
        DesToHex = Hex(Desimal)
        Exit Function
HexError:
        DesToHex = MessageBox.Show("Bilangan terlalu besar!")
    End Function

    Public Function DesToOk(ByVal NDesimal As Long) As String
        DesToOk = Oct(NDesimal)
    End Function
    Public Function DesToBin(ByVal NDesimal As Long) As String
        Dim C As Byte
        Dim D As Long
        Dim Nilai As String
        On Error GoTo ErrorHandler
        D = (2 ^ 31) - 1
        While D > 0
            If NDesimal - D >= 0 Then
                NDesimal = NDesimal - D
                Nilai = Nilai & "1"
            Else
                If Val(Nilai) > 0 Then Nilai = Nilai & "0"
            End If
            D = D / 2
        End While
        DesToBin = Nilai
        Exit Function
ErrorHandler:
        DesToBin = MessageBox.Show("Bilangan terlalu besar!")
    End Function
    
   Public Function BinToDes(ByVal NBiner As String) As Long
        Dim A As Integer
        Dim B As Long
        Dim Nilai As Long
        On Error GoTo ErrorHandler
        B = 1
        For A = Len(NBiner) To 1 Step -1
            If Mid(NBiner, A, 1) = "1" Then Nilai = Nilai + B
            B = B * 2
        Next
        BinToDes = Nilai
        Exit Function
ErrorHandler:
        BinToDes = MessageBox.Show("Bilangan terlalu besar!")
    End Function
   

    Public Function HexToDes(ByVal NHexa As String) As Long
        Dim E As Integer
        Dim Nilai As Long
        Dim F As Long
        Dim CharNilai As Byte
        On Error GoTo ErrorHandler
        For E = Len(NHexa) To 1 Step -1
            Select Case Mid(NHexa, E, 1)
                Case "0" To "9" : CharNilai = CInt(Mid(NHexa, E, 1))
                Case Else : CharNilai = Asc(Mid(NHexa, E, 1)) - 55
            End Select
            Nilai = Nilai + ((16 ^ F) * CharNilai)
            F = F + 1
        Next E
        HexToDes = Nilai
        Exit Function
ErrorHandler:
        HexToDes = MessageBox.Show("Bilangan terlalu besar!")
    End Function

    Public Function OkToDes(ByVal NOktal As String) As Long
        Dim G As Integer
        Dim H As Long
        Dim Nilai As Long
        On Error GoTo ErrorHandler
        For G = Len(NOktal) To 1 Step -1
            Nilai = Nilai + (8 ^ H) * CInt(Mid(NOktal, G, 1))
            H = H + 1
        Next G
        OkToDes = Nilai
        Exit Function
ErrorHandler:
        OkToDes = MessageBox.Show("Bilangan terlalu besar!")
    End Function
    Public Function BinToOk(ByVal bin As Long) As String
        On Error GoTo ErrorHandler
        BinToOk = DesToOk(BinToDes(bin))
        Exit Function
ErrorHandler:
        BinToOk = MessageBox.Show("Bilangan terlalu besar!")
    End Function

    Public Function BinToHex(ByVal NBiner As Long) As String
        BinToHex = DesToHex(BinToDes(NBiner))
    End Function

    Public Function OkToBin(ByVal NOktal As Double) As String
        OkToBin = DesToBin(OkToDes(NOktal))
    End Function
    Public Function OkToHex(ByVal NOktal As Double) As String
        OkToHex = DesToHex(OkToDes(NOktal))
    End Function

    Public Function HexToBin(ByVal NHexa As String) As String
        HexToBin = DesToBin(HexToDes(NHexa))
    End Function
    '
    Public Function HexToOk(ByVal NHexa As String) As Double
        HexToOk = DesToOk(HexToDes(NHexa))
    End Function

    Private Sub MaskedTextBox1_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs)

    End Sub
End Class