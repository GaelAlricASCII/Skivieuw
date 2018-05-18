<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.BtnGMAO = New System.Windows.Forms.Button()
        Me.BtnUtilisateur = New System.Windows.Forms.Button()
        Me.BtnReport = New System.Windows.Forms.Button()
        Me.BtnGeo = New System.Windows.Forms.Button()
        Me.BtnPida = New System.Windows.Forms.Button()
        Me.BtnMessagerie = New System.Windows.Forms.Button()
        Me.BtnPiste = New System.Windows.Forms.Button()
        Me.BtnAcc = New System.Windows.Forms.Button()
        Me.BtnSupervision = New System.Windows.Forms.Button()
        Me.BtnRm = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStripContainer1
        '
        Me.ToolStripContainer1.BottomToolStripPanelVisible = False
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.SplitContainer1)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.StatusStrip1)
        Me.ToolStripContainer1.ContentPanel.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(536, 524)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.LeftToolStripPanelVisible = False
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer1.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.RightToolStripPanelVisible = False
        Me.ToolStripContainer1.Size = New System.Drawing.Size(536, 524)
        Me.ToolStripContainer1.TabIndex = 0
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        Me.ToolStripContainer1.TopToolStripPanelVisible = False
        '
        'BtnGMAO
        '
        Me.BtnGMAO.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnGMAO.BackgroundImage = CType(resources.GetObject("BtnGMAO.BackgroundImage"), System.Drawing.Image)
        Me.BtnGMAO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnGMAO.Enabled = False
        Me.BtnGMAO.Location = New System.Drawing.Point(279, 156)
        Me.BtnGMAO.Name = "BtnGMAO"
        Me.BtnGMAO.Size = New System.Drawing.Size(82, 71)
        Me.BtnGMAO.TabIndex = 11
        Me.BtnGMAO.UseVisualStyleBackColor = True
        '
        'BtnUtilisateur
        '
        Me.BtnUtilisateur.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnUtilisateur.BackgroundImage = CType(resources.GetObject("BtnUtilisateur.BackgroundImage"), System.Drawing.Image)
        Me.BtnUtilisateur.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnUtilisateur.Enabled = False
        Me.BtnUtilisateur.Location = New System.Drawing.Point(141, 156)
        Me.BtnUtilisateur.Name = "BtnUtilisateur"
        Me.BtnUtilisateur.Size = New System.Drawing.Size(82, 71)
        Me.BtnUtilisateur.TabIndex = 10
        Me.BtnUtilisateur.UseVisualStyleBackColor = True
        '
        'BtnReport
        '
        Me.BtnReport.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnReport.BackgroundImage = CType(resources.GetObject("BtnReport.BackgroundImage"), System.Drawing.Image)
        Me.BtnReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnReport.Enabled = False
        Me.BtnReport.Location = New System.Drawing.Point(416, 80)
        Me.BtnReport.Name = "BtnReport"
        Me.BtnReport.Size = New System.Drawing.Size(82, 71)
        Me.BtnReport.TabIndex = 9
        Me.BtnReport.UseVisualStyleBackColor = True
        '
        'BtnGeo
        '
        Me.BtnGeo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnGeo.BackgroundImage = CType(resources.GetObject("BtnGeo.BackgroundImage"), System.Drawing.Image)
        Me.BtnGeo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnGeo.Enabled = False
        Me.BtnGeo.Location = New System.Drawing.Point(279, 79)
        Me.BtnGeo.Name = "BtnGeo"
        Me.BtnGeo.Size = New System.Drawing.Size(82, 71)
        Me.BtnGeo.TabIndex = 8
        Me.BtnGeo.UseVisualStyleBackColor = True
        '
        'BtnPida
        '
        Me.BtnPida.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnPida.BackgroundImage = CType(resources.GetObject("BtnPida.BackgroundImage"), System.Drawing.Image)
        Me.BtnPida.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnPida.Enabled = False
        Me.BtnPida.Location = New System.Drawing.Point(141, 79)
        Me.BtnPida.Name = "BtnPida"
        Me.BtnPida.Size = New System.Drawing.Size(82, 71)
        Me.BtnPida.TabIndex = 7
        Me.BtnPida.UseVisualStyleBackColor = True
        '
        'BtnMessagerie
        '
        Me.BtnMessagerie.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnMessagerie.BackgroundImage = CType(resources.GetObject("BtnMessagerie.BackgroundImage"), System.Drawing.Image)
        Me.BtnMessagerie.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnMessagerie.Enabled = False
        Me.BtnMessagerie.Location = New System.Drawing.Point(12, 80)
        Me.BtnMessagerie.Name = "BtnMessagerie"
        Me.BtnMessagerie.Size = New System.Drawing.Size(82, 71)
        Me.BtnMessagerie.TabIndex = 6
        Me.BtnMessagerie.UseVisualStyleBackColor = True
        '
        'BtnPiste
        '
        Me.BtnPiste.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnPiste.BackgroundImage = CType(resources.GetObject("BtnPiste.BackgroundImage"), System.Drawing.Image)
        Me.BtnPiste.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnPiste.Enabled = False
        Me.BtnPiste.Location = New System.Drawing.Point(279, 2)
        Me.BtnPiste.Name = "BtnPiste"
        Me.BtnPiste.Size = New System.Drawing.Size(82, 71)
        Me.BtnPiste.TabIndex = 5
        Me.BtnPiste.UseVisualStyleBackColor = True
        '
        'BtnAcc
        '
        Me.BtnAcc.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnAcc.BackgroundImage = CType(resources.GetObject("BtnAcc.BackgroundImage"), System.Drawing.Image)
        Me.BtnAcc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnAcc.Enabled = False
        Me.BtnAcc.Location = New System.Drawing.Point(416, 2)
        Me.BtnAcc.Name = "BtnAcc"
        Me.BtnAcc.Size = New System.Drawing.Size(82, 71)
        Me.BtnAcc.TabIndex = 4
        Me.BtnAcc.UseVisualStyleBackColor = True
        '
        'BtnSupervision
        '
        Me.BtnSupervision.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnSupervision.BackgroundImage = CType(resources.GetObject("BtnSupervision.BackgroundImage"), System.Drawing.Image)
        Me.BtnSupervision.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnSupervision.Location = New System.Drawing.Point(141, 2)
        Me.BtnSupervision.Name = "BtnSupervision"
        Me.BtnSupervision.Size = New System.Drawing.Size(82, 71)
        Me.BtnSupervision.TabIndex = 3
        Me.BtnSupervision.UseVisualStyleBackColor = True
        '
        'BtnRm
        '
        Me.BtnRm.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnRm.BackColor = System.Drawing.Color.Transparent
        Me.BtnRm.BackgroundImage = CType(resources.GetObject("BtnRm.BackgroundImage"), System.Drawing.Image)
        Me.BtnRm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnRm.Location = New System.Drawing.Point(12, 2)
        Me.BtnRm.Name = "BtnRm"
        Me.BtnRm.Size = New System.Drawing.Size(82, 71)
        Me.BtnRm.TabIndex = 2
        Me.BtnRm.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.SKI_VIEW.My.Resources.Resources._02_skiview_logo1
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(536, 266)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "accueil.png")
        Me.ImageList1.Images.SetKeyName(1, "construction-worker-hat-clipart-free-vector-hard-hat-clip-art_106367_Hard_Hat_cli" &
        "p_art_hight.png")
        Me.ImageList1.Images.SetKeyName(2, "location-icon.png")
        Me.ImageList1.Images.SetKeyName(3, "user-group-icon.png")
        Me.ImageList1.Images.SetKeyName(4, "Remontees.png")
        Me.ImageList1.Images.SetKeyName(5, "reports_256.png")
        Me.ImageList1.Images.SetKeyName(6, "avalanche-512.png")
        Me.ImageList1.Images.SetKeyName(7, "remontee-mecanique.png")
        Me.ImageList1.Images.SetKeyName(8, "avalanche-512.png")
        Me.ImageList1.Images.SetKeyName(9, "ski_318-9893.png.jpg")
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 502)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(536, 22)
        Me.StatusStrip1.TabIndex = 12
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(121, 17)
        Me.ToolStripStatusLabel1.Text = "ToolStripStatusLabel1"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.PictureBox1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.BtnAcc)
        Me.SplitContainer1.Panel2.Controls.Add(Me.BtnPiste)
        Me.SplitContainer1.Panel2.Controls.Add(Me.BtnUtilisateur)
        Me.SplitContainer1.Panel2.Controls.Add(Me.BtnGMAO)
        Me.SplitContainer1.Panel2.Controls.Add(Me.BtnSupervision)
        Me.SplitContainer1.Panel2.Controls.Add(Me.BtnRm)
        Me.SplitContainer1.Panel2.Controls.Add(Me.BtnMessagerie)
        Me.SplitContainer1.Panel2.Controls.Add(Me.BtnPida)
        Me.SplitContainer1.Panel2.Controls.Add(Me.BtnGeo)
        Me.SplitContainer1.Panel2.Controls.Add(Me.BtnReport)
        Me.SplitContainer1.Size = New System.Drawing.Size(536, 502)
        Me.SplitContainer1.SplitterDistance = 266
        Me.SplitContainer1.TabIndex = 13
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(3.0!, 6.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(536, 524)
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.Font = New System.Drawing.Font("Segoe UI", 3.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(130, 111)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SKI VIEW"
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.ContentPanel.PerformLayout()
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ToolStripContainer1 As ToolStripContainer
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BtnGMAO As Button
    Friend WithEvents BtnUtilisateur As Button
    Friend WithEvents BtnReport As Button
    Friend WithEvents BtnGeo As Button
    Friend WithEvents BtnPida As Button
    Friend WithEvents BtnMessagerie As Button
    Friend WithEvents BtnPiste As Button
    Friend WithEvents BtnAcc As Button
    Friend WithEvents BtnSupervision As Button
    Friend WithEvents BtnRm As Button
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents SplitContainer1 As SplitContainer
End Class
