<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GetAddress
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
        Me.txtStreet = New System.Windows.Forms.TextBox()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.txtPostalCode = New System.Windows.Forms.TextBox()
        Me.txtCountry = New System.Windows.Forms.TextBox()
        Me.saveAddress = New System.Windows.Forms.Button()
        Me.cancelAddress = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtStreet
        '
        Me.txtStreet.Location = New System.Drawing.Point(29, 23)
        Me.txtStreet.Name = "txtStreet"
        Me.txtStreet.Size = New System.Drawing.Size(159, 20)
        Me.txtStreet.TabIndex = 0
        '
        'txtCity
        '
        Me.txtCity.Location = New System.Drawing.Point(29, 49)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(159, 20)
        Me.txtCity.TabIndex = 1
        '
        'txtPostalCode
        '
        Me.txtPostalCode.Location = New System.Drawing.Point(29, 75)
        Me.txtPostalCode.Name = "txtPostalCode"
        Me.txtPostalCode.Size = New System.Drawing.Size(159, 20)
        Me.txtPostalCode.TabIndex = 2
        '
        'txtCountry
        '
        Me.txtCountry.Location = New System.Drawing.Point(29, 101)
        Me.txtCountry.Name = "txtCountry"
        Me.txtCountry.Size = New System.Drawing.Size(159, 20)
        Me.txtCountry.TabIndex = 3
        '
        'saveAddress
        '
        Me.saveAddress.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.saveAddress.Location = New System.Drawing.Point(29, 153)
        Me.saveAddress.Name = "saveAddress"
        Me.saveAddress.Size = New System.Drawing.Size(75, 23)
        Me.saveAddress.TabIndex = 4
        Me.saveAddress.Text = "OK"
        Me.saveAddress.UseVisualStyleBackColor = True
        '
        'cancelAddress
        '
        Me.cancelAddress.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cancelAddress.Location = New System.Drawing.Point(113, 153)
        Me.cancelAddress.Name = "cancelAddress"
        Me.cancelAddress.Size = New System.Drawing.Size(75, 23)
        Me.cancelAddress.TabIndex = 5
        Me.cancelAddress.Text = "Cancel"
        Me.cancelAddress.UseVisualStyleBackColor = True
        '
        'GetAddress
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(224, 213)
        Me.Controls.Add(Me.cancelAddress)
        Me.Controls.Add(Me.saveAddress)
        Me.Controls.Add(Me.txtCountry)
        Me.Controls.Add(Me.txtPostalCode)
        Me.Controls.Add(Me.txtCity)
        Me.Controls.Add(Me.txtStreet)
        Me.Name = "GetAddress"
        Me.Text = "GetAddress"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtStreet As TextBox
    Friend WithEvents txtCity As TextBox
    Friend WithEvents txtPostalCode As TextBox
    Friend WithEvents txtCountry As TextBox
    Friend WithEvents saveAddress As Button
    Friend WithEvents cancelAddress As Button
End Class
