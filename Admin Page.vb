Imports System.Data.OleDb

Public Class Admin_Page
    Dim cmd As OleDbCommand
    Dim mypath = Application.StartupPath & "\Palliativecareunit.accdb"
    Dim Palliativecareunit = ""
    Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\Users\Duncan\Dropbox\My PC (DESKTOP-FF53B85)\Desktop\splashform\Palliativecareunit.accdb")
    Private Sub EmployeeDetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmployeeDetailsToolStripMenuItem.Click
        Dim x As New Form
        x = Employee_Details
        x.Show()
    End Sub

    Private Sub PatientDetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PatientDetailsToolStripMenuItem.Click
        Dim y As New Form
        y = Patient_Details
        y.Show()
    End Sub

    

    Private Sub HospiceProjectsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HospiceProjectsToolStripMenuItem.Click
        Dim yy As New Form
        yy = Hospice_Projects
        yy.Show()
    End Sub


    Private Sub btexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btexit.Click
        Me.Close()
    End Sub

    Private Sub Admin_Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub lblfullnames_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged

    End Sub

    Private Sub MonthCalendar1_DateChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles MonthCalendar1.DateChanged

    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub
End Class