Public Class Form4
    Public s1, s2, s3, s4, s5, s6 As Double
    Public x1, x2, x3, x4, x5, x6 As Integer
    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PictureBox1.Image = My.Resources.s1
        PictureBox2.Image = My.Resources.s2
        PictureBox3.Image = My.Resources.s3
        PictureBox4.Image = My.Resources.s4
        PictureBox5.Image = My.Resources.s5
        PictureBox6.Image = My.Resources.s6

        Button2.Enabled = False
        Button3.Enabled = False
        Button5.Enabled = False
        Button7.Enabled = False
        Button10.Enabled = False
        Button11.Enabled = False


        TextBox1.Text = "صاج,صدر دجاج,مخلل,كاتشب ,مايونيز"
        TextBox2.Text = "صمون كهربائي,هوت دوغ,خردل,خس,مايونيز,كاتشب"
        TextBox3.Text = "صاج كبير,صدر دجاج,مخلل,كاتشب ,مايونيز"
        TextBox4.Text = "صمون كهربائي,قطع دجاج مقرمش,خس,مخلل,كاتشب,مايونيز"
        TextBox5.Text = "صاج دجاج عل الطريقة الايطاليا,صلصه فايكنك الخاصة,زيتون"
        TextBox6.Text = "صاج,شرائح لحم عراقي,صبصة فايكنك الخاصة,مايونيز,كاتشب"

    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        x1 = Integer.Parse(Label7.Text)
        Label7.Text = Convert.ToString(x1 + 1)
        s1 = Double.Parse(Label13.Text)
        Label13.Text = Convert.ToString(s1 + 2500)
        Button2.Enabled = True
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        x2 = Integer.Parse(Label8.Text)
        Label8.Text = Convert.ToString(x2 - 1)
        s2 = Double.Parse(Label14.Text)
        Label14.Text = Convert.ToString(s2 - 4000)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        x1 = Integer.Parse(Label7.Text)
        Label7.Text = Convert.ToString(x1 - 1)
        s1 = Double.Parse(Label13.Text)
        Label13.Text = Convert.ToString(s1 - 2500)
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        x2 = Integer.Parse(Label8.Text)
        Label8.Text = Convert.ToString(x2 + 1)
        s2 = Double.Parse(Label14.Text)
        Label14.Text = Convert.ToString(s2 + 4000)
        Button3.Enabled = True
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        x3 = Integer.Parse(Label9.Text)
        Label9.Text = Convert.ToString(x3 + 1)
        s3 = Double.Parse(Label15.Text)
        Label15.Text = Convert.ToString(s3 + 2500)
        Button5.Enabled = True
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        x4 = Integer.Parse(Label10.Text)
        Label10.Text = Convert.ToString(x4 + 1)
        s4 = Double.Parse(Label16.Text)
        Label16.Text = Convert.ToString(s4 + 3500)
        Button7.Enabled = True
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        x5 = Integer.Parse(Label11.Text)
        Label11.Text = Convert.ToString(x5 + 1)
        s5 = Double.Parse(Label17.Text)
        Label17.Text = Convert.ToString(s5 + 4000)
        Button10.Enabled = True
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        x6 = Integer.Parse(Label12.Text)
        Label12.Text = Convert.ToString(x6 + 1)
        s6 = Double.Parse(Label18.Text)
        Label18.Text = Convert.ToString(s6 + 3500)
        Button11.Enabled = True
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        x3 = Integer.Parse(Label9.Text)
        Label9.Text = Convert.ToString(x3 - 1)
        s3 = Double.Parse(Label15.Text)
        Label15.Text = Convert.ToString(s3 - 2500)
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        x4 = Integer.Parse(Label10.Text)
        Label10.Text = Convert.ToString(x4 - 1)
        s4 = Double.Parse(Label16.Text)
        Label16.Text = Convert.ToString(s4 - 3500)
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        x5 = Integer.Parse(Label11.Text)
        Label11.Text = Convert.ToString(x5 - 1)
        s5 = Double.Parse(Label17.Text)
        Label17.Text = Convert.ToString(s5 - 4000)
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        x6 = Integer.Parse(Label12.Text)
        Label12.Text = Convert.ToString(x6 - 1)
        s6 = Double.Parse(Label18.Text)
        Label18.Text = Convert.ToString(s6 - 3500)
    End Sub

    Private Sub مقرمشاتالدجاجToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles مقرمشاتالدجاجToolStripMenuItem.Click
        Me.Hide()
        Form5.Show()

    End Sub

    Private Sub الصاجToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles الصاجToolStripMenuItem.Click
        Me.Hide()
        Form3.Show()

    End Sub

    Private Sub فايكنجToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles فايكنجToolStripMenuItem.Click
        Me.Hide()
        Form2.Show()

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