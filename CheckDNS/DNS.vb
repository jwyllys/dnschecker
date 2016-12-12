'Created by Justin Wyllys
'version 1.0.0
'12/7/2011
'Last updated 2013-08-15 //added msoid record

Imports System.IO
Module CheckDNSrecords
    ' Module holds global consants/variables; must be declared as public
    Public strDomain As String = ""  'storage for user entered domain
    Public strDNServer As String = "8.8.8.8"  'DNS server for NSLookup queries
    Public strSRVsip As String = "" 'will hold dns query for _sip._tls.domain.com
    Public strSRVfed As String = "" 'will hold dns query for _sipfederationtls._tcp.domain.com
    Public strCNAMEsip As String = "" 'will hold dns query for sip.domain.com
    Public strCNAMElync As String = "" 'will hold dns query for lyncdiscover.domain.com
    Public strCNAMEauto As String = "" 'will hold dns query for autodiscover.domain.com
    Public strNameServers As String = "" 'will hold dns query for name servers for domain.com
    Public strMX As String = "" 'will hold dns query for MX records for domain.com
    Public strTXT As String = "" 'will hold dns query for TXT records for domain.com
    Public strA As String = "" 'will hold dns query for A records for domain.com
    Public strMsoid As String = "" 'will hold dns query for Cname record msoid.domain.com target clientconfig.microsoftonline-p.net

End Module

