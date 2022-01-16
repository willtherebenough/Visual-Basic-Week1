<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.exitButton = New System.Windows.Forms.Button()
        Me.clearButton = New System.Windows.Forms.Button()
        Me.calculateButton = New System.Windows.Forms.Button()
        Me.amountDueTextBox = New System.Windows.Forms.TextBox()
        Me.amountDueLabel = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.hoursTextBox = New System.Windows.Forms.TextBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.firstNameTextBox = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.lastNameTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(480, 130)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(78, 29)
        Me.exitButton.TabIndex = 39
        Me.exitButton.Text = "Exit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'clearButton
        '
        Me.clearButton.Location = New System.Drawing.Point(480, 95)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Size = New System.Drawing.Size(78, 29)
        Me.clearButton.TabIndex = 38
        Me.clearButton.Text = "Clear"
        Me.clearButton.UseVisualStyleBackColor = True
        '
        'calculateButton
        '
        Me.calculateButton.Location = New System.Drawing.Point(480, 60)
        Me.calculateButton.Name = "calculateButton"
        Me.calculateButton.Size = New System.Drawing.Size(78, 29)
        Me.calculateButton.TabIndex = 37
        Me.calculateButton.Text = "Calculate"
        Me.calculateButton.UseVisualStyleBackColor = True
        '
        'amountDueTextBox
        '
        Me.amountDueTextBox.Location = New System.Drawing.Point(306, 144)
        Me.amountDueTextBox.Name = "amountDueTextBox"
        Me.amountDueTextBox.Size = New System.Drawing.Size(33, 20)
        Me.amountDueTextBox.TabIndex = 36
        '
        'amountDueLabel
        '
        Me.amountDueLabel.AutoSize = True
        Me.amountDueLabel.BackColor = System.Drawing.Color.White
        Me.amountDueLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.amountDueLabel.Location = New System.Drawing.Point(233, 151)
        Me.amountDueLabel.Name = "amountDueLabel"
        Me.amountDueLabel.Size = New System.Drawing.Size(68, 15)
        Me.amountDueLabel.TabIndex = 35
        Me.amountDueLabel.Text = "Amount Due"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(213, 118)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(87, 13)
        Me.label4.TabIndex = 34
        Me.label4.Text = "Number of Hours"
        '
        'hoursTextBox
        '
        Me.hoursTextBox.Location = New System.Drawing.Point(306, 115)
        Me.hoursTextBox.Name = "hoursTextBox"
        Me.hoursTextBox.Size = New System.Drawing.Size(33, 20)
        Me.hoursTextBox.TabIndex = 33
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(242, 88)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(57, 13)
        Me.label3.TabIndex = 32
        Me.label3.Text = "First Name"
        '
        'firstNameTextBox
        '
        Me.firstNameTextBox.Location = New System.Drawing.Point(306, 85)
        Me.firstNameTextBox.Name = "firstNameTextBox"
        Me.firstNameTextBox.Size = New System.Drawing.Size(139, 20)
        Me.firstNameTextBox.TabIndex = 31
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(242, 60)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(58, 13)
        Me.label2.TabIndex = 30
        Me.label2.Text = "Last Name"
        '
        'lastNameTextBox
        '
        Me.lastNameTextBox.Location = New System.Drawing.Point(306, 57)
        Me.lastNameTextBox.Name = "lastNameTextBox"
        Me.lastNameTextBox.Size = New System.Drawing.Size(139, 20)
        Me.lastNameTextBox.TabIndex = 29
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(239, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(288, 31)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Cyberian Internet Cafe"
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(174, 174)
        Me.PictureBox1.TabIndex = 27
        Me.PictureBox1.TabStop = False
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(642, 198)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.clearButton)
        Me.Controls.Add(Me.calculateButton)
        Me.Controls.Add(Me.amountDueTextBox)
        Me.Controls.Add(Me.amountDueLabel)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.hoursTextBox)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.firstNameTextBox)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.lastNameTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cyberian Internet Cafe"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents exitButton As Button
    Private WithEvents clearButton As Button
    Private WithEvents calculateButton As Button
    Private WithEvents amountDueTextBox As TextBox
    Private WithEvents amountDueLabel As Label
    Private WithEvents label4 As Label
    Private WithEvents hoursTextBox As TextBox
    Private WithEvents label3 As Label
    Private WithEvents firstNameTextBox As TextBox
    Private WithEvents label2 As Label
    Private WithEvents lastNameTextBox As TextBox
    Private WithEvents Label1 As Label
    Private WithEvents PictureBox1 As PictureBox
End Class
