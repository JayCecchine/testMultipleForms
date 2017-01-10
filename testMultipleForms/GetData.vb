Public Class GetData

    Dim modSet As New DataSet
    Dim objTransData As DataTransfer
    Public Property dataSets() As DataSet
        Get
            Return dataSets
        End Get

        Set(value As DataSet)
            dataSets = value
        End Set
    End Property






    Public Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CreateDataTable()
    End Sub

    Public Sub CreateDataTable()
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
        dataSets = modSet

        DataGridView1.DataSource = dataSets.Tables(0)
    End Sub

    Public Sub DisplayDataTable()
        modSet.Tables(0).GetChanges()
        modSet.Tables(0).AcceptChanges()
        DataGridView2.DataSource = modSet.Tables(0)
    End Sub

    Public Sub Commit_Click(sender As Object, e As EventArgs) Handles Commit.Click
        DisplayDataTable()
        DataTransfer.Show()
    End Sub
End Class
