<!-- default file list -->
*Files to look at*:

* [Default.aspx](./CS/Default.aspx) (VB: [Default.aspx](./VB/Default.aspx))
* [Default.aspx.cs](./CS/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/Default.aspx.vb))
* [XtraReport1.cs](./CS/XtraReport1.cs) (VB: [XtraReport1.vb](./VB/XtraReport1.vb))
<!-- default file list end -->
# How to create a custom hyperlink control
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/e447)**
<!-- run online end -->


<p>This example does not apply to the latest XtraReports version, because with the <strong>16.1</strong> release, the corresponding functionality has become available out of the box. The current solution for this task is described in the following thread: <a href="https://www.devexpress.com/Support/Center/Question/Details/S18322">Export to HTML - Create hyperlinks using the "a href=" tag to avoid security warnings</a>.</p>
<p><br>The following example demonstrates how to create a custom <strong>HyperlinkLabel</strong> control. This control is intended to show hyperlinks on a web page without using JavaScript, as it is done by default in XtraReports. Instead, to show a hyperlink it shows the "a href=" tag to avoid security warnings.</p>

<br/>


