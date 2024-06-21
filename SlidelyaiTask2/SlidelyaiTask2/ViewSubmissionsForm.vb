Imports System.Net
Imports System.Net.Http
Imports System.Threading.Tasks
Imports Newtonsoft.Json

Public Class ViewSubmissionsForm

    Private Submissions As List(Of Submission)
    Private CurrentIndex As Integer = 0
    Private ReadOnly client As New HttpClient()

    Private Async Sub ViewSubmissionsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Await LoadSubmissions()
        If Submissions IsNot Nothing AndAlso Submissions.Count > 0 Then
            DisplaySubmission(CurrentIndex)
        Else
            MessageBox.Show("No submissions found or failed to load submissions.")
        End If
    End Sub

    Private Async Function LoadSubmissions() As Task
        Try
            ' Load all submissions at once
            Submissions = New List(Of Submission)()
            Dim index As Integer = 0
            Dim continueLoading As Boolean = True

            While continueLoading
                Dim response As HttpResponseMessage = Await client.GetAsync($"http://localhost:3000/read?index={index}")
                If response.StatusCode = HttpStatusCode.NotFound Then
                    ' Stop loading if no more submissions
                    continueLoading = False
                ElseIf response.IsSuccessStatusCode Then
                    Dim jsonResponse As String = Await response.Content.ReadAsStringAsync()
                    Console.WriteLine($"Received JSON for index {index}: {jsonResponse}") ' Log the raw JSON response
                    Dim submission As Submission = JsonConvert.DeserializeObject(Of Submission)(jsonResponse)
                    If submission IsNot Nothing Then
                        Submissions.Add(submission)
                    End If
                Else
                    MessageBox.Show("Error loading submissions: " & response.ReasonPhrase)
                    Exit While
                End If
                index += 1
            End While

            If Submissions.Count = 0 Then
                MessageBox.Show("No submissions found.")
            End If
        Catch ex As Exception
            MessageBox.Show("Error fetching submissions: " & ex.Message)
        End Try
    End Function

    Private Sub DisplaySubmission(index As Integer)
        If Submissions IsNot Nothing AndAlso index >= 0 AndAlso index < Submissions.Count Then
            Dim submission As Submission = Submissions(index)
            NameTextBox.Text = submission.Name
            EmailTextBox.Text = submission.Email
            PhoneNumTextBox.Text = submission.Phone
            GithubLinkTextBox.Text = submission.GitHub_Link
            StopwatchTextBox.Text = submission.Stopwatch_Time

            ' Debugging
            Console.WriteLine($"Displaying submission at index {index}:")
            Console.WriteLine($"Name: {submission.Name}")
            Console.WriteLine($"Email: {submission.Email}")
            Console.WriteLine($"Phone: {submission.Phone}")
            Console.WriteLine($"GitHub Link: {submission.GitHub_Link}")
            Console.WriteLine($"Stopwatch Time: {submission.Stopwatch_Time}")
        Else
            MessageBox.Show("No submissions to display.")
        End If
    End Sub

    Private Sub PreviousButton_Click(sender As Object, e As EventArgs) Handles PreviousButton.Click
        If CurrentIndex > 0 Then
            CurrentIndex -= 1
            DisplaySubmission(CurrentIndex)
        End If
    End Sub

    Private Sub NextButton_Click(sender As Object, e As EventArgs) Handles NextButton.Click
        If Submissions IsNot Nothing AndAlso CurrentIndex < Submissions.Count - 1 Then
            CurrentIndex += 1
            DisplaySubmission(CurrentIndex)
        End If
    End Sub

    ' Other event handlers can stay the same
    Private Sub TextBox1_TextChanged_1(sender As Object, e As EventArgs) Handles NameTextBox.TextChanged
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles EmailTextBox.TextChanged
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles PhoneNumTextBox.TextChanged
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles GithubLinkTextBox.TextChanged
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles StopwatchTextBox.TextChanged
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles NameLable.Click
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles EmailLable.Click
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles PhoneNumLabel.Click
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles GithubLinkLabel.Click
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles StopwatchLabel.Click
    End Sub

End Class

Public Class Submission
    Public Property Name As String
    Public Property Email As String
    Public Property Phone As String
    Public Property GitHub_Link As String ' Ensure this matches the JSON key
    Public Property Stopwatch_Time As String ' Ensure this matches the JSON key
End Class
