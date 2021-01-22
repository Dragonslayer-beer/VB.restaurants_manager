Partial Class DataSet1
    Partial Public Class asdasdDataTable
        Private Sub asdasdDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging


        End Sub

    End Class

    Partial Public Class tb_salesDataTable
        Private Sub tb_salesDataTable_tb_salesRowChanging(sender As Object, e As tb_salesRowChangeEvent) Handles Me.tb_salesRowChanging

        End Sub

        Private Sub tb_salesDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.sdateColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class
End Class
