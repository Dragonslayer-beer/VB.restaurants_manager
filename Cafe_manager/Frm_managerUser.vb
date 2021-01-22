Imports MySql.Data.MySqlClient
Imports System.IO
Public Class Frm_managerUser
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim colname As String = DataGridView1.Columns(e.ColumnIndex).Name
        If colname = "colEdit" Then
            With FrmUserList
                .txtID.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString
                .txtName.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString
                .txtPosition.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString
                .txtUser.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value.ToString
                .txtPassword.Text = DataGridView1.Rows(e.RowIndex).Cells(4).Value.ToString
                .btnSave.Enabled = False
                .btnUpdate.Enabled = True
                .ShowDialog()

            End With
        ElseIf colname = "colDelete" Then
            Dim show As New mb.ShowMessagebox
            show.Fonts(New Font("Noto Serif Lao SemCond", 14), mb.TextColor.Gold)
            If MsgBox("Delete this record ? ", vbYesNo + vbQuestion) = vbYes Then
                cn.Open()
                cm = New MySqlCommand("delete from tb_user where id like '" & DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString & "'", cn)
                cm.ExecuteNonQuery()
                cn.Close()
                show.ShowBox("ລົບຂໍ້ມູນສຳເລັດແລ້ວເດີ້ ! ", vbEmpty)
            End If
            LoadUser()
        End If



    End Sub
    Sub LoadUser()
        DataGridView1.Rows.Clear()

        Dim i As Integer

        cn.Open()
        cm = New MySqlCommand("select * from tb_user", cn)
        dr = cm.ExecuteReader
        While dr.Read
            i += 1
            DataGridView1.Rows.Add(i, dr.Item("name").ToString, dr.Item("role").ToString, dr.Item("username").ToString, dr.Item("password").ToString)
        End While
        dr.Close()
        cn.Close()

        For i = 0 To DataGridView1.Rows.Count - 1
            Dim r As DataGridViewRow = DataGridView1.Rows(i)
            r.Height = 100
        Next
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Me.Dispose()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        With FrmUserList
            .ShowDialog()
        End With
    End Sub

    Private Sub Frm_managerUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.DefaultCellStyle.Font = New Font("Defago Noto Sans", 15)
        DataGridView1.Font = New Font("Defago Noto Sans", 12)
        DataGridView1.Columns(1).HeaderText = "ຊື່"
        DataGridView1.Columns(2).HeaderText = "ຕຳແໜ່ງ"
        DataGridView1.Columns(3).HeaderText = "ຊື່ຜູ້ໃຊ້ງານ"
        DataGridView1.Columns(4).HeaderText = "ລະຫັດຜ່ານ"
    End Sub
End Class