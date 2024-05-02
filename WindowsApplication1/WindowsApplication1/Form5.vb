Public Class Form5
    Public k1, k2, k3, k4, k5, k6 As Double
    Public m1, m2, m3, m4, m5, m6 As Integer
    Private Sub فايكنجToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles فايكنجToolStripMenuItem.Click
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

    Private Sub Form5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PictureBox1.Image = My.Resources.k1
        PictureBox2.Image = My.Resources.k2
        PictureBox3.Image = My.Resources.k3
        PictureBox4.Image = My.Resources.k4
        PictureBox5.Image = My.Resources.k5
        PictureBox6.Image = My.Resources.k6

        Button2.Enabled = False
        Button3.Enabled = False
        Button5.Enabled = False
        Button7.Enabled = False
        Button10.Enabled = False
        Button11.Enabled = False

        TextBox1.Text = "وجبه زنجر صغيرة,قطعة صدر دجاج مقرمش,صلصه فايكنك الخاصة"
        TextBox2.Text = "وجبه زنجر وسط,قطعة صدر دجاج مقرمش,مايونيز,كاتشب,صلصة فايكنك الخاصة"
        TextBox3.Text = "وجبه كنتاكي كبيرة,ست قطع دجاج مقرمش,فنكر,صلصة فايكنك الخاصة"
        TextBox4.Text = "سندويش زنجر ,صدر جاج مقرمش,فنكر,خس,مايونيز,كاتشب,صلصة فايكنك الخاصة"
        TextBox5.Text = "وجبه كنتاكي صغير,اربع قطع دجاج مقرمش,صلصة فايكنك خاصة"
        TextBox6.Text = "وجبه هوت دوغ ,هوت دوغ,خس,طماطم,فنكر,خردل,صلصة فايكنك الخاصة"
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        m1 = Integer.Parse(Label7.Text)
        Label7.Text = Convert.ToString(m1 + 1)
        k1 = Double.Parse(Label13.Text)
        Label13.Text = Convert.ToString(k1 + 3500)
        Button2.Enabled = True
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        m2 = Integer.Parse(Label8.Text)
        Label8.Text = Convert.ToString(m2 - 1)
        k2 = Double.Parse(Label14.Text)
        Label14.Text = Convert.ToString(k2 - 4000)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        m1 = Integer.Parse(Label7.Text)
        Label7.Text = Convert.ToString(m1 - 1)
        k1 = Double.Parse(Label13.Text)
        Label13.Text = Convert.ToString(k1 - 3500)
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        m2 = Integer.Parse(Label8.Text)
        Label8.Text = Convert.ToString(m2 + 1)
        k2 = Double.Parse(Label14.Text)
        Label14.Text = Convert.ToString(k2 + 4000)
        Button3.Enabled = True
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        m3 = Integer.Parse(Label9.Text)
        Label9.Text = Convert.ToString(m3 + 1)
        k3 = Double.Parse(Label15.Text)
        Label15.Text = Convert.ToString(k3 + 8000)
        Button5.Enabled = True
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        m4 = Integer.Parse(Label10.Text)
        Label10.Text = Convert.ToString(m4 + 1)
        k4 = Double.Parse(Label16.Text)
        Label16.Text = Convert.ToString(k4 + 3000)
        Button7.Enabled = True
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        m5 = Integer.Parse(Label11.Text)
        Label11.Text = Convert.ToString(m5 + 1)
        k5 = Double.Parse(Label17.Text)
        Label17.Text = Convert.ToString(k5 + 5000)
        Button10.Enabled = True
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        m6 = Integer.Parse(Label12.Text)
        Label12.Text = Convert.ToString(m6 + 1)
        k6 = Double.Parse(Label18.Text)
        Label18.Text = Convert.ToString(k6 + 4500)
        Button11.Enabled = True
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        m3 = Integer.Parse(Label9.Text)
        Label9.Text = Convert.ToString(m3 - 1)
        k3 = Double.Parse(Label15.Text)
        Label15.Text = Convert.ToString(k3 - 8000)
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        m4 = Integer.Parse(Label10.Text)
        Label10.Text = Convert.ToString(m4 - 1)
        k4 = Double.Parse(Label16.Text)
        Label16.Text = Convert.ToString(k4 - 3000)
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        m5 = Integer.Parse(Label11.Text)
        Label11.Text = Convert.ToString(m5 - 1)
        k5 = Double.Parse(Label17.Text)
        Label17.Text = Convert.ToString(k5 - 5000)
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        m6 = Integer.Parse(Label12.Text)
        Label12.Text = Convert.ToString(m6 - 1)
        k6 = Double.Parse(Label18.Text)
        Label18.Text = Convert.ToString(k6 - 4500)
    End Sub

    Private Sub مشروباتغازيةToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles مشروباتغازيةToolStripMenuItem.Click
        Me.Hide()
        Form7.Show()

    End Sub

    Private Sub الدفعToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles الدفعToolStripMenuItem.Click
        Me.Hide()
        Form8.Show()

    End Sub
End Class