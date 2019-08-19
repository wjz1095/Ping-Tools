Public Class PingDashboardForm

    ' ''' Last Updated: 2/16/2018 12:30PM
    ' ''' Current version V1.3
    ' ''' 
    ' ''' To change on each version change:
    ' ''' -Last Updated labels on all 3 forms
    ' ''' -Main Form text property to reflect new version number
    ' ''' -Make copy of the project folder and put in repository as new version


    'Combo boxes allowing selection of domains or IP addresses
    Private Sub DNSserverComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DNSserverComboBox.SelectedIndexChanged
        'If a selection is made:
        '-Disable all other combo boxes and set their selection to blank
        '-Disable CustomIPCheckBox and CustomIPtextbox

        If DNSserverComboBox.SelectedIndex = 0 Then
            ComcastNodesComboBox.Enabled = True
            WebsitesComboBox.Enabled = True

            CustomIPCheckBox.Enabled = True
            CustomIPtextBox.Enabled = False

            DomainNameRadioButton.Checked = False
            DomainNameRadioButton.Enabled = False
        Else
            DomainNameRadioButton.Checked = False
            DomainNameRadioButton.Enabled = True

            ComcastNodesComboBox.Enabled = False
            ComcastNodesComboBox.SelectedIndex = 0

            WebsitesComboBox.Enabled = False
            WebsitesComboBox.SelectedIndex = 0

            CustomIPCheckBox.Enabled = False
            CustomIPtextBox.Enabled = False
        End If
    End Sub

    Private Sub ComcastNodesComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComcastNodesComboBox.SelectedIndexChanged
        'If a selection is made:
        '-Disable all other combo boxes and set their selection to blank
        '-Disable CustomIPCheckBox and CustomIPtextbox

        If ComcastNodesComboBox.SelectedIndex = 0 Then
            DomainNameRadioButton.Enabled = True

            DNSserverComboBox.Enabled = False
            DomainNameRadioButton.Checked = False
            WebsitesComboBox.Enabled = True

            CustomIPCheckBox.Enabled = True
            CustomIPtextBox.Enabled = False
        Else
            DomainNameRadioButton.Checked = False
            DomainNameRadioButton.Enabled = True

            DNSserverComboBox.Enabled = False
            DNSserverComboBox.SelectedIndex = 0

            WebsitesComboBox.Enabled = False
            WebsitesComboBox.SelectedIndex = 0

            CustomIPCheckBox.Enabled = False
            CustomIPtextBox.Enabled = False
        End If
    End Sub

    Private Sub WebsitesComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles WebsitesComboBox.SelectedIndexChanged
        'If a selection is made:
        '-Disable all other combo boxes and set their selection to blank
        '-Disable CustomIPCheckBox and CustomIPtextbox

        If WebsitesComboBox.SelectedIndex = 0 Then
            DomainNameRadioButton.Enabled = True

            DNSserverComboBox.Enabled = True
            ComcastNodesComboBox.Enabled = True

            CustomIPCheckBox.Enabled = True
            CustomIPtextBox.Enabled = False
        Else
            DNSserverComboBox.Enabled = False
            DNSserverComboBox.SelectedIndex = 0

            ComcastNodesComboBox.Enabled = False
            ComcastNodesComboBox.SelectedIndex = 0

            CustomIPCheckBox.Enabled = False
            CustomIPtextBox.Enabled = False
        End If

    End Sub


    'How long to ping check and text boxes
    Private Sub PingForeverCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles PingForeverCheckBox.CheckedChanged
        'If box is checked:
        '-Uncheck NumOfPackets check box if its checked
        '-Disable NumOfPackets text box
        '-Empties NumOfPackets text box if there is anything there
        '-Disable Tracert button
        '-Disable PathPing button

        'If box is unchecked:
        '-Enable NumOfPackets check box
        '-Enable NumofPackets text box
        '-Enable Tracert button
        '-Enable PathPing button

        If PingForeverCheckBox.Checked = True Then
            NumOfPacketsCheckBox.Checked = False
            NumOfPacketsCheckBox.Enabled = False
            NumofPacketsTextBox.Enabled = False
            NumofPacketsTextBox.Text = ""
            TraceRouteButton.Enabled = False
            PathPingButton.Enabled = False
        Else
            NumOfPacketsCheckBox.Enabled = True
            NumofPacketsTextBox.Enabled = False
            TraceRouteButton.Enabled = True
            PathPingButton.Enabled = True
        End If

    End Sub
 
    Private Sub NumOfPacketsCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles NumOfPacketsCheckBox.CheckedChanged
        'If box is checked:
        '-Enable NumOfPackets text box because it's disabled by default on startup
        '-Disable PingForever check box
        '-Uncheck PingForever check box if checked
        '-Disable Tracert button
        '-Disable PathPing button

        'If box is unchecked:
        '-Enable PingForever check box
        '-Disable NumofPackets text box
        '-Enable Tracert button
        '-Enable PathPing button

        If NumOfPacketsCheckBox.Checked = True Then
            NumofPacketsTextBox.Enabled = True
            PingForeverCheckBox.Enabled = False
            PingForeverCheckBox.Checked = False
            TraceRouteButton.Enabled = False
            PathPingButton.Enabled = False
        Else
            PingForeverCheckBox.Enabled = True
            NumofPacketsTextBox.Enabled = False
            NumofPacketsTextBox.Text = ""
            TraceRouteButton.Enabled = True
            PathPingButton.Enabled = True
        End If
    End Sub


    'Custom IP, Domain, and NSlookup check boxes
    Private Sub CustomIPCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles CustomIPCheckBox.CheckedChanged
        'If this box is checked
        '-Enable the text box below it

        'If not checked
        '-Disable text box below it and clear it

        If CustomIPCheckBox.Checked = True Then
            CustomIPtextBox.Enabled = True
            CustomDomainTextBox.Enabled = False
            CustomDomainCheckBox.Checked = False
            CustomDomainTextBox.Text = ""
            DNSserverComboBox.Enabled = False
            DNSserverComboBox.SelectedIndex = 0
            ComcastNodesComboBox.Enabled = False
            ComcastNodesComboBox.SelectedIndex = 0
            WebsitesComboBox.Enabled = False
            WebsitesComboBox.SelectedIndex = 0
        Else
            DNSserverComboBox.Enabled = True
            DNSserverComboBox.SelectedIndex = 0
            ComcastNodesComboBox.Enabled = True
            ComcastNodesComboBox.SelectedIndex = 0
            WebsitesComboBox.Enabled = True
            WebsitesComboBox.SelectedIndex = 0
            CustomIPtextBox.Enabled = False
            CustomIPtextBox.Text = ""
        End If
    End Sub

    Private Sub CustomDomainCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles CustomDomainCheckBox.CheckedChanged
        If CustomDomainCheckBox.Checked = True Then
            CustomDomainTextBox.Enabled = True
            CustomIPCheckBox.Checked = False
            CustomIPCheckBox.Enabled = False
            CustomIPtextBox.Enabled = False
            CustomIPtextBox.Text = ""
            DNSserverComboBox.Enabled = False
            DNSserverComboBox.SelectedIndex = 0
            ComcastNodesComboBox.Enabled = False
            ComcastNodesComboBox.SelectedIndex = 0
            WebsitesComboBox.Enabled = False
            WebsitesComboBox.SelectedIndex = 0
        Else
            DNSserverComboBox.Enabled = True
            DNSserverComboBox.SelectedIndex = 0
            ComcastNodesComboBox.Enabled = True
            ComcastNodesComboBox.SelectedIndex = 0
            WebsitesComboBox.Enabled = True
            WebsitesComboBox.SelectedIndex = 0
            CustomDomainTextBox.Enabled = False
            CustomDomainTextBox.Text = ""
        End If
    End Sub

    Private Sub NslookupCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles NslookupCheckBox.CheckedChanged
        If NslookupCheckBox.Checked = True Then
            NslookupTextBox.Enabled = True
            NslookupTextBox.Text = ""
            NslookupButton.Enabled = True
            DisableAllForms()
        Else
            NslookupTextBox.Enabled = False
            NslookupTextBox.Text = ""
            NslookupButton.Enabled = False
            EnableAllForms()
        End If
    End Sub


    'IP and Domain radio buttons
    Private Sub IPRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles IPRadioButton.CheckedChanged
        If IPRadioButton.Checked = True Then
            CustomIPCheckBox.Enabled = True
            CustomIPCheckBox.Checked = False
            CustomDomainTextBox.Text = ""
            CustomDomainTextBox.Enabled = False
            CustomDomainCheckBox.Enabled = False
            CustomDomainCheckBox.Checked = False
            NslookupCheckBox.Enabled = False
            NslookupCheckBox.Checked = False
        Else
            CustomIPCheckBox.Enabled = False
            NslookupCheckBox.Enabled = True
        End If
    End Sub

    Private Sub DomainNameRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles DomainNameRadioButton.CheckedChanged
        If DomainNameRadioButton.Checked = True Then
            CustomIPCheckBox.Enabled = False
            CustomIPCheckBox.Checked = False
            CustomIPtextBox.Enabled = False
            CustomIPtextBox.Text = ""
            CustomDomainCheckBox.Enabled = True
            NslookupCheckBox.Enabled = False
            NslookupCheckBox.Checked = False
        Else
            NslookupCheckBox.Enabled = True
            CustomIPCheckBox.Enabled = True
        End If
    End Sub


    'Buttons at the bottom of the form
    Private Sub TraceRouteButton_Click(sender As Object, e As EventArgs) Handles TraceRouteButton.Click
        Dim ExecuteString As String = ""
        'When this button is pressed:

        'If IPRadioButton is selected:
        '-Check all of the drop down boxes and then grep the IP from the selection made
        '-Check if CustomIPCheckBox is selected and a valid IP is entered, if so use it, if not throw error
        '-Check if IPv4 or IPv6 radio button is selected; if IPv4 is selected append "-4" to end of command; if IPv6 is selected append "-6" top end of command
        '-Run an instance of Command Prompt and pass the command as follows: "tracert <IP> <IPv4 or IPv6>"

        'If DomainRadioButton is selected:
        '-Check all of the drop down boxes and then grep the Domain from the selection made
        '-Check if IPv4 or IPv6 radio button is selected; if IPv4 is selected append "-4" to end of command; if IPv6 is selected append "-6" to end of command
        '-Run an instance of Command Prompt and pass the command as follows: "tracert <domain> <IPv4 or IPv6>"

        '-Deselect any radio buttons in the "How Long to Ping" group box
        '-Clears any text in NumOfPackets text box
        PingForeverCheckBox.Checked = False
        NumOfPacketsCheckBox.Checked = False
        NumofPacketsTextBox.Text = ""

        '-Check if IP or Domain button is checked, then check whether IPv4 or 6 is selected, and run CMD with proper command
        If IPRadioButton.Checked = True Then
            If IPv4RadioButton.Checked = True Then
                '-Check all of the drop down boxes and then grep the IP from the selection made

                If CustomIPCheckBox.Checked = True Then
                    ExecuteString = "/k tracert " + " -4 " + CustomIPtextBox.Text
                    Process.Start("cmd", String.Format(ExecuteString))
                    Console.WriteLine(ExecuteString + "1")
                    Return
                End If

                ExecuteString = "/k tracert " + " -4 " + GetDomainOrIP()
                Process.Start("cmd", String.Format(ExecuteString))
                Console.WriteLine(ExecuteString + "2")
                Return
            ElseIf IPv6RadioButton.Checked = True Then
                If CustomIPCheckBox.Checked = True Then
                    ExecuteString = "/k tracert " + "-6 " + CustomIPtextBox.Text
                    Process.Start("cmd", String.Format(ExecuteString))
                    Console.WriteLine(ExecuteString + "3")
                    Return
                End If

                ExecuteString = "/k tracert " + "-6 " + GetDomainOrIP()
                Process.Start("cmd", String.Format(ExecuteString))
                Console.WriteLine(ExecuteString + "4")
                Return
            End If

        ElseIf DomainNameRadioButton.Checked = True Then
            If IPv4RadioButton.Checked = True Then
                If CustomDomainCheckBox.Checked = True Then
                    ExecuteString = "/k tracert " + "-4 " + CustomDomainTextBox.Text
                    Process.Start("cmd", String.Format(ExecuteString))
                    Console.WriteLine(ExecuteString + "5")
                    Return
                End If
                ''''''                'Get DOMAIN from drop down boxes to put in here
                ExecuteString = "/k tracert " + "-4 " + GetDomainOrIP()
                Process.Start("cmd", String.Format(ExecuteString))
                Console.WriteLine(ExecuteString + "6")
                Return
            ElseIf IPv6RadioButton.Checked = True Then
                '-Check all of the drop down boxes and then grep the IP from the selection made
                If CustomDomainCheckBox.Checked = True Then
                    ExecuteString = "/k tracert " + "-6 " + CustomDomainTextBox.Text
                    Process.Start("cmd", String.Format(ExecuteString))
                    Console.WriteLine(ExecuteString + "7")
                    Return
                End If
                '''''''''Get IP from drop down boxes and put in here
                ExecuteString = "/k tracert " + "-6 " + GetDomainOrIP()
                Process.Start("cmd", String.Format(ExecuteString))
                Console.WriteLine(ExecuteString + "8")
                Return
            End If
        End If
    End Sub

    Private Sub PathPingButton_Click(sender As Object, e As EventArgs) Handles PathPingButton.Click
        Dim ExecuteString As String = ""
        'When this button is pressed:

        'If IPRadioButton is selected:
        '-Check all of the drop down boxes and then grep the IP from the selection made
        '-Check if CustomIPCheckBox is selected and a valid IP is entered, if so use it, if not throw error
        '-Check if IPv4 or IPv6 radio button is selected; if IPv4 is selected append "-4" to end of command; if IPv6 is selected append "-6" top end of command
        '-Run an instance of Command Prompt and pass the command as follows: "tracert <IP> <IPv4 or IPv6>"

        'If DomainRadioButton is selected:
        '-Check all of the drop down boxes and then grep the Domain from the selection made
        '-Check if IPv4 or IPv6 radio button is selected; if IPv4 is selected append "-4" to end of command; if IPv6 is selected append "-6" to end of command
        '-Run an instance of Command Prompt and pass the command as follows: "tracert <domain> <IPv4 or IPv6>"

        '-Deselect any radio buttons in the "How Long to Ping" group box
        '-Clears any text in NumOfPackets text box
        PingForeverCheckBox.Checked = False
        NumOfPacketsCheckBox.Checked = False
        NumofPacketsTextBox.Text = ""

        '-Check if IP or Domain button is checked, then check whether IPv4 or 6 is selected, and run CMD with proper command
        If IPRadioButton.Checked = True Then
            If IPv4RadioButton.Checked = True Then
                '-Check all of the drop down boxes and then grep the IP from the selection made

                If CustomIPCheckBox.Checked = True Then
                    ExecuteString = "/k pathping " + CustomIPtextBox.Text + " -4"
                    Process.Start("cmd", String.Format(ExecuteString))
                    Return
                End If

                ''''''                'Get IP from drop down boxes to put in here
                ExecuteString = "/k pathping " + GetDomainOrIP() + " -4"
                Process.Start("cmd", String.Format(ExecuteString))
                Return
            ElseIf IPv6RadioButton.Checked = True Then
                If CustomIPCheckBox.Checked = True Then
                    ExecuteString = "/k pathping " + CustomIPtextBox.Text + " -6"
                    Process.Start("cmd", String.Format(ExecuteString))
                    Return
                End If

                ExecuteString = "/k pathping " + GetDomainOrIP() + " -6"
                Process.Start("cmd", String.Format(ExecuteString))
                Return
            End If

        ElseIf DomainNameRadioButton.Checked = True Then
            If IPv4RadioButton.Checked = True Then
                If CustomDomainCheckBox.Checked = True Then
                    ExecuteString = "/k pathping " + CustomDomainTextBox.Text + " -4"
                    Process.Start("cmd", String.Format(ExecuteString))
                    Return
                End If
                ''''''                'Get DOMAIN from drop down boxes to put in here
                ExecuteString = "/k pathping " + GetDomainOrIP() + " -4"
                Process.Start("cmd", String.Format(ExecuteString))
                Return
            ElseIf IPv6RadioButton.Checked = True Then
                '-Check all of the drop down boxes and then grep the IP from the selection made
                If CustomDomainCheckBox.Checked = True Then
                    ExecuteString = "/k pathping " + CustomDomainTextBox.Text + " -6"
                    Process.Start("cmd", String.Format(ExecuteString))
                    Return
                End If
                '''''''''Get IP from drop down boxes and put in here
                ExecuteString = "/k pathping " + GetDomainOrIP() + " -6"
                Process.Start("cmd", String.Format(ExecuteString))
                Return
            End If
        End If
    End Sub

    Private Sub PingButton_Click(sender As Object, e As EventArgs) Handles PingButton.Click
        'When this button is pressed:

        Dim ExecuteString As String = ""
        Dim TempString As String = ""

        'If IPRadioButton is selected:
        '-Check all of the drop down boxes and then grep the IP from the selection made
        '-Check if CustomIPCheckBox is selected and a valid IP is entered, if so use it, if not throw error
        '-Check if IPv4 or IPv6 radio button is selected; if IPv4 is selected append "-4" to end of command; if IPv6 is selected append "-6" top end of command
        '-Run an instance of Command Prompt and pass the command as follows: "ping <IP> <IPv4 or IPv6>"

        'If DomainRadioButton is selected:
        '-Check all of the drop down boxes and then grep the Domain from the selection made
        '-Check if IPv4 or IPv6 radio button is selected; if IPv4 is selected append "-4" to end of command; if IPv6 is selected append "-6" to end of command
        '-Run an instance of Command Prompt and pass the command as follows: "ping <domain> <IPv4 or IPv6>"

        '-Check if IP or Domain button is checked, then check whether IPv4 or 6 is selected, and run CMD with proper command
        If IPRadioButton.Checked = True Then
            If IPv4RadioButton.Checked = True Then
                '-Check all of the drop down boxes and then grep the IP from the selection made

                If CustomIPCheckBox.Checked = True Then
                    If PingForeverCheckBox.Checked = True Then
                        ExecuteString = "/k ping -t " + CustomIPtextBox.Text + " -4"
                        Process.Start("cmd", String.Format(ExecuteString))
                        Return
                    ElseIf NumOfPacketsCheckBox.Checked = True Then
                        ExecuteString = "/k ping -n " + NumofPacketsTextBox.Text + " " + CustomIPtextBox.Text + " -4"
                        Process.Start("cmd", String.Format(ExecuteString))
                        Return
                    End If

                    ExecuteString = "/k ping " + CustomIPtextBox.Text + " -4"
                    Process.Start("cmd", String.Format(ExecuteString))
                    Return
                End If

                If PingForeverCheckBox.Checked = True Then
                    '''''''''''''''''''''''''''-Get value from box and add to command below
                    ExecuteString = "/k ping " + GetDomainOrIP() + " -t -4"
                    Process.Start("cmd", String.Format(ExecuteString))
                    Return
                ElseIf NumOfPacketsCheckBox.Checked = True Then
                    '-Check value of the text box and append "-n <number>" to the command
                    '''''''           '-Run instance of command prompt and pass command as follows "ping -n <number> <IP> -4"
                    ExecuteString = "/k ping " + GetDomainOrIP() + " -4 -n " + NumofPacketsTextBox.Text
                    Process.Start("cmd", String.Format(ExecuteString))
                    Return
                End If

                ''''''                'Get IP from drop down boxes to put in here
                ExecuteString = "/k ping " + GetDomainOrIP() + " -t -4"
                Process.Start("cmd", String.Format(ExecuteString))
                Return
            ElseIf IPv6RadioButton.Checked = True Then
                '-Check all of the drop down boxes and then grep the IP from the selection made

                If CustomIPCheckBox.Checked = True Then
                    If PingForeverCheckBox.Checked = True Then
                        ExecuteString = "/k ping -t " + CustomIPtextBox.Text + " -6"
                        Process.Start("cmd", String.Format(ExecuteString))
                        Return
                    ElseIf NumOfPacketsCheckBox.Checked = True Then
                        ExecuteString = "/k ping -n " + NumofPacketsTextBox.Text + " " + CustomIPtextBox.Text + " -6"
                        Process.Start("cmd", String.Format(ExecuteString))
                        Return
                    End If

                    ExecuteString = "/k ping " + CustomIPtextBox.Text + " -6"
                    Process.Start("cmd", String.Format(ExecuteString))
                    Return
                End If
                

                If PingForeverCheckBox.Checked = True Then
                '-Get value from box and add to command
                ''''''''          '-Append "-t" to command
                '-Run instance of command prompt and pass command as follows "ping -t <IP> -4"
                    ExecuteString = "/k ping " + GetDomainOrIP() + " -t -6"
                Process.Start("cmd", String.Format(ExecuteString))
                Return
            ElseIf NumOfPacketsCheckBox.Checked = True Then
                '-Check value of the text box and append "-n <number>" to the command
                '''''''           '-Run instance of command prompt and pass command as follows "ping -n <number> <IP> -4"
                    ExecuteString = "/k ping " + GetDomainOrIP() + " -t -6 -n " + NumofPacketsTextBox.Text
                Process.Start("cmd", String.Format(ExecuteString))
                Return
            End If
            '''''''''Get IP from drop down boxes and put in here
                ExecuteString = "/k ping " + GetDomainOrIP() + " -t -6"
            Process.Start("cmd", String.Format(ExecuteString))
            Return
            End If

        ElseIf DomainNameRadioButton.Checked = True Then
            If IPv4RadioButton.Checked = True Then
                '-Check all of the drop down boxes and then grep the IP from the selection made

                If PingForeverCheckBox.Checked = True Then
                    '-Get value from box and add to command
                    If CustomDomainCheckBox.Checked = True Then
                        ExecuteString = "/k ping " + CustomDomainTextBox.Text + " -4 -t"
                        Process.Start("cmd", String.Format(ExecuteString))
                        Return
                    End If
                    ''''''''          '-Append "-t" to command
                    '-Run instance of command prompt and pass command as follows "ping -t <IP> -4"
                    ExecuteString = "/k ping " + GetDomainOrIP() + " -t -4"
                    Process.Start("cmd", String.Format(ExecuteString))
                    Return
                ElseIf NumOfPacketsCheckBox.Checked = True Then
                    If CustomDomainCheckBox.Checked = True Then
                        ExecuteString = "/k ping " + CustomDomainTextBox.Text + " -4 -n " + NumofPacketsTextBox.Text
                        Process.Start("cmd", String.Format(ExecuteString))
                        Return
                    End If
                    '-Check value of the text box and append "-n <number>" to the command
                    '''''''           '-Run instance of command prompt and pass command as follows "ping -n <number> <IP> -4"
                    ExecuteString = "/k ping " + GetDomainOrIP() + " -t -4"
                    Process.Start("cmd", String.Format(ExecuteString))
                    Return
                End If

                If CustomDomainCheckBox.Checked = True Then
                    ExecuteString = "/k ping " + CustomDomainTextBox.Text + " -4"
                    Process.Start("cmd", String.Format(ExecuteString))
                    Return
                End If

                ''''''                'Get DOMAIN from drop down boxes to put in here
                ExecuteString = "/k ping " + GetDomainOrIP() + " -t -4"
                Process.Start("cmd", String.Format(ExecuteString))
                Return
            ElseIf IPv6RadioButton.Checked = True Then
                '-Check all of the drop down boxes and then grep the IP from the selection made

                If PingForeverCheckBox.Checked = True Then
                    If CustomDomainCheckBox.Checked = True Then
                        ExecuteString = "/k ping " + CustomDomainTextBox.Text + " -6"
                        Process.Start("cmd", String.Format(ExecuteString))
                        Return
                    End If
                    '-Get value from box and add to command
                    ''''''''          '-Append "-t" to command
                    ExecuteString = "/k ping " + GetDomainOrIP() + " -t -6"
                    Process.Start("cmd", String.Format(ExecuteString))
                    Return
                ElseIf NumOfPacketsCheckBox.Checked = True Then
                    If CustomDomainCheckBox.Checked = True Then
                        ExecuteString = "/k ping " + CustomDomainTextBox.Text + " -6"
                        Process.Start("cmd", String.Format(ExecuteString))
                        Return
                    End If
                    '-Check value of the text box and append "-n <number>" to the command
                    '''''''           '-Run instance of command prompt and pass command as follows "ping -n <number> <IP> -4"
                    ExecuteString = "/k ping " + GetDomainOrIP() + " -t -6"
                    Process.Start("cmd", String.Format(ExecuteString))
                    Return
                End If

                If CustomDomainCheckBox.Checked = True Then
                    ExecuteString = "/k ping " + CustomDomainTextBox.Text + " -6"
                    Process.Start("cmd", String.Format(ExecuteString))
                    Return
                End If
                '''''''''Get IP from drop down boxes and put in here
                ExecuteString = "/k ping " + GetDomainOrIP() + " -t -6"
                Process.Start("cmd", String.Format(ExecuteString))
                Return
            End If
        End If
    End Sub

    Private Sub NslookupButton_Click(sender As Object, e As EventArgs) Handles NslookupButton.Click
        Dim ExecuteString As String = "/k nslookup " + NslookupTextBox.Text
        Process.Start("cmd", String.Format(ExecuteString))
        Return
    End Sub



    'Functions used by buttons
    Public Function GetDomainOrIP() As String
        Dim Get_String As String = ""
        Dim OutputString As String = ""

        If DNSserverComboBox.Enabled = True Then
            Get_String = DNSserverComboBox.SelectedItem

            If IPRadioButton.Checked = True Then
                Dim index As Integer = Get_String.IndexOf("|")
                index = index + 1
                OutputString = Get_String.Substring(index)
                '-Read string until it hits the | character
                '-Output string = string from the index of the | character +1 to the end of the string
            End If

        ElseIf ComcastNodesComboBox.Enabled = True Then
            Get_String = ComcastNodesComboBox.SelectedItem

            If DomainNameRadioButton.Checked = True Then
                Dim index As Integer = Get_String.IndexOf("|")
                OutputString = Get_String.Substring(0, index)
                '-Read string until it hits the | character
                '-Output string = string from index 0 to the index of the | character -1
            ElseIf IPRadioButton.Checked = True Then
                Dim index As Integer = Get_String.IndexOf("|")
                index = index + 1
                OutputString = Get_String.Substring(index)
                '-Read string until it hits the | character
                '-Output string = string from the index of the | character +1 to the end of the string
            End If


        ElseIf WebsitesComboBox.Enabled = True Then
            Get_String = WebsitesComboBox.SelectedItem
            If DomainNameRadioButton.Checked = True Then
                Dim index As Integer = Get_String.IndexOf("|")
                OutputString = Get_String.Substring(0, index)
                '-Read string until it hits the | character
                '-Output string = string from index 0 to the index of the | character -1
            ElseIf IPRadioButton.Checked = True Then
                Dim index As Integer = Get_String.IndexOf("|")
                index = index + 1
                OutputString = Get_String.Substring(index)
                '-Read string until it hits the | character
                '-Output string = string from the index of the | character +1 to the end of the string
            End If

        End If

        Trim(OutputString)
        Return OutputString
    End Function

    Public Sub DisableAllForms()
        DNSserverComboBox.Enabled = False
        ComcastNodesComboBox.Enabled = False
        WebsitesComboBox.Enabled = False

        IPRadioButton.Enabled = False
        IPRadioButton.Checked = False

        DomainNameRadioButton.Enabled = False
        DomainNameRadioButton.Checked = False

        PingForeverCheckBox.Checked = False
        PingForeverCheckBox.Enabled = False

        NumOfPacketsCheckBox.Enabled = False
        NumOfPacketsCheckBox.Checked = False
        NumofPacketsTextBox.Enabled = False
        NumofPacketsTextBox.Text = ""

        CustomIPCheckBox.Enabled = False
        CustomIPCheckBox.Checked = False
        CustomIPtextBox.Enabled = False
        CustomIPtextBox.Text = ""

        CustomDomainCheckBox.Enabled = False
        CustomDomainCheckBox.Checked = False
        CustomDomainTextBox.Enabled = False
        CustomDomainTextBox.Text = ""

        IPv4RadioButton.Checked = False
        IPv4RadioButton.Enabled = False
        IPv6RadioButton.Checked = False
        IPv6RadioButton.Enabled = False

        TraceRouteButton.Enabled = False
        PathPingButton.Enabled = False
        PingButton.Enabled = False
    End Sub

    Public Sub EnableAllForms()
        DNSserverComboBox.Enabled = True
        ComcastNodesComboBox.Enabled = True
        WebsitesComboBox.Enabled = True

        IPRadioButton.Enabled = True
        IPRadioButton.Checked = False

        DomainNameRadioButton.Enabled = True
        DomainNameRadioButton.Checked = False

        PingForeverCheckBox.Checked = False
        PingForeverCheckBox.Enabled = True

        NumOfPacketsCheckBox.Enabled = True
        NumOfPacketsCheckBox.Checked = False
        NumofPacketsTextBox.Enabled = False
        NumofPacketsTextBox.Text = ""

        CustomIPCheckBox.Enabled = False
        CustomIPCheckBox.Checked = False
        CustomIPtextBox.Enabled = False
        CustomIPtextBox.Text = ""

        CustomDomainCheckBox.Enabled = False
        CustomDomainCheckBox.Checked = False
        CustomDomainTextBox.Enabled = False
        CustomDomainTextBox.Text = ""

        IPv4RadioButton.Checked = False
        IPv4RadioButton.Enabled = True
        IPv6RadioButton.Checked = False
        IPv6RadioButton.Enabled = True

        TraceRouteButton.Enabled = True
        PathPingButton.Enabled = True
        PingButton.Enabled = True
    End Sub


    'LinkLabels on the Main Form in the order they appear
    Private Sub CommandPromptLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles CommandPromptLinkLabel.LinkClicked
        Process.Start("cmd")
    End Sub

    Private Sub DNSbenchmarkLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles DNSbenchmarkLinkLabel.LinkClicked
        '-Figure out how to embed the DNS benchmark .exe in this and make it open when clicking on this link
    End Sub

    Private Sub NotepadLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles NotepadLinkLabel.LinkClicked
        'Literally just opens notepad
        Process.Start("notepad")
        Return
    End Sub

    Private Sub ServiceStatusLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles ServiceStatusLinkLabel.LinkClicked
        'Just opens another form/window with links to all of the service status pages
        StatusWebsiteLinksForm.Show()
    End Sub

    Private Sub ToolInformationLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles ToolInformationLinkLabel.LinkClicked
        'Opens the ToolInformationForm with information about all the tools available
        ToolInformationForm.Show()

        'Sets the scroll position to 0,0 when clicked
        ToolInformationForm.AutoScrollPosition = New Point(Math.Abs(0), Math.Abs(0))
    End Sub
End Class
