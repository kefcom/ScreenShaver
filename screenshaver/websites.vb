Public Class websites

    Private Sub tmr_nexturl_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmr_nexturl.Tick
        Dim rndnr As Integer
        Randomize()
        rndnr = Int(Rnd() * Form1.lst_urls.Items.Count)
        WebBrowser1.Navigate(Form1.lst_urls.Items.Item(rndnr))
    End Sub

    Private Sub WebBrowser1_DocumentCompleted(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted

    End Sub
End Class