Imports MySql.Data.MySqlClient
Public Class Bill
    Dim ds As New DataSet1
    Dim Reportss As CrystalReport2
    Private Sub Bill_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'With FrmPOS
        '    cm = New MySqlCommand("Select * From tb_cart", cn)
        '    da = New MySqlDataAdapter(cm)
        '    da.Fill(ds.tb_cart)

        '    Reportss = New CrystalReport2()
        '    Reportss.SetDataSource(ds)
        '    CrystalReportViewer1.ReportSource = Reportss
        '    CrystalReportViewer1.RefreshReport()
        'End With


    End Sub
End Class