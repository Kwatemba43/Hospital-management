Imports System.Data.OleDb

Public Class Patient_Details
    Inherits System.Windows.Forms.Form
    Dim mypath = Application.StartupPath & "\Patient Details.accdb"
    Dim patientdetails As Object = ""
    Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=  C:\Users\Duncan\Dropbox\My PC (DESKTOP-FF53B85)\Desktop\splashform\Palliativecareunit.accdb")
    Dim cmd As OleDbCommand
    Dim dt As New DataTable
    Dim Sql As String
    Dim da As New OleDb.OleDbDataAdapter

    Private Sub btnexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexit.Click
        Me.Close()

    End Sub


    Private Sub Patient_Details_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PalliativecareunitDataSet.Patient_Details' table. You can move, or remove it, as needed.
        Me.Patient_DetailsTableAdapter.Fill(Me.PalliativecareunitDataSet.Patient_Details)

    End Sub

    Private Sub btnclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclear.Click

        First_Name.Clear()
        Last_NameTextBox.Clear()
        IDTextBox.Clear()
        AgeTextBox.Clear()
        GenderTextBox.Clear()
        ResidenceTextBox.Clear()
        Marital__StatusTextBox.Clear()
        HeightTextBox.Clear()
        WeightTextBox.Clear()
        PressureTextBox.Clear()
        DiagnosisTextBox.Clear()
        TreatmentTextBox.Clear()
        Registration_feeTextBox.Clear()
        Consultation_feeTextBox.Clear()
        Laboratory_feeTextBox.Clear()
        X_RAY_feeTextBox.Clear()
        Scanning_feeTextBox.Clear()
        Medication_feeTextBox.Clear()
        Total.Dispose()

    End Sub

    Private Sub Patient_DetailsBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.Patient_DetailsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PalliativecareunitDataSet)

    End Sub

    Private Sub Patient_DetailsBindingNavigatorSaveItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Patient_DetailsBindingNavigator_RefreshItems(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigator1.RefreshItems

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
       

    End Sub

   

    Private Sub Btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btndelete.Click
        Patient_DetailsBindingSource.RemoveCurrent()
    End Sub

 
  


    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Using dbConnection = New OleDbConnection
            Dim dt As New DataTable
            Dim da As New OleDbDataAdapter
            Try

                Patient_DetailsBindingSource.EndEdit()
                Patient_DetailsTableAdapter.Update(PalliativecareunitDataSet.Patient_Details)

            Catch ex As Exception

            End Try
            MessageBox.Show("Data Saved")

        End Using
    End Sub



    Private Sub IDTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IDTextBox.TextChanged

    End Sub

    Private Sub First_Name_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles First_Name.TextChanged

    End Sub

    Private Sub Last_NameTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Last_NameTextBox.TextChanged

    End Sub

    Private Sub GenderTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GenderTextBox.TextChanged

    End Sub

    Private Sub Marital__StatusTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Marital__StatusTextBox.TextChanged

    End Sub

    Private Sub ResidenceTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResidenceTextBox.TextChanged

    End Sub

    Private Sub AgeTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgeTextBox.TextChanged

    End Sub

    Private Sub HeightTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HeightTextBox.TextChanged

    End Sub

    Private Sub WeightTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WeightTextBox.TextChanged

    End Sub

    Private Sub PressureTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PressureTextBox.TextChanged

    End Sub

    Private Sub DiagnosisTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DiagnosisTextBox.TextChanged

    End Sub

    Private Sub TreatmentTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TreatmentTextBox.TextChanged

    End Sub

    Private Sub Registration_feeTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Registration_feeTextBox.TextChanged

    End Sub

    Private Sub Consultation_feeTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Consultation_feeTextBox.TextChanged

    End Sub

    Private Sub Laboratory_feeTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Laboratory_feeTextBox.TextChanged

    End Sub

    Private Sub X_RAY_feeTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles X_RAY_feeTextBox.TextChanged

    End Sub

    Private Sub Scanning_feeTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Scanning_feeTextBox.TextChanged

    End Sub

    Private Sub Medication_feeTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Medication_feeTextBox.TextChanged

    End Sub


    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Patient_DetailsBindingSource.AddNew()

    End Sub

    Private Sub btnTotal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTotal.Click

        Dim Regfee As Integer
        Dim Consultfee As Integer
        Dim Labfee As Integer
        Dim Xrayfee As Integer
        Dim Scannfee As Integer
        Dim medicationfee As Integer

        Regfee = Integer.Parse(Registration_feeTextBox.Text)
        Consultfee = Integer.Parse(Consultation_feeTextBox.Text)
        Labfee = Integer.Parse(Laboratory_feeTextBox.Text)
        Xrayfee = Integer.Parse(X_RAY_feeTextBox.Text)
        Scannfee = Integer.Parse(Scanning_feeTextBox.Text)
        medicationfee = Integer.Parse(Medication_feeTextBox.Text)

        Total.Text = Regfee + Consultfee + Labfee + Xrayfee + Scannfee + medicationfee
       

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Total.Click

    End Sub

    Private Sub searchbox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles searchbox.TextChanged

    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Try
            Me.Patient_DetailsTableAdapter.Fill(Me.PalliativecareunitDataSet.Patient_Details)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    
    Private Sub FillByToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FillByToolStripButton.Click
        Try
            Me.Patient_DetailsTableAdapter.Fill(Me.PalliativecareunitDataSet.Patient_Details)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FillByToolStrip_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles FillByToolStrip.ItemClicked

    End Sub
End Class