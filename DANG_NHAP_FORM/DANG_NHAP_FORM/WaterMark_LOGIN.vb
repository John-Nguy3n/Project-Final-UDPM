﻿Imports System.ComponentModel
Public Class WaterMark_LOGIN
    Inherits TextBox
    Dim WaterText As String
    Dim WaterColor As Color
    Dim WaterFont As Font
    Dim WaterBrush As SolidBrush
    Dim WaterContainer As Panel
    Public Sub New()
        MyBase.New
        StartProcess()
    End Sub
    Private Sub StartProcess()
        WaterText = "Tài khoản"
        WaterColor = Color.Gray
        WaterFont = New Font(Me.Font, FontStyle.Italic)
        WaterBrush = New SolidBrush(WaterColor)
        CreateWaterMark()
        AddHandler TextChanged, AddressOf ChangeText
        AddHandler FontChanged, AddressOf ChangeFont

    End Sub
    Private Sub CreateWaterMark()
        WaterContainer = New Panel
        Me.Controls.Add(WaterContainer)
        AddHandler WaterContainer.Click, AddressOf clicked
        AddHandler WaterContainer.Paint, AddressOf Painted
    End Sub
    Private Sub RemoveWaterMark()
        Me.Controls.Remove(WaterContainer)

    End Sub
    Private Sub ChangeText(sender As Object, e As EventArgs)
        If Me.TextLength <= 0 Then
            CreateWaterMark()
        ElseIf Me.TextLength > 0 Then
            RemoveWaterMark()
        End If
    End Sub
    Private Sub ChangeFont(sender As Object, e As EventArgs)
        WaterFont = New Font(Me.Font, FontStyle.Italic)
    End Sub
    Private Sub clicked(sender As Object, e As EventArgs)
        Me.Focus()
    End Sub
    Private Sub Painted(sender As Object, e As PaintEventArgs)
        WaterContainer.Location = New Point(2, 0)
        WaterContainer.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        WaterContainer.Height = Me.Height
        WaterBrush = New SolidBrush(WaterColor)
        Dim Graphic As Graphics = e.Graphics
        Graphic.DrawString(WaterText, WaterFont, WaterBrush, New PointF(-2.0!, 1.0!))
    End Sub
    Protected Overrides Sub OnInvalidated(e As InvalidateEventArgs)
        MyBase.OnInvalidated(e)
        WaterContainer.Invalidate()

    End Sub
    <Category("Watermark Attributes"), Description("Sets Watermart text")> Public Property WatermarkText As String
        Get
            Return WaterText
        End Get
        Set(value As String)
            WaterText = value
            Me.Invalidate()
        End Set
    End Property
    <Category("Watermark Attributes"), Description("Sets Watermart color ")> Public Property WatermarkColor As Color
        Get
            Return WaterColor
        End Get
        Set(value As Color)
            WaterColor = value
            Me.Invalidate()
        End Set
    End Property
End Class
