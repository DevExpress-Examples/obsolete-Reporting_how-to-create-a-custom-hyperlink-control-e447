using DevExpress.XtraReports.UI;

namespace CustomControl_HyperlinkLabel {
    public partial class XtraReport1 : XtraReport {
        public XtraReport1() {
            InitializeComponent();
        }

        private void XtraReport1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e) {
            HyperlinkLabel label = new HyperlinkLabel();
            label.Text = "Right-click me!";
            label.Width = 500;
            label.NavigateUrl = "http://www.devexpress.com";
            this.Detail.Controls.Add(label);
        }
    }

}
