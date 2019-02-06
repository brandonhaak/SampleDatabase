Imports System.Data.SqlClient

Public Class DataAccessTier
    Public Class Data
        'Fields
        Private _DBFile As String
        Private _DBConnectionInfo As String

        'Constructor sub object to initialize the DataAccessTier.Data
        Public Sub New(DatabaseFilename)
            Dim version As String
            version = "MSSQLLocalDB"
            _DBFile = DatabaseFilename
            _DBConnectionInfo = String.Format("Data Source=(LocalDB)\{0};AttachDbFilename={1};Integrated Security=True;",
        version,
        DatabaseFilename)
        End Sub

        'Function used to test connection to local DB
        Public Function Test_DB_Connection()
            'Create a Connection object.
            Dim db As SqlConnection
            db = New SqlConnection(_DBConnectionInfo)

            'Try statement to return DB connection status and throw exception if failed.
            Dim state = False
            Try
                db.Open()
                state = (db.State = ConnectionState.Open)
                Console.WriteLine("DB is open!")
            Catch ex As Exception
                MsgBox("Exception Thrown in Test_DB_Connection " + ex.Message)
            Finally
                If db IsNot Nothing And db.State = ConnectionState.Open Then
                    db.Close()
                    Console.WriteLine("DB is Closed!")
                End If
            End Try
            Return state
        End Function

        'Function to Execute a Scalar Query

        'Function to Execute a NonScalar Query

        'Function to Execute an Action Query
        Public Function ExecuteActionQuery(sql)
            Dim db As SqlConnection = New SqlConnection(_DBConnectionInfo)

            Try
                db.Open()
                Dim cmd As SqlCommand = New SqlCommand()
                cmd.Connection = db
                cmd.CommandText = sql

                Dim rowsModified As Integer = cmd.ExecuteNonQuery()

                db.Close()

                Return rowsModified

            Catch ex As Exception
                Throw
            Finally
                If db IsNot Nothing And db.State = ConnectionState.Open Then
                    db.Close()
                End If
            End Try
            Return 0
        End Function

    End Class

End Class
