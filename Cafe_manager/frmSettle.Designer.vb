<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSettle
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.txtCash = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtChange = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnAccept = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Noto Serif Lao SemCond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(116, -1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ທັງໝົດ"
        '
        'txtTotal
        '
        Me.txtTotal.Enabled = False
        Me.txtTotal.Font = New System.Drawing.Font("Defago Noto Sans", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(12, 26)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(274, 62)
        Me.txtTotal.TabIndex = 1
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCash
        '
        Me.txtCash.Font = New System.Drawing.Font("Defago Noto Sans", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCash.Location = New System.Drawing.Point(12, 108)
        Me.txtCash.Name = "txtCash"
        Me.txtCash.Size = New System.Drawing.Size(274, 62)
        Me.txtCash.TabIndex = 3
        Me.txtCash.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Noto Serif Lao SemCond", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(124, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 33)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "ຈ່າຍ"
        '
        'txtChange
        '
        Me.txtChange.Enabled = False
        Me.txtChange.Font = New System.Drawing.Font("Defago Noto Sans", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtChange.Location = New System.Drawing.Point(12, 190)
        Me.txtChange.Name = "txtChange"
        Me.txtChange.Size = New System.Drawing.Size(274, 62)
        Me.txtChange.TabIndex = 5
        Me.txtChange.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Noto Serif Lao SemCond", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(116, 162)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 33)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "ເງີນທອນ"
        '
        'btnAccept
        '
        Me.btnAccept.BackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.btnAccept.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAccept.FlatAppearance.BorderSize = 0
        Me.btnAccept.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAccept.Font = New System.Drawing.Font("Noto Serif Lao SemCond", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAccept.ForeColor = System.Drawing.Color.White
        Me.btnAccept.Location = New System.Drawing.Point(12, 247)
        Me.btnAccept.Name = "btnAccept"
        Me.btnAccept.Size = New System.Drawing.Size(274, 41)
        Me.btnAccept.TabIndex = 6
        Me.btnAccept.Text = "ຈ່າຍເງີນ"
        Me.btnAccept.UseVisualStyleBackColor = False
        '
        'frmSettle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(301, 302)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnAccept)
        Me.Controls.Add(Me.txtChange)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtCash)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Defago Noto Sans", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Name = "frmSettle"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents txtCash As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtChange As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnAccept As Button
End Class
