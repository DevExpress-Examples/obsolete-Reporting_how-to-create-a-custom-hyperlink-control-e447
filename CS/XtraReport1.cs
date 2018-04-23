using DevExpress.XtraReports.UI;
using System.Web.UI;
using System.Web.UI.HtmlControls;

namespace CustomControl_HyperlinkLabel {
    public partial class XtraReport1 : XtraReport {
        public XtraReport1() {
            InitializeComponent();
        }

        private void xrLabel1_HtmlItemCreated(object sender, HtmlEventArgs e) {
            HtmlTableCell currentCell = (HtmlTableCell)e.ContentCell;
            HtmlAnchor link = new HtmlAnchor();
            link.HRef = ((XRLabel)sender).NavigateUrl;
            link.InnerText = e.Brick.Text;
            currentCell.Controls.Clear();
            currentCell.Controls.Add(link);
            currentCell.Attributes.Remove("onmousedown");
            currentCell.Attributes.CssStyle.Remove("cursor");
        }
    }
}
