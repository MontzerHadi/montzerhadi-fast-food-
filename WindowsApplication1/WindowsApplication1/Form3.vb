Public Class Form3
    Public f1, f2, f3, f4, f5, f6 As Double
    Public z1, z2, z3, z4, z5, z6 As Integer

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PictureBox1.Image = My.Resources.f1
        PictureBox2.Image = My.Resources.f2
        PictureBox3.Image = My.Resources.f3
        PictureBox4.Image = My.Resources.f4
        PictureBox5.Image = My.Resources.f5
        PictureBox6.Image = My.Resources.f6

        Button2.Enabled = False
        Button3.Enabled = False
        Button5.Enabled = False
        Button7.Enabled = False
        Button10.Enabled = False
        Button11.Enabled = False

        TextBox1.Text = "كلاص فنكر صغير,مايونيز, كاتشب"
        TextBox2.Text = "كلاص فنكر بالجبن كبير,صلصه فايكنك الخاصة"
        TextBox3.Text = "طبق فنكر وسط,مايونيز,كاتشب"
        TextBox4.Text = "طبق فنكر كبير,مايونيز,كاتشب"
        TextBox5.Text = "طبق حلقات بصل صغير,صلصه فايكنك الخاصة"
        TextBox6.Text = "طبق حلقات بصل كبير,مايونيز,كاتشب,صلصه فايكنك الخاصة"


    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        z1 = Integer.Parse(Label7.Text)
        Label7.Text = Convert.ToString(z1 + 1)
        f1 = Double.Parse(Label13.Text)
        Label13.Text = Convert.ToString(f1 + 1500)
        Button2.Enabled = True
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        z2 = Integer.Parse(Label8.Text)
        Label8.Text = Convert.ToString(z2 - 1)
        f2 = Double.Parse(Label14.Text)
        Label14.Text = Convert.ToString(f2 - 3000)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        z1 = Integer.Parse(Label7.Text)
        Label7.Text = Convert.ToString(z1 - 1)
        f1 = Double.Parse(Label13.Text)
        Label13.Text = Convert.ToString(f1 - 1500)
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        z2 = Integer.Parse(Label8.Text)
        Label8.Text = Convert.ToString(z2 + 1)
        f2 = Double.Parse(Label14.Text)
        Label14.Text = Convert.ToString(f2 + 3000)
        Button3.Enabled = True
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        z3 = Integer.Parse(Label9.Text)
        Label9.Text = Convert.ToString(z3 + 1)
        f3 = Double.Parse(Label15.Text)
        Label15.Text = Convert.ToString(f3 + 2000)
        Button5.Enabled = True
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        z4 = Integer.Parse(Label10.Text)
        Label10.Text = Convert.ToString(z4 + 1)
        f4 = Double.Parse(Label16.Text)
        Label16.Text = Convert.ToString(f4 + 2500)
        Button7.Enabled = True
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        z5 = Integer.Parse(Label11.Text)
        Label11.Text = Convert.ToString(z5 + 1)
        f5 = Double.Parse(Label17.Text)
        Label17.Text = Convert.ToString(f5 + 2000)
        Button10.Enabled = True
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        z6 = Integer.Parse(Label12.Text)
        Label12.Text = Convert.ToString(z6 + 1)
        f6 = Double.Parse(Label18.Text)
        Label18.Text = Convert.ToString(f6 + 4000)
        Button11.Enabled = True
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        z3 = Integer.Parse(Label9.Text)
        Label9.Text = Convert.ToString(z3 - 1)
        f3 = Double.Parse(Label15.Text)
        Label15.Text = Convert.ToString(f3 - 2000)
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        z4 = Integer.Parse(Label10.Text)
        Label10.Text = Convert.ToString(z4 - 1)
        f4 = Double.Parse(Label16.Text)
        Label16.Text = Convert.ToString(f4 - 2500)
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        z5 = Integer.Parse(Label11.Text)
        Label11.Text = Convert.ToString(z5 - 1)
        f5 = Double.Parse(Label17.Text)
        Label17.Text = Convert.ToString(f5 - 2000)
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        z6 = Integer.Parse(Label12.Text)
        Label12.Text = Convert.ToString(z6 - 1)
        f6 = Double.Parse(Label18.Text)
        Label18.Text = Convert.ToString(f6 - 4000)
    End Sub

   
   
    Private Sub الصاجToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles الصاجToolStripMenuItem.Click
        Me.Hide()
        Form4.Show()

    End Sub

    Private Sub مقرمشاتالدجاجToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles مقرمشاتالدجاجToolStripMenuItem.Click
        Me.Hide()
        Form5.Show()

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