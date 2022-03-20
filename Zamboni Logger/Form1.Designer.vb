<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ApplicationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Phantoms = New System.Windows.Forms.RadioButton()
        Me.BlackBear = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.HeavyFlood = New System.Windows.Forms.RadioButton()
        Me.MediumFlood = New System.Windows.Forms.RadioButton()
        Me.LightFlood = New System.Windows.Forms.RadioButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.HeavyCut = New System.Windows.Forms.RadioButton()
        Me.MediumCut = New System.Windows.Forms.RadioButton()
        Me.LightCut = New System.Windows.Forms.RadioButton()
        Me.Logs = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ApplicationToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(503, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ApplicationToolStripMenuItem
        '
        Me.ApplicationToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExportDataToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.ApplicationToolStripMenuItem.Name = "ApplicationToolStripMenuItem"
        Me.ApplicationToolStripMenuItem.Size = New System.Drawing.Size(100, 24)
        Me.ApplicationToolStripMenuItem.Text = "Application"
        '
        'ExportDataToolStripMenuItem
        '
        Me.ExportDataToolStripMenuItem.Name = "ExportDataToolStripMenuItem"
        Me.ExportDataToolStripMenuItem.Size = New System.Drawing.Size(171, 26)
        Me.ExportDataToolStripMenuItem.Text = "Export Data"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(171, 26)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(262, 43)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(213, 113)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 334)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(482, 29)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Submit Ice Cut"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Phantoms)
        Me.GroupBox1.Controls.Add(Me.BlackBear)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 193)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(99, 76)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Rink"
        '
        'Phantoms
        '
        Me.Phantoms.AutoSize = True
        Me.Phantoms.Location = New System.Drawing.Point(0, 52)
        Me.Phantoms.Name = "Phantoms"
        Me.Phantoms.Size = New System.Drawing.Size(95, 24)
        Me.Phantoms.TabIndex = 1
        Me.Phantoms.TabStop = True
        Me.Phantoms.Text = "Phantoms"
        Me.Phantoms.UseVisualStyleBackColor = True
        '
        'BlackBear
        '
        Me.BlackBear.AutoSize = True
        Me.BlackBear.Location = New System.Drawing.Point(0, 26)
        Me.BlackBear.Name = "BlackBear"
        Me.BlackBear.Size = New System.Drawing.Size(99, 24)
        Me.BlackBear.TabIndex = 0
        Me.BlackBear.TabStop = True
        Me.BlackBear.Text = "Black Bear"
        Me.BlackBear.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ComboBox1)
        Me.GroupBox2.Location = New System.Drawing.Point(128, 193)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(113, 76)
        Me.GroupBox2.TabIndex = 17
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Operator"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"J.T. McQuigg"})
        Me.ComboBox1.Location = New System.Drawing.Point(6, 26)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(101, 28)
        Me.ComboBox1.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.HeavyFlood)
        Me.GroupBox3.Controls.Add(Me.MediumFlood)
        Me.GroupBox3.Controls.Add(Me.LightFlood)
        Me.GroupBox3.Location = New System.Drawing.Point(256, 193)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(105, 114)
        Me.GroupBox3.TabIndex = 18
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Flood Type"
        '
        'HeavyFlood
        '
        Me.HeavyFlood.AutoSize = True
        Me.HeavyFlood.Location = New System.Drawing.Point(6, 83)
        Me.HeavyFlood.Name = "HeavyFlood"
        Me.HeavyFlood.Size = New System.Drawing.Size(71, 24)
        Me.HeavyFlood.TabIndex = 2
        Me.HeavyFlood.TabStop = True
        Me.HeavyFlood.Text = "Heavy"
        Me.HeavyFlood.UseVisualStyleBackColor = True
        '
        'MediumFlood
        '
        Me.MediumFlood.AutoSize = True
        Me.MediumFlood.Location = New System.Drawing.Point(6, 53)
        Me.MediumFlood.Name = "MediumFlood"
        Me.MediumFlood.Size = New System.Drawing.Size(85, 24)
        Me.MediumFlood.TabIndex = 1
        Me.MediumFlood.TabStop = True
        Me.MediumFlood.Text = "Medium"
        Me.MediumFlood.UseVisualStyleBackColor = True
        '
        'LightFlood
        '
        Me.LightFlood.AutoSize = True
        Me.LightFlood.Location = New System.Drawing.Point(6, 23)
        Me.LightFlood.Name = "LightFlood"
        Me.LightFlood.Size = New System.Drawing.Size(63, 24)
        Me.LightFlood.TabIndex = 0
        Me.LightFlood.TabStop = True
        Me.LightFlood.Text = "Light"
        Me.LightFlood.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.HeavyCut)
        Me.GroupBox4.Controls.Add(Me.MediumCut)
        Me.GroupBox4.Controls.Add(Me.LightCut)
        Me.GroupBox4.Location = New System.Drawing.Point(379, 193)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(115, 114)
        Me.GroupBox4.TabIndex = 19
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Cut Type"
        '
        'HeavyCut
        '
        Me.HeavyCut.AutoSize = True
        Me.HeavyCut.Location = New System.Drawing.Point(6, 82)
        Me.HeavyCut.Name = "HeavyCut"
        Me.HeavyCut.Size = New System.Drawing.Size(71, 24)
        Me.HeavyCut.TabIndex = 2
        Me.HeavyCut.TabStop = True
        Me.HeavyCut.Text = "Heavy"
        Me.HeavyCut.UseVisualStyleBackColor = True
        '
        'MediumCut
        '
        Me.MediumCut.AutoSize = True
        Me.MediumCut.Location = New System.Drawing.Point(6, 52)
        Me.MediumCut.Name = "MediumCut"
        Me.MediumCut.Size = New System.Drawing.Size(85, 24)
        Me.MediumCut.TabIndex = 1
        Me.MediumCut.TabStop = True
        Me.MediumCut.Text = "Medium"
        Me.MediumCut.UseVisualStyleBackColor = True
        '
        'LightCut
        '
        Me.LightCut.AutoSize = True
        Me.LightCut.Location = New System.Drawing.Point(6, 23)
        Me.LightCut.Name = "LightCut"
        Me.LightCut.Size = New System.Drawing.Size(63, 24)
        Me.LightCut.TabIndex = 0
        Me.LightCut.TabStop = True
        Me.LightCut.Text = "Light"
        Me.LightCut.UseVisualStyleBackColor = True
        '
        'Logs
        '
        Me.Logs.Location = New System.Drawing.Point(12, 299)
        Me.Logs.Name = "Logs"
        Me.Logs.Size = New System.Drawing.Size(223, 29)
        Me.Logs.TabIndex = 20
        Me.Logs.Text = "View Logs"
        Me.Logs.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(14, 43)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(227, 113)
        Me.PictureBox2.TabIndex = 21
        Me.PictureBox2.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(503, 387)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Logs)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Zamboni Logger"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ApplicationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExportDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Phantoms As RadioButton
    Friend WithEvents BlackBear As RadioButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents HeavyCut As RadioButton
    Friend WithEvents MediumCut As RadioButton
    Friend WithEvents LightCut As RadioButton
    Friend WithEvents HeavyFlood As RadioButton
    Friend WithEvents MediumFlood As RadioButton
    Friend WithEvents LightFlood As RadioButton
    Friend WithEvents Logs As Button
    Friend WithEvents PictureBox2 As PictureBox
End Class
