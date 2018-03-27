Public Class images

    Private Sub images_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub images_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub PictureBox1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseMove
        End
    End Sub

    Private Sub tmr_nextimage_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmr_nextimage.Tick
        Dim rndnr As Integer
        Randomize()
        rndnr = Int(Rnd() * Form1.lst_files.Items.Count)
        PictureBox1.Image = Image.FromFile(Form1.lst_files.Items.Item(rndnr))
    End Sub
End Class