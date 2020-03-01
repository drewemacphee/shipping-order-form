Module ErrorHandling
    Sub EmptyInput(ByRef value As TextBox, ByRef bool_error As Boolean)
        If value.Text = "" Then
            ErrorMsg(100)
            value.Clear()
            value.Focus()
            bool_error = False
        End If
    End Sub

    Sub ErrorMsg(ByRef errorNum As Int16, ByRef Optional exmessage As String = "")
        If errorNum = 100 Then
            MsgBox("Error: you forgot to enter a required field.")
        ElseIf errorNum = 200 Then
            MsgBox($"An unknown error has occured, please restart. Official cause: {exmessage}")
        End If
    End Sub
End Module
