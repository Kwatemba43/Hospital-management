Partial Class PalliativecareunitDataSet
    Partial Class Patient_DetailsDataTable

        Private Sub Patient_DetailsDataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.HeightColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

End Class
