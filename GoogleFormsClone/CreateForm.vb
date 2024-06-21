Imports System.Net.Http
Imports System.Text
Imports Newtonsoft.Json

Public Class CreateForm
    Private stopwatch As New Stopwatch()
    Private client As New HttpClient()

    Public Sub New()
        InitializeComponent()

        SetPlaceholders()
    End Sub

    Private Sub SetPlaceholders()
        SetPlaceholder(txtName, "Enter your name")
        SetPlaceholder(txtEmail, "Enter your email")
        SetPlaceholder(txtPhone, "Enter your phone number")
        SetPlaceholder(txtGitHub, "Enter your GitHub profile URL")
    End Sub

    Private Sub SetPlaceholder(textBox As TextBox, placeholder As String)
        textBox.Text = placeholder
        textBox.ForeColor = Color.Gray

        AddHandler textBox.Enter, Sub(sender, e)
                                      If textBox.Text = placeholder Then
                                          textBox.Text = ""
                                          textBox.ForeColor = Color.Black
                                      End If
                                  End Sub

        AddHandler textBox.Leave, Sub(sender, e)
                                      If String.IsNullOrWhiteSpace(textBox.Text) Then
                                          textBox.Text = placeholder
                                          textBox.ForeColor = Color.Gray
                                      End If
                                  End Sub
    End Sub

    Private Async Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim formData As New Dictionary(Of String, String) From {
            {"name", txtName.Text},
            {"email", txtEmail.Text},
            {"phone", txtPhone.Text},
            {"github", txtGitHub.Text}
        }

        Dim json As String = JsonConvert.SerializeObject(formData)
        Dim content As New StringContent(json, Encoding.UTF8, "application/json")

        Dim response As HttpResponseMessage = Await client.PostAsync("http://localhost:3000/forms", content)
        If response.IsSuccessStatusCode Then
            MessageBox.Show("Submission successful!")
        Else
            MessageBox.Show("Error in submission.")
        End If
    End Sub

    Private Sub btnStartStop_Click(sender As Object, e As EventArgs) Handles btnStartStop.Click
        If stopwatch.IsRunning Then
            stopwatch.Stop()
            btnStartStop.Text = "Resume"
        Else
            stopwatch.Start()
            btnStartStop.Text = "Pause"
        End If
    End Sub
End Class
