<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formlaporanpenghasilan
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.NOPESANANDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOPEMBAYARANDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TANGGALPEMBAYARANDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TOTALPEMBAYARANDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TABELPENGHASILANBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CAFEDataSet = New kasir_cafe.CAFEDataSet()
        Me.TABELPENGHASILANTableAdapter = New kasir_cafe.CAFEDataSetTableAdapters.TABELPENGHASILANTableAdapter()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TABELPENGHASILANBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CAFEDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(869, 493)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(198, 49)
        Me.Button1.TabIndex = 64
        Me.Button1.Text = "Kembali ke Dashboard"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.BackgroundImage = Global.kasir_cafe.My.Resources.Resources.increase
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(239, 553)
        Me.Panel1.TabIndex = 61
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
        Me.Panel2.Location = New System.Drawing.Point(-112, -15)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1219, 100)
        Me.Panel2.TabIndex = 62
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(396, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(281, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tabel Penghasilan"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NOPESANANDataGridViewTextBoxColumn, Me.NOPEMBAYARANDataGridViewTextBoxColumn, Me.TANGGALPEMBAYARANDataGridViewTextBoxColumn, Me.TOTALPEMBAYARANDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TABELPENGHASILANBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(278, 123)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(798, 254)
        Me.DataGridView1.TabIndex = 65
        '
        'NOPESANANDataGridViewTextBoxColumn
        '
        Me.NOPESANANDataGridViewTextBoxColumn.DataPropertyName = "NOPESANAN"
        Me.NOPESANANDataGridViewTextBoxColumn.HeaderText = "NOPESANAN"
        Me.NOPESANANDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NOPESANANDataGridViewTextBoxColumn.Name = "NOPESANANDataGridViewTextBoxColumn"
        Me.NOPESANANDataGridViewTextBoxColumn.Width = 125
        '
        'NOPEMBAYARANDataGridViewTextBoxColumn
        '
        Me.NOPEMBAYARANDataGridViewTextBoxColumn.DataPropertyName = "NOPEMBAYARAN"
        Me.NOPEMBAYARANDataGridViewTextBoxColumn.HeaderText = "NOPEMBAYARAN"
        Me.NOPEMBAYARANDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NOPEMBAYARANDataGridViewTextBoxColumn.Name = "NOPEMBAYARANDataGridViewTextBoxColumn"
        Me.NOPEMBAYARANDataGridViewTextBoxColumn.Width = 125
        '
        'TANGGALPEMBAYARANDataGridViewTextBoxColumn
        '
        Me.TANGGALPEMBAYARANDataGridViewTextBoxColumn.DataPropertyName = "TANGGALPEMBAYARAN"
        Me.TANGGALPEMBAYARANDataGridViewTextBoxColumn.HeaderText = "TANGGALPEMBAYARAN"
        Me.TANGGALPEMBAYARANDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TANGGALPEMBAYARANDataGridViewTextBoxColumn.Name = "TANGGALPEMBAYARANDataGridViewTextBoxColumn"
        Me.TANGGALPEMBAYARANDataGridViewTextBoxColumn.Width = 125
        '
        'TOTALPEMBAYARANDataGridViewTextBoxColumn
        '
        Me.TOTALPEMBAYARANDataGridViewTextBoxColumn.DataPropertyName = "TOTALPEMBAYARAN"
        Me.TOTALPEMBAYARANDataGridViewTextBoxColumn.HeaderText = "TOTALPEMBAYARAN"
        Me.TOTALPEMBAYARANDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TOTALPEMBAYARANDataGridViewTextBoxColumn.Name = "TOTALPEMBAYARANDataGridViewTextBoxColumn"
        Me.TOTALPEMBAYARANDataGridViewTextBoxColumn.Width = 125
        '
        'TABELPENGHASILANBindingSource
        '
        Me.TABELPENGHASILANBindingSource.DataMember = "TABELPENGHASILAN"
        Me.TABELPENGHASILANBindingSource.DataSource = Me.CAFEDataSet
        '
        'CAFEDataSet
        '
        Me.CAFEDataSet.DataSetName = "CAFEDataSet"
        Me.CAFEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TABELPENGHASILANTableAdapter
        '
        Me.TABELPENGHASILANTableAdapter.ClearBeforeFill = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(680, 413)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(183, 23)
        Me.Label3.TabIndex = 66
        Me.Label3.Text = "Total penghasilan"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(869, 402)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(198, 49)
        Me.Button2.TabIndex = 67
        Me.Button2.Text = "hitung total"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'formlaporanpenghasilan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1105, 553)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "formlaporanpenghasilan"
        Me.Text = "formlaporanpenghasilan"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TABELPENGHASILANBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CAFEDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents CAFEDataSet As CAFEDataSet
    Friend WithEvents TABELPENGHASILANBindingSource As BindingSource
    Friend WithEvents TABELPENGHASILANTableAdapter As CAFEDataSetTableAdapters.TABELPENGHASILANTableAdapter
    Friend WithEvents NOPESANANDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NOPEMBAYARANDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TANGGALPEMBAYARANDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TOTALPEMBAYARANDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label3 As Label
    Friend WithEvents Button2 As Button
End Class
