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
        Label1 = New Label()
        TextBox1 = New TextBox()
        btnAdd = New Button()
        ListBox = New ListBox()
        Label = New TextBox()
        GroupBox1 = New GroupBox()
        RdToLower = New RadioButton()
        RdToUpper = New RadioButton()
        GroupBox2 = New GroupBox()
        RdBlue = New RadioButton()
        RdPurple = New RadioButton()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(155, 18)
        Label1.Name = "Label1"
        Label1.Size = New Size(73, 15)
        Label1.TabIndex = 0
        Label1.Text = "Enter a word"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(155, 36)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(209, 23)
        TextBox1.TabIndex = 1
        ' 
        ' btnAdd
        ' 
        btnAdd.Location = New Point(155, 65)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(75, 23)
        btnAdd.TabIndex = 2
        btnAdd.Text = "Add"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' ListBox
        ' 
        ListBox.FormattingEnabled = True
        ListBox.ItemHeight = 15
        ListBox.Location = New Point(155, 104)
        ListBox.Name = "ListBox"
        ListBox.Size = New Size(237, 94)
        ListBox.TabIndex = 3
        ' 
        ' Label
        ' 
        Label.Location = New Point(0, 216)
        Label.Name = "Label"
        Label.Size = New Size(800, 23)
        Label.TabIndex = 4
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(RdToLower)
        GroupBox1.Controls.Add(RdToUpper)
        GroupBox1.Location = New Point(138, 254)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(200, 100)
        GroupBox1.TabIndex = 5
        GroupBox1.TabStop = False
        GroupBox1.Text = "Case"
        ' 
        ' RdToLower
        ' 
        RdToLower.AutoSize = True
        RdToLower.Location = New Point(6, 56)
        RdToLower.Name = "RdToLower"
        RdToLower.Size = New Size(72, 19)
        RdToLower.TabIndex = 1
        RdToLower.TabStop = True
        RdToLower.Text = "To Lower"
        RdToLower.UseVisualStyleBackColor = True
        ' 
        ' RdToUpper
        ' 
        RdToUpper.AutoSize = True
        RdToUpper.Location = New Point(6, 31)
        RdToUpper.Name = "RdToUpper"
        RdToUpper.Size = New Size(72, 19)
        RdToUpper.TabIndex = 0
        RdToUpper.TabStop = True
        RdToUpper.Text = "To Upper"
        RdToUpper.UseVisualStyleBackColor = True
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(RdBlue)
        GroupBox2.Controls.Add(RdPurple)
        GroupBox2.Location = New Point(378, 254)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(200, 100)
        GroupBox2.TabIndex = 6
        GroupBox2.TabStop = False
        GroupBox2.Text = "Colour"
        ' 
        ' RdBlue
        ' 
        RdBlue.AutoSize = True
        RdBlue.Location = New Point(6, 56)
        RdBlue.Name = "RdBlue"
        RdBlue.Size = New Size(48, 19)
        RdBlue.TabIndex = 1
        RdBlue.TabStop = True
        RdBlue.Text = "Blue"
        RdBlue.UseVisualStyleBackColor = True
        ' 
        ' RdPurple
        ' 
        RdPurple.AutoSize = True
        RdPurple.Location = New Point(6, 22)
        RdPurple.Name = "RdPurple"
        RdPurple.Size = New Size(59, 19)
        RdPurple.TabIndex = 0
        RdPurple.TabStop = True
        RdPurple.Text = "Purple"
        RdPurple.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(Label)
        Controls.Add(ListBox)
        Controls.Add(btnAdd)
        Controls.Add(TextBox1)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents ListBox As ListBox
    Friend WithEvents Label As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RdToLower As RadioButton
    Friend WithEvents RdToUpper As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents RdBlue As RadioButton
    Friend WithEvents RdPurple As RadioButton
End Class
