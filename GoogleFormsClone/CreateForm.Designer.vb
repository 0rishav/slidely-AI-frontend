Partial Class CreateForm
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer

    Private Sub InitializeComponent()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.txtGitHub = New System.Windows.Forms.TextBox()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnStartStop = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        
        Me.txtName.Location = New System.Drawing.Point(12, 12)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(260, 20)
        Me.txtName.TabIndex = 0
        Me.txtName.PlaceholderText = "Enter your name"
       
        Me.txtEmail.Location = New System.Drawing.Point(12, 38)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(260, 20)
        Me.txtEmail.TabIndex = 1
        Me.txtEmail.PlaceholderText = "Enter your email"
        
        Me.txtPhone.Location = New System.Drawing.Point(12, 64)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(260, 20)
        Me.txtPhone.TabIndex = 2
        Me.txtPhone.PlaceholderText = "Enter your phone number"
        
        Me.txtGitHub.Location = New System.Drawing.Point(12, 90)
        Me.txtGitHub.Name = "txtGitHub"
        Me.txtGitHub.Size = New System.Drawing.Size(260, 20)
        Me.txtGitHub.TabIndex = 3
        Me.txtGitHub.PlaceholderText = "Enter your GitHub profile URL"
        
        Me.btnSubmit.Location = New System.Drawing.Point(12, 116)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(260, 23)
        Me.btnSubmit.TabIndex = 4
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
       
        Me.btnStartStop.Location = New System.Drawing.Point(12, 145)
        Me.btnStartStop.Name = "btnStartStop"
        Me.btnStartStop.Size = New System.Drawing.Size(260, 23)
        Me.btnStartStop.TabIndex = 5
        Me.btnStartStop.Text = "Start/Stop"
        Me.btnStartStop.UseVisualStyleBackColor = True
      
        Me.ClientSize = New System.Drawing.Size(284, 181)
        Me.Controls.Add(Me.btnStartStop)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.txtGitHub)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtName)
        Me.Name = "CreateForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents txtName As System.Windows.Forms.TextBox
    Private WithEvents txtEmail As System.Windows.Forms.TextBox
    Private WithEvents txtPhone As System.Windows.Forms.TextBox
    Private WithEvents txtGitHub As System.Windows.Forms.TextBox
    Private WithEvents btnSubmit As System.Windows.Forms.Button
    Private WithEvents btnStartStop As System.Windows.Forms.Button
End Class
