Imports System.Net.Http
Imports Newtonsoft.Json

Public Class ViewForm
    Private submissions As List(Of FormSubmission)
    Private currentIndex As Integer = 0

    Private Async Sub ViewForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim client As New HttpClient()
            Dim response As HttpResponseMessage = Await client.GetAsync("http://localhost:3000/forms")

            If response.IsSuccessStatusCode Then
                Dim json As String = Await response.Content.ReadAsStringAsync()
                submissions = JsonConvert.DeserializeObject(Of List(Of FormSubmission))(json)

                If submissions IsNot Nothing AndAlso submissions.Count > 0 Then
                    DisplaySubmission()
                Else
                    MessageBox.Show("No submissions found.")
                End If
            Else
                MessageBox.Show("Error retrieving submissions")
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub DisplaySubmission()
        If submissions IsNot Nothing AndAlso submissions.Count > 0 AndAlso currentIndex < submissions.Count Then
            Dim submission As FormSubmission = submissions(currentIndex)

            If submission IsNot Nothing Then
                txtName.Text = submission.name
                txtEmail.Text = submission.email
                txtPhone.Text = submission.phone
                txtGithub.Text = submission.github
                lblStopwatch.Text = "Time Spent: " & submission.timeSpent
            Else
                ClearFields()
                MessageBox.Show("Submission data is null.")
            End If
        Else
            ClearFields()
            MessageBox.Show("No submissions to display.")
        End If
    End Sub

    Private Sub ClearFields()
        txtName.Clear()
        txtEmail.Clear()
        txtPhone.Clear()
        txtGithub.Clear()
        lblStopwatch.Text = "Time Spent: N/A"
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If submissions IsNot Nothing AndAlso currentIndex < submissions.Count - 1 Then
            currentIndex += 1
            DisplaySubmission()
        End If
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If submissions IsNot Nothing AndAlso currentIndex > 0 Then
            currentIndex -= 1
            DisplaySubmission()
        End If
    End Sub
End Class

Public Class FormSubmission
    Public Property name As String
    Public Property email As String
    Public Property phone As String
    Public Property github As String
    Public Property timeSpent As String
End Class
