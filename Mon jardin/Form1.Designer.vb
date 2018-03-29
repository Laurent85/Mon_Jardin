<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim IdLabel As System.Windows.Forms.Label
        Dim Date_semisLabel As System.Windows.Forms.Label
        Dim Date_repiquageLabel As System.Windows.Forms.Label
        Dim QuantitéLabel As System.Windows.Forms.Label
        Dim Date_récolteLabel As System.Windows.Forms.Label
        Dim ObservationsLabel As System.Windows.Forms.Label
        Dim AnnéeLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.LégumesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.JardinDataSet = New Mon_jardin.JardinDataSet()
        Me.LégumesBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.LégumesBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.NomTextBox = New System.Windows.Forms.TextBox()
        Me.PhotoPictureBox = New System.Windows.Forms.PictureBox()
        Me.FicheRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.Date_semisDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Date_repiquageDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.QuantitéNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.Date_récolteDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Modifier = New System.Windows.Forms.Button()
        Me.ObservationsRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.LégumesTableAdapter = New Mon_jardin.JardinDataSetTableAdapters.LégumesTableAdapter()
        Me.TableAdapterManager = New Mon_jardin.JardinDataSetTableAdapters.TableAdapterManager()
        Me.Année = New System.Windows.Forms.ComboBox()
        Me.AnnéeComboBox = New System.Windows.Forms.ComboBox()
        Me.Liste = New System.Windows.Forms.ComboBox()
        Me.Annuler = New System.Windows.Forms.Button()
        Me.Supprimer = New System.Windows.Forms.Button()
        Me.Bilan = New System.Windows.Forms.Button()
        IdLabel = New System.Windows.Forms.Label()
        Date_semisLabel = New System.Windows.Forms.Label()
        Date_repiquageLabel = New System.Windows.Forms.Label()
        QuantitéLabel = New System.Windows.Forms.Label()
        Date_récolteLabel = New System.Windows.Forms.Label()
        ObservationsLabel = New System.Windows.Forms.Label()
        AnnéeLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        CType(Me.LégumesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JardinDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LégumesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LégumesBindingNavigator.SuspendLayout()
        CType(Me.PhotoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuantitéNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Location = New System.Drawing.Point(493, 35)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(19, 13)
        IdLabel.TabIndex = 1
        IdLabel.Text = "Id:"
        IdLabel.Visible = False
        '
        'Date_semisLabel
        '
        Date_semisLabel.AutoSize = True
        Date_semisLabel.ForeColor = System.Drawing.Color.Green
        Date_semisLabel.Location = New System.Drawing.Point(39, 172)
        Date_semisLabel.Name = "Date_semisLabel"
        Date_semisLabel.Size = New System.Drawing.Size(62, 13)
        Date_semisLabel.TabIndex = 9
        Date_semisLabel.Text = "Date semis:"
        '
        'Date_repiquageLabel
        '
        Date_repiquageLabel.AutoSize = True
        Date_repiquageLabel.ForeColor = System.Drawing.Color.Green
        Date_repiquageLabel.Location = New System.Drawing.Point(39, 227)
        Date_repiquageLabel.Name = "Date_repiquageLabel"
        Date_repiquageLabel.Size = New System.Drawing.Size(83, 13)
        Date_repiquageLabel.TabIndex = 11
        Date_repiquageLabel.Text = "Date repiquage:"
        '
        'QuantitéLabel
        '
        QuantitéLabel.AutoSize = True
        QuantitéLabel.ForeColor = System.Drawing.Color.Green
        QuantitéLabel.Location = New System.Drawing.Point(39, 279)
        QuantitéLabel.Name = "QuantitéLabel"
        QuantitéLabel.Size = New System.Drawing.Size(50, 13)
        QuantitéLabel.TabIndex = 13
        QuantitéLabel.Text = "Quantité:"
        '
        'Date_récolteLabel
        '
        Date_récolteLabel.AutoSize = True
        Date_récolteLabel.ForeColor = System.Drawing.Color.Green
        Date_récolteLabel.Location = New System.Drawing.Point(39, 334)
        Date_récolteLabel.Name = "Date_récolteLabel"
        Date_récolteLabel.Size = New System.Drawing.Size(68, 13)
        Date_récolteLabel.TabIndex = 15
        Date_récolteLabel.Text = "Date récolte:"
        '
        'ObservationsLabel
        '
        ObservationsLabel.AutoSize = True
        ObservationsLabel.ForeColor = System.Drawing.Color.Green
        ObservationsLabel.Location = New System.Drawing.Point(155, 381)
        ObservationsLabel.Name = "ObservationsLabel"
        ObservationsLabel.Size = New System.Drawing.Size(69, 13)
        ObservationsLabel.TabIndex = 24
        ObservationsLabel.Text = "Observations"
        '
        'AnnéeLabel
        '
        AnnéeLabel.AutoSize = True
        AnnéeLabel.ForeColor = System.Drawing.Color.Green
        AnnéeLabel.Location = New System.Drawing.Point(214, 279)
        AnnéeLabel.Name = "AnnéeLabel"
        AnnéeLabel.Size = New System.Drawing.Size(41, 13)
        AnnéeLabel.TabIndex = 29
        AnnéeLabel.Text = "Année:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.ForeColor = System.Drawing.Color.Blue
        Label1.Location = New System.Drawing.Point(357, 15)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(70, 13)
        Label1.TabIndex = 36
        Label1.Text = "Choix Année:"
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
        'LégumesBindingNavigator
        '
        Me.LégumesBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.LégumesBindingNavigator.BindingSource = Me.LégumesBindingSource
        Me.LégumesBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.LégumesBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.LégumesBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ToolStripButton1, Me.LégumesBindingNavigatorSaveItem})
        Me.LégumesBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.LégumesBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.LégumesBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.LégumesBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.LégumesBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.LégumesBindingNavigator.Name = "LégumesBindingNavigator"
        Me.LégumesBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.LégumesBindingNavigator.Size = New System.Drawing.Size(962, 25)
        Me.LégumesBindingNavigator.TabIndex = 0
        Me.LégumesBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Ajouter nouveau"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Nombre total d'éléments"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Supprimer"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Placer en premier"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Déplacer vers le haut"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.BackColor = System.Drawing.Color.AliceBlue
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Position actuelle"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Déplacer vers le bas"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Placer en dernier"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'LégumesBindingNavigatorSaveItem
        '
        Me.LégumesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.LégumesBindingNavigatorSaveItem.Image = CType(resources.GetObject("LégumesBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.LégumesBindingNavigatorSaveItem.Name = "LégumesBindingNavigatorSaveItem"
        Me.LégumesBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.LégumesBindingNavigatorSaveItem.Text = "Enregistrer les données"
        '
        'IdTextBox
        '
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LégumesBindingSource, "Id", True))
        Me.IdTextBox.Location = New System.Drawing.Point(531, 28)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.Size = New System.Drawing.Size(53, 20)
        Me.IdTextBox.TabIndex = 2
        Me.IdTextBox.Visible = False
        '
        'NomTextBox
        '
        Me.NomTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.NomTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LégumesBindingSource, "Nom", True))
        Me.NomTextBox.Location = New System.Drawing.Point(128, 113)
        Me.NomTextBox.Name = "NomTextBox"
        Me.NomTextBox.Size = New System.Drawing.Size(200, 20)
        Me.NomTextBox.TabIndex = 4
        '
        'PhotoPictureBox
        '
        Me.PhotoPictureBox.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.LégumesBindingSource, "Photo", True))
        Me.PhotoPictureBox.Location = New System.Drawing.Point(770, 28)
        Me.PhotoPictureBox.Name = "PhotoPictureBox"
        Me.PhotoPictureBox.Size = New System.Drawing.Size(180, 134)
        Me.PhotoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PhotoPictureBox.TabIndex = 6
        Me.PhotoPictureBox.TabStop = False
        '
        'FicheRichTextBox
        '
        Me.FicheRichTextBox.BackColor = System.Drawing.Color.LemonChiffon
        Me.FicheRichTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LégumesBindingSource, "Fiche", True))
        Me.FicheRichTextBox.Location = New System.Drawing.Point(399, 168)
        Me.FicheRichTextBox.Name = "FicheRichTextBox"
        Me.FicheRichTextBox.Size = New System.Drawing.Size(551, 394)
        Me.FicheRichTextBox.TabIndex = 8
        Me.FicheRichTextBox.Text = ""
        '
        'Date_semisDateTimePicker
        '
        Me.Date_semisDateTimePicker.CalendarMonthBackground = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Date_semisDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.LégumesBindingSource, "Date_semis", True))
        Me.Date_semisDateTimePicker.Location = New System.Drawing.Point(128, 168)
        Me.Date_semisDateTimePicker.Name = "Date_semisDateTimePicker"
        Me.Date_semisDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Date_semisDateTimePicker.TabIndex = 10
        '
        'Date_repiquageDateTimePicker
        '
        Me.Date_repiquageDateTimePicker.CalendarMonthBackground = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Date_repiquageDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.LégumesBindingSource, "Date_repiquage", True))
        Me.Date_repiquageDateTimePicker.Location = New System.Drawing.Point(128, 223)
        Me.Date_repiquageDateTimePicker.Name = "Date_repiquageDateTimePicker"
        Me.Date_repiquageDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Date_repiquageDateTimePicker.TabIndex = 12
        '
        'QuantitéNumericUpDown
        '
        Me.QuantitéNumericUpDown.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.QuantitéNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.LégumesBindingSource, "Quantité", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0", "N0"))
        Me.QuantitéNumericUpDown.Location = New System.Drawing.Point(128, 277)
        Me.QuantitéNumericUpDown.Maximum = New Decimal(New Integer() {900, 0, 0, 0})
        Me.QuantitéNumericUpDown.Name = "QuantitéNumericUpDown"
        Me.QuantitéNumericUpDown.Size = New System.Drawing.Size(53, 20)
        Me.QuantitéNumericUpDown.TabIndex = 14
        Me.QuantitéNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Date_récolteDateTimePicker
        '
        Me.Date_récolteDateTimePicker.CalendarMonthBackground = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Date_récolteDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.LégumesBindingSource, "Date_récolte", True))
        Me.Date_récolteDateTimePicker.Location = New System.Drawing.Point(128, 330)
        Me.Date_récolteDateTimePicker.Name = "Date_récolteDateTimePicker"
        Me.Date_récolteDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Date_récolteDateTimePicker.TabIndex = 16
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.Color.AliceBlue
        Me.ComboBox1.DataSource = Me.LégumesBindingSource
        Me.ComboBox1.DisplayMember = "Nom"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(64, 55)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(155, 21)
        Me.ComboBox1.TabIndex = 18
        Me.ComboBox1.ValueMember = "Id"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LégumesBindingSource, "Date_semis", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "D"))
        Me.TextBox1.Location = New System.Drawing.Point(128, 168)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(161, 20)
        Me.TextBox1.TabIndex = 20
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LégumesBindingSource, "Date_repiquage", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "D"))
        Me.TextBox2.Location = New System.Drawing.Point(128, 223)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(161, 20)
        Me.TextBox2.TabIndex = 21
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LégumesBindingSource, "Date_récolte", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "D"))
        Me.TextBox3.Location = New System.Drawing.Point(128, 330)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(161, 20)
        Me.TextBox3.TabIndex = 22
        Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(166, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 13)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Entrez le nom du légume"
        '
        'Modifier
        '
        Me.Modifier.Location = New System.Drawing.Point(235, 52)
        Me.Modifier.Name = "Modifier"
        Me.Modifier.Size = New System.Drawing.Size(93, 24)
        Me.Modifier.TabIndex = 24
        Me.Modifier.Text = "Modifier le nom"
        Me.Modifier.UseVisualStyleBackColor = True
        '
        'ObservationsRichTextBox
        '
        Me.ObservationsRichTextBox.BackColor = System.Drawing.Color.LemonChiffon
        Me.ObservationsRichTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LégumesBindingSource, "Observations", True))
        Me.ObservationsRichTextBox.Location = New System.Drawing.Point(12, 397)
        Me.ObservationsRichTextBox.Name = "ObservationsRichTextBox"
        Me.ObservationsRichTextBox.Size = New System.Drawing.Size(370, 165)
        Me.ObservationsRichTextBox.TabIndex = 25
        Me.ObservationsRichTextBox.Text = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Green
        Me.Label3.Location = New System.Drawing.Point(400, 145)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(123, 17)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Fiche technique"
        '
        'TextBox4
        '
        Me.TextBox4.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LégumesBindingSource, "Nom", True))
        Me.TextBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.ForeColor = System.Drawing.Color.RoyalBlue
        Me.TextBox4.Location = New System.Drawing.Point(399, 88)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(348, 25)
        Me.TextBox4.TabIndex = 27
        '
        'LégumesTableAdapter
        '
        Me.LégumesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.LégumesTableAdapter = Me.LégumesTableAdapter
        Me.TableAdapterManager.UpdateOrder = Mon_jardin.JardinDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Année
        '
        Me.Année.BackColor = System.Drawing.Color.AliceBlue
        Me.Année.ForeColor = System.Drawing.Color.Black
        Me.Année.FormattingEnabled = True
        Me.Année.Items.AddRange(New Object() {"2015", "2016", "2017", "2018", "2019", "2020"})
        Me.Année.Location = New System.Drawing.Point(433, 12)
        Me.Année.Name = "Année"
        Me.Année.Size = New System.Drawing.Size(67, 21)
        Me.Année.TabIndex = 29
        '
        'AnnéeComboBox
        '
        Me.AnnéeComboBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.AnnéeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LégumesBindingSource, "Année", True))
        Me.AnnéeComboBox.FormattingEnabled = True
        Me.AnnéeComboBox.Items.AddRange(New Object() {"2015", "2016", "2017", "2018", "2019", "2020"})
        Me.AnnéeComboBox.Location = New System.Drawing.Point(261, 276)
        Me.AnnéeComboBox.Name = "AnnéeComboBox"
        Me.AnnéeComboBox.Size = New System.Drawing.Size(67, 21)
        Me.AnnéeComboBox.TabIndex = 30
        '
        'Liste
        '
        Me.Liste.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Liste.FormattingEnabled = True
        Me.Liste.Items.AddRange(New Object() {"Ail", "Basilic", "Betterave", "Brocoli", "Carotte", "Celeri", "Chou Fleur", "Ciboulette", "Concombre", "Courgette", "Echalotte", "Epinard", "Estragon", "Fraise", "Haricot Blanc", "Laitue", "Mache", "Melon", "Navet", "Oignon", "Patate", "Persil", "Petit Pois", "Poireau", "Poivron", "Radis", "Tomate", "Tomate cerise"})
        Me.Liste.Location = New System.Drawing.Point(128, 113)
        Me.Liste.Name = "Liste"
        Me.Liste.Size = New System.Drawing.Size(200, 21)
        Me.Liste.TabIndex = 31
        '
        'Annuler
        '
        Me.Annuler.Location = New System.Drawing.Point(42, 111)
        Me.Annuler.Name = "Annuler"
        Me.Annuler.Size = New System.Drawing.Size(75, 23)
        Me.Annuler.TabIndex = 32
        Me.Annuler.Text = "Annuler"
        Me.Annuler.UseVisualStyleBackColor = True
        '
        'Supprimer
        '
        Me.Supprimer.Location = New System.Drawing.Point(139, 71)
        Me.Supprimer.Name = "Supprimer"
        Me.Supprimer.Size = New System.Drawing.Size(174, 23)
        Me.Supprimer.TabIndex = 33
        Me.Supprimer.Text = "Supprimer ce légume de la liste"
        Me.Supprimer.UseVisualStyleBackColor = True
        '
        'Bilan
        '
        Me.Bilan.Location = New System.Drawing.Point(181, 568)
        Me.Bilan.Name = "Bilan"
        Me.Bilan.Size = New System.Drawing.Size(78, 23)
        Me.Bilan.TabIndex = 37
        Me.Bilan.Text = "Bilan"
        Me.Bilan.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(962, 603)
        Me.Controls.Add(Me.Bilan)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.Supprimer)
        Me.Controls.Add(Me.Annuler)
        Me.Controls.Add(Me.Liste)
        Me.Controls.Add(AnnéeLabel)
        Me.Controls.Add(Me.AnnéeComboBox)
        Me.Controls.Add(Me.Année)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(ObservationsLabel)
        Me.Controls.Add(Me.ObservationsRichTextBox)
        Me.Controls.Add(Me.Modifier)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(IdLabel)
        Me.Controls.Add(Me.IdTextBox)
        Me.Controls.Add(Me.NomTextBox)
        Me.Controls.Add(Me.PhotoPictureBox)
        Me.Controls.Add(Me.FicheRichTextBox)
        Me.Controls.Add(Date_semisLabel)
        Me.Controls.Add(Me.Date_semisDateTimePicker)
        Me.Controls.Add(Date_repiquageLabel)
        Me.Controls.Add(Me.Date_repiquageDateTimePicker)
        Me.Controls.Add(QuantitéLabel)
        Me.Controls.Add(Me.QuantitéNumericUpDown)
        Me.Controls.Add(Date_récolteLabel)
        Me.Controls.Add(Me.Date_récolteDateTimePicker)
        Me.Controls.Add(Me.LégumesBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mon jardin"
        CType(Me.LégumesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JardinDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LégumesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LégumesBindingNavigator.ResumeLayout(False)
        Me.LégumesBindingNavigator.PerformLayout()
        CType(Me.PhotoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuantitéNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents JardinDataSet As Mon_jardin.JardinDataSet
    Friend WithEvents LégumesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LégumesTableAdapter As Mon_jardin.JardinDataSetTableAdapters.LégumesTableAdapter
    Friend WithEvents TableAdapterManager As Mon_jardin.JardinDataSetTableAdapters.TableAdapterManager
    Friend WithEvents LégumesBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents LégumesBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents IdTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NomTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PhotoPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents FicheRichTextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents Date_semisDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Date_repiquageDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents QuantitéNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents Date_récolteDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents Modifier As System.Windows.Forms.Button
    Friend WithEvents ObservationsRichTextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Année As System.Windows.Forms.ComboBox
    Friend WithEvents AnnéeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Liste As System.Windows.Forms.ComboBox
    Friend WithEvents Annuler As System.Windows.Forms.Button
    Friend WithEvents Supprimer As System.Windows.Forms.Button
    Friend WithEvents Bilan As System.Windows.Forms.Button
End Class
