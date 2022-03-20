Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ApplicationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ApplicationToolStripMenuItem.Click

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Rink As String
        If Me.BlackBear.Checked Then
            Rink = "Black Bear"
        ElseIf Me.Phantoms.Checked Then
            Rink = "Phantoms"
        Else
            MessageBox.Show("Please input all Values before Submitting")
            Stop
        End If

        Dim Flood As String

        If Me.HeavyFlood.Checked Then
            Flood = "Heavy"
        ElseIf Me.MediumFlood.Checked Then
            Flood = "Medium"
        ElseIf Me.LightFlood.Checked Then
            Flood = "Light"
        Else
            MessageBox.Show("Please input all Values before Submitting")
            Stop
        End If

        Dim Cut As String

        If Me.HeavyCut.Checked Then
            Cut = "Heavy"
        ElseIf Me.MediumCut.Checked Then
            Cut = "Medium"
        ElseIf Me.LightCut.Checked Then
            Cut = "Light"
        Else
            MessageBox.Show("Please input all Values before Submitting")
            Stop
        End If







    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub RadioButton7_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub RadioButton8_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub RadioButton6_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles op.SelectedIndexChanged

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles LightFlood.CheckedChanged

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BlackBear_CheckedChanged(sender As Object, e As EventArgs) Handles BlackBear.CheckedChanged

    End Sub
End Class
