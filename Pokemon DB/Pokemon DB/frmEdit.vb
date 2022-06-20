Public Class frmEdit

    Private instance_id As Integer

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click

        Dim found_id As Boolean

        For Each card As Card In frmMain.cards
            If card.id = txtid.Text Then
                found_id = True
                grpControl.Show()
                initCbo()
                instance_id = card.id
                txtName.Text = card.name
                txtRelease.Text = card.release
                cboRarity.Text = card.rarity
                cboType.Text = card.type
                cboSet.Text = card.pSet
                pkrQuanity.Value = card.quanity
                cboGrade.Text = card.grade
                Exit For
            End If
        Next

        If found_id = False Then
            MsgBox("Error - id {" & txtid.Text & "} not found!")
        End If

    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        Try
            Dim query As String = "UPDATE Cards SET Pokemon = '" & txtName.Text & "', Rarity = '" & cboRarity.Text & "', Type = '" & cboType.Text & "', [Set] = '" & cboSet.Text & "', [Release Date] = '" & txtRelease.Text & "', Quanity = '" & pkrQuanity.Value & "', Grade = '" & cboGrade.Text & "' WHERE id = " & instance_id & ";"
            Dim sql_query As New SQL(query, "Cards")
            Dim result As String = sql_query.nonQuery(10)

            lblResult.Text = result
            frmMain.populateDataGrid("SELECT * FROM Cards;")
        Catch ex As Exception
            MsgBox("Error - " & ex.Message)
        End Try


    End Sub

    Private Sub frmEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grpControl.Hide()
    End Sub

    Public Sub initCbo()

        cboRarity.Items.Clear()
        cboType.Items.Clear()
        cboSet.Items.Clear()

        ' load rarity, type, and sets
        Dim sql_query As New SQL("SELECT * FROM Rarity", "Rarity")
        Dim fillTable As DataTable = sql_query.fillTable()

        For Each row As DataRow In fillTable.Rows
            cboRarity.Items.Add(row.ItemArray(1))
        Next

        sql_query.setTable("Types")
        sql_query.setQuery("SELECT * FROM Types")
        fillTable = sql_query.fillTable()

        For Each row As DataRow In fillTable.Rows
            cboType.Items.Add(row.ItemArray(1))
        Next

        sql_query.setTable("Sets")
        sql_query.setQuery("SELECT * FROM Sets")
        fillTable = sql_query.fillTable()

        For Each row As DataRow In fillTable.Rows
            cboSet.Items.Add(row.ItemArray(1))
        Next

    End Sub

End Class