Imports System.IO
Imports System.Text

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Propane As String
        Dim Electric As String
        Dim File As String
        If My.Computer.FileSystem.FileExists("C:\ZamLogger\info.txt") Then
            File = My.Computer.FileSystem.ReadAllText("C:\ZamLogger\info.txt")
            Dim space As Integer = File.IndexOf(" ")
            Propane = File.Substring(0, space)
        Else
            Propane = "0"
            Electric = "0"
            My.Computer.FileSystem.CreateDirectory("C:\ZamLogger\")
            My.Computer.FileSystem.WriteAllText("C:\ZamLogger\info.txt", "0 0", True)
        End If
        PropaneCuts.Text = "Propane Blade Cuts: " + Propane
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
        ElseIf Me.Noflood.Checked Then
            Flood = "none"
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
        ElseIf Me.NoCut.Checked Then
            Cut = "None"
        Else
            MessageBox.Show("Please input all Values before Submitting")
            Stop
        End If

        My.Computer.FileSystem.WriteAllText("C:\Users\JTMcQ\Testfile1.txt", "Rink: " + Rink + " | Operator: " + Me.op.Text + " | Flood Type: " + Flood + " | Cut Type: " + Cut + Environment.NewLine, True)

        resetAllControls(Me)

        If Not Cut.Equals("None") Then
            If 

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

    Private Sub Logs_Click(sender As Object, e As EventArgs) Handles Logs.Click
        File.Open("C:\Users\JTMcQ\Testfile1.txt", FileMode.Open)
    End Sub
    Private Sub resetAllControls(ByVal container As Control)
        For Each ctrl As Control In container.Controls
            If TypeOf ctrl Is RadioButton Then
                DirectCast(ctrl, RadioButton).Checked = False
            ElseIf TypeOf ctrl Is TextBox Then
                DirectCast(ctrl, TextBox).Clear()
            ElseIf TypeOf ctrl Is ComboBox Then
                DirectCast(ctrl, ComboBox).SelectedIndex = -1
            End If
            If ctrl.Controls.Count > 0 Then
                resetAllControls(ctrl)
            End If
        Next
    End Sub

    Private Sub RadioButton1_CheckedChanged_1(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked Then
            Label1.Text = "Battery Levels"
            Label1.Visible = True
            ComboBox1.Visible = True
            ComboBox2.Visible = True
        Else
            Label1.Visible = False
            ComboBox1.Visible = False
            ComboBox2.Visible = False
        End If

    End Sub

    Private Sub RadioButton2_CheckedChanged_1(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked Then
            Label1.Text = "Tank Info"
            Label1.Visible = True
            ComboBox1.Items.Clear()
            ComboBox1.Items.Add("A")
            ComboBox1.Items.Add("B")
            ComboBox1.Visible = True
            ComboBox2.Items.Clear()
            ComboBox2.Visible = True
        Else
            Label1.Visible = False
            ComboBox1.Visible = False
            ComboBox2.Visible = False
        End If
    End Sub

    Private Sub ResetBladeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetBladeToolStripMenuItem.Click
        MessageBox.Show("Which Zam would you like to reset")
        My.Computer.FileSystem.DeleteFile("C:\ZamLogger\info.txt")
    End Sub

    Private Sub PropaneCuts_Click(sender As Object, e As EventArgs) Handles PropaneCuts.Click

    End Sub
End Class
