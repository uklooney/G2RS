Option Explicit On

'Imports System.Threading
'Imports System.Text
Imports System.Runtime.InteropServices

Public Class FormMain

    ' G2RS Proof of Concept - UKLooney
    ' Version 0.1 15-Jul-2017
    ' Version 0.2 16-Jul-2017
    ' Version 0.3 17-Jul-2017

    ' process memory access functions
    <DllImport("kernel32.dll")>
    Public Shared Function OpenProcess(dwDesiredAccess As Integer, bInheritHandle As Boolean, dwProcessId As Integer) As IntPtr
    End Function
    <DllImport("kernel32.dll")>
    Public Shared Function ReadProcessMemory(hProcess As IntPtr, lpBaseAddress As IntPtr, lpBuffer As Byte(), dwSize As IntPtr, ByRef lpNumberOfBytesRead As IntPtr) As Boolean
    End Function
    ' active window functions
    <DllImport("user32.dll", EntryPoint:="GetForegroundWindow")>
    Private Shared Function GetForegroundWindow() As IntPtr
    End Function
    <DllImport("user32.dll", SetLastError:=True, CharSet:=CharSet.Auto)>
    Private Shared Function GetWindowTextLength(ByVal hwnd As IntPtr) As Integer
    End Function
    Public Declare Function GetWindowText Lib "user32" Alias "GetWindowTextA" (ByVal hwnd As Integer, ByVal lpString As String, ByVal cch As Integer) As Integer
    '<DllImport("user32.dll", SetLastError:=True, CharSet:=CharSet.Auto)>
    'Public Shared Function GetWindowText(hwnd As Integer, <MarshalAs(UnmanagedType.LPStr)> lpString As String, cch As Integer) As Integer
    'End Function

    Const PROCESS_WM_READ As Integer = &H10
    Const note_A1 As Integer = &H21
    Const note_Bb1 As Integer = &H22
    Const note_B1 As Integer = &H23
    Const note_C2 As Integer = &H24
    Const note_Cs2 As Integer = &H25
    Const note_D2 As Integer = &H26
    Const note_Eb2 As Integer = &H27
    Const note_E2 As Integer = &H28
    Const note_F2 As Integer = &H29
    Const note_Fs2 As Integer = &H2A
    Const note_G2 As Integer = &H2B
    Const note_Gs2 As Integer = &H2C
    Const note_A2 As Integer = &H2D
    Const note_Bb2 As Integer = &H2E
    Const note_B2 As Integer = &H2F
    Const note_C3 As Integer = &H30
    Const note_Cs3 As Integer = &H31
    Const note_D3 As Integer = &H32
    Const note_Eb3 As Integer = &H33
    Const note_E3 As Integer = &H34
    Const note_F3 As Integer = &H35
    Const note_Fs3 As Integer = &H36
    Const note_G3 As Integer = &H37
    Const note_Gs3 As Integer = &H38
    Const note_A3 As Integer = &H39
    Const note_Bb3 As Integer = &H3A
    Const note_B3 As Integer = &H3B
    Const note_C4 As Integer = &H3C
    Const note_Cs4 As Integer = &H3D
    Const note_D4 As Integer = &H3E
    Const note_Eb4 As Integer = &H3F
    Const note_E4 As Integer = &H40
    Const note_F4 As Integer = &H41
    Const note_Fs4 As Integer = &H42
    Const note_G4 As Integer = &H43
    Const note_Gs4 As Integer = &H44
    Const note_A4 As Integer = &H45
    Const note_Bb4 As Integer = &H46
    Const note_B4 As Integer = &H47
    Const note_C5 As Integer = &H48
    Const note_Cs5 As Integer = &H49
    Const note_D5 As Integer = &H4A
    Const note_Eb5 As Integer = &H4B
    Const note_E5 As Integer = &H4C
    Const note_F5 As Integer = &H4D
    Const note_Fs5 As Integer = &H4E
    Const note_G5 As Integer = &H4F
    Const note_Gs5 As Integer = &H50

    Dim timerCount As Integer
    Dim memberCount As Integer
    Dim seqListenCount As Integer = 0
    Dim keyComboArray() As String = {"DELETE", "DOWN", "ENTER", "ESCAPE", "PAGE DN", "PAGE UP", "SPACE", "TAB", "UP", "CANCEL", "none", "TBD"}
    Dim keyPressArray() As String = {"{DELETE}", "{DOWN}", "{ENTER}", "{ESC}", "{PGDN}", "{PGUP}", "{SPACE}", "{TAB}", "{UP}", "<CANCEL>", "<none>", "<TBD>"}
    Dim NotesUsedArray As String() = {"A", "B", "C#", "Eb", "F", "G"}
    Dim NotesSeqTextArray As String() = {"A 2", "B 2", "C# 3", "Eb 3", "F 3", "G 3", "A 3", "B 3", "C# 4", "Eb 4", "F 4", "G 4"}
    Dim NotesSeqMidiArray As Integer() = {&H2D, &H2F, &H31, &H33, &H35, &H37, &H39, &H3B, &H3D, &H3F, &H41, &H43}
    Dim SeqArrayNotes() As Integer = {0, 0, 0, 0, 0}
    Dim strSend As String = ""

    Dim MidiArray() As Integer = {&H0, &H1, &H2, &H3, &H4, &H5, &H6, &H7, &H8, &H9, &H10, &H11, &H12, &H13, &H14, &H15, &H16, &H17, &H18, &H19, &H20, &H21, &H22, &H23, &H24, &H25, &H26, &H27, &H28, &H29, &H30, &H31, &H32, &H33, &H34, &H35, &H36, &H37, &H38, &H39, &H40, &H41, &H42, &H43, &H44, &H45, &H46, &H47, &H48, &H49, &H50, &H51, &H52, &H53, &H54, &H55, &H56, &H57, &H58, &H59, &H60, &H61, &H62, &H63, &H64, &H65, &H66, &H67, &H68, &H69, &H70, &H71, &H72, &H73, &H74, &H75, &H76, &H77, &H78, &H79, &H80, &H81, &H82, &H83, &H84, &H85, &H86, &H87, &H88, &H89, &H90, &H91, &H92, &H93, &H94, &H95}  'C-1 to C6
    Dim MidiNotesArray() As String = {"C", "C#", "D", "Eb", "E", "F", "F#", "G", "G#", "A", "Bb", "B", "C", "C#", "D", "Eb", "E", "F", "F#", "G", "G#", "A", "Bb", "B", "C", "C#", "D", "Eb", "E", "F", "F#", "G", "G#", "A", "Bb", "B", "C", "C#", "D", "Eb", "E", "F", "F#", "G", "G#", "A", "Bb", "B", "C", "C#", "D", "Eb", "E", "F", "F#", "G", "G#", "A", "Bb", "B", "C", "C#", "D", "Eb", "E", "F", "F#", "G", "G#", "A", "Bb", "B", "C", "C#", "D", "Eb", "E", "F", "F#", "G", "G#", "A", "Bb", "B", "C", "C#", "D", "Eb", "E", "F", "F#", "G", "G#", "A", "Bb", "B"}
    Dim MidiNotesFullArray() As String = {"C-1", "C#-1", "D-1", "Eb-1", "E-1", "F-1", "F#-1", "G-1", "G#-1", "A-1", "Bb-1", "B-1", "C0", "C#0", "D0", "Eb0", "E0", "F0", "F#0", "G0", "G#0", "A0", "Bb0", "B0", "C1", "C#1", "D1", "Eb1", "E1", "F1", "F#1", "G1", "G#1", "A1", "Bb1", "B1", "C2", "C#2", "D2", "Eb2", "E2", "F2", "F#2", "G2", "G#2", "A2", "Bb2", "B2", "C3", "C#3", "D3", "Eb3", "E3", "F3", "F#3", "G3", "G#3", "A3", "Bb3", "B3", "C4", "C#4", "D4", "Eb4", "E4", "F4", "F#4", "G4", "G#4", "A4", "Bb4", "B4", "C5", "C#5", "D5", "Eb5", "E5", "F5", "F#5", "G5", "G#5", "A5", "Bb5", "B5", "C6", "C#6", "D6", "Eb6", "E6", "F6", "F#6", "G6", "G#6", "A6", "Bb6", "B6"}
    Dim MidiNotesOctaveArray() As Integer = {-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6}

    Dim indexKey_A As Integer
    Dim indexKey_Bb As Integer
    Dim indexKey_B As Integer
    Dim indexKey_C As Integer
    Dim indexKey_Cs As Integer
    Dim indexKey_D As Integer
    Dim indexKey_Eb As Integer
    Dim indexKey_E As Integer
    Dim indexKey_F As Integer
    Dim indexKey_Fs As Integer
    Dim indexKey_G As Integer
    Dim indexKey_Gs As Integer

    Dim strKey_A As String
    Dim strKey_Bb As String
    Dim strKey_B As String
    Dim strKey_C As String
    Dim strKey_Cs As String
    Dim strKey_D As String
    Dim strKey_Eb As String
    Dim strKey_E As String
    Dim strKey_F As String
    Dim strKey_Fs As String
    Dim strKey_G As String
    Dim strKey_Gs As String

    Dim RegSeq1 As String
    Dim RegSeq2 As String
    Dim RegSeq3 As String
    Dim RegSeq4 As String
    Dim RegSeq5 As String

    Dim activeWindowsIsRS2014 As Boolean = False
    Dim RS2014isRunning As Boolean = False
    Dim RS2014KeysendActive As Boolean = False

    Dim RS2014Process As Process
    Dim processHandle As IntPtr
    Dim lastHwnd As Integer
    Dim Note As Byte
    Dim lastNote As Byte
    Dim newNote As Boolean
    Dim currentNote As String = "-"
    Dim currentNoteOctave As Integer = -1
    Dim currentImage As Integer = 12
    Dim pollRate As Integer = 20  ' times per second process memory should be polled

    Dim notBufferLast As Integer = &HFF
    Dim noteBufferCur As Integer = &HFF

    ' function to return the window's title
    Private Function GetWindowTitle(ByVal window_hwnd As Integer) As String
        ' see how long the window's title is
        Dim length As Integer = GetWindowTextLength(window_hwnd) + 1
        If length <= 1 Then
            ' there's no title, return the hWnd
            Return "<" & window_hwnd & ">"
        Else
            ' Get the title.
            Dim strTitle As String = (Space(length))
            GetWindowText(window_hwnd, strTitle, length)
            Return strTitle.ToString
        End If
    End Function

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' check if the foreground window has change since last tick
        ' get the foreground window's handle
        Dim currHwnd As Long = GetForegroundWindow()
        ' if the window handle has changed, check if RS has become active/inactive
        If lastHwnd <> currHwnd Then
            lastHwnd = currHwnd
            Dim WindowText As String = GetWindowTitle(currHwnd)
            ' check if RS is the new active window, if so then activate monitoring for note sequence
            If Not (activeWindowsIsRS2014) Then
                If Mid(WindowText, 1, 14) = "Rocksmith 2014" Then
                    activeWindowsIsRS2014 = True
                    RS2014KeysendActive = False
                    ' if this is the first time we've seen RS running then setup access to process memory
                    If Not (RS2014isRunning) Then
                        RS2014isRunning = True  ' leave this on forever
                        RS2014Process = Process.GetProcessesByName("Rocksmith2014")(0)
                        processHandle = OpenProcess(PROCESS_WM_READ, False, RS2014Process.Id)
                    End If
                End If
            Else
                ' if Rocksmith 2014 is no longer the active window, deactivate
                activeWindowsIsRS2014 = False
                RS2014KeysendActive = False
                seqListenCount = 0
            End If
        End If

        ' update background colour and status text
        If Not (activeWindowsIsRS2014) Then
            Me.BackColor = Color.Orange
            LabelStatus.Text = "Rocksmith Inactive"
        End If
        If activeWindowsIsRS2014 And Not (RS2014KeysendActive) Then
            Me.BackColor = Color.White
            If seqListenCount = 0 Then
                LabelStatus.Text = "Waiting for Note Sequence"
            Else
                LabelStatus.Text = "Note Sequence " & seqListenCount
            End If
        End If
        If RS2014KeysendActive Then
            Me.BackColor = Color.LightGreen
            LabelStatus.Text = "Play Note to Send a Key"
        End If

        ' update debug textboxes
        timerCount = timerCount + 1
        If timerCount > pollRate Then timerCount = 1
        lblTimerCounter.Text = timerCount

        ' TODO TIDY UP
        LabelCurrentNote.Text = currentNote
        If currentNote <> "-" Then
            lblCurrentNoteOctave.Text = currentNoteOctave
        Else
            lblCurrentNoteOctave.Text = ""
        End If

        tbSeq.Text = String.Format("{0:X2}.{1:X2}.{2:X2}.{3:X2}.{4:X2}", SeqArrayNotes(0), SeqArrayNotes(1), SeqArrayNotes(2), SeqArrayNotes(3), SeqArrayNotes(4))

        ' exit and do no more if rocksmith 2014 is not the active window
        If Not (activeWindowsIsRS2014) Then Exit Sub

        ' get the note being played
        Const BaseAddress As Integer = &H135C4FC  '&HF5C4FC
        Const Offset1 As Integer = &H10
        Const Offset2 As Integer = &H4
        Const Offset3 As Integer = &H5FC
        Dim Pointer1 As Integer
        Dim Pointer2 As Integer
        Dim Pointer3 As Integer
        Dim memoryLocNote As Integer
        Dim bytesRead As Integer = 0
        Dim memBuffer As Byte() = {0, 0, 0, 0}

        ' ## www.cheatengine.org, youtube.com/watch?v=hfWOAFsYnFA ##
        '
        ' variables for debugging 
        'Dim BaseOffset As Integer = &HBB9E704  '&HF5C4FC
        'Dim BaseOffset As Integer = &H6E26CA4  '&HF5C4FC
        'Dim BaseOffset As Integer = &HF5C4FC ' original
        'Const tesdtoff As Int64 = &HFFFFFFFF
        ' variables for debugging without pointers, these values will need changed everytime RS is restarted
        'Const DirectAddress As Integer = &H192E310C ' 'changes everytime game restarts
        'Const b3 As Integer = &H19
        'Const b2 As Integer = &H2E
        'Const b1 As Integer = &H31
        'Const b0 As Integer = &HC
        'Dim tt As Integer
        ' DIRECTLY ACCESS CHANGING MEMORY ADDRESS - DEBUG USE ONLY
        'ReadProcessMemory(CInt(processHandle), DirectAddress, buffer, buffer.Length, bytesRead)
        'tt = (((b0 Or (b1 << 8)) Or (b2 << &H10)) Or (b3 << &H18))
        'TextBoxDirect.Text = String.Format("{0:X8}", DirectOffset) & "/" & String.Format("{0:X8}", tt) & "/" & String.Format("{0:X2}{1:X2}{2:X2}{3:X2}", buffer(3), buffer(2), buffer(1), buffer(0))

        ' get pointer 1 address from fixed base address and offset 1
        ReadProcessMemory(CInt(processHandle), BaseAddress, memBuffer, memBuffer.Length, bytesRead)
        Pointer1 = (((CInt(memBuffer(0)) Or (CInt(memBuffer(1)) << 8)) Or (CInt(memBuffer(2)) << &H10)) Or (CInt(memBuffer(3)) << &H18)) + Offset1
        ' write pointer value and offset to off form textbox for debug use
        TextBox1.Text = "F:" & String.Format("{0:X2}{1:X2}{2:X2}{3:X2}", memBuffer(3), memBuffer(2), memBuffer(1), memBuffer(0)) & " O:" & String.Format("{0:X8}", Pointer1)
        ' get pointer 2 address from pointer 1 and offset 2
        ReadProcessMemory(CInt(processHandle), Pointer1, memBuffer, memBuffer.Length, bytesRead)
        Pointer2 = (((CInt(memBuffer(0)) Or (CInt(memBuffer(1)) << 8)) Or (CInt(memBuffer(2)) << &H10)) Or (CInt(memBuffer(3)) << &H18)) + Offset2
        TextBox2.Text = "F:" & String.Format("{0:X2}{1:X2}{2:X2}{3:X2}", memBuffer(3), memBuffer(2), memBuffer(1), memBuffer(0)) & " O:" & String.Format("{0:X8}", Pointer2)
        ' get pointer 3 address from pointer 2 and offset 3
        ReadProcessMemory(CInt(processHandle), Pointer2, memBuffer, memBuffer.Length, bytesRead)
        Pointer3 = (((CInt(memBuffer(0)) Or (CInt(memBuffer(1)) << 8)) Or (CInt(memBuffer(2)) << &H10)) Or (CInt(memBuffer(3)) << &H18)) + Offset3
        TextBox3.Text = "F:" & String.Format("{0:X2}{1:X2}{2:X2}{3:X2}", memBuffer(3), memBuffer(2), memBuffer(1), memBuffer(0)) & " O:" & String.Format("{0:X8}", Pointer3)
        ' get memory from pointer 3
        ReadProcessMemory(CInt(processHandle), Pointer3, memBuffer, memBuffer.Length, bytesRead)
        memoryLocNote = (((CInt(memBuffer(0)) Or (CInt(memBuffer(1)) << 8)) Or (CInt(memBuffer(2)) << &H10)) Or (CInt(memBuffer(3)) << &H18))
        TextBoxMem.Text = "V:" & String.Format("{0:X8}", memoryLocNote)

        Dim mem As Integer = memBuffer(0)
        ' if the new note is too high pitch , just ignore it and exit
        If (mem <> &HFF) And (mem >= MidiNotesArray.Length) Then Exit Sub

        If (mem = notBufferLast) And (mem <> noteBufferCur) Then
            noteBufferCur = mem
        End If
        If (mem <> notBufferLast) Then
            notBufferLast = mem
        End If

        ' TODO TIDY
        ' check if we have a new note, process the data
        If (noteBufferCur <> &HFF) And (noteBufferCur <> lastNote) Then
            newNote = True
            Note = noteBufferCur
            lastNote = Note
        End If
        ' if  the note ends clear
        If (noteBufferCur = &HFF) And (lastNote <> 0) Then
            currentNote = "-"
            currentNoteOctave = -1
            newNote = False
            Note = 0
            lastNote = 0
        End If

        ' determine what the new note is and which keystroke it is assigned to , if any
        If newNote Then
            Dim strSendTemp As String = ""
            currentNote = MidiNotesArray(Note)
            currentNoteOctave = MidiNotesOctaveArray(Note)
            ' determine if there is a keypress to send and the image to display
            Dim transparentImage As Integer = 12
            Select Case Note
               'Case note_A1, note_A2, note_A3
                Case note_A2
                    strSendTemp = strKey_A
                    currentImage = indexKey_A
                Case note_Bb2
                    strSendTemp = strKey_Bb
                    currentImage = transparentImage 'indexKey_Bb
                Case note_B2
                    strSendTemp = strKey_B
                    currentImage = indexKey_B
                Case note_C3
                    strSendTemp = strKey_C
                    currentImage = transparentImage 'indexKey_C
                Case note_Cs3
                    strSendTemp = strKey_Cs
                    currentImage = indexKey_Cs
                Case note_D3
                    strSendTemp = strKey_D
                    currentImage = transparentImage 'indexKey_D
                Case note_Eb3
                    strSendTemp = strKey_Eb
                    currentImage = indexKey_Eb
                Case note_E3
                    strSendTemp = strKey_E
                    currentImage = transparentImage 'indexKey_E
                Case note_F3
                    strSendTemp = strKey_F
                    currentImage = indexKey_F
                Case note_Fs3
                    strSendTemp = strKey_Fs
                    currentImage = transparentImage 'indexKey_Gb
                Case note_G3
                    strSendTemp = strKey_G
                    currentImage = indexKey_G
                Case note_Gs3
                    strSendTemp = strKey_Gs
                    currentImage = transparentImage 'indexKey_Ab
            End Select

            ' if the note is not one which we use, then don't process it any further, just exit
            If Not (NotesUsedArray.Contains(currentNote)) Then
                Exit Sub
            End If

            If RS2014KeysendActive Then
                ' if we are active and sending keystrokes to Rocksmith 2014
                strSend = strSendTemp
            Else
                ' if we are listening for the activate note sequence
                If newNote Then
                    If Note = SeqArrayNotes(seqListenCount) Then
                        seqListenCount = seqListenCount + 1
                        If seqListenCount > SeqArrayNotes.Length() - 1 Then
                            seqListenCount = 0
                            RS2014KeysendActive = True
                        End If
                    Else
                        If Note = SeqArrayNotes(0) Then
                            seqListenCount = 1
                        Else
                            seqListenCount = 0
                        End If
                    End If
                End If
            End If
        End If

        newNote = False

        ' if we are actively sending keystrokes to Rocksmith
        If RS2014KeysendActive Then
            ' process notes to be send
            If Mid(strSend, 1, 1) = "{" Then
                If strSend = "{SPACE}" Then
                    SendKeys.Send(" ")
                Else
                    SendKeys.Send(strSend)
                End If
            End If
            ' process any instructions to be send
            If Mid(strSend, 1, 8) = "<CANCEL>" Then
                RS2014KeysendActive = False
            End If
            ' display/hide keypress bitmap
            If currentImage < 0 Then currentImage = 0
            lblCurrentImage.ImageIndex = currentImage
            ' clear keystroke
            strSend = ""
        End If

    End Sub


    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' create registry key if it doesn't exist
        My.Computer.Registry.CurrentUser.CreateSubKey("SOFTWARE\G2RS")
        ' set default background colour and key press image
        Me.BackColor = Color.White
        lblCurrentImage.ImageIndex = currentImage

        ' populate keypress comboboxes
        For memberCount = 0 To keyPressArray.Length - 1
            ComboBox_A.Items.Add(keyComboArray(memberCount))
            ComboBox_Bb.Items.Add(keyComboArray(memberCount))
            ComboBox_B.Items.Add(keyComboArray(memberCount))
            ComboBox_C.Items.Add(keyComboArray(memberCount))
            ComboBox_Cs.Items.Add(keyComboArray(memberCount))
            ComboBox_D.Items.Add(keyComboArray(memberCount))
            ComboBox_Eb.Items.Add(keyComboArray(memberCount))
            ComboBox_E.Items.Add(keyComboArray(memberCount))
            ComboBox_F.Items.Add(keyComboArray(memberCount))
            ComboBox_Fs.Items.Add(keyComboArray(memberCount))
            ComboBox_G.Items.Add(keyComboArray(memberCount))
            ComboBox_Gs.Items.Add(keyComboArray(memberCount))
        Next

        ' get prior configured keypress options from registry
        ' there are 12 possible notes, but we currently only use six of these
        Dim RegKeyPressA = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\SOFTWARE\G2RS", "KeyPressA", "UP")
        Dim RegKeyPressBb = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\SOFTWARE\G2RS", "KeyPressBb", "none")
        Dim RegKeyPressB = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\SOFTWARE\G2RS", "KeyPressB", "DOWN")
        Dim RegKeyPressC = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\SOFTWARE\G2RS", "KeyPressC", "none")
        Dim RegKeyPressCs = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\SOFTWARE\G2RS", "KeyPressCs", "ESCAPE")
        Dim RegKeyPressD = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\SOFTWARE\G2RS", "KeyPressD", "none")
        Dim RegKeyPressEb = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\SOFTWARE\G2RS", "KeyPressEb", "ENTER")
        Dim RegKeyPressE = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\SOFTWARE\G2RS", "KeyPressE", "none")
        Dim RegKeyPressF = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\SOFTWARE\G2RS", "KeyPressF", "none")
        Dim RegKeyPressGb = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\SOFTWARE\G2RS", "KeyPressGb", "none")
        Dim RegKeyPressG = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\SOFTWARE\G2RS", "KeyPressG", "CANCEL")
        Dim RegKeyPressAb = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\SOFTWARE\G2RS", "KeyPressAb", "none")

        ' select appropriate index in combobox
        Dim selIndex As Integer
        ' A 
        selIndex = ComboBox_A.FindString(RegKeyPressA)
        ComboBox_A.SelectedIndex = selIndex
        indexKey_A = selIndex
        If selIndex <> -1 Then strKey_A = keyPressArray(selIndex)
        ' Bb
        selIndex = ComboBox_Bb.FindString(RegKeyPressBb)
        ComboBox_Bb.SelectedIndex = selIndex
        indexKey_Bb = selIndex
        If selIndex <> -1 Then strKey_Bb = keyPressArray(selIndex)
        ' B
        selIndex = ComboBox_B.FindString(RegKeyPressB)
        ComboBox_B.SelectedIndex = selIndex
        indexKey_B = selIndex
        If selIndex <> -1 Then strKey_B = keyPressArray(selIndex)
        ' etc
        selIndex = ComboBox_C.FindString(RegKeyPressC)
        ComboBox_C.SelectedIndex = selIndex
        indexKey_C = selIndex
        If selIndex <> -1 Then strKey_C = keyPressArray(selIndex)
        '
        selIndex = ComboBox_Cs.FindString(RegKeyPressCs)
        ComboBox_Cs.SelectedIndex = selIndex
        indexKey_Cs = selIndex
        If selIndex <> -1 Then strKey_Cs = keyPressArray(selIndex)
        '
        selIndex = ComboBox_D.FindString(RegKeyPressD)
        ComboBox_D.SelectedIndex = selIndex
        indexKey_D = selIndex
        If selIndex <> -1 Then strKey_D = keyPressArray(selIndex)
        '
        selIndex = ComboBox_Eb.FindString(RegKeyPressEb)
        ComboBox_Eb.SelectedIndex = selIndex
        indexKey_Eb = selIndex
        If selIndex <> -1 Then strKey_Eb = keyPressArray(selIndex)
        '
        selIndex = ComboBox_E.FindString(RegKeyPressE)
        ComboBox_E.SelectedIndex = selIndex
        indexKey_E = selIndex
        If selIndex <> -1 Then strKey_E = keyPressArray(selIndex)
        '
        selIndex = ComboBox_F.FindString(RegKeyPressF)
        ComboBox_F.SelectedIndex = selIndex
        indexKey_F = selIndex
        If selIndex <> -1 Then strKey_F = keyPressArray(selIndex)
        '
        selIndex = ComboBox_Fs.FindString(RegKeyPressGb)
        ComboBox_Fs.SelectedIndex = selIndex
        indexKey_Fs = selIndex
        If selIndex <> -1 Then strKey_Fs = keyPressArray(selIndex)
        '
        selIndex = ComboBox_G.FindString(RegKeyPressG)
        ComboBox_G.SelectedIndex = selIndex
        indexKey_G = selIndex
        If selIndex <> -1 Then strKey_G = keyPressArray(selIndex)
        '
        selIndex = ComboBox_Gs.FindString(RegKeyPressAb)
        ComboBox_Gs.SelectedIndex = selIndex
        indexKey_Gs = selIndex
        If selIndex <> -1 Then strKey_Gs = keyPressArray(selIndex)

        ' populate sequence comboboxes
        For memberCount = 0 To NotesSeqTextArray.Length - 1
            ComboBox_Seq1.Items.Add(NotesSeqTextArray(memberCount))
            ComboBox_Seq2.Items.Add(NotesSeqTextArray(memberCount))
            ComboBox_Seq3.Items.Add(NotesSeqTextArray(memberCount))
            ComboBox_Seq4.Items.Add(NotesSeqTextArray(memberCount))
            ComboBox_Seq5.Items.Add(NotesSeqTextArray(memberCount))
        Next

        ' get prior selected sequence from registry
        RegSeq1 = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\SOFTWARE\G2RS", "Seq1", "A 2") 'A,B,C#,Eb or F
        RegSeq2 = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\SOFTWARE\G2RS", "Seq2", "B 2")
        RegSeq3 = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\SOFTWARE\G2RS", "Seq3", "A 2")
        RegSeq4 = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\SOFTWARE\G2RS", "Seq4", "B 2")
        RegSeq5 = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\SOFTWARE\G2RS", "Seq5", "A 2")
        ' popoulate sequence array and select combobox item
        selIndex = ComboBox_Seq1.FindString(RegSeq1)
        ComboBox_Seq1.SelectedIndex = selIndex
        If selIndex <> -1 Then SeqArrayNotes(0) = NotesSeqMidiArray(selIndex)
        selIndex = ComboBox_Seq2.FindString(RegSeq2)
        ComboBox_Seq2.SelectedIndex = selIndex
        If selIndex <> -1 Then SeqArrayNotes(1) = NotesSeqMidiArray(selIndex)
        selIndex = ComboBox_Seq3.FindString(RegSeq3)
        ComboBox_Seq3.SelectedIndex = selIndex
        If selIndex <> -1 Then SeqArrayNotes(2) = NotesSeqMidiArray(selIndex)
        selIndex = ComboBox_Seq4.FindString(RegSeq4)
        ComboBox_Seq4.SelectedIndex = selIndex
        If selIndex <> -1 Then SeqArrayNotes(3) = NotesSeqMidiArray(selIndex)
        selIndex = ComboBox_Seq5.FindString(RegSeq5)
        ComboBox_Seq5.SelectedIndex = selIndex
        If selIndex <> -1 Then SeqArrayNotes(4) = NotesSeqMidiArray(selIndex)

        ' start timer
        Timer1.Interval = 1000 / pollRate
        Timer1.Start()

    End Sub

    Private Sub FormMain_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Application.Exit()
    End Sub

    Private Sub LabelStatus_Click(sender As Object, e As EventArgs) Handles LabelStatus.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub ComboBox_A_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_A.SelectedIndexChanged
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\G2RS", "KeyPressA", ComboBox_A.SelectedItem.ToString())
        strKey_A = keyPressArray(ComboBox_A.SelectedIndex)
    End Sub

    Private Sub ComboBox_Bb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_Bb.SelectedIndexChanged
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\G2RS", "KeyPressBb", ComboBox_Bb.SelectedItem.ToString())
        strKey_Bb = keyPressArray(ComboBox_Bb.SelectedIndex)
    End Sub

    Private Sub ComboBox_B_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_B.SelectedIndexChanged
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\G2RS", "KeyPressB", ComboBox_B.SelectedItem.ToString())
        strKey_B = keyPressArray(ComboBox_B.SelectedIndex)
    End Sub

    Private Sub ComboBox_C_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_C.SelectedIndexChanged
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\G2RS", "KeyPressC", ComboBox_C.SelectedItem.ToString())
        strKey_C = keyPressArray(ComboBox_C.SelectedIndex)
    End Sub

    Private Sub ComboBox_Cs_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_Cs.SelectedIndexChanged
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\G2RS", "KeyPressC#", ComboBox_Cs.SelectedItem.ToString())
        strKey_Cs = keyPressArray(ComboBox_Cs.SelectedIndex)
    End Sub

    Private Sub ComboBox_D_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_D.SelectedIndexChanged
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\G2RS", "KeyPressD", ComboBox_D.SelectedItem.ToString())
        strKey_D = keyPressArray(ComboBox_D.SelectedIndex)
    End Sub

    Private Sub ComboBox_Eb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_Eb.SelectedIndexChanged
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\G2RS", "KeyPressEb", ComboBox_Eb.SelectedItem.ToString())
        strKey_Eb = keyPressArray(ComboBox_Eb.SelectedIndex)
    End Sub

    Private Sub ComboBox_E_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_E.SelectedIndexChanged
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\G2RS", "KeyPressE", ComboBox_E.SelectedItem.ToString())
        strKey_E = keyPressArray(ComboBox_E.SelectedIndex)
    End Sub

    Private Sub ComboBox_F_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_F.SelectedIndexChanged
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\G2RS", "KeyPressF", ComboBox_F.SelectedItem.ToString())
        strKey_F = keyPressArray(ComboBox_F.SelectedIndex)
    End Sub

    Private Sub ComboBox_Fs_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_Fs.SelectedIndexChanged
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\G2RS", "KeyPressGb", ComboBox_Fs.SelectedItem.ToString())
        strKey_Fs = keyPressArray(ComboBox_Fs.SelectedIndex)
    End Sub

    Private Sub ComboBox_G_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_G.SelectedIndexChanged
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\G2RS", "KeyPressG", ComboBox_G.SelectedItem.ToString())
        strKey_G = keyPressArray(ComboBox_G.SelectedIndex)
    End Sub

    Private Sub ComboBox_Gs_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_Gs.SelectedIndexChanged
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\G2RS", "KeyPressAb", ComboBox_Gs.SelectedItem.ToString())
        strKey_Gs = keyPressArray(ComboBox_Gs.SelectedIndex)
    End Sub

    Private Sub ComboBox_Seq1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_Seq1.SelectedIndexChanged
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\G2RS", "Seq1", ComboBox_Seq1.SelectedItem.ToString())
        SeqArrayNotes(0) = NotesSeqMidiArray(ComboBox_Seq1.SelectedIndex)
    End Sub

    Private Sub ComboBox_Seq2_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles ComboBox_Seq2.SelectedIndexChanged
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\G2RS", "Seq2", ComboBox_Seq2.SelectedItem.ToString())
        SeqArrayNotes(1) = NotesSeqMidiArray(ComboBox_Seq2.SelectedIndex)
    End Sub

    Private Sub ComboBox_Seq3_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles ComboBox_Seq3.SelectedIndexChanged
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\G2RS", "Seq3", ComboBox_Seq3.SelectedItem.ToString())
        SeqArrayNotes(2) = NotesSeqMidiArray(ComboBox_Seq3.SelectedIndex)
    End Sub

    Private Sub ComboBox_Seq4_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles ComboBox_Seq4.SelectedIndexChanged
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\G2RS", "Seq4", ComboBox_Seq4.SelectedItem.ToString())
        SeqArrayNotes(3) = NotesSeqMidiArray(ComboBox_Seq4.SelectedIndex)
    End Sub

    Private Sub ComboBox_Seq5_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles ComboBox_Seq5.SelectedIndexChanged
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\G2RS", "Seq5", ComboBox_Seq5.SelectedItem.ToString())
        SeqArrayNotes(4) = NotesSeqMidiArray(ComboBox_Seq5.SelectedIndex)
    End Sub

End Class
