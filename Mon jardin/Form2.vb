Public Class Form2

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'JardinDataSet.Légumes'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        If Form1.Année.SelectedItem = 2015 Then
            Me.LégumesTableAdapter.Fill_2015(Me.JardinDataSet.Légumes)
        End If
        If Form1.Année.SelectedItem = 2016 Then
            Me.LégumesTableAdapter.Fill_2016(Me.JardinDataSet.Légumes)
        End If
        If Form1.Année.SelectedItem = 2017 Then
            Me.LégumesTableAdapter.Fill_2017(Me.JardinDataSet.Légumes)
        End If
        If Form1.Année.SelectedItem = 2018 Then
            Me.LégumesTableAdapter.Fill_2018(Me.JardinDataSet.Légumes)
        End If
        If Form1.Année.SelectedItem = 2019 Then
            Me.LégumesTableAdapter.Fill_2019(Me.JardinDataSet.Légumes)
        End If
        If Form1.Année.SelectedItem = 2020 Then
            Me.LégumesTableAdapter.Fill_2020(Me.JardinDataSet.Légumes)
        End If

        Année_text.Text = Form1.Année.SelectedItem
        DataGridView1.Sort(DataGridView1.Columns(1), System.ComponentModel.ListSortDirection.Ascending)

    End Sub

    Private Sub Fermer_Click(sender As Object, e As EventArgs) Handles Fermer.Click
        Me.Close()
    End Sub

    Private Sub DataGridView1_SelectionChanged(sender As Object, e As System.EventArgs) Handles DataGridView1.SelectionChanged
        DataGridView1.ClearSelection()
    End Sub

End Class