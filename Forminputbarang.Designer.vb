<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormInputBarang
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
        Me.components = New System.ComponentModel.Container()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CAFEDataSet = New kasir_cafe.CAFEDataSet()
        Me.ITEMMENUBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ITEM_MENUTableAdapter = New kasir_cafe.CAFEDataSetTableAdapters.ITEM_MENUTableAdapter()
        Me.NOITEMDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOSUBKATEGORIDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NAMADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HARGADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.KATEGORIMENUBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KATEGORI_MENUTableAdapter = New kasir_cafe.CAFEDataSetTableAdapters.KATEGORI_MENUTableAdapter()
        Me.SUBKATEGORIMENUBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SUBKATEGORI_MENUTableAdapter = New kasir_cafe.CAFEDataSetTableAdapters.SUBKATEGORI_MENUTableAdapter()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CAFEDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ITEMMENUBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KATEGORIMENUBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SUBKATEGORIMENUBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button2.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button2.Location = New System.Drawing.Point(130, 35)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(117, 36)
        Me.Button2.TabIndex = 20
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Location = New System.Drawing.Point(326, 33)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(105, 38)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "Submit"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.KATEGORIMENUBindingSource
        Me.ComboBox1.DisplayMember = "NAMA"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(484, 389)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(176, 24)
        Me.ComboBox1.TabIndex = 18
        Me.ComboBox1.ValueMember = "NOKATEGORI"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(484, 479)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(176, 22)
        Me.TextBox2.TabIndex = 17
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(484, 347)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(176, 22)
        Me.TextBox1.TabIndex = 16
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(315, 480)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(143, 21)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Harga              : "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(315, 392)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(144, 21)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Kategori          : "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(315, 348)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(146, 21)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Nama Barang : "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(278, 52)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(382, 49)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Input Data Barang"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(315, 435)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(141, 21)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "SubKategori   : "
        '
        'ComboBox2
        '
        Me.ComboBox2.DataSource = Me.SUBKATEGORIMENUBindingSource
        Me.ComboBox2.DisplayMember = "NAMA"
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(484, 435)
        Me.ComboBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(176, 24)
        Me.ComboBox2.TabIndex = 24
        Me.ComboBox2.ValueMember = "NOSUBKATEGORI"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Location = New System.Drawing.Point(206, 531)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(717, 97)
        Me.Panel2.TabIndex = 25
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(254, 28)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(388, 54)
        Me.Panel3.TabIndex = 26
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.BackgroundImage = Global.kasir_cafe.My.Resources.Resources.coffee_cup__1_
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 676)
        Me.Panel1.TabIndex = 22
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button3.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(24, 531)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(145, 64)
        Me.Button3.TabIndex = 21
        Me.Button3.Text = "Kembali ke Dashboard"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(57, 237)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 49)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Cafe"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NOITEMDataGridViewTextBoxColumn, Me.NOSUBKATEGORIDataGridViewTextBoxColumn, Me.NAMADataGridViewTextBoxColumn, Me.HARGADataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ITEMMENUBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(232, 128)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(654, 150)
        Me.DataGridView1.TabIndex = 27
        '
        'CAFEDataSet
        '
        Me.CAFEDataSet.DataSetName = "CAFEDataSet"
        Me.CAFEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ITEMMENUBindingSource
        '
        Me.ITEMMENUBindingSource.DataMember = "ITEM_MENU"
        Me.ITEMMENUBindingSource.DataSource = Me.CAFEDataSet
        '
        'ITEM_MENUTableAdapter
        '
        Me.ITEM_MENUTableAdapter.ClearBeforeFill = True
        '
        'NOITEMDataGridViewTextBoxColumn
        '
        Me.NOITEMDataGridViewTextBoxColumn.DataPropertyName = "NOITEM"
        Me.NOITEMDataGridViewTextBoxColumn.HeaderText = "NOITEM"
        Me.NOITEMDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NOITEMDataGridViewTextBoxColumn.Name = "NOITEMDataGridViewTextBoxColumn"
        Me.NOITEMDataGridViewTextBoxColumn.Width = 125
        '
        'NOSUBKATEGORIDataGridViewTextBoxColumn
        '
        Me.NOSUBKATEGORIDataGridViewTextBoxColumn.DataPropertyName = "NOSUBKATEGORI"
        Me.NOSUBKATEGORIDataGridViewTextBoxColumn.HeaderText = "NOSUBKATEGORI"
        Me.NOSUBKATEGORIDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NOSUBKATEGORIDataGridViewTextBoxColumn.Name = "NOSUBKATEGORIDataGridViewTextBoxColumn"
        Me.NOSUBKATEGORIDataGridViewTextBoxColumn.Width = 125
        '
        'NAMADataGridViewTextBoxColumn
        '
        Me.NAMADataGridViewTextBoxColumn.DataPropertyName = "NAMA"
        Me.NAMADataGridViewTextBoxColumn.HeaderText = "NAMA"
        Me.NAMADataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NAMADataGridViewTextBoxColumn.Name = "NAMADataGridViewTextBoxColumn"
        Me.NAMADataGridViewTextBoxColumn.Width = 125
        '
        'HARGADataGridViewTextBoxColumn
        '
        Me.HARGADataGridViewTextBoxColumn.DataPropertyName = "HARGA"
        Me.HARGADataGridViewTextBoxColumn.HeaderText = "HARGA"
        Me.HARGADataGridViewTextBoxColumn.MinimumWidth = 6
        Me.HARGADataGridViewTextBoxColumn.Name = "HARGADataGridViewTextBoxColumn"
        Me.HARGADataGridViewTextBoxColumn.Width = 125
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(315, 310)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(110, 21)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "ID Barang : "
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(484, 311)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(176, 22)
        Me.TextBox3.TabIndex = 29
        '
        'KATEGORIMENUBindingSource
        '
        Me.KATEGORIMENUBindingSource.DataMember = "KATEGORI_MENU"
        Me.KATEGORIMENUBindingSource.DataSource = Me.CAFEDataSet
        '
        'KATEGORI_MENUTableAdapter
        '
        Me.KATEGORI_MENUTableAdapter.ClearBeforeFill = True
        '
        'SUBKATEGORIMENUBindingSource
        '
        Me.SUBKATEGORIMENUBindingSource.DataMember = "SUBKATEGORI_MENU"
        Me.SUBKATEGORIMENUBindingSource.DataSource = Me.CAFEDataSet
        '
        'SUBKATEGORI_MENUTableAdapter
        '
        Me.SUBKATEGORI_MENUTableAdapter.ClearBeforeFill = True
        '
        'FormInputBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(919, 631)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel3)
        Me.Name = "FormInputBarang"
        Me.Text = "FormInputBarang"
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CAFEDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ITEMMENUBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KATEGORIMENUBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SUBKATEGORIMENUBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents CAFEDataSet As CAFEDataSet
    Friend WithEvents ITEMMENUBindingSource As BindingSource
    Friend WithEvents ITEM_MENUTableAdapter As CAFEDataSetTableAdapters.ITEM_MENUTableAdapter
    Friend WithEvents NOITEMDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NOSUBKATEGORIDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NAMADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HARGADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents KATEGORIMENUBindingSource As BindingSource
    Friend WithEvents KATEGORI_MENUTableAdapter As CAFEDataSetTableAdapters.KATEGORI_MENUTableAdapter
    Friend WithEvents SUBKATEGORIMENUBindingSource As BindingSource
    Friend WithEvents SUBKATEGORI_MENUTableAdapter As CAFEDataSetTableAdapters.SUBKATEGORI_MENUTableAdapter
End Class
