Imports MySql.Data.MySqlClient
Imports System.IO
Public Class FrmPOS
    Dim btnCategory As New Button
    Dim pic As New PictureBox
    Dim lblDesc As New Label
    Dim lblPrice As New Label
    Dim lblbg As New Label
    Dim _filter As String = ""
    Private Sub FrmPOS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Connection()
        LoadCategory()
        LoadMenu()
        Enable()
        Me.KeyPreview = True
    End Sub

    Private Sub btnProduct_Click(sender As Object, e As EventArgs) Handles btnProduct.Click
        With frmProductList
            .LoadRecords()
            .ShowDialog()
        End With
    End Sub

    Private Sub btnTable_Click(sender As Object, e As EventArgs) Handles btnTable.Click
        With frmTable
            .btnUpdate.Enabled = False
            .Loadrecore()
            .ShowDialog()
        End With
    End Sub
    Public Sub select_Click(sender As Object, e As EventArgs)
        If lblTransNo.Text = String.Empty Then
            Dim show As New mb.ShowMessagebox
            show.Fonts(New Font("Noto Serif Lao SemCond", 14), mb.TextColor.Gold)
            show.ShowBox(" ກະລຸນາເລືອກໂຕະທີ່ບ່ອນເພີ່ມເມນູ !  ", vbEmpty)
        Else
            Try
                Dim price As Double
                Dim weight As Boolean
                Dim id As String = sender.tag.ToString
                cn.Open()
                cm = New MySqlCommand("select * From tb_product where id like'" & id & "'", cn)
                dr = cm.ExecuteReader
                dr.Read()
                If dr.HasRows Then
                    'description = dr.Item("description").ToString
                    price = CDbl(dr.Item("price").ToString)
                End If

                dr.Close()
                cn.Close()
                With frmQty
                    .AddToCart(id, price, weight)
                    .ShowDialog()
                End With
            Catch ex As Exception
                cn.Close()
                MsgBox(ex.Message, vbCritical)
            End Try
        End If

    End Sub
    Sub loadCart()
        Dim _total As Double
        DataGridView1.Font = New Font("Noto Serif Lao SemCond", 12)
        DataGridView1.Rows.Clear()
        cn.Open()
        cm = New MySqlCommand("select c.id,p.description ,c.price, c.qty, c.total from tb_cart as c inner join tb_product as p on p.id = c.pid where c.transno like '" & lblTransNo.Text & "'", cn)
        dr = cm.ExecuteReader
        While dr.Read
            _total += CDbl(dr.Item("total").ToString)
            DataGridView1.Rows.Add(dr.Item("id").ToString, dr.Item("description").ToString, dr.Item("price").ToString, dr.Item("qty").ToString, dr.Item("total").ToString)

        End While
        cn.Close()
        lblTotal.Text = Format(_total, "#,##0.00")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub
    Sub ss()
        FlowLayoutPanel1.Controls.Clear()
        btnCategory.Dispose()

    End Sub
    Sub LoadCategory()
        cn.Open()
        cm = New MySqlCommand("Select * from tb_category", cn)
        dr = cm.ExecuteReader
        While dr.Read
            'ບ໋ອກ ເມນູ
            btnCategory = New Button
            btnCategory.Width = 100
            btnCategory.Height = 40
            btnCategory.Text = dr.Item("Category").ToString
            btnCategory.FlatStyle = FlatStyle.Flat
            btnCategory.BackColor = Color.FromArgb(125, 137, 214)
            btnCategory.ForeColor = Color.White
            btnCategory.Cursor = Cursors.Hand
            btnCategory.Font = New Font("Noto Serif Lao SemCond", 12, FontStyle.Regular)
            btnCategory.TextAlign = ContentAlignment.MiddleLeft
            FlowLayoutPanel1.Controls.Add(btnCategory)
            AddHandler btnCategory.Click, AddressOf filter_Click
        End While
        dr.Close()
        cn.Close()

        DataGridView1.Font = New Font("Noto Serif Lao SemCond", 12)
        DataGridView1.Columns(1).HeaderText = "ເມນູ"
        DataGridView1.Columns(2).HeaderText = "ລາຄາ"
        DataGridView1.Columns(3).HeaderText = "ຈຳນວນ"
        DataGridView1.Columns(4).HeaderText = "ລວມທັງໝົດ"

    End Sub
    Public Sub filter_Click(sender As Object, e As EventArgs)
        Dim show As New mb.ShowMessagebox
        show.Fonts(New Font("Noto Serif Lao SemCond", 14), mb.TextColor.Gold)
        If lblTransNo.Text = String.Empty Then
            show.ShowBox(" ກະລຸນາເລືອກໂຕະທີ່ບ່ອນເພີ່ມເມນູ ! ", vbEmpty)
        Else
            LoadMenu()
        End If

        _filter = sender.text.ToString

    End Sub

    Sub LoadMenu()

        FlowLayoutPanel2.AutoScroll = True
        FlowLayoutPanel2.Controls.Clear()
        cn.Open()
        cm = New MySqlCommand("Select image, id, description, price, statut from tb_product where category Like '" & _filter & "%' order by description", cn)
        dr = cm.ExecuteReader
        While dr.Read
            Dim len As Long = dr.GetBytes(0, 0, Nothing, 0, 0)
            Dim array(CInt(len)) As Byte
            dr.GetBytes(0, 0, array, 0, CInt(len))

            ' ຮູບເມນູ
            pic = New PictureBox
            pic.Width = 155
            pic.Height = 155
            pic.BackgroundImageLayout = ImageLayout.Stretch
            Dim ms As New MemoryStream(array)
            Dim bitmap As New System.Drawing.Bitmap(ms)
            pic.BackgroundImage = bitmap
            pic.Tag = dr.Item("id").ToString




            'ໜັງສື 
            lblDesc = New Label
            lblDesc.BackColor = Color.White
            lblDesc.ForeColor = Color.Black
            lblDesc.Text = dr.Item("description").ToString
            lblDesc.Font = New Font("Noto Serif Lao SemCond", 10, FontStyle.Regular)
            lblDesc.Dock = DockStyle.Bottom
            lblDesc.Cursor = Cursors.Hand
            lblDesc.TextAlign = ContentAlignment.MiddleCenter
            lblDesc.Tag = dr.Item("id").ToString

            'ລາຄາ
            Dim ASD As Double
            ASD = dr.Item("price").ToString
            lblPrice = New Label
            lblPrice.BackColor = Color.White
            lblPrice.ForeColor = Color.FromArgb(2, 209, 38)
            lblPrice.Text = Format(ASD, "#,##0.00").ToString & " ກີບ"
            lblPrice.Font = New Font("Noto Serif Lao SemCond", 10, FontStyle.Regular)
            lblPrice.Dock = DockStyle.Bottom
            lblPrice.Cursor = Cursors.Hand
            lblPrice.TextAlign = ContentAlignment.BottomCenter
            lblPrice.Tag = dr.Item("id").ToString

            pic.Controls.Add(lblDesc)
            pic.Controls.Add(lblPrice)
            FlowLayoutPanel2.Controls.Add(pic)

            AddHandler pic.Click, AddressOf select_Click
            AddHandler lblDesc.Click, AddressOf select_Click
            AddHandler lblPrice.Click, AddressOf select_Click

        End While
        dr.Close()
        cn.Close()
    End Sub

    Private Sub btnNewOrder_Click(sender As Object, e As EventArgs) Handles btnNewOrder.Click
        lblTransNo.Text = GetTransno()
        With frmSelectTable
            .LoadTable()
            .ShowDialog()
        End With
        loadCart()

    End Sub
    Sub Enable()
        If lblRole.Text = "Role   : Admin" Or lblRole.Text = "Role   : admin" Then
            Button3.Enabled = True
            Button5.Enabled = True
            Button1.Enabled = True
        Else
            Button3.Enabled = False
            Button5.Enabled = False
            Button1.Enabled = False
        End If


    End Sub


    Function GetTransno() As String
        Try
            Dim sdate As String = Now.ToString("yyyyMMdd")
            cn.Open()
            cm = New MySqlCommand("select * from tb_cart where transno like '" & sdate & "%' order by id desc", cn)
            dr = cm.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                GetTransno = CLng(dr.Item("transno").ToString) + 1
            Else
                GetTransno = sdate & "0001"
            End If
            dr.Close()
            cn.Close()
            Return GetTransno
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Function

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim colname As String = DataGridView1.Columns(e.ColumnIndex).Name
        If colname = "ColRemove" Then
            cn.Open()
            cm = New MySqlCommand("delete from tb_cart where id like '" & DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString & "'", cn)
            cm.ExecuteNonQuery()
            cn.Close()
            MsgBox("Item has been Successfully removed from the cart !", vbInformation)
            loadCart()

        End If
    End Sub


    Sub Getorder()
        Dim found As Boolean
        Dim tno As String
        cn.Open()
        cm = New MySqlCommand("select * from  tb_cart where tableno like '" & lblTable.Text & "'", cn)
        dr = cm.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            found = True
            tno = dr.Item("transno").ToString

        Else
            found = False
        End If
        dr.Close()
        cn.Close()
        If found = True Then
            lblTransNo.Text = tno

        End If
    End Sub

    Private Sub FrmPOS_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F1 Then
            'Select Tok
            btnNewOrder_Click(sender, e)
        ElseIf e.KeyCode = Keys.F2 Then
            ' Khr moun User
            With frmSettle
                .txtTotal.Text = lblTotal.Text
                .ShowDialog()
            End With

        ElseIf e.KeyCode = Keys.F3 Then
            'Show Aharn
            With frmProductList
                .LoadRecords()
                .ShowDialog()
            End With
        ElseIf e.KeyCode = Keys.F4 Then

            'Karn jur jarn tok
            With frmTable
                .btnUpdate.Enabled = False
                .Loadrecore()
                .ShowDialog()
            End With
        ElseIf e.KeyCode = Keys.F5 Then
            ' Pa vut 

        ElseIf e.KeyCode = Keys.F6 Then
            'Khr moun pha nuk ngarn 
        ElseIf e.KeyCode = Keys.F7 Then
            'Log Out
            Me.Close()
        End If
    End Sub

    Private Sub btn_setting_Click(sender As Object, e As EventArgs) Handles btn_setting.Click
        With frmSettle
            .txtTotal.Text = lblTotal.Text
            .ShowDialog()
        End With
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles PrintDocument.Click
        'ໃບບິນ
        Dim strPrint As String
        Dim i As Integer
        Dim show As New mb.ShowMessagebox
        show.Fonts(New Font("Noto Serif Lao SemCond", 14), mb.TextColor.Gold)
        If lblTable.Text = "" Then

            show.ShowBox(" ກະລຸນາເລືອກໂຕະທີ່ບ່ອນເພີ່ມເມນູ !  ", vbEmpty)
        Else
            strPrint = "                                 ໃບບິນ ຮ້ານ ອາຫານ ?  " & vbCrLf
            strPrint = strPrint & "------------------------------------------------------------------" & vbCrLf
            strPrint = strPrint & "                        No  : " + lblTransNo.Text & vbCrLf
            strPrint = strPrint & "                        " & lblTable.Text & vbCrLf
            strPrint = strPrint & "                          " & vbCrLf
            strPrint = strPrint & "------------------------------------------------------------------" & vbCrLf
            strPrint = strPrint & "ລວມລາຄາ            ລາຄາ              ຈຳນວນ                  ຊື່" & vbCrLf
            For i = 0 To DataGridView1.Rows.Count - 1 Step 1
                strPrint = strPrint & DataGridView1.Rows(i).Cells(4).Value.ToString & "        "
                strPrint = strPrint & DataGridView1.Rows(i).Cells(3).Value.ToString & "        "
                strPrint = strPrint & DataGridView1.Rows(i).Cells(2).Value.ToString & "        "
                strPrint = strPrint & DataGridView1.Rows(i).Cells(1).Value.ToString & "        " & vbCrLf
            Next
            strPrint = strPrint & "-------------------------------------------------------------------" & vbCrLf
            strPrint = strPrint & "                                             Total :" & lblTotal.Text
            BillPrint.Print(strPrint)
        End If
        'With Bill
        '    .ShowDialog()

        'End With
        'Dim dt As New DataTable
        'With dt
        '    .Columns.Add("DESCRIPTION")
        '    .Columns.Add("PRICE")
        '    .Columns.Add("ORDER")
        '    .Columns.Add("TOTAL")
        '    ''   .Columns.Add("transno")
        '    ''   .Columns.Add("tableno")
        'End With
        'For Each dgr As DataGridViewRow In DataGridView1.Rows
        '    dt.Rows.Add(dgr.Cells(0).Value, dgr.Cells(1).Value, dgr.Cells(2).Value, dgr.Cells(3).Value)
        'Next

        'Dim reportDocument As CrystalDecisions.CrystalReports.Engine.ReportDocument
        'reportDocument = New CrystalReport2
        'reportDocument.SetDataSource(dt)
        'Bill.CrystalReportViewer1.ReportSource = reportDocument
        'Bill.ShowDialog()
        'Bill.Dispose()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        With Frm_managerUser
            .LoadUser()
            .ShowDialog()
        End With
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        With FrnManagerEmployees
            .ShowDialog()

        End With
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        With Report
            .ShowDialog()
        End With

    End Sub

    Private Sub FlowLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles FlowLayoutPanel1.Paint

    End Sub
End Class
