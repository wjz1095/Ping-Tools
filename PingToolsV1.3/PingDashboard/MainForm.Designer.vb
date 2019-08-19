<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PingDashboardForm
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
        Me.PingButton = New System.Windows.Forms.Button()
        Me.NslookupButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PathPingButton = New System.Windows.Forms.Button()
        Me.TraceRouteButton = New System.Windows.Forms.Button()
        Me.CustomIPtextBox = New System.Windows.Forms.TextBox()
        Me.IPRadioButton = New System.Windows.Forms.RadioButton()
        Me.DomainNameRadioButton = New System.Windows.Forms.RadioButton()
        Me.IPorDomainGroupBox = New System.Windows.Forms.GroupBox()
        Me.PingTimeGroupBox = New System.Windows.Forms.GroupBox()
        Me.NumOfPacketsCheckBox = New System.Windows.Forms.CheckBox()
        Me.PingForeverCheckBox = New System.Windows.Forms.CheckBox()
        Me.NumofPacketsTextBox = New System.Windows.Forms.TextBox()
        Me.ComcastNodesComboBox = New System.Windows.Forms.ComboBox()
        Me.DNSserverComboBox = New System.Windows.Forms.ComboBox()
        Me.WebsitesComboBox = New System.Windows.Forms.ComboBox()
        Me.CustomIPCheckBox = New System.Windows.Forms.CheckBox()
        Me.ProtocolVersionGroupBox = New System.Windows.Forms.GroupBox()
        Me.IPv6RadioButton = New System.Windows.Forms.RadioButton()
        Me.IPv4RadioButton = New System.Windows.Forms.RadioButton()
        Me.CustomDomainCheckBox = New System.Windows.Forms.CheckBox()
        Me.CustomDomainTextBox = New System.Windows.Forms.TextBox()
        Me.NslookupCheckBox = New System.Windows.Forms.CheckBox()
        Me.NslookupTextBox = New System.Windows.Forms.TextBox()
        Me.ServiceStatusLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.DNSbenchmarkLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.LastUpdatedLabel = New System.Windows.Forms.Label()
        Me.ToolInformationLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.NotepadLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.CommandPromptLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.IPorDomainGroupBox.SuspendLayout()
        Me.PingTimeGroupBox.SuspendLayout()
        Me.ProtocolVersionGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'PingButton
        '
        Me.PingButton.Location = New System.Drawing.Point(201, 377)
        Me.PingButton.Name = "PingButton"
        Me.PingButton.Size = New System.Drawing.Size(87, 23)
        Me.PingButton.TabIndex = 0
        Me.PingButton.Text = "Ping"
        Me.PingButton.UseVisualStyleBackColor = True
        '
        'NslookupButton
        '
        Me.NslookupButton.Enabled = False
        Me.NslookupButton.Location = New System.Drawing.Point(294, 377)
        Me.NslookupButton.Name = "NslookupButton"
        Me.NslookupButton.Size = New System.Drawing.Size(87, 23)
        Me.NslookupButton.TabIndex = 1
        Me.NslookupButton.Text = "NsLookup"
        Me.NslookupButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 116)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Websites:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "DNS Servers:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Comcast Nodes:"
        '
        'PathPingButton
        '
        Me.PathPingButton.Location = New System.Drawing.Point(108, 377)
        Me.PathPingButton.Name = "PathPingButton"
        Me.PathPingButton.Size = New System.Drawing.Size(87, 23)
        Me.PathPingButton.TabIndex = 9
        Me.PathPingButton.Text = "PathPing"
        Me.PathPingButton.UseVisualStyleBackColor = True
        '
        'TraceRouteButton
        '
        Me.TraceRouteButton.Location = New System.Drawing.Point(15, 377)
        Me.TraceRouteButton.Name = "TraceRouteButton"
        Me.TraceRouteButton.Size = New System.Drawing.Size(87, 23)
        Me.TraceRouteButton.TabIndex = 10
        Me.TraceRouteButton.Text = "Tracert"
        Me.TraceRouteButton.UseVisualStyleBackColor = True
        '
        'CustomIPtextBox
        '
        Me.CustomIPtextBox.Enabled = False
        Me.CustomIPtextBox.Location = New System.Drawing.Point(274, 179)
        Me.CustomIPtextBox.Name = "CustomIPtextBox"
        Me.CustomIPtextBox.Size = New System.Drawing.Size(120, 20)
        Me.CustomIPtextBox.TabIndex = 11
        '
        'IPRadioButton
        '
        Me.IPRadioButton.AutoSize = True
        Me.IPRadioButton.Location = New System.Drawing.Point(6, 19)
        Me.IPRadioButton.Name = "IPRadioButton"
        Me.IPRadioButton.Size = New System.Drawing.Size(76, 17)
        Me.IPRadioButton.TabIndex = 13
        Me.IPRadioButton.TabStop = True
        Me.IPRadioButton.Text = "IP Address"
        Me.IPRadioButton.UseVisualStyleBackColor = True
        '
        'DomainNameRadioButton
        '
        Me.DomainNameRadioButton.AutoSize = True
        Me.DomainNameRadioButton.Location = New System.Drawing.Point(6, 42)
        Me.DomainNameRadioButton.Name = "DomainNameRadioButton"
        Me.DomainNameRadioButton.Size = New System.Drawing.Size(92, 17)
        Me.DomainNameRadioButton.TabIndex = 14
        Me.DomainNameRadioButton.TabStop = True
        Me.DomainNameRadioButton.Text = "Domain Name"
        Me.DomainNameRadioButton.UseVisualStyleBackColor = True
        '
        'IPorDomainGroupBox
        '
        Me.IPorDomainGroupBox.Controls.Add(Me.IPRadioButton)
        Me.IPorDomainGroupBox.Controls.Add(Me.DomainNameRadioButton)
        Me.IPorDomainGroupBox.Location = New System.Drawing.Point(15, 172)
        Me.IPorDomainGroupBox.Name = "IPorDomainGroupBox"
        Me.IPorDomainGroupBox.Size = New System.Drawing.Size(138, 93)
        Me.IPorDomainGroupBox.TabIndex = 15
        Me.IPorDomainGroupBox.TabStop = False
        Me.IPorDomainGroupBox.Text = "Use IP or Domain?"
        '
        'PingTimeGroupBox
        '
        Me.PingTimeGroupBox.Controls.Add(Me.NumOfPacketsCheckBox)
        Me.PingTimeGroupBox.Controls.Add(Me.PingForeverCheckBox)
        Me.PingTimeGroupBox.Controls.Add(Me.NumofPacketsTextBox)
        Me.PingTimeGroupBox.Location = New System.Drawing.Point(15, 271)
        Me.PingTimeGroupBox.Name = "PingTimeGroupBox"
        Me.PingTimeGroupBox.Size = New System.Drawing.Size(138, 100)
        Me.PingTimeGroupBox.TabIndex = 16
        Me.PingTimeGroupBox.TabStop = False
        Me.PingTimeGroupBox.Text = "How long to Ping?"
        '
        'NumOfPacketsCheckBox
        '
        Me.NumOfPacketsCheckBox.AutoSize = True
        Me.NumOfPacketsCheckBox.Location = New System.Drawing.Point(7, 44)
        Me.NumOfPacketsCheckBox.Name = "NumOfPacketsCheckBox"
        Me.NumOfPacketsCheckBox.Size = New System.Drawing.Size(90, 17)
        Me.NumOfPacketsCheckBox.TabIndex = 4
        Me.NumOfPacketsCheckBox.Text = "# of Packets:"
        Me.NumOfPacketsCheckBox.UseVisualStyleBackColor = True
        '
        'PingForeverCheckBox
        '
        Me.PingForeverCheckBox.AutoSize = True
        Me.PingForeverCheckBox.Location = New System.Drawing.Point(7, 19)
        Me.PingForeverCheckBox.Name = "PingForeverCheckBox"
        Me.PingForeverCheckBox.Size = New System.Drawing.Size(62, 17)
        Me.PingForeverCheckBox.TabIndex = 3
        Me.PingForeverCheckBox.Text = "Forever"
        Me.PingForeverCheckBox.UseVisualStyleBackColor = True
        '
        'NumofPacketsTextBox
        '
        Me.NumofPacketsTextBox.Enabled = False
        Me.NumofPacketsTextBox.Location = New System.Drawing.Point(7, 64)
        Me.NumofPacketsTextBox.Name = "NumofPacketsTextBox"
        Me.NumofPacketsTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NumofPacketsTextBox.TabIndex = 2
        '
        'ComcastNodesComboBox
        '
        Me.ComcastNodesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComcastNodesComboBox.FormattingEnabled = True
        Me.ComcastNodesComboBox.Items.AddRange(New Object() {"", "Comcast.net|96.120.73.221", "te-6-2-ur01.raritan.nj.panjde.comcast.net|68.86.221.129", "be-39-ar03.plainfield.nj.panjde.comcast.net|162.151.210.173", "be-33659-cr02.newyork.ny.ibone.comcast.net|68.86.90.21", "hu-0-11-0-4-pe02.111eighthave.ny.ibone.comcast.net|68.86.87.170", "be-10203-cr01.newark.nj.ibone.comcast.net|68.86.85.185", "be-10249-pe03.newark.nj.ibone.comcast.net|68.86.85.90", "be-10102-cr02.ashburn.va.ibone.comcast.net|68.86.85.161", "hu-0-10-0-3-pe04.ashburn.va.ibone.comcast.net|68.86.82.218", "as46489-1-c.350ecermak.il.ibone.comcast.net|23.30.206.190", "be-10114-cr02.56marietta.ga.ibone.comcast.net|68.86.85.10", "be-11422-cr02.miami.fl.ibone.comcast.net|68.86.84.154", "be-12274-pe01.nota.fl.ibone.comcast.net|68.86.82.154"})
        Me.ComcastNodesComboBox.Location = New System.Drawing.Point(15, 81)
        Me.ComcastNodesComboBox.Name = "ComcastNodesComboBox"
        Me.ComcastNodesComboBox.Size = New System.Drawing.Size(379, 21)
        Me.ComcastNodesComboBox.TabIndex = 17
        '
        'DNSserverComboBox
        '
        Me.DNSserverComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem
        Me.DNSserverComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DNSserverComboBox.FormattingEnabled = True
        Me.DNSserverComboBox.Items.AddRange(New Object() {"", "Comcast DNS1|75.75.75.75", "Comcast DNS2|75.75.76.76", "Comodo Secure DNS1|8.26.56.26", "Comodo Secure DNS2|8.20.247.20", "DNS Watch 1|84.200.69.80", "DNS Watch 2|84.200.70.40", "Google DNS 1|8.8.8.8", "Google DNS 2|8.8.4.4", "GreenTeamDNS1|81.218.119.11", "GreenTeamDNS2|209.88.198.133", "Hurricane Electric DNS|74.82.42.42", "Level3 DNS 1|4.2.2.1", "Level3 DNS 2|4.2.2.2", "Level3 DNS 3|4.2.2.3", "Level3 DNS 4|4.2.2.4", "Level3 DNS 5|4.2.2.5", "OpenDNS|208.67.222.222", "OpenDNS2|208.67.220.220", "Quad9 DNS1|9.9.9.9", "Quad9 DNS2|149.112.112.112", "SafeDNS1|195.46.39.39", "SafeDNS2|195.46.39.40", "UncensoredDNS 1|91.239.100.100", "UncensoredDNS 2|89.233.43.71", "Verisign DNS 1|64.6.64.6", "Verisign DNS 2|64.6.65.6"})
        Me.DNSserverComboBox.Location = New System.Drawing.Point(15, 31)
        Me.DNSserverComboBox.Name = "DNSserverComboBox"
        Me.DNSserverComboBox.Size = New System.Drawing.Size(379, 21)
        Me.DNSserverComboBox.TabIndex = 18
        '
        'WebsitesComboBox
        '
        Me.WebsitesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.WebsitesComboBox.FormattingEnabled = True
        Me.WebsitesComboBox.Items.AddRange(New Object() {"", "-----WEBSITES-----", "Amazon.com|54.239.17.6", "App.snapchat.com|216.239.39.126", "Discord.gg|104.16.59.37", "Drive.google.com|172.217.12.238", "DuckDuckGo.com|107.21.1.61", "Ebay.com|66.135.209.52", "Facebook.com|157.240.14.35", "Github.com|192.30.253.112", "Gmail.com|172.217.6.197", "Google.com|172.217.6.206", "Iamresponding.com|104.17.253.46", "Imgur.com", "Lifehacker.com|151.101.2.166", "Netflix.com|54.209.96.16", "NJ.com|216.146.46.10", "Play.google.com|172.217.6.238", "Reddit.com|151.101.65.140", "Spotify.com|104.154.127.47", "Store.steampowered.com|104.69.220.169", "Ubnt.com|54.71.247.231", "Youtube.com|172.217.6.206", "", "#####SERVICES#####", "", "-----BACKBONE-----", "Cdnjs.cloudflare.com|104.19.164.102", "S3.amazonaws.com|52.216.130.29", "", "-----FACEBOOK-----", "B-api.facebook.com|31.13.68.228", "Facebook.com|31.13.71.36", "Scontent.xx.fbcdn.net|31.13.69.203", "Star.c10r.facebook.com|31.13.69.197", "Star-mini.c10r.facebook.com|31.13.69.228", "Video.xx.fbcdn.net|31.13.69.202", "", "-----GOOGLE-----", "Accounts.google.com|172.217.6.237", "APIs.google.com|172.217.6.238", "Clients.L.google.com|172.217.6.238", "Google.com|172.217.6.238", "S.Youtube.com|172.217.10.78", "Storage.googleapis.com|172.217.10.240", "Storage.L.googleusercontent.com|172.217.10.240", "Video-stats.L.google.com|172.217.10.14", "", "-----LINUX-----", "Archive.raspberrypi.org|93.93.128.133", "Mirrordirector.raspbian.org|93.93.128.193", "Old-releases.ubuntu.com|91.189.88.17", "Security.ubuntu.com|91.189.88.149", "US.archive.ubuntu.com|91.189.91.26", "", "-----MAIL-----", "Googlemail.L.google.com|172.217.10.229", "Mail.google.com|172.217.10.229", "Mail.yahoo.com|69.147.92.11", "POP.gmail.com|209.85.201.109", "SMTP.gmail.com|173.194.205.108", "SMTP.mail.yahoo.com|63.250.193.228", "", "-----OTHER-----", "API-global.netflix.com|52.1.230.75", "App.snapchat.com|216.239.39.126"})
        Me.WebsitesComboBox.Location = New System.Drawing.Point(12, 133)
        Me.WebsitesComboBox.Name = "WebsitesComboBox"
        Me.WebsitesComboBox.Size = New System.Drawing.Size(382, 21)
        Me.WebsitesComboBox.TabIndex = 19
        '
        'CustomIPCheckBox
        '
        Me.CustomIPCheckBox.AutoSize = True
        Me.CustomIPCheckBox.Enabled = False
        Me.CustomIPCheckBox.Location = New System.Drawing.Point(165, 182)
        Me.CustomIPCheckBox.Name = "CustomIPCheckBox"
        Me.CustomIPCheckBox.Size = New System.Drawing.Size(80, 17)
        Me.CustomIPCheckBox.TabIndex = 20
        Me.CustomIPCheckBox.Text = "Custom IP?"
        Me.CustomIPCheckBox.UseVisualStyleBackColor = True
        '
        'ProtocolVersionGroupBox
        '
        Me.ProtocolVersionGroupBox.Controls.Add(Me.IPv6RadioButton)
        Me.ProtocolVersionGroupBox.Controls.Add(Me.IPv4RadioButton)
        Me.ProtocolVersionGroupBox.Location = New System.Drawing.Point(159, 271)
        Me.ProtocolVersionGroupBox.Name = "ProtocolVersionGroupBox"
        Me.ProtocolVersionGroupBox.Size = New System.Drawing.Size(109, 100)
        Me.ProtocolVersionGroupBox.TabIndex = 21
        Me.ProtocolVersionGroupBox.TabStop = False
        Me.ProtocolVersionGroupBox.Text = "Protocol Version:"
        '
        'IPv6RadioButton
        '
        Me.IPv6RadioButton.AutoSize = True
        Me.IPv6RadioButton.Location = New System.Drawing.Point(6, 44)
        Me.IPv6RadioButton.Name = "IPv6RadioButton"
        Me.IPv6RadioButton.Size = New System.Drawing.Size(47, 17)
        Me.IPv6RadioButton.TabIndex = 1
        Me.IPv6RadioButton.TabStop = True
        Me.IPv6RadioButton.Text = "IPv6"
        Me.IPv6RadioButton.UseVisualStyleBackColor = True
        '
        'IPv4RadioButton
        '
        Me.IPv4RadioButton.AutoSize = True
        Me.IPv4RadioButton.Location = New System.Drawing.Point(6, 20)
        Me.IPv4RadioButton.Name = "IPv4RadioButton"
        Me.IPv4RadioButton.Size = New System.Drawing.Size(47, 17)
        Me.IPv4RadioButton.TabIndex = 0
        Me.IPv4RadioButton.TabStop = True
        Me.IPv4RadioButton.Text = "IPv4"
        Me.IPv4RadioButton.UseVisualStyleBackColor = True
        '
        'CustomDomainCheckBox
        '
        Me.CustomDomainCheckBox.AutoSize = True
        Me.CustomDomainCheckBox.Enabled = False
        Me.CustomDomainCheckBox.Location = New System.Drawing.Point(165, 208)
        Me.CustomDomainCheckBox.Name = "CustomDomainCheckBox"
        Me.CustomDomainCheckBox.Size = New System.Drawing.Size(106, 17)
        Me.CustomDomainCheckBox.TabIndex = 22
        Me.CustomDomainCheckBox.Text = "Custom Domain?"
        Me.CustomDomainCheckBox.UseVisualStyleBackColor = True
        '
        'CustomDomainTextBox
        '
        Me.CustomDomainTextBox.Enabled = False
        Me.CustomDomainTextBox.Location = New System.Drawing.Point(274, 205)
        Me.CustomDomainTextBox.Name = "CustomDomainTextBox"
        Me.CustomDomainTextBox.Size = New System.Drawing.Size(120, 20)
        Me.CustomDomainTextBox.TabIndex = 23
        '
        'NslookupCheckBox
        '
        Me.NslookupCheckBox.AutoSize = True
        Me.NslookupCheckBox.Location = New System.Drawing.Point(166, 234)
        Me.NslookupCheckBox.Name = "NslookupCheckBox"
        Me.NslookupCheckBox.Size = New System.Drawing.Size(81, 17)
        Me.NslookupCheckBox.TabIndex = 24
        Me.NslookupCheckBox.Text = "NsLookup?"
        Me.NslookupCheckBox.UseVisualStyleBackColor = True
        '
        'NslookupTextBox
        '
        Me.NslookupTextBox.Enabled = False
        Me.NslookupTextBox.Location = New System.Drawing.Point(274, 232)
        Me.NslookupTextBox.Name = "NslookupTextBox"
        Me.NslookupTextBox.Size = New System.Drawing.Size(120, 20)
        Me.NslookupTextBox.TabIndex = 25
        '
        'ServiceStatusLinkLabel
        '
        Me.ServiceStatusLinkLabel.AutoSize = True
        Me.ServiceStatusLinkLabel.Location = New System.Drawing.Point(274, 322)
        Me.ServiceStatusLinkLabel.Name = "ServiceStatusLinkLabel"
        Me.ServiceStatusLinkLabel.Size = New System.Drawing.Size(123, 13)
        Me.ServiceStatusLinkLabel.TabIndex = 26
        Me.ServiceStatusLinkLabel.TabStop = True
        Me.ServiceStatusLinkLabel.Text = "Service Status Websites"
        '
        'DNSbenchmarkLinkLabel
        '
        Me.DNSbenchmarkLinkLabel.AutoSize = True
        Me.DNSbenchmarkLinkLabel.Enabled = False
        Me.DNSbenchmarkLinkLabel.Location = New System.Drawing.Point(274, 288)
        Me.DNSbenchmarkLinkLabel.Name = "DNSbenchmarkLinkLabel"
        Me.DNSbenchmarkLinkLabel.Size = New System.Drawing.Size(111, 13)
        Me.DNSbenchmarkLinkLabel.TabIndex = 27
        Me.DNSbenchmarkLinkLabel.TabStop = True
        Me.DNSbenchmarkLinkLabel.Text = "DNS Benchmark Tool"
        '
        'LastUpdatedLabel
        '
        Me.LastUpdatedLabel.AutoSize = True
        Me.LastUpdatedLabel.Location = New System.Drawing.Point(12, 403)
        Me.LastUpdatedLabel.Name = "LastUpdatedLabel"
        Me.LastUpdatedLabel.Size = New System.Drawing.Size(166, 13)
        Me.LastUpdatedLabel.TabIndex = 28
        Me.LastUpdatedLabel.Text = "Last Updated 2/16/2018 5:30AM"
        '
        'ToolInformationLinkLabel
        '
        Me.ToolInformationLinkLabel.AutoSize = True
        Me.ToolInformationLinkLabel.Location = New System.Drawing.Point(274, 339)
        Me.ToolInformationLinkLabel.Name = "ToolInformationLinkLabel"
        Me.ToolInformationLinkLabel.Size = New System.Drawing.Size(83, 13)
        Me.ToolInformationLinkLabel.TabIndex = 29
        Me.ToolInformationLinkLabel.TabStop = True
        Me.ToolInformationLinkLabel.Text = "Tool Information"
        '
        'NotepadLinkLabel
        '
        Me.NotepadLinkLabel.AutoSize = True
        Me.NotepadLinkLabel.Location = New System.Drawing.Point(274, 305)
        Me.NotepadLinkLabel.Name = "NotepadLinkLabel"
        Me.NotepadLinkLabel.Size = New System.Drawing.Size(48, 13)
        Me.NotepadLinkLabel.TabIndex = 30
        Me.NotepadLinkLabel.TabStop = True
        Me.NotepadLinkLabel.Text = "Notepad"
        '
        'CommandPromptLinkLabel
        '
        Me.CommandPromptLinkLabel.AutoSize = True
        Me.CommandPromptLinkLabel.Location = New System.Drawing.Point(274, 271)
        Me.CommandPromptLinkLabel.Name = "CommandPromptLinkLabel"
        Me.CommandPromptLinkLabel.Size = New System.Drawing.Size(90, 13)
        Me.CommandPromptLinkLabel.TabIndex = 31
        Me.CommandPromptLinkLabel.TabStop = True
        Me.CommandPromptLinkLabel.Text = "Command Prompt"
        '
        'PingDashboardForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.ClientSize = New System.Drawing.Size(404, 420)
        Me.Controls.Add(Me.CommandPromptLinkLabel)
        Me.Controls.Add(Me.NotepadLinkLabel)
        Me.Controls.Add(Me.ToolInformationLinkLabel)
        Me.Controls.Add(Me.LastUpdatedLabel)
        Me.Controls.Add(Me.DNSbenchmarkLinkLabel)
        Me.Controls.Add(Me.ServiceStatusLinkLabel)
        Me.Controls.Add(Me.NslookupTextBox)
        Me.Controls.Add(Me.NslookupCheckBox)
        Me.Controls.Add(Me.CustomDomainTextBox)
        Me.Controls.Add(Me.CustomDomainCheckBox)
        Me.Controls.Add(Me.ProtocolVersionGroupBox)
        Me.Controls.Add(Me.CustomIPCheckBox)
        Me.Controls.Add(Me.WebsitesComboBox)
        Me.Controls.Add(Me.DNSserverComboBox)
        Me.Controls.Add(Me.ComcastNodesComboBox)
        Me.Controls.Add(Me.PingTimeGroupBox)
        Me.Controls.Add(Me.IPorDomainGroupBox)
        Me.Controls.Add(Me.CustomIPtextBox)
        Me.Controls.Add(Me.TraceRouteButton)
        Me.Controls.Add(Me.PathPingButton)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.NslookupButton)
        Me.Controls.Add(Me.PingButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PingDashboardForm"
        Me.ShowIcon = False
        Me.Text = "Ping Tools by Wally V1.3"
        Me.IPorDomainGroupBox.ResumeLayout(False)
        Me.IPorDomainGroupBox.PerformLayout()
        Me.PingTimeGroupBox.ResumeLayout(False)
        Me.PingTimeGroupBox.PerformLayout()
        Me.ProtocolVersionGroupBox.ResumeLayout(False)
        Me.ProtocolVersionGroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PingButton As System.Windows.Forms.Button
    Friend WithEvents NslookupButton As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PathPingButton As System.Windows.Forms.Button
    Friend WithEvents TraceRouteButton As System.Windows.Forms.Button
    Friend WithEvents CustomIPtextBox As System.Windows.Forms.TextBox
    Friend WithEvents IPRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents DomainNameRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents IPorDomainGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents PingTimeGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents NumofPacketsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ComcastNodesComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents WebsitesComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents CustomIPCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents DNSserverComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ProtocolVersionGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents IPv6RadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents IPv4RadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents NumOfPacketsCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents PingForeverCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents CustomDomainCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents CustomDomainTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NslookupCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents NslookupTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ServiceStatusLinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents DNSbenchmarkLinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents LastUpdatedLabel As System.Windows.Forms.Label
    Friend WithEvents ToolInformationLinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents NotepadLinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents CommandPromptLinkLabel As System.Windows.Forms.LinkLabel

End Class
