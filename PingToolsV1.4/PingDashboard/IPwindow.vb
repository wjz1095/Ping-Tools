Public Class IPwindow

    'On form load, a window will pop up reminding the user to run as an Administrator
    Private Sub IPwindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox("You cannot change the IP unless you run this program as an administrator. Click OK to continue.", MsgBoxStyle.Exclamation, "Check Admin Privledge")
    End Sub

    Private Sub IPconfigButton_Click(sender As Object, e As EventArgs) Handles IPconfigButton.Click
        'Runs IPconfig so user can view current IP configuration
        Process.Start("cmd", String.Format("/k ipconfig /all"))
    End Sub

    Private Sub ViewInterfacesButton_Click(sender As Object, e As EventArgs) Handles ViewInterfacesButton.Click
        'Runs netsh command when clicked as its difficult to get CMD output and put that inside an object in the form
        Process.Start("cmd", String.Format("/k netsh interface show interface"))
    End Sub
    
    Private Sub SetIPbutton_Click(sender As Object, e As EventArgs) Handles SetIPbutton.Click
        Dim ExecString As String = "/k netsh interface ip set address """ 'Have to have double quotes here so it will add quotations in command properly
        Dim DNSpriString As String = "/k netsh interface ipv4 add dnsserver """
        Dim DNSsecString As String = "/k netsh interface ipv4 add dnsserver """

        'Checks which radio button is checked, then appends proper commands and runs in CMD
        If DHCPradioButton.Checked = True Then
            ExecString = ExecString + InterfaceNameTextBox.Text + """ dhcp"
            Process.Start("cmd", ExecString)
            Return
        End If

        If StaticIPRadioButton.Checked = True Then
            'Must be run with an Elevated Administrator Commmand Prompt or it will fail
            ExecString = ExecString + InterfaceNameTextBox.Text + """ static " + StaticIPtextBox.Text + " " + SubnetMaskTextBox.Text + " " + DefaultGatewayTextBox.Text + " 1"
            Process.Start("cmd", ExecString)

            'Deletes all DNS servers currently in the list and places the custom DNS server as the first one
            Process.Start("cmd", "delete dnsserver """ + InterfaceNameTextBox.Text + """ all")

            'Sets primary DNS using whatever input there is from the Custom DNS text box
            DNSpriString = DNSpriString + InterfaceNameTextBox.Text + """ address=" + SetPrimaryDNSTextBox.Text + " index=1"
            Process.Start("cmd", DNSpriString)
            Return

            'If the Secondary DNS text box is NOT empty, then set a secondary DNS inputted by the user
            If SetSecondaryDNSTextBox.Text <> "" Then
                DNSsecString = DNSsecString + InterfaceNameTextBox.Text + """ address=" + SetPrimaryDNSTextBox.Text + " index=2"
                Process.Start("cmd", DNSsecString)
                Return
            End If
        End If
    End Sub


    'Radio buttons
    Private Sub DHCPradioButton_CheckedChanged(sender As Object, e As EventArgs) Handles DHCPradioButton.CheckedChanged
        'Disables the custom input text boxes so they wont be passed on
        If DHCPradioButton.Checked = True Then
            StaticIPRadioButton.Checked = False
            StaticIPtextBox.Enabled = False
            SubnetMaskTextBox.Enabled = False
            DefaultGatewayTextBox.Enabled = False
            SetPrimaryDNSTextBox.Enabled = False
            SetSecondaryDNSTextBox.Enabled = False
        End If
    End Sub

    Private Sub StaticIPRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles StaticIPRadioButton.CheckedChanged
        'Enables custom input text boxes which are auto filled on form launch to make it easier for the user
        If StaticIPRadioButton.Checked = True Then
            DHCPradioButton.Checked = False
            StaticIPtextBox.Enabled = True
            SubnetMaskTextBox.Enabled = True
            DefaultGatewayTextBox.Enabled = True
            SetPrimaryDNSTextBox.Enabled = True
            SetSecondaryDNSTextBox.Enabled = True
        End If
    End Sub

    Private Sub CommandPromptLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles CommandPromptLinkLabel.LinkClicked
        Process.Start("cmd")
    End Sub

    
End Class