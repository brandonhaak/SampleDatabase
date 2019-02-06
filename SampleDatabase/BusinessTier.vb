Public Class BusinessTier
    Public Class Business
        Private _DBFile As String
        Private dataTier As DataAccessTier.Data

        'BusinessTier Business class constructor
        Public Sub New(DatabaseFilename)
            _DBFile = DatabaseFilename
            dataTier = New DataAccessTier.Data(DatabaseFilename)
        End Sub

        'Call the Test Connection funtion of the dataTier
        Public Function TestConnection()
            Return dataTier.Test_DB_Connection()
        End Function

        'Business Tier Function to Build SQL Table
        Public Sub BuildTable(sqlFilePath As String)
            Dim sql As String

            Console.WriteLine()
            Console.WriteLine("** Create Database Console App **")
            Console.WriteLine()

            'attempt to connect to database
            Console.Write("Testing Connection to DB: ")
            TestConnection()
            Console.WriteLine()

            Try
                'Create tables in database using sql file
                Console.WriteLine("Creating tables by executing sql file...")
                Dim lines() As String = System.IO.File.ReadAllLines(sqlFilePath)
                sql = ""

                'Loop through file and grab SQL code
                For Each element In lines
                    Dim nextLine As String = element
                    If nextLine.Trim() = "" Then ''do nothing
                    ElseIf nextLine.Contains(";") Then
                        sql = sql + nextLine + System.Environment.NewLine
                        Console.WriteLine("** Executing '{0}'...", sql)
                        dataTier.ExecuteActionQuery(sql)
                        sql = ""
                    Else
                        sql = sql + nextLine + System.Environment.NewLine
                    End If
                Next element
            Catch ex As Exception
                MsgBox("Exception thrown in BusinessTier.BuildTable(): " + ex.Message + Environment.NewLine + "EX @: " + ex.Source)
            End Try

            Console.WriteLine()
            Console.WriteLine("SQL Table Build Successfully!")
            Console.WriteLine()
        End Sub

        'Business Tier function to populate SQL Table
        Public Sub PopulateTable(csvFilePath As String)
            'Use Reader object to parse CSV File
            Using MyReader As New Microsoft.VisualBasic.FileIO.TextFieldParser(csvFilePath)
                MyReader.TextFieldType = FileIO.FieldType.Delimited
                MyReader.SetDelimiters(",")
                While Not MyReader.EndOfData
                    Try
                        'Insert each rewpective element in each row into SQL table
                        Dim currentRow As String() = MyReader.ReadFields()
                        Dim sql As String = ""
                        Dim ttime As String = currentRow(0)
                        Dim ttype As String = currentRow(1)
                        Dim toperator As String = currentRow(2)
                        Dim tlocation As String = currentRow(3)
                        tlocation = tlocation.Replace("'", "''") 'Without this line, SQL insertion will fail with instances such as "O'Hare"
                        Dim tdescription As String = currentRow(4)
                        Dim tamount As Double = CDbl(currentRow(5))
                        sql = String.Format("INSERT INTO
Transactions(TTIME, TTYPE, TOPERATOR, TLOCATION, TDESCRIPTION, TAMOUNT)
Values('{0}','{1}','{2}','{3}','{4}','{5}');
", ttime, ttype, toperator, tlocation, tdescription, tamount)

                        'Console feedback of SQL insertion
                        Console.WriteLine("Running code..." + Environment.NewLine + sql)
                        Console.WriteLine()

                        'Execute SQL
                        dataTier.ExecuteActionQuery(sql)

                    Catch ex As Exception
                        MsgBox("Exception thrown in BusinessTier.PopulateTable(): " + ex.Message + Environment.NewLine + "EX @: " + ex.Source)
                    End Try

                End While
            End Using
        End Sub
    End Class
End Class
