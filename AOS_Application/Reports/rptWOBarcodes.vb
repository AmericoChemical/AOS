Imports AOS.BusinessObjects

Public Class rptWOBarcodes


#Region "Report Instantiation and Data Acquisition"
    Public Sub New(ByVal vID As Integer)
        MyBase.New()
        'This call is required by the Designer.
        InitializeComponent()
        'Add any initialization after the InitializeComponent() call
        getdata(vID)
    End Sub

    Private Sub getdata(ByVal vID As Integer)

        Dim obj As New ViewRptWorkOrderCollection
        obj.Query.Where(obj.Query.Workordernumber.Equal(vID))
        If Not obj.Query.Load Then
            MsgBox("Error retrieving report data", MsgBoxStyle.Critical, "Error")
            Me.ClosePreview()
        End If

        Me.bsRpt.DataSource = obj

    End Sub
#End Region




End Class