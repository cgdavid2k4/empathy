Option Strict Off
Option Explicit On
Friend Class MainForm
    Inherits System.Windows.Forms.Form
    ' This example demonstrates waiting for Text-To-Speech and Wave-Playback to finish.
    ' It's somewhat similar to the javascript utility file "HapToDoList.js",
    ' which is included in the Programming|JavaScript section of the Haptek Guide.
    '
    ' Basically, one needs to poll the Haptek control, asking it if Sound is being made.
    ' This is acheived here thru a timer, which triggers 10 times per second.
    '
    ' There is a Gotcha with this, and that is the fact that a wave file may not
    ' start immediately after its \Load command, so it's possible that if you
    ' query for wave-Playback-Status very soon after launching a wave file
    ' that the answer will be "not playing anything".
    '
    ' To avoid this, it's advisable to first wait for sound to begin,
    ' and then wait for sound to stop. This is implemented in this example
    ' with the "WaitForSound" and "SoundStarted" variables.
    '
    ' Orion Elenzil 200201

    Dim WaitForSound As Object ' Set to true when we want to wait for sound to finish
    Dim SoundStarted As Object ' Set to true once sound has begun

    ' Convenience function
    Private Function MyQuery(ByRef h As AxACTIVEHAPTEKXLib.AxActiveHaptekX, ByRef q As Object) As String
        'UPGRADE_WARNING: Couldn't resolve default property of object q. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        h.Query = q
        MyQuery = h.QueryReturn
    End Function

    Private Sub Form1_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        Hap1.HyperText = "\Load [file= [data/standard/standardStartup.hap]]"
        playOGGTF.Text = My.Application.Info.DirectoryPath & "\buyingthings.ogg"
        Label4.BackColor = System.Drawing.ColorTranslator.FromOle(&H8000000F)
        Label4.Text = ""
        'UPGRADE_WARNING: Couldn't resolve default property of object WaitForSound. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        WaitForSound = False
        'UPGRADE_WARNING: Couldn't resolve default property of object SoundStarted. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        SoundStarted = False
    End Sub

    Private Sub Command1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        Hap1.HyperText = "\q2 [s0= [" & speakTF.Text & "]]"
        'UPGRADE_WARNING: Couldn't resolve default property of object WaitForSound. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        WaitForSound = True
    End Sub

    Private Sub Command2_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        Dim cmd As Object
        Hap1.HyperText = "\q2 [s0= [\Load [file= [" & playOGGTF.Text & "]]]]"
        'UPGRADE_WARNING: Couldn't resolve default property of object WaitForSound. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        WaitForSound = True
    End Sub

    Private Sub Command3_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        Hap1.HyperText = "\stop"
    End Sub

    ' Returns true if either Text-To-Speech or Wavefile-Playback is active.
    ' See the Haptek Guide for details on these queries.
    Private Function MakingSound() As Object
        If (CDbl(MyQuery(Hap1, "soundmgr status")) = 2 And CDbl(MyQuery(Hap1, "status tts busy")) = 0) Then
            'UPGRADE_WARNING: Couldn't resolve default property of object MakingSound. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            MakingSound = False
        Else
            'UPGRADE_WARNING: Couldn't resolve default property of object MakingSound. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            MakingSound = True
        End If
    End Function

    Private Sub Timer1_Tick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Timer1.Tick
        Label1.Text = "TTS: " & MyQuery(Hap1, "status tts busy")
        Label2.Text = "WAV: " & MyQuery(Hap1, "soundmgr status")
        Label3.Text = MyQuery(Hap1, "current framerate") & " Hz"

        ' We're in "Wait until sound has finished mode".
        If (WaitForSound) Then
            'UPGRADE_WARNING: Couldn't resolve default property of object SoundStarted. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            If (SoundStarted = False) Then
                ' Need to first wait for sound to actually start before we wait for it to finish.
                'UPGRADE_WARNING: Couldn't resolve default property of object MakingSound(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Couldn't resolve default property of object SoundStarted. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                SoundStarted = MakingSound()
            Else
                ' Okay, sound has started, now check if it's finished also.
                'UPGRADE_WARNING: Couldn't resolve default property of object MakingSound(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                If (MakingSound() = False) Then
                    ' Sound has finished.
                    'UPGRADE_WARNING: Couldn't resolve default property of object SoundStarted. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    SoundStarted = False
                    'UPGRADE_WARNING: Couldn't resolve default property of object WaitForSound. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    WaitForSound = False
                    '                blah = MsgBox("That's Great", vbDefaultButton1, "Finished Making Sound")
                    Label4.BackColor = System.Drawing.ColorTranslator.FromOle(&H8000000F)
                    Label4.Text = "done waiting"
                Else
                    Label4.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000014)
                    Label4.Text = "waiting"
                End If
            End If
        End If
    End Sub
End Class