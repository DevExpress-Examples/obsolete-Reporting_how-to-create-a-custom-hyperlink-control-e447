Imports Microsoft.VisualBasic
Imports DevExpress.XtraReports.UI
Imports System.Web.UI
Imports System.Web.UI.HtmlControls
Imports DevExpress.XtraPrinting.HtmlExport.Controls

Namespace CustomControl_HyperlinkLabel
	Partial Public Class XtraReport1
		Inherits XtraReport
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub xrLabel1_HtmlItemCreated(ByVal sender As Object, ByVal e As HtmlEventArgs) Handles xrLabel1.HtmlItemCreated
			Dim currentCell As DXHtmlTableCell = CType(e.ContentCell, DXHtmlTableCell)
			Dim link As New DXHtmlAnchor()
			link.HRef = (CType(sender, XRLabel)).NavigateUrl
			link.InnerText = e.Brick.Text
			currentCell.Controls.Clear()
			currentCell.Controls.Add(link)
			currentCell.Attributes.Remove("onmousedown")
			currentCell.Attributes.CssStyle.Remove("cursor")
		End Sub
	End Class
End Namespace
