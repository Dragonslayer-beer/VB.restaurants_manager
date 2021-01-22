Imports MySql.Data.MySqlClient
Imports System.IO
Public Class frmProductList
    Private Sub ToolStripLabel1_Click(sender As Object, e As EventArgs) Handles ToolStripLabel1.Click
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        With frmProduct
            .btnSave.Enabled = True
            .btnUpdate.Enabled = False
            .ShowDialog()
        End With
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Me.Dispose()
        With FrmPOS
            .LoadMenu()
        End With
    End Sub
    Sub LoadRecords()
        DataGridView1.Rows.Clear()

        Dim i As Integer
        Dim a As Double
        cn.Open()
        cm = New MySqlCommand("select * from tb_product", cn)
        dr = cm.ExecuteReader

        While dr.Read
            a = dr.Item("price").ToString
            i += 1
            DataGridView1.Rows.Add(i, dr.Item("id").ToString, dr.Item("description").ToString, Format(a, "#,##0.00").ToString, dr.Item("category").ToString, dr.Item("image"), dr.Item("statut").ToString)

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
        If colname = "colEdit" Then
            With frmProduct
                cn.Open()
                cm = New MySqlCommand("select image from tb_product where id like '" & DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString & "'", cn)
                dr = cm.ExecuteReader
                While dr.Read

                    Dim len As Long = dr.GetBytes(0, 0, Nothing, 0, 0)
                    Dim arrat(CInt(len)) As Byte
                    dr.GetBytes(0, 0, arrat, 0, CInt(len))
                    Dim ms As New MemoryStream(arrat)
                    Dim bitmap As New System.Drawing.Bitmap(ms)
                    .PictureBox1.BackgroundImage = bitmap
                    .txtID.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString
                    .txtDescription.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString
                    .txtPrice.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value.ToString
                    .cboCategory.Text = DataGridView1.Rows(e.RowIndex).Cells(4).Value.ToString
                    .cboStatus.Text = DataGridView1.Rows(e.RowIndex).Cells(6).Value.ToString
                End While
                dr.Close()
                cn.Close()
                .LoadCatrgory()
                .btnSave.Enabled = False
                .btnUpdate.Enabled = True
                .ShowDialog()

            End With
        ElseIf colname = "colDelete" Then
            Dim show As New mb.ShowMessagebox
            show.Fonts(New Font("Noto Serif Lao SemCond", 14), mb.TextColor.Gold)
            If show.ShowBox("ທ່ານ ຈະລົບຂໍ້ມູນບໍ ? ", vbYesNo + vbQuestion) = vbYes Then
                cn.Open()
                cm = New MySqlCommand("delete from tb_product where id like '" & DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString & "'", cn)
                cm.ExecuteNonQuery()
                cn.Close()
                show.ShowBox("ຂໍ້ມູນຂອງທ່ານຖືກລົບລະເດີ້ ! ", vbInformation)
                LoadRecords()
            End If
        End If
    End Sub

    Private Sub frmProductList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.DefaultCellStyle.Font = New Font("Noto Serif Lao SemCond", 15)
        DataGridView1.Font = New Font("Noto Serif Lao SemCond", 12)
        DataGridView1.Columns(2).HeaderText = "ປະເພດສິນຄ້າ"
        DataGridView1.Columns(3).HeaderText = "ລາຄາ   (ກີບ)"
        DataGridView1.Columns(4).HeaderText = "ປະເພດ"
        DataGridView1.Columns(5).HeaderText = "ຮູບພາບ"
        DataGridView1.Columns(6).HeaderText = "ສະຖານະ"

        'DataGridView1.Columns("Price").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
    End Sub

    Private Sub Guna2DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub
End Class