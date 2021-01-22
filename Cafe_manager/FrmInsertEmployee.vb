Imports MySql.Data.MySqlClient
Imports System.IO
Public Class FrmInsertEmployee
    Private Sub Guna2DateTimePicker1_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click
        Me.Dispose()

    End Sub

    Private Sub btn_insertphoto_Click(sender As Object, e As EventArgs) Handles btn_insertphoto.Click
        Using ofd As New OpenFileDialog With {.Filter = "(Image Files)|*.jpg;*.png;*.bmp;*.gif;*.ico|Jpg, | *.jpg|Png, | *.png|Bmp, | *.bmp|Gif, | *.gif|Ico | *.ico", .Multiselect = False, .Title = "Select Image"}
            If ofd.ShowDialog = 1 Then
                PictureBox1.BackgroundImage = Image.FromFile(ofd.FileName)
                openfile_user.FileName = ofd.FileName
            End If
        End Using
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click

        Try
            Dim show As New mb.ShowMessagebox
            show.Fonts(New Font("Noto Serif Lao SemCond", 14), mb.TextColor.Gold)
            If openfile_user.FileName = "OpenFileDialog1" Then
                show.ShowBox("ກະລຸນາເພີ່ມຮູບພາບ!", vbEmpty)
                Return
            End If
            If txt_name.Text = String.Empty Or txt_surname.Text = String.Empty Then
                show.ShowBox("ກະລຸນາເພີ່ມຂໍ້ມູນ !", vbEmpty)
                Return
            End If

            If show.ShowBox("ທ່ານ ຈະເພີ່ມຂໍມູນພະນັກງານບໍ ?", vbYesNo + vbQuestion) = vbYes Then
                Dim stream As New MemoryStream
                PictureBox1.BackgroundImage.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg)
                Dim arrImage() As Byte = stream.GetBuffer
                cn.Open()
                cm = New MySqlCommand("insert into tb_employee(Name, Surname ,Department, StarWork, Gender,Nationality,Age,Salary,Status,Gmail,Photo)values(@Name, @Surname ,@Department, @StarWork, @Gender,@Nationality,@Age,@Salary,@Status,@Gmail,@Photo)", cn)
                With cm.Parameters
                    .AddWithValue("@Name", txt_name.Text)
                    .AddWithValue("@Surname", txt_surname.Text)
                    .AddWithValue("@Department", txt_department.Text)
                    DateTimePicker1.CustomFormat = "yyyy-MM-dd"
                    .AddWithValue("StarWork", DateTimePicker1.Value)
                    Dim sex As String
                    If radio_man.Checked = True Then
                        sex = "ຊາຍ"
                    Else
                        sex = "ຍິງ"
                    End If
                    .AddWithValue("@Gender", sex)
                    .AddWithValue("@Nationality", txt_address.Text)
                    .AddWithValue("@Age", txt_age.Text)
                    .AddWithValue("@Salary", txtSalary.Text)
                    .AddWithValue("@Status", cobo_stastu.Text)
                    .AddWithValue("@Gmail", txt_mail.Text)
                    .AddWithValue("@Photo", arrImage)
                End With
                cm.ExecuteNonQuery()
                cn.Close()
                show.ShowBox("ເພີ່ມຂໍ້ມູນໃຫ້ລະເດີ້", vbEmpty)
            End If
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub txtSalary_TextChanged(sender As Object, e As EventArgs) Handles txtSalary.TextChanged

    End Sub

    Private Sub txtSalary_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSalary.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57
            Case 46
            Case 8
            Case Else
                e.Handled = True
        End Select
    End Sub

    Sub Refresh()
        Try
            cn.Open()
            cm = New MySqlCommand("select * from tb_employee  where id = @id", cn)
            cm.Parameters.Add("@id", MySqlDbType.Int64).Value = txt_id.Text
            dr = cm.ExecuteReader
            If dr.Read() Then
                txt_name.Text = dr.Item("Name").ToString
                txt_surname.Text = dr.Item("Surname").ToString
                txt_department.Text = dr.Item("Department").ToString
                DateTimePicker1.CustomFormat = "yyyy-MM-dd"
                DateTimePicker1.Value = dr.Item("StarWork").ToString
                If dr.Item("Gender").ToString = "ຊາຍ" Then
                    radio_man.Checked = True
                Else
                    radio_woman.Checked = True
                End If

                txt_address.Text = dr.Item("Nationality").ToString
                txt_age.Text = dr.Item("Age").ToString
                cobo_stastu.Text = dr.Item("Status").ToString
                txt_mail.Text = dr.Item("Gmail").ToString
                txtSalary.Text = dr.Item("Salary").ToString
            End If

            dr.Close()
            cn.Close()

        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub Guna2GroupBox1_Click(sender As Object, e As EventArgs) Handles Guna2GroupBox1.Click

    End Sub

    Private Sub FrmInsertEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If txt_id.Text = "" Then
        Else
            Refresh()
        End If
    End Sub
    Private Sub brn_update_Click(sender As Object, e As EventArgs) Handles brn_update.Click
        Try
            Dim Dates = Format(DateTimePicker1.Value, "MM/dd/yyyy").ToString
            Dim show As New mb.ShowMessagebox
            show.Fonts(New Font("Noto Serif Lao SemCond", 14), mb.TextColor.Gold)
            If show.ShowBox("ທ່ານຕ້ອງການແກ້ໄຂຂໍ້ມູນບໍ ?", vbYesNo + vbQuestion) = vbYes Then
                Dim stream As New MemoryStream
                PictureBox1.BackgroundImage.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg)
                Dim arrImage() As Byte = stream.GetBuffer
                cn.Open()
                cm = New MySqlCommand("update tb_employee set Name=@Name, Surname=@Surname, Department=@Department,StarWork=@StarWork, Gender=@Gender, Nationality=@Nationality, Age=@Age, Salary=@Salary, Status=@Status, Gmail=@Gmail, Photo=@Photo where id=@id ", cn)
                With cm.Parameters
                    .AddWithValue("@Name", txt_name.Text)
                    .AddWithValue("@Surname", txt_surname.Text)
                    .AddWithValue("@Department", txt_department.Text)
                    .AddWithValue("@StarWork", Dates)
                    If radio_man.Checked = True Then
                        .AddWithValue("@Gender", "ຊາຍ")
                    ElseIf radio_woman.Checked = True Then
                        .AddWithValue("@Gender", "ຍິງ")
                    End If
                    .AddWithValue("@Nationality", txt_address.Text)
                    .AddWithValue("@Age", txt_age.Text)
                    .AddWithValue("@Salary", txtSalary.Text)
                    .AddWithValue("@Status", cobo_stastu.Text)
                    .AddWithValue("@Gmail", txt_mail.Text)
                    .AddWithValue("@Photo", arrImage)
                    .AddWithValue("@id", txt_id.Text)
                End With
                cm.ExecuteNonQuery()
                cn.Close()
                show.ShowBox("ແກ້ໄຂ ຂໍ້ມູນໃຫ້ສຳເລັດແລ້ວລະເດີ້ ?", vbEmpty)
                With FrnManagerEmployees
                    .LoadEmployees()
                End With
            End If

        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        PictureBox1.BackgroundImage = Nothing
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub
End Class