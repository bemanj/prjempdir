Public Class AloricaSite

#Region "Comments"
    'Private Sub HomeButtonAdmin_Paint(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HomeButtonAdmin.Paint
    '    Dim buttonPath As New System.Drawing.Drawing2D.GraphicsPath

    '    ' Set a new rectangle to the same size as the button's 
    '    ' ClientRectangle property.
    '    Dim newRectangle As Rectangle = HomeButtonAdmin.ClientRectangle

    '    ' Decrease the size of the rectangle.
    '    newRectangle.Inflate(-10, -10)

    '    ' Draw the button's border.
    '    'e.Graphics.DrawEllipse(System.Drawing.Pens.Black, newRectangle)

    '    'Increase the size of the rectangle to include the border.
    '    newRectangle.Inflate(1, 1)

    '    ' Create a circle within the new rectangle.
    '    buttonPath.AddEllipse(New Rectangle(New Point(5, 5), New Size(39, 39)))
    '    ' Set the button's Region property to the newly created 
    '    ' circle region.
    '    HomeButtonAdmin.Region = New System.Drawing.Region(buttonPath)


    '    'Dim btn As New Button
    '    'btn.Size = New Size(75, 75)
    '    'btn.Location = New Point(174, 184)
    '    'Dim gp As New Drawing.Drawing2D.GraphicsPath
    '    'gp.AddEllipse(New Rectangle(New Point(2, 2), New Size(70, 70)))
    '    'btn.Region = New Region(gp)
    '    'Me.Controls.Add(btn)
    'End Sub


    'Private Sub Button2_Paint(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Paint
    '    Dim buttonPath As New System.Drawing.Drawing2D.GraphicsPath

    '    ' Set a new rectangle to the same size as the button's 
    '    ' ClientRectangle property.
    '    Dim newRectangle As Rectangle = HomeButtonAdmin.ClientRectangle

    '    ' Decrease the size of the rectangle.
    '    newRectangle.Inflate(-10, -10)

    '    ' Draw the button's border.
    '    'e.Graphics.DrawEllipse(System.Drawing.Pens.Black, newRectangle)

    '    'Increase the size of the rectangle to include the border.
    '    newRectangle.Inflate(1, 1)

    '    ' Create a circle within the new rectangle.
    '    buttonPath.AddEllipse(New Rectangle(New Point(5, 5), New Size(39, 39)))
    '    ' Set the button's Region property to the newly created 
    '    ' circle region.
    '    HomeButtonAdmin.Region = New System.Drawing.Region(buttonPath)
    'End Sub
#End Region

#Region "Subroutines"
    Private Sub SetupIcons()
        HomeLabel.Hide()
        LogoutLabel.Hide()
        HomeLabel.Parent = AdminAloricaSiteHeader
        HomeLabel.AutoSize = True
        HomeLabel.BackColor = System.Drawing.Color.Transparent
        LogoutLabel.Parent = AdminAloricaSiteHeader
        LogoutLabel.AutoSize = True
        LogoutLabel.BackColor = System.Drawing.Color.Transparent
    End Sub
#End Region

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub HomeButtonAdmin_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles HomeButtonAdmin.MouseHover
        HomeLabel.Show()
    End Sub

    Private Sub Button2_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.MouseHover
        LogoutLabel.Show()
    End Sub

    Private Sub HomeButtonAdmin_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles HomeButtonAdmin.MouseLeave
        HomeLabel.Hide()
    End Sub

    Private Sub Button2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.MouseLeave
        LogoutLabel.Hide()
    End Sub

    Private Sub AloricaSite_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetupIcons()
    End Sub

End Class