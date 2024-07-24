<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Formlaporanpenjualan
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label64 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.NOITEMDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOPESANANDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NAMADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HARGADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JUMLAHPESANANDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TANGGALPESANANDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TOTALHARUSDIBAYARDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TABELPENJUALANBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CAFEDataSet = New kasir_cafe.CAFEDataSet()
        Me.TABELPENJUALANTableAdapter = New kasir_cafe.CAFEDataSetTableAdapters.TABELPENJUALANTableAdapter()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TABELPENJUALANBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CAFEDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(1094, 479)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(198, 49)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Kembali ke Dashboard"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(269, 479)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 37)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Total"
        '
        'Label64
        '
        Me.Label64.AutoSize = True
        Me.Label64.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label64.Location = New System.Drawing.Point(372, 480)
        Me.Label64.Name = "Label64"
        Me.Label64.Size = New System.Drawing.Size(32, 36)
        Me.Label64.TabIndex = 60
        Me.Label64.Text = "0"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.BackgroundImage = Global.kasir_cafe.My.Resources.Resources.bill
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(239, 577)
        Me.Panel1.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(73, 211)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 44)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Cafe"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel2.BackgroundImage = Global.kasir_cafe.My.Resources.Resources.leaves
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(-75, -29)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1402, 100)
        Me.Panel2.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(332, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(249, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tabel Penjualan"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NOITEMDataGridViewTextBoxColumn, Me.NOPESANANDataGridViewTextBoxColumn, Me.NAMADataGridViewTextBoxColumn, Me.HARGADataGridViewTextBoxColumn, Me.JUMLAHPESANANDataGridViewTextBoxColumn, Me.TANGGALPESANANDataGridViewTextBoxColumn, Me.TOTALHARUSDIBAYARDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TABELPENJUALANBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(264, 93)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1051, 307)
        Me.DataGridView1.TabIndex = 61
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(599, 467)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(198, 49)
        Me.Button2.TabIndex = 62
        Me.Button2.Text = "Hitung total"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'NOITEMDataGridViewTextBoxColumn
        '
        Me.NOITEMDataGridViewTextBoxColumn.DataPropertyName = "NOITEM"
        Me.NOITEMDataGridViewTextBoxColumn.HeaderText = "NOITEM"
        Me.NOITEMDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NOITEMDataGridViewTextBoxColumn.Name = "NOITEMDataGridViewTextBoxColumn"
        Me.NOITEMDataGridViewTextBoxColumn.Width = 125
        '
        'NOPESANANDataGridViewTextBoxColumn
        '
        Me.NOPESANANDataGridViewTextBoxColumn.DataPropertyName = "NOPESANAN"
        Me.NOPESANANDataGridViewTextBoxColumn.HeaderText = "NOPESANAN"
        Me.NOPESANANDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NOPESANANDataGridViewTextBoxColumn.Name = "NOPESANANDataGridViewTextBoxColumn"
        Me.NOPESANANDataGridViewTextBoxColumn.Width = 125
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
        'TANGGALPESANANDataGridViewTextBoxColumn
        '
        Me.TANGGALPESANANDataGridViewTextBoxColumn.DataPropertyName = "TANGGALPESANAN"
        Me.TANGGALPESANANDataGridViewTextBoxColumn.HeaderText = "TANGGALPESANAN"
        Me.TANGGALPESANANDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TANGGALPESANANDataGridViewTextBoxColumn.Name = "TANGGALPESANANDataGridViewTextBoxColumn"
        Me.TANGGALPESANANDataGridViewTextBoxColumn.Width = 125
        '
        'TOTALHARUSDIBAYARDataGridViewTextBoxColumn
        '
        Me.TOTALHARUSDIBAYARDataGridViewTextBoxColumn.DataPropertyName = "TOTALHARUSDIBAYAR"
        Me.TOTALHARUSDIBAYARDataGridViewTextBoxColumn.HeaderText = "TOTALHARUSDIBAYAR"
        Me.TOTALHARUSDIBAYARDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TOTALHARUSDIBAYARDataGridViewTextBoxColumn.Name = "TOTALHARUSDIBAYARDataGridViewTextBoxColumn"
        Me.TOTALHARUSDIBAYARDataGridViewTextBoxColumn.Width = 125
        '
        'TABELPENJUALANBindingSource
        '
        Me.TABELPENJUALANBindingSource.DataMember = "TABELPENJUALAN"
        Me.TABELPENJUALANBindingSource.DataSource = Me.CAFEDataSet
        '
        'CAFEDataSet
        '
        Me.CAFEDataSet.DataSetName = "CAFEDataSet"
        Me.CAFEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TABELPENJUALANTableAdapter
        '
        Me.TABELPENJUALANTableAdapter.ClearBeforeFill = True
        '
        'Formlaporanpenjualan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1327, 577)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label64)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "Formlaporanpenjualan"
        Me.Text = "Formlaporanpenjualan"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TABELPENJUALANBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CAFEDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label64 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents CAFEDataSet As CAFEDataSet
    Friend WithEvents TABELPENJUALANBindingSource As BindingSource
    Friend WithEvents TABELPENJUALANTableAdapter As CAFEDataSetTableAdapters.TABELPENJUALANTableAdapter
    Friend WithEvents NOITEMDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NOPESANANDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NAMADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HARGADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents JUMLAHPESANANDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TANGGALPESANANDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TOTALHARUSDIBAYARDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Button2 As Button
End Class
