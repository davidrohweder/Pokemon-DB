' David Rohweder -> Ryan Phillips
' Pokeman project
' Proj start - 6.14.22

Public Class frmMain

    Dim cards As New List(Of Card)

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
            cards.Add(New Card(row.ItemArray(1), row.ItemArray(2), row.ItemArray(3), row.ItemArray(4), row.ItemArray(5)))
        Next

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        Dim query As String = TextBox1.Text

        If Not query = "" Then

            Dim queryTable As DataTable = New DataTable()

            Dim nameColumn As DataColumn = New DataColumn("Name", GetType(String))
            Dim rarityColumn As DataColumn = New DataColumn("Rarity", GetType(String))
            Dim typeColumn As DataColumn = New DataColumn("Type", GetType(String))
            Dim setColumn As DataColumn = New DataColumn("Set", GetType(String))
            Dim releaseColumn As DataColumn = New DataColumn("Release", GetType(String))

            queryTable.Columns.Add(nameColumn)
            queryTable.Columns.Add(rarityColumn)
            queryTable.Columns.Add(typeColumn)
            queryTable.Columns.Add(setColumn)
            queryTable.Columns.Add(releaseColumn)

            ' search thru all card items for | query phrase
            For Each card As Card In cards

                If card.name.ToUpper.Contains(query.ToUpper()) Then
                    queryTable.Rows.Add(card.name, card.rarity, card.type, card.pSet, card.release)
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

    Private Sub LoadDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoadDataToolStripMenuItem.Click
        frmAddCard.Show()
    End Sub

    Private Sub AdvancedQueryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdvancedQueryToolStripMenuItem.Click
        frmSearch.Show()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        TextBox1.Text = ""
    End Sub

    Private Sub DeleteCardToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteCardToolStripMenuItem.Click
        frmDelete.Show()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        populateDataGrid("SELECT * FROM Cards;")
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub

End Class