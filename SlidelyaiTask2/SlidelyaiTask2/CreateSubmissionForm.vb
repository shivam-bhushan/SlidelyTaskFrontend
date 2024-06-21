Imports System.Net.Http
Imports System.Text
Imports Newtonsoft.Json

Public Class CreateSubmissionForm
    Private stopwatch As New Stopwatch()

    Private Async Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click
        ' Collect form data
        Dim name As String = NameField.Text
        Dim email As String = EmailField.Text
        Dim phone As String = PhoneNumberField.Text
        Dim gitHubLink As String = GithubLinkField.Text
        Dim stopwatchTime As String = stopwatch.Elapsed.ToString()

        ' Create a new submission object
        Dim submission As New Dictionary(Of String, String) From {
            {"name", name},
            {"email", email},
            {"phone", phone},
            {"github_link", gitHubLink},
            {"stopwatch_time", stopwatchTime}
        }

        ' Convert the submission object to JSON
        Dim json As String = JsonConvert.SerializeObject(submission)
        Dim content As New StringContent(json, Encoding.UTF8, "application/json")

        ' Send the POST request to the backend
        Using client As New HttpClient()
            Dim response As HttpResponseMessage = Await client.PostAsync("http://localhost:3000/submit", content)
            If response.IsSuccessStatusCode Then
                MessageBox.Show("Submission successful!")
            Else
                MessageBox.Show("Submission failed: " & response.ReasonPhrase)
            End If
        End Using
    End Sub



    ' Other event handlers can stay the same
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles NameField.TextChanged
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles EmailField.TextChanged
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles PhoneNumberField.TextChanged
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles GithubLinkField.TextChanged
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles StopwatchField.TextChanged
    End Sub


End Class
