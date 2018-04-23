using System;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;
// ...

namespace WindowsApplication12 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            XtraReport1 detailReport = new XtraReport1();
            detailReport.CreateDocument();

            XtraReport2 masterReport = new XtraReport2();
            masterReport.CreateDocument();
            masterReport.PrintingSystem.Pages.RemoveAt(detailReport.currentPage);

            ReportPrintTool printTool = new ReportPrintTool(masterReport);
            printTool.ShowPreview();
        }

    }
}