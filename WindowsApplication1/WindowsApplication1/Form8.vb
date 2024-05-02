Public Class Form8
    Dim pass As Integer = 2003
    Dim user As String = "montzer hadi"
    Dim card As Integer = 123456
    Dim pass2 As Integer = 2003

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub Form8_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GroupBox1.Visible = False
        GroupBox2.Visible = False




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

    Private Sub مشروباتغازيةToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles مشروباتغازيةToolStripMenuItem.Click
        Me.Hide()
        Form7.Show()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Button2.Visible = False
        GroupBox1.Visible = True

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Button1.Visible = False
        GroupBox2.Visible = True

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        If TextBox1.Text = user And TextBox2.Text = pass Then
            Button7.BackColor = Color.Honeydew
            TextBox1.Text = "montzer hadi"
            TextBox2.Text = "2003"
            MessageBox.Show("تم الطلب بنجاح")


        Else

            MessageBox.Show("الرمز او اسم المستخدم غير صحيح")
            Button7.BackColor = Color.Red

        End If



    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        If TextBox3.Text = card And TextBox4.Text = pass2 Then
            Button8.BackColor = Color.Honeydew
            TextBox3.Text = "12345"
            TextBox4.Text = "2003"
            MessageBox.Show("تم الطلب بنجاح")


        Else
            MessageBox.Show("الرمز او اسم المستخدم غير صحيح")
            Button8.BackColor = Color.Red

        End If
    End Sub
End Class