<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IPAN2
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IPABBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.BaseProyectoDataSet2 = New WindowsApp1.baseProyectoDataSet2()
        Me.BaseProyectoDataSet = New WindowsApp1.baseProyectoDataSet()
        Me.BaseProyectoDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BaseProyectoDataSet1 = New WindowsApp1.baseProyectoDataSet1()
        Me.IPABBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IPABTableAdapter = New WindowsApp1.baseProyectoDataSet1TableAdapters.IPABTableAdapter()
        Me.IPABTableAdapter1 = New WindowsApp1.baseProyectoDataSet2TableAdapters.IPABTableAdapter()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DineroahorradoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadocivilDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DireccionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumtelefonicoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CorreoelectronicoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Delete = New System.Windows.Forms.DataGridViewButtonColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IPABBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BaseProyectoDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BaseProyectoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BaseProyectoDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BaseProyectoDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IPABBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NombreDataGridViewTextBoxColumn, Me.DineroahorradoDataGridViewTextBoxColumn, Me.EstadocivilDataGridViewTextBoxColumn, Me.DireccionDataGridViewTextBoxColumn, Me.NumtelefonicoDataGridViewTextBoxColumn, Me.CorreoelectronicoDataGridViewTextBoxColumn, Me.Delete})
        Me.DataGridView1.DataSource = Me.IPABBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(800, 450)
        Me.DataGridView1.TabIndex = 0
        '
        'IPABBindingSource1
        '
        Me.IPABBindingSource1.DataMember = "IPAB"
        Me.IPABBindingSource1.DataSource = Me.BaseProyectoDataSet2
        '
        'BaseProyectoDataSet2
        '
        Me.BaseProyectoDataSet2.DataSetName = "baseProyectoDataSet2"
        Me.BaseProyectoDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BaseProyectoDataSet
        '
        Me.BaseProyectoDataSet.DataSetName = "baseProyectoDataSet"
        Me.BaseProyectoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BaseProyectoDataSetBindingSource
        '
        Me.BaseProyectoDataSetBindingSource.DataSource = Me.BaseProyectoDataSet
        Me.BaseProyectoDataSetBindingSource.Position = 0
        '
        'BaseProyectoDataSet1
        '
        Me.BaseProyectoDataSet1.DataSetName = "baseProyectoDataSet1"
        Me.BaseProyectoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'IPABBindingSource
        '
        Me.IPABBindingSource.DataMember = "IPAB"
        Me.IPABBindingSource.DataSource = Me.BaseProyectoDataSet1
        '
        'IPABTableAdapter
        '
        Me.IPABTableAdapter.ClearBeforeFill = True
        '
        'IPABTableAdapter1
        '
        Me.IPABTableAdapter1.ClearBeforeFill = True
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "nombre"
        Me.NombreDataGridViewTextBoxColumn.Frozen = True
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        '
        'DineroahorradoDataGridViewTextBoxColumn
        '
        Me.DineroahorradoDataGridViewTextBoxColumn.DataPropertyName = "dinero_ahorrado"
        Me.DineroahorradoDataGridViewTextBoxColumn.Frozen = True
        Me.DineroahorradoDataGridViewTextBoxColumn.HeaderText = "dinero_ahorrado"
        Me.DineroahorradoDataGridViewTextBoxColumn.Name = "DineroahorradoDataGridViewTextBoxColumn"
        '
        'EstadocivilDataGridViewTextBoxColumn
        '
        Me.EstadocivilDataGridViewTextBoxColumn.DataPropertyName = "estado_civil"
        Me.EstadocivilDataGridViewTextBoxColumn.Frozen = True
        Me.EstadocivilDataGridViewTextBoxColumn.HeaderText = "estado_civil"
        Me.EstadocivilDataGridViewTextBoxColumn.Name = "EstadocivilDataGridViewTextBoxColumn"
        '
        'DireccionDataGridViewTextBoxColumn
        '
        Me.DireccionDataGridViewTextBoxColumn.DataPropertyName = "direccion"
        Me.DireccionDataGridViewTextBoxColumn.Frozen = True
        Me.DireccionDataGridViewTextBoxColumn.HeaderText = "direccion"
        Me.DireccionDataGridViewTextBoxColumn.Name = "DireccionDataGridViewTextBoxColumn"
        '
        'NumtelefonicoDataGridViewTextBoxColumn
        '
        Me.NumtelefonicoDataGridViewTextBoxColumn.DataPropertyName = "num_telefonico"
        Me.NumtelefonicoDataGridViewTextBoxColumn.Frozen = True
        Me.NumtelefonicoDataGridViewTextBoxColumn.HeaderText = "num_telefonico"
        Me.NumtelefonicoDataGridViewTextBoxColumn.Name = "NumtelefonicoDataGridViewTextBoxColumn"
        '
        'CorreoelectronicoDataGridViewTextBoxColumn
        '
        Me.CorreoelectronicoDataGridViewTextBoxColumn.DataPropertyName = "correo_electronico"
        Me.CorreoelectronicoDataGridViewTextBoxColumn.Frozen = True
        Me.CorreoelectronicoDataGridViewTextBoxColumn.HeaderText = "correo_electronico"
        Me.CorreoelectronicoDataGridViewTextBoxColumn.Name = "CorreoelectronicoDataGridViewTextBoxColumn"
        '
        'Delete
        '
        Me.Delete.Frozen = True
        Me.Delete.HeaderText = "Eliminar"
        Me.Delete.Name = "Delete"
        Me.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Delete.Text = "Delete"
        Me.Delete.ToolTipText = "Delete"
        '
        'IPAN2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "IPAN2"
        Me.Text = "IPAN2"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IPABBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BaseProyectoDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BaseProyectoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BaseProyectoDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BaseProyectoDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IPABBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BaseProyectoDataSetBindingSource As BindingSource
    Friend WithEvents BaseProyectoDataSet As baseProyectoDataSet
    Friend WithEvents BaseProyectoDataSet1 As baseProyectoDataSet1
    Friend WithEvents IPABBindingSource As BindingSource
    Friend WithEvents IPABTableAdapter As baseProyectoDataSet1TableAdapters.IPABTableAdapter
    Friend WithEvents BaseProyectoDataSet2 As baseProyectoDataSet2
    Friend WithEvents IPABBindingSource1 As BindingSource
    Friend WithEvents IPABTableAdapter1 As baseProyectoDataSet2TableAdapters.IPABTableAdapter
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DineroahorradoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EstadocivilDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DireccionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NumtelefonicoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CorreoelectronicoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Delete As DataGridViewButtonColumn
End Class
