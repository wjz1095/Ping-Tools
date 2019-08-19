Public Class ToolInformationForm

    Private Sub CommandPromptLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles CommandPromptLinkLabel.LinkClicked
        Process.Start("cmd")
    End Sub
End Class