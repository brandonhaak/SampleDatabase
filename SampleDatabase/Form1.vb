Imports System.Data.SqlClient

Partial Public Class Form1
    Inherits System.Windows.Forms.Form

    Private newDBFlag As Boolean = False

    Private Sub ButtonManager()
        Import_Button.Enabled = False
        CSV_Browse.Enabled = False
        Task.Delay(3000)
        Import_Button.Enabled = True
        CSV_Browse.Enabled = True
    End Sub

    Private Function BrowseCreator(fileType As String)
        Try
            Dim filePath As String
            Dim fileExplorer As OpenFileDialog = New OpenFileDialog()
            fileExplorer.InitialDirectory = "c:\\"
            fileExplorer.Filter = String.Format("{0} files(*.{0})|*.{0}|All files (*.*)|*.*", fileType)
            fileExplorer.FilterIndex = 2
            fileExplorer.RestoreDirectory = True
            If fileExplorer.ShowDialog() = DialogResult.OK Then
                filePath = fileExplorer.FileName
                If Not FileValid(filePath, fileType) Then
                    Dim message As String = String.Format("Please select a valid {0} File!", fileType)
                    MsgBox(message, MessageBoxIcon.Error)
                Else
                    Return filePath
                End If
            End If
        Catch ex As Exception
            MsgBox("Exception thrown in " + fileType + "_Browse_Click: " + ex.Message + Environment.NewLine + "EX @: " + ex.Source)
        End Try
        Return ""
    End Function

    Private Function FileValid(filePath As String, fileType As String)
        If filePath.Equals("") Then Return False
        Dim substr As String = filePath.Substring(filePath.Length - 4)
        If Not substr.Equals("." + fileType) Then
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub CreateNewDB()

    End Sub

    Private Sub PopulateExistingDB()

    End Sub

    'Import_Button_Click handler
    Private Sub Import_Button_Click(sender As Object, e As EventArgs) Handles Import_Button.Click
        Try
            If newDBFlag = False And Not FileValid(CSV_Textbox.Text, "csv") Or
                    Not FileValid(DB_Textbox.Text, "mdf") Or
                    Not FileValid(SQL_Textbox.Text, "sql") Then
                MsgBox("Please make sure all fields are correctly populated!", MessageBoxIcon.Error)
            Else
                'Build biz connection to DB
                'Dim DB_Filepath As String = DB_Textbox.Text
                Dim bizTier As BusinessTier.Business = New BusinessTier.Business(DB_Textbox.Text)

                'Test connection to DB
                bizTier.TestConnection()

                'Build SQL Table from BizTier
                bizTier.BuildTable(SQL_Textbox.Text)

                'Populate SQL Table from BizTier
                bizTier.PopulateTable(CSV_Textbox.Text)

                'Success Message
                MsgBox("Database has been created and populated successfully!", MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MsgBox("Exception thrown in Import_Button.Click: " + ex.Message + Environment.NewLine + "EX @: " + ex.Source)
        End Try
    End Sub

    Private Sub CSV_Browse_Click(sender As Object, e As EventArgs) Handles CSV_Browse.Click
        'Call file browser creator to select CSV File
        Dim filePath As String = BrowseCreator("csv")
        If Not filePath.Equals("") Then
            CSV_Textbox.Text = filePath
        End If
    End Sub

    Private Sub DB_Browse_Click(sender As Object, e As EventArgs) Handles DB_Browse.Click
        'Call file browser creator to select MDF File
        Dim filePath As String = BrowseCreator("mdf")
        If Not filePath.Equals("") Then
            DB_Textbox.Text = filePath
            newDBFlag = False
        End If
    End Sub

    Private Sub SQL_Browse_Click(sender As Object, e As EventArgs) Handles SQL_Browse.Click
        'Call file browser creator to select SQL File
        Dim filePath As String = BrowseCreator("sql")
        If Not filePath.Equals("") Then
            SQL_Textbox.Text = filePath
        End If
    End Sub

    Private Sub New_DB_Button_Click(sender As Object, e As EventArgs) Handles New_DB_Button.Click
        Try
            Dim folderPath As String
            Dim fileExplorer As FolderBrowserDialog = New FolderBrowserDialog()
            If fileExplorer.ShowDialog = DialogResult.OK Then
                If Not fileExplorer.SelectedPath.Equals("") Then
                    folderPath = fileExplorer.SelectedPath
                    DB_Textbox.Text = folderPath
                    newDBFlag = True
                End If
            End If
        Catch ex As Exception
            MsgBox("Exception thrown in New_DB_Button_Click: " + ex.Message + Environment.NewLine + "EX @: " + ex.Source)
        End Try
    End Sub
End Class
