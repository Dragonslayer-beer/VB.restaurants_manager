Imports MySql.Data.MySqlClient
Imports System.IO
Public Class FrnManagerEmployees
    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        With FrmInsertEmployee
            .brn_update.Enabled = False
            .ShowDialog()
        End With
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs)
        Me.Dispose()
    End Sub

    Private Sub ToolStripButton2_Click_1(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Me.Dispose()

    End Sub

    Private Sub FrnManagerEmployees_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadEmployees()
        DataGridView1.DefaultCellStyle.Font = New Font("Noto Serif Lao SemCond", 15)
        DataGridView1.Font = New Font("Noto Serif Lao SemCond", 12)
        DataGridView1.Columns(2).HeaderText = "ຊື່"
        DataGridView1.Columns(3).HeaderText = "ອາຍຸ"
        DataGridView1.Columns(4).HeaderText = "ຕຳແໜ່ງ"
        DataGridView1.Columns(5).HeaderText = "ຮູບພາບ"
        DataGridView1.Columns(6).HeaderText = "ເພດ"
        DataGridView1.Columns(7).HeaderText = "ເມວ"
    End Sub
    Sub LoadEmployees()
        DataGridView1.Rows.Clear()
        Dim i As Integer
        cn.Open()
        cm = New MySqlCommand("select * from tb_employee", cn)
        dr = cm.ExecuteReader
        While dr.Read
            i += 1
            DataGridView1.Rows.Add(i, dr.Item("id").ToString, dr.Item("Name").ToString, dr.Item("Age").ToString, dr.Item("Department").ToString, dr.Item("Photo"), dr.Item("Gender").ToString)

        End While
        dr.Close()
        cn.Close()
        For i = 0 To DataGridView1.Rows.Count - 1
            Dim r As DataGridViewRow = DataGridView1.Rows(i)
            r.Height = 100
        Next
        Dim imagecolumn = DirectCast(DataGridView1.Columns("Column8"), DataGridViewImageColumn)
        imagecolumn.ImageLayout = DataGridViewImageCellLayout.Stretch

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim colname As String = DataGridView1.Columns(e.ColumnIndex).Name
        If colname = "colSearch" Then
            With frmShowEm
                cn.Open()
                cm = New MySqlCommand("select * from tb_employee where id like '" & DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString & "'", cn)
                dr = cm.ExecuteReader
                While dr.Read
                    .ShowID.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString
                End While
                dr.Close()
                cn.Close()
                .ShowDialog()
            End With
        ElseIf colname = "colEdit" Then
            With FrmInsertEmployee
                cn.Open()
                cm = New MySqlCommand("select Photo from tb_employee where id like '" & DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString & "'", cn)
                dr = cm.ExecuteReader
                While dr.Read
                    .txt_id.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString
                    Dim len As Long = dr.GetBytes(0, 0, Nothing, 0, 0)
                    Dim arrat(CInt(len)) As Byte
                    dr.GetBytes(0, 0, arrat, 0, CInt(len))
                    Dim ms As New MemoryStream(arrat)
                    Dim bitmap As New System.Drawing.Bitmap(ms)
                    .PictureBox1.BackgroundImage = bitmap
                End While
                .btn_save.Enabled = False
                dr.Close()
                cn.Close()
                .ShowDialog()
            End With
        ElseIf colname = "colDelete" Then
            Dim show As New mb.ShowMessagebox
            show.Fonts(New Font("Noto Serif Lao SemCond", 14), mb.TextColor.Gold)
            If show.ShowBox("ຈະລົບຂໍມູນບໍ ? ", vbYesNo + vbQuestion) = vbYes Then
                cn.Open()
                cm = New MySqlCommand("delete from tb_employee where id like '" & DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString & "'", cn)
                cm.ExecuteNonQuery()
                cn.Close()
                show.ShowBox("ຂໍ້ມູນຂອງທ່ານຖືກລົບລະເດີ້ ! ", vbEmpty)
                LoadEmployees()
            End If
        End If
    End Sub
End Class