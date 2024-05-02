Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PictureBox1.Image = My.Resources.تنزيل
    End Sub

    Private Sub فايكنكبرجرToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles فايكنكبرجرToolStripMenuItem.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub المقبلاتالحارةToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles المقبلاتالحارةToolStripMenuItem.Click
        Me.Hide()
        Form3.Show()

    End Sub

    Private Sub الصاجToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles الصاجToolStripMenuItem.Click
        Me.Hide()
        Form4.Show()

    End Sub

    Private Sub مقرمشاتالدجاجToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles مقرمشاتالدجاجToolStripMenuItem.Click
        Me.Hide()
        Form5.Show()

    End Sub

    Private Sub مشروباتغازيةToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles مشروباتغازيةToolStripMenuItem.Click
        Me.Hide()
        Form7.Show()

    End Sub
End Class
