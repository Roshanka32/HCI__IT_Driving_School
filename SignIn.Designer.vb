<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SignIn
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SignIn))
        Panel4 = New Panel()
        Panel2 = New Panel()
        Label3 = New Label()
        Panel1 = New Panel()
        Label2 = New Label()
        Label1 = New Label()
        Panel3 = New Panel()
        AddressTbox = New TextBox()
        Label7 = New Label()
        NameTbox = New TextBox()
        Label4 = New Label()
        Newuserbtn = New Button()
        Button1 = New Button()
        Panel5 = New Panel()
        SignUpbtn = New Label()
        Panel4.SuspendLayout()
        Panel2.SuspendLayout()
        Panel1.SuspendLayout()
        Panel3.SuspendLayout()
        Panel5.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel4
        ' 
        Panel4.BackgroundImage = CType(resources.GetObject("Panel4.BackgroundImage"), Image)
        Panel4.Controls.Add(Panel3)
        Panel4.Dock = DockStyle.Fill
        Panel4.Location = New Point(0, 80)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(1080, 581)
        Panel4.TabIndex = 6
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        Panel2.Controls.Add(Label3)
        Panel2.Dock = DockStyle.Bottom
        Panel2.Location = New Point(0, 661)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1080, 59)
        Panel2.TabIndex = 5
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
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1080, 80)
        Panel1.TabIndex = 4
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
        ' Panel3
        ' 
        Panel3.BackColor = Color.White
        Panel3.Controls.Add(AddressTbox)
        Panel3.Controls.Add(Label7)
        Panel3.Controls.Add(NameTbox)
        Panel3.Controls.Add(Label4)
        Panel3.Controls.Add(Newuserbtn)
        Panel3.Controls.Add(Button1)
        Panel3.Controls.Add(Panel5)
        Panel3.Location = New Point(317, 108)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(463, 313)
        Panel3.TabIndex = 1
        ' 
        ' AddressTbox
        ' 
        AddressTbox.Font = New Font("Microsoft Sans Serif", 8.25F)
        AddressTbox.Location = New Point(38, 183)
        AddressTbox.Name = "AddressTbox"
        AddressTbox.Size = New Size(375, 23)
        AddressTbox.TabIndex = 10
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(38, 154)
        Label7.Name = "Label7"
        Label7.Size = New Size(83, 18)
        Label7.TabIndex = 9
        Label7.Text = "Password"
        ' 
        ' NameTbox
        ' 
        NameTbox.Font = New Font("Microsoft Sans Serif", 8.25F)
        NameTbox.Location = New Point(38, 116)
        NameTbox.Name = "NameTbox"
        NameTbox.Size = New Size(375, 23)
        NameTbox.TabIndex = 8
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(38, 89)
        Label4.Name = "Label4"
        Label4.Size = New Size(50, 18)
        Label4.TabIndex = 7
        Label4.Text = "Email"
        ' 
        ' Newuserbtn
        ' 
        Newuserbtn.BackgroundImageLayout = ImageLayout.None
        Newuserbtn.FlatAppearance.BorderSize = 0
        Newuserbtn.FlatStyle = FlatStyle.Flat
        Newuserbtn.Font = New Font("Segoe UI", 7.20000029F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Newuserbtn.Location = New Point(124, 236)
        Newuserbtn.Name = "Newuserbtn"
        Newuserbtn.Size = New Size(109, 29)
        Newuserbtn.TabIndex = 6
        Newuserbtn.Text = "New User?"
        Newuserbtn.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Blue
        Button1.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = SystemColors.ControlLightLight
        Button1.Location = New Point(233, 233)
        Button1.Name = "Button1"
        Button1.Size = New Size(105, 38)
        Button1.TabIndex = 5
        Button1.Text = "Sign In"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(192))
        Panel5.Controls.Add(SignUpbtn)
        Panel5.Dock = DockStyle.Top
        Panel5.Location = New Point(0, 0)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(463, 53)
        Panel5.TabIndex = 0
        ' 
        ' SignUpbtn
        ' 
        SignUpbtn.AutoSize = True
        SignUpbtn.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        SignUpbtn.Location = New Point(188, 11)
        SignUpbtn.Name = "SignUpbtn"
        SignUpbtn.Size = New Size(89, 31)
        SignUpbtn.TabIndex = 0
        SignUpbtn.Text = "Sign In"
        ' 
        ' SignIn
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1080, 720)
        Controls.Add(Panel4)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "SignIn"
        Text = "SignIn"
        Panel4.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents AddressTbox As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents NameTbox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Newuserbtn As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents SignUpbtn As Label
End Class
