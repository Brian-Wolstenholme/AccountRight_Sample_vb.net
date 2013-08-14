Public Class WelcomeForm

    Private Sub lnkGetStarted_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkGetStarted.LinkClicked
        Dim frmCompanyFiles As New CompanyFilesForm
        frmCompanyFiles.Show()

    End Sub
End Class