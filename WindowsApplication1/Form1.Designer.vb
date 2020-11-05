<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnDisable = New System.Windows.Forms.Button()
        Me.BtnEnable = New System.Windows.Forms.Button()
        Me.BtnClear = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextNpm = New System.Windows.Forms.TextBox()
        Me.TextUts = New System.Windows.Forms.TextBox()
        Me.TextUas = New System.Windows.Forms.TextBox()
        Me.TextTugas = New System.Windows.Forms.TextBox()
        Me.TextNama = New System.Windows.Forms.TextBox()
        Me.TextAngka = New System.Windows.Forms.TextBox()
        Me.TextHuruf = New System.Windows.Forms.TextBox()
        Me.TextKet = New System.Windows.Forms.TextBox()
        Me.LblMsg = New System.Windows.Forms.Label()
        Me.BtnHitung = New System.Windows.Forms.Button()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Montserrat SemiBold", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(261, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(516, 40)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "MENGHITUNG NILAI MAHASISWA"
        '
        'BtnDisable
        '
        Me.BtnDisable.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDisable.Location = New System.Drawing.Point(234, 435)
        Me.BtnDisable.Name = "BtnDisable"
        Me.BtnDisable.Size = New System.Drawing.Size(115, 35)
        Me.BtnDisable.TabIndex = 1
        Me.BtnDisable.Text = "DISABLE"
        Me.BtnDisable.UseVisualStyleBackColor = True
        '
        'BtnEnable
        '
        Me.BtnEnable.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEnable.Location = New System.Drawing.Point(422, 435)
        Me.BtnEnable.Name = "BtnEnable"
        Me.BtnEnable.Size = New System.Drawing.Size(115, 35)
        Me.BtnEnable.TabIndex = 2
        Me.BtnEnable.Text = "ENABLE"
        Me.BtnEnable.UseVisualStyleBackColor = True
        '
        'BtnClear
        '
        Me.BtnClear.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClear.Location = New System.Drawing.Point(733, 318)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(115, 35)
        Me.BtnClear.TabIndex = 3
        Me.BtnClear.Text = "CLEAR"
        Me.BtnClear.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Montserrat", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(27, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 26)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Npm"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Montserrat", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(27, 268)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 26)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Nilai Uts"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Montserrat", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(27, 208)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(115, 26)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Nilai Tugas"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Montserrat", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(27, 158)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 26)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Nama"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Montserrat", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(27, 323)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 26)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Nilai Uas"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Montserrat", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(728, 183)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(125, 26)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Keterangan"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Montserrat", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(616, 84)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(120, 26)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Nilai Angka"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Montserrat", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(849, 84)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(113, 26)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Nilai Huruf"
        '
        'TextNpm
        '
        Me.TextNpm.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextNpm.Location = New System.Drawing.Point(234, 84)
        Me.TextNpm.Multiline = True
        Me.TextNpm.Name = "TextNpm"
        Me.TextNpm.Size = New System.Drawing.Size(303, 38)
        Me.TextNpm.TabIndex = 14
        '
        'TextUts
        '
        Me.TextUts.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextUts.Location = New System.Drawing.Point(234, 259)
        Me.TextUts.Multiline = True
        Me.TextUts.Name = "TextUts"
        Me.TextUts.Size = New System.Drawing.Size(303, 38)
        Me.TextUts.TabIndex = 15
        '
        'TextUas
        '
        Me.TextUas.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextUas.Location = New System.Drawing.Point(234, 315)
        Me.TextUas.Multiline = True
        Me.TextUas.Name = "TextUas"
        Me.TextUas.Size = New System.Drawing.Size(303, 38)
        Me.TextUas.TabIndex = 16
        '
        'TextTugas
        '
        Me.TextTugas.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextTugas.Location = New System.Drawing.Point(234, 202)
        Me.TextTugas.Multiline = True
        Me.TextTugas.Name = "TextTugas"
        Me.TextTugas.Size = New System.Drawing.Size(303, 38)
        Me.TextTugas.TabIndex = 17
        '
        'TextNama
        '
        Me.TextNama.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextNama.Location = New System.Drawing.Point(234, 146)
        Me.TextNama.Multiline = True
        Me.TextNama.Name = "TextNama"
        Me.TextNama.Size = New System.Drawing.Size(303, 38)
        Me.TextNama.TabIndex = 18
        '
        'TextAngka
        '
        Me.TextAngka.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextAngka.Location = New System.Drawing.Point(584, 123)
        Me.TextAngka.Multiline = True
        Me.TextAngka.Name = "TextAngka"
        Me.TextAngka.Size = New System.Drawing.Size(183, 38)
        Me.TextAngka.TabIndex = 19
        Me.TextAngka.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextHuruf
        '
        Me.TextHuruf.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextHuruf.Location = New System.Drawing.Point(815, 123)
        Me.TextHuruf.Multiline = True
        Me.TextHuruf.Name = "TextHuruf"
        Me.TextHuruf.Size = New System.Drawing.Size(183, 38)
        Me.TextHuruf.TabIndex = 20
        Me.TextHuruf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextKet
        '
        Me.TextKet.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextKet.Location = New System.Drawing.Point(584, 219)
        Me.TextKet.Multiline = True
        Me.TextKet.Name = "TextKet"
        Me.TextKet.Size = New System.Drawing.Size(414, 78)
        Me.TextKet.TabIndex = 21
        Me.TextKet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LblMsg
        '
        Me.LblMsg.AutoSize = True
        Me.LblMsg.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMsg.Location = New System.Drawing.Point(231, 390)
        Me.LblMsg.Name = "LblMsg"
        Me.LblMsg.Size = New System.Drawing.Size(0, 22)
        Me.LblMsg.TabIndex = 22
        '
        'BtnHitung
        '
        Me.BtnHitung.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnHitung.Location = New System.Drawing.Point(883, 318)
        Me.BtnHitung.Name = "BtnHitung"
        Me.BtnHitung.Size = New System.Drawing.Size(115, 35)
        Me.BtnHitung.TabIndex = 23
        Me.BtnHitung.Text = "HITUNG"
        Me.BtnHitung.UseVisualStyleBackColor = True
        '
        'BtnExit
        '
        Me.BtnExit.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExit.Location = New System.Drawing.Point(584, 318)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(115, 35)
        Me.BtnExit.TabIndex = 24
        Me.BtnExit.Text = "EXIT"
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1034, 595)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.BtnHitung)
        Me.Controls.Add(Me.LblMsg)
        Me.Controls.Add(Me.TextKet)
        Me.Controls.Add(Me.TextHuruf)
        Me.Controls.Add(Me.TextAngka)
        Me.Controls.Add(Me.TextNama)
        Me.Controls.Add(Me.TextTugas)
        Me.Controls.Add(Me.TextUas)
        Me.Controls.Add(Me.TextUts)
        Me.Controls.Add(Me.TextNpm)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnClear)
        Me.Controls.Add(Me.BtnEnable)
        Me.Controls.Add(Me.BtnDisable)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Menghitung Nilai Mahasiswa"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnDisable As System.Windows.Forms.Button
    Friend WithEvents BtnEnable As System.Windows.Forms.Button
    Friend WithEvents BtnClear As System.Windows.Forms.Button


    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click

    End Sub
    Friend WithEvents TextNpm As System.Windows.Forms.TextBox
    Friend WithEvents TextUts As System.Windows.Forms.TextBox
    Friend WithEvents TextUas As System.Windows.Forms.TextBox
    Friend WithEvents TextTugas As System.Windows.Forms.TextBox
    Friend WithEvents TextNama As System.Windows.Forms.TextBox
    Friend WithEvents TextAngka As System.Windows.Forms.TextBox
    Friend WithEvents TextHuruf As System.Windows.Forms.TextBox
    Friend WithEvents TextKet As System.Windows.Forms.TextBox
    Friend WithEvents LblMsg As System.Windows.Forms.Label
    Friend WithEvents BtnHitung As System.Windows.Forms.Button
    Friend WithEvents BtnExit As System.Windows.Forms.Button

    Private Sub BtnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClear.Click
        TextNpm.Text = ""

        TextNama.Text = ""

        TextTugas.Text = ""

        TextUts.Text = ""

        TextUas.Text = ""

        TextAngka.Text = ""

        TextHuruf.Text = ""

        TextKet.Text = ""

    End Sub

    Private Sub BtnHitung_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHitung.Click
        Dim Npm As String

        Dim Nama As String

        Dim Tugas As Double

        Dim UTS As Double

        Dim UAS As Double

        Dim Huruf As String

        Dim Angka As Double

        Dim Komentar As String

        Npm = TextNpm.Text

        Nama = TextNama.Text

        Tugas = Val(TextTugas.Text)

        UTS = Val(TextUts.Text)

        UAS = Val(TextUas.Text)

        Angka = (0.2 * Tugas + 0.3 * UTS + 0.5 * UAS)

        TextAngka.Text = Angka



        If Angka <= 56 Then

            Huruf = "E"

            Komentar = "Nilai Anda Sangat kurang"

        ElseIf Angka <= 65 Then

            Huruf = "D"

            Komentar = "Nilai Anda Kurang"

        ElseIf Angka <= 75 Then

            Huruf = "C"

            Komentar = "Nilai Anda Cukup! Anda Lulus"

        ElseIf Angka <= 85 Then

            Huruf = "B"

            Komentar = "Nilai Anda Baik! Anda Lulus"

        ElseIf Angka > 85 Then

            Huruf = "A"

            Komentar = "Nilai Anda Sangat Baik"

        End If

        TextHuruf.Text = Huruf

        TextKet.Text = Komentar


    End Sub

    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
        End
    End Sub

    Private Sub BtnDisable_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDisable.Click
        TextNpm.Enabled = False
        TextNama.Enabled = False
        TextTugas.Enabled = False
        TextUts.Enabled = False
        TextUas.Enabled = False
        TextAngka.Enabled = False
        TextHuruf.Enabled = False
        TextKet.Enabled = False
        BtnClear.Enabled = False
        BtnExit.Enabled = False
        BtnHitung.Enabled = False
        LblMsg.Text = "Form Terkunci, Klik Enable Untuk Membuka"
    End Sub

    Private Sub BtnEnable_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEnable.Click
        TextNpm.Enabled = True
        TextNpm.Enabled = True
        TextNama.Enabled = True
        TextTugas.Enabled = True
        TextUts.Enabled = True
        TextUas.Enabled = True
        TextAngka.Enabled = True
        TextHuruf.Enabled = True
        TextKet.Enabled = True
        BtnClear.Enabled = True
        BtnExit.Enabled = True
        BtnHitung.Enabled = True

        LblMsg.Text = "Form Terbuka"
    End Sub
End Class
