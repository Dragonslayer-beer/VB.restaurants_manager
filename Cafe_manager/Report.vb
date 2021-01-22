Imports MySql.Data.MySqlClient
Public Class Report
    Dim ds As New DataSet1
    Dim Reportss As CrystalReport1
    Dim p(7) As MySqlParameter
    Private Sub Report_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Report()
    End Sub
    Sub Report()

        'cm = New MySqlCommand("Select * From tb_sales", cn)
        'da = New MySqlDataAdapter(cm)
        'da.Fill(ds.tb_sales)

        'Reportss = New CrystalReport1()
        'Reportss.SetDataSource(ds)
        'CrystalReportViewer1.ReportSource = Reportss
        'CrystalReportViewer1.RefreshReport()


    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        Me.Dispose()

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click

        'Dim FromDate = Format(Data1.Value, "yyyy/MM/dd").ToString
        'Dim ToDate = Format(Data2.Value, "yyyy/MM/dd").ToString

        'cn.Open()
        'cm = New MySqlCommand("Select * from tb_sales where (sdate between ('" & FromDate & "')AND('" & ToDate & "'))", cn)
        'da = New MySqlDataAdapter(cm)
        'da.Fill(ds, "sdate")
        'Reportss = New CrystalReport1()
        'Reportss.SetDataSource(ds)
        'CrystalReportViewer1.ReportSource = Reportss
        ''Reportss.SummaryInfo.ReportTitle = "Sales Date: " & Format(Data1.Value, "dd/MM/yyyy") & Format(Data2.Value, "dd/MM/yyyy")
        'CrystalReportViewer1.RefreshReport()
        'cn.Close()
        'Try
        '    Dim qury As String

        '    Dim FromDate = Format(Data1.Value, "yyyy/MM/dd").ToString
        '    Dim ToDate = Format(Data2.Value, "yyyy/MM/dd").ToString
        '    cn.Open()

        '    p(0) = New MySqlParameter("@FromDate", MySqlDbType.Date)
        '    p(1) = New MySqlParameter("@ToDate", MySqlDbType.Date)
        '    p(0).Value = TextBox1.Text
        '    p(1).Value = TextBox2.Text

        '    qury = "select * from tb_sales where sdate between @FromDate and @ToDate"
        '    da = New MySqlDataAdapter(qury, cn)
        '    da.SelectCommand.Parameters.Add(p(0))
        '    da.SelectCommand.Parameters.Add(p(1))
        '    da.Fill(ds, "sdate")
        '    cn.Close()
        '    Dim cc As New CrystalReport1
        '    cc.SetDataSource(ds.Tables(0))
        '    CrystalReportViewer1.ReportSource = cc
        '    CrystalReportViewer1.Refresh()

        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        '    cn.Close()
        'End Try


        Dim sql As String
        If (cn.State = ConnectionState.Closed) Then
            cn.Open()
        End If
        ds.Reset()
        Dim CR_Rent As New CrystalReport1()
        Sql = "select * from tb_sales where sdate between @date2 and @date3"
        cm = New MySqlCommand(sql, cn)
        cm.Parameters.Clear()
        cm.Parameters.AddWithValue("date2", TextBox1.Text)
        cm.Parameters.AddWithValue("date3", TextBox2.Text)
        da = New MySqlDataAdapter(cm)
        da.Fill(ds, "sdate")
        If Not ds.Tables("sdate") Is Nothing Then
            ds.Tables("sdate").Clear()
        End If
        da.Fill(ds, "sdate")

        CR_Rent.SetDataSource(ds.Tables("sdate"))
        CrystalReportViewer1.ReportSource = CR_Rent
        CrystalReportViewer1.Refresh()
        cn.Close()
    End Sub

    Private Sub Data1_ValueChanged(sender As Object, e As EventArgs) Handles Data1.ValueChanged
        TextBox1.Text = Format(Data1.Value, "yyyy/MM/dd")
    End Sub

    Private Sub Data2_ValueChanged(sender As Object, e As EventArgs) Handles Data2.ValueChanged
        TextBox2.Text = Format(Data2.Value, "yyyy/MM/dd")
    End Sub
End Class