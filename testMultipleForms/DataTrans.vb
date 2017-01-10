Public Class DataTransfer
    Dim objGetData As GetData = New GetData
    Dim transSet As New DataSet

    Public Sub DisplayDataTable()

        GetData.CreateDataTable()
        'DataGridView1.DataSource = modSet.Tables(0)
        ' GetData.dataSets.Tables(0)

    End Sub


    Private Sub GetAddress_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub saveAddress_Click(sender As Object, e As EventArgs) Handles saveAddress.Click

    End Sub

    Function DataTableCreate()

    End Function

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

    End Sub
End Class