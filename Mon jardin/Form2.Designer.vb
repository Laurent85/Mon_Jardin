<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.LégumesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.JardinDataSet = New Mon_jardin.JardinDataSet()
        Me.LégumesTableAdapter = New Mon_jardin.JardinDataSetTableAdapters.LégumesTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Fermer = New System.Windows.Forms.Button()
        Me.Année_text = New System.Windows.Forms.Label()
        Me.NomDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DatesemisDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DaterepiquageDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuantitéDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DaterécolteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AnnéeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LégumesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JardinDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Empty
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NomDataGridViewTextBoxColumn, Me.DatesemisDataGridViewTextBoxColumn, Me.DaterepiquageDataGridViewTextBoxColumn, Me.QuantitéDataGridViewTextBoxColumn, Me.DaterécolteDataGridViewTextBoxColumn, Me.AnnéeDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.LégumesBindingSource
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.Location = New System.Drawing.Point(58, 70)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(553, 316)
        Me.DataGridView1.TabIndex = 38
        '
        'LégumesBindingSource
        '
        Me.LégumesBindingSource.DataMember = "Légumes"
        Me.LégumesBindingSource.DataSource = Me.JardinDataSet
        '
        'JardinDataSet
        '
        Me.JardinDataSet.DataSetName = "JardinDataSet"
        Me.JardinDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LégumesTableAdapter
        '
        Me.LégumesTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Green
        Me.Label1.Location = New System.Drawing.Point(170, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(242, 26)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "Bilan des cultures en "
        '
        'Fermer
        '
        Me.Fermer.Location = New System.Drawing.Point(293, 401)
        Me.Fermer.Name = "Fermer"
        Me.Fermer.Size = New System.Drawing.Size(71, 24)
        Me.Fermer.TabIndex = 40
        Me.Fermer.Text = "Fermer"
        Me.Fermer.UseVisualStyleBackColor = True
        '
        'Année_text
        '
        Me.Année_text.AutoSize = True
        Me.Année_text.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Année_text.ForeColor = System.Drawing.Color.Green
        Me.Année_text.Location = New System.Drawing.Point(405, 23)
        Me.Année_text.Name = "Année_text"
        Me.Année_text.Size = New System.Drawing.Size(83, 26)
        Me.Année_text.TabIndex = 41
        Me.Année_text.Text = "Label2"
        '
        'NomDataGridViewTextBoxColumn
        '
        Me.NomDataGridViewTextBoxColumn.DataPropertyName = "Nom"
        Me.NomDataGridViewTextBoxColumn.HeaderText = "Nom"
        Me.NomDataGridViewTextBoxColumn.Name = "NomDataGridViewTextBoxColumn"
        Me.NomDataGridViewTextBoxColumn.ReadOnly = True
        Me.NomDataGridViewTextBoxColumn.Width = 54
        '
        'DatesemisDataGridViewTextBoxColumn
        '
        Me.DatesemisDataGridViewTextBoxColumn.DataPropertyName = "Date_semis"
        Me.DatesemisDataGridViewTextBoxColumn.HeaderText = "Date_semis"
        Me.DatesemisDataGridViewTextBoxColumn.Name = "DatesemisDataGridViewTextBoxColumn"
        Me.DatesemisDataGridViewTextBoxColumn.ReadOnly = True
        Me.DatesemisDataGridViewTextBoxColumn.Width = 87
        '
        'DaterepiquageDataGridViewTextBoxColumn
        '
        Me.DaterepiquageDataGridViewTextBoxColumn.DataPropertyName = "Date_repiquage"
        Me.DaterepiquageDataGridViewTextBoxColumn.HeaderText = "Date_repiquage"
        Me.DaterepiquageDataGridViewTextBoxColumn.Name = "DaterepiquageDataGridViewTextBoxColumn"
        Me.DaterepiquageDataGridViewTextBoxColumn.ReadOnly = True
        Me.DaterepiquageDataGridViewTextBoxColumn.Width = 108
        '
        'QuantitéDataGridViewTextBoxColumn
        '
        Me.QuantitéDataGridViewTextBoxColumn.DataPropertyName = "Quantité"
        Me.QuantitéDataGridViewTextBoxColumn.HeaderText = "Quantité"
        Me.QuantitéDataGridViewTextBoxColumn.Name = "QuantitéDataGridViewTextBoxColumn"
        Me.QuantitéDataGridViewTextBoxColumn.ReadOnly = True
        Me.QuantitéDataGridViewTextBoxColumn.Width = 72
        '
        'DaterécolteDataGridViewTextBoxColumn
        '
        Me.DaterécolteDataGridViewTextBoxColumn.DataPropertyName = "Date_récolte"
        Me.DaterécolteDataGridViewTextBoxColumn.HeaderText = "Date_récolte"
        Me.DaterécolteDataGridViewTextBoxColumn.Name = "DaterécolteDataGridViewTextBoxColumn"
        Me.DaterécolteDataGridViewTextBoxColumn.ReadOnly = True
        Me.DaterécolteDataGridViewTextBoxColumn.Width = 93
        '
        'AnnéeDataGridViewTextBoxColumn
        '
        Me.AnnéeDataGridViewTextBoxColumn.DataPropertyName = "Année"
        Me.AnnéeDataGridViewTextBoxColumn.HeaderText = "Année"
        Me.AnnéeDataGridViewTextBoxColumn.Name = "AnnéeDataGridViewTextBoxColumn"
        Me.AnnéeDataGridViewTextBoxColumn.ReadOnly = True
        Me.AnnéeDataGridViewTextBoxColumn.Width = 63
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(674, 437)
        Me.Controls.Add(Me.Année_text)
        Me.Controls.Add(Me.Fermer)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mon Jardin"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LégumesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JardinDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents JardinDataSet As Mon_jardin.JardinDataSet
    Friend WithEvents LégumesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LégumesTableAdapter As Mon_jardin.JardinDataSetTableAdapters.LégumesTableAdapter
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Fermer As System.Windows.Forms.Button
    Friend WithEvents Année_text As System.Windows.Forms.Label
    Friend WithEvents NomDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DatesemisDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DaterepiquageDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QuantitéDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DaterécolteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AnnéeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
