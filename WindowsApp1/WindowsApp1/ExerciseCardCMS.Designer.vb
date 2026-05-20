<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ExerciseCardCMS
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblDivider = New System.Windows.Forms.Label()
        Me.btnRemove = New Guna.UI2.WinForms.Guna2Button()
        Me.lblMuscle = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.flpSets = New System.Windows.Forms.FlowLayoutPanel()
        Me.pnlFooter = New System.Windows.Forms.Panel()
        Me.btnAddSet = New Guna.UI2.WinForms.Guna2Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.pnlHeader.SuspendLayout()
        Me.pnlFooter.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSize = True
        Me.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.pnlHeader, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.flpSets, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.pnlFooter, 0, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 74.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(450, 124)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'pnlHeader
        '
        Me.pnlHeader.Controls.Add(Me.Label4)
        Me.pnlHeader.Controls.Add(Me.Label3)
        Me.pnlHeader.Controls.Add(Me.Label2)
        Me.pnlHeader.Controls.Add(Me.Label1)
        Me.pnlHeader.Controls.Add(Me.lblDivider)
        Me.pnlHeader.Controls.Add(Me.btnRemove)
        Me.pnlHeader.Controls.Add(Me.lblMuscle)
        Me.pnlHeader.Controls.Add(Me.lblName)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Margin = New System.Windows.Forms.Padding(0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(450, 74)
        Me.pnlHeader.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(110, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(262, 53)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 15)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Done"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(110, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(180, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 15)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Reps"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(110, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(60, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 15)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Weight (kg)"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(110, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(14, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(23, 15)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Set"
        '
        'lblDivider
        '
        Me.lblDivider.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDivider.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.lblDivider.Location = New System.Drawing.Point(0, 45)
        Me.lblDivider.Name = "lblDivider"
        Me.lblDivider.Size = New System.Drawing.Size(450, 1)
        Me.lblDivider.TabIndex = 3
        '
        'btnRemove
        '
        Me.btnRemove.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRemove.BorderRadius = 4
        Me.btnRemove.FillColor = System.Drawing.Color.Transparent
        Me.btnRemove.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnRemove.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnRemove.Location = New System.Drawing.Point(408, 9)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(30, 28)
        Me.btnRemove.TabIndex = 2
        Me.btnRemove.Text = "✕"
        '
        'lblMuscle
        '
        Me.lblMuscle.AutoSize = True
        Me.lblMuscle.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblMuscle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.lblMuscle.Location = New System.Drawing.Point(120, 15)
        Me.lblMuscle.Name = "lblMuscle"
        Me.lblMuscle.Size = New System.Drawing.Size(46, 15)
        Me.lblMuscle.TabIndex = 1
        Me.lblMuscle.Text = "Muscle"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Bold)
        Me.lblName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.lblName.Location = New System.Drawing.Point(14, 13)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(107, 19)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Exercise Name"
        '
        'flpSets
        '
        Me.flpSets.AutoSize = True
        Me.flpSets.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.flpSets.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flpSets.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.flpSets.Location = New System.Drawing.Point(0, 74)
        Me.flpSets.Margin = New System.Windows.Forms.Padding(0)
        Me.flpSets.Name = "flpSets"
        Me.flpSets.Size = New System.Drawing.Size(450, 1)
        Me.flpSets.TabIndex = 1
        Me.flpSets.WrapContents = False
        '
        'pnlFooter
        '
        Me.pnlFooter.Controls.Add(Me.btnAddSet)
        Me.pnlFooter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlFooter.Location = New System.Drawing.Point(0, 74)
        Me.pnlFooter.Margin = New System.Windows.Forms.Padding(0)
        Me.pnlFooter.Name = "pnlFooter"
        Me.pnlFooter.Size = New System.Drawing.Size(450, 50)
        Me.pnlFooter.TabIndex = 2
        '
        'btnAddSet
        '
        Me.btnAddSet.BorderRadius = 5
        Me.btnAddSet.FillColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnAddSet.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnAddSet.ForeColor = System.Drawing.Color.White
        Me.btnAddSet.Location = New System.Drawing.Point(14, 8)
        Me.btnAddSet.Name = "btnAddSet"
        Me.btnAddSet.Size = New System.Drawing.Size(110, 32)
        Me.btnAddSet.TabIndex = 0
        Me.btnAddSet.Text = "+ Add Set"
        '
        'ExerciseCardCMS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "ExerciseCardCMS"
        Me.Size = New System.Drawing.Size(450, 124)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.pnlFooter.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TableLayoutPanel1 As Windows.Forms.TableLayoutPanel
    Friend WithEvents pnlHeader As Windows.Forms.Panel
    Friend WithEvents Label4 As Windows.Forms.Label
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents lblDivider As Windows.Forms.Label
    Friend WithEvents btnRemove As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblMuscle As Windows.Forms.Label
    Friend WithEvents lblName As Windows.Forms.Label
    Friend WithEvents flpSets As Windows.Forms.FlowLayoutPanel
    Friend WithEvents pnlFooter As Windows.Forms.Panel
    Friend WithEvents btnAddSet As Guna.UI2.WinForms.Guna2Button

End Class