Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraReports.UI

Namespace CustomControl_HyperlinkLabel
	Partial Public Class XtraReport1
		Inherits XtraReport
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub XtraReport1_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles MyBase.BeforePrint
			Dim label As New HyperlinkLabel()
			label.Text = "Right-click me!"
			label.Width = 500
			label.NavigateUrl = "http://www.devexpress.com"
			Me.Detail.Controls.Add(label)
		End Sub
	End Class

End Namespace
