Public Class Main2

    Private precio As Integer
    Private total As Integer


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TOTAL2.Text = "USTED COMPRO UNA ENTRADA DE:" + precio.ToString("$ ##0,000")

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles SUPERVIP1.Click

        precio = 2500
        PRECIOTOTAL.Text = precio.ToString("$ ##0,000")


    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()
    End Sub

    Private Sub VIP1_Click(sender As Object, e As EventArgs) Handles VIP1.Click
        precio = 2000

        PRECIOTOTAL.Text = precio.ToString("$ ##0,000")


    End Sub

    Private Sub GENERAL1_Click(sender As Object, e As EventArgs) Handles GENERAL1.Click
        precio = 1000

        PRECIOTOTAL.Text = precio.ToString("$ ##0,000")


    End Sub
    Private Sub Main2_Load(sender As Object, e As EventArgs) Handles Me.Load
        PRECIOTOTAL.Text = ""

        TOTAL2.Text = ""


    End Sub

End Class