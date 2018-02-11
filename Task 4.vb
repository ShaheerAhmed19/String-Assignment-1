Module Module1

    Sub Main()

        Dim str1 As String = ""
        Dim str2 As String = ""
        Dim char_str1 As String = ""
        Dim char_str2 As String = ""
        Dim ostr As String = ""

        Console.Write("Enter String 1 : ")
        str1 = Console.ReadLine
        Console.Write("Enter String 2 : ")
        str2 = Console.ReadLine

        char_str1 = Left(str1, 2)
        char_str2 = Left(str2, 2)

        ostr = char_str2 & Mid(str1, 3, Len(str1)) & " " & char_str1 & Mid(str2, 3, Len(str2))

        Console.Write("Output is : " & ostr)
        Console.ReadKey()

    End Sub

End Module
