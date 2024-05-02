Public Class Form7
    Public p1, p2, p3, p4, p5, p6 As Double
    Public n1, n2, n3, n4, n5, n6 As Integer
    Private Sub Form7_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PictureBox1.Image = My.Resources.P1
        PictureBox2.Image = My.Resources.P2
        PictureBox3.Image = My.Resources.P3
        PictureBox4.Image = My.Resources.P4
        PictureBox5.Image = My.Resources.q2
        PictureBox6.Image = My.Resources.P6

        Button2.Enabled = False
        Button3.Enabled = False
        Button5.Enabled = False
        Button7.Enabled = False
        Button10.Enabled = False
        Button11.Enabled = False

        TextBox1.Text = "ببسي"
        TextBox2.Text = "سفن"
        TextBox3.Text = "ميرندا تفاح"
        TextBox4.Text = "ميرندا حمضيات"
        TextBox5.Text = "ميرندا برتقال"
        TextBox6.Text = "مياه معدنيه"

    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        n1 = Integer.Parse(Label7.Text)
        Label7.Text = Convert.ToString(n1 + 1)
        p1 = Double.Parse(Label13.Text)
        Label13.Text = Convert.ToString(p1 + 1000)
        Button2.Enabled = True
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        n2 = Integer.Parse(Label8.Text)
        Label8.Text = Convert.ToString(n2 - 1)
        p2 = Double.Parse(Label14.Text)
        Label14.Text = Convert.ToString(p2 - 1000)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        n1 = Integer.Parse(Label7.Text)
        Label7.Text = Convert.ToString(n1 - 1)
        p1 = Double.Parse(Label13.Text)
        Label13.Text = Convert.ToString(p1 - 1000)
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        n2 = Integer.Parse(Label8.Text)
        Label8.Text = Convert.ToString(n2 + 1)
        p2 = Double.Parse(Label14.Text)
        Label14.Text = Convert.ToString(p2 + 1000)
        Button3.Enabled = True
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        n3 = Integer.Parse(Label9.Text)
        Label9.Text = Convert.ToString(n3 + 1)
        p3 = Double.Parse(Label15.Text)
        Label15.Text = Convert.ToString(p3 + 1000)
        Button5.Enabled = True
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        n4 = Integer.Parse(Label10.Text)
        Label10.Text = Convert.ToString(n4 + 1)
        p4 = Double.Parse(Label16.Text)
        Label16.Text = Convert.ToString(p4 + 1000)
        Button7.Enabled = True
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        n5 = Integer.Parse(Label11.Text)
        Label11.Text = Convert.ToString(n5 + 1)
        p5 = Double.Parse(Label17.Text)
        Label17.Text = Convert.ToString(p5 + 1000)
        Button10.Enabled = True
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        n6 = Integer.Parse(Label12.Text)
        Label12.Text = Convert.ToString(n6 + 1)
        p6 = Double.Parse(Label18.Text)
        Label18.Text = Convert.ToString(p6 + 500)
        Button11.Enabled = True
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        n3 = Integer.Parse(Label9.Text)
        Label9.Text = Convert.ToString(n3 - 1)
        p3 = Double.Parse(Label15.Text)
        Label15.Text = Convert.ToString(p3 - 1000)
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        n4 = Integer.Parse(Label10.Text)
        Label10.Text = Convert.ToString(n4 - 1)
        p4 = Double.Parse(Label16.Text)
        Label16.Text = Convert.ToString(p4 - 1000)
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        n5 = Integer.Parse(Label11.Text)
        Label11.Text = Convert.ToString(n5 - 1)
        p5 = Double.Parse(Label17.Text)
        Label17.Text = Convert.ToString(p5 - 1000)
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        n6 = Integer.Parse(Label12.Text)
        Label12.Text = Convert.ToString(n6 - 1)
        p6 = Double.Parse(Label18.Text)
        Label18.Text = Convert.ToString(p6 - 500)
    End Sub

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

    Private Sub مقرمشاتالدجاجToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles مقرمشاتالدجاجToolStripMenuItem.Click
        Me.Hide()
        Form5.Show()

    End Sub

    
    Private Sub الدفعToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles الدفعToolStripMenuItem.Click
        Me.Hide()
        Form8.Show()
    End Sub
End Class