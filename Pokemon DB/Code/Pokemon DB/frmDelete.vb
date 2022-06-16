Public Class frmDelete

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If TextBox1.Text <> "" Then

            If radConfirm.Checked = True Then

                If txtEnd.Text = "" Then
                    Dim sql_query As New SQL("DELETE FROM Cards WHERE ID = " & TextBox1.Text & ";", "Cards")
                    Dim result As String = sql_query.nonQuery(1)

                    lblSuccess.Text = result

                Else

                    For int As Integer = TextBox1.Text To Convert.ToInt16(txtEnd.Text)
                        Dim sql_query As New SQL("DELETE FROM Cards WHERE ID = " & int & ";", "Cards")
                        Dim result As String = sql_query.nonQuery(1)

                        If result.Contains("Error") Then
                            lblSuccess.Text = "Error - range delete threw error on ID " & int & ": " & result
                            Exit For
                        End If

                        lblSuccess.Text = result

                    Next

                End If

                ' update table refresh
                frmMain.populateDataGrid("SELECT * FROM Cards;")

            Else
                MsgBox("Validation error: Please check confirm delete!")
            End If
        Else
            MsgBox("Error :: Invalid input - please enter a valid ID")
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        ' close form
        Close()

    End Sub

End Class