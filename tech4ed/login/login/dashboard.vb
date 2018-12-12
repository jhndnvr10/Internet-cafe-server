Public Class dashboard

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim ans As MsgBoxResult
        ans = MsgBox("Do you really want to Exit??", vbYesNo, "Exit")
        If ans = MsgBoxResult.Yes Then
            End
        ElseIf ans = MsgBoxResult.No Then
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

  

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim ans As MsgBoxResult
        ans = MsgBox("Do you really want to Log out??", vbYesNo, "Log out")
        If ans = MsgBoxResult.Yes Then

            Form1.Show()
            Me.Close()
        ElseIf ans = MsgBoxResult.No Then
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        DateTimePicker1.Value = Now
        DateTimePicker2.Value = Now
    End Sub
End Class