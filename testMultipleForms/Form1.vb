Public Class Form1
    Dim modSet As New DataSet

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CreateDataTable()
    End Sub

    Sub CreateDataTable()
        Dim testTable As New DataTable
        Dim newCol = testTable.Columns
        Dim newRow = testTable.Rows

        newCol.Add("Regular")
        newCol.Add("Price 1")
        newCol.Add("Price 2")

        newRow.Add("Slims", "1.50", "2.00")
        newRow.Add("Subs", "1.50", "2.00")
        newRow.Add("Clubs", "1.50", "2.00")

        modSet.Tables.Add(testTable)

        DataGridView1.DataSource = modSet.Tables(0)
    End Sub

    Sub DisplayDataTable()
        modSet.Tables(0).GetChanges()
        modSet.Tables(0).AcceptChanges()
        DataGridView2.DataSource = modSet.Tables(0)
    End Sub

    Private Sub Commit_Click(sender As Object, e As EventArgs) Handles Commit.Click
        DisplayDataTable()
    End Sub
End Class
