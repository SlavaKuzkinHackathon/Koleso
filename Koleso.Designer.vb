<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Koleso
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
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

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Koleso))
        Me.tableLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.btnOpenFile = New System.Windows.Forms.Button()
        Me.ibOriginal = New System.Windows.Forms.PictureBox()
        Me.cbShowSteps = New System.Windows.Forms.CheckBox()
        Me.txtInfo = New System.Windows.Forms.TextBox()
        Me.lblChosenFile = New System.Windows.Forms.Label()
        Me.ofdOpenFile = New System.Windows.Forms.OpenFileDialog()
        Me.tableLayoutPanel.SuspendLayout()
        CType(Me.ibOriginal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tableLayoutPanel
        '
        Me.tableLayoutPanel.ColumnCount = 3
        Me.tableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.14256!))
        Me.tableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.85744!))
        Me.tableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tableLayoutPanel.Controls.Add(Me.btnOpenFile, 0, 0)
        Me.tableLayoutPanel.Controls.Add(Me.ibOriginal, 0, 1)
        Me.tableLayoutPanel.Controls.Add(Me.cbShowSteps, 2, 0)
        Me.tableLayoutPanel.Controls.Add(Me.txtInfo, 0, 2)
        Me.tableLayoutPanel.Controls.Add(Me.lblChosenFile, 1, 0)
        Me.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tableLayoutPanel.Location = New System.Drawing.Point(0, 0)
        Me.tableLayoutPanel.Name = "tableLayoutPanel"
        Me.tableLayoutPanel.RowCount = 3
        Me.tableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70.0!))
        Me.tableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.tableLayoutPanel.Size = New System.Drawing.Size(954, 500)
        Me.tableLayoutPanel.TabIndex = 0
        '
        'btnOpenFile
        '
        Me.btnOpenFile.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOpenFile.AutoSize = True
        Me.btnOpenFile.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnOpenFile.Location = New System.Drawing.Point(3, 3)
        Me.btnOpenFile.Name = "btnOpenFile"
        Me.btnOpenFile.Size = New System.Drawing.Size(126, 34)
        Me.btnOpenFile.TabIndex = 0
        Me.btnOpenFile.Text = "Открыть файл"
        Me.btnOpenFile.UseVisualStyleBackColor = True
        '
        'ibOriginal
        '
        Me.ibOriginal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tableLayoutPanel.SetColumnSpan(Me.ibOriginal, 3)
        Me.ibOriginal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ibOriginal.Enabled = False
        Me.ibOriginal.Location = New System.Drawing.Point(3, 43)
        Me.ibOriginal.Name = "ibOriginal"
        Me.ibOriginal.Size = New System.Drawing.Size(948, 316)
        Me.ibOriginal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ibOriginal.TabIndex = 2
        Me.ibOriginal.TabStop = False
        '
        'cbShowSteps
        '
        Me.cbShowSteps.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbShowSteps.AutoSize = True
        Me.cbShowSteps.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.cbShowSteps.Location = New System.Drawing.Point(820, 9)
        Me.cbShowSteps.Name = "cbShowSteps"
        Me.cbShowSteps.Size = New System.Drawing.Size(131, 22)
        Me.cbShowSteps.TabIndex = 3
        Me.cbShowSteps.Text = "показать шаги"
        Me.cbShowSteps.UseVisualStyleBackColor = True
        '
        'txtInfo
        '
        Me.tableLayoutPanel.SetColumnSpan(Me.txtInfo, 3)
        Me.txtInfo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtInfo.Location = New System.Drawing.Point(3, 365)
        Me.txtInfo.Multiline = True
        Me.txtInfo.Name = "txtInfo"
        Me.txtInfo.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtInfo.Size = New System.Drawing.Size(948, 132)
        Me.txtInfo.TabIndex = 4
        Me.txtInfo.WordWrap = False
        '
        'lblChosenFile
        '
        Me.lblChosenFile.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblChosenFile.AutoSize = True
        Me.lblChosenFile.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblChosenFile.Location = New System.Drawing.Point(135, 11)
        Me.lblChosenFile.Name = "lblChosenFile"
        Me.lblChosenFile.Size = New System.Drawing.Size(679, 18)
        Me.lblChosenFile.TabIndex = 1
        Me.lblChosenFile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ofdOpenFile
        '
        Me.ofdOpenFile.FileName = "OpenFileDialog1"
        '
        'Koleso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(954, 500)
        Me.Controls.Add(Me.tableLayoutPanel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Koleso"
        Me.Text = "Koleso"
        Me.tableLayoutPanel.ResumeLayout(False)
        Me.tableLayoutPanel.PerformLayout()
        CType(Me.ibOriginal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tableLayoutPanel As TableLayoutPanel
    Friend WithEvents btnOpenFile As Button
    Friend WithEvents lblChosenFile As Label
    Friend WithEvents ibOriginal As PictureBox
    Friend WithEvents cbShowSteps As CheckBox
    Friend WithEvents txtInfo As TextBox
    Friend WithEvents ofdOpenFile As OpenFileDialog
End Class
