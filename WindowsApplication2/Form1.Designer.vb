<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ticket_Booking
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
		Me.Train_No = New System.Windows.Forms.TextBox()
		Me.Pass_Name = New System.Windows.Forms.TextBox()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Class_List = New System.Windows.Forms.ListBox()
		Me.Fare = New System.Windows.Forms.TextBox()
		Me.Panel1 = New System.Windows.Forms.Panel()
		Me.gn6 = New System.Windows.Forms.TextBox()
		Me.ag6 = New System.Windows.Forms.TextBox()
		Me.psn6 = New System.Windows.Forms.TextBox()
		Me.TextBox28 = New System.Windows.Forms.TextBox()
		Me.gn5 = New System.Windows.Forms.TextBox()
		Me.ag5 = New System.Windows.Forms.TextBox()
		Me.psn5 = New System.Windows.Forms.TextBox()
		Me.TextBox24 = New System.Windows.Forms.TextBox()
		Me.gn4 = New System.Windows.Forms.TextBox()
		Me.ag4 = New System.Windows.Forms.TextBox()
		Me.psn4 = New System.Windows.Forms.TextBox()
		Me.TextBox20 = New System.Windows.Forms.TextBox()
		Me.gn3 = New System.Windows.Forms.TextBox()
		Me.ag3 = New System.Windows.Forms.TextBox()
		Me.psn3 = New System.Windows.Forms.TextBox()
		Me.TextBox16 = New System.Windows.Forms.TextBox()
		Me.gn2 = New System.Windows.Forms.TextBox()
		Me.ag2 = New System.Windows.Forms.TextBox()
		Me.psn2 = New System.Windows.Forms.TextBox()
		Me.TextBox12 = New System.Windows.Forms.TextBox()
		Me.gn1 = New System.Windows.Forms.TextBox()
		Me.ag1 = New System.Windows.Forms.TextBox()
		Me.psn1 = New System.Windows.Forms.TextBox()
		Me.TextBox8 = New System.Windows.Forms.TextBox()
		Me.TextBox4 = New System.Windows.Forms.TextBox()
		Me.TextBox3 = New System.Windows.Forms.TextBox()
		Me.TextBox2 = New System.Windows.Forms.TextBox()
		Me.TextBox1 = New System.Windows.Forms.TextBox()
		Me.Total = New System.Windows.Forms.TextBox()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.Button2 = New System.Windows.Forms.Button()
		Me.Panel1.SuspendLayout()
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(22, 29)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(103, 24)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Train No: "
		'
		'Train_No
		'
		Me.Train_No.BackColor = System.Drawing.SystemColors.Info
		Me.Train_No.Location = New System.Drawing.Point(131, 29)
		Me.Train_No.Name = "Train_No"
		Me.Train_No.Size = New System.Drawing.Size(170, 20)
		Me.Train_No.TabIndex = 1
		'
		'Pass_Name
		'
		Me.Pass_Name.BackColor = System.Drawing.SystemColors.Info
		Me.Pass_Name.Location = New System.Drawing.Point(215, 79)
		Me.Pass_Name.Name = "Pass_Name"
		Me.Pass_Name.Size = New System.Drawing.Size(252, 20)
		Me.Pass_Name.TabIndex = 2
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.Location = New System.Drawing.Point(22, 79)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(176, 24)
		Me.Label3.TabIndex = 4
		Me.Label3.Text = "Passenger Name:"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Location = New System.Drawing.Point(517, 29)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(66, 24)
		Me.Label2.TabIndex = 6
		Me.Label2.Text = "Class:"
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label4.Location = New System.Drawing.Point(517, 79)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(59, 24)
		Me.Label4.TabIndex = 7
		Me.Label4.Text = "Fare:"
		'
		'Class_List
		'
		Me.Class_List.BackColor = System.Drawing.SystemColors.Info
		Me.Class_List.FormattingEnabled = True
		Me.Class_List.Items.AddRange(New Object() {"Sleeper", "2 AC", "3 AC", "General"})
		Me.Class_List.Location = New System.Drawing.Point(635, 12)
		Me.Class_List.Name = "Class_List"
		Me.Class_List.Size = New System.Drawing.Size(116, 56)
		Me.Class_List.TabIndex = 3
		'
		'Fare
		'
		Me.Fare.BackColor = System.Drawing.SystemColors.Info
		Me.Fare.ForeColor = System.Drawing.SystemColors.WindowText
		Me.Fare.Location = New System.Drawing.Point(635, 82)
		Me.Fare.Name = "Fare"
		Me.Fare.ReadOnly = True
		Me.Fare.Size = New System.Drawing.Size(114, 20)
		Me.Fare.TabIndex = 4
		Me.Fare.TabStop = False
		'
		'Panel1
		'
		Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
		Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Panel1.Controls.Add(Me.gn6)
		Me.Panel1.Controls.Add(Me.ag6)
		Me.Panel1.Controls.Add(Me.psn6)
		Me.Panel1.Controls.Add(Me.TextBox28)
		Me.Panel1.Controls.Add(Me.gn5)
		Me.Panel1.Controls.Add(Me.ag5)
		Me.Panel1.Controls.Add(Me.psn5)
		Me.Panel1.Controls.Add(Me.TextBox24)
		Me.Panel1.Controls.Add(Me.gn4)
		Me.Panel1.Controls.Add(Me.ag4)
		Me.Panel1.Controls.Add(Me.psn4)
		Me.Panel1.Controls.Add(Me.TextBox20)
		Me.Panel1.Controls.Add(Me.gn3)
		Me.Panel1.Controls.Add(Me.ag3)
		Me.Panel1.Controls.Add(Me.psn3)
		Me.Panel1.Controls.Add(Me.TextBox16)
		Me.Panel1.Controls.Add(Me.gn2)
		Me.Panel1.Controls.Add(Me.ag2)
		Me.Panel1.Controls.Add(Me.psn2)
		Me.Panel1.Controls.Add(Me.TextBox12)
		Me.Panel1.Controls.Add(Me.gn1)
		Me.Panel1.Controls.Add(Me.ag1)
		Me.Panel1.Controls.Add(Me.psn1)
		Me.Panel1.Controls.Add(Me.TextBox8)
		Me.Panel1.Controls.Add(Me.TextBox4)
		Me.Panel1.Controls.Add(Me.TextBox3)
		Me.Panel1.Controls.Add(Me.TextBox2)
		Me.Panel1.Controls.Add(Me.TextBox1)
		Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Panel1.Location = New System.Drawing.Point(61, 124)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(500, 193)
		Me.Panel1.TabIndex = 8
		'
		'gn6
		'
		Me.gn6.BackColor = System.Drawing.SystemColors.Info
		Me.gn6.Location = New System.Drawing.Point(373, 161)
		Me.gn6.Name = "gn6"
		Me.gn6.Size = New System.Drawing.Size(117, 22)
		Me.gn6.TabIndex = 17
		'
		'ag6
		'
		Me.ag6.BackColor = System.Drawing.SystemColors.Info
		Me.ag6.Location = New System.Drawing.Point(250, 161)
		Me.ag6.Name = "ag6"
		Me.ag6.Size = New System.Drawing.Size(117, 22)
		Me.ag6.TabIndex = 16
		'
		'psn6
		'
		Me.psn6.BackColor = System.Drawing.SystemColors.Info
		Me.psn6.Location = New System.Drawing.Point(127, 161)
		Me.psn6.Name = "psn6"
		Me.psn6.Size = New System.Drawing.Size(117, 22)
		Me.psn6.TabIndex = 15
		'
		'TextBox28
		'
		Me.TextBox28.BackColor = System.Drawing.SystemColors.MenuBar
		Me.TextBox28.Location = New System.Drawing.Point(4, 161)
		Me.TextBox28.Name = "TextBox28"
		Me.TextBox28.ReadOnly = True
		Me.TextBox28.Size = New System.Drawing.Size(117, 22)
		Me.TextBox28.TabIndex = 24
		Me.TextBox28.TabStop = False
		Me.TextBox28.Text = "6"
		Me.TextBox28.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		'
		'gn5
		'
		Me.gn5.BackColor = System.Drawing.SystemColors.Info
		Me.gn5.Location = New System.Drawing.Point(373, 133)
		Me.gn5.Name = "gn5"
		Me.gn5.Size = New System.Drawing.Size(117, 22)
		Me.gn5.TabIndex = 14
		'
		'ag5
		'
		Me.ag5.BackColor = System.Drawing.SystemColors.Info
		Me.ag5.Location = New System.Drawing.Point(250, 133)
		Me.ag5.Name = "ag5"
		Me.ag5.Size = New System.Drawing.Size(117, 22)
		Me.ag5.TabIndex = 13
		'
		'psn5
		'
		Me.psn5.BackColor = System.Drawing.SystemColors.Info
		Me.psn5.Location = New System.Drawing.Point(127, 133)
		Me.psn5.Name = "psn5"
		Me.psn5.Size = New System.Drawing.Size(117, 22)
		Me.psn5.TabIndex = 12
		'
		'TextBox24
		'
		Me.TextBox24.BackColor = System.Drawing.SystemColors.MenuBar
		Me.TextBox24.Location = New System.Drawing.Point(4, 133)
		Me.TextBox24.Name = "TextBox24"
		Me.TextBox24.ReadOnly = True
		Me.TextBox24.Size = New System.Drawing.Size(117, 22)
		Me.TextBox24.TabIndex = 20
		Me.TextBox24.TabStop = False
		Me.TextBox24.Text = "5"
		Me.TextBox24.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		'
		'gn4
		'
		Me.gn4.BackColor = System.Drawing.SystemColors.Info
		Me.gn4.Location = New System.Drawing.Point(373, 107)
		Me.gn4.Name = "gn4"
		Me.gn4.Size = New System.Drawing.Size(117, 22)
		Me.gn4.TabIndex = 11
		'
		'ag4
		'
		Me.ag4.BackColor = System.Drawing.SystemColors.Info
		Me.ag4.Location = New System.Drawing.Point(250, 107)
		Me.ag4.Name = "ag4"
		Me.ag4.Size = New System.Drawing.Size(117, 22)
		Me.ag4.TabIndex = 10
		'
		'psn4
		'
		Me.psn4.BackColor = System.Drawing.SystemColors.Info
		Me.psn4.Location = New System.Drawing.Point(127, 107)
		Me.psn4.Name = "psn4"
		Me.psn4.Size = New System.Drawing.Size(117, 22)
		Me.psn4.TabIndex = 9
		'
		'TextBox20
		'
		Me.TextBox20.BackColor = System.Drawing.SystemColors.MenuBar
		Me.TextBox20.Location = New System.Drawing.Point(4, 107)
		Me.TextBox20.Name = "TextBox20"
		Me.TextBox20.ReadOnly = True
		Me.TextBox20.Size = New System.Drawing.Size(117, 22)
		Me.TextBox20.TabIndex = 16
		Me.TextBox20.TabStop = False
		Me.TextBox20.Text = "4"
		Me.TextBox20.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		'
		'gn3
		'
		Me.gn3.BackColor = System.Drawing.SystemColors.Info
		Me.gn3.Location = New System.Drawing.Point(373, 81)
		Me.gn3.Name = "gn3"
		Me.gn3.Size = New System.Drawing.Size(117, 22)
		Me.gn3.TabIndex = 8
		'
		'ag3
		'
		Me.ag3.BackColor = System.Drawing.SystemColors.Info
		Me.ag3.Location = New System.Drawing.Point(250, 81)
		Me.ag3.Name = "ag3"
		Me.ag3.Size = New System.Drawing.Size(117, 22)
		Me.ag3.TabIndex = 7
		'
		'psn3
		'
		Me.psn3.BackColor = System.Drawing.SystemColors.Info
		Me.psn3.Location = New System.Drawing.Point(127, 81)
		Me.psn3.Name = "psn3"
		Me.psn3.Size = New System.Drawing.Size(117, 22)
		Me.psn3.TabIndex = 6
		'
		'TextBox16
		'
		Me.TextBox16.BackColor = System.Drawing.SystemColors.MenuBar
		Me.TextBox16.Location = New System.Drawing.Point(4, 81)
		Me.TextBox16.Name = "TextBox16"
		Me.TextBox16.ReadOnly = True
		Me.TextBox16.Size = New System.Drawing.Size(117, 22)
		Me.TextBox16.TabIndex = 12
		Me.TextBox16.TabStop = False
		Me.TextBox16.Text = "3"
		Me.TextBox16.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		'
		'gn2
		'
		Me.gn2.BackColor = System.Drawing.SystemColors.Info
		Me.gn2.Location = New System.Drawing.Point(373, 55)
		Me.gn2.Name = "gn2"
		Me.gn2.Size = New System.Drawing.Size(117, 22)
		Me.gn2.TabIndex = 5
		'
		'ag2
		'
		Me.ag2.BackColor = System.Drawing.SystemColors.Info
		Me.ag2.Location = New System.Drawing.Point(250, 55)
		Me.ag2.Name = "ag2"
		Me.ag2.Size = New System.Drawing.Size(117, 22)
		Me.ag2.TabIndex = 4
		'
		'psn2
		'
		Me.psn2.BackColor = System.Drawing.SystemColors.Info
		Me.psn2.Location = New System.Drawing.Point(127, 55)
		Me.psn2.Name = "psn2"
		Me.psn2.Size = New System.Drawing.Size(117, 22)
		Me.psn2.TabIndex = 3
		'
		'TextBox12
		'
		Me.TextBox12.BackColor = System.Drawing.SystemColors.MenuBar
		Me.TextBox12.Location = New System.Drawing.Point(4, 55)
		Me.TextBox12.Name = "TextBox12"
		Me.TextBox12.ReadOnly = True
		Me.TextBox12.Size = New System.Drawing.Size(117, 22)
		Me.TextBox12.TabIndex = 8
		Me.TextBox12.TabStop = False
		Me.TextBox12.Text = "2"
		Me.TextBox12.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		'
		'gn1
		'
		Me.gn1.BackColor = System.Drawing.SystemColors.Info
		Me.gn1.Location = New System.Drawing.Point(373, 29)
		Me.gn1.Name = "gn1"
		Me.gn1.Size = New System.Drawing.Size(117, 22)
		Me.gn1.TabIndex = 2
		'
		'ag1
		'
		Me.ag1.BackColor = System.Drawing.SystemColors.Info
		Me.ag1.Location = New System.Drawing.Point(250, 29)
		Me.ag1.Name = "ag1"
		Me.ag1.Size = New System.Drawing.Size(117, 22)
		Me.ag1.TabIndex = 1
		'
		'psn1
		'
		Me.psn1.BackColor = System.Drawing.SystemColors.Info
		Me.psn1.Location = New System.Drawing.Point(127, 29)
		Me.psn1.Name = "psn1"
		Me.psn1.Size = New System.Drawing.Size(117, 22)
		Me.psn1.TabIndex = 0
		'
		'TextBox8
		'
		Me.TextBox8.BackColor = System.Drawing.SystemColors.MenuBar
		Me.TextBox8.Location = New System.Drawing.Point(4, 29)
		Me.TextBox8.Name = "TextBox8"
		Me.TextBox8.ReadOnly = True
		Me.TextBox8.Size = New System.Drawing.Size(117, 22)
		Me.TextBox8.TabIndex = 4
		Me.TextBox8.TabStop = False
		Me.TextBox8.Text = "1"
		Me.TextBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		'
		'TextBox4
		'
		Me.TextBox4.BackColor = System.Drawing.SystemColors.MenuBar
		Me.TextBox4.Location = New System.Drawing.Point(372, 3)
		Me.TextBox4.Name = "TextBox4"
		Me.TextBox4.ReadOnly = True
		Me.TextBox4.Size = New System.Drawing.Size(117, 22)
		Me.TextBox4.TabIndex = 3
		Me.TextBox4.TabStop = False
		Me.TextBox4.Text = "Gender"
		Me.TextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'TextBox3
		'
		Me.TextBox3.BackColor = System.Drawing.SystemColors.MenuBar
		Me.TextBox3.Location = New System.Drawing.Point(249, 3)
		Me.TextBox3.Name = "TextBox3"
		Me.TextBox3.ReadOnly = True
		Me.TextBox3.Size = New System.Drawing.Size(117, 22)
		Me.TextBox3.TabIndex = 2
		Me.TextBox3.TabStop = False
		Me.TextBox3.Text = "Age"
		Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'TextBox2
		'
		Me.TextBox2.BackColor = System.Drawing.SystemColors.MenuBar
		Me.TextBox2.Location = New System.Drawing.Point(127, 3)
		Me.TextBox2.Name = "TextBox2"
		Me.TextBox2.ReadOnly = True
		Me.TextBox2.Size = New System.Drawing.Size(117, 22)
		Me.TextBox2.TabIndex = 1111111
		Me.TextBox2.TabStop = False
		Me.TextBox2.Text = "Name"
		Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'TextBox1
		'
		Me.TextBox1.BackColor = System.Drawing.SystemColors.MenuBar
		Me.TextBox1.Location = New System.Drawing.Point(3, 3)
		Me.TextBox1.Name = "TextBox1"
		Me.TextBox1.ReadOnly = True
		Me.TextBox1.Size = New System.Drawing.Size(117, 22)
		Me.TextBox1.TabIndex = 111111
		Me.TextBox1.TabStop = False
		Me.TextBox1.Text = "Serial No."
		Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'Total
		'
		Me.Total.BackColor = System.Drawing.SystemColors.Info
		Me.Total.Location = New System.Drawing.Point(131, 381)
		Me.Total.Name = "Total"
		Me.Total.Size = New System.Drawing.Size(170, 20)
		Me.Total.TabIndex = 10
		Me.Total.TabStop = False
		Me.Total.Visible = False
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label5.Location = New System.Drawing.Point(22, 381)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(103, 24)
		Me.Label5.TabIndex = 9
		Me.Label5.Text = "Train No: "
		Me.Label5.Visible = False
		'
		'Button1
		'
		Me.Button1.BackColor = System.Drawing.SystemColors.Menu
		Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Button1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Button1.Location = New System.Drawing.Point(427, 371)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(94, 29)
		Me.Button1.TabIndex = 11
		Me.Button1.Text = "Submit"
		Me.Button1.UseVisualStyleBackColor = False
		'
		'Button2
		'
		Me.Button2.BackColor = System.Drawing.SystemColors.Menu
		Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Button2.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Button2.Location = New System.Drawing.Point(541, 371)
		Me.Button2.Name = "Button2"
		Me.Button2.Size = New System.Drawing.Size(131, 29)
		Me.Button2.TabIndex = 12
		Me.Button2.Text = "Refresh All"
		Me.Button2.UseVisualStyleBackColor = False
		'
		'Ticket_Booking
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.AppWorkspace
		Me.ClientSize = New System.Drawing.Size(861, 541)
		Me.Controls.Add(Me.Button2)
		Me.Controls.Add(Me.Button1)
		Me.Controls.Add(Me.Total)
		Me.Controls.Add(Me.Label5)
		Me.Controls.Add(Me.Panel1)
		Me.Controls.Add(Me.Fare)
		Me.Controls.Add(Me.Class_List)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Pass_Name)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.Train_No)
		Me.Controls.Add(Me.Label1)
		Me.KeyPreview = True
		Me.Name = "Ticket_Booking"
		Me.Text = "Train Ticket"
		Me.Panel1.ResumeLayout(False)
		Me.Panel1.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents Label1 As System.Windows.Forms.Label

	Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

	End Sub
	Friend WithEvents Train_No As System.Windows.Forms.TextBox
	Friend WithEvents Pass_Name As System.Windows.Forms.TextBox
	Friend WithEvents Label3 As System.Windows.Forms.Label
	Friend WithEvents Label2 As System.Windows.Forms.Label
	Friend WithEvents Label4 As System.Windows.Forms.Label
	Friend WithEvents Class_List As System.Windows.Forms.ListBox
	Friend WithEvents Fare As System.Windows.Forms.TextBox
	Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

	End Sub


	Private Sub Class_List_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Class_List.SelectedIndexChanged
		Select Case Class_List.SelectedIndex
			Case 0
				Fare.Text = 285
			Case 1
				Fare.Text = 1090
			Case 2
				Fare.Text = 785
			Case 3
				Fare.Text = 170
		End Select

	End Sub
	Friend WithEvents Panel1 As System.Windows.Forms.Panel
	Friend WithEvents gn6 As System.Windows.Forms.TextBox
	Friend WithEvents ag6 As System.Windows.Forms.TextBox
	Friend WithEvents psn6 As System.Windows.Forms.TextBox
	Friend WithEvents TextBox28 As System.Windows.Forms.TextBox
	Friend WithEvents gn5 As System.Windows.Forms.TextBox
	Friend WithEvents ag5 As System.Windows.Forms.TextBox
	Friend WithEvents psn5 As System.Windows.Forms.TextBox
	Friend WithEvents TextBox24 As System.Windows.Forms.TextBox
	Friend WithEvents gn4 As System.Windows.Forms.TextBox
	Friend WithEvents ag4 As System.Windows.Forms.TextBox
	Friend WithEvents psn4 As System.Windows.Forms.TextBox
	Friend WithEvents TextBox20 As System.Windows.Forms.TextBox
	Friend WithEvents gn3 As System.Windows.Forms.TextBox
	Friend WithEvents ag3 As System.Windows.Forms.TextBox
	Friend WithEvents psn3 As System.Windows.Forms.TextBox
	Friend WithEvents TextBox16 As System.Windows.Forms.TextBox
	Friend WithEvents gn2 As System.Windows.Forms.TextBox
	Friend WithEvents ag2 As System.Windows.Forms.TextBox
	Friend WithEvents psn2 As System.Windows.Forms.TextBox
	Friend WithEvents TextBox12 As System.Windows.Forms.TextBox
	Friend WithEvents gn1 As System.Windows.Forms.TextBox
	Friend WithEvents ag1 As System.Windows.Forms.TextBox
	Friend WithEvents psn1 As System.Windows.Forms.TextBox
	Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
	Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
	Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
	Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
	Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
	Friend WithEvents Total As System.Windows.Forms.TextBox
	Friend WithEvents Label5 As System.Windows.Forms.Label

	Private Sub TextBox14_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ag3.TextChanged

	End Sub
	Friend WithEvents Button1 As System.Windows.Forms.Button
	Friend WithEvents Button2 As System.Windows.Forms.Button

	Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
		Label5.Visible = True
		Total.Visible = True
		Dim i As Integer
		i = 0
		If String.Compare(psn1.Text, "") And Val(ag1.Text) >= 5 Then
			i = i + 1
		End If
		If String.Compare(psn2.Text, "") And Val(ag2.Text) >= 5 Then
			i = i + 1
		End If
		If String.Compare(psn3.Text, "") And Val(ag3.Text) >= 5 Then
			i = i + 1
		End If
		If String.Compare(psn4.Text, "") And Val(ag4.Text) >= 5 Then
			i = i + 1
		End If
		If String.Compare(psn5.Text, "") And Val(ag5.Text) >= 5 Then
			i = i + 1
		End If
		If String.Compare(psn6.Text, "") And Val(ag6.Text) >= 5 Then
			i = i + 1
		End If

		Total.Text = i * Val(Fare.Text)
	End Sub

	Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
		Train_No.Text = ""
		Pass_Name.Text = ""
		Fare.Text = ""

		psn1.Text = ""
		psn2.Text = ""
		psn3.Text = ""
		psn4.Text = ""
		psn5.Text = ""
		psn6.Text = ""

		ag1.Text = ""
		ag2.Text = ""
		ag3.Text = ""
		ag4.Text = ""
		ag5.Text = ""
		ag6.Text = ""

		gn1.Text = ""
		gn2.Text = ""
		gn3.Text = ""
		gn4.Text = ""
		gn5.Text = ""
		gn6.Text = ""

		Total.Text = ""

		Label5.Visible = False
		Total.Visible = False

	End Sub
End Class
