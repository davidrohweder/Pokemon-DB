Public Class frmAddCard

    Private Sub frmAddCard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            ' init cbo
            initCbo()

            ' set default values
            cboRarity.SelectedIndex = 0
            cboSet.SelectedIndex = 0
            cboType.SelectedIndex = 0
            cboGrade.SelectedIndex = 0

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

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

    Private Sub btnAddCard_Click(sender As Object, e As EventArgs) Handles btnAddCard.Click

        Dim query As String = ""
        Dim matched As Boolean = False

        If Not TextBox1.Text = "" Then

            ' check if card is present to add quanity
            For Each card As Card In frmMain.cards
                If card.name = TextBox1.Text And card.release = TextBox2.Text And card.grade = cboGrade.Text And card.rarity = cboRarity.Text And card.pSet = cboSet.Text And card.type = cboType.Text Then
                    query = "UPDATE Cards SET Quanity = " & card.quanity + pkrQuanity.Value & " WHERE id = " & card.id & ""
                    matched = True
                End If
            Next

            If matched = False Then
                query = "INSERT INTO Cards ( Pokemon, Rarity, Type, [Set], [Release Date], Quanity, Grade ) VALUES ('" & TextBox1.Text & "', '" & cboRarity.Text & "', '" & cboType.Text & "', '" & cboSet.Text & "', '" & TextBox2.Text & "', '" & pkrQuanity.Value & "', '" & cboGrade.Text & "');"
            End If

            Dim sql_query As New SQL(query, "Cards")
            Dim result As String = sql_query.nonQuery(0)

            lblSuccess.Text = result

            ' update table refresh
            frmMain.populateDataGrid("SELECT * FROM Cards;")

        Else
            MsgBox("Error :: Invalid input - please enter search phrase")
        End If

    End Sub

    Private Sub btnAddDat_Click(sender As Object, e As EventArgs) Handles btnAddDat.Click

        Hide()
        frmAddFields.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        ' update table refresh
        frmMain.populateDataGrid("SELECT * FROM Cards;")

        ' close form
        Close()
    End Sub

End Class