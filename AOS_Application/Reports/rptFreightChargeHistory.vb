Imports DevExpress.XtraReports

Public Class rptFreightChargeHistory
    Public vLoadId As Integer
    Public vMatchingLoads As List(Of Integer)

    Public Sub New(ByVal vID As Integer, ByVal vMatchingLoadIds As List(Of Integer))
        MyBase.New()
        'This call is required by the Designer.
        InitializeComponent()
        'Add any initialization after the InitializeComponent() call

        vLoadId = vID
        vMatchingLoads = vMatchingLoadIds
        getdata()
    End Sub

    Private Sub getdata()

        Dim oLoad As New ViewLoadInfoCollection
        oLoad.Query.Where(oLoad.Query.LoadID.Equal(vLoadId))
        If Not oLoad.Query.Load Then
            MsgBox("Error retrieving Load Data", MsgBoxStyle.Critical, "Error")
            Me.ClosePreview()
        End If
        bsLoadInfo.DataSource = oLoad

        If (vMatchingLoads.Count > 0) Then
            Dim oMatchingLoads As New ViewLoadInfoCollection
            oMatchingLoads.Query.Where(oMatchingLoads.Query.LoadID.In(vMatchingLoads.ToArray()))
            oMatchingLoads.Query.Load()
            bsMatchingLoadInfo.DataSource = oMatchingLoads
        End If

        Dim oQuotes = New ViewLoadQuoteDataCollection
        oQuotes.Query.Where(oQuotes.Query.LoadID.Equal(vLoadId))
        oQuotes.Query.Load()
        DetailReport.DataSource = oQuotes
    End Sub

End Class