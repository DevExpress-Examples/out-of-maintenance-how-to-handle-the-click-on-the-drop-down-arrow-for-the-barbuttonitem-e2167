Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraBars
Imports DevExpress.XtraBars.Styles
Imports DevExpress.XtraBars.ViewInfo
Imports DevExpress.XtraBars.Painters

Namespace WindowsApplication3
	Public Class MyBarManager
		Inherits BarManager
		Public Sub New(ByVal cont As IContainer)
			MyBase.New(cont)
		End Sub

		Public Delegate Sub ArrowClickEventHandler(ByVal sender As Object, ByVal e As ArrowClickEventArgs)
		Public Event ArrowItemClick As ArrowClickEventHandler

		Protected Overridable Sub UpdateBarItemInfo()
			For Each ps As BarManagerPaintStyle In GetController().PaintStyles
				If TypeOf ps Is SkinBarManagerPaintStyle Then
					For Each info As BarItemInfo In ps.ItemInfoCollection
						If info.Name = "BarButtonItem" Then
							ps.ItemInfoCollection.Remove(info)
							ps.ItemInfoCollection.Add(New BarItemInfo("BarButtonItem", "Button", 0, GetType(BarButtonItem), GetType(MyBarButtonItemLink), GetType(BarButtonLinkViewInfo), New BarButtonLinkPainter(ps), True, True))
							Return
						End If
					Next info
				End If
			Next ps
		End Sub
		Protected Overrides Sub OnLoaded()
			MyBase.OnLoaded()
			UpdateBarItemInfo()
		End Sub

		Friend Sub RaiseArrowItemClick(ByVal e As ArrowClickEventArgs)
			RaiseEvent ArrowItemClick(Me, e)
		End Sub
	End Class
End Namespace
