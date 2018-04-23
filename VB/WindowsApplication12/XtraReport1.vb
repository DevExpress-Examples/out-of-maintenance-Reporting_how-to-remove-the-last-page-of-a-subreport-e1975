Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraReports.UI
' ...

Namespace WindowsApplication12
	Partial Public Class XtraReport1
		Inherits DevExpress.XtraReports.UI.XtraReport
		Public Sub New()
			InitializeComponent()
		End Sub

		Public currentPage As Integer

		Private Sub xrLabel2_PrintOnPage(ByVal sender As Object, ByVal e As PrintOnPageEventArgs) Handles xrLabel2.PrintOnPage
			currentPage = e.PageIndex
		End Sub

	End Class
End Namespace
