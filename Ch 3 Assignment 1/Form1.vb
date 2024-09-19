Public Class Form1

    Dim num1 As Integer
    Dim num2 As Integer

    Private Sub numOne_TextChanged(sender As Object, e As EventArgs) Handles numOne.TextChanged
        Integer.TryParse(numOne.Text, num1) ' using TryParse to convert the text to an integer to prevent errors 
    End Sub

    Private Sub numTwo_TextChanged(sender As Object, e As EventArgs) Handles numTwo.TextChanged
        Integer.TryParse(numTwo.Text, num2)
    End Sub
    Private Sub addBtn_Click(sender As Object, e As EventArgs) Handles addBtn.Click
        calculate("+")
    End Sub

    Private Sub subBtn_Click(sender As Object, e As EventArgs) Handles subBtn.Click
        calculate("-")
    End Sub

    Private Sub multBtn_Click(sender As Object, e As EventArgs) Handles multBtn.Click
        calculate("*")
    End Sub

    ' calculate the result of the two numbers
    Function calculate(symbol As String) As Integer

        Dim numResult As Integer

        Select Case symbol ' Figured out this case function last assignment, and it works well for this too
            Case "+"
                numResult = num1 + num2 ' do the math
                result.Text = numResult ' set result box
                formula.Text = num1 & " + " & num2 & " = " & numResult ' set formula box
            Case "-"
                numResult = num1 - num2
                result.Text = numResult
                formula.Text = num1 & " - " & num2 & " = " & numResult
            Case "*"
                numResult = num1 * num2
                result.Text = numResult
                formula.Text = num1 & " * " & num2 & " = " & numResult

        End Select

        Return numResult ' dont need to call the return val but have to return something

    End Function

End Class
