' Global Imports
Imports System.Data.OleDb

' SQL class wrappeer
Public Class SQL

    ' private vars
    Private sql_query As String
    Private sql_table As String
    Private sql_con As New OleDbConnection

    ' class constructor
    Public Sub New(ByRef query As String, ByRef table As String)

        sql_query = query
        sql_table = table
        establishConnection()

    End Sub

    ' connect to access Db
    Public Sub establishConnection()

        ' init env
        Dim dbProvider As String
        Dim dbSource As String
        Dim dbPathAndFilename As String

        dbProvider = "PROVIDER=Microsoft.Ace.OLEDB.12.0;" 'ACCDB
        dbSource = "Data Source="

        Dim appPath As String = Application.StartupPath()
        dbPathAndFilename = appPath + "\Pokeman.accdb"
        sql_con.ConnectionString = dbProvider & dbSource & dbPathAndFilename
        sql_con.Open()

    End Sub

    ' fill table with all
    Public Function fillTable()

        Dim ds As New DataSet
        Dim da As OleDbDataAdapter

        da = New OleDbDataAdapter(sql_query, sql_con)
        da.Fill(ds, sql_table)

        sql_con.Close()

        ' Return to populate the DataGridView
        Dim table As DataTable = New DataTable

        table = ds.Tables(sql_table)

        Return table

    End Function

    ' insert pokemon card
    Public Function nonQuery(ByRef opType As Integer)

        Dim result As String = "Failed"

        Try
            ' init env
            Dim da As OleDbCommand

            da = New OleDbCommand(sql_query, sql_con)
            da.ExecuteNonQuery()
            sql_con.Close()

            Select Case opType
                Case 0
                    result = "Sucessfully added card!"
                Case 1
                    result = "Sucessfully deleted card!"
                Case 2
                    result = "Sucessfully added rarity!"
                Case 3
                    result = "Sucessfully added type!"
                Case 4
                    result = "Sucessfully added set!"
                Case 5
                    result = "Sucessfully deleted rarity!"
                Case 6
                    result = "Sucessfully deleted type!"
                Case 7
                    result = "Sucessfully deleted set!"
                Case 10
                    result = "Successfully edited card!"
            End Select

        Catch ex As Exception
            MsgBox("Error in operation {" & opType & "}: " & ex.Message)
        End Try

        Return result

    End Function

    Public Sub setTable(ByRef table As String)
        sql_table = table
    End Sub

    Public Sub setQuery(ByRef query As String)
        sql_query = query
    End Sub

End Class