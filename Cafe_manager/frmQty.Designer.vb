<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQty
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblQty = New System.Windows.Forms.Label()
        Me.txtQty = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(308, 4)
        Me.Panel1.TabIndex = 23
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(1361, 12)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 36)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "0.0"
        '
        'lblQty
        '
        Me.lblQty.ForeColor = System.Drawing.Color.Gray
        Me.lblQty.Location = New System.Drawing.Point(0, 7)
        Me.lblQty.Name = "lblQty"
        Me.lblQty.Size = New System.Drawing.Size(308, 29)
        Me.lblQty.TabIndex = 24
        Me.lblQty.Text = "......."
        Me.lblQty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtQty
        '
        Me.txtQty.Font = New System.Drawing.Font("Calibri", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQty.Location = New System.Drawing.Point(0, 39)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(308, 69)
        Me.txtQty.TabIndex = 25
        Me.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'frmQty
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(308, 108)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtQty)
        Me.Controls.Add(Me.lblQty)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmQty"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents lblQty As Label
    Friend WithEvents txtQty As TextBox
End Class
