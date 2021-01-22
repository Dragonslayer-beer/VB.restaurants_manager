Imports MySql.Data.MySqlClient
Public Class frmSelectTable
    Dim btnTable As New Button
    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Me.Dispose()

    End Sub
    Sub LoadTable()
        cn.Open()
        cm = New MySqlCommand("select * from vwtable", cn)
        dr = cm.ExecuteReader
        While dr.Read
            btnTable = New Button
            btnTable.Width = 200
            btnTable.Height = 60
            If CDbl(dr.Item("bill").ToString) > 1 Then
                btnTable.Text = dr.Item("tableno").ToString & " -  " & dr.Item("bill").ToString & "  ກີບ"
                btnTable.BackColor = Color.Crimson
                btnTable.Font = New Font("Defago Noto Sans", 9, FontStyle.Regular)
            Else
                btnTable.Text = dr.Item("tableno").ToString
                btnTable.Font = New Font("Defago Noto Sans", 9, FontStyle.Regular)
                btnTable.BackColor = Color.FromArgb(55, 176, 213)
            End If
            btnTable.Tag = dr.Item("tableno").ToString
            btnTable.FlatStyle = FlatStyle.Flat
            btnTable.Font = New Font("Defago Noto Sans", 9, FontStyle.Regular)
            btnTable.ForeColor = Color.White
            btnTable.Cursor = Cursors.Hand
            btnTable.TextAlign = ContentAlignment.MiddleLeft
            FlowLayoutPanel1.Controls.Add(btnTable)
            AddHandler btnTable.Click, AddressOf GetTable_Click
        End While
        dr.Close()
        cn.Close()


    End Sub

    Sub GetTable_Click(sender As Object, e As EventArgs)

        Dim table As String = sender.tag.ToString
        With FrmPOS
            .lblTable.Text = table
            .Getorder()
        End With
        Me.Dispose()


    End Sub


End Class