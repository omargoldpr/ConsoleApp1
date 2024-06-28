Imports Microsoft.VisualBasic

Imports Microsoft.Data.Sqlite
Imports SQLitePCL

Module Logger
    Private ReadOnly ConnectionString As String = "Data Source=C:\Users\omarg\Desktop\method_logs.db"

    ' Initialize SQLite provider
    Sub New()
        Batteries.Init()
        InitializeDatabase()
    End Sub

    Private Sub InitializeDatabase()
        Using connection As New SqliteConnection(ConnectionString)
            connection.Open()
            Dim createTableQuery As String = "
                CREATE TABLE IF NOT EXISTS MethodLogs (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    ClassName TEXT,
                    MethodName TEXT,
                    Parameters TEXT,
                    ReturnValue TEXT,
                    LogDate TEXT
                )"
            Using command As New SqliteCommand(createTableQuery, connection)
                command.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Sub LogMethodCall(className As String, methodName As String, parameters As String, Optional returnValue As String = "")
        Dim logMessage As String = $"Class: {className}, Method: {methodName}, Parameters: {parameters}, Return Value: {returnValue}"
        Dim logDate As String = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")

        ' Log to console and file (as per your existing implementation)
        Console.WriteLine(logMessage)
        System.IO.File.AppendAllText("C:\Users\omarg\Desktop\log.txt", logMessage & Environment.NewLine)

        ' Log to SQLite database
        Using connection As New SqliteConnection(ConnectionString)
            connection.Open()
            Dim insertQuery As String = "
                INSERT INTO MethodLogs (ClassName, MethodName, Parameters, ReturnValue, LogDate) 
                VALUES (@ClassName, @MethodName, @Parameters, @ReturnValue, @LogDate)"
            Using command As New SqliteCommand(insertQuery, connection)
                command.Parameters.AddWithValue("@ClassName", className)
                command.Parameters.AddWithValue("@MethodName", methodName)
                command.Parameters.AddWithValue("@Parameters", parameters)
                command.Parameters.AddWithValue("@ReturnValue", returnValue)
                command.Parameters.AddWithValue("@LogDate", logDate)
                command.ExecuteNonQuery()
            End Using
        End Using
    End Sub
End Module
