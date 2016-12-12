<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DNS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DNS))
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnCheckDNS = New System.Windows.Forms.Button()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.txtDomain = New System.Windows.Forms.TextBox()
        Me.lblEnterDomain = New System.Windows.Forms.Label()
        Me.lblChooseDNS = New System.Windows.Forms.Label()
        Me.txtOtherDNS = New System.Windows.Forms.TextBox()
        Me.cboDNSServer = New System.Windows.Forms.ComboBox()
        Me.lblSpecificDNS = New System.Windows.Forms.Label()
        Me.txtResults = New System.Windows.Forms.TextBox()
        Me.lblResults = New System.Windows.Forms.Label()
        Me.btnCopy = New System.Windows.Forms.Button()
        Me.lblOwner = New System.Windows.Forms.Label()
        Me.chkMX = New System.Windows.Forms.CheckBox()
        Me.chkTXT = New System.Windows.Forms.CheckBox()
        Me.chkA = New System.Windows.Forms.CheckBox()
        Me.lblTypes = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(19, 661)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(252, 43)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.Location = New System.Drawing.Point(19, 605)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(252, 43)
        Me.btnReset.TabIndex = 8
        Me.btnReset.Text = "&Reset Form"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnCheckDNS
        '
        Me.btnCheckDNS.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCheckDNS.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnCheckDNS.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheckDNS.Location = New System.Drawing.Point(19, 436)
        Me.btnCheckDNS.Name = "btnCheckDNS"
        Me.btnCheckDNS.Size = New System.Drawing.Size(252, 97)
        Me.btnCheckDNS.TabIndex = 6
        Me.btnCheckDNS.Tag = ""
        Me.btnCheckDNS.Text = "Check &DNS!"
        Me.btnCheckDNS.UseVisualStyleBackColor = True
        '
        'lblDescription
        '
        Me.lblDescription.Location = New System.Drawing.Point(22, 18)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(252, 30)
        Me.lblDescription.TabIndex = 20
        Me.lblDescription.Text = "This program will query a public DNS server for the specified domain. It will ret" & _
            "urn the following records: "
        '
        'txtDomain
        '
        Me.txtDomain.Location = New System.Drawing.Point(25, 222)
        Me.txtDomain.MaxLength = 255
        Me.txtDomain.Name = "txtDomain"
        Me.txtDomain.Size = New System.Drawing.Size(249, 20)
        Me.txtDomain.TabIndex = 0
        '
        'lblEnterDomain
        '
        Me.lblEnterDomain.AutoSize = True
        Me.lblEnterDomain.Location = New System.Drawing.Point(22, 206)
        Me.lblEnterDomain.Name = "lblEnterDomain"
        Me.lblEnterDomain.Size = New System.Drawing.Size(114, 13)
        Me.lblEnterDomain.TabIndex = 22
        Me.lblEnterDomain.Text = "Enter the domain here:"
        '
        'lblChooseDNS
        '
        Me.lblChooseDNS.AutoSize = True
        Me.lblChooseDNS.Location = New System.Drawing.Point(22, 254)
        Me.lblChooseDNS.Name = "lblChooseDNS"
        Me.lblChooseDNS.Size = New System.Drawing.Size(138, 13)
        Me.lblChooseDNS.TabIndex = 23
        Me.lblChooseDNS.Text = "Choose DNS Server to use:"
        '
        'txtOtherDNS
        '
        Me.txtOtherDNS.Location = New System.Drawing.Point(25, 320)
        Me.txtOtherDNS.MaxLength = 15
        Me.txtOtherDNS.Name = "txtOtherDNS"
        Me.txtOtherDNS.Size = New System.Drawing.Size(166, 20)
        Me.txtOtherDNS.TabIndex = 2
        Me.txtOtherDNS.Visible = False
        '
        'cboDNSServer
        '
        Me.cboDNSServer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDNSServer.FormattingEnabled = True
        Me.cboDNSServer.Items.AddRange(New Object() {"8.8.8.8", "4.2.2.2", "4.2.2.1", "208.67.220.220", "208.67.222.222", "Use my internal DNS server", "Other (specify below)"})
        Me.cboDNSServer.Location = New System.Drawing.Point(25, 271)
        Me.cboDNSServer.Name = "cboDNSServer"
        Me.cboDNSServer.Size = New System.Drawing.Size(166, 21)
        Me.cboDNSServer.TabIndex = 1
        '
        'lblSpecificDNS
        '
        Me.lblSpecificDNS.AutoSize = True
        Me.lblSpecificDNS.Location = New System.Drawing.Point(22, 304)
        Me.lblSpecificDNS.Name = "lblSpecificDNS"
        Me.lblSpecificDNS.Size = New System.Drawing.Size(118, 13)
        Me.lblSpecificDNS.TabIndex = 24
        Me.lblSpecificDNS.Text = "Custom DNS Server IP:"
        Me.lblSpecificDNS.Visible = False
        '
        'txtResults
        '
        Me.txtResults.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtResults.BackColor = System.Drawing.SystemColors.Window
        Me.txtResults.Location = New System.Drawing.Point(293, 29)
        Me.txtResults.Multiline = True
        Me.txtResults.Name = "txtResults"
        Me.txtResults.ReadOnly = True
        Me.txtResults.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtResults.Size = New System.Drawing.Size(570, 626)
        Me.txtResults.TabIndex = 10
        '
        'lblResults
        '
        Me.lblResults.AutoSize = True
        Me.lblResults.Location = New System.Drawing.Point(290, 13)
        Me.lblResults.Name = "lblResults"
        Me.lblResults.Size = New System.Drawing.Size(45, 13)
        Me.lblResults.TabIndex = 26
        Me.lblResults.Text = "Results:"
        '
        'btnCopy
        '
        Me.btnCopy.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnCopy.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCopy.Location = New System.Drawing.Point(322, 661)
        Me.btnCopy.Name = "btnCopy"
        Me.btnCopy.Size = New System.Drawing.Size(252, 43)
        Me.btnCopy.TabIndex = 7
        Me.btnCopy.Text = "&Copy Results"
        Me.btnCopy.UseVisualStyleBackColor = True
        '
        'lblOwner
        '
        Me.lblOwner.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblOwner.AutoSize = True
        Me.lblOwner.Location = New System.Drawing.Point(516, 9)
        Me.lblOwner.Name = "lblOwner"
        Me.lblOwner.Size = New System.Drawing.Size(348, 13)
        Me.lblOwner.TabIndex = 28
        Me.lblOwner.Text = "DNS Checker v1.2.2 - Copyright 2013 - Justin Wyllys (web@jrwpcs.com)"
        '
        'chkMX
        '
        Me.chkMX.AutoSize = True
        Me.chkMX.Location = New System.Drawing.Point(25, 353)
        Me.chkMX.Name = "chkMX"
        Me.chkMX.Size = New System.Drawing.Size(123, 17)
        Me.chkMX.TabIndex = 3
        Me.chkMX.Text = "Include MX Records"
        Me.chkMX.UseVisualStyleBackColor = True
        '
        'chkTXT
        '
        Me.chkTXT.AutoSize = True
        Me.chkTXT.Location = New System.Drawing.Point(25, 376)
        Me.chkTXT.Name = "chkTXT"
        Me.chkTXT.Size = New System.Drawing.Size(128, 17)
        Me.chkTXT.TabIndex = 4
        Me.chkTXT.Text = "Include TXT Records"
        Me.chkTXT.UseVisualStyleBackColor = True
        '
        'chkA
        '
        Me.chkA.AutoSize = True
        Me.chkA.Location = New System.Drawing.Point(25, 399)
        Me.chkA.Name = "chkA"
        Me.chkA.Size = New System.Drawing.Size(109, 17)
        Me.chkA.TabIndex = 5
        Me.chkA.Text = "Include A Record"
        Me.chkA.UseVisualStyleBackColor = True
        '
        'lblTypes
        '
        Me.lblTypes.Location = New System.Drawing.Point(22, 50)
        Me.lblTypes.Name = "lblTypes"
        Me.lblTypes.Size = New System.Drawing.Size(245, 140)
        Me.lblTypes.TabIndex = 32
        Me.lblTypes.Text = resources.GetString("lblTypes.Text")
        '
        'btnSave
        '
        Me.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(580, 661)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(252, 43)
        Me.btnSave.TabIndex = 33
        Me.btnSave.Text = "&Save Results"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(19, 549)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(252, 43)
        Me.btnClear.TabIndex = 34
        Me.btnClear.Text = "Clear Results"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.Filter = "Text Files|*.txt"
        Me.SaveFileDialog1.Title = "Save As"
        '
        'DNS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(872, 715)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.lblTypes)
        Me.Controls.Add(Me.chkA)
        Me.Controls.Add(Me.chkTXT)
        Me.Controls.Add(Me.chkMX)
        Me.Controls.Add(Me.lblOwner)
        Me.Controls.Add(Me.btnCopy)
        Me.Controls.Add(Me.lblResults)
        Me.Controls.Add(Me.txtResults)
        Me.Controls.Add(Me.lblSpecificDNS)
        Me.Controls.Add(Me.cboDNSServer)
        Me.Controls.Add(Me.txtOtherDNS)
        Me.Controls.Add(Me.lblChooseDNS)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnCheckDNS)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.txtDomain)
        Me.Controls.Add(Me.lblEnterDomain)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(888, 726)
        Me.Name = "DNS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DNS Checker v1.2.2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents btnCheckDNS As System.Windows.Forms.Button
    Friend WithEvents lblDescription As System.Windows.Forms.Label
    Friend WithEvents txtDomain As System.Windows.Forms.TextBox
    Friend WithEvents lblEnterDomain As System.Windows.Forms.Label
    Friend WithEvents lblChooseDNS As System.Windows.Forms.Label
    Friend WithEvents txtOtherDNS As System.Windows.Forms.TextBox
    Friend WithEvents cboDNSServer As System.Windows.Forms.ComboBox
    Friend WithEvents lblSpecificDNS As System.Windows.Forms.Label
    Friend WithEvents txtResults As System.Windows.Forms.TextBox
    Friend WithEvents lblResults As System.Windows.Forms.Label
    Friend WithEvents btnCopy As System.Windows.Forms.Button
    Friend WithEvents lblOwner As System.Windows.Forms.Label
    Friend WithEvents chkMX As System.Windows.Forms.CheckBox
    Friend WithEvents chkTXT As System.Windows.Forms.CheckBox
    Friend WithEvents chkA As System.Windows.Forms.CheckBox
    Friend WithEvents lblTypes As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
End Class
