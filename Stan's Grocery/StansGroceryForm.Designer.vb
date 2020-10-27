﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StansGroceryForm
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
        Me.components = New System.ComponentModel.Container()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.LeftGroupBox = New System.Windows.Forms.GroupBox()
        Me.DisplayLabel = New System.Windows.Forms.Label()
        Me.SearchButton = New System.Windows.Forms.Button()
        Me.SelectLabel = New System.Windows.Forms.Label()
        Me.LookUpLabel = New System.Windows.Forms.Label()
        Me.DisplayListBox = New System.Windows.Forms.ListBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.SearchTextBox = New System.Windows.Forms.TextBox()
        Me.TopMenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileTopMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpTopMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutTopMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.LeftGroupBox.SuspendLayout()
        Me.TopMenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'ExitButton
        '
        Me.ExitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ExitButton.Location = New System.Drawing.Point(493, 16)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(98, 20)
        Me.ExitButton.TabIndex = 17
        Me.ExitButton.Text = "&Exit"
        Me.ToolTip1.SetToolTip(Me.ExitButton, "Exit,if you can see this. Stop Hacking.")
        Me.ExitButton.UseVisualStyleBackColor = True
        Me.ExitButton.Visible = False
        '
        'LeftGroupBox
        '
        Me.LeftGroupBox.Controls.Add(Me.DisplayLabel)
        Me.LeftGroupBox.Location = New System.Drawing.Point(76, 88)
        Me.LeftGroupBox.Name = "LeftGroupBox"
        Me.LeftGroupBox.Size = New System.Drawing.Size(218, 224)
        Me.LeftGroupBox.TabIndex = 16
        Me.LeftGroupBox.TabStop = False
        '
        'DisplayLabel
        '
        Me.DisplayLabel.Location = New System.Drawing.Point(3, 16)
        Me.DisplayLabel.Name = "DisplayLabel"
        Me.DisplayLabel.Size = New System.Drawing.Size(209, 205)
        Me.DisplayLabel.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.DisplayLabel, "The item location will be displayed here")
        '
        'SearchButton
        '
        Me.SearchButton.Location = New System.Drawing.Point(493, 35)
        Me.SearchButton.Name = "SearchButton"
        Me.SearchButton.Size = New System.Drawing.Size(98, 20)
        Me.SearchButton.TabIndex = 11
        Me.SearchButton.Text = "&Search"
        Me.ToolTip1.SetToolTip(Me.SearchButton, "Click here to search for an item")
        Me.SearchButton.UseVisualStyleBackColor = True
        '
        'SelectLabel
        '
        Me.SelectLabel.AutoSize = True
        Me.SelectLabel.Location = New System.Drawing.Point(10, 61)
        Me.SelectLabel.Name = "SelectLabel"
        Me.SelectLabel.Size = New System.Drawing.Size(60, 13)
        Me.SelectLabel.TabIndex = 15
        Me.SelectLabel.Text = "Select Item"
        '
        'LookUpLabel
        '
        Me.LookUpLabel.AutoSize = True
        Me.LookUpLabel.Location = New System.Drawing.Point(-1, 35)
        Me.LookUpLabel.Name = "LookUpLabel"
        Me.LookUpLabel.Size = New System.Drawing.Size(71, 13)
        Me.LookUpLabel.TabIndex = 13
        Me.LookUpLabel.Text = "Look Up Item"
        '
        'DisplayListBox
        '
        Me.DisplayListBox.FormattingEnabled = True
        Me.DisplayListBox.Location = New System.Drawing.Point(300, 61)
        Me.DisplayListBox.Name = "DisplayListBox"
        Me.DisplayListBox.Size = New System.Drawing.Size(291, 251)
        Me.DisplayListBox.TabIndex = 14
        Me.ToolTip1.SetToolTip(Me.DisplayListBox, "Select an item here to see its location")
        '
        'ComboBox1
        '
        Me.ComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.ComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(76, 61)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(218, 21)
        Me.ComboBox1.TabIndex = 12
        Me.ToolTip1.SetToolTip(Me.ComboBox1, "Click an item from this drop down menu to see its location")
        '
        'SearchTextBox
        '
        Me.SearchTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.SearchTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllSystemSources
        Me.SearchTextBox.Location = New System.Drawing.Point(76, 35)
        Me.SearchTextBox.Name = "SearchTextBox"
        Me.SearchTextBox.Size = New System.Drawing.Size(411, 20)
        Me.SearchTextBox.TabIndex = 10
        Me.ToolTip1.SetToolTip(Me.SearchTextBox, "What do you want to search for? Type it here and click search to find it")
        '
        'TopMenuStrip
        '
        Me.TopMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileTopMenuItem, Me.HelpTopMenuItem})
        Me.TopMenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.TopMenuStrip.Name = "TopMenuStrip"
        Me.TopMenuStrip.Size = New System.Drawing.Size(603, 24)
        Me.TopMenuStrip.TabIndex = 9
        Me.TopMenuStrip.Text = "MenuStrip1"
        '
        'FileTopMenuItem
        '
        Me.FileTopMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SearchToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileTopMenuItem.Name = "FileTopMenuItem"
        Me.FileTopMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileTopMenuItem.Text = "&File"
        '
        'SearchToolStripMenuItem
        '
        Me.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem"
        Me.SearchToolStripMenuItem.Size = New System.Drawing.Size(109, 22)
        Me.SearchToolStripMenuItem.Text = "Search"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(109, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'HelpTopMenuItem
        '
        Me.HelpTopMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutTopMenuItem})
        Me.HelpTopMenuItem.Name = "HelpTopMenuItem"
        Me.HelpTopMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpTopMenuItem.Text = "&Help"
        '
        'AboutTopMenuItem
        '
        Me.AboutTopMenuItem.Name = "AboutTopMenuItem"
        Me.AboutTopMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AboutTopMenuItem.Text = "About"
        '
        'ToolTip1
        '
        Me.ToolTip1.AutoPopDelay = 5000
        Me.ToolTip1.InitialDelay = 200
        Me.ToolTip1.ReshowDelay = 100
        '
        'StansGroceryForm
        '
        Me.AcceptButton = Me.SearchButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.ExitButton
        Me.ClientSize = New System.Drawing.Size(603, 317)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.LeftGroupBox)
        Me.Controls.Add(Me.SearchButton)
        Me.Controls.Add(Me.SelectLabel)
        Me.Controls.Add(Me.LookUpLabel)
        Me.Controls.Add(Me.DisplayListBox)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.SearchTextBox)
        Me.Controls.Add(Me.TopMenuStrip)
        Me.Name = "StansGroceryForm"
        Me.Text = "Stan's Grocery"
        Me.ToolTip1.SetToolTip(Me, "Welcome to Stan's Grocery")
        Me.LeftGroupBox.ResumeLayout(False)
        Me.TopMenuStrip.ResumeLayout(False)
        Me.TopMenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ExitButton As Button
    Friend WithEvents LeftGroupBox As GroupBox
    Friend WithEvents DisplayLabel As Label
    Friend WithEvents SearchButton As Button
    Friend WithEvents SelectLabel As Label
    Friend WithEvents LookUpLabel As Label
    Friend WithEvents DisplayListBox As ListBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents SearchTextBox As TextBox
    Friend WithEvents TopMenuStrip As MenuStrip
    Friend WithEvents FileTopMenuItem As ToolStripMenuItem
    Friend WithEvents SearchToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpTopMenuItem As ToolStripMenuItem
    Friend WithEvents AboutTopMenuItem As ToolStripMenuItem
    Friend WithEvents ToolTip1 As ToolTip
End Class
