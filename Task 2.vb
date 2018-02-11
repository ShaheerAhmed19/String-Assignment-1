Module Module1

    Sub Main()
        Dim str As String = ""
        Dim lstr As String = ""
        Dim rstr As String = ""

        Console.Write("Enter A String : ")
        str = Console.ReadLine

        rstr = Right(str, 2)
        lstr = Left(str, 2)

            If Len(str) < 2 Then
                Console.Write("The Length of string is less than 2")
            Else
                Console.Write("The new string is : " & lstr & rstr)
            End If
            Console.ReadKey()
    End Sub

End Module
