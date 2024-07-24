<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRincianPesanan
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
        Me.components = New System.ComponentModel.Container()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.NOPEMBAYARANDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOPESANANDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TANGGALPEMBAYARANDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TOTALPEMBAYARAN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PEMBAYARANPESANANBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CAFEDataSet = New kasir_cafe.CAFEDataSet()
        Me.PEMBAYARAN_PESANANTableAdapter = New kasir_cafe.CAFEDataSetTableAdapters.PEMBAYARAN_PESANANTableAdapter()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.DataTable1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataTable1TableAdapter = New kasir_cafe.CAFEDataSetTableAdapters.DataTable1TableAdapter()
        Me.NAMADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HARGADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JUMLAHPESANANDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TOTALHARUSDIBAYARDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PEMBAYARANPESANANBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CAFEDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.White
        Me.Label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(221, 463)
        Me.Label11.Name = "Label11"
        Me.Label11.Padding = New System.Windows.Forms.Padding(10)
        Me.Label11.Size = New System.Drawing.Size(71, 41)
        Me.Label11.TabIndex = 30
        Me.Label11.Text = "Total"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.White
        Me.Label12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(540, 463)
        Me.Label12.Name = "Label12"
        Me.Label12.Padding = New System.Windows.Forms.Padding(10)
        Me.Label12.Size = New System.Drawing.Size(20, 41)
        Me.Label12.TabIndex = 31
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(647, 529)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(141, 44)
        Me.Button1.TabIndex = 32
        Me.Button1.Text = "Pesan lagi"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.BackgroundImage = Global.kasir_cafe.My.Resources.Resources.restaurant
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.DateTimePicker1)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Location = New System.Drawing.Point(-1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 588)
        Me.Panel1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(8, 138)
        Me.Label2.Name = "Label2"
        Me.Label2.Padding = New System.Windows.Forms.Padding(10)
        Me.Label2.Size = New System.Drawing.Size(20, 47)
        Me.Label2.TabIndex = 23
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(4, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(10)
        Me.Label1.Size = New System.Drawing.Size(127, 47)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "NoBayar"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(13, 104)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 22)
        Me.TextBox1.TabIndex = 22
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(4, 25)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 22)
        Me.DateTimePicker1.TabIndex = 21
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button4.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(34, 516)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(141, 57)
        Me.Button4.TabIndex = 20
        Me.Button4.Text = "Kembali ke Dashboard"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label8.Location = New System.Drawing.Point(38, 246)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(121, 47)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "CAFE"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel2.BackgroundImage = Global.kasir_cafe.My.Resources.Resources.leaves
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(800, 72)
        Me.Panel2.TabIndex = 21
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(244, 9)
        Me.Label10.Name = "Label10"
        Me.Label10.Padding = New System.Windows.Forms.Padding(10)
        Me.Label10.Size = New System.Drawing.Size(349, 47)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Detail Pembayaran Pesanan"
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(225, 432)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(546, 10)
        Me.ListView1.TabIndex = 33
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Nama"
        Me.ColumnHeader1.Width = 181
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Harga"
        Me.ColumnHeader2.Width = 122
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Jumlah"
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Total"
        Me.ColumnHeader4.Width = 115
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NOPEMBAYARANDataGridViewTextBoxColumn, Me.NOPESANANDataGridViewTextBoxColumn, Me.TANGGALPEMBAYARANDataGridViewTextBoxColumn, Me.TOTALPEMBAYARAN})
        Me.DataGridView1.DataSource = Me.PEMBAYARANPESANANBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(750, 78)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(21, 12)
        Me.DataGridView1.TabIndex = 34
        '
        'NOPEMBAYARANDataGridViewTextBoxColumn
        '
        Me.NOPEMBAYARANDataGridViewTextBoxColumn.DataPropertyName = "NOPEMBAYARAN"
        Me.NOPEMBAYARANDataGridViewTextBoxColumn.HeaderText = "NOPEMBAYARAN"
        Me.NOPEMBAYARANDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NOPEMBAYARANDataGridViewTextBoxColumn.Name = "NOPEMBAYARANDataGridViewTextBoxColumn"
        Me.NOPEMBAYARANDataGridViewTextBoxColumn.Width = 125
        '
        'NOPESANANDataGridViewTextBoxColumn
        '
        Me.NOPESANANDataGridViewTextBoxColumn.DataPropertyName = "NOPESANAN"
        Me.NOPESANANDataGridViewTextBoxColumn.HeaderText = "NOPESANAN"
        Me.NOPESANANDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NOPESANANDataGridViewTextBoxColumn.Name = "NOPESANANDataGridViewTextBoxColumn"
        Me.NOPESANANDataGridViewTextBoxColumn.Width = 125
        '
        'TANGGALPEMBAYARANDataGridViewTextBoxColumn
        '
        Me.TANGGALPEMBAYARANDataGridViewTextBoxColumn.DataPropertyName = "TANGGALPEMBAYARAN"
        Me.TANGGALPEMBAYARANDataGridViewTextBoxColumn.HeaderText = "TANGGALPEMBAYARAN"
        Me.TANGGALPEMBAYARANDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TANGGALPEMBAYARANDataGridViewTextBoxColumn.Name = "TANGGALPEMBAYARANDataGridViewTextBoxColumn"
        Me.TANGGALPEMBAYARANDataGridViewTextBoxColumn.Width = 125
        '
        'TOTALPEMBAYARAN
        '
        Me.TOTALPEMBAYARAN.DataPropertyName = "TOTALPEMBAYARAN"
        Me.TOTALPEMBAYARAN.HeaderText = "TOTALPEMBAYARAN"
        Me.TOTALPEMBAYARAN.MinimumWidth = 6
        Me.TOTALPEMBAYARAN.Name = "TOTALPEMBAYARAN"
        Me.TOTALPEMBAYARAN.Width = 125
        '
        'PEMBAYARANPESANANBindingSource
        '
        Me.PEMBAYARANPESANANBindingSource.DataMember = "PEMBAYARAN_PESANAN"
        Me.PEMBAYARANPESANANBindingSource.DataSource = Me.CAFEDataSet
        '
        'CAFEDataSet
        '
        Me.CAFEDataSet.DataSetName = "CAFEDataSet"
        Me.CAFEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PEMBAYARAN_PESANANTableAdapter
        '
        Me.PEMBAYARAN_PESANANTableAdapter.ClearBeforeFill = True
        '
        'DataGridView2
        '
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NAMADataGridViewTextBoxColumn, Me.HARGADataGridViewTextBoxColumn, Me.JUMLAHPESANANDataGridViewTextBoxColumn, Me.TOTALHARUSDIBAYARDataGridViewTextBoxColumn})
        Me.DataGridView2.DataSource = Me.DataTable1BindingSource
        Me.DataGridView2.Location = New System.Drawing.Point(225, 115)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowHeadersWidth = 51
        Me.DataGridView2.RowTemplate.Height = 24
        Me.DataGridView2.Size = New System.Drawing.Size(563, 294)
        Me.DataGridView2.TabIndex = 35
        '
        'DataTable1BindingSource
        '
        Me.DataTable1BindingSource.DataMember = "DataTable1"
        Me.DataTable1BindingSource.DataSource = Me.CAFEDataSet
        '
        'DataTable1TableAdapter
        '
        Me.DataTable1TableAdapter.ClearBeforeFill = True
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
        'JUMLAHPESANANDataGridViewTextBoxColumn
        '
        Me.JUMLAHPESANANDataGridViewTextBoxColumn.DataPropertyName = "JUMLAHPESANAN"
        Me.JUMLAHPESANANDataGridViewTextBoxColumn.HeaderText = "JUMLAHPESANAN"
        Me.JUMLAHPESANANDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.JUMLAHPESANANDataGridViewTextBoxColumn.Name = "JUMLAHPESANANDataGridViewTextBoxColumn"
        Me.JUMLAHPESANANDataGridViewTextBoxColumn.Width = 125
        '
        'TOTALHARUSDIBAYARDataGridViewTextBoxColumn
        '
        Me.TOTALHARUSDIBAYARDataGridViewTextBoxColumn.DataPropertyName = "TOTALHARUSDIBAYAR"
        Me.TOTALHARUSDIBAYARDataGridViewTextBoxColumn.HeaderText = "TOTALHARUSDIBAYAR"
        Me.TOTALHARUSDIBAYARDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TOTALHARUSDIBAYARDataGridViewTextBoxColumn.Name = "TOTALHARUSDIBAYARDataGridViewTextBoxColumn"
        Me.TOTALHARUSDIBAYARDataGridViewTextBoxColumn.Width = 125
        '
        'FormRincianPesanan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 585)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "FormRincianPesanan"
        Me.Text = "FormRincianPesanan"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PEMBAYARANPESANANBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CAFEDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents CAFEDataSet As CAFEDataSet
    Friend WithEvents PEMBAYARANPESANANBindingSource As BindingSource
    Friend WithEvents PEMBAYARAN_PESANANTableAdapter As CAFEDataSetTableAdapters.PEMBAYARAN_PESANANTableAdapter
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents NOPEMBAYARANDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NOPESANANDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TANGGALPEMBAYARANDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TOTALPEMBAYARAN As DataGridViewTextBoxColumn
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents DataTable1BindingSource As BindingSource
    Friend WithEvents DataTable1TableAdapter As CAFEDataSetTableAdapters.DataTable1TableAdapter
    Friend WithEvents NAMADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HARGADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents JUMLAHPESANANDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TOTALHARUSDIBAYARDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
