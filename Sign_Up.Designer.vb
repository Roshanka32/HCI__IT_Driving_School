<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Sign_Up
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Sign_Up))
        Panel1 = New Panel()
        Label2 = New Label()
        Label1 = New Label()
        Panel2 = New Panel()
        Label3 = New Label()
        Panel4 = New Panel()
        Panel3 = New Panel()
        ContactTbox = New TextBox()
        Label8 = New Label()
        AddressTbox = New TextBox()
        Label7 = New Label()
        NameTbox = New TextBox()
        Label4 = New Label()
        Newuserbtn = New Button()
        Button1 = New Button()
        TextBox2 = New TextBox()
        Label6 = New Label()
        TextBox1 = New TextBox()
        Label5 = New Label()
        Panel5 = New Panel()
        SignUpbtn = New Label()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel4.SuspendLayout()
        Panel3.SuspendLayout()
        Panel5.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1080, 80)
        Panel1.TabIndex = 0
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(56, 19)
        Label2.Name = "Label2"
        Label2.Size = New Size(261, 41)
        Label2.TabIndex = 1
        Label2.Text = "IT Driving School"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(239, 198)
        Label1.Name = "Label1"
        Label1.Size = New Size(53, 20)
        Label1.TabIndex = 0
        Label1.Text = "Label1"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        Panel2.Controls.Add(Label3)
        Panel2.Dock = DockStyle.Bottom
        Panel2.Location = New Point(0, 661)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1080, 59)
        Panel2.TabIndex = 1
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(852, 20)
        Label3.Name = "Label3"
        Label3.Size = New Size(172, 17)
        Label3.TabIndex = 0
        Label3.Text = "@2023 All Rights Reserved"
        ' 
        ' Panel4
        ' 
        Panel4.BackgroundImage = CType(resources.GetObject("Panel4.BackgroundImage"), Image)
        Panel4.Controls.Add(Panel3)
        Panel4.Dock = DockStyle.Fill
        Panel4.Location = New Point(0, 80)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(1080, 581)
        Panel4.TabIndex = 3
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.White
        Panel3.Controls.Add(ContactTbox)
        Panel3.Controls.Add(Label8)
        Panel3.Controls.Add(AddressTbox)
        Panel3.Controls.Add(Label7)
        Panel3.Controls.Add(NameTbox)
        Panel3.Controls.Add(Label4)
        Panel3.Controls.Add(Newuserbtn)
        Panel3.Controls.Add(Button1)
        Panel3.Controls.Add(TextBox2)
        Panel3.Controls.Add(Label6)
        Panel3.Controls.Add(TextBox1)
        Panel3.Controls.Add(Label5)
        Panel3.Controls.Add(Panel5)
        Panel3.Location = New Point(345, 29)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(425, 512)
        Panel3.TabIndex = 0
        ' 
        ' ContactTbox
        ' 
        ContactTbox.Font = New Font("Microsoft Sans Serif", 8.25F)
        ContactTbox.Location = New Point(38, 248)
        ContactTbox.Name = "ContactTbox"
        ContactTbox.Size = New Size(348, 23)
        ContactTbox.TabIndex = 12
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(38, 219)
        Label8.Name = "Label8"
        Label8.Size = New Size(67, 18)
        Label8.TabIndex = 11
        Label8.Text = "Contact"
        ' 
        ' AddressTbox
        ' 
        AddressTbox.Font = New Font("Microsoft Sans Serif", 8.25F)
        AddressTbox.Location = New Point(38, 183)
        AddressTbox.Name = "AddressTbox"
        AddressTbox.Size = New Size(348, 23)
        AddressTbox.TabIndex = 10
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(38, 154)
        Label7.Name = "Label7"
        Label7.Size = New Size(69, 18)
        Label7.TabIndex = 9
        Label7.Text = "Address"
        ' 
        ' NameTbox
        ' 
        NameTbox.Font = New Font("Microsoft Sans Serif", 8.25F)
        NameTbox.Location = New Point(38, 116)
        NameTbox.Name = "NameTbox"
        NameTbox.Size = New Size(348, 23)
        NameTbox.TabIndex = 8
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(38, 89)
        Label4.Name = "Label4"
        Label4.Size = New Size(52, 18)
        Label4.TabIndex = 7
        Label4.Text = "Name"
        ' 
        ' Newuserbtn
        ' 
        Newuserbtn.BackgroundImageLayout = ImageLayout.None
        Newuserbtn.FlatAppearance.BorderSize = 0
        Newuserbtn.FlatStyle = FlatStyle.Flat
        Newuserbtn.Font = New Font("Segoe UI", 7.20000029F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Newuserbtn.Location = New Point(60, 449)
        Newuserbtn.Name = "Newuserbtn"
        Newuserbtn.Size = New Size(193, 29)
        Newuserbtn.TabIndex = 6
        Newuserbtn.Text = "Already have an account?"
        Newuserbtn.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Blue
        Button1.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = SystemColors.ControlLightLight
        Button1.Location = New Point(254, 443)
        Button1.Name = "Button1"
        Button1.Size = New Size(105, 38)
        Button1.TabIndex = 5
        Button1.Text = "Sign Up"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Microsoft Sans Serif", 8.25F)
        TextBox2.Location = New Point(38, 372)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(348, 23)
        TextBox2.TabIndex = 4
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(38, 344)
        Label6.Name = "Label6"
        Label6.Size = New Size(83, 18)
        Label6.TabIndex = 3
        Label6.Text = "Password"
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Microsoft Sans Serif", 8.25F)
        TextBox1.Location = New Point(38, 311)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(348, 23)
        TextBox1.TabIndex = 2
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(38, 283)
        Label5.Name = "Label5"
        Label5.Size = New Size(50, 18)
        Label5.TabIndex = 1
        Label5.Text = "Email"
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(0))
        Panel5.Controls.Add(SignUpbtn)
        Panel5.Dock = DockStyle.Top
        Panel5.Location = New Point(0, 0)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(425, 53)
        Panel5.TabIndex = 0
        ' 
        ' SignUpbtn
        ' 
        SignUpbtn.AutoSize = True
        SignUpbtn.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        SignUpbtn.Location = New Point(164, 11)
        SignUpbtn.Name = "SignUpbtn"
        SignUpbtn.Size = New Size(99, 31)
        SignUpbtn.TabIndex = 0
        SignUpbtn.Text = "Sign Up"
        ' 
        ' Sign_Up
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1080, 720)
        Controls.Add(Panel4)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Sign_Up"
        StartPosition = FormStartPosition.WindowsDefaultBounds
        Text = "Form1"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents SignUpbtn As Label
    Friend WithEvents Newuserbtn As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents ContactTbox As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents AddressTbox As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents NameTbox As TextBox
    Friend WithEvents Label4 As Label

End Class
