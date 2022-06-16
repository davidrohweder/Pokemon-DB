Public Class frmAddCard

    Private Sub frmAddCard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            ' init cbo
            initCbo()

            ' set default values
            cboRarity.SelectedIndex = 0
            cboSet.SelectedIndex = 0
            cboType.SelectedIndex = 0

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

        If Not TextBox1.Text = "" Then
            Dim sql_query As New SQL("INSERT INTO Cards ( Pokemon, Rarity, Type, [Set], [Release Date] ) VALUES ('" & TextBox1.Text & "', '" & cboRarity.Text & "', '" & cboSet.Text & "', '" & cboType.Text & "', '" & TextBox2.Text & "');", "Cards")
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