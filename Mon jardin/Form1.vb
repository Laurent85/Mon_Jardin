Imports System.IO

Public Class Form1

    Private Sub OuvertureLogiciel(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'JardinDataSet.Légumes'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Année.SelectedItem = Date.Today.Year.ToString
        FctTriAnnée()
        NomTextBox.Visible = False
        CmbListe.Visible = False
        LblNomLégume.Visible = False
        CmbChoixLégume.Visible = True
        BtnAnnulerAjout.Visible = False
        BtnSupprimerLégumeListe.Visible = False
        CmbListe.Sorted = True
    End Sub

    Private Sub BtnAjouter(sender As Object, e As EventArgs) Handles BtnAjouterLégume.Click
        NomTextBox.Visible = False
        CmbListe.Visible = True
        LblNomLégume.Visible = True
        CmbChoixLégume.Visible = False
        BtnAnnulerAjout.Visible = True
        BtnModifier.Visible = False
        BtnSupprimerLégumeListe.Visible = True
        CmbListe.Select()
        QuantitéNumericUpDown.Value = 0
        JardinDataSet.Légumes.Columns.Item(9).DefaultValue = Année.SelectedItem
        LégumesTableAdapter.Fill(JardinDataSet.Légumes)

        BtnAjouterLégume.Enabled = False
        BtnEnregistrerLégume.Enabled = True
        BtnPhoto.Enabled = True
        BtnSupprimerLégume.Enabled = False

    End Sub

    Private Sub BtnChangerPhoto(sender As Object, e As EventArgs) Handles BtnPhoto.Click
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

    Private Sub BtnEnregistrer(sender As Object, e As EventArgs) Handles BtnEnregistrerLégume.Click

        BtnEnregistrerLégume.Enabled = True
        BtnPhoto.Enabled = True
        BtnSupprimerLégume.Enabled = True

        Dim resultIndex As Integer
        resultIndex = CmbListe.FindStringExact(NomTextBox.Text)
        If resultIndex > -1 Then
        Else
            CmbListe.Items.Add(NomTextBox.Text)
            CmbListe.Sorted = True
        End If

        Dim numéroLigne As Integer = 0
        Dim flag As Integer = 0
        If BtnAjouterLégume.Enabled = False Then
            For Each dr As DataRow In JardinDataSet.Légumes
                If (dr("Nom").ToString = (NomTextBox.Text.ToString)) And flag < 1 Then
                    FicheRichTextBox.Text = dr.Item("fiche").ToString
                    numéroLigne = JardinDataSet.Légumes.Rows.IndexOf(dr)
                    flag = 1
                End If
            Next dr
        End If

        If flag > 0 And BtnAjouterLégume.Enabled = False Then
            Dim photo() As Byte = JardinDataSet.Légumes.Rows(numéroLigne).Item("Photo")
            Dim copiePhoto As New MemoryStream(photo)
            PhotoPictureBox.Image = Image.FromStream(copiePhoto)
            NomTextBox.Visible = False
        End If

        CmbListe.Visible = False
        LblNomLégume.Visible = False
        CmbChoixLégume.Visible = True
        BtnAnnulerAjout.Visible = False
        BtnSupprimerLégumeListe.Visible = False

        Validate()
        LégumesBindingSource.EndEdit()
        TableAdapterManager.UpdateAll(JardinDataSet)
        LégumesTableAdapter.Fill(JardinDataSet.Légumes)
        BtnAjouterLégume.Enabled = True

        FctTriAnnée()
    End Sub

    Private Sub BtnSupprimer(sender As Object, e As EventArgs) Handles BtnSupprimerLégumeListe.Click
        CmbListe.Items.Remove(CmbListe.SelectedItem)
        CmbListe.Sorted = True
        FctTriAnnée()
        NomTextBox.Visible = False
        CmbListe.Visible = False
        LblNomLégume.Visible = False
        CmbChoixLégume.Visible = True
        BtnAnnulerAjout.Visible = False
        BtnSupprimerLégumeListe.Visible = False
        BtnAjouterLégume.Enabled = True
        BtnEnregistrerLégume.Enabled = True
        BtnPhoto.Enabled = True
        BtnSupprimerLégume.Enabled = True
    End Sub

    Private Sub BtnModifierLeNom(sender As Object, e As EventArgs) Handles BtnModifier.Click
        NomTextBox.Visible = False
        CmbListe.Visible = True
        LblNomLégume.Visible = True
        CmbChoixLégume.Visible = False
        CmbListe.Select()
        BtnAnnulerAjout.Visible = True
    End Sub

    Private Sub BtnAnnuler(sender As Object, e As EventArgs) Handles BtnAnnulerAjout.Click
        FctTriAnnée()
        NomTextBox.Visible = False
        CmbListe.Visible = False
        LblNomLégume.Visible = False
        CmbChoixLégume.Visible = True
        BtnAnnulerAjout.Visible = False
        BtnSupprimerLégumeListe.Visible = False
        BtnAjouterLégume.Enabled = True
        BtnEnregistrerLégume.Enabled = True
        BtnPhoto.Enabled = True
        BtnSupprimerLégume.Enabled = True
    End Sub

    Private Sub BtnBilan(sender As Object, e As EventArgs) Handles Bilan.Click
        Form2.Show()

    End Sub

    Private Sub CmbChoixAnnée(sender As Object, e As EventArgs) Handles Année.SelectedIndexChanged
        FctTriAnnée()
        AnnéeComboBox.SelectedItem = Année.SelectedItem
    End Sub

    Private Sub CmbAjouter(sender As Object, e As EventArgs) Handles CmbListe.SelectedIndexChanged, CmbListe.TextChanged
        NomTextBox.Text = CmbListe.Text
        If CmbListe.Text = "" Then
            BtnAjouterLégume.Enabled = False
            BtnEnregistrerLégume.Enabled = False
            BtnPhoto.Enabled = False
            BtnSupprimerLégume.Enabled = False
        Else
            BtnEnregistrerLégume.Enabled = True
            BtnPhoto.Enabled = True
        End If

    End Sub

    Private Sub CmbDateSemis(sender As Object, e As EventArgs) Handles Date_semisDateTimePicker.ValueChanged
        TextBox1.Text = Date_semisDateTimePicker.Text
        REM If TextBox2.Text = "" Then
        REM    TextBox2.Text = Date_semisDateTimePicker.Value.AddDays(25).ToString("dddd dd MMMM yyyy", CultureInfo.CreateSpecificCulture("fr-FR"))
        REM End If
    End Sub

    Private Sub CmbDateRepiquage(sender As Object, e As EventArgs) Handles Date_repiquageDateTimePicker.ValueChanged
        TextBox2.Text = Date_repiquageDateTimePicker.Text
        REM Label4.Text = Date_repiquageDateTimePicker.Value.AddDays(25).ToString()
    End Sub

    Private Sub CmbDateRécolte(sender As Object, e As EventArgs) Handles Date_récolteDateTimePicker.ValueChanged
        TextBox3.Text = Date_récolteDateTimePicker.Text
    End Sub

    Sub FctTriAnnée()
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

End Class