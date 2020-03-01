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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tb_fName = New System.Windows.Forms.TextBox()
        Me.tb_lName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tb_address1 = New System.Windows.Forms.TextBox()
        Me.tb_address2 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tb_city = New System.Windows.Forms.TextBox()
        Me.tb_prov = New System.Windows.Forms.TextBox()
        Me.tb_postalCode = New System.Windows.Forms.TextBox()
        Me.tb_phone = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.listb_billTo = New System.Windows.Forms.ListBox()
        Me.listb_shipTo = New System.Windows.Forms.ListBox()
        Me.chckbx_sameAsBill = New System.Windows.Forms.CheckBox()
        Me.btn_billInfo = New System.Windows.Forms.Button()
        Me.btn_shipInfo = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Order Shipment"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "First Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(125, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Last Name"
        '
        'tb_fName
        '
        Me.tb_fName.Location = New System.Drawing.Point(19, 58)
        Me.tb_fName.Name = "tb_fName"
        Me.tb_fName.Size = New System.Drawing.Size(74, 20)
        Me.tb_fName.TabIndex = 3
        '
        'tb_lName
        '
        Me.tb_lName.Location = New System.Drawing.Point(128, 57)
        Me.tb_lName.Name = "tb_lName"
        Me.tb_lName.Size = New System.Drawing.Size(100, 20)
        Me.tb_lName.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Address Line 1"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(22, 144)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Address Line 2"
        '
        'tb_address1
        '
        Me.tb_address1.Location = New System.Drawing.Point(22, 114)
        Me.tb_address1.Name = "tb_address1"
        Me.tb_address1.Size = New System.Drawing.Size(161, 20)
        Me.tb_address1.TabIndex = 7
        '
        'tb_address2
        '
        Me.tb_address2.Location = New System.Drawing.Point(22, 161)
        Me.tb_address2.Name = "tb_address2"
        Me.tb_address2.Size = New System.Drawing.Size(161, 20)
        Me.tb_address2.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(25, 200)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(24, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "City"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(128, 200)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Province"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(19, 252)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 13)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Postal Code"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(19, 307)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(38, 13)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Phone"
        '
        'tb_city
        '
        Me.tb_city.Location = New System.Drawing.Point(25, 217)
        Me.tb_city.Name = "tb_city"
        Me.tb_city.Size = New System.Drawing.Size(71, 20)
        Me.tb_city.TabIndex = 13
        '
        'tb_prov
        '
        Me.tb_prov.Location = New System.Drawing.Point(131, 216)
        Me.tb_prov.Name = "tb_prov"
        Me.tb_prov.Size = New System.Drawing.Size(52, 20)
        Me.tb_prov.TabIndex = 14
        '
        'tb_postalCode
        '
        Me.tb_postalCode.Location = New System.Drawing.Point(25, 269)
        Me.tb_postalCode.Name = "tb_postalCode"
        Me.tb_postalCode.Size = New System.Drawing.Size(100, 20)
        Me.tb_postalCode.TabIndex = 15
        '
        'tb_phone
        '
        Me.tb_phone.Location = New System.Drawing.Point(25, 324)
        Me.tb_phone.Name = "tb_phone"
        Me.tb_phone.Size = New System.Drawing.Size(100, 20)
        Me.tb_phone.TabIndex = 16
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(349, 40)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(36, 13)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Bill To"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(349, 236)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(44, 13)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "Ship To"
        '
        'listb_billTo
        '
        Me.listb_billTo.FormattingEnabled = True
        Me.listb_billTo.Location = New System.Drawing.Point(352, 58)
        Me.listb_billTo.Name = "listb_billTo"
        Me.listb_billTo.Size = New System.Drawing.Size(168, 147)
        Me.listb_billTo.TabIndex = 19
        '
        'listb_shipTo
        '
        Me.listb_shipTo.FormattingEnabled = True
        Me.listb_shipTo.Location = New System.Drawing.Point(352, 252)
        Me.listb_shipTo.Name = "listb_shipTo"
        Me.listb_shipTo.Size = New System.Drawing.Size(168, 160)
        Me.listb_shipTo.TabIndex = 20
        '
        'chckbx_sameAsBill
        '
        Me.chckbx_sameAsBill.AutoSize = True
        Me.chckbx_sameAsBill.Location = New System.Drawing.Point(352, 430)
        Me.chckbx_sameAsBill.Name = "chckbx_sameAsBill"
        Me.chckbx_sameAsBill.Size = New System.Drawing.Size(99, 17)
        Me.chckbx_sameAsBill.TabIndex = 21
        Me.chckbx_sameAsBill.Text = "Same as Bill To"
        Me.chckbx_sameAsBill.UseVisualStyleBackColor = True
        '
        'btn_billInfo
        '
        Me.btn_billInfo.Location = New System.Drawing.Point(19, 367)
        Me.btn_billInfo.Name = "btn_billInfo"
        Me.btn_billInfo.Size = New System.Drawing.Size(106, 36)
        Me.btn_billInfo.TabIndex = 22
        Me.btn_billInfo.Text = "Add Billing Info"
        Me.btn_billInfo.UseVisualStyleBackColor = True
        '
        'btn_shipInfo
        '
        Me.btn_shipInfo.Location = New System.Drawing.Point(19, 430)
        Me.btn_shipInfo.Name = "btn_shipInfo"
        Me.btn_shipInfo.Size = New System.Drawing.Size(106, 38)
        Me.btn_shipInfo.TabIndex = 23
        Me.btn_shipInfo.Text = "Add Shipping Info"
        Me.btn_shipInfo.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(190, 167)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(48, 13)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "*optional"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(128, 330)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(48, 13)
        Me.Label13.TabIndex = 25
        Me.Label13.Text = "*optional"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(581, 506)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.btn_shipInfo)
        Me.Controls.Add(Me.btn_billInfo)
        Me.Controls.Add(Me.chckbx_sameAsBill)
        Me.Controls.Add(Me.listb_shipTo)
        Me.Controls.Add(Me.listb_billTo)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.tb_phone)
        Me.Controls.Add(Me.tb_postalCode)
        Me.Controls.Add(Me.tb_prov)
        Me.Controls.Add(Me.tb_city)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.tb_address2)
        Me.Controls.Add(Me.tb_address1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tb_lName)
        Me.Controls.Add(Me.tb_fName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents tb_fName As TextBox
    Friend WithEvents tb_lName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents tb_address1 As TextBox
    Friend WithEvents tb_address2 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents tb_city As TextBox
    Friend WithEvents tb_prov As TextBox
    Friend WithEvents tb_postalCode As TextBox
    Friend WithEvents tb_phone As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents listb_billTo As ListBox
    Friend WithEvents listb_shipTo As ListBox
    Friend WithEvents chckbx_sameAsBill As CheckBox
    Friend WithEvents btn_billInfo As Button
    Friend WithEvents btn_shipInfo As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
End Class
