Imports MySql.Data.MySqlClient
Public Class frmLogin
    Private Sub btnLogin_Click(sender As Object, e As EventArgs)
        Try
            Dim found As Boolean = False
            If txtName.Text = String.Empty Or txtPassword.Text = String.Empty Then
                MsgBox("Required empty field.", vbExclamation)
                Return

            End If
            cn.Open()
            cm = New MySqlCommand("select * from tb_user where username =@username and password =@password", cn)
            With cm
                .Parameters.AddWithValue("@username", txtName.Text)
                .Parameters.AddWithValue("@password", txtPassword.Text)
            End With
            dr = cm.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                found = True
                str_user = dr.Item("username").ToString
                str_pass = dr.Item("password").ToString
                str_name = dr.Item("name")
                str_role = dr.Item("role")
            Else
                found = False

            End If

            dr.Close()
            cn.Close()

            If found = True Then
                With FrmPOS
                    MsgBox("Access Granted! Wecome" & str_name, vbInformation)
                    .lblName.Text = "Name : " & str_name
                    .lblRole.Text = "Role   : " & str_role
                    .Show()
                End With
            Else
                MsgBox(" Invalid usename or password !", vbExclamation)
            End If
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtName.Select()
        txtPassword.PasswordChar = Chr(149)

        Connection()
    End Sub

    Private Sub btnCansel_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        Try

            Dim show As New mb.ShowMessagebox
            show.Fonts(New Font("Noto Serif Lao SemCond", 14), mb.TextColor.Gold)
            Dim found As Boolean = False
            If txtName.Text = String.Empty Or txtPassword.Text = String.Empty Then

                show.ShowBox("ກະລຸນາກອກຂໍ້ມູນໃຫ້ຄົບ !")
                Return

            End If
            cn.Open()
            cm = New MySqlCommand("select * from tb_user where username =@username and password =@password", cn)
            With cm
                .Parameters.AddWithValue("@username", txtName.Text)
                .Parameters.AddWithValue("@password", txtPassword.Text)
            End With
            dr = cm.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                found = True
                str_user = dr.Item("username").ToString
                str_pass = dr.Item("password").ToString
                str_name = dr.Item("name")
                str_role = dr.Item("role")
            Else
                found = False

            End If

            dr.Close()
            cn.Close()

            If found = True Then
                With FrmPOS
                    show.ShowBox("ລະຫັດຜ່ານຖືກຕ້ອງ ! ຍິນດີຕອນຮັບ ທ່ານ " & str_name, vbEmpty)
                    .lblName.Text = "Name : " & str_name
                    .lblRole.Text = "Role   : " & str_role
                    .Show()
                End With
            Else
                show.ShowBox(" ຍູເຊີ ຫຼື ລະຫັດຜ່ານບໍຖືກ ກະລຸນາລອງໃຫ່ມອີກຄັ້ງ !", vbEmpty)
            End If
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub
    Dim m As mb.ShowMessagebox
    Private Sub Guna2Button1_Click_1(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        ' Me.Close()
        Dim show As New mb.ShowMessagebox
        show.Fonts(New Font("Noto Serif Lao SemCond", 14), mb.TextColor.Aqua)
        show.ButtonText("ແມ່ນ", "ບໍແມ່ນ")
        If (show.ShowBox("ທ່ານຕ້ອງການອອກຈາກໂປແກຼມບໍ ? ", mb.MStyle.YesNo, mb.FStyle.Question, "ກະລຸນ່າກົດປຸ່ມ !")) = Windows.Forms.DialogResult.Yes Then
            Me.Close()
        Else

        End If
    End Sub

    Private Sub frmLogin_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs)

    End Sub
End Class