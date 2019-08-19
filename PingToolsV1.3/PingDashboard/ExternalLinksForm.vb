Public Class StatusWebsiteLinksForm

    ''To add a link to the form:
    ''-Add LinkLabel to the form
    ''-Change name and text to reflect the action
    ''-Doubleclick to add it to the code
    ''-Paste in the line below and change the URL
    ''  System.Diagnostics.Process.Start("URL.com")

    'Status Websites Group
    Private Sub AkamaiLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles AkamaiLinkLabel.LinkClicked
        System.Diagnostics.Process.Start("https://www.akamai.com/uk/en/solutions/intelligent-platform/visualizing-akamai/real-time-web-monitor.jsp")
    End Sub

    Private Sub AmazonLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles AmazonLinkLabel.LinkClicked
        System.Diagnostics.Process.Start("http://status.aws.amazon.com/?nc2=h_l2_su")
    End Sub

    Private Sub BOINCLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles BOINCLinkLabel.LinkClicked
        System.Diagnostics.Process.Start("https://setiathome.berkeley.edu/show_server_status.php")
    End Sub

    Private Sub CloudflareLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles CloudflareLinkLabel.LinkClicked
        System.Diagnostics.Process.Start("https://www.cloudflarestatus.com/")
    End Sub

    Private Sub CloudSquareLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles CloudSquareLinkLabel.LinkClicked
        System.Diagnostics.Process.Start("https://cloudharmony.com/status")
    End Sub

    Private Sub DiscordLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles DiscordLinkLabel.LinkClicked
        System.Diagnostics.Process.Start("https://status.discordapp.com/")
    End Sub

    Private Sub GsuiteLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles GsuiteLinkLabel.LinkClicked
        System.Diagnostics.Process.Start("https://www.google.com/appsstatus#hl=en&v=status")
    End Sub

    Private Sub RockstarLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles RockstarLinkLabel.LinkClicked
        System.Diagnostics.Process.Start("https://support.rockstargames.com/hc/en-us/articles/200426246-GTA-Online-Server-Status-Latest-Updates")
    End Sub

    Private Sub NintendoLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles NintendoLinkLabel.LinkClicked
        System.Diagnostics.Process.Start("https://www.nintendo.com/consumer/network/en_na/network_status.jsp")
    End Sub

    Private Sub PlaystationStatusLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles PlaystationStatusLinkLabel.LinkClicked
        System.Diagnostics.Process.Start("https://status.playstation.com/en-US/")
    End Sub

    Private Sub SteamLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles SteamLinkLabel.LinkClicked
        System.Diagnostics.Process.Start("https://steamstat.us/")
    End Sub

    Private Sub XboxLiveLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles XboxLiveLinkLabel.LinkClicked
        System.Diagnostics.Process.Start("https://support.xbox.com/en-US/xbox-live-status")
    End Sub


    ''Outage Reports Group
    Private Sub DownForEveroneOrJustMeLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles DownForEveroneOrJustMeLinkLabel.LinkClicked
        System.Diagnostics.Process.Start("http://downforeveryoneorjustme.com/")
    End Sub

    Private Sub DownDetectorLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles DownDetectorLinkLabel.LinkClicked
        System.Diagnostics.Process.Start("http://downdetector.com/companies")
    End Sub

    Private Sub DownRightNowLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles DownRightNowLinkLabel.LinkClicked
        System.Diagnostics.Process.Start("http://downrightnow.com/")
    End Sub

    Private Sub OutageReportLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles OutageReportLinkLabel.LinkClicked
        System.Diagnostics.Process.Start("http://outage.report/")
    End Sub


    ''Speed Testing Group
    Private Sub FastComLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles FastComLinkLabel.LinkClicked
        System.Diagnostics.Process.Start("https://fast.com")
    End Sub

    Private Sub SpeakeasySpeedtestLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles SpeakeasySpeedtestLinkLabel.LinkClicked
        System.Diagnostics.Process.Start("https://www.speakeasy.net/speedtest/")
    End Sub

    Private Sub SpeedTestNetLinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles SpeedTestNetLinkLabel1.LinkClicked
        System.Diagnostics.Process.Start("https://speedtest.net")
    End Sub

    Private Sub TestMyNetLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles TestMyNetLinkLabel.LinkClicked
        System.Diagnostics.Process.Start("https://testmy.net/")
    End Sub

    Private Sub VerizonSpeedtestLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles VerizonSpeedtestLinkLabel.LinkClicked
        System.Diagnostics.Process.Start("https://www.verizon.com/speedtest/")
    End Sub

    Private Sub XfinitySpeedtestLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles XfinitySpeedtestLinkLabel.LinkClicked
        System.Diagnostics.Process.Start("http://speedtest.xfinity.com/")
    End Sub


    ''Ownership and Location Group
    Private Sub IPlocationLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles IPlocationLinkLabel.LinkClicked
        System.Diagnostics.Process.Start("https://www.iplocation.net/")
    End Sub

    Private Sub IP2locationLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles IP2locationLinkLabel.LinkClicked
        System.Diagnostics.Process.Start("http://www.ip2location.com/demo")
    End Sub

    Private Sub WhoISLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles WhoISLinkLabel.LinkClicked
        System.Diagnostics.Process.Start("https://www.whois.com/whois/")
    End Sub

    Private Sub WhoISicannLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles WhoISicannLinkLabel.LinkClicked
        System.Diagnostics.Process.Start("https://whois.icann.org/en")
    End Sub


    ''Other Links Group
    Private Sub DECIXnycLinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles DECIXnycLinkLabel1.LinkClicked
        System.Diagnostics.Process.Start("https://www.de-cix.net/en/locations/united-states/new-york/statistics")
    End Sub

    Private Sub DrawIOLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles DrawIOLinkLabel.LinkClicked
        System.Diagnostics.Process.Start("https://www.draw.io/")
    End Sub

    Private Sub NorsecorpLinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles NorsecorpLinkLabel1.LinkClicked
        System.Diagnostics.Process.Start("http://map.norsecorp.com/#/")
    End Sub

    Private Sub VirusTotalLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles VirusTotalLinkLabel.LinkClicked
        System.Diagnostics.Process.Start("https://www.virustotal.com/#/home/upload")
    End Sub

    Private Sub AkamaiExternalIPLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles AkamaiExternalIPLinkLabel.LinkClicked
        System.Diagnostics.Process.Start("http://whatismyip.akamai.com/")
    End Sub
End Class