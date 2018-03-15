Imports System.Data
Imports System.Data.Common
Imports System.Data.OleDb
Imports System.IO
Imports System.DateTime
Imports FluentDate
Imports System.Globalization

Public Class Form1

    Private Sub LégumesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles LégumesBindingNavigatorSaveItem.Click

        LégumesBindingNavigatorSaveItem.Enabled = True
        ToolStripButton1.Enabled = True
        BindingNavigatorDeleteItem.Enabled = True

        Dim resultIndex As Integer = -1
        resultIndex = Liste.FindStringExact(NomTextBox.Text)
        If resultIndex > -1 Then
            ' Found text, do something here
        Else
            ' Did not find text, do something here
            Liste.Items.Add(NomTextBox.Text)
            Liste.Sorted = True
        End If

        Dim r As Integer = 0
        Dim s As Integer = 0
        Dim t As Integer = 0
        If BindingNavigatorAddNewItem.Enabled = False Then
            For Each dr As DataRow In JardinDataSet.Légumes
                If dr.Item("Nom").ToString = (NomTextBox.Text) Then
                    FicheRichTextBox.Text = dr.Item("fiche").ToString
                    r = JardinDataSet.Légumes.Rows.IndexOf(dr)
                    t = 1
                End If
                s = s + 1
            Next
        End If

        NomTextBox.Visible = False
        Liste.Visible = False
        Label2.Visible = False
        ComboBox1.Visible = True
        Annuler.Visible = False
        Supprimer.Visible = False

        Me.Validate()
        Me.LégumesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.JardinDataSet)
        Me.LégumesTableAdapter.Fill(Me.JardinDataSet.Légumes)

        If t > 0 And BindingNavigatorAddNewItem.Enabled = False Then
            JardinDataSet.Légumes.Rows(s).Item("Photo") = JardinDataSet.Légumes.Rows(r).Item("Photo")
        End If

        Me.Validate()
        Me.LégumesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.JardinDataSet)
        Me.LégumesTableAdapter.Fill(Me.JardinDataSet.Légumes)
        BindingNavigatorAddNewItem.Enabled = True

        tri_année()
    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'JardinDataSet.Légumes'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Année.SelectedIndex = 2
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
            Me.LégumesTableAdapter.Fill_2015(Me.JardinDataSet.Légumes)
        End If
        If Année.SelectedItem = 2016 Then
            Me.LégumesTableAdapter.Fill_2016(Me.JardinDataSet.Légumes)
        End If
        If Année.SelectedItem = 2017 Then
            Me.LégumesTableAdapter.Fill_2017(Me.JardinDataSet.Légumes)
        End If
        If Année.SelectedItem = 2018 Then
            Me.LégumesTableAdapter.Fill_2018(Me.JardinDataSet.Légumes)
        End If
        If Année.SelectedItem = 2019 Then
            Me.LégumesTableAdapter.Fill_2019(Me.JardinDataSet.Légumes)
        End If
        If Année.SelectedItem = 2020 Then
            Me.LégumesTableAdapter.Fill_2020(Me.JardinDataSet.Légumes)
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
        'NomTextBox.Select()
        Liste.Select()
        QuantitéNumericUpDown.Value = 0
        JardinDataSet.Légumes.Columns.Item(9).DefaultValue = Année.SelectedItem
        Me.LégumesTableAdapter.Fill(Me.JardinDataSet.Légumes)

        BindingNavigatorAddNewItem.Enabled = False
        LégumesBindingNavigatorSaveItem.Enabled = True
        ToolStripButton1.Enabled = True
        BindingNavigatorDeleteItem.Enabled = False


    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Dim OpenFileDialog1 As New OpenFileDialog
        With OpenFileDialog1

            .CheckFileExists = True
            .ShowReadOnly = False
            .Filter = "All Files|*.*|Bitmap Files (*)|*.bmp;*.gif;*.jpg"
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
        'NomTextBox.Select()
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
