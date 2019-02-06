<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.CSV_Textbox = New System.Windows.Forms.TextBox()
        Me.CSV_Label = New System.Windows.Forms.Label()
        Me.DB_Label = New System.Windows.Forms.Label()
        Me.DB_Textbox = New System.Windows.Forms.TextBox()
        Me.Import_Button = New System.Windows.Forms.Button()
        Me.SQL_Label = New System.Windows.Forms.Label()
        Me.SQL_Textbox = New System.Windows.Forms.TextBox()
        Me.CSV_Browse = New System.Windows.Forms.Button()
        Me.DB_Browse = New System.Windows.Forms.Button()
        Me.SQL_Browse = New System.Windows.Forms.Button()
        Me.New_DB_Button = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CSV_Textbox
        '
        Me.CSV_Textbox.Location = New System.Drawing.Point(41, 113)
        Me.CSV_Textbox.Name = "CSV_Textbox"
        Me.CSV_Textbox.Size = New System.Drawing.Size(709, 20)
        Me.CSV_Textbox.TabIndex = 0
        '
        'CSV_Label
        '
        Me.CSV_Label.AutoSize = True
        Me.CSV_Label.Location = New System.Drawing.Point(38, 97)
        Me.CSV_Label.Name = "CSV_Label"
        Me.CSV_Label.Size = New System.Drawing.Size(72, 13)
        Me.CSV_Label.TabIndex = 1
        Me.CSV_Label.Text = "CSV File Path"
        '
        'DB_Label
        '
        Me.DB_Label.AutoSize = True
        Me.DB_Label.Location = New System.Drawing.Point(38, 187)
        Me.DB_Label.Name = "DB_Label"
        Me.DB_Label.Size = New System.Drawing.Size(97, 13)
        Me.DB_Label.TabIndex = 3
        Me.DB_Label.Text = "Database File Path"
        '
        'DB_Textbox
        '
        Me.DB_Textbox.Location = New System.Drawing.Point(41, 203)
        Me.DB_Textbox.Name = "DB_Textbox"
        Me.DB_Textbox.Size = New System.Drawing.Size(709, 20)
        Me.DB_Textbox.TabIndex = 2
        '
        'Import_Button
        '
        Me.Import_Button.Location = New System.Drawing.Point(675, 392)
        Me.Import_Button.Name = "Import_Button"
        Me.Import_Button.Size = New System.Drawing.Size(75, 23)
        Me.Import_Button.TabIndex = 4
        Me.Import_Button.Text = "Import"
        Me.Import_Button.UseVisualStyleBackColor = True
        '
        'SQL_Label
        '
        Me.SQL_Label.AutoSize = True
        Me.SQL_Label.Location = New System.Drawing.Point(38, 277)
        Me.SQL_Label.Name = "SQL_Label"
        Me.SQL_Label.Size = New System.Drawing.Size(72, 13)
        Me.SQL_Label.TabIndex = 6
        Me.SQL_Label.Text = "SQL File Path"
        '
        'SQL_Textbox
        '
        Me.SQL_Textbox.Location = New System.Drawing.Point(41, 293)
        Me.SQL_Textbox.Name = "SQL_Textbox"
        Me.SQL_Textbox.Size = New System.Drawing.Size(709, 20)
        Me.SQL_Textbox.TabIndex = 5
        '
        'CSV_Browse
        '
        Me.CSV_Browse.Location = New System.Drawing.Point(675, 139)
        Me.CSV_Browse.Name = "CSV_Browse"
        Me.CSV_Browse.Size = New System.Drawing.Size(75, 23)
        Me.CSV_Browse.TabIndex = 7
        Me.CSV_Browse.Text = "Browse"
        Me.CSV_Browse.UseVisualStyleBackColor = True
        '
        'DB_Browse
        '
        Me.DB_Browse.Location = New System.Drawing.Point(675, 229)
        Me.DB_Browse.Name = "DB_Browse"
        Me.DB_Browse.Size = New System.Drawing.Size(75, 23)
        Me.DB_Browse.TabIndex = 8
        Me.DB_Browse.Text = "Browse"
        Me.DB_Browse.UseVisualStyleBackColor = True
        '
        'SQL_Browse
        '
        Me.SQL_Browse.Location = New System.Drawing.Point(675, 319)
        Me.SQL_Browse.Name = "SQL_Browse"
        Me.SQL_Browse.Size = New System.Drawing.Size(75, 23)
        Me.SQL_Browse.TabIndex = 9
        Me.SQL_Browse.Text = "Browse"
        Me.SQL_Browse.UseVisualStyleBackColor = True
        '
        'New_DB_Button
        '
        Me.New_DB_Button.Enabled = False
        Me.New_DB_Button.Location = New System.Drawing.Point(567, 229)
        Me.New_DB_Button.Name = "New_DB_Button"
        Me.New_DB_Button.Size = New System.Drawing.Size(102, 23)
        Me.New_DB_Button.TabIndex = 10
        Me.New_DB_Button.Text = "New Database"
        Me.New_DB_Button.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.New_DB_Button)
        Me.Controls.Add(Me.SQL_Browse)
        Me.Controls.Add(Me.DB_Browse)
        Me.Controls.Add(Me.CSV_Browse)
        Me.Controls.Add(Me.SQL_Label)
        Me.Controls.Add(Me.SQL_Textbox)
        Me.Controls.Add(Me.Import_Button)
        Me.Controls.Add(Me.DB_Label)
        Me.Controls.Add(Me.DB_Textbox)
        Me.Controls.Add(Me.CSV_Label)
        Me.Controls.Add(Me.CSV_Textbox)
        Me.Name = "Form1"
        Me.Text = "Create a Database from a CSV File"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CSV_Textbox As TextBox
    Friend WithEvents CSV_Label As Label
    Friend WithEvents DB_Label As Label
    Friend WithEvents DB_Textbox As TextBox
    Friend WithEvents Import_Button As Button
    Friend WithEvents SQL_Label As Label
    Friend WithEvents SQL_Textbox As TextBox
    Friend WithEvents CSV_Browse As Button
    Friend WithEvents DB_Browse As Button
    Friend WithEvents SQL_Browse As Button
    Friend WithEvents New_DB_Button As Button
End Class
