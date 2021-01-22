<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUserList
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
        Me.txtPosition = New System.Windows.Forms.TextBox()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtPosition
        '
        Me.txtPosition.BackColor = System.Drawing.SystemColors.Control
        Me.txtPosition.Font = New System.Drawing.Font("Defago Noto Sans", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPosition.Location = New System.Drawing.Point(93, 79)
        Me.txtPosition.Name = "txtPosition"
        Me.txtPosition.Size = New System.Drawing.Size(432, 32)
        Me.txtPosition.TabIndex = 31
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdate.FlatAppearance.BorderSize = 0
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Font = New System.Drawing.Font("Defago Noto Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.Location = New System.Drawing.Point(198, 193)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(103, 33)
        Me.btnUpdate.TabIndex = 28
        Me.btnUpdate.Text = "ປ່ຽນແປ່ງ"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Defago Noto Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(93, 193)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(103, 33)
        Me.btnSave.TabIndex = 27
        Me.btnSave.Text = "ບັນທຶກ"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Defago Noto Sans", 9.75!)
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(23, 119)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 29)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "ຊື່ຜູ້ໃຊ້ງານ"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Defago Noto Sans", 9.75!)
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(28, 82)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 29)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "ຕຳແໜ່ງ"
        '
        'txtName
        '
        Me.txtName.BackColor = System.Drawing.SystemColors.Control
        Me.txtName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtName.Font = New System.Drawing.Font("Defago Noto Sans", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(93, 41)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(432, 32)
        Me.txtName.TabIndex = 23
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Defago Noto Sans", 9.75!)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(39, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(23, 29)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "ຊື່"
        '
        'txtUser
        '
        Me.txtUser.BackColor = System.Drawing.SystemColors.Control
        Me.txtUser.Font = New System.Drawing.Font("Defago Noto Sans", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUser.Location = New System.Drawing.Point(93, 117)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(432, 32)
        Me.txtUser.TabIndex = 32
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.SystemColors.Control
        Me.txtPassword.Font = New System.Drawing.Font("Defago Noto Sans", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(93, 155)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(432, 32)
        Me.txtPassword.TabIndex = 34
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Defago Noto Sans", 9.75!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(7, 157)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 29)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "ລະຫັດຝ່ານ"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label2.Font = New System.Drawing.Font("Defago Noto Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(531, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 29)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "[ ປິດ ]"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Defago Noto Sans", 9.75!)
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(23, 12)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 29)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "ໄອດີ"
        '
        'txtID
        '
        Me.txtID.BackColor = System.Drawing.SystemColors.Control
        Me.txtID.Enabled = False
        Me.txtID.Location = New System.Drawing.Point(93, 12)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(432, 22)
        Me.txtID.TabIndex = 30
        Me.txtID.Text = "( Auto )"
        '
        'FrmUserList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(595, 235)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.txtPosition)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label3)
        Me.Name = "FrmUserList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtPosition As TextBox
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtUser As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtID As TextBox
End Class
