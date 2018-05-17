Public Class Form1


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

#Region "MENU"

    Private Sub ANIMATION_Click(sender As Object, e As EventArgs) Handles ANIMATION.Click
        Dim fichier As String
        fichier = Application.StartupPath + "\SUPERVISION\SKI VIEW.exe"
        Shell(fichier, AppWinStyle.NormalFocus)
    End Sub

    Private Sub REMONTEES_Click(sender As Object, e As EventArgs) Handles REMONTEES.Click
        Dim fichier As String
        fichier = Application.StartupPath + "\RM\SKI VIEW RM.exe"
        Shell(fichier, AppWinStyle.NormalFocus)
    End Sub

    Private Sub PISTES_Click(sender As Object, e As EventArgs) Handles PISTES.Click
        Dim fichier As String
        fichier = Application.StartupPath + "\PISTES\PISTES.exe"
        Shell(fichier, AppWinStyle.NormalFocus)
    End Sub

    Private Sub ACCEUIL_Click(sender As Object, e As EventArgs) Handles ACCEUIL.Click
        Dim fichier As String
        fichier = Application.StartupPath + "\ACCEUIL\ACCEUIL.exe"
        Shell(fichier, AppWinStyle.NormalFocus)
    End Sub

    Private Sub MESSAGERIE_Click(sender As Object, e As EventArgs) Handles MESSAGERIE.Click
        Dim fichier As String
        fichier = Application.StartupPath + "\MESSAGERIE\MESSAGERIE.exe"
        Shell(fichier, AppWinStyle.NormalFocus)
    End Sub

    Private Sub PIDA_Click(sender As Object, e As EventArgs) Handles PIDA.Click
        Dim fichier As String
        fichier = Application.StartupPath + "\PIDA\PIDA.exe"
        Shell(fichier, AppWinStyle.NormalFocus)
    End Sub

    Private Sub GEOLOCALISATION_Click(sender As Object, e As EventArgs) Handles GEOLOCALISATION.Click
        Dim fichier As String
        fichier = Application.StartupPath + "\GEOLOCALISATION\GEOLOCALISATION.exe"
        Shell(fichier, AppWinStyle.NormalFocus)
    End Sub

    Private Sub REPORTING_Click(sender As Object, e As EventArgs) Handles REPORTING.Click
        Dim fichier As String
        fichier = Application.StartupPath + "\REPORTING\REPORTING.exe"
        Shell(fichier, AppWinStyle.NormalFocus)
    End Sub

    Private Sub UTILISATEURS_Click(sender As Object, e As EventArgs) Handles UTILISATEURS.Click
        Dim fichier As String
        fichier = Application.StartupPath + "\UTILISATEURS\UTILISATEURS.exe"
        Shell(fichier, AppWinStyle.NormalFocus)
    End Sub
    Private Sub GMAO_Click(sender As Object, e As EventArgs) Handles GMAO.Click
        Dim fichier As String
        fichier = Application.StartupPath + "\GMAO\GMAO.exe"
        Shell(fichier, AppWinStyle.NormalFocus)
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ToolStripLabel1_Click(sender As Object, e As EventArgs) Handles ToolStripLabel1.Click

    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim DialogResult = MessageBox.Show("Etes-vous sur de vouloir quitter SkiVieuw ?", "Fermeture de SKIVIEUW", MessageBoxButtons.YesNo)
        If (DialogResult = DialogResult.No) Then
            e.Cancel = True
        End If

    End Sub

#End Region

End Class
