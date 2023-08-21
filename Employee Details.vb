Imports System.Data.OleDb

Public Class Employee_Details
    Inherits System.Windows.Forms.Form
    Dim mypath = Application.StartupPath & "\Employee details.accdb"
    Dim employeedetails As Object = ""
    Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\Users\Duncan\Dropbox\My PC (DESKTOP-FF53B85)\Desktop\splashform\splashform\Palliativecareunit.accdb")
    Dim cmd As OleDbCommand
    Public result As DataTable

    Public Sql As String



    Private Sub btnexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexit.Click
        Me.Close()

    End Sub



    Private Sub Employee_Details_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PalliativecareunitDataSet.Employee_details' table. You can move, or remove it, as needed.
        Me.Employee_detailsTableAdapter.Fill(Me.PalliativecareunitDataSet.Employee_details)
        'TODO: This line of code loads data into the 'PalliativecareunitDataSet.Employee_details' table. You can move, or remove it, as needed.
        Me.Employee_detailsTableAdapter.Fill(Me.PalliativecareunitDataSet.Employee_details)


    End Sub

    Private Sub Employee_detailsBindingSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.Employee_detailsBindingSource.AddNew()
        Me.TableAdapterManager.UpdateAll(Me.PalliativecareunitDataSet)

    End Sub

    Private Sub btnclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclear.Click
        First_NameTextBox.Clear()
        Second_NameTextBox.Clear()
        IDTextBox.Clear()
        AgeTextBox.Clear()
        GenderTextBox.Clear()
        ResidenceTextBox.Clear()
        Employee_StatusTextBox.Clear()
        UsernameTextBox.Clear()
        PasswordTextBox.Clear()
        Maritual_StatusTextBox.Clear()

    End Sub

    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        Employee_detailsBindingSource.AddNew()
    End Sub

    Private Sub btnenter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnenter.Click
        Using dbConnection = New OleDbConnection
            Dim dt As New DataTable
            Dim da As New OleDbDataAdapter
            Try

                Employee_detailsBindingSource.EndEdit()
                Employee_detailsTableAdapter.Update(PalliativecareunitDataSet.Employee_details)

            Catch ex As Exception

            End Try
            MessageBox.Show("Data Saved")

        End Using
        
    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        Employee_detailsBindingSource.RemoveCurrent()
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        Me.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString
        First_NameTextBox.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString
        Second_NameTextBox.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString
        IDTextBox.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString
        AgeTextBox.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString
        GenderTextBox.Text = DataGridView1.CurrentRow.Cells(5).Value.ToString
        ResidenceTextBox.Text = DataGridView1.CurrentRow.Cells(6).Value.ToString
        Maritual_StatusTextBox.Text = DataGridView1.CurrentRow.Cells(7).Value.ToString
        Employee_StatusTextBox.Text = DataGridView1.CurrentRow.Cells(8).Value.ToString
        PasswordTextBox.Text = DataGridView1.CurrentRow.Cells(9).Value.ToString
        UsernameTextBox.Text = DataGridView1.CurrentRow.Cells(10).Value.ToString
    End Sub

    Private Sub Employee_detailsBindingNavigator_RefreshItems(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Second_NameLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub First_NameLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub IDTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IDTextBox.TextChanged

    End Sub

    Private Sub First_NameTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles First_NameTextBox.TextChanged

    End Sub

    Private Sub Second_NameTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Second_NameTextBox.TextChanged

    End Sub

    Private Sub Maritual_StatusTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Maritual_StatusTextBox.TextChanged

    End Sub

    Private Sub GenderTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GenderTextBox.TextChanged

    End Sub

    Private Sub AgeTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgeTextBox.TextChanged

    End Sub



  
End Class