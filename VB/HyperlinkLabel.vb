Imports Microsoft.VisualBasic
Imports System.Reflection
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraPrinting.Native
Imports DevExpress.XtraPrinting.Export

Namespace CustomControl_HyperlinkLabel
	Public Class HyperlinkLabel
		Inherits XRLabel
		Protected Overrides Function CreateBrick(ByVal childrenBricks() As VisualBrick) As VisualBrick
			Return New CustomLabelBrick(Me)
		End Function
	End Class
	Public Class CustomLabelBrick
		Inherits LabelBrick
		Private Const brickType_Renamed As String = "CustomLabelBrick"
		Shared Sub New()
			BrickFactory.RegisterFactory(brickType_Renamed, New DefaultBrickFactory(Of CustomLabelBrick)())
		End Sub
		Public Sub New()
			MyBase.New()
		End Sub
		Public Sub New(ByVal owner As IBrickOwner)
			MyBase.New(owner)
		End Sub
		Protected Overrides Sub FillHtmlTableCellInternal(ByVal exportProvider As IHtmlExportProvider)
			FillHtmlTableCellCore(exportProvider)
			If (Not String.IsNullOrEmpty(Url)) Then
				SetHTMLLink(exportProvider)
			End If
			exportProvider.SetAnchor(AnchorName)
			exportProvider.RaiseHtmlItemCreated(Me)
		End Sub
		Public Overrides ReadOnly Property BrickType() As String
			Get
				Return brickType_Renamed
			End Get
		End Property
		Private Sub SetHTMLLink(ByVal exportProvider As IHtmlExportProvider)
			Dim currentCell As System.Web.UI.Control = CType(CType(exportProvider, Object).GetType().GetField("currentCell", BindingFlags.Instance Or BindingFlags.NonPublic).GetValue(exportProvider), System.Web.UI.Control)
			Dim link As New System.Web.UI.HtmlControls.HtmlGenericControl("A")
			link.Attributes.Add("href", Url)
			For i As Integer = currentCell.Controls.Count - 1 To 0 Step -1
				link.Controls.Add(currentCell.Controls(i))
			Next i
			currentCell.Controls.Add(link)
		End Sub
	End Class
End Namespace
