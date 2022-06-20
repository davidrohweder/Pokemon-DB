Public Class frmSearch

    Private Structure Filter
        Public rarity As Boolean
        Public type As Boolean
        Public pSet As Boolean
        Public grade As Boolean
    End Structure

    Private filters As Filter

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        Try
            Dim query As String = TextBox1.Text

            If Not query = "" Then

                Dim queryTable As DataTable = New DataTable()

                frmMain.generateTable(queryTable)

                ' search thru all card items for | query phrase
                For Each row As DataGridViewRow In DataGridView1.Rows
                    Dim cells(7) As String
                    Dim inc As Integer = 0

                    For Each cell As DataGridViewCell In row.Cells
                        cells(inc) = cell.Value
                        inc += 1
                    Next

                    If cells(1).ToUpper.Contains(query.ToUpper()) Then
                        queryTable.Rows.Add(cells(0), cells(1), cells(2), cells(3), cells(4), cells(5), cells(6), cells(7))
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
        Catch ex As Exception
            MsgBox("Error - " & ex.Message)
        End Try

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        populateDataGrid("SELECT * FROM Cards;")
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        TextBox1.Text = ""
    End Sub

    Private Sub frmSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' create filter def vals
        filters.rarity = False
        filters.type = False
        filters.pSet = False
        filters.grade = False

        ' load data into view
        populateDataGrid("SELECT * FROM Cards;")

        ' load cbo's
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

    Public Sub populateDataGrid(ByRef query As String)

        ' populate data on field
        Dim sql_query As New SQL(query, "Cards")
        Dim fillTable As DataTable = sql_query.fillTable()

        DataGridView1.DataSource = fillTable

    End Sub

    Private Sub btnFilter_Click(sender As Object, e As EventArgs) Handles btnFilter.Click

        If cboRarity.Text = "" And cboType.Text = "" And cboSet.Text = "" And cboGrade.Text = "" Then
            MsgBox("Error - no filters applied!")
        Else

            Dim queryTable As DataTable = New DataTable()
            Dim criteriaMet As Boolean = True

            frmMain.generateTable(queryTable)

            For Each card As Card In frmMain.cards

                If cboRarity.Text <> "" And card.rarity = cboRarity.Text Then
                    filters.rarity = True

                End If

                If cboType.Text <> "" And card.type = cboType.Text Then
                    filters.type = True

                End If

                If cboSet.Text <> "" And card.pSet = cboSet.Text Then
                    filters.pSet = True

                End If

                If cboGrade.Text <> "" Then

                    If card.grade = Convert.ToInt16(cboGrade.Text) Then
                        filters.grade = True

                    End If

                End If

                If filters.rarity = True Or filters.type = True Or filters.pSet = True Or filters.grade = True Then

                    If cboRarity.Text <> "" And filters.rarity = True Then
                        criteriaMet = True
                    Else

                        If cboRarity.Text <> "" Then
                            criteriaMet = False
                        End If

                    End If

                    If cboType.Text <> "" And filters.type = True Then

                        If criteriaMet <> False Then
                            criteriaMet = True
                        End If

                    Else

                        If cboType.Text <> "" Then
                            criteriaMet = False
                        End If

                    End If

                    If cboSet.Text <> "" And filters.pSet = True Then

                        If criteriaMet <> False Then
                            criteriaMet = True
                        End If

                    Else

                        If cboSet.Text <> "" Then
                            criteriaMet = False
                        End If

                    End If

                    If cboGrade.Text <> "" And filters.grade = True Then

                        If criteriaMet <> False Then
                            criteriaMet = True
                        End If

                    Else

                        If cboGrade.Text <> "" Then
                            criteriaMet = False
                        End If

                    End If

                    If criteriaMet = True Then
                        queryTable.Rows.Add(card.id, card.name, card.rarity, card.type, card.pSet, card.release, card.quanity, card.grade)

                    End If

                End If

                criteriaMet = True
                ' reset filter table
                filters.rarity = False
                filters.type = False
                filters.pSet = False
                filters.grade = False
            Next

            DataGridView1.DataSource = queryTable
        End If
    End Sub

    Private Sub btnClearFilters_Click(sender As Object, e As EventArgs) Handles btnClearFilters.Click

        'reset filters
        filters.rarity = False
        filters.type = False
        filters.pSet = False
        filters.grade = False

        ' change back to default values
        cboRarity.Text = ""
        cboType.Text = ""
        cboSet.Text = ""
        cboGrade.Text = ""

        populateDataGrid("SELECT * FROM Cards;")

    End Sub

End Class