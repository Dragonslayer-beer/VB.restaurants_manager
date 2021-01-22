<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmPOS
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.btnTable = New System.Windows.Forms.Button()
        Me.btnProduct = New System.Windows.Forms.Button()
        Me.btnNewOrder = New System.Windows.Forms.Button()
        Me.btn_setting = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColRemove = New System.Windows.Forms.DataGridViewImageColumn()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.lblTransNo1 = New System.Windows.Forms.Label()
        Me.lblTransNo = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblTable = New System.Windows.Forms.Label()
        Me.lblRole = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.PrintDocument = New System.Windows.Forms.Button()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lblTotal)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1940, 58)
        Me.Panel1.TabIndex = 0
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblTotal.Location = New System.Drawing.Point(1879, 15)
        Me.lblTotal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(57, 36)
        Me.lblTotal.TabIndex = 1
        Me.lblTotal.Text = "0.0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Noto Serif Lao", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(-1, 3)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(393, 55)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ລະບົບການຈັກການຮ້ານອາຫານ"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Button3)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.Button7)
        Me.Panel2.Controls.Add(Me.Button5)
        Me.Panel2.Controls.Add(Me.btnTable)
        Me.Panel2.Controls.Add(Me.btnProduct)
        Me.Panel2.Controls.Add(Me.btnNewOrder)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 1023)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1940, 46)
        Me.Panel2.TabIndex = 1
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.Enabled = False
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Noto Serif Lao SemCond", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(300, -4)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(300, 50)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "[ F2 - ຂໍ້ມູນ User ໃຊ້ງານ ]"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Enabled = False
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Noto Serif Lao SemCond", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(1500, -4)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(300, 50)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "[ F6 -  ຂໍ້ມູນພະນັກງານ ]"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.Tomato
        Me.Button7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button7.FlatAppearance.BorderSize = 0
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Font = New System.Drawing.Font("Noto Serif Lao SemCond", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.ForeColor = System.Drawing.Color.White
        Me.Button7.Location = New System.Drawing.Point(1797, -4)
        Me.Button7.Margin = New System.Windows.Forms.Padding(4)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(268, 50)
        Me.Button7.TabIndex = 5
        Me.Button7.Text = "[ F7 - ອອກຈາກລະບົບ ]"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.Button5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button5.Enabled = False
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Noto Serif Lao SemCond", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.Location = New System.Drawing.Point(1200, -4)
        Me.Button5.Margin = New System.Windows.Forms.Padding(4)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(300, 50)
        Me.Button5.TabIndex = 3
        Me.Button5.Text = "[ F5 - ປະຫວັດການຂາຍ ]"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'btnTable
        '
        Me.btnTable.BackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.btnTable.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTable.FlatAppearance.BorderSize = 0
        Me.btnTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTable.Font = New System.Drawing.Font("Noto Serif Lao SemCond", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTable.ForeColor = System.Drawing.Color.White
        Me.btnTable.Location = New System.Drawing.Point(900, -4)
        Me.btnTable.Margin = New System.Windows.Forms.Padding(4)
        Me.btnTable.Name = "btnTable"
        Me.btnTable.Size = New System.Drawing.Size(300, 50)
        Me.btnTable.TabIndex = 2
        Me.btnTable.Text = "[ F4 - ການຈັດການໂຕະ ]"
        Me.btnTable.UseVisualStyleBackColor = False
        '
        'btnProduct
        '
        Me.btnProduct.BackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.btnProduct.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnProduct.FlatAppearance.BorderSize = 0
        Me.btnProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProduct.Font = New System.Drawing.Font("Noto Serif Lao SemCond", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProduct.ForeColor = System.Drawing.Color.White
        Me.btnProduct.Location = New System.Drawing.Point(600, -5)
        Me.btnProduct.Margin = New System.Windows.Forms.Padding(4)
        Me.btnProduct.Name = "btnProduct"
        Me.btnProduct.Size = New System.Drawing.Size(300, 50)
        Me.btnProduct.TabIndex = 2
        Me.btnProduct.Text = "[ F3 - ການຈັດການສິນຄ້າ ]"
        Me.btnProduct.UseVisualStyleBackColor = False
        '
        'btnNewOrder
        '
        Me.btnNewOrder.BackColor = System.Drawing.Color.Orange
        Me.btnNewOrder.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNewOrder.FlatAppearance.BorderSize = 0
        Me.btnNewOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNewOrder.Font = New System.Drawing.Font("Noto Serif Lao SemCond", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewOrder.ForeColor = System.Drawing.Color.White
        Me.btnNewOrder.Location = New System.Drawing.Point(0, -5)
        Me.btnNewOrder.Margin = New System.Windows.Forms.Padding(4)
        Me.btnNewOrder.Name = "btnNewOrder"
        Me.btnNewOrder.Size = New System.Drawing.Size(300, 50)
        Me.btnNewOrder.TabIndex = 0
        Me.btnNewOrder.Text = "[ F1 - ເພີ່ມເມນູ ]"
        Me.btnNewOrder.UseVisualStyleBackColor = False
        '
        'btn_setting
        '
        Me.btn_setting.BackColor = System.Drawing.Color.DodgerBlue
        Me.btn_setting.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_setting.FlatAppearance.BorderSize = 0
        Me.btn_setting.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_setting.Font = New System.Drawing.Font("Noto Serif Lao SemCond", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_setting.ForeColor = System.Drawing.Color.White
        Me.btn_setting.Location = New System.Drawing.Point(1663, 915)
        Me.btn_setting.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_setting.Name = "btn_setting"
        Me.btn_setting.Size = New System.Drawing.Size(373, 99)
        Me.btn_setting.TabIndex = 1
        Me.btn_setting.Text = "ການຈ່າຍເງີນ"
        Me.btn_setting.UseVisualStyleBackColor = False
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(9, 151)
        Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(146, 864)
        Me.FlowLayoutPanel1.TabIndex = 2
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeight = 30
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column5, Me.Column4, Me.ColRemove})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Ivory
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.Location = New System.Drawing.Point(1262, 151)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(778, 863)
        Me.DataGridView1.TabIndex = 3
        '
        'Column1
        '
        Me.Column1.FillWeight = 120.0!
        Me.Column1.HeaderText = "ID"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.Visible = False
        Me.Column1.Width = 6
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column2.HeaderText = "DESCRIPTION"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "#,##0.00"
        DataGridViewCellStyle2.NullValue = "#,##0.00"
        Me.Column3.DefaultCellStyle = DataGridViewCellStyle2
        Me.Column3.HeaderText = "PRICE"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 77
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Column5.DefaultCellStyle = DataGridViewCellStyle3
        Me.Column5.HeaderText = "ORDER"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 87
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Column4.DefaultCellStyle = DataGridViewCellStyle4
        Me.Column4.HeaderText = "TOTAL"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 83
        '
        'ColRemove
        '
        Me.ColRemove.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ColRemove.HeaderText = ""
        Me.ColRemove.Image = Global.Cafe_manager.My.Resources.Resources.icons8_rectangle_32__2_5
        Me.ColRemove.MinimumWidth = 6
        Me.ColRemove.Name = "ColRemove"
        Me.ColRemove.Width = 6
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(163, 151)
        Me.FlowLayoutPanel2.Margin = New System.Windows.Forms.Padding(4)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(1091, 864)
        Me.FlowLayoutPanel2.TabIndex = 3
        '
        'lblTransNo1
        '
        Me.lblTransNo1.AutoSize = True
        Me.lblTransNo1.Font = New System.Drawing.Font("Noto Serif Lao SemCond", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTransNo1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblTransNo1.Location = New System.Drawing.Point(38, 74)
        Me.lblTransNo1.Name = "lblTransNo1"
        Me.lblTransNo1.Size = New System.Drawing.Size(109, 37)
        Me.lblTransNo1.TabIndex = 4
        Me.lblTransNo1.Text = "ເລກທີ່ ໄອດີ :"
        '
        'lblTransNo
        '
        Me.lblTransNo.AutoSize = True
        Me.lblTransNo.Font = New System.Drawing.Font("Defago Noto Sans", 12.75!)
        Me.lblTransNo.ForeColor = System.Drawing.Color.Red
        Me.lblTransNo.Location = New System.Drawing.Point(156, 79)
        Me.lblTransNo.Name = "lblTransNo"
        Me.lblTransNo.Size = New System.Drawing.Size(0, 36)
        Me.lblTransNo.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Noto Serif Lao SemCond", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(39, 110)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(113, 37)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "ເລກທີ່ໂຕະ   :"
        '
        'lblTable
        '
        Me.lblTable.AutoSize = True
        Me.lblTable.Font = New System.Drawing.Font("Defago Noto Sans", 12.75!)
        Me.lblTable.ForeColor = System.Drawing.Color.Red
        Me.lblTable.Location = New System.Drawing.Point(156, 114)
        Me.lblTable.Name = "lblTable"
        Me.lblTable.Size = New System.Drawing.Size(0, 36)
        Me.lblTable.TabIndex = 7
        '
        'lblRole
        '
        Me.lblRole.AutoSize = True
        Me.lblRole.Font = New System.Drawing.Font("Defago Noto Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRole.ForeColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.lblRole.Location = New System.Drawing.Point(1799, 97)
        Me.lblRole.Name = "lblRole"
        Me.lblRole.Size = New System.Drawing.Size(53, 33)
        Me.lblRole.TabIndex = 9
        Me.lblRole.Text = "Roel"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Defago Noto Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.Color.Black
        Me.lblName.Location = New System.Drawing.Point(1797, 62)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(71, 33)
        Me.lblName.TabIndex = 8
        Me.lblName.Text = "Name"
        '
        'PrintDocument
        '
        Me.PrintDocument.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PrintDocument.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PrintDocument.FlatAppearance.BorderSize = 0
        Me.PrintDocument.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PrintDocument.Font = New System.Drawing.Font("Noto Serif Lao SemCond", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrintDocument.ForeColor = System.Drawing.Color.White
        Me.PrintDocument.Location = New System.Drawing.Point(1270, 914)
        Me.PrintDocument.Margin = New System.Windows.Forms.Padding(4)
        Me.PrintDocument.Name = "PrintDocument"
        Me.PrintDocument.Size = New System.Drawing.Size(389, 99)
        Me.PrintDocument.TabIndex = 7
        Me.PrintDocument.Text = "ໃບບິນ"
        Me.PrintDocument.UseVisualStyleBackColor = False
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewImageColumn1.HeaderText = ""
        Me.DataGridViewImageColumn1.Image = Global.Cafe_manager.My.Resources.Resources.icons8_rectangle_32__2_5
        Me.DataGridViewImageColumn1.MinimumWidth = 6
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.Width = 125
        '
        'FrmPOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1940, 1069)
        Me.ControlBox = False
        Me.Controls.Add(Me.btn_setting)
        Me.Controls.Add(Me.PrintDocument)
        Me.Controls.Add(Me.lblRole)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblTable)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblTransNo)
        Me.Controls.Add(Me.lblTransNo1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.FlowLayoutPanel2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmPOS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button7 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents btnTable As Button
    Friend WithEvents btnProduct As Button
    Friend WithEvents btnNewOrder As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblTotal As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents lblTransNo1 As Label
    Friend WithEvents lblTransNo As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblTable As Label
    Friend WithEvents lblRole As Label
    Friend WithEvents lblName As Label
    Friend WithEvents btn_setting As Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents ColRemove As DataGridViewImageColumn
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents PrintDocument As Button
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
End Class
