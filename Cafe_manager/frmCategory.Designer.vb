<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCategory
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCategory = New System.Windows.Forms.TextBox()
        Me.F1 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label2.Font = New System.Drawing.Font("Defago Noto Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(615, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 25)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "[ ປິດ ]"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Defago Noto Sans", 11.25!)
        Me.Label1.Location = New System.Drawing.Point(4, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 25)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "ປະເພດສິນຄ້າ"
        '
        'txtCategory
        '
        Me.txtCategory.BackColor = System.Drawing.SystemColors.Control
        Me.txtCategory.Font = New System.Drawing.Font("Defago Noto Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCategory.Location = New System.Drawing.Point(6, 39)
        Me.txtCategory.Name = "txtCategory"
        Me.txtCategory.Size = New System.Drawing.Size(657, 29)
        Me.txtCategory.TabIndex = 4
        '
        'F1
        '
        Me.F1.BackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.F1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.F1.FlatAppearance.BorderSize = 0
        Me.F1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.F1.Font = New System.Drawing.Font("Defago Noto Sans", 11.25!)
        Me.F1.ForeColor = System.Drawing.Color.White
        Me.F1.Location = New System.Drawing.Point(6, 74)
        Me.F1.Name = "F1"
        Me.F1.Size = New System.Drawing.Size(103, 27)
        Me.F1.TabIndex = 15
        Me.F1.Text = "ບັນທຶກ"
        Me.F1.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(675, 5)
        Me.Panel1.TabIndex = 23
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(1361, 12)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 29)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "0.0"
        '
        'frmCategory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(675, 109)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.F1)
        Me.Controls.Add(Me.txtCategory)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmCategory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCategory As TextBox
    Friend WithEvents F1 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label8 As Label
End Class
