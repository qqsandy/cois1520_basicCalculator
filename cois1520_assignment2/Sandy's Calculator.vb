Public Class Calculator
    '--------------------------------------------------------------------------------
    ' Written By:       Sandy Le
    ' Course:           COIS 1520 - Assignment #2
    ' Written On:       February 18. 2019
    ' Due Date:         February 19, 2019
    ' Program Name:     Basic Calculator
    '
    ' Program Description:
    ' This program was coded by myself with the help of the citation(s) below. This was an assignment for the course cois 1520, and it had a guideline of instructions that needed to
    ' include serveral things such as operations, operands, answers, history, exit function, etc.
    ' This basic calculator has four main operations such as; addition, subtraction, multiplication and division. The answer displays on the answer box and all the equations will be listed
    ' under the history box. This program will only take integers, decimals, and backspace in the parameter boxes.
    '--------------------------------------------------------------------------------
    ' Instructions:
    ' Enter a integer into the first paramter
    ' Enter another integer that you wish to use in the secound parameter
    ' Click on the operation you desire, note that the first parameter is self explanatory and will act as such.
    ' Once the operation you want is clicked the answer will be displayed in the answer box along with the equation being added to the calculator history.
    ' *NOTE: Clear All will infact clear everything from paramters, answer to history. So be careful!
    '--------------------------------------------------------------------------------
    ' Integrity citation:
    ' http://net-informations.com/q/faq/txtbox.html
    ' All images in the program are created by myself
    '--------------------------------------------------------------------------------
    ' Other Stuff:
    ' FirstInputBox, SecoundInputBox: The boxes that are labeled "1st and 2nd parameter" lets user input the parameters to be calculated.
    ' FirstParameterLabel,SecoundParameterLabel, AnswerLabel, HistoryLabel: These are labels for either the boxes that correspond directly by name.
    ' AnswerBox: The box that shows the answer for the equation/operation by the user, also used to prompt errors if present
    ' CalculatorHistory: This listbox shows all the calculations/operations that the user had done.
    ' ExitButton: Self explanatory, just a button to clsoe the program.
    ' ClearAllButton: Clears all the contents in first/secound parameter, answer and history box.
    ' Addition, Subtraction, Mulitiplication and Division: These buttons are the operators, pretty self explanatory
    ' LegendLabel: This is a label that contents text that show the user the hotkeys present within the program
    ' ContactLink: This is an addition shameless plug I added on the program that executes on your default browser when clicked.


    Private Sub Division_Click(sender As Object, e As EventArgs) Handles Division.Click
        ' The if statement above checks if there are intgers entered in the parameter boxes, if one or neither of the parameter boxes have integers inputted
        ' then the operation would not work and an error will be outputed in the answer box, and the history box will not be activated.
        ' Else if the secound user input is equal to zero then the else if portition of the code will execute an error message box pop-up.
        ' In the event that there are proper user input in the parameter boxes then the else portion will calculate the equation "first parameter / secound paramter = Answer"
        ' The answer will be outputed in the answer box, and the whole equaition including the operands, result and operation will be printed in the history box.
        If String.IsNullOrEmpty(FirstInputBox.Text) Or String.IsNullOrEmpty(SecoundInputBox.Text) Then
            AnswerBox.Text = "ERROR: Parameter(s) are empty"

        ElseIf Val(SecoundInputBox.Text = 0) Then
            MsgBox("***ERROR***: YOU CANNOT DIVIDE BY ZERO!")
            AnswerBox.Text = "ERROR: Division by zero is impossible"
        Else
            AnswerBox.Text = Val(FirstInputBox.Text) / Val(SecoundInputBox.Text)
            CalculatorHistory.Items.Add(FirstInputBox.Text & " / " & SecoundInputBox.Text & " = " & AnswerBox.Text & vbNewLine)
            CalculatorHistory.TopIndex = CalculatorHistory.Items.Count - 1
        End If

    End Sub

    Private Sub Addtition_Click(sender As Object, e As EventArgs) Handles Addtition.Click
        ' The if statement above checks if there are intgers entered in the parameter boxes, if one or neither of the parameter boxes have integers inputted
        ' then the operation would not work and an error will be outputed in the answer box, and the history box will not be activated.
        ' In the event that there are proper user input in the parameter boxes then the else portion will calculate the equation "first parameter + secound paramter = Answer"
        ' The answer will be outputed in the answer box, and the whole equaition including the operands, result and operation will be printed in the history box.
        If String.IsNullOrEmpty(FirstInputBox.Text) Or String.IsNullOrEmpty(SecoundInputBox.Text) Then
            AnswerBox.Text = "ERROR: Parameter(s) are empty"
        Else
            AnswerBox.Text = Val(FirstInputBox.Text) + Val(SecoundInputBox.Text)
            CalculatorHistory.Items.Add(FirstInputBox.Text & " + " & SecoundInputBox.Text & " = " & AnswerBox.Text & vbNewLine)
            CalculatorHistory.TopIndex = CalculatorHistory.Items.Count - 1
        End If
    End Sub

    Private Sub Subtraction_Click(sender As Object, e As EventArgs) Handles Subtraction.Click
        ' The if statement above checks if there are intgers entered in the parameter boxes, if one or neither of the parameter boxes have integers inputted
        ' then the operation would not work and an error will be outputed in the answer box, and the history box will not be activated.
        ' In the event that there are proper user input in the parameter boxes then the else portion will calculate the equation "first parameter - secound paramter = Answer"
        ' The answer will be outputed in the answer box, and the whole equaition including the operands, result and operation will be printed in the history box.
        If String.IsNullOrEmpty(FirstInputBox.Text) Or String.IsNullOrEmpty(SecoundInputBox.Text) Then
            AnswerBox.Text = "ERROR: Parameter(s) are empty"
        Else
            AnswerBox.Text = Val(FirstInputBox.Text) - Val(SecoundInputBox.Text)
            CalculatorHistory.Items.Add(FirstInputBox.Text & " - " & SecoundInputBox.Text & " = " & AnswerBox.Text & vbNewLine)
            CalculatorHistory.TopIndex = CalculatorHistory.Items.Count - 1
        End If
    End Sub

    Private Sub Multiplication_Click(sender As Object, e As EventArgs) Handles Multiplication.Click
        ' The if statement above checks if there are intgers entered in the parameter boxes, if one or neither of the parameter boxes have integers inputted
        ' then the operation would not work and an error will be outputed in the answer box, and the history box will not be activated.
        ' In the event that there are proper user input in the parameter boxes then the else portion will calculate the equation "first parameter * secound paramter = Answer"
        ' The answer will be outputed in the answer box, and the whole equaition including the operands, result and operation will be printed in the history box.
        If String.IsNullOrEmpty(FirstInputBox.Text) Or String.IsNullOrEmpty(SecoundInputBox.Text) Then
            AnswerBox.Text = "ERROR: Parameter(s) are empty"
        Else
            AnswerBox.Text = Val(FirstInputBox.Text) * Val(SecoundInputBox.Text)
            CalculatorHistory.Items.Add(FirstInputBox.Text & " * " & SecoundInputBox.Text & " = " & AnswerBox.Text & vbNewLine)
            CalculatorHistory.TopIndex = CalculatorHistory.Items.Count - 1
        End If
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        ' This will ensure that the exit button closes the application. (Shortkey: 'x')
        Me.Close()
    End Sub

    Private Sub ClearAllButton_Click(sender As Object, e As EventArgs) Handles ClearAllButton.Click
        ' The code below will give the Clear All Button a function that will clear all the text within the 1st, 2nd parameter, answer and calculator box.
        FirstInputBox.Clear()
        SecoundInputBox.Clear()
        AnswerBox.Clear()
        CalculatorHistory.Items.Clear()

    End Sub

    Private Sub FirstInputBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles FirstInputBox.KeyPress
        ' In this KeyPress subroutine, I made sure that keystrokes that weren't numbers were unable to be registered in the textbox besides decimals "."
        ' Was able to created this by the sources above and looking up the asciiz representation of 'backspace'.

        e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Or Asc(e.KeyChar) = 8)

    End Sub

    Private Sub SecoundInputBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles SecoundInputBox.KeyPress
        ' (Just like the subroutine above, but for the secound parameter box) In this KeyPress subroutine, I made sure that keystrokes that weren't numbers
        ' were unable to be registered in the textbox besides decimals "." Was able to created this by the sources above and looking up the asciiz representation of 'backspace'.

        e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Or Asc(e.KeyChar) = 8)

    End Sub

    Private Sub ContactLink_Click(sender As Object, e As EventArgs) Handles ContactLink.Click
        ' Just an addition thing I did with the label that allows the user to launch my website through your default browser by clicking the label
        Process.Start("http://www.sandyle.net")
    End Sub
End Class
