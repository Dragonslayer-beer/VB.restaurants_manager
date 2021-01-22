Imports MySql.Data.MySqlClient
Imports System.IO
Public Class FrmUserList
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.Dispose()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            Dim show As New mb.ShowMessagebox
            show.Fonts(New Font("Noto Serif Lao SemCond", 14), mb.TextColor.Gold)
            If txtName.Text = String.Empty Or txtPosition.Text = String.Empty Or txtUser.Text = String.Empty Or txtPassword.Text = String.Empty Then
                show.ShowBox("ກະລຸນາໃສ່ຂໍ້ມູນ!", vbCritical)
                Return
            End If
            If show.ShowBox("ທ່ານ ຕ້ອງການບັນທຶກຂໍ້ມູນບໍ ?", vbYesNo + vbQuestion) = vbYes Then

                cn.Open()
                cm = New MySqlCommand("insert into tb_user(username, password ,name , role)values(@username, @password ,@name, @role)", cn)
                With cm.Parameters
                    .AddWithValue("@username", txtUser.Text)
                    .AddWithValue("@password", txtPassword.Text)
                    .AddWithValue("@name", txtName.Text)
                    .AddWithValue("@role", txtPosition.Text)
                End With
                cm.ExecuteNonQuery()
                cn.Close()

                show.ShowBox("ບັນທຶກຂໍ້ມູນສຳເລັດ", vbInformation)
                txtUser.Text = ""
                txtPosition.Text = ""
                txtUser.Text = ""
                txtPassword.Text = ""

                With Frm_managerUser
                    .LoadUser()
                End With

            End If

        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs)
        Dim show As New mb.ShowMessagebox
        show.Fonts(New Font("Noto Serif Lao SemCond", 14), mb.TextColor.Gold)
        Try
            If txtName.Text = String.Empty Or txtPosition.Text = String.Empty Or txtUser.Text = String.Empty Or txtPassword.Text = String.Empty Then
                MsgBox("ກະລຸນາໃສ່ຂໍ້ມູນ!", vbEmpty)
                Return
            End If
            If MsgBox("Update this Record", vbYesNo + vbQuestion) = vbYes Then
                cn.Open()
                cm = New MySqlCommand("update tb_user set username=@username, password=@password ,name=@name, role=@role where id=@id", cn)
                With cm.Parameters
                    .AddWithValue("@username", txtUser.Text)
                    .AddWithValue("@password", txtPassword.Text)
                    .AddWithValue("@name", txtName.Text)
                    .AddWithValue("@role", txtPosition.Text)
                    .AddWithValue("@id", txtID.Text)
                End With
                cm.ExecuteNonQuery()
                cn.Close()
                MsgBox("ແກ້ໄຂຂໍ້ມູນສຳເລັດ", vbInformation)
                With Frm_managerUser
                    .LoadUser()
                End With

            End If

        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub btnUpdate_Click_1(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim show As New mb.ShowMessagebox
        show.Fonts(New Font("Noto Serif Lao SemCond", 14), mb.TextColor.Gold)
        Try
            If txtName.Text = String.Empty Or txtPosition.Text = String.Empty Or txtUser.Text = String.Empty Or txtPassword.Text = String.Empty Then
                show.ShowBox("ກະລຸນາຕື່ມຂໍ້ມູນ !", vbCritical)
                Return
            End If
            If show.ShowBox("ຈະແກ້ໄຂຂໍມູນບໍ ? ", vbYesNo + vbQuestion) = vbYes Then
                cn.Open()
                cm = New MySqlCommand("update tb_user set username=@username, password=@password ,name=@name, role=@role where id=@id", cn)
                With cm.Parameters
                    .AddWithValue("@username", txtUser.Text)
                    .AddWithValue("@password", txtPassword.Text)
                    .AddWithValue("@name", txtName.Text)
                    .AddWithValue("@role", txtPosition.Text)
                    .AddWithValue("@id", txtID.Text)
                End With
                cm.ExecuteNonQuery()
                cn.Close()
                show.ShowBox("ແກ້ໄຂຂໍມູນສຳເລັດແລ້ວ", vbEmpty)
                With Frm_managerUser
                    .LoadUser()
                End With

            End If

        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub
End Class