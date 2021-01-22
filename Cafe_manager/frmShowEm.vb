Imports MySql.Data.MySqlClient
Imports System.IO
Public Class frmShowEm
    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Me.Dispose()

    End Sub

    Private Sub ShowID_Click(sender As Object, e As EventArgs) Handles ShowID.Click


    End Sub

    Private Sub frmShowEm_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        If ShowID.Text < 1 Then
            MsgBox("Error", vbInformation)
        Else
            Refresh()
        End If

    End Sub

    Private Sub brnRignt_Click(sender As Object, e As EventArgs) Handles brnRignt.Click
        ShowID.Text = ShowID.Text + 1
        Refresh()
    End Sub

    Sub Refresh()
        Dim _total As Double
        cn.Open()
        cm = New MySqlCommand("select * from tb_employee  where id = @id", cn)
        cm.Parameters.Add("@id", MySqlDbType.Int64).Value = ShowID.Text
        dr = cm.ExecuteReader

        If dr.Read() Then

            Showname.Text = dr.Item("Name").ToString
            showSurname.Text = dr.Item("Surname").ToString
            ShowDepartment.Text = dr.Item("Department").ToString
            showDateStart.Text = dr.Item("StarWork").ToString
            showGender.Text = dr.Item("Gender").ToString
            ShowContry.Text = dr.Item("Nationality").ToString
            showAge.Text = dr.Item("Age").ToString
            showStatus.Text = dr.Item("Status").ToString
            ShowEmail.Text = dr.Item("Gmail").ToString
            _total = dr.Item("Salary").ToString
            showsarary.Text = Format(_total, "#,##0" + " ກີບ")
            Dim imgByte() As Byte
            imgByte = dr.Item("Photo")
            Dim ms As New MemoryStream(imgByte)
            PictureBox1.Image = Image.FromStream(ms)
        End If


        dr.Close()
        cn.Close()
    End Sub

    Private Sub brnLeft_Click(sender As Object, e As EventArgs) Handles brnLeft.Click
        ShowID.Text = ShowID.Text - 1
        Refresh()
    End Sub
End Class