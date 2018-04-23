<%@ Page Language="vb" AutoEventWireup="true" CodeBehind="Default.aspx.vb" Inherits="CustomControl_HyperlinkLabel._Default" %>

<%@ Register Assembly="DevExpress.XtraReports.v8.1.Web, Version=8.1.7.0, Culture=neutral, PublicKeyToken=9b171c9fd64da1d1"
	Namespace="DevExpress.XtraReports.Web" TagPrefix="dxxr" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
	<title>Untitled Page</title>
</head>
<body>
	<form id="form1" runat="server">
	<div>
		<dxxr:reporttoolbar id="ReportToolbar1" runat="server" reportviewer="<%#ReportViewer1%>"
			showdefaultbuttons="False">
<Styles>
<LabelStyle>
<Margins MarginLeft="3px" MarginRight="3px"></Margins>
</LabelStyle>
</Styles>
<Items>
<dxxr:ReportToolbarButton ItemKind="Search" ToolTip="Display the search window"></dxxr:ReportToolbarButton>
<dxxr:ReportToolbarSeparator></dxxr:ReportToolbarSeparator>
<dxxr:ReportToolbarButton ItemKind="PrintReport" ToolTip="Print the report"></dxxr:ReportToolbarButton>
<dxxr:ReportToolbarButton ItemKind="PrintPage" ToolTip="Print the current page"></dxxr:ReportToolbarButton>
<dxxr:ReportToolbarSeparator></dxxr:ReportToolbarSeparator>
<dxxr:ReportToolbarButton Enabled="False" ItemKind="FirstPage" ToolTip="First Page"></dxxr:ReportToolbarButton>
<dxxr:ReportToolbarButton Enabled="False" ItemKind="PreviousPage" ToolTip="Previous Page"></dxxr:ReportToolbarButton>
<dxxr:ReportToolbarLabel Text="Page"></dxxr:ReportToolbarLabel>
<dxxr:ReportToolbarComboBox Width="65px" ItemKind="PageNumber"></dxxr:ReportToolbarComboBox>
<dxxr:ReportToolbarLabel Text="of"></dxxr:ReportToolbarLabel>
<dxxr:ReportToolbarTextBox IsReadOnly="True" ItemKind="PageCount"></dxxr:ReportToolbarTextBox>
<dxxr:ReportToolbarButton ItemKind="NextPage" ToolTip="Next Page"></dxxr:ReportToolbarButton>
<dxxr:ReportToolbarButton ItemKind="LastPage" ToolTip="Last Page"></dxxr:ReportToolbarButton>
<dxxr:ReportToolbarSeparator></dxxr:ReportToolbarSeparator>
<dxxr:ReportToolbarButton ItemKind="SaveToDisk" ToolTip="Export a report and save it to the disk"></dxxr:ReportToolbarButton>
<dxxr:ReportToolbarButton ItemKind="SaveToWindow" ToolTip="Export a report and show it in a new window"></dxxr:ReportToolbarButton>
<dxxr:ReportToolbarComboBox Width="70px" ItemKind="SaveFormat"><Elements>
<dxxr:ListElement Text="Pdf" Value="pdf"></dxxr:ListElement>
<dxxr:ListElement Text="Xls" Value="xls"></dxxr:ListElement>
<dxxr:ListElement Text="Rtf" Value="rtf"></dxxr:ListElement>
<dxxr:ListElement Text="Mht" Value="mht"></dxxr:ListElement>
<dxxr:ListElement Text="Text" Value="txt"></dxxr:ListElement>
<dxxr:ListElement Text="Csv" Value="csv"></dxxr:ListElement>
<dxxr:ListElement Text="Image" Value="png"></dxxr:ListElement>
</Elements>
</dxxr:ReportToolbarComboBox>
</Items>
</dxxr:reporttoolbar>
		<br />
		<br />
		<dxxr:reportviewer id="ReportViewer1" runat="server" height="309px" report="<%#New CustomControl_HyperlinkLabel.XtraReport1()%>"
			reportname="CustomControl_HyperlinkLabel.XtraReport1" width="544px"></dxxr:reportviewer>
		&nbsp;</div>
	</form>
</body>
</html>
