Module App
    Sub Main(args As String())
'        dim user as new User("d", "Quliyev", 22)
'        If user.Name IsNot Nothing Then 'Notthing = Null'
'            Console.WriteLine("is not null")
'
'        Else
'            Console.WriteLine("is null")
'        End If

'        dim num as Integer = 15
'        dim num2 as integer = 1
'
'        dim operation as string
'        Console.Write("op:  ")
'        operation = Console.ReadLine()
'        
'        Select Case operation
'            case "+"
'                Console.WriteLine(num + num2)
'            case "-"
'                Console.WriteLine(num - num2)
'            case "*"
'                Console.WriteLine(num*num2)
'            case "/"
'                Try
'                    If num2 = 0 Then
'                        throw new DivideByZeroException("num2 = 0")
'                    Else
'                        Console.WriteLine(num/num2)
'                    End If
'                Catch ex as DivideByZeroException
'                    Console.WriteLine($"{ex.Message}")
'                End Try
'        End Select

'        If num > 10 orElse num < 15 Then '&& and ||'
'            Console.WriteLine("is digit letter 10 and small 15")
'        Else
'            Console.WriteLine("digit no correct")
'        End If

'        dim result as string = If(num > 10, "digit from ten is big", "digit from ten is small") 'Ternary operator'
'        Console.WriteLine(result)


        dim nums as new List(Of integer)
        For i As Integer = 0 To 100 step 5
            nums.Add(i)
        Next
        For Each o As integer In nums
            Console.WriteLine(o)
        Next
    End Sub
End Module