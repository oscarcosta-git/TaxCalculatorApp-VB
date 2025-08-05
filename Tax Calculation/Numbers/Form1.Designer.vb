<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label4 = New System.Windows.Forms.Label()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.GrossIncomeTextBox = New System.Windows.Forms.TextBox()
        Me.GrossIncomeTextBoxLabel = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.NameTextBoxLabel = New System.Windows.Forms.Label()
        Me.DisplayButton = New System.Windows.Forms.Button()
        Me.CalculateButton = New System.Windows.Forms.Button()
        Me.EmployeeDetailsTextBox = New System.Windows.Forms.TextBox()
        Me.Goback = New System.Windows.Forms.Button()
        Me.Resetall = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(157, 73)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 13)
        Me.Label4.TabIndex = 12
        '
        'NameTextBox
        '
        Me.NameTextBox.BackColor = System.Drawing.SystemColors.Control
        Me.NameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NameTextBox.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 18.0!)
        Me.NameTextBox.ForeColor = System.Drawing.SystemColors.ControlText
        Me.NameTextBox.Location = New System.Drawing.Point(192, 93)
        Me.NameTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(190, 35)
        Me.NameTextBox.TabIndex = 18
        '
        'GrossIncomeTextBox
        '
        Me.GrossIncomeTextBox.BackColor = System.Drawing.SystemColors.Control
        Me.GrossIncomeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.GrossIncomeTextBox.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 18.0!)
        Me.GrossIncomeTextBox.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GrossIncomeTextBox.Location = New System.Drawing.Point(192, 182)
        Me.GrossIncomeTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.GrossIncomeTextBox.Name = "GrossIncomeTextBox"
        Me.GrossIncomeTextBox.Size = New System.Drawing.Size(190, 35)
        Me.GrossIncomeTextBox.TabIndex = 19
        '
        'GrossIncomeTextBoxLabel
        '
        Me.GrossIncomeTextBoxLabel.AutoSize = True
        Me.GrossIncomeTextBoxLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GrossIncomeTextBoxLabel.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 18.0!)
        Me.GrossIncomeTextBoxLabel.Location = New System.Drawing.Point(196, 150)
        Me.GrossIncomeTextBoxLabel.Name = "GrossIncomeTextBoxLabel"
        Me.GrossIncomeTextBoxLabel.Size = New System.Drawing.Size(183, 30)
        Me.GrossIncomeTextBoxLabel.TabIndex = 20
        Me.GrossIncomeTextBoxLabel.Text = "Input Gross Income"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Location = New System.Drawing.Point(-2, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(592, 33)
        Me.Panel2.TabIndex = 21
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 8)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(376, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Tax Calculation - Oscar Costa - YR11 - Task 2"
        '
        'NameTextBoxLabel
        '
        Me.NameTextBoxLabel.AutoSize = True
        Me.NameTextBoxLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.NameTextBoxLabel.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 18.0!)
        Me.NameTextBoxLabel.Location = New System.Drawing.Point(186, 61)
        Me.NameTextBoxLabel.Name = "NameTextBoxLabel"
        Me.NameTextBoxLabel.Size = New System.Drawing.Size(205, 30)
        Me.NameTextBoxLabel.TabIndex = 22
        Me.NameTextBoxLabel.Text = "Input Employee Name"
        '
        'DisplayButton
        '
        Me.DisplayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DisplayButton.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DisplayButton.Location = New System.Drawing.Point(160, 296)
        Me.DisplayButton.Margin = New System.Windows.Forms.Padding(2)
        Me.DisplayButton.Name = "DisplayButton"
        Me.DisplayButton.Size = New System.Drawing.Size(253, 41)
        Me.DisplayButton.TabIndex = 23
        Me.DisplayButton.Text = "Display Employee List"
        Me.DisplayButton.UseVisualStyleBackColor = True
        '
        'CalculateButton
        '
        Me.CalculateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CalculateButton.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CalculateButton.Location = New System.Drawing.Point(160, 251)
        Me.CalculateButton.Margin = New System.Windows.Forms.Padding(2)
        Me.CalculateButton.Name = "CalculateButton"
        Me.CalculateButton.Size = New System.Drawing.Size(253, 41)
        Me.CalculateButton.TabIndex = 24
        Me.CalculateButton.Text = "Input Employee"
        Me.CalculateButton.UseVisualStyleBackColor = True
        '
        'EmployeeDetailsTextBox
        '
        Me.EmployeeDetailsTextBox.BackColor = System.Drawing.SystemColors.Control
        Me.EmployeeDetailsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.EmployeeDetailsTextBox.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmployeeDetailsTextBox.ForeColor = System.Drawing.SystemColors.ControlText
        Me.EmployeeDetailsTextBox.Location = New System.Drawing.Point(11, 37)
        Me.EmployeeDetailsTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.EmployeeDetailsTextBox.Multiline = True
        Me.EmployeeDetailsTextBox.Name = "EmployeeDetailsTextBox"
        Me.EmployeeDetailsTextBox.ReadOnly = True
        Me.EmployeeDetailsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.EmployeeDetailsTextBox.Size = New System.Drawing.Size(550, 204)
        Me.EmployeeDetailsTextBox.TabIndex = 25
        Me.EmployeeDetailsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Goback
        '
        Me.Goback.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Goback.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Goback.Location = New System.Drawing.Point(160, 296)
        Me.Goback.Margin = New System.Windows.Forms.Padding(2)
        Me.Goback.Name = "Goback"
        Me.Goback.Size = New System.Drawing.Size(253, 41)
        Me.Goback.TabIndex = 26
        Me.Goback.Text = "Go Back"
        Me.Goback.UseVisualStyleBackColor = True
        '
        'Resetall
        '
        Me.Resetall.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Resetall.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Resetall.Location = New System.Drawing.Point(160, 342)
        Me.Resetall.Margin = New System.Windows.Forms.Padding(2)
        Me.Resetall.Name = "Resetall"
        Me.Resetall.Size = New System.Drawing.Size(253, 41)
        Me.Resetall.TabIndex = 27
        Me.Resetall.Text = "Reset All"
        Me.Resetall.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(572, 396)
        Me.Controls.Add(Me.Resetall)
        Me.Controls.Add(Me.CalculateButton)
        Me.Controls.Add(Me.NameTextBoxLabel)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.GrossIncomeTextBoxLabel)
        Me.Controls.Add(Me.GrossIncomeTextBox)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.EmployeeDetailsTextBox)
        Me.Controls.Add(Me.DisplayButton)
        Me.Controls.Add(Me.Goback)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tax"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents GrossIncomeTextBox As TextBox
    Friend WithEvents GrossIncomeTextBoxLabel As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents NameTextBoxLabel As Label
    Friend WithEvents DisplayButton As Button
    Friend WithEvents CalculateButton As Button
    Friend WithEvents EmployeeDetailsTextBox As TextBox
    Friend WithEvents Goback As Button
    Friend WithEvents Resetall As Button
End Class
