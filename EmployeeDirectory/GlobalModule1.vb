﻿Imports System.Runtime.CompilerServices

Public Module GlobalModule
    Public Property CurrentUser As Long
    Public Property CurrentUserType As Integer

    'Public Sub SetSelectedValue(ByVal comboBox As ComboBox, ByVal value As Integer)

    '    Dim _list As List(Of DropDownList)
    '    _list = comboBox.DataSource

    '    comboBox.SelectedItem = _list.Where(Function(x) x.ListID = value).FirstOrDefault()

    'End Sub

    Public Function SetListName(ByVal combo As ComboBox, ByVal val As Integer) As String
        Dim j As Integer = combo.Items.Count
        Dim _selectname As String = "unk"

        If Not val > 0 Then
            Return _selectname
        End If

        Dim i As Integer = 0
        Do
            combo.SelectedIndex = i
            If CType(combo.SelectedItem, DropDownList).ListID = val Then
                _selectname = CType(combo.SelectedItem, DropDownList).ListName
                Exit Do
            End If
            i += 1
        Loop Until i > j
        Return _selectname

    End Function

    Public Function SetSiteDetails(ByVal sitecombo As ComboBox, ByVal siteidentity As Integer) As Site

        Dim j As Integer = sitecombo.Items.Count
        Dim _site As New Site()
        

        Dim i As Integer = 0

        Do
            If Not siteidentity > 0 Then
                Exit Do
            End If
            sitecombo.SelectedIndex = i
            If CType(sitecombo.SelectedItem, Site).SiteID = siteidentity Then
                _site = CType(sitecombo.SelectedItem, Site)
                Exit Do
            End If
            i += 1
        Loop Until i > j

        Return _site

    End Function
End Module
