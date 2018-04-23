using System;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;
// ...

namespace WindowsApplication12 {
    public partial class XtraReport1 : DevExpress.XtraReports.UI.XtraReport {
        public XtraReport1() {
            InitializeComponent();
        }

        public int currentPage;

        private void xrLabel2_PrintOnPage(object sender, PrintOnPageEventArgs e) {
            currentPage = e.PageIndex;
        }

    }
}