' Program Info
'-----------------------------------------------------------------------------
' Program: Shipping order form
' Date: November 23 2018
' Author: Drew MacPhee
' Operation: Create a basic shipping form with billing and shipping information to listboxes. 
' Use a sub procedure to send texbox information to specified listbox, and if checkbox is
' checked then apply the same information to both listboxes.
'-----------------------------------------------------------------------------
' Change Log
' ------------
' Date                  Programmer                  Change
'-----------------------------------------------------------------------------
'11/23/2018             Drew MacPhee                Program created


Public Class Form1
    Dim g_boolError = True

    Private Sub btn_billInfo_Click(sender As Object, e As EventArgs) Handles btn_billInfo.Click
        Try
            'check for empty input
            EmptyInput(tb_address1, g_boolError)
            EmptyInput(tb_city, g_boolError)
            EmptyInput(tb_fName, g_boolError)
            EmptyInput(tb_lName, g_boolError)
            EmptyInput(tb_prov, g_boolError)
            EmptyInput(tb_postalCode, g_boolError)

            'allow items to be added to list box if no errors occur
            If g_boolError = True Then

                If chckbx_sameAsBill.Checked = True Then
                    AddToListbox(Me, listb_billTo)
                    AddToListbox(Me, listb_shipTo)
                Else
                    AddToListbox(Me, listb_billTo)
                End If
            End If

        Catch ex As Exception
            ErrorMsg(200)
        End Try

    End Sub

    Private Sub btn_shipInfo_Click(sender As Object, e As EventArgs) Handles btn_shipInfo.Click
        Try
            'check for empty input
            EmptyInput(tb_address1, g_boolError)
            EmptyInput(tb_city, g_boolError)
            EmptyInput(tb_fName, g_boolError)
            EmptyInput(tb_lName, g_boolError)
            EmptyInput(tb_prov, g_boolError)
            EmptyInput(tb_postalCode, g_boolError)

            'allow items to be added to list box if no errors occur
            If g_boolError = True Then

                If chckbx_sameAsBill.Checked = True Then
                    AddToListbox(Me, listb_billTo)
                    AddToListbox(Me, listb_shipTo)
                Else
                    AddToListbox(Me, listb_shipTo)
                End If

            End If

        Catch ex As Exception
            ErrorMsg(200, ex.Message)
        End Try
    End Sub
End Class
