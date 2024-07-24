<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formInputKategori
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
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.SUBKATEGORIMENUBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CAFEDataSet = New kasir_cafe.CAFEDataSet()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.NOSUBKATEGORI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOKATEGORIDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NAMADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KATEGORIMENUBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KATEGORI_MENUTableAdapter = New kasir_cafe.CAFEDataSetTableAdapters.KATEGORI_MENUTableAdapter()
        Me.SUBKATEGORI_MENUTableAdapter = New kasir_cafe.CAFEDataSetTableAdapters.SUBKATEGORI_MENUTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.FKSUBKATEGONOKAT440B1D61BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KATEGORIMENUBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.FKSUBKATEGONOKAT440B1D61BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.KATEGORIMENUBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.CafeDataSet1 = New kasir_cafe.CAFEDataSet()
        CType(Me.SUBKATEGORIMENUBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CAFEDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KATEGORIMENUBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FKSUBKATEGONOKAT440B1D61BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KATEGORIMENUBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FKSUBKATEGONOKAT440B1D61BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KATEGORIMENUBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CafeDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button2.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(470, 455)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(107, 46)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "Submit"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button1.Location = New System.Drawing.Point(332, 455)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(101, 46)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Reset"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(428, 389)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(197, 45)
        Me.TextBox1.TabIndex = 13
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.KATEGORIMENUBindingSource
        Me.ComboBox1.DisplayMember = "NAMA"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(428, 347)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(194, 24)
        Me.ComboBox1.TabIndex = 12
        Me.ComboBox1.ValueMember = "NOKATEGORI"
        '
        'SUBKATEGORIMENUBindingSource
        '
        Me.SUBKATEGORIMENUBindingSource.DataMember = "SUBKATEGORI_MENU"
        Me.SUBKATEGORIMENUBindingSource.DataSource = Me.CAFEDataSet
        '
        'CAFEDataSet
        '
        Me.CAFEDataSet.DataSetName = "CAFEDataSet"
        Me.CAFEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(270, 389)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(135, 21)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Sub-kategori  :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(269, 350)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(134, 21)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Kategori         :"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.BackgroundImage = Global.kasir_cafe.My.Resources.Resources.categorization
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Location = New System.Drawing.Point(0, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 600)
        Me.Panel1.TabIndex = 23
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button3.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(49, 403)
        Me.Button3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(107, 80)
        Me.Button3.TabIndex = 16
        Me.Button3.Text = "Kembali ke Dashboard"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label5.Location = New System.Drawing.Point(40, 33)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(124, 49)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Cafe"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel2.BackgroundImage = Global.kasir_cafe.My.Resources.Resources.leaves
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(915, 100)
        Me.Panel2.TabIndex = 24
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(220, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(277, 39)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Kategori Barang"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NOSUBKATEGORI, Me.NOKATEGORIDataGridViewTextBoxColumn, Me.NAMADataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.SUBKATEGORIMENUBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(263, 135)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(586, 150)
        Me.DataGridView1.TabIndex = 25
        '
        'NOSUBKATEGORI
        '
        Me.NOSUBKATEGORI.DataPropertyName = "NOSUBKATEGORI"
        Me.NOSUBKATEGORI.HeaderText = "NOSUBKATEGORI"
        Me.NOSUBKATEGORI.MinimumWidth = 6
        Me.NOSUBKATEGORI.Name = "NOSUBKATEGORI"
        Me.NOSUBKATEGORI.Width = 125
        '
        'NOKATEGORIDataGridViewTextBoxColumn
        '
        Me.NOKATEGORIDataGridViewTextBoxColumn.DataPropertyName = "NOKATEGORI"
        Me.NOKATEGORIDataGridViewTextBoxColumn.HeaderText = "NOKATEGORI"
        Me.NOKATEGORIDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NOKATEGORIDataGridViewTextBoxColumn.Name = "NOKATEGORIDataGridViewTextBoxColumn"
        Me.NOKATEGORIDataGridViewTextBoxColumn.Width = 125
        '
        'NAMADataGridViewTextBoxColumn
        '
        Me.NAMADataGridViewTextBoxColumn.DataPropertyName = "NAMA"
        Me.NAMADataGridViewTextBoxColumn.HeaderText = "NAMA"
        Me.NAMADataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NAMADataGridViewTextBoxColumn.Name = "NAMADataGridViewTextBoxColumn"
        Me.NAMADataGridViewTextBoxColumn.Width = 125
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
        'SUBKATEGORI_MENUTableAdapter
        '
        Me.SUBKATEGORI_MENUTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(269, 311)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(153, 21)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "NO Subkategori:"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(428, 310)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(181, 22)
        Me.TextBox2.TabIndex = 27
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'FKSUBKATEGONOKAT440B1D61BindingSource
        '
        Me.FKSUBKATEGONOKAT440B1D61BindingSource.DataMember = "FK__SUBKATEGO__NOKAT__440B1D61"
        Me.FKSUBKATEGONOKAT440B1D61BindingSource.DataSource = Me.KATEGORIMENUBindingSource
        '
        'KATEGORIMENUBindingSource1
        '
        Me.KATEGORIMENUBindingSource1.DataMember = "KATEGORI_MENU"
        Me.KATEGORIMENUBindingSource1.DataSource = Me.CAFEDataSet
        '
        'FKSUBKATEGONOKAT440B1D61BindingSource1
        '
        Me.FKSUBKATEGONOKAT440B1D61BindingSource1.DataMember = "FK__SUBKATEGO__NOKAT__440B1D61"
        Me.FKSUBKATEGONOKAT440B1D61BindingSource1.DataSource = Me.KATEGORIMENUBindingSource
        '
        'KATEGORIMENUBindingSource2
        '
        Me.KATEGORIMENUBindingSource2.DataMember = "KATEGORI_MENU"
        Me.KATEGORIMENUBindingSource2.DataSource = Me.CAFEDataSet
        '
        'CafeDataSet1
        '
        Me.CafeDataSet1.DataSetName = "CAFEDataSet"
        Me.CafeDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'formInputKategori
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(915, 568)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "formInputKategori"
        Me.Text = "formInputKategori"
        CType(Me.SUBKATEGORIMENUBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CAFEDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KATEGORIMENUBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FKSUBKATEGONOKAT440B1D61BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KATEGORIMENUBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FKSUBKATEGONOKAT440B1D61BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KATEGORIMENUBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CafeDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents CAFEDataSet As CAFEDataSet
    Friend WithEvents KATEGORIMENUBindingSource As BindingSource
    Friend WithEvents KATEGORI_MENUTableAdapter As CAFEDataSetTableAdapters.KATEGORI_MENUTableAdapter
    Friend WithEvents SUBKATEGORIMENUBindingSource As BindingSource
    Friend WithEvents SUBKATEGORI_MENUTableAdapter As CAFEDataSetTableAdapters.SUBKATEGORI_MENUTableAdapter
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents NOSUBKATEGORI As DataGridViewTextBoxColumn
    Friend WithEvents NOKATEGORIDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NAMADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FKSUBKATEGONOKAT440B1D61BindingSource As BindingSource
    Friend WithEvents KATEGORIMENUBindingSource1 As BindingSource
    Friend WithEvents FKSUBKATEGONOKAT440B1D61BindingSource1 As BindingSource
    Friend WithEvents KATEGORIMENUBindingSource2 As BindingSource
    Friend WithEvents CafeDataSet1 As CAFEDataSet
    Friend WithEvents Button3 As Button
End Class
