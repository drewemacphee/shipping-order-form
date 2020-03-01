Module BuildListbox
    Sub AddToListbox(ByRef theForm As Form1, ByRef theListbx As ListBox)
        theListbx.Items.Add($"{theForm.tb_fName.Text} {theForm.tb_lName.Text}")
        theListbx.Items.Add($"{theForm.tb_address1.Text} {theForm.tb_address2.Text}")
        theListbx.Items.Add($"{theForm.tb_city.Text} {theForm.tb_prov.Text}, {theForm.tb_postalCode.Text}")
        theListbx.Items.Add($"{theForm.tb_phone.Text}")
    End Sub

End Module
