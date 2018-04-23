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
Imports System.Diagnostics

Namespace WindowsApplication3
	Public Class MyBarButtonItemLink
		Inherits BarButtonItemLink
		Public Sub New(ByVal ALinks As BarItemLinkReadOnlyCollection, ByVal AItem As BarItem, ByVal ALinkedObject As Object)
			MyBase.New(ALinks, AItem, ALinkedObject)
		End Sub
		Protected Overrides Sub OnLinkAction(ByVal action As BarLinkAction, ByVal actionArgs As Object)
			If action = BarLinkAction.PressArrow Then
				If CanPressDropDownButton Then
					If BarControl IsNot Nothing Then
						BarControl.Capture = False
					End If
					If IsPopupVisible Then
						HidePopupCore(True)
					Else
						Dim e As New ArrowClickEventArgs() With {.Handled = False, .Link = Me}
						Manager.RaiseArrowItemClick(e)
						If (Not e.Handled) Then
						  ShowPopup()
						End If
						Debug.WriteLine("ArrowClick")
					End If
				End If
				Return
			End If
			MyBase.OnLinkAction(action, actionArgs)
		End Sub

		Private ReadOnly Overloads Property Manager() As MyBarManager
			Get
				Return TryCast(MyBase.Manager, MyBarManager)
			End Get
		End Property
	End Class
End Namespace