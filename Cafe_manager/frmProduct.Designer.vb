<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProduct
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboCategory = New System.Windows.Forms.ComboBox()
        Me.cboStatus = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(1, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Product Entry"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label2.Font = New System.Drawing.Font("Defago Noto Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(712, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 29)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "[ ປິດ ]"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Noto Serif Lao SemCond", 13.2!)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(-4, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 37)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "ປະເພດສິນຄ້າ"
        '
        'txtDescription
        '
        Me.txtDescription.BackColor = System.Drawing.SystemColors.Control
        Me.txtDescription.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescription.Font = New System.Drawing.Font("Noto Serif Lao SemCond", 9.0!)
        Me.txtDescription.Location = New System.Drawing.Point(115, 63)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(396, 32)
        Me.txtDescription.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Noto Serif Lao SemCond", 13.2!)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(40, 90)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 37)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "ປະເພດ"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Noto Serif Lao SemCond", 13.2!)
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(54, 120)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 37)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "ລາຄາ"
        '
        'cboCategory
        '
        Me.cboCategory.BackColor = System.Drawing.SystemColors.Control
        Me.cboCategory.Font = New System.Drawing.Font("Noto Serif Lao SemCond", 9.75!)
        Me.cboCategory.FormattingEnabled = True
        Me.cboCategory.Location = New System.Drawing.Point(115, 92)
        Me.cboCategory.Name = "cboCategory"
        Me.cboCategory.Size = New System.Drawing.Size(351, 35)
        Me.cboCategory.TabIndex = 8
        '
        'cboStatus
        '
        Me.cboStatus.BackColor = System.Drawing.SystemColors.Control
        Me.cboStatus.Font = New System.Drawing.Font("Noto Serif Lao SemCond", 9.0!)
        Me.cboStatus.FormattingEnabled = True
        Me.cboStatus.Items.AddRange(New Object() {"ມີ", "ບໍ່ມີ"})
        Me.cboStatus.Location = New System.Drawing.Point(115, 154)
        Me.cboStatus.Name = "cboStatus"
        Me.cboStatus.Size = New System.Drawing.Size(396, 33)
        Me.cboStatus.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Noto Serif Lao SemCond", 13.2!)
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(32, 154)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 37)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "ສະເຕຕັດ"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(546, 24)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(214, 175)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Noto Serif Lao", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(115, 208)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(103, 42)
        Me.btnSave.TabIndex = 14
        Me.btnSave.Text = "ບັນທຶກ"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdate.FlatAppearance.BorderSize = 0
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Font = New System.Drawing.Font("Noto Serif Lao", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.Location = New System.Drawing.Point(220, 208)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(103, 42)
        Me.btnUpdate.TabIndex = 15
        Me.btnUpdate.Text = "ປ່ຽນແປ່ງ"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Noto Serif Lao", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(327, 208)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(103, 42)
        Me.Button2.TabIndex = 16
        Me.Button2.Text = "ລ້າງ"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Noto Serif Lao", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(546, 205)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(214, 42)
        Me.Button3.TabIndex = 17
        Me.Button3.Text = "ເພີ່ມຮູບພາບ"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'txtID
        '
        Me.txtID.BackColor = System.Drawing.SystemColors.Control
        Me.txtID.Enabled = False
        Me.txtID.Location = New System.Drawing.Point(115, 34)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(396, 27)
        Me.txtID.TabIndex = 19
        Me.txtID.Text = "( Auto )"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Noto Serif Lao SemCond", 13.2!)
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(64, 26)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 37)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "ໄອດີ"
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(472, 92)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(39, 30)
        Me.Button4.TabIndex = 20
        Me.Button4.Text = "+"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'txtPrice
        '
        Me.txtPrice.BackColor = System.Drawing.SystemColors.Control
        Me.txtPrice.Font = New System.Drawing.Font("Noto Serif Lao SemCond", 9.0!)
        Me.txtPrice.Location = New System.Drawing.Point(115, 125)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(396, 32)
        Me.txtPrice.TabIndex = 21
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(772, 6)
        Me.Panel1.TabIndex = 22
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
        'frmProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(772, 262)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.cboStatus)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cboCategory)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmProduct"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cboCategory As ComboBox
    Friend WithEvents cboStatus As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents txtID As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label8 As Label
End Class
