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
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub myBarManager1_ArrowItemClick(ByVal sender As Object, ByVal e As ArrowClickEventArgs) Handles myBarManager1.ArrowItemClick
		   ' e.Handled = true;
			Text &= "Arrow "
		End Sub
	End Class
End Namespace