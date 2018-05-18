Public Class Form1


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

#Region "MENU"

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim DialogResult = MessageBox.Show("Etes-vous sur de vouloir quitter SkiVieuw ?", "Fermeture de SKIVIEUW", MessageBoxButtons.YesNo)
        If (DialogResult = DialogResult.No) Then
            e.Cancel = True
        End If

    End Sub
    Private Sub REMONTEES_Click_1(sender As Object, e As EventArgs)
        Dim fichier As String
        fichier = Application.StartupPath + "\RM\SKI VIEW RM.exe"
        Shell(fichier, AppWinStyle.NormalFocus)
    End Sub


    Private Sub BtnSupervision_Click(sender As Object, e As EventArgs) Handles BtnSupervision.Click
        Dim fichier As String
        fichier = Application.StartupPath + "\SUPERVISION\SKI VIEW.exe"
        Shell(fichier, AppWinStyle.NormalFocus)
    End Sub

    Private Sub BtnRm_Click(sender As Object, e As EventArgs) Handles BtnRm.Click
        Dim fichier As String
        fichier = Application.StartupPath + "\RM\SKI VIEW RM.exe"
        Shell(fichier, AppWinStyle.NormalFocus)
    End Sub

    Private Sub BtnPiste_Click(sender As Object, e As EventArgs) Handles BtnPiste.Click
        Dim fichier As String
        fichier = Application.StartupPath + "\PISTES\PISTES.exe"
        Shell(fichier, AppWinStyle.NormalFocus)
    End Sub

    Private Sub BtnAcc_Click(sender As Object, e As EventArgs) Handles BtnAcc.Click
        Dim fichier As String
        fichier = Application.StartupPath + "\ACCEUIL\ACCEUIL.exe"
        Shell(fichier, AppWinStyle.NormalFocus)
    End Sub

    Private Sub BtnMessagerie_Click(sender As Object, e As EventArgs) Handles BtnMessagerie.Click
        Dim fichier As String
        fichier = Application.StartupPath + "\MESSAGERIE\MESSAGERIE.exe"
        Shell(fichier, AppWinStyle.NormalFocus)
    End Sub

    Private Sub BtnPida_Click(sender As Object, e As EventArgs) Handles BtnPida.Click
        Dim fichier As String
        fichier = Application.StartupPath + "\PIDA\PIDA.exe"
        Shell(fichier, AppWinStyle.NormalFocus)
    End Sub

    Private Sub BtnGeo_Click(sender As Object, e As EventArgs) Handles BtnGeo.Click
        Dim fichier As String
        fichier = Application.StartupPath + "\GEOLOCALISATION\GEOLOCALISATION.exe"
        Shell(fichier, AppWinStyle.NormalFocus)
    End Sub

    Private Sub BtnReport_Click(sender As Object, e As EventArgs) Handles BtnReport.Click
        Dim fichier As String
        fichier = Application.StartupPath + "\REPORTING\REPORTING.exe"
        Shell(fichier, AppWinStyle.NormalFocus)
    End Sub

    Private Sub BtnUtilisateur_Click(sender As Object, e As EventArgs) Handles BtnUtilisateur.Click
        Dim fichier As String
        fichier = Application.StartupPath + "\UTILISATEURS\UTILISATEURS.exe"
        Shell(fichier, AppWinStyle.NormalFocus)
    End Sub

    Private Sub BtnGMAO_Click(sender As Object, e As EventArgs) Handles BtnGMAO.Click
        Dim fichier As String
        fichier = Application.StartupPath + "\GMAO\GMAO.exe"
        Shell(fichier, AppWinStyle.NormalFocus)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

#End Region

End Class
