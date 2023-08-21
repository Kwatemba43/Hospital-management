Imports System.Data.OleDb
Public Class Hospice_Projects
    Inherits System.Windows.Forms.Form
    Dim mypath = Application.StartupPath & "\Hospice Projects & Events.accdb"
    Dim hospice_projects__events As Object = ""
    Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=  C:\Users\Duncan\Dropbox\My PC (DESKTOP-FF53B85)\Desktop\splashform\Palliativecareunit.accdb")
    Dim cmd As OleDbCommand
    Private Sub btnenter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnenter.Click
        Using dbConnection = New OleDbConnection
            Dim dt As New DataTable
            Dim da As New OleDbDataAdapter
            Try

                Hospice_Projects___EventsBindingSource.EndEdit()
                Hospice_Projects___EventsTableAdapter.Update(PalliativecareunitDataSet._Hospice_Projects___Events)

            Catch ex As Exception

            End Try
            MessageBox.Show("Data Saved")
        End Using
    End Sub

    Private Sub Hospice_Projects_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PalliativecareunitDataSet._Hospice_Projects___Events' table. You can move, or remove it, as needed.
        Me.Hospice_Projects___EventsTableAdapter.Fill(Me.PalliativecareunitDataSet._Hospice_Projects___Events)

    End Sub

    Private Sub btnclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclear.Click
        IDTextBox.Clear()
        ProjectsTextBox.Clear()
        EventsTextBox.Clear()
    End Sub

    Private Sub btnexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexit.Click
        Me.Close()
    End Sub

    Private Sub CheckedListBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub CheckedListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Hospice_Projects___EventsBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Hospice_Projects___EventsBindingNavigator_RefreshItems(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

   
  
    Private Sub Projects_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Events_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Hospice_Projects___EventsBindingSource.AddNew()
    End Sub

    Private Sub Hospice_Projects___EventsBindingNavigatorSaveItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Hospice_Projects___EventsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Hospice_Projects___EventsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PalliativecareunitDataSet)

    End Sub
End Class