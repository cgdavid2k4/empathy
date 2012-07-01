<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class MainForm
#Region "Windows Form Designer generated code "
    <System.Diagnostics.DebuggerNonUserCode()> Public Sub New()
        MyBase.New()
        'This call is required by the Windows Form Designer.
        InitializeComponent()
    End Sub
    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
        If Disposing Then
            If Not components Is Nothing Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(Disposing)
    End Sub
    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer
    Public ToolTip1 As System.Windows.Forms.ToolTip
    Public WithEvents playOGGTF As System.Windows.Forms.TextBox
    Public WithEvents speakTF As System.Windows.Forms.TextBox
    Public WithEvents Timer1 As System.Windows.Forms.Timer
    Public WithEvents Hap1 As AxACTIVEHAPTEKXLib.AxActiveHaptekX
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents Picture1 As Microsoft.VisualBasic.Compatibility.VB6.PictureBoxArray
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.playOGGTF = New System.Windows.Forms.TextBox
        Me.speakTF = New System.Windows.Forms.TextBox
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Hap1 = New AxACTIVEHAPTEKXLib.AxActiveHaptekX
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Picture1 = New Microsoft.VisualBasic.Compatibility.VB6.PictureBoxArray(Me.components)
        Me.bgTF = New System.Windows.Forms.TextBox
        Me.bgbutton = New System.Windows.Forms.Button
        Me.speakButton = New System.Windows.Forms.Button
        Me.playOGGButton = New System.Windows.Forms.Button
        CType(Me.Hap1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Picture1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'playOGGTF
        '
        Me.playOGGTF.AcceptsReturn = True
        Me.playOGGTF.BackColor = System.Drawing.SystemColors.Window
        Me.playOGGTF.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.playOGGTF.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.playOGGTF.ForeColor = System.Drawing.SystemColors.WindowText
        Me.playOGGTF.Location = New System.Drawing.Point(8, 470)
        Me.playOGGTF.MaxLength = 0
        Me.playOGGTF.Name = "playOGGTF"
        Me.playOGGTF.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.playOGGTF.Size = New System.Drawing.Size(257, 19)
        Me.playOGGTF.TabIndex = 11
        Me.playOGGTF.Text = "ogg file"
        '
        'speakTF
        '
        Me.speakTF.AcceptsReturn = True
        Me.speakTF.BackColor = System.Drawing.SystemColors.Window
        Me.speakTF.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.speakTF.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.speakTF.ForeColor = System.Drawing.SystemColors.WindowText
        Me.speakTF.Location = New System.Drawing.Point(8, 435)
        Me.speakTF.MaxLength = 0
        Me.speakTF.Name = "speakTF"
        Me.speakTF.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.speakTF.Size = New System.Drawing.Size(257, 19)
        Me.speakTF.TabIndex = 8
        Me.speakTF.Text = "Clever words for me to speak"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Hap1
        '
        Me.Hap1.Enabled = True
        Me.Hap1.Location = New System.Drawing.Point(12, 12)
        Me.Hap1.Name = "Hap1"
        Me.Hap1.OcxState = CType(resources.GetObject("Hap1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.Hap1.Size = New System.Drawing.Size(306, 282)
        Me.Hap1.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(393, 471)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(65, 17)
        Me.Label4.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(393, 447)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(65, 17)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Hz"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(393, 423)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(65, 17)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Snd:"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(393, 399)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(65, 17)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "TTS:"
        '
        'bgTF
        '
        Me.bgTF.Location = New System.Drawing.Point(9, 399)
        Me.bgTF.Name = "bgTF"
        Me.bgTF.Size = New System.Drawing.Size(257, 20)
        Me.bgTF.TabIndex = 14
        '
        'bgbutton
        '
        Me.bgbutton.Location = New System.Drawing.Point(271, 397)
        Me.bgbutton.Name = "bgbutton"
        Me.bgbutton.Size = New System.Drawing.Size(107, 24)
        Me.bgbutton.TabIndex = 15
        Me.bgbutton.Text = "Apply Background"
        Me.bgbutton.UseVisualStyleBackColor = True
        '
        'speakButton
        '
        Me.speakButton.Location = New System.Drawing.Point(271, 433)
        Me.speakButton.Name = "speakButton"
        Me.speakButton.Size = New System.Drawing.Size(75, 23)
        Me.speakButton.TabIndex = 16
        Me.speakButton.Text = "Speak"
        Me.speakButton.UseVisualStyleBackColor = True
        '
        'playOGGButton
        '
        Me.playOGGButton.Location = New System.Drawing.Point(271, 468)
        Me.playOGGButton.Name = "playOGGButton"
        Me.playOGGButton.Size = New System.Drawing.Size(75, 23)
        Me.playOGGButton.TabIndex = 17
        Me.playOGGButton.TabStop = False
        Me.playOGGButton.Text = "Play"
        Me.playOGGButton.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(489, 523)
        Me.Controls.Add(Me.playOGGButton)
        Me.Controls.Add(Me.speakButton)
        Me.Controls.Add(Me.bgbutton)
        Me.Controls.Add(Me.bgTF)
        Me.Controls.Add(Me.playOGGTF)
        Me.Controls.Add(Me.speakTF)
        Me.Controls.Add(Me.Hap1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(3, 22)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MainForm"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ShowInTaskbar = False
        Me.Text = "Waiting For Sound Example"
        CType(Me.Hap1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Picture1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bgTF As System.Windows.Forms.TextBox
    Friend WithEvents bgbutton As System.Windows.Forms.Button
    Friend WithEvents speakButton As System.Windows.Forms.Button
    Friend WithEvents playOGGButton As System.Windows.Forms.Button
#End Region
End Class