Public Class Form2
    Public b1, b2, b3, b4, b5, b6 As Decimal
    Public C1, C2, C3, C4, C5, C6 As Integer
    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Button2.Enabled = False
        Button3.Enabled = False
        Button5.Enabled = False
        Button7.Enabled = False
        Button10.Enabled = False
        Button11.Enabled = False
        PictureBox1.Image = My.Resources.b1
        PictureBox2.Image = My.Resources.b2
        PictureBox3.Image = My.Resources.b3
        PictureBox4.Image = My.Resources.b4
        PictureBox5.Image = My.Resources.b5
        PictureBox6.Image = My.Resources.b6
        TextBox1.Text = "صمون,شريحة بركر لحم مشوية,لحم مقدد,فنكر,مايونيز,كاتشب,طماطم,خس,بصل,صلصة فايكنك الخاصة"
        TextBox2.Text = "صمون,شريحة بركر لحم مشوية,لحم مقدد,جبنة,فنكر,مايونيز,كاتشب,طماطم,خس,صلصة فايكنك الخاصة"
        TextBox3.Text = "صمون,شريحة بركر لحم مشوية حارة,لحم مقدد مدخن,فنكر,مايونيز,كاتشب,طماطم,خس,بصل,صلصة فاينكن الخاصة"
        TextBox4.Text = "صمون,شريحة بركر لحم مشوية حارة,لحم مقدد مدخن,فنكر,مايونز,كاتشب,طماطم,خس,بصل,صلصة فايكنك الخاصة"
        TextBox5.Text = "صمون,شريحتين بركر لحم مشوية,لحم مقدد,فنكر,مايونيز,كاتشب,طماطم,خس,بصل,صلصة فايكنك الخاصة"
        TextBox6.Text = "صمون,شريحة بركر لحم مشوية,فنكر,مايونيز,كاتشب,طماطم,خس,بصل,صلصة فايكنك الخاصة"
       


       



        Label8.Text = 0
        Label9.Text = 0
        Label10.Text = 0
        Label11.Text = 0
        Label12.Text = 0


    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click

    End Sub

    Private Sub PictureBox6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox6.Click

    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        C1 = Integer.Parse(Label7.Text)
        Label7.Text = Convert.ToString(C1 + 1)
        b1 = Double.Parse(Label13.Text)
        Label13.Text = Convert.ToString(b1 + 5500)
        Button2.Enabled = True
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        C2 = Integer.Parse(Label8.Text)
        Label8.Text = Convert.ToString(C2 - 1)
        b2 = Double.Parse(Label14.Text)
        Label14.Text = Convert.ToString(b2 - 6000)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        C1 = Integer.Parse(Label7.Text)
        Label7.Text = Convert.ToString(C1 - 1)
        b1 = Double.Parse(Label13.Text)
        Label13.Text = Convert.ToString(b1 - 5500)
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        C2 = Integer.Parse(Label8.Text)
        Label8.Text = Convert.ToString(C2 + 1)
        b2 = Double.Parse(Label14.Text)
        Label14.Text = Convert.ToString(b2 + 6000)
        Button3.Enabled = True
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        C3 = Integer.Parse(Label9.Text)
        Label9.Text = Convert.ToString(C3 + 1)
        b3 = Double.Parse(Label15.Text)
        Label15.Text = Convert.ToString(b3 + 6000)
        Button5.Enabled = True
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        C4 = Integer.Parse(Label10.Text)
        Label10.Text = Convert.ToString(C4 + 1)
        b4 = Double.Parse(Label16.Text)
        Label16.Text = Convert.ToString(b4 + 6000)
        Button7.Enabled = True
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        C5 = Integer.Parse(Label11.Text)
        Label11.Text = Convert.ToString(C5 + 1)
        b5 = Double.Parse(Label17.Text)
        Label17.Text = Convert.ToString(b5 + 8000)
        Button10.Enabled = True
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        C6 = Integer.Parse(Label12.Text)
        Label12.Text = Convert.ToString(C6 + 1)
        b6 = Double.Parse(Label18.Text)
        Label18.Text = Convert.ToString(b6 + 6500)
        Button11.Enabled = True
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        C3 = Integer.Parse(Label9.Text)
        Label9.Text = Convert.ToString(C3 - 1)
        b3 = Double.Parse(Label15.Text)
        Label15.Text = Convert.ToString(b3 - 6000)
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        C4 = Integer.Parse(Label10.Text)
        Label10.Text = Convert.ToString(C4 - 1)
        b4 = Double.Parse(Label16.Text)
        Label16.Text = Convert.ToString(b4 - 6000)
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        C5 = Integer.Parse(Label11.Text)
        Label11.Text = Convert.ToString(C5 - 1)
        b5 = Double.Parse(Label17.Text)
        Label17.Text = Convert.ToString(b5 - 8000)
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        C6 = Integer.Parse(Label12.Text)
        Label12.Text = Convert.ToString(C6 - 1)
        b6 = Double.Parse(Label18.Text)
        Label18.Text = Convert.ToString(b6 - 6500)
    End Sub

    Private Sub Label18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label18.Click

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

    Private Sub الدفعToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles الدفعToolStripMenuItem.Click
        Me.Hide()
        Form8.Show()

    End Sub
End Class