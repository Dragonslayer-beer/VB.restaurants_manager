Imports MySql.Data.MySqlClient
Imports System.IO
Public Class frmProduct
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.Dispose()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        With frmCategory
            .ShowDialog()
        End With
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Using ofd As New OpenFileDialog With {.Filter = "(Image Files)|*.jpg;*.png;*.bmp;*.gif;*.ico|Jpg, | *.jpg|Png, | *.png|Bmp, | *.bmp|Gif, | *.gif|Ico | *.ico", .Multiselect = False, .Title = "Select Image"}
            If ofd.ShowDialog = 1 Then
                PictureBox1.BackgroundImage = Image.FromFile(ofd.FileName)
                OpenFileDialog1.FileName = ofd.FileName
            End If
        End Using
    End Sub

    Sub LoadCatrgory()

        cn.Open()
        cm = New MySqlCommand("SELECT * FROM tb_category", cn)
        dr = cm.ExecuteReader
        While dr.Read
            cboCategory.Items.Add(dr.Item("Category").ToString)
        End While
        dr.Close()
        cn.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim show As New mb.ShowMessagebox
        show.Fonts(New Font("Noto Serif Lao SemCond", 14), mb.TextColor.Gold)
        Try
            If OpenFileDialog1.FileName = "OpenFileDialog1" Then
                show.ShowBox("ກະລຸນາເພີ່ມຮູບພາບ!", vbEmpty)
                Return
            End If
            If txtDescription.Text = String.Empty Or txtPrice.Text = String.Empty Then
                show.ShowBox("ກະລຸນາເພີ່ມຂໍ້ມູນໃຫ້ຄົບ!", vbEmpty)
                Return
            End If
            If cboStatus.Text = String.Empty Or cboStatus.Text = String.Empty Then
                show.ShowBox("ກະລຸນາເລືອກປະເພດຂໍ້ມູນ !", vbEmpty)
                Return
            End If
            If MsgBox("ທ່ານຈະເພີ່ມຂໍ້ມູນບໍ !", vbYesNo + vbQuestion) = vbYes Then

                Dim stream As New MemoryStream
                PictureBox1.BackgroundImage.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg)
                Dim arrImage() As Byte = stream.GetBuffer
                cn.Open()
                cm = New MySqlCommand("insert into tb_product(description, price ,category, image)values(@description, @price ,@category, @image)", cn)
                With cm.Parameters
                    .AddWithValue("@description", txtDescription.Text)
                    .AddWithValue("@price", txtPrice.Text)
                    .AddWithValue("@category", cboCategory.Text)
                    .AddWithValue("@image", arrImage)
                End With
                cm.ExecuteNonQuery()
                cn.Close()

                MsgBox("ເພີ່ມຂໍ້ມູນສຳເລັດແລ້ວລະເດີ້ ! ", vbInformation)
                Clear()
                With frmProductList
                    .LoadRecords()
                End With
                With FrmPOS
                    .LoadMenu()
                End With

            End If

        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub txtPrice_TextChanged(sender As Object, e As EventArgs) Handles txtPrice.TextChanged

    End Sub
    Sub Clear()
        txtDescription.Clear()
        txtID.Text = "(Auto)"
        txtPrice.Clear()
        cboCategory.Text = ""
        cboStatus.Text = ""
        PictureBox1.BackgroundImage = Nothing
        btnSave.Enabled = True
        btnUpdate.Enabled = False
        txtDescription.Focus()
    End Sub

    Private Sub txtPrice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrice.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57
            Case 46
            Case 8
            Case Else
                e.Handled = True
        End Select

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Clear()

    End Sub

    Private Sub cboCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCategory.SelectedIndexChanged

    End Sub

    Private Sub cboCategory_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboCategory.KeyPress
        e.Handled = True

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim show As New mb.ShowMessagebox
        show.Fonts(New Font("Noto Serif Lao SemCond", 14), mb.TextColor.Gold)
        Try
            If txtDescription.Text = String.Empty Or txtPrice.Text = String.Empty Then
                show.ShowBox("ກະລຸນາເພີ່່ມຂໍ້ມູນໃຫ້ຄົບ!", vbCritical)
                Return
            End If
            If cboStatus.Text = String.Empty Or cboStatus.Text = String.Empty Then
                show.ShowBox("ກະລຸນາເພີ່ມປະເພດຂໍ້ມູນ !", vbEmpty)
                Return
            End If
            If show.ShowBox("ທ່ານຕ້ອງການແກ້ໄຂຂໍ້ມູນບໍ ?", vbYesNo + vbQuestion) = vbYes Then

                Dim stream As New MemoryStream
                PictureBox1.BackgroundImage.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg)
                Dim arrImage() As Byte = stream.GetBuffer
                cn.Open()
                cm = New MySqlCommand("update tb_product set description=@description, price=@price ,category=@category, image=@image where id=@id", cn)
                With cm.Parameters
                    .AddWithValue("@description", txtDescription.Text)
                    .AddWithValue("@price", txtPrice.Text)
                    .AddWithValue("@category", cboCategory.Text)
                    .AddWithValue("@image", arrImage)
                    .AddWithValue("@id", txtID.Text)
                End With
                cm.ExecuteNonQuery()
                cn.Close()
                show.ShowBox("ແກ້ໄຂ ຂໍ້ມູນໃຫ້ສຳເລັດແລ້ວລະເດີ້ ?", vbEmpty)
                Clear()
                With frmProductList
                    .LoadRecords()

                End With

            End If

        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub frmProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCatrgory()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class