' David Rohweder
' Pokeman project
' Proj start - 6.14.22

Public Class frmMain

    Protected Friend cards As New List(Of Card)

    ' form on load --
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' check data source availability
        checkconnection()

        'populate datatable with init cards
        populateDataGrid("SELECT * FROM Cards;")

    End Sub

    ' connect to internet
    Private Function checkconnection()

        Dim connected As Boolean = True

        If My.Computer.Network.Ping("tcgplayer.com") Then
            lblConnection.Text = "Data Sources Online"
            connected = True
        Else
            MsgBox("No Connection")
            connected = False
        End If

        Return connected

    End Function

    Private Sub RefreshDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshDataToolStripMenuItem.Click

        ' remove previous cards
        cards.Clear()

        'populate datatable
        populateDataGrid("SELECT * FROM Cards;")

    End Sub

    ' populate table with sql query
    Friend Sub populateDataGrid(ByRef query As String)

        cards.Clear()

        ' populate data on field
        Dim sql_query As New SQL(query, "Cards")
        Dim fillTable As DataTable = sql_query.fillTable()

        DataGridView1.DataSource = fillTable

        ' init internal Card class
        For Each row As DataRow In fillTable.Rows
            cards.Add(New Card(row.ItemArray(0), row.ItemArray(1), row.ItemArray(2), row.ItemArray(3), row.ItemArray(4), row.ItemArray(5), row.ItemArray(6), row.ItemArray(7)))
        Next

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        Dim query As String = TextBox1.Text

        If Not query = "" Then

            Dim queryTable As DataTable = New DataTable()

            generateTable(queryTable)

            ' search thru all card items for | query phrase
            For Each card As Card In cards

                If card.name.ToUpper.Contains(query.ToUpper()) Then
                    queryTable.Rows.Add(card.id, card.name, card.rarity, card.type, card.pSet, card.release, card.quanity, card.grade)
                End If

            Next

            If queryTable.Rows.Count = 0 Then
                MsgBox("0 Results Found from search, """ + TextBox1.Text + """")
            Else
                DataGridView1.DataSource = queryTable
            End If

        Else
            MsgBox("Error :: Invalid input - please enter search phrase")

        End If

    End Sub

    Public Sub generateTable(ByRef queryTable As DataTable)

        Dim idColumn As DataColumn = New DataColumn("ID", GetType(Integer))
        Dim nameColumn As DataColumn = New DataColumn("Pokemon", GetType(String))
        Dim rarityColumn As DataColumn = New DataColumn("Rarity", GetType(String))
        Dim typeColumn As DataColumn = New DataColumn("Type", GetType(String))
        Dim setColumn As DataColumn = New DataColumn("Set", GetType(String))
        Dim releaseColumn As DataColumn = New DataColumn("Release", GetType(String))
        Dim quanityColumn As DataColumn = New DataColumn("Quanity", GetType(String))
        Dim gradeColumn As DataColumn = New DataColumn("Grade", GetType(String))

        queryTable.Columns.Add(idColumn)
        queryTable.Columns.Add(nameColumn)
        queryTable.Columns.Add(rarityColumn)
        queryTable.Columns.Add(typeColumn)
        queryTable.Columns.Add(setColumn)
        queryTable.Columns.Add(releaseColumn)
        queryTable.Columns.Add(quanityColumn)
        queryTable.Columns.Add(gradeColumn)

    End Sub

    Private Sub LoadDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoadDataToolStripMenuItem.Click
        frmAddCard.Show()
    End Sub

    Private Sub AdvancedQueryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdvancedQueryToolStripMenuItem.Click
        frmSearch.Show()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        TextBox1.Text = ""
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        populateDataGrid("SELECT * FROM Cards;")
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub EditCardToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditCardToolStripMenuItem.Click
        frmDelete.Show()
    End Sub

    Private Sub AddCardToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddCardToolStripMenuItem.Click
        frmAddCard.Show()
    End Sub

    Private Sub EditCardToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles EditCardToolStripMenuItem1.Click
        frmEdit.Show()
    End Sub

    Private Sub PokemonTraderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PokemonTraderToolStripMenuItem.Click
        MsgBox("TODO")
    End Sub

    Private Sub CardCountToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CardCountToolStripMenuItem.Click
        MsgBox(cards.Count)
    End Sub

    Private Sub CollectionWorthToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CollectionWorthToolStripMenuItem.Click
        MsgBox("TODO")
    End Sub

    Private Sub AddMassToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddMassToolStripMenuItem.Click
        MsgBox("TODO")
    End Sub

End Class