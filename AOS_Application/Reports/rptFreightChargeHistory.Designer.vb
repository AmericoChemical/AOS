﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rptFreightChargeHistory
    Inherits DevExpress.XtraReports.UI.XtraReport

    'XtraReport overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim XrSummary1 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary2 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand()
        Me.XrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.ReportFooter = New DevExpress.XtraReports.UI.ReportFooterBand()
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrCurrentPlannedDepartureDate = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel23 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrCurrentTotalGrossWeight = New DevExpress.XtraReports.UI.XRLabel()
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
        Me.XrCurrentFreezeProtect = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel11 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrCurrentTotalSkids = New DevExpress.XtraReports.UI.XRLabel()
        Me.calcFreezeProtectionValue = New DevExpress.XtraReports.UI.CalculatedField()
        Me.Detail1 = New DevExpress.XtraReports.UI.DetailBand()
        Me.XrLabel26 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel25 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel24 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel22 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel21 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel20 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel19 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrCurrentCarrierName = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel15 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel14 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel10 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel9 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.DetailReport = New DevExpress.XtraReports.UI.DetailReportBand()
        Me.ReportHeader1 = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.XrLabel12 = New DevExpress.XtraReports.UI.XRLabel()
        Me.DetailReport1 = New DevExpress.XtraReports.UI.DetailReportBand()
        Me.Detail2 = New DevExpress.XtraReports.UI.DetailBand()
        Me.XrLabel28 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel27 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel39 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel38 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrMarchingTotalSkids = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrMatchingTotalGrossWeight = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel31 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrlShippingDate = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel18 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrMatchingTotalCharged = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel40 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel43 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrMatchingTotalBilled = New DevExpress.XtraReports.UI.XRLabel()
        Me.xlMatchingFreezeProtect = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrMatchingCarrierName = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel16 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel13 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.ReportHeader2 = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.XrLabel44 = New DevExpress.XtraReports.UI.XRLabel()
        Me.calcQuoteFreezeProtect = New DevExpress.XtraReports.UI.CalculatedField()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.bsMatchingLoadInfo = New System.Windows.Forms.BindingSource(Me.components)
        Me.bsLoadInfo = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsMatchingLoadInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsLoadInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.BorderColor = System.Drawing.Color.Beige
        Me.Detail.HeightF = 0!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.SortFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("Hazmatid", DevExpress.XtraReports.UI.XRColumnSortOrder.Descending), New DevExpress.XtraReports.UI.GroupField("ItemType", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending), New DevExpress.XtraReports.UI.GroupField("ItemID", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.Detail.StylePriority.UseBorderColor = False
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'TopMargin
        '
        Me.TopMargin.HeightF = 50.0!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'BottomMargin
        '
        Me.BottomMargin.HeightF = 50.0!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'ReportHeader
        '
        Me.ReportHeader.HeightF = 0!
        Me.ReportHeader.Name = "ReportHeader"
        '
        'PageFooter
        '
        Me.PageFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPageInfo1})
        Me.PageFooter.HeightF = 31.25!
        Me.PageFooter.Name = "PageFooter"
        '
        'XrPageInfo1
        '
        Me.XrPageInfo1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrPageInfo1.Format = "{0:M/d/yyyy h:mm tt}"
        Me.XrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(315.0626!, 0!)
        Me.XrPageInfo1.Name = "XrPageInfo1"
        Me.XrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrPageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
        Me.XrPageInfo1.SizeF = New System.Drawing.SizeF(116.8334!, 23.0!)
        Me.XrPageInfo1.StylePriority.UseFont = False
        Me.XrPageInfo1.StylePriority.UseTextAlignment = False
        Me.XrPageInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomRight
        '
        'ReportFooter
        '
        Me.ReportFooter.HeightF = 0!
        Me.ReportFooter.Name = "ReportFooter"
        '
        'XrLabel4
        '
        Me.XrLabel4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(34.47921!, 26.37501!)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(120.7502!, 18.0!)
        Me.XrLabel4.StylePriority.UseFont = False
        Me.XrLabel4.StylePriority.UseTextAlignment = False
        Me.XrLabel4.Text = "Shipping Date:"
        Me.XrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrCurrentPlannedDepartureDate
        '
        Me.XrCurrentPlannedDepartureDate.CanGrow = False
        Me.XrCurrentPlannedDepartureDate.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "PlannedDepartureDate", "{0:MM/dd/yyyy}")})
        Me.XrCurrentPlannedDepartureDate.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.XrCurrentPlannedDepartureDate.LocationFloat = New DevExpress.Utils.PointFloat(160.9585!, 26.37501!)
        Me.XrCurrentPlannedDepartureDate.Name = "XrCurrentPlannedDepartureDate"
        Me.XrCurrentPlannedDepartureDate.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrCurrentPlannedDepartureDate.SizeF = New System.Drawing.SizeF(292.2917!, 18.0!)
        Me.XrCurrentPlannedDepartureDate.StylePriority.UseFont = False
        Me.XrCurrentPlannedDepartureDate.StylePriority.UseTextAlignment = False
        Me.XrCurrentPlannedDepartureDate.Text = "XrCurrentPlannedDepartureDate"
        Me.XrCurrentPlannedDepartureDate.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrCurrentPlannedDepartureDate.WordWrap = False
        '
        'XrLabel23
        '
        Me.XrLabel23.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel23.LocationFloat = New DevExpress.Utils.PointFloat(34.47921!, 45.97394!)
        Me.XrLabel23.Name = "XrLabel23"
        Me.XrLabel23.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel23.SizeF = New System.Drawing.SizeF(120.7502!, 18.0!)
        Me.XrLabel23.StylePriority.UseFont = False
        Me.XrLabel23.StylePriority.UseTextAlignment = False
        Me.XrLabel23.Text = "Load Weight:"
        Me.XrLabel23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrCurrentTotalGrossWeight
        '
        Me.XrCurrentTotalGrossWeight.CanGrow = False
        Me.XrCurrentTotalGrossWeight.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "TotalGrossWeight", "{0:#,#}")})
        Me.XrCurrentTotalGrossWeight.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.XrCurrentTotalGrossWeight.LocationFloat = New DevExpress.Utils.PointFloat(160.9585!, 45.97394!)
        Me.XrCurrentTotalGrossWeight.Name = "XrCurrentTotalGrossWeight"
        Me.XrCurrentTotalGrossWeight.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrCurrentTotalGrossWeight.SizeF = New System.Drawing.SizeF(292.2917!, 18.0!)
        Me.XrCurrentTotalGrossWeight.StylePriority.UseFont = False
        Me.XrCurrentTotalGrossWeight.StylePriority.UseTextAlignment = False
        Me.XrCurrentTotalGrossWeight.Text = "XrCurrentTotalGrossWeight"
        Me.XrCurrentTotalGrossWeight.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrCurrentTotalGrossWeight.WordWrap = False
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrCurrentFreezeProtect, Me.XrLabel1, Me.XrLabel11, Me.XrLabel8, Me.XrCurrentTotalSkids, Me.XrCurrentTotalGrossWeight, Me.XrLabel23, Me.XrCurrentPlannedDepartureDate, Me.XrLabel4})
        Me.PageHeader.HeightF = 115.0209!
        Me.PageHeader.Name = "PageHeader"
        '
        'XrCurrentFreezeProtect
        '
        Me.XrCurrentFreezeProtect.CanGrow = False
        Me.XrCurrentFreezeProtect.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "calcFreezeProtectionValue", "{0:#,#}")})
        Me.XrCurrentFreezeProtect.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.XrCurrentFreezeProtect.LocationFloat = New DevExpress.Utils.PointFloat(160.9585!, 85.17186!)
        Me.XrCurrentFreezeProtect.Name = "XrCurrentFreezeProtect"
        Me.XrCurrentFreezeProtect.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrCurrentFreezeProtect.SizeF = New System.Drawing.SizeF(292.2917!, 18.0!)
        Me.XrCurrentFreezeProtect.StylePriority.UseFont = False
        Me.XrCurrentFreezeProtect.StylePriority.UseTextAlignment = False
        Me.XrCurrentFreezeProtect.Text = "XrLabel22"
        Me.XrCurrentFreezeProtect.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrCurrentFreezeProtect.Visible = False
        Me.XrCurrentFreezeProtect.WordWrap = False
        '
        'XrLabel1
        '
        Me.XrLabel1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(11.56247!, 4.208342!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(479.7085!, 18.0!)
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.Text = "Current Load "
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel11
        '
        Me.XrLabel11.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel11.LocationFloat = New DevExpress.Utils.PointFloat(34.47921!, 85.17186!)
        Me.XrLabel11.Name = "XrLabel11"
        Me.XrLabel11.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel11.SizeF = New System.Drawing.SizeF(120.7502!, 18.0!)
        Me.XrLabel11.StylePriority.UseFont = False
        Me.XrLabel11.StylePriority.UseTextAlignment = False
        Me.XrLabel11.Text = "Freeze Protect:"
        Me.XrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrLabel11.Visible = False
        '
        'XrLabel8
        '
        Me.XrLabel8.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(36.04167!, 65.5729!)
        Me.XrLabel8.Name = "XrLabel8"
        Me.XrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel8.SizeF = New System.Drawing.SizeF(120.7502!, 18.0!)
        Me.XrLabel8.StylePriority.UseFont = False
        Me.XrLabel8.StylePriority.UseTextAlignment = False
        Me.XrLabel8.Text = "Skids:"
        Me.XrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrCurrentTotalSkids
        '
        Me.XrCurrentTotalSkids.CanGrow = False
        Me.XrCurrentTotalSkids.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "TotalSkids", "{0:#,#}")})
        Me.XrCurrentTotalSkids.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.XrCurrentTotalSkids.LocationFloat = New DevExpress.Utils.PointFloat(160.9585!, 65.5729!)
        Me.XrCurrentTotalSkids.Name = "XrCurrentTotalSkids"
        Me.XrCurrentTotalSkids.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrCurrentTotalSkids.SizeF = New System.Drawing.SizeF(292.2917!, 18.0!)
        Me.XrCurrentTotalSkids.StylePriority.UseFont = False
        Me.XrCurrentTotalSkids.StylePriority.UseTextAlignment = False
        Me.XrCurrentTotalSkids.Text = "XrLabel22"
        Me.XrCurrentTotalSkids.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrCurrentTotalSkids.WordWrap = False
        '
        'calcFreezeProtectionValue
        '
        Me.calcFreezeProtectionValue.DataSource = Me.bsMatchingLoadInfo
        Me.calcFreezeProtectionValue.Expression = "Iif(IsNull([FreezeProtectFlag]),'Undefined',Iif([FreezeProtectFlag],'Yes','No'))"
        Me.calcFreezeProtectionValue.Name = "calcFreezeProtectionValue"
        '
        'Detail1
        '
        Me.Detail1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel26, Me.XrLabel25, Me.XrLabel24, Me.XrLabel22, Me.XrLabel21, Me.XrLabel20, Me.XrLabel19, Me.xrCurrentCarrierName, Me.XrLabel15, Me.XrLabel14, Me.XrLabel10, Me.XrLabel9, Me.XrLabel6})
        Me.Detail1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Detail1.HeightF = 142.7342!
        Me.Detail1.Name = "Detail1"
        Me.Detail1.StylePriority.UseFont = False
        '
        'XrLabel26
        '
        Me.XrLabel26.CanGrow = False
        Me.XrLabel26.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "FreezeProtectDesc", "{0:#,#}")})
        Me.XrLabel26.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.XrLabel26.LocationFloat = New DevExpress.Utils.PointFloat(160.9585!, 111.5337!)
        Me.XrLabel26.Name = "XrLabel26"
        Me.XrLabel26.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel26.SizeF = New System.Drawing.SizeF(292.2917!, 21.20046!)
        Me.XrLabel26.StylePriority.UseFont = False
        Me.XrLabel26.StylePriority.UseTextAlignment = False
        Me.XrLabel26.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrLabel26.WordWrap = False
        '
        'XrLabel25
        '
        Me.XrLabel25.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel25.LocationFloat = New DevExpress.Utils.PointFloat(36.04167!, 111.5337!)
        Me.XrLabel25.Name = "XrLabel25"
        Me.XrLabel25.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel25.SizeF = New System.Drawing.SizeF(120.7502!, 21.20046!)
        Me.XrLabel25.StylePriority.UseFont = False
        Me.XrLabel25.StylePriority.UseTextAlignment = False
        Me.XrLabel25.Text = "Freeze Protect:"
        Me.XrLabel25.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel24
        '
        Me.XrLabel24.CanGrow = False
        Me.XrLabel24.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "EquipmentCost", "{0:#.00}")})
        Me.XrLabel24.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.XrLabel24.LocationFloat = New DevExpress.Utils.PointFloat(162.521!, 89.22704!)
        Me.XrLabel24.Name = "XrLabel24"
        Me.XrLabel24.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel24.SizeF = New System.Drawing.SizeF(292.2917!, 21.20046!)
        Me.XrLabel24.StylePriority.UseFont = False
        Me.XrLabel24.StylePriority.UseTextAlignment = False
        Me.XrLabel24.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrLabel24.WordWrap = False
        '
        'XrLabel22
        '
        Me.XrLabel22.CanGrow = False
        Me.XrLabel22.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "EmptyCost", "{0:#.00}")})
        Me.XrLabel22.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.XrLabel22.LocationFloat = New DevExpress.Utils.PointFloat(160.9585!, 66.92022!)
        Me.XrLabel22.Name = "XrLabel22"
        Me.XrLabel22.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel22.SizeF = New System.Drawing.SizeF(292.2917!, 21.20046!)
        Me.XrLabel22.StylePriority.UseFont = False
        Me.XrLabel22.StylePriority.UseTextAlignment = False
        Me.XrLabel22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrLabel22.WordWrap = False
        '
        'XrLabel21
        '
        Me.XrLabel21.AutoWidth = True
        Me.XrLabel21.CanGrow = False
        Me.XrLabel21.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "LoadQuoteID")})
        Me.XrLabel21.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.XrLabel21.LocationFloat = New DevExpress.Utils.PointFloat(9.999962!, 0!)
        Me.XrLabel21.Name = "XrLabel21"
        Me.XrLabel21.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel21.SizeF = New System.Drawing.SizeF(21.35422!, 18.0!)
        Me.XrLabel21.StylePriority.UseFont = False
        Me.XrLabel21.StylePriority.UseTextAlignment = False
        XrSummary1.FormatString = "{0:##.}"
        XrSummary1.Func = DevExpress.XtraReports.UI.SummaryFunc.RecordNumber
        XrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.XrLabel21.Summary = XrSummary1
        Me.XrLabel21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrLabel21.WordWrap = False
        '
        'XrLabel20
        '
        Me.XrLabel20.CanGrow = False
        Me.XrLabel20.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "QuoteDate", "{0:MM/dd/yyyy}")})
        Me.XrLabel20.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.XrLabel20.LocationFloat = New DevExpress.Utils.PointFloat(160.9585!, 22.30673!)
        Me.XrLabel20.Name = "XrLabel20"
        Me.XrLabel20.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel20.SizeF = New System.Drawing.SizeF(292.2917!, 21.20046!)
        Me.XrLabel20.StylePriority.UseFont = False
        Me.XrLabel20.StylePriority.UseTextAlignment = False
        Me.XrLabel20.Text = "XrLabel22"
        Me.XrLabel20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrLabel20.WordWrap = False
        '
        'XrLabel19
        '
        Me.XrLabel19.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel19.LocationFloat = New DevExpress.Utils.PointFloat(34.47914!, 44.61349!)
        Me.XrLabel19.Name = "XrLabel19"
        Me.XrLabel19.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel19.SizeF = New System.Drawing.SizeF(120.7502!, 21.20046!)
        Me.XrLabel19.StylePriority.UseFont = False
        Me.XrLabel19.StylePriority.UseTextAlignment = False
        Me.XrLabel19.Text = "Price:"
        Me.XrLabel19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'xrCurrentCarrierName
        '
        Me.xrCurrentCarrierName.CanGrow = False
        Me.xrCurrentCarrierName.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CarrierName", "{0:#,#}")})
        Me.xrCurrentCarrierName.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.xrCurrentCarrierName.LocationFloat = New DevExpress.Utils.PointFloat(160.9585!, 0!)
        Me.xrCurrentCarrierName.Name = "xrCurrentCarrierName"
        Me.xrCurrentCarrierName.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrCurrentCarrierName.SizeF = New System.Drawing.SizeF(292.2917!, 21.20046!)
        Me.xrCurrentCarrierName.StylePriority.UseFont = False
        Me.xrCurrentCarrierName.StylePriority.UseTextAlignment = False
        Me.xrCurrentCarrierName.Text = "XrLabel22"
        Me.xrCurrentCarrierName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.xrCurrentCarrierName.WordWrap = False
        '
        'XrLabel15
        '
        Me.XrLabel15.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel15.LocationFloat = New DevExpress.Utils.PointFloat(34.47914!, 22.30673!)
        Me.XrLabel15.Name = "XrLabel15"
        Me.XrLabel15.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel15.SizeF = New System.Drawing.SizeF(120.7502!, 21.20046!)
        Me.XrLabel15.StylePriority.UseFont = False
        Me.XrLabel15.StylePriority.UseTextAlignment = False
        Me.XrLabel15.Text = "Date:"
        Me.XrLabel15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel14
        '
        Me.XrLabel14.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel14.LocationFloat = New DevExpress.Utils.PointFloat(36.04161!, 89.22704!)
        Me.XrLabel14.Name = "XrLabel14"
        Me.XrLabel14.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel14.SizeF = New System.Drawing.SizeF(120.7502!, 21.20046!)
        Me.XrLabel14.StylePriority.UseFont = False
        Me.XrLabel14.StylePriority.UseTextAlignment = False
        Me.XrLabel14.Text = "Equipment Cost:"
        Me.XrLabel14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel10
        '
        Me.XrLabel10.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel10.LocationFloat = New DevExpress.Utils.PointFloat(57.39587!, 0!)
        Me.XrLabel10.Name = "XrLabel10"
        Me.XrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel10.SizeF = New System.Drawing.SizeF(97.83353!, 21.20046!)
        Me.XrLabel10.StylePriority.UseFont = False
        Me.XrLabel10.StylePriority.UseTextAlignment = False
        Me.XrLabel10.Text = "Carrier:"
        Me.XrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel9
        '
        Me.XrLabel9.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(34.47914!, 66.92022!)
        Me.XrLabel9.Name = "XrLabel9"
        Me.XrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel9.SizeF = New System.Drawing.SizeF(120.7502!, 21.20046!)
        Me.XrLabel9.StylePriority.UseFont = False
        Me.XrLabel9.StylePriority.UseTextAlignment = False
        Me.XrLabel9.Text = "Empty Cost:"
        Me.XrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel6
        '
        Me.XrLabel6.CanGrow = False
        Me.XrLabel6.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "QuoteAmount", "{0:#,#}")})
        Me.XrLabel6.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.XrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(160.9585!, 44.61349!)
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel6.SizeF = New System.Drawing.SizeF(292.2917!, 21.20046!)
        Me.XrLabel6.StylePriority.UseFont = False
        Me.XrLabel6.StylePriority.UseTextAlignment = False
        Me.XrLabel6.Text = "XrLabel22"
        Me.XrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrLabel6.WordWrap = False
        '
        'DetailReport
        '
        Me.DetailReport.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail1, Me.ReportHeader1})
        Me.DetailReport.DataSource = Me.BindingSource1
        Me.DetailReport.Level = 0
        Me.DetailReport.Name = "DetailReport"
        '
        'ReportHeader1
        '
        Me.ReportHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel12})
        Me.ReportHeader1.HeightF = 21.66667!
        Me.ReportHeader1.Name = "ReportHeader1"
        '
        'XrLabel12
        '
        Me.XrLabel12.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel12.LocationFloat = New DevExpress.Utils.PointFloat(9.999974!, 3.666655!)
        Me.XrLabel12.Name = "XrLabel12"
        Me.XrLabel12.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel12.SizeF = New System.Drawing.SizeF(441.6878!, 18.0!)
        Me.XrLabel12.StylePriority.UseFont = False
        Me.XrLabel12.Text = "Quote(s)"
        Me.XrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'DetailReport1
        '
        Me.DetailReport1.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail2, Me.ReportHeader2})
        Me.DetailReport1.DataSource = Me.bsMatchingLoadInfo
        Me.DetailReport1.Level = 1
        Me.DetailReport1.Name = "DetailReport1"
        '
        'Detail2
        '
        Me.Detail2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel28, Me.XrLabel27, Me.XrLabel39, Me.XrLabel38, Me.xrMarchingTotalSkids, Me.xrMatchingTotalGrossWeight, Me.XrLabel31, Me.xrlShippingDate, Me.XrLabel18, Me.xrMatchingTotalCharged, Me.XrLabel40, Me.XrLabel43, Me.xrMatchingTotalBilled, Me.xlMatchingFreezeProtect, Me.XrMatchingCarrierName, Me.XrLabel7, Me.XrLabel16, Me.XrLabel13, Me.XrLabel3, Me.XrLabel5})
        Me.Detail2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Detail2.HeightF = 188.4165!
        Me.Detail2.Name = "Detail2"
        Me.Detail2.StylePriority.UseFont = False
        '
        'XrLabel28
        '
        Me.XrLabel28.CanGrow = False
        Me.XrLabel28.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.XrLabel28.LocationFloat = New DevExpress.Utils.PointFloat(162.5211!, 161.4398!)
        Me.XrLabel28.Name = "XrLabel28"
        Me.XrLabel28.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel28.SizeF = New System.Drawing.SizeF(292.2917!, 18.0!)
        Me.XrLabel28.StylePriority.UseFont = False
        Me.XrLabel28.StylePriority.UseTextAlignment = False
        Me.XrLabel28.Text = ".00"
        Me.XrLabel28.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrLabel28.WordWrap = False
        '
        'XrLabel27
        '
        Me.XrLabel27.CanGrow = False
        Me.XrLabel27.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.XrLabel27.LocationFloat = New DevExpress.Utils.PointFloat(162.5211!, 141.9723!)
        Me.XrLabel27.Name = "XrLabel27"
        Me.XrLabel27.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel27.SizeF = New System.Drawing.SizeF(292.2917!, 18.0!)
        Me.XrLabel27.StylePriority.UseFont = False
        Me.XrLabel27.StylePriority.UseTextAlignment = False
        Me.XrLabel27.Text = ".00"
        Me.XrLabel27.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrLabel27.WordWrap = False
        '
        'XrLabel39
        '
        Me.XrLabel39.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel39.LocationFloat = New DevExpress.Utils.PointFloat(36.04167!, 61.60189!)
        Me.XrLabel39.Name = "XrLabel39"
        Me.XrLabel39.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel39.SizeF = New System.Drawing.SizeF(120.7502!, 18.0!)
        Me.XrLabel39.StylePriority.UseFont = False
        Me.XrLabel39.StylePriority.UseTextAlignment = False
        Me.XrLabel39.Text = "Freeze Protect:"
        Me.XrLabel39.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel38
        '
        Me.XrLabel38.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel38.LocationFloat = New DevExpress.Utils.PointFloat(36.04167!, 41.50931!)
        Me.XrLabel38.Name = "XrLabel38"
        Me.XrLabel38.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel38.SizeF = New System.Drawing.SizeF(120.7502!, 18.0!)
        Me.XrLabel38.StylePriority.UseFont = False
        Me.XrLabel38.StylePriority.UseTextAlignment = False
        Me.XrLabel38.Text = "Skids:"
        Me.XrLabel38.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'xrMarchingTotalSkids
        '
        Me.xrMarchingTotalSkids.CanGrow = False
        Me.xrMarchingTotalSkids.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "TotalSkids", "{0:#,#}")})
        Me.xrMarchingTotalSkids.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.xrMarchingTotalSkids.LocationFloat = New DevExpress.Utils.PointFloat(162.5211!, 41.50931!)
        Me.xrMarchingTotalSkids.Name = "xrMarchingTotalSkids"
        Me.xrMarchingTotalSkids.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrMarchingTotalSkids.SizeF = New System.Drawing.SizeF(292.2917!, 18.0!)
        Me.xrMarchingTotalSkids.StylePriority.UseFont = False
        Me.xrMarchingTotalSkids.StylePriority.UseTextAlignment = False
        Me.xrMarchingTotalSkids.Text = "XrLabel22"
        Me.xrMarchingTotalSkids.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.xrMarchingTotalSkids.WordWrap = False
        '
        'xrMatchingTotalGrossWeight
        '
        Me.xrMatchingTotalGrossWeight.CanGrow = False
        Me.xrMatchingTotalGrossWeight.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "TotalGrossWeight", "{0:#,#}")})
        Me.xrMatchingTotalGrossWeight.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.xrMatchingTotalGrossWeight.LocationFloat = New DevExpress.Utils.PointFloat(162.5211!, 21.41673!)
        Me.xrMatchingTotalGrossWeight.Name = "xrMatchingTotalGrossWeight"
        Me.xrMatchingTotalGrossWeight.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrMatchingTotalGrossWeight.SizeF = New System.Drawing.SizeF(292.2917!, 18.0!)
        Me.xrMatchingTotalGrossWeight.StylePriority.UseFont = False
        Me.xrMatchingTotalGrossWeight.StylePriority.UseTextAlignment = False
        Me.xrMatchingTotalGrossWeight.Text = "XrLabel22"
        Me.xrMatchingTotalGrossWeight.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.xrMatchingTotalGrossWeight.WordWrap = False
        '
        'XrLabel31
        '
        Me.XrLabel31.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel31.LocationFloat = New DevExpress.Utils.PointFloat(36.04167!, 21.41673!)
        Me.XrLabel31.Name = "XrLabel31"
        Me.XrLabel31.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel31.SizeF = New System.Drawing.SizeF(120.7502!, 18.0!)
        Me.XrLabel31.StylePriority.UseFont = False
        Me.XrLabel31.StylePriority.UseTextAlignment = False
        Me.XrLabel31.Text = "Load Weight:"
        Me.XrLabel31.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'xrlShippingDate
        '
        Me.xrlShippingDate.CanGrow = False
        Me.xrlShippingDate.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ActualShipmentDate", "{0:MM/dd/yyyy}")})
        Me.xrlShippingDate.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.xrlShippingDate.LocationFloat = New DevExpress.Utils.PointFloat(162.5211!, 3.416697!)
        Me.xrlShippingDate.Name = "xrlShippingDate"
        Me.xrlShippingDate.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrlShippingDate.SizeF = New System.Drawing.SizeF(292.2917!, 18.0!)
        Me.xrlShippingDate.StylePriority.UseFont = False
        Me.xrlShippingDate.StylePriority.UseTextAlignment = False
        Me.xrlShippingDate.Text = "XrLabel3"
        Me.xrlShippingDate.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.xrlShippingDate.WordWrap = False
        '
        'XrLabel18
        '
        Me.XrLabel18.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel18.LocationFloat = New DevExpress.Utils.PointFloat(36.04167!, 3.416697!)
        Me.XrLabel18.Name = "XrLabel18"
        Me.XrLabel18.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel18.SizeF = New System.Drawing.SizeF(120.7502!, 18.0!)
        Me.XrLabel18.StylePriority.UseFont = False
        Me.XrLabel18.StylePriority.UseTextAlignment = False
        Me.XrLabel18.Text = "Shipping Date:"
        Me.XrLabel18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'xrMatchingTotalCharged
        '
        Me.xrMatchingTotalCharged.CanGrow = False
        Me.xrMatchingTotalCharged.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "TotalCharged", "{0:#,#}")})
        Me.xrMatchingTotalCharged.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.xrMatchingTotalCharged.LocationFloat = New DevExpress.Utils.PointFloat(162.5211!, 101.7871!)
        Me.xrMatchingTotalCharged.Name = "xrMatchingTotalCharged"
        Me.xrMatchingTotalCharged.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrMatchingTotalCharged.SizeF = New System.Drawing.SizeF(292.2917!, 18.0!)
        Me.xrMatchingTotalCharged.StylePriority.UseFont = False
        Me.xrMatchingTotalCharged.StylePriority.UseTextAlignment = False
        Me.xrMatchingTotalCharged.Text = "XrLabel22"
        Me.xrMatchingTotalCharged.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.xrMatchingTotalCharged.WordWrap = False
        '
        'XrLabel40
        '
        Me.XrLabel40.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel40.LocationFloat = New DevExpress.Utils.PointFloat(36.04167!, 101.7871!)
        Me.XrLabel40.Name = "XrLabel40"
        Me.XrLabel40.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel40.SizeF = New System.Drawing.SizeF(120.7502!, 18.0!)
        Me.XrLabel40.StylePriority.UseFont = False
        Me.XrLabel40.StylePriority.UseTextAlignment = False
        Me.XrLabel40.Text = "Paid:"
        Me.XrLabel40.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel43
        '
        Me.XrLabel43.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel43.LocationFloat = New DevExpress.Utils.PointFloat(36.04167!, 121.8796!)
        Me.XrLabel43.Name = "XrLabel43"
        Me.XrLabel43.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel43.SizeF = New System.Drawing.SizeF(120.7502!, 18.0!)
        Me.XrLabel43.StylePriority.UseFont = False
        Me.XrLabel43.StylePriority.UseTextAlignment = False
        Me.XrLabel43.Text = "Invoiced:"
        Me.XrLabel43.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'xrMatchingTotalBilled
        '
        Me.xrMatchingTotalBilled.CanGrow = False
        Me.xrMatchingTotalBilled.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "TotalBilled", "{0:#,#}")})
        Me.xrMatchingTotalBilled.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.xrMatchingTotalBilled.LocationFloat = New DevExpress.Utils.PointFloat(162.5211!, 121.8796!)
        Me.xrMatchingTotalBilled.Name = "xrMatchingTotalBilled"
        Me.xrMatchingTotalBilled.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrMatchingTotalBilled.SizeF = New System.Drawing.SizeF(292.2917!, 18.0!)
        Me.xrMatchingTotalBilled.StylePriority.UseFont = False
        Me.xrMatchingTotalBilled.StylePriority.UseTextAlignment = False
        Me.xrMatchingTotalBilled.Text = "XrLabel22"
        Me.xrMatchingTotalBilled.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.xrMatchingTotalBilled.WordWrap = False
        '
        'xlMatchingFreezeProtect
        '
        Me.xlMatchingFreezeProtect.CanGrow = False
        Me.xlMatchingFreezeProtect.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "FreezeProtectDesc", "{0:#,#}")})
        Me.xlMatchingFreezeProtect.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.xlMatchingFreezeProtect.LocationFloat = New DevExpress.Utils.PointFloat(162.5211!, 61.60189!)
        Me.xlMatchingFreezeProtect.Name = "xlMatchingFreezeProtect"
        Me.xlMatchingFreezeProtect.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xlMatchingFreezeProtect.SizeF = New System.Drawing.SizeF(292.2917!, 18.0!)
        Me.xlMatchingFreezeProtect.StylePriority.UseFont = False
        Me.xlMatchingFreezeProtect.StylePriority.UseTextAlignment = False
        Me.xlMatchingFreezeProtect.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.xlMatchingFreezeProtect.WordWrap = False
        '
        'XrMatchingCarrierName
        '
        Me.XrMatchingCarrierName.CanGrow = False
        Me.XrMatchingCarrierName.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ScheduledCarrierName", "{0:#,#}")})
        Me.XrMatchingCarrierName.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.XrMatchingCarrierName.LocationFloat = New DevExpress.Utils.PointFloat(162.5211!, 81.69447!)
        Me.XrMatchingCarrierName.Name = "XrMatchingCarrierName"
        Me.XrMatchingCarrierName.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrMatchingCarrierName.SizeF = New System.Drawing.SizeF(292.2917!, 18.0!)
        Me.XrMatchingCarrierName.StylePriority.UseFont = False
        Me.XrMatchingCarrierName.StylePriority.UseTextAlignment = False
        Me.XrMatchingCarrierName.Text = "XrLabel22"
        Me.XrMatchingCarrierName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrMatchingCarrierName.WordWrap = False
        '
        'XrLabel7
        '
        Me.XrLabel7.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(36.04167!, 81.69447!)
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel7.SizeF = New System.Drawing.SizeF(120.7502!, 18.0!)
        Me.XrLabel7.StylePriority.UseFont = False
        Me.XrLabel7.StylePriority.UseTextAlignment = False
        Me.XrLabel7.Text = "Carrier:"
        Me.XrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel16
        '
        Me.XrLabel16.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel16.LocationFloat = New DevExpress.Utils.PointFloat(37.60417!, 161.4398!)
        Me.XrLabel16.Name = "XrLabel16"
        Me.XrLabel16.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel16.SizeF = New System.Drawing.SizeF(120.7502!, 18.0!)
        Me.XrLabel16.StylePriority.UseFont = False
        Me.XrLabel16.StylePriority.UseTextAlignment = False
        Me.XrLabel16.Text = "Equipment Cost:"
        Me.XrLabel16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel13
        '
        Me.XrLabel13.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel13.LocationFloat = New DevExpress.Utils.PointFloat(36.04167!, 141.9723!)
        Me.XrLabel13.Name = "XrLabel13"
        Me.XrLabel13.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel13.SizeF = New System.Drawing.SizeF(120.7502!, 18.0!)
        Me.XrLabel13.StylePriority.UseFont = False
        Me.XrLabel13.StylePriority.UseTextAlignment = False
        Me.XrLabel13.Text = "Empty Cost:"
        Me.XrLabel13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel3
        '
        Me.XrLabel3.AutoWidth = True
        Me.XrLabel3.CanGrow = False
        Me.XrLabel3.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "LoadID")})
        Me.XrLabel3.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(9.999974!, 3.416697!)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(21.35422!, 18.0!)
        Me.XrLabel3.StylePriority.UseFont = False
        Me.XrLabel3.StylePriority.UseTextAlignment = False
        XrSummary2.FormatString = "{0:##.}"
        XrSummary2.Func = DevExpress.XtraReports.UI.SummaryFunc.RecordNumber
        XrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.XrLabel3.Summary = XrSummary2
        Me.XrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrLabel3.WordWrap = False
        '
        'XrLabel5
        '
        Me.XrLabel5.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.XrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(32.91671!, 0!)
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel5.SizeF = New System.Drawing.SizeF(2.083332!, 18.0!)
        Me.XrLabel5.StylePriority.UseFont = False
        Me.XrLabel5.StylePriority.UseTextAlignment = False
        Me.XrLabel5.Text = "."
        Me.XrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft
        '
        'ReportHeader2
        '
        Me.ReportHeader2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel44})
        Me.ReportHeader2.HeightF = 25.83335!
        Me.ReportHeader2.Name = "ReportHeader2"
        '
        'XrLabel44
        '
        Me.XrLabel44.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel44.LocationFloat = New DevExpress.Utils.PointFloat(13.12501!, 0!)
        Me.XrLabel44.Name = "XrLabel44"
        Me.XrLabel44.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel44.SizeF = New System.Drawing.SizeF(506.8749!, 18.0!)
        Me.XrLabel44.StylePriority.UseFont = False
        Me.XrLabel44.Text = "Similar Load(s)"
        Me.XrLabel44.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'calcQuoteFreezeProtect
        '
        Me.calcQuoteFreezeProtect.DataSource = Me.BindingSource1
        Me.calcQuoteFreezeProtect.Expression = "'Yes'"
        Me.calcQuoteFreezeProtect.FieldType = DevExpress.XtraReports.UI.FieldType.[String]
        Me.calcQuoteFreezeProtect.Name = "calcQuoteFreezeProtect"
        '
        'BindingSource1
        '
        Me.BindingSource1.DataSource = GetType(AOS.BusinessObjects.ViewLoadQuoteDataCollection)
        '
        'bsMatchingLoadInfo
        '
        Me.bsMatchingLoadInfo.DataSource = GetType(AOS.BusinessObjects.ViewLoadInfo)
        '
        'bsLoadInfo
        '
        Me.bsLoadInfo.DataSource = GetType(AOS.BusinessObjects.ViewLoadInfoCollection)
        '
        'rptFreightChargeHistory
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.ReportHeader, Me.PageHeader, Me.PageFooter, Me.ReportFooter, Me.DetailReport, Me.DetailReport1})
        Me.CalculatedFields.AddRange(New DevExpress.XtraReports.UI.CalculatedField() {Me.calcFreezeProtectionValue, Me.calcQuoteFreezeProtect})
        Me.DataSource = Me.bsLoadInfo
        Me.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.Margins = New System.Drawing.Printing.Margins(50, 270, 50, 50)
        Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
        Me.Version = "17.1"
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsMatchingLoadInfo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsLoadInfo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents bsLoadInfo As System.Windows.Forms.BindingSource
    Friend WithEvents ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents PageFooter As DevExpress.XtraReports.UI.PageFooterBand
    Friend WithEvents XrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents ReportFooter As DevExpress.XtraReports.UI.ReportFooterBand
    Friend WithEvents XrLabel4 As XRLabel
    Friend WithEvents XrCurrentPlannedDepartureDate As XRLabel
    Friend WithEvents XrLabel23 As XRLabel
    Friend WithEvents XrCurrentTotalGrossWeight As XRLabel
    Friend WithEvents PageHeader As PageHeaderBand
    Friend WithEvents XrLabel11 As XRLabel
    Friend WithEvents XrLabel8 As XRLabel
    Friend WithEvents XrCurrentTotalSkids As XRLabel
    Friend WithEvents bsMatchingLoadInfo As BindingSource
    Friend WithEvents XrCurrentFreezeProtect As XRLabel
    Public WithEvents XrLabel1 As XRLabel
    Friend WithEvents calcFreezeProtectionValue As CalculatedField
    Friend WithEvents Detail1 As DetailBand
    Friend WithEvents xrCurrentCarrierName As XRLabel
    Friend WithEvents XrLabel15 As XRLabel
    Friend WithEvents XrLabel14 As XRLabel
    Friend WithEvents XrLabel10 As XRLabel
    Friend WithEvents XrLabel9 As XRLabel
    Friend WithEvents XrLabel6 As XRLabel
    Friend WithEvents DetailReport As DetailReportBand
    Friend WithEvents ReportHeader1 As ReportHeaderBand
    Public WithEvents XrLabel12 As XRLabel
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents XrLabel20 As XRLabel
    Friend WithEvents XrLabel19 As XRLabel
    Friend WithEvents XrLabel21 As XRLabel
    Friend WithEvents DetailReport1 As DetailReportBand
    Friend WithEvents Detail2 As DetailBand
    Friend WithEvents XrLabel39 As XRLabel
    Friend WithEvents XrLabel38 As XRLabel
    Friend WithEvents xrMarchingTotalSkids As XRLabel
    Friend WithEvents xrMatchingTotalGrossWeight As XRLabel
    Friend WithEvents XrLabel31 As XRLabel
    Friend WithEvents xrlShippingDate As XRLabel
    Friend WithEvents XrLabel18 As XRLabel
    Friend WithEvents xrMatchingTotalCharged As XRLabel
    Friend WithEvents XrLabel40 As XRLabel
    Friend WithEvents XrLabel43 As XRLabel
    Friend WithEvents xrMatchingTotalBilled As XRLabel
    Friend WithEvents xlMatchingFreezeProtect As XRLabel
    Friend WithEvents XrMatchingCarrierName As XRLabel
    Friend WithEvents XrLabel7 As XRLabel
    Friend WithEvents XrLabel16 As XRLabel
    Friend WithEvents XrLabel13 As XRLabel
    Friend WithEvents XrLabel3 As XRLabel
    Friend WithEvents XrLabel5 As XRLabel
    Friend WithEvents ReportHeader2 As ReportHeaderBand
    Public WithEvents XrLabel44 As XRLabel
    Friend WithEvents XrLabel25 As XRLabel
    Friend WithEvents XrLabel24 As XRLabel
    Friend WithEvents XrLabel22 As XRLabel
    Friend WithEvents calcQuoteFreezeProtect As CalculatedField
    Friend WithEvents XrLabel26 As XRLabel
    Friend WithEvents XrLabel28 As XRLabel
    Friend WithEvents XrLabel27 As XRLabel
End Class