Public Class DNS
    Dim strFileName As String = "" 'filename to be entered by user
    Dim outputFile As StreamWriter 'defining the file to be written

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cboDNSServer.SelectedItem = "8.8.8.8" 'sets google as default dns server
        txtDomain.Focus() 'gives focus to user input box
        'add streamwriter or outputFile ???

        'Me.MaximizeBox = False 'don't allow users to maximize - temp fix until maximize issue is resolved

    End Sub

    Private Sub btnCheckDNS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCheckDNS.Click

        Dim DNS As New Process

        'verify a domain name is entered
        If txtDomain.Text = "" Then
            MsgBox("Please enter a domain name")
            Return
        End If

        'put text from domain entry box into string 
        Try
            strDomain = Trim(txtDomain.Text)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        'store dns server in string
        Try
            If cboDNSServer.SelectedItem = "Use my internal DNS server" Then
                strDNServer = ""
            ElseIf cboDNSServer.SelectedItem = "Other (specify below)" Then
                strDNServer = Trim(txtOtherDNS.Text)
            Else
                strDNServer = cboDNSServer.SelectedItem.ToString
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        'store user intput into dns strings for running through nslookup
        strSRVsip = "-type=SRV" + " " + "_sip._tls." + strDomain + " " + strDNServer
        strSRVfed = "-type=SRV" + " " + "_sipfederationtls._tcp." + strDomain + " " + strDNServer
        strCNAMEsip = "-type=CNAME" + " " + "sip." + strDomain + " " + strDNServer
        strCNAMElync = "-type=CNAME" + " " + "lyncdiscover." + strDomain + " " + strDNServer
        strCNAMEauto = "-type=CNAME" + " " + "autodiscover." + strDomain + " " + strDNServer
        strMsoid = "-type=CNAME" + " " + "msoid." + strDomain + " " + strDNServer
        strNameServers = "-type=NS" + " " + strDomain + " " + strDNServer
        strMX = "-type=MX" + " " + strDomain + " " + strDNServer
        strTXT = "-type=TXT" + " " + strDomain + " " + strDNServer
        strA = "-type=A" + " " + strDomain + " " + strDNServer


        txtResults.AppendText(vbNewLine)
        txtResults.AppendText("==========================================================") 'makes the text output fancy
        txtResults.AppendText(vbNewLine)
        txtResults.AppendText("DNS Records for: " + strDomain + vbNewLine + "Using DNS Server: " + strDNServer) 'makes the text output fancy
        txtResults.AppendText(vbNewLine)
        txtResults.AppendText("==========================================================") 'makes the text output fancy
        txtResults.AppendText(vbNewLine)
        txtResults.AppendText(vbNewLine)
        txtResults.AppendText("SRV SIP record for " + strDomain + ":") 'makes the text output fancy
        txtResults.AppendText(vbNewLine)

        'strSRVsip
        'write nslookup info to buffer
        With DNS.StartInfo
            .FileName = "nslookup.exe"
            .Arguments = strSRVsip
            .CreateNoWindow = True
            .RedirectStandardOutput = True
            .RedirectStandardError = True
            .UseShellExecute = False
        End With
        DNS.Start() 'start nslookup and run above commands
        If DNS.WaitForExit(9999) Then
            'Read Output
            'MessageBox.Show(DNS.StandardOutput.ReadToEnd)
            txtResults.AppendText(DNS.StandardOutput.ReadToEnd)
        Else
            'Failed
            MessageBox.Show("SRV SIP Failed: Timeout")
        End If


        txtResults.AppendText("---------------------------------") 'makes the text output fancy
        txtResults.AppendText(vbNewLine)
        txtResults.AppendText("SRV FED record for " + strDomain + ":") 'makes the text output fancy
        txtResults.AppendText(vbNewLine)

        'strSRVfed
        'write nslookup info to buffer
        With DNS.StartInfo
            .FileName = "nslookup.exe"
            .Arguments = strSRVfed
            .CreateNoWindow = True
            .RedirectStandardOutput = True
            .RedirectStandardError = True
            .UseShellExecute = False
        End With
        DNS.Start() 'start nslookup and run above commands
        If DNS.WaitForExit(9999) Then
            'Read Output
            txtResults.AppendText(DNS.StandardOutput.ReadToEnd)
        Else
            'Failed
            MessageBox.Show("SRV FED Failed: Timeout")
        End If

        txtResults.AppendText("---------------------------------") 'makes the text output fancy
        txtResults.AppendText(vbNewLine)
        txtResults.AppendText("CNAME SIP record for " + strDomain + ":") 'makes the text output fancy
        txtResults.AppendText(vbNewLine)

        'strCNAMEsip
        'write nslookup info to buffer
        With DNS.StartInfo
            .FileName = "nslookup.exe"
            .Arguments = strCNAMEsip
            .CreateNoWindow = True
            .RedirectStandardOutput = True
            .RedirectStandardError = True
            .UseShellExecute = False
        End With
        DNS.Start() 'start nslookup and run above commands
        If DNS.WaitForExit(9999) Then
            'Read Output
            txtResults.AppendText(DNS.StandardOutput.ReadToEnd)
        Else
            'Failed
            MessageBox.Show("CNAME SIP Failed: Timeout")
        End If

        txtResults.AppendText("---------------------------------") 'makes the text output fancy
        txtResults.AppendText(vbNewLine)
        txtResults.AppendText("CNAME LyncDiscover record for " + strDomain + ":") 'makes the text output fancy
        txtResults.AppendText(vbNewLine)

        'strCNAMElync
        'write nslookup info to buffer
        With DNS.StartInfo
            .FileName = "nslookup.exe"
            .Arguments = strCNAMElync
            .CreateNoWindow = True
            .RedirectStandardOutput = True
            .RedirectStandardError = True
            .UseShellExecute = False
        End With
        DNS.Start() 'start nslookup and run above commands
        If DNS.WaitForExit(9999) Then
            'Read Output
            txtResults.AppendText(DNS.StandardOutput.ReadToEnd)
        Else
            'Failed
            MessageBox.Show("Lyncdiscover Failed: Timeout")
        End If

        txtResults.AppendText("---------------------------------") 'makes the text output fancy
        txtResults.AppendText(vbNewLine)
        txtResults.AppendText("CNAME MsOID for " + strDomain + ":") 'makes the text output fancy
        txtResults.AppendText(vbNewLine)

        'strMsoid
        'write nslookup info to buffer
        With DNS.StartInfo
            .FileName = "nslookup.exe"
            .Arguments = strMsoid
            .CreateNoWindow = True
            .RedirectStandardOutput = True
            .RedirectStandardError = True
            .UseShellExecute = False
        End With
        DNS.Start() 'start nslookup and run above commands
        If DNS.WaitForExit(9999) Then
            'Read Output
            'MessageBox.Show(DNS.StandardOutput.ReadToEnd)
            txtResults.AppendText(DNS.StandardOutput.ReadToEnd)
        Else
            'Failed
            MessageBox.Show("CNAME MsOID Failed: Timeout")
        End If


        txtResults.AppendText("---------------------------------") 'makes the text output fancy
        txtResults.AppendText(vbNewLine)
        txtResults.AppendText("Exchange Autodiscover record for " + strDomain + ":") 'makes the text output fancy
        txtResults.AppendText(vbNewLine)

        'strCNAMEauto
        'write nslookup info to buffer
        With DNS.StartInfo
            .FileName = "nslookup.exe"
            .Arguments = strCNAMEauto
            .CreateNoWindow = True
            .RedirectStandardOutput = True
            .RedirectStandardError = True
            .UseShellExecute = False
        End With
        DNS.Start() 'start nslookup and run above commands
        If DNS.WaitForExit(9999) Then
            'Read Output
            txtResults.AppendText(DNS.StandardOutput.ReadToEnd)
        Else
            'Failed
            MessageBox.Show("Autodiscover Failed: Timeout")
        End If

        txtResults.AppendText("---------------------------------") 'makes the text output fancy
        txtResults.AppendText(vbNewLine)
        txtResults.AppendText("Name server records for " + strDomain + ":") 'makes the text output fancy
        txtResults.AppendText(vbNewLine)

        'strNameServers
        'write nslookup info to buffer
        With DNS.StartInfo
            .FileName = "nslookup.exe"
            .Arguments = strNameServers
            .CreateNoWindow = True
            .RedirectStandardOutput = True
            .RedirectStandardError = True
            .UseShellExecute = False
        End With
        DNS.Start() 'start nslookup and run above commands
        If DNS.WaitForExit(9999) Then
            'Read Output
            txtResults.AppendText(DNS.StandardOutput.ReadToEnd)
        Else
            'Failed
            MessageBox.Show("NS Failed: Timeout")
        End If

        

        'strMX
        If chkMX.Checked = True Then
            txtResults.AppendText("---------------------------------") 'makes the text output fancy
            txtResults.AppendText(vbNewLine)
            txtResults.AppendText("MX records for " + strDomain + ":") 'makes the text output fancy
            txtResults.AppendText(vbNewLine)

            'write nslookup info to buffer
            With DNS.StartInfo
                .FileName = "nslookup.exe"
                .Arguments = strMX
                .CreateNoWindow = True
                .RedirectStandardOutput = True
                .RedirectStandardError = True
                .UseShellExecute = False
            End With
            DNS.Start() 'start nslookup and run above commands
            If DNS.WaitForExit(9999) Then
                'Read Output
                txtResults.AppendText(DNS.StandardOutput.ReadToEnd)
            Else
                'Failed
                MessageBox.Show("MX Failed: Timeout")
            End If
        End If

        'strTXT
        If chkTXT.Checked = True Then
            txtResults.AppendText("---------------------------------") 'makes the text output fancy
            txtResults.AppendText(vbNewLine)
            txtResults.AppendText("TXT records for " + strDomain + ":") 'makes the text output fancy
            txtResults.AppendText(vbNewLine)

            'write nslookup info to buffer
            With DNS.StartInfo
                .FileName = "nslookup.exe"
                .Arguments = strTXT
                .CreateNoWindow = True
                .RedirectStandardOutput = True
                .RedirectStandardError = True
                .UseShellExecute = False
            End With
            DNS.Start() 'start nslookup and run above commands
            If DNS.WaitForExit(9999) Then
                'Read Output
                txtResults.AppendText(DNS.StandardOutput.ReadToEnd)
            Else
                'Failed
                MessageBox.Show("TXT Failed: Timeout")
            End If
        End If

        'strA
        If chkA.Checked = True Then
            txtResults.AppendText("---------------------------------") 'makes the text output fancy
            txtResults.AppendText(vbNewLine)
            txtResults.AppendText("A record for " + strDomain + ":") 'makes the text output fancy
            txtResults.AppendText(vbNewLine)

            'write nslookup info to buffer
            With DNS.StartInfo
                .FileName = "nslookup.exe"
                .Arguments = strA
                .CreateNoWindow = True
                .RedirectStandardOutput = True
                .RedirectStandardError = True
                .UseShellExecute = False
            End With
            DNS.Start() 'start nslookup and run above commands
            If DNS.WaitForExit(9999) Then
                'Read Output
                txtResults.AppendText(DNS.StandardOutput.ReadToEnd)
            Else
                'Failed
                MessageBox.Show("A record Failed: Timeout")
            End If
        End If

        txtResults.AppendText(vbNewLine)
        txtResults.AppendText("---------------End------------------") 'makes the text output fancy
        txtResults.AppendText(vbNewLine)

    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        strDomain = "" 'clear string storage
        txtDomain.Clear() 'clear domain text box
        txtOtherDNS.Clear() 'clear DNS server text box
        cboDNSServer.SelectedItem = "8.8.8.8" 'reset dns server selection
        txtResults.Clear() 'clears results
        txtDomain.Focus() 'give focus to domain text box
        chkA.Checked = False
        chkMX.Checked = False
        chkTXT.Checked = False
        lblSpecificDNS.Visible = False
        txtOtherDNS.Visible = False


    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close() 'exit

    End Sub

    Private Sub cboDNSServer_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDNSServer.SelectedIndexChanged

        'if user selects other, make other box available to enter customer DNS server IP address
        If cboDNSServer.SelectedItem = "Other (specify below)" Then
            lblSpecificDNS.Visible = True
            txtOtherDNS.Visible = True
        End If

        'if user reverts from other, remove lbl and txt box
        If Not cboDNSServer.SelectedItem = "Other (specify below)" Then
            lblSpecificDNS.Visible = False
            txtOtherDNS.Visible = False
        End If

    End Sub

    
    Private Sub btnCopy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCopy.Click
        'copy text from textbox
        Clipboard.SetDataObject(txtResults.Text)

    End Sub

 
    Private Sub TextBox1_KeyPress(ByVal sender As Object, _
    ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles _
    txtDomain.KeyPress

        If e.KeyChar = Convert.ToChar(Keys.Enter) Then

            btnCheckDNS.PerformClick()

            'This tells the system not to process
            'the key, as you've already taken care 
            'of it 
            e.Handled = True
        End If

    End Sub

    
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        'Save to text file

        SaveFileDialog1.ShowDialog()


        ''ask user for a file name and store it in strFileName
        'Try
        '    strFileName = InputBox("Please enter a file name:", "Employee Records")
        'Catch ex As Exception
        '    MessageBox.Show("Invalid file name, please try again.")
        'End Try

        ''open file
        'outputFile = File.AppendText(strFileName + ".txt")

        ''append the file
        'Try
        '    'write data to the file
        '    outputFile.WriteLine(txtResults.Text)
        'Catch ex As Exception
        '    MessageBox.Show("Error: Unable to write data to file")
        'End Try

        ''append line separator to file
        ''outputFile.WriteLine("----------------------")

        ''close file to write data from buffer to file
        'outputFile.Close()


    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click

        strDomain = "" 'clear string storage
        txtResults.Clear() 'clears results
        txtDomain.Focus() 'give focus to domain text box

    End Sub

    Private Sub SaveFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog1.FileOk

        Dim writer As New IO.StreamWriter(SaveFileDialog1.FileName) 'Creates the 'writer'
        writer.Write(txtResults.Text) 'this will write it
        writer.Close() 'closes it

    End Sub

End Class

