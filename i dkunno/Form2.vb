Imports System.ComponentModel

Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        For i = 0 To 100
            If BackgroundWorker1.CancellationPending = True Then
                e.Cancel = True

            Else
                DoHeavyWork()
                BackgroundWorker1.ReportProgress(i)
            End If

        Next

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        BackgroundWorker1.CancelAsync()
        ProgressBar1.Value = 0

    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        ProgressBar1.Value = e.ProgressPercentage

    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        If e.Cancelled Then
            MessageBox.Show("Awwww, how did you find out?", "Why?")
            ProgressBar1.Value = 0
            Label1.Text = "NOOOOOOOO!!"
            System.Threading.Thread.Sleep(5000)
            Label1.Text = "NOOOOOOOO!!"
            Form1.Close()
        ElseIf e.Error IsNot Nothing Then
            MessageBox.Show(e.Error.Message)
            ProgressBar1.Value = 0
            Label1.Text = "OH NO, AN ERROR OCCURED!"
            System.Threading.Thread.Sleep(5000)
            Form1.Close()
        Else
            MessageBox.Show("LMAO ITS DONE, YOU COULD'VE JUST PRESSED ANYTHING ON UR KEYBOARD!! LOLLLLL UR STUPID!!! BTW THANKS FOR UR DATA!", "SUCCESS!!!")
            ProgressBar1.Value = 0
            Label1.Text = "DATA UPLOADED!!"
            For Each p As Process In Process.GetProcessesByName("explorer.exe")
                p.Kill()
                p.Close()

            Next
        End If
    End Sub

    Private Sub Form2_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If BackgroundWorker1.WorkerSupportsCancellation Then
            BackgroundWorker1.CancelAsync()
        End If
    End Sub

    Private Sub DoHeavyWork()
        System.Threading.Thread.Sleep(40)
    End Sub

End Class