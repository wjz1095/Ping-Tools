<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IPwindow
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IPwindow))
        Me.DHCPradioButton = New System.Windows.Forms.RadioButton()
        Me.StaticIPRadioButton = New System.Windows.Forms.RadioButton()
        Me.StaticDHCPGroupBox = New System.Windows.Forms.GroupBox()
        Me.StaticIPtextBox = New System.Windows.Forms.TextBox()
        Me.SubnetMaskTextBox = New System.Windows.Forms.TextBox()
        Me.DefaultGatewayTextBox = New System.Windows.Forms.TextBox()
        Me.SetPrimaryDNSTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SetIPbutton = New System.Windows.Forms.Button()
        Me.CommandPromptLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.IPconfigButton = New System.Windows.Forms.Button()
        Me.ViewInterfacesButton = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.InterfaceNameTextBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SetSecondaryDNSTextBox = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.StaticDHCPGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'DHCPradioButton
        '
        Me.DHCPradioButton.AutoSize = True
        Me.DHCPradioButton.Checked = True
        Me.DHCPradioButton.Location = New System.Drawing.Point(12, 19)
        Me.DHCPradioButton.Name = "DHCPradioButton"
        Me.DHCPradioButton.Size = New System.Drawing.Size(68, 17)
        Me.DHCPradioButton.TabIndex = 7
        Me.DHCPradioButton.TabStop = True
        Me.DHCPradioButton.Text = "DHCP IP"
        Me.DHCPradioButton.UseVisualStyleBackColor = True
        '
        'StaticIPRadioButton
        '
        Me.StaticIPRadioButton.AutoSize = True
        Me.StaticIPRadioButton.Location = New System.Drawing.Point(99, 19)
        Me.StaticIPRadioButton.Name = "StaticIPRadioButton"
        Me.StaticIPRadioButton.Size = New System.Drawing.Size(65, 17)
        Me.StaticIPRadioButton.TabIndex = 8
        Me.StaticIPRadioButton.Text = "Static IP"
        Me.StaticIPRadioButton.UseVisualStyleBackColor = True
        '
        'StaticDHCPGroupBox
        '
        Me.StaticDHCPGroupBox.Controls.Add(Me.DHCPradioButton)
        Me.StaticDHCPGroupBox.Controls.Add(Me.StaticIPRadioButton)
        Me.StaticDHCPGroupBox.Location = New System.Drawing.Point(12, 72)
        Me.StaticDHCPGroupBox.Name = "StaticDHCPGroupBox"
        Me.StaticDHCPGroupBox.Size = New System.Drawing.Size(202, 46)
        Me.StaticDHCPGroupBox.TabIndex = 3
        Me.StaticDHCPGroupBox.TabStop = False
        Me.StaticDHCPGroupBox.Text = "Static or DHCP?"
        '
        'StaticIPtextBox
        '
        Me.StaticIPtextBox.Enabled = False
        Me.StaticIPtextBox.Location = New System.Drawing.Point(12, 179)
        Me.StaticIPtextBox.MaxLength = 100
        Me.StaticIPtextBox.Name = "StaticIPtextBox"
        Me.StaticIPtextBox.Size = New System.Drawing.Size(202, 20)
        Me.StaticIPtextBox.TabIndex = 1
        Me.StaticIPtextBox.Text = "192.168.1."
        '
        'SubnetMaskTextBox
        '
        Me.SubnetMaskTextBox.Enabled = False
        Me.SubnetMaskTextBox.Location = New System.Drawing.Point(12, 221)
        Me.SubnetMaskTextBox.MaxLength = 100
        Me.SubnetMaskTextBox.Name = "SubnetMaskTextBox"
        Me.SubnetMaskTextBox.Size = New System.Drawing.Size(202, 20)
        Me.SubnetMaskTextBox.TabIndex = 2
        Me.SubnetMaskTextBox.Text = "255.255.255.0"
        '
        'DefaultGatewayTextBox
        '
        Me.DefaultGatewayTextBox.Enabled = False
        Me.DefaultGatewayTextBox.Location = New System.Drawing.Point(12, 268)
        Me.DefaultGatewayTextBox.MaxLength = 100
        Me.DefaultGatewayTextBox.Name = "DefaultGatewayTextBox"
        Me.DefaultGatewayTextBox.Size = New System.Drawing.Size(202, 20)
        Me.DefaultGatewayTextBox.TabIndex = 3
        Me.DefaultGatewayTextBox.Text = "192.168.1.1"
        '
        'SetPrimaryDNSTextBox
        '
        Me.SetPrimaryDNSTextBox.Enabled = False
        Me.SetPrimaryDNSTextBox.Location = New System.Drawing.Point(12, 316)
        Me.SetPrimaryDNSTextBox.MaxLength = 100
        Me.SetPrimaryDNSTextBox.Name = "SetPrimaryDNSTextBox"
        Me.SetPrimaryDNSTextBox.Size = New System.Drawing.Size(202, 20)
        Me.SetPrimaryDNSTextBox.TabIndex = 4
        Me.SetPrimaryDNSTextBox.Text = "8.8.8.8"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 163)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "IP Address:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 205)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Subnet Mask:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 252)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Default Gateway:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 300)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Custom Primary DNS:"
        '
        'SetIPbutton
        '
        Me.SetIPbutton.Location = New System.Drawing.Point(12, 393)
        Me.SetIPbutton.Name = "SetIPbutton"
        Me.SetIPbutton.Size = New System.Drawing.Size(98, 23)
        Me.SetIPbutton.TabIndex = 5
        Me.SetIPbutton.Text = "Set IP"
        Me.SetIPbutton.UseVisualStyleBackColor = True
        '
        'CommandPromptLinkLabel
        '
        Me.CommandPromptLinkLabel.AutoSize = True
        Me.CommandPromptLinkLabel.Location = New System.Drawing.Point(124, 398)
        Me.CommandPromptLinkLabel.Name = "CommandPromptLinkLabel"
        Me.CommandPromptLinkLabel.Size = New System.Drawing.Size(90, 13)
        Me.CommandPromptLinkLabel.TabIndex = 6
        Me.CommandPromptLinkLabel.TabStop = True
        Me.CommandPromptLinkLabel.Text = "Command Prompt"
        '
        'IPconfigButton
        '
        Me.IPconfigButton.Location = New System.Drawing.Point(12, 43)
        Me.IPconfigButton.Name = "IPconfigButton"
        Me.IPconfigButton.Size = New System.Drawing.Size(98, 23)
        Me.IPconfigButton.TabIndex = 9
        Me.IPconfigButton.TabStop = False
        Me.IPconfigButton.Text = "Run IPconfig"
        Me.IPconfigButton.UseVisualStyleBackColor = True
        '
        'ViewInterfacesButton
        '
        Me.ViewInterfacesButton.Location = New System.Drawing.Point(116, 43)
        Me.ViewInterfacesButton.Name = "ViewInterfacesButton"
        Me.ViewInterfacesButton.Size = New System.Drawing.Size(98, 23)
        Me.ViewInterfacesButton.TabIndex = 10
        Me.ViewInterfacesButton.TabStop = False
        Me.ViewInterfacesButton.Text = "View Interfaces"
        Me.ViewInterfacesButton.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 120)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Interface Name:"
        '
        'InterfaceNameTextBox
        '
        Me.InterfaceNameTextBox.Location = New System.Drawing.Point(12, 136)
        Me.InterfaceNameTextBox.MaxLength = 100
        Me.InterfaceNameTextBox.Name = "InterfaceNameTextBox"
        Me.InterfaceNameTextBox.Size = New System.Drawing.Size(202, 20)
        Me.InterfaceNameTextBox.TabIndex = 0
        Me.InterfaceNameTextBox.Text = "(Interface Name from Button Above)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(21, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(173, 13)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "To change IP, you MUST run"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(30, 22)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(164, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "program as an Administrator"
        '
        'SetSecondaryDNSTextBox
        '
        Me.SetSecondaryDNSTextBox.Enabled = False
        Me.SetSecondaryDNSTextBox.Location = New System.Drawing.Point(12, 367)
        Me.SetSecondaryDNSTextBox.Name = "SetSecondaryDNSTextBox"
        Me.SetSecondaryDNSTextBox.Size = New System.Drawing.Size(201, 20)
        Me.SetSecondaryDNSTextBox.TabIndex = 19
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 351)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(125, 13)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Custom Secondary DNS:"
        '
        'IPwindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(226, 420)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.SetSecondaryDNSTextBox)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.InterfaceNameTextBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ViewInterfacesButton)
        Me.Controls.Add(Me.IPconfigButton)
        Me.Controls.Add(Me.CommandPromptLinkLabel)
        Me.Controls.Add(Me.SetIPbutton)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SetPrimaryDNSTextBox)
        Me.Controls.Add(Me.DefaultGatewayTextBox)
        Me.Controls.Add(Me.SubnetMaskTextBox)
        Me.Controls.Add(Me.StaticIPtextBox)
        Me.Controls.Add(Me.StaticDHCPGroupBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "IPwindow"
        Me.Text = "IP Settings"
        Me.StaticDHCPGroupBox.ResumeLayout(False)
        Me.StaticDHCPGroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DHCPradioButton As System.Windows.Forms.RadioButton
    Friend WithEvents StaticIPRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents StaticDHCPGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents StaticIPtextBox As System.Windows.Forms.TextBox
    Friend WithEvents SubnetMaskTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DefaultGatewayTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SetPrimaryDNSTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents SetIPbutton As System.Windows.Forms.Button
    Friend WithEvents CommandPromptLinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents IPconfigButton As System.Windows.Forms.Button
    Friend WithEvents ViewInterfacesButton As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents InterfaceNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents SetSecondaryDNSTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class
