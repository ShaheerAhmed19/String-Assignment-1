Module Module1

    Sub Main()
        Dim istr As String = ""
        Dim ostr As String = ""
        Dim fchar As Char = ""
        Dim count As Integer = 0

        Console.Write("Enter String : ")
        istr = Console.ReadLine

        fchar = Left(istr, 1)
        ostr = fchar

        For count = 1 To Len(istr) - 1
            If Mid(istr, count + 1, 1) = fchar Then
                ostr = ostr & "*"
            Else
                ostr = ostr & Mid(istr, count + 1, 1)
            End If
        Next

        Console.Write("Output is : " & ostr)
        Console.ReadKey()

    End Sub

End Module
