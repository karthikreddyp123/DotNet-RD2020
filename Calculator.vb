Imports System

Class HelloWorld
    Shared Sub Main()
        Console.WriteLine("Opening Calculator.")
        Dim calc As Calculator = New Calculator()
        Dim temp As Boolean = True

        While temp
            Console.WriteLine("1. Addition")
            Console.WriteLine("2. Subtraction")
            Console.WriteLine("3. Multiplication")
            Console.WriteLine("4. Division")
            Console.WriteLine("5. Exit")
            Console.WriteLine("Choose any Option")
            Dim choice As Integer = Convert.ToInt32(Console.ReadLine())

            If choice = 5 Then
                Exit While
            End If

            Console.WriteLine("Enter two numbers:")
            Dim num1 As Integer = Convert.ToInt32(Console.ReadLine())
            Dim num2 As Integer = Convert.ToInt32(Console.ReadLine())

            Select Case choice
                Case 1
                    Console.WriteLine("Result:" & calc.add(num1, num2))
                    Exit Select
                Case 2
                    Console.WriteLine("Result:" & calc.[sub](num1, num2))
                    Exit Select
                Case 3
                    Console.WriteLine("Result:" & calc.multiply(num1, num2))
                    Exit Select
                Case 4
                    Console.WriteLine("Result:" & calc.div(num1, num2))
                    Exit Select
                Case Else
                    Console.WriteLine("Choose valid option.")
                    Exit Select
            End Select
        End While
    End Sub
End Class

Class Calculator
    Public Function add(ByVal num1 As Integer, ByVal num2 As Integer) As Integer
        Return num1 + num2
    End Function

    Public Function [sub](ByVal num1 As Integer, ByVal num2 As Integer) As Integer
        Return num1 - num2
    End Function

    Public Function multiply(ByVal num1 As Integer, ByVal num2 As Integer) As Integer
        Return num1 * num2
    End Function

    Public Function div(ByVal num1 As Integer, ByVal num2 As Integer) As Double
        Return num1 / num2
    End Function
End Class
