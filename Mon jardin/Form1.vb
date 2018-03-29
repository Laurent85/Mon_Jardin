Imports System.IO

Public Class Form1

    Private Sub LégumesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles LégumesBindingNavigatorSaveItem.Click

        LégumesBindingNavigatorSaveItem.Enabled = True
        ToolStripButton1.Enabled = True
        BindingNavigatorDeleteItem.Enabled = True

        Dim resultIndex As Integer
        resultIndex = Liste.FindStringExact(NomTextBox.Text)
        If resultIndex > -1 Then
        Else
            Liste.Items.Add(NomTextBox.Text)
            Liste.Sorted = True
        End If

        Dim numéroLigne As Integer = 0
        Dim flag As Integer = 0
        If BindingNavigatorAddNewItem.Enabled = False Then
            For Each dr As DataRow In JardinDataSet.Légumes
                If (dr("Nom").ToString = (NomTextBox.Text.ToString)) And flag < 1 Then
                    FicheRichTextBox.Text = dr.Item("fiche").ToString
                    numéroLigne = JardinDataSet.Légumes.Rows.IndexOf(dr)
                    flag = 1
                End If
            Next dr
        End If

        If flag > 0 And BindingNavigatorAddNewItem.Enabled = False Then
            Dim photo() As Byte = JardinDataSet.Légumes.Rows(numéroLigne).Item("Photo")
            Dim copiePhoto As New MemoryStream(photo)
            PhotoPictureBox.Image = Image.FromStream(copiePhoto)

            NomTextBox.Visible = False
        End If

        Liste.Visible = False
        Label2.Visible = False
        ComboBox1.Visible = True
        Annuler.Visible = False
        Supprimer.Visible = False

        Validate()
        LégumesBindingSource.EndEdit()
        TableAdapterManager.UpdateAll(JardinDataSet)
        LégumesTableAdapter.Fill(JardinDataSet.Légumes)
        BindingNavigatorAddNewItem.Enabled = True

        tri_année()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'JardinDataSet.Légumes'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Année.SelectedItem = Date.Today.Year.ToString
        tri_année()
        NomTextBox.Visible = False
        Liste.Visible = False
        Label2.Visible = False
        ComboBox1.Visible = True
        Annuler.Visible = False
        Supprimer.Visible = False
        Liste.Sorted = True
    End Sub

    Sub tri_année()
        If Année.SelectedItem = 2015 Then
            LégumesTableAdapter.Fill_2015(JardinDataSet.Légumes)
        End If
        If Année.SelectedItem = 2016 Then
            LégumesTableAdapter.Fill_2016(JardinDataSet.Légumes)
        End If
        If Année.SelectedItem = 2017 Then
            LégumesTableAdapter.Fill_2017(JardinDataSet.Légumes)
        End If
        If Année.SelectedItem = 2018 Then
            LégumesTableAdapter.Fill_2018(JardinDataSet.Légumes)
        End If
        If Année.SelectedItem = 2019 Then
            LégumesTableAdapter.Fill_2019(JardinDataSet.Légumes)
        End If
        If Année.SelectedItem = 2020 Then
            LégumesTableAdapter.Fill_2020(JardinDataSet.Légumes)
        End If
    End Sub

    Private Sub Date_semisDateTimePicker_ValueChanged(sender As Object, e As EventArgs) Handles Date_semisDateTimePicker.ValueChanged
        TextBox1.Text = Date_semisDateTimePicker.Text
        REM If TextBox2.Text = "" Then
        REM    TextBox2.Text = Date_semisDateTimePicker.Value.AddDays(25).ToString("dddd dd MMMM yyyy", CultureInfo.CreateSpecificCulture("fr-FR"))
        REM End If
    End Sub

    Private Sub Date_repiquageDateTimePicker_ValueChanged(sender As Object, e As EventArgs) Handles Date_repiquageDateTimePicker.ValueChanged
        TextBox2.Text = Date_repiquageDateTimePicker.Text
        REM Label4.Text = Date_repiquageDateTimePicker.Value.AddDays(25).ToString()
    End Sub

    Private Sub Date_récolteDateTimePicker_ValueChanged(sender As Object, e As EventArgs) Handles Date_récolteDateTimePicker.ValueChanged
        TextBox3.Text = Date_récolteDateTimePicker.Text
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click
        NomTextBox.Visible = False
        Liste.Visible = True
        Label2.Visible = True
        ComboBox1.Visible = False
        Annuler.Visible = True
        Modifier.Visible = False
        Supprimer.Visible = True
        Liste.Select()
        QuantitéNumericUpDown.Value = 0
        JardinDataSet.Légumes.Columns.Item(9).DefaultValue = Année.SelectedItem
        LégumesTableAdapter.Fill(JardinDataSet.Légumes)

        BindingNavigatorAddNewItem.Enabled = False
        LégumesBindingNavigatorSaveItem.Enabled = True
        ToolStripButton1.Enabled = True
        BindingNavigatorDeleteItem.Enabled = False

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Dim openFileDialog1 As New OpenFileDialog
        With openFileDialog1

            .CheckFileExists = True
            .ShowReadOnly = False
            .Filter = "All Files|*.*|Bitmap Files (*)|*.bmp;*.gif;*.jpg;*.png"
            .FilterIndex = 2

            If .ShowDialog = DialogResult.OK Then

                ' Load the specified file into a PictureBox control.
                PhotoPictureBox.Image = Image.FromFile(.FileName)

            End If
        End With
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Modifier.Click
        NomTextBox.Visible = False
        Liste.Visible = True
        Label2.Visible = True
        ComboBox1.Visible = False
        Liste.Select()
        Annuler.Visible = True
    End Sub

    Private Sub Année_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Année.SelectedIndexChanged
        tri_année()
        AnnéeComboBox.SelectedItem = Année.SelectedItem
    End Sub

    Private Sub Liste_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Liste.SelectedIndexChanged
        NomTextBox.Text = Liste.Text
        If Liste.Text = "" Then
            BindingNavigatorAddNewItem.Enabled = False
            LégumesBindingNavigatorSaveItem.Enabled = False
            ToolStripButton1.Enabled = False
            BindingNavigatorDeleteItem.Enabled = False
        Else
            LégumesBindingNavigatorSaveItem.Enabled = True
            ToolStripButton1.Enabled = True
        End If

    End Sub

    Private Sub Liste_SelectedTextChanged(sender As Object, e As EventArgs) Handles Liste.TextChanged
        NomTextBox.Text = Liste.Text
        If Liste.Text = "" Then
            BindingNavigatorAddNewItem.Enabled = False
            LégumesBindingNavigatorSaveItem.Enabled = False
            ToolStripButton1.Enabled = False
            BindingNavigatorDeleteItem.Enabled = False
        Else
            LégumesBindingNavigatorSaveItem.Enabled = True
            ToolStripButton1.Enabled = True
        End If

    End Sub

    Private Sub Annuler_Click(sender As Object, e As EventArgs) Handles Annuler.Click
        tri_année()
        NomTextBox.Visible = False
        Liste.Visible = False
        Label2.Visible = False
        ComboBox1.Visible = True
        Annuler.Visible = False
        Supprimer.Visible = False
        BindingNavigatorAddNewItem.Enabled = True
        LégumesBindingNavigatorSaveItem.Enabled = True
        ToolStripButton1.Enabled = True
        BindingNavigatorDeleteItem.Enabled = True
    End Sub

    Private Sub Supprimer_Click(sender As Object, e As EventArgs) Handles Supprimer.Click
        Liste.Items.Remove(Liste.SelectedItem)
        Liste.Sorted = True
        tri_année()
        NomTextBox.Visible = False
        Liste.Visible = False
        Label2.Visible = False
        ComboBox1.Visible = True
        Annuler.Visible = False
        Supprimer.Visible = False
        BindingNavigatorAddNewItem.Enabled = True
        LégumesBindingNavigatorSaveItem.Enabled = True
        ToolStripButton1.Enabled = True
        BindingNavigatorDeleteItem.Enabled = True
    End Sub

    Private Sub Bilan_Click(sender As Object, e As EventArgs) Handles Bilan.Click
        Form2.Show()

    End Sub

End Class