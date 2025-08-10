Friend Class SQLCommand
    Private value As Object
    Private con As SQLConnection

    Public Sub New(value As Object, con As SQLConnection)
        Me.value = value
        Me.con = con
    End Sub
End Class
