Imports System.Reflection.Emit
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar

Public Class Form1
    Dim names(19) As String
    Dim incomes(19) As Double
    Dim taxes(19) As Double
    Dim netIncomes(19) As Double
    Dim index As Integer = 0
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EmployeeDetailsTextBox.Visible = False
        Goback.Visible = False
    End Sub
    Private Sub CalculateButton_Click(sender As Object, e As EventArgs) Handles CalculateButton.Click
        Dim name As String = NameTextBox.Text
        Dim grossIncome As Double
        Dim tax As Double

        If index >= 20 Then
            MessageBox.Show("You have reached the maximum number of employees.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        ElseIf String.IsNullOrEmpty(NameTextBox.Text) Then
            MessageBox.Show("Please enter a valid name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        ElseIf Not Double.TryParse(GrossIncomeTextBox.Text, grossIncome) Then
            MessageBox.Show("Please enter a valid gross income.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If grossIncome <= 18200 Then
            tax = 0
        ElseIf grossIncome <= 45000 Then
            tax = (grossIncome - 18200) * 0.19
        ElseIf grossIncome <= 120000 Then
            tax = 5092 + (grossIncome - 45000) * 0.325
        ElseIf grossIncome <= 180000 Then
            tax = 29467 + (grossIncome - 120000) * 0.37
        Else
            tax = 51667 + (grossIncome - 180000) * 0.45
        End If

        Dim netIncome As Double = grossIncome - tax

        names(index) = name
        incomes(index) = grossIncome
        taxes(index) = tax
        netIncomes(index) = netIncome
        index += 1

        NameTextBox.Clear()
        GrossIncomeTextBox.Clear()

        MessageBox.Show($"Employee details calculated and stored. {vbCrLf}{vbCrLf}Name: {name} {vbCrLf}Income: ${grossIncome:N2} {vbCrLf}Tax: ${tax:N2} {vbCrLf}Net Income: ${netIncome:N2}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Sub DisplayButton_Click(sender As Object, e As EventArgs) Handles DisplayButton.Click
        If index = 0 Then
            MessageBox.Show("You must input Employee Details first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim output As String = "Employee Tax Information:" & vbCrLf & vbCrLf

            For i As Integer = 0 To index - 1
                output += $"Employee #{i + 1}:" & vbCrLf
                output += $"Name: {names(i)}" & vbCrLf
                output += $"Income: ${incomes(i)}" & vbCrLf
                output += $"Tax: ${taxes(i):N2}" & vbCrLf
                output += $"Net Income: ${netIncomes(i):N2}" & vbCrLf & vbCrLf
            Next

            NameTextBox.Visible = False
            GrossIncomeTextBox.Visible = False
            NameTextBoxLabel.Visible = False
            GrossIncomeTextBoxLabel.Visible = False
            DisplayButton.Visible = False
            Goback.Visible = True
            EmployeeDetailsTextBox.Visible = True
            EmployeeDetailsTextBox.Text = output
        End If
    End Sub
    Private Sub Goback_Click(sender As Object, e As EventArgs) Handles Goback.Click
        Goback.Visible = False
        EmployeeDetailsTextBox.Visible = False
        NameTextBox.Visible = True
        GrossIncomeTextBox.Visible = True
        NameTextBoxLabel.Visible = True
        GrossIncomeTextBoxLabel.Visible = True
        DisplayButton.Visible = True
    End Sub
    Private Sub Resetall_Click(sender As Object, e As EventArgs) Handles Resetall.Click
        Array.Clear(names, 0, names.Length)
        Array.Clear(incomes, 0, incomes.Length)
        Array.Clear(taxes, 0, taxes.Length)
        Array.Clear(netIncomes, 0, netIncomes.Length)

        index = 0

        NameTextBox.Clear()
        GrossIncomeTextBox.Clear()
        EmployeeDetailsTextBox.Clear()

        MessageBox.Show("All data has been reset.", "Reset", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class



