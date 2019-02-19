<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Calculator
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Calculator))
        Me.FirstInputBox = New System.Windows.Forms.TextBox()
        Me.SecoundInputBox = New System.Windows.Forms.TextBox()
        Me.AnswerBox = New System.Windows.Forms.TextBox()
        Me.Addtition = New System.Windows.Forms.Button()
        Me.Subtraction = New System.Windows.Forms.Button()
        Me.Multiplication = New System.Windows.Forms.Button()
        Me.Division = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.ClearAllButton = New System.Windows.Forms.Button()
        Me.FirstParameterLabel = New System.Windows.Forms.Label()
        Me.SecoundParameterLabel = New System.Windows.Forms.Label()
        Me.CalculatorHistory = New System.Windows.Forms.ListBox()
        Me.AnswerLabel = New System.Windows.Forms.Label()
        Me.HistoryLabel = New System.Windows.Forms.Label()
        Me.LegendLabel = New System.Windows.Forms.Label()
        Me.ContactLink = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'FirstInputBox
        '
        Me.FirstInputBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FirstInputBox.Location = New System.Drawing.Point(12, 33)
        Me.FirstInputBox.Name = "FirstInputBox"
        Me.FirstInputBox.Size = New System.Drawing.Size(140, 38)
        Me.FirstInputBox.TabIndex = 0
        '
        'SecoundInputBox
        '
        Me.SecoundInputBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SecoundInputBox.Location = New System.Drawing.Point(198, 33)
        Me.SecoundInputBox.Name = "SecoundInputBox"
        Me.SecoundInputBox.Size = New System.Drawing.Size(144, 38)
        Me.SecoundInputBox.TabIndex = 1
        '
        'AnswerBox
        '
        Me.AnswerBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AnswerBox.Location = New System.Drawing.Point(8, 216)
        Me.AnswerBox.Name = "AnswerBox"
        Me.AnswerBox.Size = New System.Drawing.Size(344, 29)
        Me.AnswerBox.TabIndex = 2
        '
        'Addtition
        '
        Me.Addtition.Font = New System.Drawing.Font("Microsoft Sans Serif", 0.1!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Addtition.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Addtition.Image = CType(resources.GetObject("Addtition.Image"), System.Drawing.Image)
        Me.Addtition.Location = New System.Drawing.Point(198, 77)
        Me.Addtition.Name = "Addtition"
        Me.Addtition.Size = New System.Drawing.Size(60, 52)
        Me.Addtition.TabIndex = 3
        Me.Addtition.Text = "&a"
        Me.Addtition.UseVisualStyleBackColor = True
        '
        'Subtraction
        '
        Me.Subtraction.Font = New System.Drawing.Font("Microsoft Sans Serif", 0.1!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Subtraction.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Subtraction.Image = CType(resources.GetObject("Subtraction.Image"), System.Drawing.Image)
        Me.Subtraction.Location = New System.Drawing.Point(278, 77)
        Me.Subtraction.Name = "Subtraction"
        Me.Subtraction.Size = New System.Drawing.Size(60, 52)
        Me.Subtraction.TabIndex = 4
        Me.Subtraction.Text = "&s"
        Me.Subtraction.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Subtraction.UseVisualStyleBackColor = True
        '
        'Multiplication
        '
        Me.Multiplication.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Multiplication.Image = CType(resources.GetObject("Multiplication.Image"), System.Drawing.Image)
        Me.Multiplication.Location = New System.Drawing.Point(198, 137)
        Me.Multiplication.Name = "Multiplication"
        Me.Multiplication.Size = New System.Drawing.Size(60, 52)
        Me.Multiplication.TabIndex = 5
        Me.Multiplication.Text = "&m"
        Me.Multiplication.UseVisualStyleBackColor = True
        '
        'Division
        '
        Me.Division.Font = New System.Drawing.Font("Microsoft Sans Serif", 0.1!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Division.ForeColor = System.Drawing.SystemColors.Control
        Me.Division.Image = CType(resources.GetObject("Division.Image"), System.Drawing.Image)
        Me.Division.Location = New System.Drawing.Point(278, 137)
        Me.Division.Name = "Division"
        Me.Division.Size = New System.Drawing.Size(60, 52)
        Me.Division.TabIndex = 6
        Me.Division.Text = "&d"
        Me.Division.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(300, 427)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(53, 23)
        Me.ExitButton.TabIndex = 8
        Me.ExitButton.Text = "E&xit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'ClearAllButton
        '
        Me.ClearAllButton.Location = New System.Drawing.Point(12, 77)
        Me.ClearAllButton.Name = "ClearAllButton"
        Me.ClearAllButton.Size = New System.Drawing.Size(140, 24)
        Me.ClearAllButton.TabIndex = 9
        Me.ClearAllButton.Text = "&Clear All"
        Me.ClearAllButton.UseVisualStyleBackColor = True
        '
        'FirstParameterLabel
        '
        Me.FirstParameterLabel.AutoSize = True
        Me.FirstParameterLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FirstParameterLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.FirstParameterLabel.Location = New System.Drawing.Point(42, 9)
        Me.FirstParameterLabel.Name = "FirstParameterLabel"
        Me.FirstParameterLabel.Size = New System.Drawing.Size(85, 13)
        Me.FirstParameterLabel.TabIndex = 10
        Me.FirstParameterLabel.Text = "1st Parameter"
        '
        'SecoundParameterLabel
        '
        Me.SecoundParameterLabel.AutoSize = True
        Me.SecoundParameterLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SecoundParameterLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.SecoundParameterLabel.Location = New System.Drawing.Point(229, 9)
        Me.SecoundParameterLabel.Name = "SecoundParameterLabel"
        Me.SecoundParameterLabel.Size = New System.Drawing.Size(89, 13)
        Me.SecoundParameterLabel.TabIndex = 11
        Me.SecoundParameterLabel.Text = "2nd Parameter"
        '
        'CalculatorHistory
        '
        Me.CalculatorHistory.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CalculatorHistory.FormattingEnabled = True
        Me.CalculatorHistory.ItemHeight = 16
        Me.CalculatorHistory.Location = New System.Drawing.Point(8, 279)
        Me.CalculatorHistory.Name = "CalculatorHistory"
        Me.CalculatorHistory.Size = New System.Drawing.Size(344, 148)
        Me.CalculatorHistory.TabIndex = 12
        '
        'AnswerLabel
        '
        Me.AnswerLabel.AutoSize = True
        Me.AnswerLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AnswerLabel.ForeColor = System.Drawing.SystemColors.Control
        Me.AnswerLabel.Location = New System.Drawing.Point(151, 200)
        Me.AnswerLabel.Name = "AnswerLabel"
        Me.AnswerLabel.Size = New System.Drawing.Size(48, 13)
        Me.AnswerLabel.TabIndex = 13
        Me.AnswerLabel.Text = "Answer"
        '
        'HistoryLabel
        '
        Me.HistoryLabel.AutoSize = True
        Me.HistoryLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HistoryLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.HistoryLabel.Location = New System.Drawing.Point(151, 263)
        Me.HistoryLabel.Name = "HistoryLabel"
        Me.HistoryLabel.Size = New System.Drawing.Size(46, 13)
        Me.HistoryLabel.TabIndex = 14
        Me.HistoryLabel.Text = "History"
        '
        'LegendLabel
        '
        Me.LegendLabel.AutoSize = True
        Me.LegendLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LegendLabel.Location = New System.Drawing.Point(12, 111)
        Me.LegendLabel.Name = "LegendLabel"
        Me.LegendLabel.Size = New System.Drawing.Size(61, 91)
        Me.LegendLabel.TabIndex = 15
        Me.LegendLabel.Text = "Hotkeys:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Add - a" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Subtract - s" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Multiply - m" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Divide - d" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Clear All - c" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Exit - " &
    "x" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'ContactLink
        '
        Me.ContactLink.AutoSize = True
        Me.ContactLink.Location = New System.Drawing.Point(10, 432)
        Me.ContactLink.Name = "ContactLink"
        Me.ContactLink.Size = New System.Drawing.Size(145, 13)
        Me.ContactLink.TabIndex = 16
        Me.ContactLink.Text = "Created by: www.sandyle.net"
        '
        'Calculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.ClientSize = New System.Drawing.Size(359, 451)
        Me.Controls.Add(Me.ContactLink)
        Me.Controls.Add(Me.LegendLabel)
        Me.Controls.Add(Me.HistoryLabel)
        Me.Controls.Add(Me.AnswerLabel)
        Me.Controls.Add(Me.CalculatorHistory)
        Me.Controls.Add(Me.SecoundParameterLabel)
        Me.Controls.Add(Me.FirstParameterLabel)
        Me.Controls.Add(Me.ClearAllButton)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.Division)
        Me.Controls.Add(Me.Multiplication)
        Me.Controls.Add(Me.Subtraction)
        Me.Controls.Add(Me.Addtition)
        Me.Controls.Add(Me.AnswerBox)
        Me.Controls.Add(Me.SecoundInputBox)
        Me.Controls.Add(Me.FirstInputBox)
        Me.Name = "Calculator"
        Me.Text = "Basic Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FirstInputBox As TextBox
    Friend WithEvents SecoundInputBox As TextBox
    Friend WithEvents AnswerBox As TextBox
    Friend WithEvents Addtition As Button
    Friend WithEvents Subtraction As Button
    Friend WithEvents Multiplication As Button
    Friend WithEvents Division As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents ClearAllButton As Button
    Friend WithEvents FirstParameterLabel As Label
    Friend WithEvents SecoundParameterLabel As Label
    Friend WithEvents CalculatorHistory As ListBox
    Friend WithEvents AnswerLabel As Label
    Friend WithEvents HistoryLabel As Label
    Friend WithEvents LegendLabel As Label
    Friend WithEvents ContactLink As Label
End Class
