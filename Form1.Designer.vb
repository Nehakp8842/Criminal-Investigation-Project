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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        txtUser = New TextBox()
        txtPass = New TextBox()
        Login = New Button()
        ComboBox1 = New ComboBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(30, 80)
        Label1.Name = "Label1"
        Label1.Size = New Size(94, 25)
        Label1.TabIndex = 0
        Label1.Text = "UserName"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(30, 144)
        Label2.Name = "Label2"
        Label2.Size = New Size(87, 25)
        Label2.TabIndex = 1
        Label2.Text = "Password"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(30, 216)
        Label3.Name = "Label3"
        Label3.Size = New Size(89, 25)
        Label3.TabIndex = 2
        Label3.Text = "User Type"
        ' 
        ' txtUser
        ' 
        txtUser.Location = New Point(257, 81)
        txtUser.Name = "txtUser"
        txtUser.Size = New Size(141, 27)
        txtUser.TabIndex = 3
        ' 
        ' txtPass
        ' 
        txtPass.Location = New Point(257, 144)
        txtPass.Name = "txtPass"
        txtPass.Size = New Size(142, 27)
        txtPass.TabIndex = 4
        ' 
        ' Login
        ' 
        Login.Font = New Font("Palatino Linotype", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Login.Location = New Point(114, 302)
        Login.Name = "Login"
        Login.Size = New Size(130, 41)
        Login.TabIndex = 6
        Login.Text = "Login"
        Login.UseVisualStyleBackColor = True
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Admin", "Officer"})
        ComboBox1.Location = New Point(257, 213)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(142, 28)
        ComboBox1.TabIndex = 7
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Center
        ClientSize = New Size(922, 534)
        Controls.Add(ComboBox1)
        Controls.Add(Login)
        Controls.Add(txtPass)
        Controls.Add(txtUser)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        DoubleBuffered = True
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtUser As TextBox
    Friend WithEvents txtPass As TextBox
    Friend WithEvents Login As Button
    Friend WithEvents ComboBox1 As ComboBox

End Class
