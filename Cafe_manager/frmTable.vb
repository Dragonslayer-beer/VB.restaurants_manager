Imports MySql.Data.MySqlClient
Public Class frmTable
    Dim table As String
    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Me.Dispose()

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            Dim show As New mb.ShowMessagebox
            show.Fonts(New Font("Noto Serif Lao SemCond", 14), mb.TextColor.Gold)
            If txtTable.Text = String.Empty Then Return
            If MsgBox("Save tableno ?", vbYesNo + vbQuestion) = vbYes Then
                cn.Open()
                cm = New MySqlCommand("insert into tb_table (tableno)values(@tableno)", cn)
                cm.Parameters.AddWithValue("@tableno", txtTable.Text)
                cm.ExecuteNonQuery()
                cn.Close()
                show.ShowBox("ເພີ່ມຂໍມູນໃຫ້ສຳເລັດລະເດີ້ !", vbEmpty)
                Loadrecore()
                Button2_Click(sender, e)

            End If
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)

        End Try
    End Sub
    Sub Loadrecore()
        Dim i As Integer
        DataGridView1.Rows.Clear()
        cn.Open()
        cm = New MySqlCommand("select * from tb_table", cn)
        dr = cm.ExecuteReader
        While dr.Read
            i += 1
            DataGridView1.Rows.Add(i, dr.Item("tableno").ToString)
        End While
        dr.Close()
        cn.Close()

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim colname As String = DataGridView1.Columns(e.ColumnIndex).Name
        Dim show As New mb.ShowMessagebox
        show.Fonts(New Font("Noto Serif Lao SemCond", 14), mb.TextColor.Gold)
        If colname = "colEdit" Then
            table = DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString
            txtTable.Text = table
            btnSave.Enabled = False
            btnUpdate.Enabled = True
        ElseIf colname = "colDelete" Then
            If show.ShowBox("ທ່ານຕ້ອງການລົບຂໍ້ມູນບໍ ? ", vbYesNo + vbQuestion) = vbYes Then
                cn.Open()
                cm = New MySqlCommand("delete from tb_table where tableno like '" & DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString & "'", cn)
                cm.ExecuteNonQuery()
                cn.Close()
                show.ShowBox("ລົບຂໍ້ມູນສຳເລັດແລ້ວລະເດີ້!", vbEmpty)
                Loadrecore()

            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        table = ""
        btnSave.Enabled = True
        btnUpdate.Enabled = False
        txtTable.Clear()
        txtTable.Focus()

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            Dim show As New mb.ShowMessagebox
            show.Fonts(New Font("Noto Serif Lao SemCond", 14), mb.TextColor.Gold)
            If txtTable.Text = String.Empty Then Return
            If show.ShowBox("ຕ້ອງການແກ້ໄຂໂຕະບໍ ?", vbYesNo + vbQuestion) = vbYes Then
                cn.Open()
                cm = New MySqlCommand("update tb_table set tableno =@tableno where tableno like '" & table & "'", cn)
                cm.Parameters.AddWithValue("@tableno", txtTable.Text)
                cm.ExecuteNonQuery()
                cn.Close()
                show.ShowBox("ແກ້ໄຂສຳເລັດລະເດີ້ !", vbEmpty)
                Loadrecore()
                Button2_Click(sender, e)

            End If
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)

        End Try
    End Sub

    Private Sub frmTable_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        DataGridView1.Font = New Font("Defago Noto Sans", 12)
        'DataGridView1.Columns(1).HeaderText = ""
    End Sub
End Class