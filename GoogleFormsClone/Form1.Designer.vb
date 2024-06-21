Partial Class Form1
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer

    Private Sub InitializeComponent()
        Me.btnCreateSubmission = New System.Windows.Forms.Button()
        Me.btnViewSubmissions = New System.Windows.Forms.Button()
        Me.SuspendLayout()
       
        Me.btnCreateSubmission.Location = New System.Drawing.Point(12, 12)
        Me.btnCreateSubmission.Name = "btnCreateSubmission"
        Me.btnCreateSubmission.Size = New System.Drawing.Size(260, 23)
        Me.btnCreateSubmission.TabIndex = 0
        Me.btnCreateSubmission.Text = "Create New Submission"
        Me.btnCreateSubmission.UseVisualStyleBackColor = True
        
        Me.btnViewSubmissions.Location = New System.Drawing.Point(12, 41)
        Me.btnViewSubmissions.Name = "btnViewSubmissions"
        Me.btnViewSubmissions.Size = New System.Drawing.Size(260, 23)
        Me.btnViewSubmissions.TabIndex = 1
        Me.btnViewSubmissions.Text = "View Submissions"
        Me.btnViewSubmissions.UseVisualStyleBackColor = True
        
        Me.ClientSize = New System.Drawing.Size(284, 76)
        Me.Controls.Add(Me.btnViewSubmissions)
        Me.Controls.Add(Me.btnCreateSubmission)
        Me.Name = "Form1"
        Me.ResumeLayout(False)
    End Sub

    Private WithEvents btnCreateSubmission As System.Windows.Forms.Button
    Private WithEvents btnViewSubmissions As System.Windows.Forms.Button
End Class
