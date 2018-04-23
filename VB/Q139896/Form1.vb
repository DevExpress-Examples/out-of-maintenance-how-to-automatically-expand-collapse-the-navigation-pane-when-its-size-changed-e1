Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraNavBar

Namespace Q139896
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
			prevExpandedWidth = navBarControl1.Width
		End Sub
		Private prevExpandedWidth As Integer

		Private Sub splitterControl1_SplitterMoved(ByVal sender As Object, ByVal e As SplitterEventArgs) Handles splitterControl1.SplitterMoved
			If navBarControl1.Width <= 50 Then
				If navBarControl1.OptionsNavPane.NavPaneState = NavPaneState.Expanded Then
					navBarControl1.OptionsNavPane.NavPaneState = NavPaneState.Collapsed
					navBarControl1.OptionsNavPane.ExpandedWidth = prevExpandedWidth
				End If
			Else
				If navBarControl1.OptionsNavPane.NavPaneState = NavPaneState.Collapsed Then
					navBarControl1.OptionsNavPane.NavPaneState = NavPaneState.Expanded
				Else
					prevExpandedWidth = navBarControl1.Width
				End If
			End If
		End Sub
	End Class
End Namespace