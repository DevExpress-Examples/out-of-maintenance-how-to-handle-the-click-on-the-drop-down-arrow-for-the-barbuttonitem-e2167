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
	Public Class ArrowClickEventArgs
		Inherits EventArgs

		Public Sub New()
		End Sub


		'// Fields...

		Private _Link As BarItemLink
		Private _Handled As Boolean

		Public Property Handled() As Boolean
			Get
				Return _Handled
			End Get
			Set(ByVal value As Boolean)
				_Handled = value
			End Set
		End Property


		Public Property Link() As BarItemLink
			Get
				Return _Link
			End Get
			Set(ByVal value As BarItemLink)
				_Link = value
			End Set
		End Property

	End Class
End Namespace
