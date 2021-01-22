Imports MySql.Data.MySqlClient
Public Class frmCategory
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.Dispose()

    End Sub

    Private Sub F1_Click(sender As Object, e As EventArgs) Handles F1.Click
        Try
            Dim show As New mb.ShowMessagebox
            show.Fonts(New Font("Noto Serif Lao SemCond", 14), mb.TextColor.Gold)
            If MsgBox("Save this Categery ?", vbYesNo + vbQuestion) = vbYes Then
                cn.Open()
                cm = New MySqlCommand("insert into tb_category (category)values(@category)", cn)
                cm.Parameters.AddWithValue("@category", txtCategory.Text)
                cm.ExecuteNonQuery()
                cn.Close()
                show.ShowBox("ເພີ່ມປະເພດໃຫ້ແລ້ວລະເດີ້ !", vbEmpty)
                txtCategory.Clear()
                txtCategory.Focus()

            End If
            With frmProduct
                .cboCategory.Items.Clear()
                .LoadCatrgory()
            End With
            With FrmPOS
                .ss()
                .LoadCategory()
            End With

        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)

        End Try
    End Sub
End Class