Imports System.Data.OleDb

Public Class LoginForm2
    Dim cmd As OleDbCommand
    Dim mypath = Application.StartupPath & "\Login.accdb"
    Dim Login = ""
    Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=  C:\Users\Duncan\Dropbox\My PC (DESKTOP-FF53B85)\Desktop\splashform\Palliativecareunit.accdb")


    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnok.Click

        Dim sql = "SELECT *FROM Login WHERE Username ='" & txtusername.Text & "' AND [Password]='" & txtpassword.Text & "'"
        Dim Username As String = ""
        Dim Password As String = ""
        Dim sqlCom As New System.Data.OleDb.OleDbCommand(sql)
        'open database connection
        sqlCom.Connection = con
        con.Open()
        Dim sqlRead As System.Data.OleDb.OleDbDataReader = sqlCom.ExecuteReader()

        If CheckBox1.Checked Then
            MessageBox.Show("Login as Admin Successful!")
            Admin_Page.Show()
            Me.Hide()

        ElseIf CheckBox2.Checked Then

            MessageBox.Show("Login as Nurse Successful!")
            Patient_Details.Show()
            Me.Hide()
        ElseIf CheckBox1.Checked = False Then

            MessageBox.Show("Please indicate login as Admin or Nurse!")
        ElseIf CheckBox2.Checked = False Then
            MessageBox.Show("Please indicate login as Admin or Nurse!")
        Else
            MessageBox.Show("Invalid Username or Password!")
            con.Close()
        End If

    End Sub
    
    Private Sub LoginForm2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Private Sub btnexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexit.Click
        Application.Exit()

    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged

    End Sub
    
    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged

    End Sub
End Class

