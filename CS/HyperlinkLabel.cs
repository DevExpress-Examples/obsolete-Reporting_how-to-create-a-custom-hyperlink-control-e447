using System.Reflection;
using DevExpress.XtraReports.UI;
using DevExpress.XtraPrinting;
using DevExpress.XtraPrinting.Native;
using DevExpress.XtraPrinting.Export;

namespace CustomControl_HyperlinkLabel {
    public class HyperlinkLabel : XRLabel {
        protected override VisualBrick CreateBrick(VisualBrick[] childrenBricks) {
            return new CustomLabelBrick(this);
        }
    }
    public class CustomLabelBrick : LabelBrick {
        const string brickType = "CustomLabelBrick";
        static CustomLabelBrick() {
            BrickFactory.RegisterFactory(brickType, new DefaultBrickFactory<CustomLabelBrick>());
        }
        public CustomLabelBrick()
            : base() {
        }
        public CustomLabelBrick(IBrickOwner owner)
            : base(owner) {
        }
        protected override void FillHtmlTableCellInternal(IHtmlExportProvider exportProvider) {
            FillHtmlTableCellCore(exportProvider);
            if (!string.IsNullOrEmpty(Url))
                SetHTMLLink(exportProvider);
            exportProvider.SetAnchor(AnchorName);
            exportProvider.RaiseHtmlItemCreated(this);
        }
        public override string BrickType {
            get { return brickType; }
        }
        void SetHTMLLink(IHtmlExportProvider exportProvider) {
            System.Web.UI.Control currentCell = (System.Web.UI.Control)exportProvider.GetType().GetField("currentCell", BindingFlags.Instance | BindingFlags.NonPublic).GetValue(exportProvider);
            System.Web.UI.HtmlControls.HtmlGenericControl link = new System.Web.UI.HtmlControls.HtmlGenericControl("A");
            link.Attributes.Add("href", Url);
            for (int i = currentCell.Controls.Count - 1; i >= 0; i--)
                link.Controls.Add(currentCell.Controls[i]);
            currentCell.Controls.Add(link);
        }
    }
}
