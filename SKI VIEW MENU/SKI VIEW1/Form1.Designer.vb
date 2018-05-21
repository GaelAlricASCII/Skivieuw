<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MENU
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MENU))
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.CadreGeneral = New System.Windows.Forms.SplitContainer()
        Me.GrandLogo = New System.Windows.Forms.PictureBox()
        Me.Souscadre1 = New System.Windows.Forms.SplitContainer()
        Me.Souscadre2 = New System.Windows.Forms.SplitContainer()
        Me.ToolStripTOP = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton13 = New System.Windows.Forms.ToolStripButton()
        Me.ANIMATION = New System.Windows.Forms.ToolStripButton()
        Me.REMONTEES = New System.Windows.Forms.ToolStripButton()
        Me.PISTES = New System.Windows.Forms.ToolStripButton()
        Me.ACCEUIL = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripMID = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton14 = New System.Windows.Forms.ToolStripButton()
        Me.MESSAGERIE = New System.Windows.Forms.ToolStripButton()
        Me.PIDA = New System.Windows.Forms.ToolStripButton()
        Me.GEOLOCALISATION = New System.Windows.Forms.ToolStripButton()
        Me.REPORTING = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton16 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton15 = New System.Windows.Forms.ToolStripButton()
        Me.GMAO = New System.Windows.Forms.ToolStripButton()
        Me.UTILISATEURS = New System.Windows.Forms.ToolStripButton()
        Me.BlockageInfDroit3 = New System.Windows.Forms.ToolStripButton()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.TextNumVers = New System.Windows.Forms.ToolStripStatusLabel()
        Me.NumVers = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        CType(Me.CadreGeneral, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CadreGeneral.Panel1.SuspendLayout()
        Me.CadreGeneral.Panel2.SuspendLayout()
        Me.CadreGeneral.SuspendLayout()
        CType(Me.GrandLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Souscadre1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Souscadre1.Panel1.SuspendLayout()
        Me.Souscadre1.Panel2.SuspendLayout()
        Me.Souscadre1.SuspendLayout()
        CType(Me.Souscadre2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Souscadre2.Panel1.SuspendLayout()
        Me.Souscadre2.Panel2.SuspendLayout()
        Me.Souscadre2.SuspendLayout()
        Me.ToolStripTOP.SuspendLayout()
        Me.ToolStripMID.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStripContainer1
        '
        Me.ToolStripContainer1.BottomToolStripPanelVisible = False
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.CadreGeneral)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.StatusStrip1)
        Me.ToolStripContainer1.ContentPanel.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(477, 494)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.LeftToolStripPanelVisible = False
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer1.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.RightToolStripPanelVisible = False
        Me.ToolStripContainer1.Size = New System.Drawing.Size(477, 494)
        Me.ToolStripContainer1.TabIndex = 0
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        Me.ToolStripContainer1.TopToolStripPanelVisible = False
        '
        'CadreGeneral
        '
        Me.CadreGeneral.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CadreGeneral.IsSplitterFixed = True
        Me.CadreGeneral.Location = New System.Drawing.Point(0, 0)
        Me.CadreGeneral.Name = "CadreGeneral"
        Me.CadreGeneral.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'CadreGeneral.Panel1
        '
        Me.CadreGeneral.Panel1.Controls.Add(Me.GrandLogo)
        Me.CadreGeneral.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No
        '
        'CadreGeneral.Panel2
        '
        Me.CadreGeneral.Panel2.Controls.Add(Me.Souscadre1)
        Me.CadreGeneral.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CadreGeneral.Size = New System.Drawing.Size(477, 472)
        Me.CadreGeneral.SplitterDistance = 249
        Me.CadreGeneral.TabIndex = 13
        '
        'GrandLogo
        '
        Me.GrandLogo.BackgroundImage = Global.SKI_VIEW.My.Resources.Resources._02_skiview_logo1
        Me.GrandLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GrandLogo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GrandLogo.Location = New System.Drawing.Point(0, 0)
        Me.GrandLogo.Name = "GrandLogo"
        Me.GrandLogo.Size = New System.Drawing.Size(477, 249)
        Me.GrandLogo.TabIndex = 1
        Me.GrandLogo.TabStop = False
        '
        'Souscadre1
        '
        Me.Souscadre1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Souscadre1.IsSplitterFixed = True
        Me.Souscadre1.Location = New System.Drawing.Point(0, 0)
        Me.Souscadre1.Name = "Souscadre1"
        Me.Souscadre1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'Souscadre1.Panel1
        '
        Me.Souscadre1.Panel1.Controls.Add(Me.Souscadre2)
        '
        'Souscadre1.Panel2
        '
        Me.Souscadre1.Panel2.Controls.Add(Me.ToolStrip1)
        Me.Souscadre1.Size = New System.Drawing.Size(477, 219)
        Me.Souscadre1.SplitterDistance = 147
        Me.Souscadre1.TabIndex = 0
        '
        'Souscadre2
        '
        Me.Souscadre2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Souscadre2.IsSplitterFixed = True
        Me.Souscadre2.Location = New System.Drawing.Point(0, 0)
        Me.Souscadre2.Name = "Souscadre2"
        Me.Souscadre2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'Souscadre2.Panel1
        '
        Me.Souscadre2.Panel1.Controls.Add(Me.ToolStripTOP)
        '
        'Souscadre2.Panel2
        '
        Me.Souscadre2.Panel2.Controls.Add(Me.ToolStripMID)
        Me.Souscadre2.Size = New System.Drawing.Size(477, 147)
        Me.Souscadre2.SplitterDistance = 74
        Me.Souscadre2.TabIndex = 0
        '
        'ToolStripTOP
        '
        Me.ToolStripTOP.AllowDrop = True
        Me.ToolStripTOP.BackColor = System.Drawing.Color.White
        Me.ToolStripTOP.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripTOP.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton13, Me.ANIMATION, Me.REMONTEES, Me.PISTES, Me.ACCEUIL})
        Me.ToolStripTOP.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
        Me.ToolStripTOP.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripTOP.Name = "ToolStripTOP"
        Me.ToolStripTOP.Padding = New System.Windows.Forms.Padding(0)
        Me.ToolStripTOP.Size = New System.Drawing.Size(477, 74)
        Me.ToolStripTOP.TabIndex = 0
        '
        'ToolStripButton13
        '
        Me.ToolStripButton13.AutoSize = False
        Me.ToolStripButton13.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton13.Enabled = False
        Me.ToolStripButton13.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton13.Name = "ToolStripButton13"
        Me.ToolStripButton13.Size = New System.Drawing.Size(23, 20)
        Me.ToolStripButton13.Text = "ToolStripButton13"
        '
        'ANIMATION
        '
        Me.ANIMATION.AutoSize = False
        Me.ANIMATION.BackColor = System.Drawing.Color.Transparent
        Me.ANIMATION.Image = CType(resources.GetObject("ANIMATION.Image"), System.Drawing.Image)
        Me.ANIMATION.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ANIMATION.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ANIMATION.Name = "ANIMATION"
        Me.ANIMATION.Size = New System.Drawing.Size(110, 76)
        Me.ANIMATION.Text = "SUPERVISION"
        Me.ANIMATION.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ANIMATION.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'REMONTEES
        '
        Me.REMONTEES.AutoSize = False
        Me.REMONTEES.BackColor = System.Drawing.Color.White
        Me.REMONTEES.Image = CType(resources.GetObject("REMONTEES.Image"), System.Drawing.Image)
        Me.REMONTEES.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.REMONTEES.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.REMONTEES.Name = "REMONTEES"
        Me.REMONTEES.Size = New System.Drawing.Size(110, 68)
        Me.REMONTEES.Text = "REMONTEES"
        Me.REMONTEES.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.REMONTEES.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'PISTES
        '
        Me.PISTES.AutoSize = False
        Me.PISTES.BackColor = System.Drawing.Color.White
        Me.PISTES.Enabled = False
        Me.PISTES.Image = CType(resources.GetObject("PISTES.Image"), System.Drawing.Image)
        Me.PISTES.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.PISTES.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PISTES.Name = "PISTES"
        Me.PISTES.Size = New System.Drawing.Size(110, 68)
        Me.PISTES.Text = "PISTES"
        Me.PISTES.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.PISTES.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ACCEUIL
        '
        Me.ACCEUIL.AutoSize = False
        Me.ACCEUIL.BackColor = System.Drawing.Color.White
        Me.ACCEUIL.Enabled = False
        Me.ACCEUIL.Image = CType(resources.GetObject("ACCEUIL.Image"), System.Drawing.Image)
        Me.ACCEUIL.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ACCEUIL.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ACCEUIL.Name = "ACCEUIL"
        Me.ACCEUIL.Size = New System.Drawing.Size(110, 68)
        Me.ACCEUIL.Text = "ACCEUIL CENTRAL"
        Me.ACCEUIL.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ACCEUIL.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripMID
        '
        Me.ToolStripMID.AllowDrop = True
        Me.ToolStripMID.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripMID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripMID.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton14, Me.MESSAGERIE, Me.PIDA, Me.GEOLOCALISATION, Me.REPORTING})
        Me.ToolStripMID.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
        Me.ToolStripMID.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripMID.Name = "ToolStripMID"
        Me.ToolStripMID.Size = New System.Drawing.Size(477, 69)
        Me.ToolStripMID.TabIndex = 0
        '
        'ToolStripButton14
        '
        Me.ToolStripButton14.AutoSize = False
        Me.ToolStripButton14.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton14.Enabled = False
        Me.ToolStripButton14.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton14.Name = "ToolStripButton14"
        Me.ToolStripButton14.Size = New System.Drawing.Size(23, 24)
        Me.ToolStripButton14.Text = "ToolStripButton14"
        '
        'MESSAGERIE
        '
        Me.MESSAGERIE.AutoSize = False
        Me.MESSAGERIE.BackColor = System.Drawing.Color.White
        Me.MESSAGERIE.Enabled = False
        Me.MESSAGERIE.Image = CType(resources.GetObject("MESSAGERIE.Image"), System.Drawing.Image)
        Me.MESSAGERIE.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.MESSAGERIE.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.MESSAGERIE.Name = "MESSAGERIE"
        Me.MESSAGERIE.Size = New System.Drawing.Size(110, 68)
        Me.MESSAGERIE.Text = "MESSAGERIE"
        Me.MESSAGERIE.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.MESSAGERIE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'PIDA
        '
        Me.PIDA.AutoSize = False
        Me.PIDA.BackColor = System.Drawing.Color.White
        Me.PIDA.Enabled = False
        Me.PIDA.Image = CType(resources.GetObject("PIDA.Image"), System.Drawing.Image)
        Me.PIDA.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.PIDA.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PIDA.Name = "PIDA"
        Me.PIDA.Size = New System.Drawing.Size(110, 68)
        Me.PIDA.Text = "PIDA"
        Me.PIDA.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.PIDA.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'GEOLOCALISATION
        '
        Me.GEOLOCALISATION.AutoSize = False
        Me.GEOLOCALISATION.BackColor = System.Drawing.Color.White
        Me.GEOLOCALISATION.Enabled = False
        Me.GEOLOCALISATION.Image = CType(resources.GetObject("GEOLOCALISATION.Image"), System.Drawing.Image)
        Me.GEOLOCALISATION.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.GEOLOCALISATION.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.GEOLOCALISATION.Margin = New System.Windows.Forms.Padding(0)
        Me.GEOLOCALISATION.Name = "GEOLOCALISATION"
        Me.GEOLOCALISATION.Size = New System.Drawing.Size(110, 68)
        Me.GEOLOCALISATION.Text = "GEOLOCALISATION"
        Me.GEOLOCALISATION.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.GEOLOCALISATION.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'REPORTING
        '
        Me.REPORTING.AutoSize = False
        Me.REPORTING.BackColor = System.Drawing.Color.White
        Me.REPORTING.Enabled = False
        Me.REPORTING.Image = CType(resources.GetObject("REPORTING.Image"), System.Drawing.Image)
        Me.REPORTING.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.REPORTING.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.REPORTING.Name = "REPORTING"
        Me.REPORTING.Size = New System.Drawing.Size(110, 68)
        Me.REPORTING.Text = "REPORTING"
        Me.REPORTING.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.REPORTING.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AllowDrop = True
        Me.ToolStrip1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton16, Me.ToolStripButton15, Me.GMAO, Me.UTILISATEURS, Me.BlockageInfDroit3})
        Me.ToolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(477, 68)
        Me.ToolStrip1.TabIndex = 1
        '
        'ToolStripButton16
        '
        Me.ToolStripButton16.AutoSize = False
        Me.ToolStripButton16.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton16.Enabled = False
        Me.ToolStripButton16.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton16.Name = "ToolStripButton16"
        Me.ToolStripButton16.Size = New System.Drawing.Size(23, 24)
        Me.ToolStripButton16.Text = "ToolStripButton16"
        '
        'ToolStripButton15
        '
        Me.ToolStripButton15.AutoSize = False
        Me.ToolStripButton15.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton15.Enabled = False
        Me.ToolStripButton15.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton15.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton15.Name = "ToolStripButton15"
        Me.ToolStripButton15.Size = New System.Drawing.Size(110, 68)
        Me.ToolStripButton15.Text = "ToolStripButton5"
        '
        'GMAO
        '
        Me.GMAO.AutoSize = False
        Me.GMAO.BackColor = System.Drawing.Color.White
        Me.GMAO.Enabled = False
        Me.GMAO.Image = CType(resources.GetObject("GMAO.Image"), System.Drawing.Image)
        Me.GMAO.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.GMAO.ImageTransparentColor = System.Drawing.Color.MediumAquamarine
        Me.GMAO.Name = "GMAO"
        Me.GMAO.Size = New System.Drawing.Size(110, 68)
        Me.GMAO.Text = "GMAO"
        Me.GMAO.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.GMAO.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'UTILISATEURS
        '
        Me.UTILISATEURS.AutoSize = False
        Me.UTILISATEURS.BackColor = System.Drawing.Color.White
        Me.UTILISATEURS.Enabled = False
        Me.UTILISATEURS.Image = CType(resources.GetObject("UTILISATEURS.Image"), System.Drawing.Image)
        Me.UTILISATEURS.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.UTILISATEURS.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.UTILISATEURS.Name = "UTILISATEURS"
        Me.UTILISATEURS.Size = New System.Drawing.Size(110, 68)
        Me.UTILISATEURS.Text = "UTILISATEURS"
        Me.UTILISATEURS.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.UTILISATEURS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'BlockageInfDroit3
        '
        Me.BlockageInfDroit3.AutoSize = False
        Me.BlockageInfDroit3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BlockageInfDroit3.Enabled = False
        Me.BlockageInfDroit3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BlockageInfDroit3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BlockageInfDroit3.Name = "BlockageInfDroit3"
        Me.BlockageInfDroit3.Size = New System.Drawing.Size(110, 68)
        Me.BlockageInfDroit3.Text = "ToolStripButton5"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TextNumVers, Me.NumVers})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 472)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(477, 22)
        Me.StatusStrip1.TabIndex = 12
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'TextNumVers
        '
        Me.TextNumVers.Name = "TextNumVers"
        Me.TextNumVers.Size = New System.Drawing.Size(120, 17)
        Me.TextNumVers.Text = "Numéros de Version :"
        '
        'NumVers
        '
        Me.NumVers.Name = "NumVers"
        Me.NumVers.Size = New System.Drawing.Size(0, 17)
        '
        'MENU
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(3.0!, 6.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(477, 494)
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Font = New System.Drawing.Font("Segoe UI", 3.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(130, 111)
        Me.Name = "MENU"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SkiView"
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.ContentPanel.PerformLayout()
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.CadreGeneral.Panel1.ResumeLayout(False)
        Me.CadreGeneral.Panel2.ResumeLayout(False)
        CType(Me.CadreGeneral, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CadreGeneral.ResumeLayout(False)
        CType(Me.GrandLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Souscadre1.Panel1.ResumeLayout(False)
        Me.Souscadre1.Panel2.ResumeLayout(False)
        Me.Souscadre1.Panel2.PerformLayout()
        CType(Me.Souscadre1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Souscadre1.ResumeLayout(False)
        Me.Souscadre2.Panel1.ResumeLayout(False)
        Me.Souscadre2.Panel1.PerformLayout()
        Me.Souscadre2.Panel2.ResumeLayout(False)
        Me.Souscadre2.Panel2.PerformLayout()
        CType(Me.Souscadre2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Souscadre2.ResumeLayout(False)
        Me.ToolStripTOP.ResumeLayout(False)
        Me.ToolStripTOP.PerformLayout()
        Me.ToolStripMID.ResumeLayout(False)
        Me.ToolStripMID.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ToolStripContainer1 As ToolStripContainer
    Friend WithEvents GrandLogo As PictureBox
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents TextNumVers As ToolStripStatusLabel
    Friend WithEvents NumVers As ToolStripStatusLabel
    Friend WithEvents ToolStripTOP As ToolStrip
    Protected WithEvents CadreGeneral As SplitContainer
    Protected WithEvents Souscadre1 As SplitContainer
    Friend WithEvents Souscadre2 As SplitContainer
    Friend WithEvents ToolStripMID As ToolStrip
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripButton9 As ToolStripButton
    Friend WithEvents BlockageInfDroit3 As ToolStripButton
    Friend WithEvents ToolStripButton13 As ToolStripButton
    Friend WithEvents ToolStripButton14 As ToolStripButton
    Friend WithEvents ToolStripButton16 As ToolStripButton
    Friend WithEvents ToolStripButton15 As ToolStripButton
    Friend WithEvents ANIMATION As ToolStripButton
    Friend WithEvents REMONTEES As ToolStripButton
    Friend WithEvents PISTES As ToolStripButton
    Friend WithEvents ACCEUIL As ToolStripButton
    Friend WithEvents MESSAGERIE As ToolStripButton
    Friend WithEvents PIDA As ToolStripButton
    Friend WithEvents GEOLOCALISATION As ToolStripButton
    Friend WithEvents REPORTING As ToolStripButton
    Friend WithEvents GMAO As ToolStripButton
    Friend WithEvents UTILISATEURS As ToolStripButton
End Class
