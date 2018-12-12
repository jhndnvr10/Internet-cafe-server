Imports MySql.Data.MySqlClient
Public Class Form1
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    'Dim Query As String
    'Dim publictable As New DataTable
    'Dim cmd As New MySqlCommand
    'Dim da As New MySqlDataAdapter
    Dim sqlcon As MySqlConnection
    Dim da As MySqlDataAdapter
    Dim ds As DataSet

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sqlcon = New MySqlConnection("Server=localhost;database=tech4ed;uid=root;pwd=")
        sqlcon.Open()
    End Sub

    

   
    Private Sub Panel2_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel2.MouseDown
        drag = True
        mousex = System.Windows.Forms.Cursor.Position.X - Me.Left
        mousey = System.Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub

    Private Sub Panel2_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel2.MouseMove
        If drag Then
            Me.Top = System.Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = System.Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub Panel2_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel2.MouseUp
        drag = False
    End Sub

    
    
   

    Private Sub PictureBox2_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox2.MouseDown
        drag = True
        mousex = System.Windows.Forms.Cursor.Position.X - Me.Left
        mousey = System.Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub

    

    Private Sub PictureBox2_MouseUp(sender As Object, e As MouseEventArgs) Handles PictureBox2.MouseUp
        drag = False
    End Sub



    Private Sub PictureBox2_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox2.MouseMove
        If drag Then
            Me.Top = System.Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = System.Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub


    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim errors As Boolean = True


        ds = New DataSet
        da = New MySqlDataAdapter("select username,password,user_no from user_info", sqlcon)
        da.Fill(ds, "user_info")
        For a As Integer = 0 To ds.Tables("user_info").Rows.Count - 1
            If TextBox1.Text = ds.Tables("user_info").Rows(a).Item(0).ToString And TextBox2.Text = ds.Tables("user_info").Rows(a).Item(1).ToString Then

                MsgBox("Welcome! You login as ADMIN", vbInformation, "Success")





                Me.Hide()
                dashboard.Show()
                TextBox1.Text = ""
                TextBox2.Text = ""
                errors = False

            Else
                MsgBox("Username or Password did not match!", vbCritical, "Error")
                TextBox2.Clear()
            End If

        Next
        If errors = True Then
            MsgBox("Username or Password did not match!", vbCritical, "Error")
            TextBox2.Clear()
        End If
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        Dim ans As MsgBoxResult
        ans = MsgBox("Do you really want to Exit??", vbYesNo, "Exit")
        If ans = MsgBoxResult.Yes Then
            End
        ElseIf ans = MsgBoxResult.No Then
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class
