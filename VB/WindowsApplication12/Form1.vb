Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraReports.UI
' ...

Namespace WindowsApplication12
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			Dim detailReport As New XtraReport1()
			detailReport.CreateDocument()

			Dim masterReport As New XtraReport2()
			masterReport.CreateDocument()
			masterReport.PrintingSystem.Pages.RemoveAt(detailReport.currentPage)

			Dim printTool As New ReportPrintTool(masterReport)
			printTool.ShowPreview()
		End Sub

	End Class
End Namespace