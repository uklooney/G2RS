<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMain
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMain))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblNote2 = New System.Windows.Forms.Label()
        Me.lblNote4 = New System.Windows.Forms.Label()
        Me.lblTimerCounter = New System.Windows.Forms.Label()
        Me.ComboBox_Bb = New System.Windows.Forms.ComboBox()
        Me.lblNote6 = New System.Windows.Forms.Label()
        Me.lblNote8 = New System.Windows.Forms.Label()
        Me.lblNote10 = New System.Windows.Forms.Label()
        Me.ComboBox_C = New System.Windows.Forms.ComboBox()
        Me.ComboBox_D = New System.Windows.Forms.ComboBox()
        Me.ComboBox_E = New System.Windows.Forms.ComboBox()
        Me.ComboBox_Fs = New System.Windows.Forms.ComboBox()
        Me.lblNote12 = New System.Windows.Forms.Label()
        Me.ComboBox_Gs = New System.Windows.Forms.ComboBox()
        Me.LabelStatus = New System.Windows.Forms.Label()
        Me.LabelCurrentNote = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ImageListKeys = New System.Windows.Forms.ImageList(Me.components)
        Me.lblCurrentImage = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblNote9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBox_G = New System.Windows.Forms.ComboBox()
        Me.ComboBox_F = New System.Windows.Forms.ComboBox()
        Me.ComboBox_Eb = New System.Windows.Forms.ComboBox()
        Me.ComboBox_Cs = New System.Windows.Forms.ComboBox()
        Me.lblNote11 = New System.Windows.Forms.Label()
        Me.lblNote7 = New System.Windows.Forms.Label()
        Me.lblNote5 = New System.Windows.Forms.Label()
        Me.ComboBox_B = New System.Windows.Forms.ComboBox()
        Me.ComboBox_A = New System.Windows.Forms.ComboBox()
        Me.lblNote3 = New System.Windows.Forms.Label()
        Me.lblNote1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ComboBox_Seq5 = New System.Windows.Forms.ComboBox()
        Me.ComboBox_Seq4 = New System.Windows.Forms.ComboBox()
        Me.ComboBox_Seq3 = New System.Windows.Forms.ComboBox()
        Me.ComboBox_Seq2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox_Seq1 = New System.Windows.Forms.ComboBox()
        Me.tbSeq = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBoxMem = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBoxDirect = New System.Windows.Forms.TextBox()
        Me.lblCurrentNoteOctave = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 50
        '
        'lblNote2
        '
        Me.lblNote2.AutoSize = True
        Me.lblNote2.BackColor = System.Drawing.SystemColors.Control
        Me.lblNote2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNote2.Location = New System.Drawing.Point(216, 112)
        Me.lblNote2.Name = "lblNote2"
        Me.lblNote2.Size = New System.Drawing.Size(23, 14)
        Me.lblNote2.TabIndex = 8
        Me.lblNote2.Text = "Bb"
        '
        'lblNote4
        '
        Me.lblNote4.AutoSize = True
        Me.lblNote4.BackColor = System.Drawing.SystemColors.Control
        Me.lblNote4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNote4.Location = New System.Drawing.Point(217, 166)
        Me.lblNote4.Name = "lblNote4"
        Me.lblNote4.Size = New System.Drawing.Size(15, 14)
        Me.lblNote4.TabIndex = 17
        Me.lblNote4.Text = "C"
        '
        'lblTimerCounter
        '
        Me.lblTimerCounter.AutoSize = True
        Me.lblTimerCounter.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimerCounter.Location = New System.Drawing.Point(6, 329)
        Me.lblTimerCounter.Name = "lblTimerCounter"
        Me.lblTimerCounter.Size = New System.Drawing.Size(51, 13)
        Me.lblTimerCounter.TabIndex = 22
        Me.lblTimerCounter.Text = "Counter"
        '
        'ComboBox_Bb
        '
        Me.ComboBox_Bb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_Bb.FormattingEnabled = True
        Me.ComboBox_Bb.Location = New System.Drawing.Point(243, 112)
        Me.ComboBox_Bb.Name = "ComboBox_Bb"
        Me.ComboBox_Bb.Size = New System.Drawing.Size(74, 21)
        Me.ComboBox_Bb.TabIndex = 26
        '
        'lblNote6
        '
        Me.lblNote6.AutoSize = True
        Me.lblNote6.BackColor = System.Drawing.SystemColors.Control
        Me.lblNote6.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNote6.Location = New System.Drawing.Point(217, 220)
        Me.lblNote6.Name = "lblNote6"
        Me.lblNote6.Size = New System.Drawing.Size(16, 14)
        Me.lblNote6.TabIndex = 29
        Me.lblNote6.Text = "D"
        '
        'lblNote8
        '
        Me.lblNote8.AutoSize = True
        Me.lblNote8.BackColor = System.Drawing.SystemColors.Control
        Me.lblNote8.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNote8.Location = New System.Drawing.Point(217, 274)
        Me.lblNote8.Name = "lblNote8"
        Me.lblNote8.Size = New System.Drawing.Size(14, 14)
        Me.lblNote8.TabIndex = 31
        Me.lblNote8.Text = "E"
        '
        'lblNote10
        '
        Me.lblNote10.AutoSize = True
        Me.lblNote10.BackColor = System.Drawing.SystemColors.Control
        Me.lblNote10.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNote10.Location = New System.Drawing.Point(217, 328)
        Me.lblNote10.Name = "lblNote10"
        Me.lblNote10.Size = New System.Drawing.Size(22, 14)
        Me.lblNote10.TabIndex = 33
        Me.lblNote10.Text = "F#"
        '
        'ComboBox_C
        '
        Me.ComboBox_C.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_C.FormattingEnabled = True
        Me.ComboBox_C.Location = New System.Drawing.Point(243, 166)
        Me.ComboBox_C.Name = "ComboBox_C"
        Me.ComboBox_C.Size = New System.Drawing.Size(74, 21)
        Me.ComboBox_C.TabIndex = 35
        '
        'ComboBox_D
        '
        Me.ComboBox_D.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_D.FormattingEnabled = True
        Me.ComboBox_D.Location = New System.Drawing.Point(243, 220)
        Me.ComboBox_D.Name = "ComboBox_D"
        Me.ComboBox_D.Size = New System.Drawing.Size(74, 21)
        Me.ComboBox_D.TabIndex = 37
        '
        'ComboBox_E
        '
        Me.ComboBox_E.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_E.FormattingEnabled = True
        Me.ComboBox_E.Location = New System.Drawing.Point(243, 274)
        Me.ComboBox_E.Name = "ComboBox_E"
        Me.ComboBox_E.Size = New System.Drawing.Size(74, 21)
        Me.ComboBox_E.TabIndex = 39
        '
        'ComboBox_Fs
        '
        Me.ComboBox_Fs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_Fs.FormattingEnabled = True
        Me.ComboBox_Fs.Location = New System.Drawing.Point(243, 328)
        Me.ComboBox_Fs.Name = "ComboBox_Fs"
        Me.ComboBox_Fs.Size = New System.Drawing.Size(74, 21)
        Me.ComboBox_Fs.TabIndex = 41
        '
        'lblNote12
        '
        Me.lblNote12.AutoSize = True
        Me.lblNote12.BackColor = System.Drawing.SystemColors.Control
        Me.lblNote12.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNote12.Location = New System.Drawing.Point(216, 382)
        Me.lblNote12.Name = "lblNote12"
        Me.lblNote12.Size = New System.Drawing.Size(24, 14)
        Me.lblNote12.TabIndex = 43
        Me.lblNote12.Text = "G#"
        '
        'ComboBox_Gs
        '
        Me.ComboBox_Gs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_Gs.FormattingEnabled = True
        Me.ComboBox_Gs.Location = New System.Drawing.Point(243, 382)
        Me.ComboBox_Gs.Name = "ComboBox_Gs"
        Me.ComboBox_Gs.Size = New System.Drawing.Size(74, 21)
        Me.ComboBox_Gs.TabIndex = 44
        '
        'LabelStatus
        '
        Me.LabelStatus.Cursor = System.Windows.Forms.Cursors.PanSE
        Me.LabelStatus.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelStatus.Location = New System.Drawing.Point(1, 3)
        Me.LabelStatus.Name = "LabelStatus"
        Me.LabelStatus.Size = New System.Drawing.Size(185, 14)
        Me.LabelStatus.TabIndex = 45
        Me.LabelStatus.Text = "Status"
        Me.LabelStatus.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LabelCurrentNote
        '
        Me.LabelCurrentNote.Font = New System.Drawing.Font("Tahoma", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCurrentNote.Location = New System.Drawing.Point(2, 17)
        Me.LabelCurrentNote.Name = "LabelCurrentNote"
        Me.LabelCurrentNote.Size = New System.Drawing.Size(96, 58)
        Me.LabelCurrentNote.TabIndex = 49
        Me.LabelCurrentNote.Text = "-"
        Me.LabelCurrentNote.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(89, 34)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(81, 26)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 51
        Me.PictureBox1.TabStop = False
        '
        'ImageListKeys
        '
        Me.ImageListKeys.ImageStream = CType(resources.GetObject("ImageListKeys.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageListKeys.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageListKeys.Images.SetKeyName(0, "btn_delete.png")
        Me.ImageListKeys.Images.SetKeyName(1, "btn_dn.png")
        Me.ImageListKeys.Images.SetKeyName(2, "btn_enter.png")
        Me.ImageListKeys.Images.SetKeyName(3, "btn_escape.png")
        Me.ImageListKeys.Images.SetKeyName(4, "btn_pgdn.png")
        Me.ImageListKeys.Images.SetKeyName(5, "btn_pgup.png")
        Me.ImageListKeys.Images.SetKeyName(6, "btn_space.png")
        Me.ImageListKeys.Images.SetKeyName(7, "btn_tab.png")
        Me.ImageListKeys.Images.SetKeyName(8, "btn_up.png")
        Me.ImageListKeys.Images.SetKeyName(9, "btn_cancel.png")
        Me.ImageListKeys.Images.SetKeyName(10, "btn_none.png")
        Me.ImageListKeys.Images.SetKeyName(11, "btn_tbd.png")
        Me.ImageListKeys.Images.SetKeyName(12, "btn_invisible.png")
        '
        'lblCurrentImage
        '
        Me.lblCurrentImage.ImageKey = "btn_enter.png"
        Me.lblCurrentImage.ImageList = Me.ImageListKeys
        Me.lblCurrentImage.Location = New System.Drawing.Point(88, 33)
        Me.lblCurrentImage.Name = "lblCurrentImage"
        Me.lblCurrentImage.Size = New System.Drawing.Size(79, 24)
        Me.lblCurrentImage.TabIndex = 52
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.SystemColors.Control
        Me.Label15.Location = New System.Drawing.Point(0, 82)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(211, 235)
        Me.Label15.TabIndex = 53
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.lblNote9)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.ComboBox_G)
        Me.GroupBox1.Controls.Add(Me.ComboBox_F)
        Me.GroupBox1.Controls.Add(Me.ComboBox_Eb)
        Me.GroupBox1.Controls.Add(Me.ComboBox_Cs)
        Me.GroupBox1.Controls.Add(Me.lblNote11)
        Me.GroupBox1.Controls.Add(Me.lblNote7)
        Me.GroupBox1.Controls.Add(Me.lblNote5)
        Me.GroupBox1.Controls.Add(Me.ComboBox_B)
        Me.GroupBox1.Controls.Add(Me.ComboBox_A)
        Me.GroupBox1.Controls.Add(Me.lblNote3)
        Me.GroupBox1.Controls.Add(Me.lblNote1)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Location = New System.Drawing.Point(3, 86)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(117, 186)
        Me.GroupBox1.TabIndex = 69
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Key Press"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(22, 81)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(10, 12)
        Me.Label5.TabIndex = 57
        Me.Label5.Text = "3"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.Control
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(13, 134)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(10, 12)
        Me.Label8.TabIndex = 59
        Me.Label8.Text = "3"
        '
        'lblNote9
        '
        Me.lblNote9.AutoSize = True
        Me.lblNote9.BackColor = System.Drawing.SystemColors.Control
        Me.lblNote9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNote9.Location = New System.Drawing.Point(3, 130)
        Me.lblNote9.Name = "lblNote9"
        Me.lblNote9.Size = New System.Drawing.Size(14, 13)
        Me.lblNote9.TabIndex = 49
        Me.lblNote9.Text = "F"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.SystemColors.Control
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(15, 163)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(10, 12)
        Me.Label10.TabIndex = 60
        Me.Label10.Text = "3"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(15, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(10, 12)
        Me.Label4.TabIndex = 56
        Me.Label4.Text = "2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(15, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(10, 12)
        Me.Label3.TabIndex = 55
        Me.Label3.Text = "2"
        '
        'ComboBox_G
        '
        Me.ComboBox_G.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_G.FormattingEnabled = True
        Me.ComboBox_G.Location = New System.Drawing.Point(37, 154)
        Me.ComboBox_G.Name = "ComboBox_G"
        Me.ComboBox_G.Size = New System.Drawing.Size(74, 21)
        Me.ComboBox_G.TabIndex = 54
        '
        'ComboBox_F
        '
        Me.ComboBox_F.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_F.FormattingEnabled = True
        Me.ComboBox_F.Location = New System.Drawing.Point(37, 127)
        Me.ComboBox_F.Name = "ComboBox_F"
        Me.ComboBox_F.Size = New System.Drawing.Size(74, 21)
        Me.ComboBox_F.TabIndex = 53
        '
        'ComboBox_Eb
        '
        Me.ComboBox_Eb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_Eb.FormattingEnabled = True
        Me.ComboBox_Eb.Location = New System.Drawing.Point(37, 100)
        Me.ComboBox_Eb.Name = "ComboBox_Eb"
        Me.ComboBox_Eb.Size = New System.Drawing.Size(74, 21)
        Me.ComboBox_Eb.TabIndex = 52
        '
        'ComboBox_Cs
        '
        Me.ComboBox_Cs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_Cs.FormattingEnabled = True
        Me.ComboBox_Cs.Location = New System.Drawing.Point(37, 73)
        Me.ComboBox_Cs.Name = "ComboBox_Cs"
        Me.ComboBox_Cs.Size = New System.Drawing.Size(74, 21)
        Me.ComboBox_Cs.TabIndex = 51
        '
        'lblNote11
        '
        Me.lblNote11.AutoSize = True
        Me.lblNote11.BackColor = System.Drawing.SystemColors.Control
        Me.lblNote11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNote11.Location = New System.Drawing.Point(3, 157)
        Me.lblNote11.Name = "lblNote11"
        Me.lblNote11.Size = New System.Drawing.Size(16, 13)
        Me.lblNote11.TabIndex = 50
        Me.lblNote11.Text = "G"
        '
        'lblNote7
        '
        Me.lblNote7.AutoSize = True
        Me.lblNote7.BackColor = System.Drawing.SystemColors.Control
        Me.lblNote7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNote7.Location = New System.Drawing.Point(3, 103)
        Me.lblNote7.Name = "lblNote7"
        Me.lblNote7.Size = New System.Drawing.Size(22, 13)
        Me.lblNote7.TabIndex = 48
        Me.lblNote7.Text = "Eb"
        '
        'lblNote5
        '
        Me.lblNote5.AutoSize = True
        Me.lblNote5.BackColor = System.Drawing.SystemColors.Control
        Me.lblNote5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNote5.Location = New System.Drawing.Point(3, 76)
        Me.lblNote5.Name = "lblNote5"
        Me.lblNote5.Size = New System.Drawing.Size(23, 13)
        Me.lblNote5.TabIndex = 47
        Me.lblNote5.Text = "C#"
        '
        'ComboBox_B
        '
        Me.ComboBox_B.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_B.FormattingEnabled = True
        Me.ComboBox_B.Location = New System.Drawing.Point(37, 46)
        Me.ComboBox_B.Name = "ComboBox_B"
        Me.ComboBox_B.Size = New System.Drawing.Size(74, 21)
        Me.ComboBox_B.TabIndex = 46
        '
        'ComboBox_A
        '
        Me.ComboBox_A.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_A.FormattingEnabled = True
        Me.ComboBox_A.Location = New System.Drawing.Point(37, 19)
        Me.ComboBox_A.Name = "ComboBox_A"
        Me.ComboBox_A.Size = New System.Drawing.Size(74, 21)
        Me.ComboBox_A.TabIndex = 45
        '
        'lblNote3
        '
        Me.lblNote3.AutoSize = True
        Me.lblNote3.BackColor = System.Drawing.SystemColors.Control
        Me.lblNote3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNote3.Location = New System.Drawing.Point(3, 48)
        Me.lblNote3.Name = "lblNote3"
        Me.lblNote3.Size = New System.Drawing.Size(15, 13)
        Me.lblNote3.TabIndex = 44
        Me.lblNote3.Text = "B"
        '
        'lblNote1
        '
        Me.lblNote1.AutoSize = True
        Me.lblNote1.BackColor = System.Drawing.SystemColors.Control
        Me.lblNote1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNote1.Location = New System.Drawing.Point(3, 22)
        Me.lblNote1.Name = "lblNote1"
        Me.lblNote1.Size = New System.Drawing.Size(15, 13)
        Me.lblNote1.TabIndex = 43
        Me.lblNote1.Text = "A"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(22, 109)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(10, 12)
        Me.Label6.TabIndex = 58
        Me.Label6.Text = "3"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox2.Controls.Add(Me.ComboBox_Seq5)
        Me.GroupBox2.Controls.Add(Me.ComboBox_Seq4)
        Me.GroupBox2.Controls.Add(Me.ComboBox_Seq3)
        Me.GroupBox2.Controls.Add(Me.ComboBox_Seq2)
        Me.GroupBox2.Controls.Add(Me.ComboBox_Seq1)
        Me.GroupBox2.Location = New System.Drawing.Point(119, 86)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(64, 156)
        Me.GroupBox2.TabIndex = 70
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Seq."
        '
        'ComboBox_Seq5
        '
        Me.ComboBox_Seq5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_Seq5.FormattingEnabled = True
        Me.ComboBox_Seq5.Location = New System.Drawing.Point(6, 126)
        Me.ComboBox_Seq5.Name = "ComboBox_Seq5"
        Me.ComboBox_Seq5.Size = New System.Drawing.Size(52, 21)
        Me.ComboBox_Seq5.TabIndex = 66
        '
        'ComboBox_Seq4
        '
        Me.ComboBox_Seq4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_Seq4.FormattingEnabled = True
        Me.ComboBox_Seq4.Location = New System.Drawing.Point(6, 99)
        Me.ComboBox_Seq4.Name = "ComboBox_Seq4"
        Me.ComboBox_Seq4.Size = New System.Drawing.Size(52, 21)
        Me.ComboBox_Seq4.TabIndex = 65
        '
        'ComboBox_Seq3
        '
        Me.ComboBox_Seq3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_Seq3.FormattingEnabled = True
        Me.ComboBox_Seq3.Location = New System.Drawing.Point(6, 72)
        Me.ComboBox_Seq3.Name = "ComboBox_Seq3"
        Me.ComboBox_Seq3.Size = New System.Drawing.Size(52, 21)
        Me.ComboBox_Seq3.TabIndex = 64
        '
        'ComboBox_Seq2
        '
        Me.ComboBox_Seq2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_Seq2.FormattingEnabled = True
        Me.ComboBox_Seq2.Location = New System.Drawing.Point(6, 45)
        Me.ComboBox_Seq2.Name = "ComboBox_Seq2"
        Me.ComboBox_Seq2.Size = New System.Drawing.Size(52, 21)
        Me.ComboBox_Seq2.TabIndex = 63
        '
        'ComboBox_Seq1
        '
        Me.ComboBox_Seq1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_Seq1.DropDownWidth = 38
        Me.ComboBox_Seq1.FormattingEnabled = True
        Me.ComboBox_Seq1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ComboBox_Seq1.Location = New System.Drawing.Point(6, 18)
        Me.ComboBox_Seq1.Name = "ComboBox_Seq1"
        Me.ComboBox_Seq1.Size = New System.Drawing.Size(52, 21)
        Me.ComboBox_Seq1.TabIndex = 62
        '
        'tbSeq
        '
        Me.tbSeq.Location = New System.Drawing.Point(9, 365)
        Me.tbSeq.Name = "tbSeq"
        Me.tbSeq.Size = New System.Drawing.Size(92, 20)
        Me.tbSeq.TabIndex = 71
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(9, 429)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(148, 20)
        Me.TextBox1.TabIndex = 73
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(9, 455)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(148, 20)
        Me.TextBox2.TabIndex = 74
        '
        'TextBoxMem
        '
        Me.TextBoxMem.BackColor = System.Drawing.Color.Black
        Me.TextBoxMem.Enabled = False
        Me.TextBoxMem.ForeColor = System.Drawing.Color.White
        Me.TextBoxMem.Location = New System.Drawing.Point(1, 278)
        Me.TextBoxMem.Name = "TextBoxMem"
        Me.TextBoxMem.Size = New System.Drawing.Size(184, 20)
        Me.TextBoxMem.TabIndex = 75
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(9, 507)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(148, 20)
        Me.TextBox4.TabIndex = 76
        '
        'TextBoxDirect
        '
        Me.TextBoxDirect.Location = New System.Drawing.Point(9, 403)
        Me.TextBoxDirect.Name = "TextBoxDirect"
        Me.TextBoxDirect.Size = New System.Drawing.Size(148, 20)
        Me.TextBoxDirect.TabIndex = 80
        '
        'lblCurrentNoteOctave
        '
        Me.lblCurrentNoteOctave.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentNoteOctave.Location = New System.Drawing.Point(78, 55)
        Me.lblCurrentNoteOctave.Name = "lblCurrentNoteOctave"
        Me.lblCurrentNoteOctave.Size = New System.Drawing.Size(27, 27)
        Me.lblCurrentNoteOctave.TabIndex = 82
        Me.lblCurrentNoteOctave.Text = "2"
        Me.lblCurrentNoteOctave.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(240, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 83
        Me.Label1.Text = "For Future Use"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 387)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 13)
        Me.Label2.TabIndex = 84
        Me.Label2.Text = "Process Memory"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 349)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 13)
        Me.Label7.TabIndex = 85
        Me.Label7.Text = "Note Sequence"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(9, 481)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(148, 20)
        Me.TextBox3.TabIndex = 86
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(186, 298)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblCurrentImage)
        Me.Controls.Add(Me.lblCurrentNoteOctave)
        Me.Controls.Add(Me.TextBoxDirect)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBoxMem)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.tbSeq)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.LabelCurrentNote)
        Me.Controls.Add(Me.LabelStatus)
        Me.Controls.Add(Me.ComboBox_Gs)
        Me.Controls.Add(Me.lblNote12)
        Me.Controls.Add(Me.ComboBox_Fs)
        Me.Controls.Add(Me.ComboBox_E)
        Me.Controls.Add(Me.ComboBox_D)
        Me.Controls.Add(Me.ComboBox_C)
        Me.Controls.Add(Me.lblNote10)
        Me.Controls.Add(Me.lblNote8)
        Me.Controls.Add(Me.lblNote6)
        Me.Controls.Add(Me.ComboBox_Bb)
        Me.Controls.Add(Me.lblTimerCounter)
        Me.Controls.Add(Me.lblNote4)
        Me.Controls.Add(Me.lblNote2)
        Me.Controls.Add(Me.Label15)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormMain"
        Me.Text = "G2RS v0.3"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblNote4 As Label
    Friend WithEvents lblTimerCounter As Label
    Friend WithEvents ComboBox_Bb As ComboBox
    Friend WithEvents lblNote6 As Label
    Friend WithEvents lblNote8 As Label
    Friend WithEvents lblNote10 As Label
    Friend WithEvents ComboBox_C As ComboBox
    Friend WithEvents ComboBox_D As ComboBox
    Friend WithEvents ComboBox_E As ComboBox
    Friend WithEvents ComboBox_Fs As ComboBox
    Friend WithEvents lblNote12 As Label
    Friend WithEvents ComboBox_Gs As ComboBox
    Friend WithEvents LabelStatus As Label
    Friend WithEvents LabelCurrentNote As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblNote2 As Label
    Friend WithEvents ImageListKeys As ImageList
    Friend WithEvents lblCurrentImage As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ComboBox_G As ComboBox
    Friend WithEvents ComboBox_F As ComboBox
    Friend WithEvents ComboBox_Eb As ComboBox
    Friend WithEvents ComboBox_Cs As ComboBox
    Friend WithEvents lblNote11 As Label
    Friend WithEvents lblNote9 As Label
    Friend WithEvents lblNote7 As Label
    Friend WithEvents lblNote5 As Label
    Friend WithEvents ComboBox_B As ComboBox
    Friend WithEvents ComboBox_A As ComboBox
    Friend WithEvents lblNote3 As Label
    Friend WithEvents lblNote1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ComboBox_Seq5 As ComboBox
    Friend WithEvents ComboBox_Seq4 As ComboBox
    Friend WithEvents ComboBox_Seq3 As ComboBox
    Friend WithEvents ComboBox_Seq2 As ComboBox
    Friend WithEvents ComboBox_Seq1 As ComboBox
    Friend WithEvents tbSeq As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBoxMem As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBoxDirect As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblCurrentNoteOctave As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox3 As TextBox
End Class
