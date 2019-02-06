Public Class BusinessTierObjects
    Public Class Transaction
        Public ID As Integer
        Public DateTime As String
        Public Type As String
        Public TOperator As String
        Public Location As String
        Public Description As String
        Public Amount As String

        Public Sub New(tid, tdatetime, ttype, ttoperator, tlocation, tdescription, tamount)
            ID = tid
            DateTime = tdatetime
            Type = ttype
            TOperator = ttoperator
            Location = tlocation
            Description = tdescription
            Amount = tamount
        End Sub

    End Class
End Class
