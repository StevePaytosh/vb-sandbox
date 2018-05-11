Public Class Form1

    Dim textBox1 As TextBox
    Dim label1 As Label
    Dim button1 As Button

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        label1 = New Label()
        label1.Text = "enter a name"
        label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        label1.UseMnemonic = True
        label1.Size = New Size(100, 100)
        label1.Location = New Point(0, 0)
        Controls.Add(label1)


        'add text box
        textBox1 = New TextBox()
        '  textBox1.Dock = System.Windows.Forms.DockStyle.Fill
        textBox1.Location = New Point(105, 0)
        textBox1.Size = New Size(100, 100)
        Controls.Add(textBox1)

        'add button
        button1 = New Button()
        button1.Text = "enter"
        button1.Size = New Size(100, 100)
        button1.Location = New Point(0, 115)
        Controls.Add(button1)
        AddHandler button1.Click, AddressOf Button1_Click


        SuspendLayout()
        '  textBox1.AcceptsReturn = True
        ''  textBox1.AcceptsTab = True
        ' textBox1.Multiline = True
        ' textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        ClientSize = New System.Drawing.Size(200, 200)

        Text = "TextBox Example"
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

        textBox1.Visible = False
        button1.Visible = False
        label1.Text = "Hello " + textBox1.Text


    End Sub

End Class
