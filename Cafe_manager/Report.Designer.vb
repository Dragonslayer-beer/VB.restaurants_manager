<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Report
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Data1 = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Data2 = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.q = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button3 = New Guna.UI2.WinForms.Guna2Button()
        Me.TextBox1 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TextBox2 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.CrystalReportViewer1)
        Me.Guna2Panel1.Location = New System.Drawing.Point(-4, 146)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(1359, 881)
        Me.Guna2Panel1.TabIndex = 0
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1359, 881)
        Me.CrystalReportViewer1.TabIndex = 0
        '
        'Data1
        '
        Me.Data1.CheckedState.Parent = Me.Data1
        Me.Data1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Data1.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.Data1.HoverState.Parent = Me.Data1
        Me.Data1.Location = New System.Drawing.Point(295, 36)
        Me.Data1.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.Data1.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.Data1.Name = "Data1"
        Me.Data1.ShadowDecoration.Parent = Me.Data1
        Me.Data1.Size = New System.Drawing.Size(259, 44)
        Me.Data1.TabIndex = 1
        Me.Data1.Value = New Date(2021, 1, 11, 0, 0, 0, 0)
        '
        'Data2
        '
        Me.Data2.CheckedState.Parent = Me.Data2
        Me.Data2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Data2.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.Data2.HoverState.Parent = Me.Data2
        Me.Data2.Location = New System.Drawing.Point(870, 36)
        Me.Data2.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.Data2.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.Data2.Name = "Data2"
        Me.Data2.ShadowDecoration.Parent = Me.Data2
        Me.Data2.Size = New System.Drawing.Size(278, 44)
        Me.Data2.TabIndex = 2
        Me.Data2.Value = New Date(2021, 1, 11, 0, 0, 0, 0)
        '
        'q
        '
        Me.q.AutoSize = True
        Me.q.Font = New System.Drawing.Font("Noto Serif Lao", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.q.Location = New System.Drawing.Point(370, 0)
        Me.q.Name = "q"
        Me.q.Size = New System.Drawing.Size(90, 33)
        Me.q.TabIndex = 3
        Me.q.Text = "ແຕ່ວັນທິ່ : "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Noto Serif Lao", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(965, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 33)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "ຫາວັນທີ່ : "
        '
        'Guna2Button1
        '
        Me.Guna2Button1.BorderRadius = 7
        Me.Guna2Button1.CheckedState.Parent = Me.Guna2Button1
        Me.Guna2Button1.CustomImages.Parent = Me.Guna2Button1
        Me.Guna2Button1.Font = New System.Drawing.Font("Noto Serif Lao", 12.0!)
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.HoverState.Parent = Me.Guna2Button1
        Me.Guna2Button1.Location = New System.Drawing.Point(629, 85)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.ShadowDecoration.Parent = Me.Guna2Button1
        Me.Guna2Button1.Size = New System.Drawing.Size(158, 45)
        Me.Guna2Button1.TabIndex = 5
        Me.Guna2Button1.Text = "ເລື່ອກ"
        '
        'Guna2Button3
        '
        Me.Guna2Button3.BorderColor = System.Drawing.Color.Cyan
        Me.Guna2Button3.BorderRadius = 6
        Me.Guna2Button3.CheckedState.Parent = Me.Guna2Button3
        Me.Guna2Button3.CustomImages.Parent = Me.Guna2Button3
        Me.Guna2Button3.FillColor = System.Drawing.Color.Red
        Me.Guna2Button3.Font = New System.Drawing.Font("Open Sans Semibold", 16.2!, System.Drawing.FontStyle.Bold)
        Me.Guna2Button3.ForeColor = System.Drawing.Color.White
        Me.Guna2Button3.HoverState.Parent = Me.Guna2Button3
        Me.Guna2Button3.Location = New System.Drawing.Point(1318, -3)
        Me.Guna2Button3.Name = "Guna2Button3"
        Me.Guna2Button3.ShadowDecoration.Parent = Me.Guna2Button3
        Me.Guna2Button3.Size = New System.Drawing.Size(52, 41)
        Me.Guna2Button3.TabIndex = 32
        Me.Guna2Button3.Text = "X"
        '
        'TextBox1
        '
        Me.TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBox1.DefaultText = ""
        Me.TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextBox1.DisabledState.Parent = Me.TextBox1
        Me.TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextBox1.Enabled = False
        Me.TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBox1.FocusedState.Parent = Me.TextBox1
        Me.TextBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBox1.HoverState.Parent = Me.TextBox1
        Me.TextBox1.Location = New System.Drawing.Point(295, 85)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextBox1.PlaceholderText = ""
        Me.TextBox1.SelectedText = ""
        Me.TextBox1.ShadowDecoration.Parent = Me.TextBox1
        Me.TextBox1.Size = New System.Drawing.Size(259, 36)
        Me.TextBox1.TabIndex = 33
        '
        'TextBox2
        '
        Me.TextBox2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBox2.DefaultText = ""
        Me.TextBox2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TextBox2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TextBox2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextBox2.DisabledState.Parent = Me.TextBox2
        Me.TextBox2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextBox2.Enabled = False
        Me.TextBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBox2.FocusedState.Parent = Me.TextBox2
        Me.TextBox2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TextBox2.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBox2.HoverState.Parent = Me.TextBox2
        Me.TextBox2.Location = New System.Drawing.Point(870, 85)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextBox2.PlaceholderText = ""
        Me.TextBox2.SelectedText = ""
        Me.TextBox2.ShadowDecoration.Parent = Me.TextBox2
        Me.TextBox2.Size = New System.Drawing.Size(278, 36)
        Me.TextBox2.TabIndex = 34
        '
        'Report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1367, 1028)
        Me.ControlBox = False
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Guna2Button3)
        Me.Controls.Add(Me.Guna2Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.q)
        Me.Controls.Add(Me.Data2)
        Me.Controls.Add(Me.Data1)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Name = "Report"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Data1 As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Data2 As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents q As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button3 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents TextBox1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TextBox2 As Guna.UI2.WinForms.Guna2TextBox
End Class
