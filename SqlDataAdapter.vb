Friend Class SqlDataAdapter
    Private cmd As SQLCommand

    Public Sub New(cmd As SQLCommand)
        Me.cmd = cmd
    End Sub

    Friend Sub Fill(dt As DataTable)
        Throw New NotImplementedException()
    End Sub
End Class
