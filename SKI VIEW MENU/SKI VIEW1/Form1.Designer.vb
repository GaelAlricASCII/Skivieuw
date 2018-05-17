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
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ANIMATION = New System.Windows.Forms.ToolStripButton()
        Me.REMONTEES = New System.Windows.Forms.ToolStripButton()
        Me.PISTES = New System.Windows.Forms.ToolStripButton()
        Me.ACCEUIL = New System.Windows.Forms.ToolStripButton()
        Me.MESSAGERIE = New System.Windows.Forms.ToolStripButton()
        Me.PIDA = New System.Windows.Forms.ToolStripButton()
        Me.GEOLOCALISATION = New System.Windows.Forms.ToolStripButton()
        Me.REPORTING = New System.Windows.Forms.ToolStripButton()
        Me.GMAO = New System.Windows.Forms.ToolStripButton()
        Me.UTILISATEURS = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStripContainer1
        '
        Me.ToolStripContainer1.BottomToolStripPanelVisible = False
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.ToolStrip1)
        Me.ToolStripContainer1.ContentPanel.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(1324, 78)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.LeftToolStripPanelVisible = False
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer1.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.RightToolStripPanelVisible = False
        Me.ToolStripContainer1.Size = New System.Drawing.Size(1324, 78)
        Me.ToolStripContainer1.TabIndex = 0
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        Me.ToolStripContainer1.TopToolStripPanelVisible = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AllowDrop = True
        Me.ToolStrip1.BackColor = System.Drawing.Color.White
        Me.ToolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(48, 48)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.ANIMATION, Me.REMONTEES, Me.PISTES, Me.ACCEUIL, Me.MESSAGERIE, Me.PIDA, Me.GEOLOCALISATION, Me.REPORTING, Me.GMAO, Me.UTILISATEURS, Me.ToolStripLabel2})
        Me.ToolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Padding = New System.Windows.Forms.Padding(0)
        Me.ToolStrip1.Size = New System.Drawing.Size(1324, 78)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.AutoSize = False
        Me.ToolStripLabel1.BackColor = System.Drawing.Color.White
        Me.ToolStripLabel1.BackgroundImage = Global.SKI_VIEW.My.Resources.Resources._02_skiview_logo
        Me.ToolStripLabel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ToolStripLabel1.Enabled = False
        Me.ToolStripLabel1.Margin = New System.Windows.Forms.Padding(2, 3, 0, 2)
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(110, 68)
        '
        'ANIMATION
        '
        Me.ANIMATION.AutoSize = False
        Me.ANIMATION.BackColor = System.Drawing.Color.White
        Me.ANIMATION.Image = CType(resources.GetObject("ANIMATION.Image"), System.Drawing.Image)
        Me.ANIMATION.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ANIMATION.Name = "ANIMATION"
        Me.ANIMATION.Size = New System.Drawing.Size(110, 68)
        Me.ANIMATION.Text = "SUPERVISION"
        Me.ANIMATION.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ANIMATION.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'REMONTEES
        '
        Me.REMONTEES.AutoSize = False
        Me.REMONTEES.BackColor = System.Drawing.Color.White
        Me.REMONTEES.Image = CType(resources.GetObject("REMONTEES.Image"), System.Drawing.Image)
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
        Me.ACCEUIL.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ACCEUIL.Name = "ACCEUIL"
        Me.ACCEUIL.Size = New System.Drawing.Size(110, 68)
        Me.ACCEUIL.Text = "ACCEUIL CENTRAL"
        Me.ACCEUIL.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ACCEUIL.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'MESSAGERIE
        '
        Me.MESSAGERIE.AutoSize = False
        Me.MESSAGERIE.BackColor = System.Drawing.Color.White
        Me.MESSAGERIE.Enabled = False
        Me.MESSAGERIE.Image = CType(resources.GetObject("MESSAGERIE.Image"), System.Drawing.Image)
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
        Me.REPORTING.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.REPORTING.Name = "REPORTING"
        Me.REPORTING.Size = New System.Drawing.Size(110, 68)
        Me.REPORTING.Text = "REPORTING"
        Me.REPORTING.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.REPORTING.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'GMAO
        '
        Me.GMAO.AutoSize = False
        Me.GMAO.BackColor = System.Drawing.Color.White
        Me.GMAO.Enabled = False
        Me.GMAO.Image = CType(resources.GetObject("GMAO.Image"), System.Drawing.Image)
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
        Me.UTILISATEURS.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.UTILISATEURS.Name = "UTILISATEURS"
        Me.UTILISATEURS.Size = New System.Drawing.Size(110, 68)
        Me.UTILISATEURS.Text = "UTILISATEURS"
        Me.UTILISATEURS.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.UTILISATEURS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.AutoSize = False
        Me.ToolStripLabel2.BackgroundImage = CType(resources.GetObject("ToolStripLabel2.BackgroundImage"), System.Drawing.Image)
        Me.ToolStripLabel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(110, 68)
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
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(3.0!, 6.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1324, 78)
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.Font = New System.Drawing.Font("Segoe UI", 3.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(130, 111)
        Me.Name = "Form1"
        Me.Text = "Nom Utilisateur"
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.ContentPanel.PerformLayout()
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ToolStripContainer1 As ToolStripContainer
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ANIMATION As ToolStripButton
    Friend WithEvents REMONTEES As ToolStripButton
    Friend WithEvents PISTES As ToolStripButton
    Friend WithEvents UTILISATEURS As ToolStripButton
    Friend WithEvents ACCEUIL As ToolStripButton
    Friend WithEvents MESSAGERIE As ToolStripButton
    Friend WithEvents PIDA As ToolStripButton
    Friend WithEvents GEOLOCALISATION As ToolStripButton
    Friend WithEvents GMAO As ToolStripButton
    Friend WithEvents REPORTING As ToolStripButton
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
End Class
