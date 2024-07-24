<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PELANGGANCAFEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CAFEDataSet = New kasir_cafe.CAFEDataSet()
        Me.PELANGGAN_CAFETableAdapter = New kasir_cafe.CAFEDataSetTableAdapters.PELANGGAN_CAFETableAdapter()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.NOPELANGGANDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NAMADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOTELPDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ALAMATDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EMAILDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PASSWORDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PELANGGANCAFEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CAFEDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(267, 281)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(120, 45)
        Me.Button1.TabIndex = 23
        Me.Button1.Text = "Simpan"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(260, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(263, 37)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Ubah Data Anda"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Button3)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(211, 377)
        Me.Panel2.TabIndex = 29
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button3.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(54, 281)
        Me.Button3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(125, 61)
        Me.Button3.TabIndex = 29
        Me.Button3.Text = "Kembali ke Dashboard"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.kasir_cafe.My.Resources.Resources.record
        Me.PictureBox1.Location = New System.Drawing.Point(12, 68)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(512, 512)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label7.Location = New System.Drawing.Point(46, 18)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(121, 47)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "CAFE"
        '
        'PELANGGANCAFEBindingSource
        '
        Me.PELANGGANCAFEBindingSource.DataMember = "PELANGGAN_CAFE"
        Me.PELANGGANCAFEBindingSource.DataSource = Me.CAFEDataSet
        '
        'CAFEDataSet
        '
        Me.CAFEDataSet.DataSetName = "CAFEDataSet"
        Me.CAFEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PELANGGAN_CAFETableAdapter
        '
        Me.PELANGGAN_CAFETableAdapter.ClearBeforeFill = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NOPELANGGANDataGridViewTextBoxColumn, Me.NAMADataGridViewTextBoxColumn, Me.NOTELPDataGridViewTextBoxColumn, Me.ALAMATDataGridViewTextBoxColumn, Me.EMAILDataGridViewTextBoxColumn, Me.PASSWORDDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.PELANGGANCAFEBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(264, 68)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(677, 150)
        Me.DataGridView1.TabIndex = 32
        '
        'NOPELANGGANDataGridViewTextBoxColumn
        '
        Me.NOPELANGGANDataGridViewTextBoxColumn.DataPropertyName = "NOPELANGGAN"
        Me.NOPELANGGANDataGridViewTextBoxColumn.HeaderText = "NOPELANGGAN"
        Me.NOPELANGGANDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NOPELANGGANDataGridViewTextBoxColumn.Name = "NOPELANGGANDataGridViewTextBoxColumn"
        Me.NOPELANGGANDataGridViewTextBoxColumn.Width = 125
        '
        'NAMADataGridViewTextBoxColumn
        '
        Me.NAMADataGridViewTextBoxColumn.DataPropertyName = "NAMA"
        Me.NAMADataGridViewTextBoxColumn.HeaderText = "NAMA"
        Me.NAMADataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NAMADataGridViewTextBoxColumn.Name = "NAMADataGridViewTextBoxColumn"
        Me.NAMADataGridViewTextBoxColumn.Width = 125
        '
        'NOTELPDataGridViewTextBoxColumn
        '
        Me.NOTELPDataGridViewTextBoxColumn.DataPropertyName = "NOTELP"
        Me.NOTELPDataGridViewTextBoxColumn.HeaderText = "NOTELP"
        Me.NOTELPDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NOTELPDataGridViewTextBoxColumn.Name = "NOTELPDataGridViewTextBoxColumn"
        Me.NOTELPDataGridViewTextBoxColumn.Width = 125
        '
        'ALAMATDataGridViewTextBoxColumn
        '
        Me.ALAMATDataGridViewTextBoxColumn.DataPropertyName = "ALAMAT"
        Me.ALAMATDataGridViewTextBoxColumn.HeaderText = "ALAMAT"
        Me.ALAMATDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ALAMATDataGridViewTextBoxColumn.Name = "ALAMATDataGridViewTextBoxColumn"
        Me.ALAMATDataGridViewTextBoxColumn.Width = 125
        '
        'EMAILDataGridViewTextBoxColumn
        '
        Me.EMAILDataGridViewTextBoxColumn.DataPropertyName = "EMAIL"
        Me.EMAILDataGridViewTextBoxColumn.HeaderText = "EMAIL"
        Me.EMAILDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.EMAILDataGridViewTextBoxColumn.Name = "EMAILDataGridViewTextBoxColumn"
        Me.EMAILDataGridViewTextBoxColumn.Width = 125
        '
        'PASSWORDDataGridViewTextBoxColumn
        '
        Me.PASSWORDDataGridViewTextBoxColumn.DataPropertyName = "PASSWORD"
        Me.PASSWORDDataGridViewTextBoxColumn.HeaderText = "PASSWORD"
        Me.PASSWORDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PASSWORDDataGridViewTextBoxColumn.Name = "PASSWORDDataGridViewTextBoxColumn"
        Me.PASSWORDDataGridViewTextBoxColumn.Width = 125
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1042, 377)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label5)
        Me.Name = "Form2"
        Me.Text = "DataPelanggan"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PELANGGANCAFEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CAFEDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents CAFEDataSet As CAFEDataSet
    Friend WithEvents PELANGGANCAFEBindingSource As BindingSource
    Friend WithEvents PELANGGAN_CAFETableAdapter As CAFEDataSetTableAdapters.PELANGGAN_CAFETableAdapter
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents NOPELANGGANDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NAMADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NOTELPDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ALAMATDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EMAILDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PASSWORDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Button3 As Button
End Class
