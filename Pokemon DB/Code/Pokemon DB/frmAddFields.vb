Public Class frmAddFields

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        frmAddCard.initCbo()
        frmAddCard.Show()
        Close()

    End Sub

    Private Sub btnAddRarity_Click(sender As Object, e As EventArgs) Handles btnAddRarity.Click

        If txtAddRarity.Text <> "" Then
            Dim sql_command As String = "INSERT INTO Rarity (Rarity) VALUES ('" & txtAddRarity.Text & "');"
            Dim sql_query As New SQL(sql_command, "Rarity")
            Dim result As String = sql_query.nonQuery(2)

            lblResult.Text = result

        Else
            MsgBox("Error :: Invalid input - please enter valid field")
        End If

    End Sub

    Private Sub btnAddType_Click(sender As Object, e As EventArgs) Handles btnAddType.Click

        If txtAddtype.Text <> "" Then
            Dim sql_command As String = "INSERT INTO Types (Type) VALUES ('" & txtAddtype.Text & "');"
            Dim sql_query As New SQL(sql_command, "Type")
            Dim result As String = sql_query.nonQuery(3)

            lblResult.Text = result

        Else
            MsgBox("Error :: Invalid input - please enter valid field")
        End If

    End Sub

    Private Sub btnAddSet_Click(sender As Object, e As EventArgs) Handles btnAddSet.Click

        If txtAddSet.Text <> "" Then
            Dim sql_command As String = "INSERT INTO Sets ( [Set] ) VALUES ('" & txtAddSet.Text & "');"
            Dim sql_query As New SQL(sql_command, "Sets")
            Dim result As String = sql_query.nonQuery(4)

            lblResult.Text = result

        Else
            MsgBox("Error :: Invalid input - please enter valid field")
        End If

    End Sub

    Private Sub btnDeleteRarity_Click(sender As Object, e As EventArgs) Handles btnDeleteRarity.Click

        If txtDeleteRarity.Text <> "" Then
            Dim sql_command As String = "DELETE FROM Rarity WHERE Rarity = '" & txtDeleteRarity.Text & "';"
            Dim sql_query As New SQL(sql_command, "Rarity")
            Dim result As String = sql_query.nonQuery(5)

            lblResult.Text = result

        Else
            MsgBox("Error :: Invalid input - please enter valid field")
        End If

    End Sub

    Private Sub btnDeleteType_Click(sender As Object, e As EventArgs) Handles btnDeleteType.Click

        If txtDeleteType.Text <> "" Then
            Dim sql_command As String = "DELETE FROM Types WHERE Type = '" & txtDeleteType.Text & "';"
            Dim sql_query As New SQL(sql_command, "Type")
            Dim result As String = sql_query.nonQuery(6)

            lblResult.Text = result

        Else
            MsgBox("Error :: Invalid input - please enter valid field")
        End If

    End Sub

    Private Sub btnDeleteSet_Click(sender As Object, e As EventArgs) Handles btnDeleteSet.Click

        If txtDeleteSet.Text <> "" Then
            Dim sql_command As String = "DELETE FROM Sets WHERE Set = '" & txtDeleteSet.Text & "';"
            Dim sql_query As New SQL(sql_command, "Sets")
            Dim result As String = sql_query.nonQuery(7)

            lblResult.Text = result

        Else
            MsgBox("Error :: Invalid input - please enter valid field")
        End If

    End Sub

End Class