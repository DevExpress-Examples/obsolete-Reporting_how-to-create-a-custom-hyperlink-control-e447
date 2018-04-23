Imports Microsoft.VisualBasic
Imports DevExpress.XtraReports.UI
Imports System.Web.UI
Imports System.Web.UI.HtmlControls

Namespace CustomControl_HyperlinkLabel
	Partial Public Class XtraReport1
		Inherits XtraReport
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub xrLabel1_HtmlItemCreated(ByVal sender As Object, ByVal e As HtmlEventArgs) Handles xrLabel1.HtmlItemCreated
			Dim currentCell As HtmlTableCell = CType(e.ContentCell, HtmlTableCell)
			Dim link As New HtmlAnchor()
			link.HRef = (CType(sender, XRLabel)).NavigateUrl
			link.InnerText = e.Brick.Text
			currentCell.Controls.Clear()
			currentCell.Controls.Add(link)
			currentCell.Attributes.Remove("onmousedown")
			currentCell.Attributes.CssStyle.Remove("cursor")
		End Sub
	End Class
End Namespace
