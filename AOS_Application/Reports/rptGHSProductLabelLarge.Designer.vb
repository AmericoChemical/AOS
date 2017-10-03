<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rptGHSProductLabelLarge
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptGHSProductLabelLarge))
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.XrLabel13 = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblProdIDChemID = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrPanel1 = New DevExpress.XtraReports.UI.XRPanel()
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblHazardousContainerWarning = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblDangerWord = New DevExpress.XtraReports.UI.XRLabel()
        Me.GHSSymbol5 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.GHSSymbol4 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.GHSSymbol3 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.GHSSymbol2 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.GHSSymbol1 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.lblGHSInfo = New DevExpress.XtraReports.UI.XRLabel()
        Me.fldWeight = New DevExpress.XtraReports.UI.XRLabel()
        Me.fldNetweightCaption = New DevExpress.XtraReports.UI.XRLabel()
        Me.fldLotDesc2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.fldWeightDesc = New DevExpress.XtraReports.UI.XRLabel()
        Me.fldStandardWeight = New DevExpress.XtraReports.UI.XRLabel()
        Me.fldLotDesc = New DevExpress.XtraReports.UI.XRLabel()
        Me.fldLotNum = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel12 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel11 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel10 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel9 = New DevExpress.XtraReports.UI.XRLabel()
        Me.fldDescAll = New DevExpress.XtraReports.UI.XRLabel()
        Me.ItemName = New DevExpress.XtraReports.UI.XRLabel()
        Me.fldDOTHAZMATDesc = New DevExpress.XtraReports.UI.XRLabel()
        Me.fldHAZMATDESC = New DevExpress.XtraReports.UI.XRLabel()
        Me.fldDOTDESC = New DevExpress.XtraReports.UI.XRLabel()
        Me.ItemName2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.fldHazMatID = New DevExpress.XtraReports.UI.XRLabel()
        Me.HazMatImage = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.Title = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.FieldCaption = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.PageInfo = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.DataField = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.DOTImages = New DevExpress.Utils.ImageCollection(Me.components)
        Me.TopMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMarginBand1 = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.GHSImages = New DevExpress.Utils.ImageCollection(Me.components)
        Me.bsRpt = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.DOTImages, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GHSImages, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsRpt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel13, Me.lblProdIDChemID, Me.XrPanel1, Me.XrLabel6, Me.lblHazardousContainerWarning, Me.lblDangerWord, Me.GHSSymbol5, Me.GHSSymbol4, Me.GHSSymbol3, Me.GHSSymbol2, Me.GHSSymbol1, Me.lblGHSInfo, Me.fldWeight, Me.fldNetweightCaption, Me.fldLotDesc2, Me.fldWeightDesc, Me.fldStandardWeight, Me.fldLotDesc, Me.fldLotNum, Me.XrLabel12, Me.XrLabel11, Me.XrLabel10, Me.XrLabel9, Me.fldDescAll, Me.ItemName, Me.fldDOTHAZMATDesc, Me.fldHAZMATDESC, Me.fldDOTDESC, Me.ItemName2, Me.fldHazMatID, Me.HazMatImage})
        Me.Detail.HeightF = 880.0!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel13
        '
        Me.XrLabel13.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Idnumber")})
        Me.XrLabel13.Font = New System.Drawing.Font("Arial Narrow", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel13.LocationFloat = New DevExpress.Utils.PointFloat(1164.584!, 120.0!)
        Me.XrLabel13.Name = "XrLabel13"
        Me.XrLabel13.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel13.SizeF = New System.Drawing.SizeF(210.415!, 97.0!)
        Me.XrLabel13.StylePriority.UseFont = False
        Me.XrLabel13.StylePriority.UseTextAlignment = False
        Me.XrLabel13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'lblProdIDChemID
        '
        Me.lblProdIDChemID.LocationFloat = New DevExpress.Utils.PointFloat(775.0001!, 765.7084!)
        Me.lblProdIDChemID.Name = "lblProdIDChemID"
        Me.lblProdIDChemID.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblProdIDChemID.SizeF = New System.Drawing.SizeF(86.45837!, 23.0!)
        Me.lblProdIDChemID.StylePriority.UseTextAlignment = False
        Me.lblProdIDChemID.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrPanel1
        '
        Me.XrPanel1.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrPanel1.BorderWidth = 4.0!
        Me.XrPanel1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel7, Me.XrLabel8})
        Me.XrPanel1.LocationFloat = New DevExpress.Utils.PointFloat(531.8799!, 765.7084!)
        Me.XrPanel1.Name = "XrPanel1"
        Me.XrPanel1.SizeF = New System.Drawing.SizeF(228.12!, 45.0!)
        Me.XrPanel1.StylePriority.UseBorders = False
        Me.XrPanel1.StylePriority.UseBorderWidth = False
        '
        'XrLabel7
        '
        Me.XrLabel7.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel7.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(5.999987!, 4.625002!)
        Me.XrLabel7.Multiline = True
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel7.SizeF = New System.Drawing.SizeF(213.12!, 17.375!)
        Me.XrLabel7.StylePriority.UseBorders = False
        Me.XrLabel7.StylePriority.UseFont = False
        Me.XrLabel7.Text = "24 HR EMERGENCY NUMBER:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'XrLabel8
        '
        Me.XrLabel8.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel8.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(6.0!, 21.99997!)
        Me.XrLabel8.Multiline = True
        Me.XrLabel8.Name = "XrLabel8"
        Me.XrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel8.SizeF = New System.Drawing.SizeF(212.5!, 17.375!)
        Me.XrLabel8.StylePriority.UseBorders = False
        Me.XrLabel8.StylePriority.UseFont = False
        Me.XrLabel8.Text = "CHEMTREC: 800/424-9300"
        '
        'XrLabel6
        '
        Me.XrLabel6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(408.1599!, 724.2499!)
        Me.XrLabel6.Multiline = True
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel6.SizeF = New System.Drawing.SizeF(351.84!, 34.37506!)
        Me.XrLabel6.StylePriority.UseFont = False
        Me.XrLabel6.Text = "SEE SAFETY DATA SHEET." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "KEEP OUT OF REACH OF CHILDREN. FOR COMMERCIAL USE."
        '
        'lblHazardousContainerWarning
        '
        Me.lblHazardousContainerWarning.Font = New System.Drawing.Font("Arial", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHazardousContainerWarning.LocationFloat = New DevExpress.Utils.PointFloat(174.9999!, 672.0!)
        Me.lblHazardousContainerWarning.Name = "lblHazardousContainerWarning"
        Me.lblHazardousContainerWarning.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblHazardousContainerWarning.SizeF = New System.Drawing.SizeF(585.0001!, 32.29169!)
        Me.lblHazardousContainerWarning.StylePriority.UseFont = False
        Me.lblHazardousContainerWarning.Text = resources.GetString("lblHazardousContainerWarning.Text")
        '
        'lblDangerWord
        '
        Me.lblDangerWord.CanGrow = False
        Me.lblDangerWord.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Dangerword")})
        Me.lblDangerWord.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDangerWord.LocationFloat = New DevExpress.Utils.PointFloat(175.0!, 204.75!)
        Me.lblDangerWord.Name = "lblDangerWord"
        Me.lblDangerWord.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblDangerWord.SizeF = New System.Drawing.SizeF(198.6979!, 23.0!)
        Me.lblDangerWord.StylePriority.UseFont = False
        Me.lblDangerWord.WordWrap = False
        '
        'GHSSymbol5
        '
        Me.GHSSymbol5.LocationFloat = New DevExpress.Utils.PointFloat(669.7917!, 125.0!)
        Me.GHSSymbol5.Name = "GHSSymbol5"
        Me.GHSSymbol5.SizeF = New System.Drawing.SizeF(75.0!, 75.0!)
        Me.GHSSymbol5.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
        '
        'GHSSymbol4
        '
        Me.GHSSymbol4.LocationFloat = New DevExpress.Utils.PointFloat(553.7682!, 125.0!)
        Me.GHSSymbol4.Name = "GHSSymbol4"
        Me.GHSSymbol4.SizeF = New System.Drawing.SizeF(75.0!, 75.0!)
        Me.GHSSymbol4.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
        '
        'GHSSymbol3
        '
        Me.GHSSymbol3.LocationFloat = New DevExpress.Utils.PointFloat(437.7448!, 125.0!)
        Me.GHSSymbol3.Name = "GHSSymbol3"
        Me.GHSSymbol3.SizeF = New System.Drawing.SizeF(75.0!, 75.0!)
        Me.GHSSymbol3.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
        '
        'GHSSymbol2
        '
        Me.GHSSymbol2.LocationFloat = New DevExpress.Utils.PointFloat(321.7213!, 125.0!)
        Me.GHSSymbol2.Name = "GHSSymbol2"
        Me.GHSSymbol2.SizeF = New System.Drawing.SizeF(75.0!, 75.0!)
        Me.GHSSymbol2.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
        '
        'GHSSymbol1
        '
        Me.GHSSymbol1.LocationFloat = New DevExpress.Utils.PointFloat(205.6979!, 125.0!)
        Me.GHSSymbol1.Name = "GHSSymbol1"
        Me.GHSSymbol1.SizeF = New System.Drawing.SizeF(75.0!, 75.0!)
        Me.GHSSymbol1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
        '
        'lblGHSInfo
        '
        Me.lblGHSInfo.CanGrow = False
        Me.lblGHSInfo.Font = New System.Drawing.Font("Arial Narrow", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGHSInfo.LocationFloat = New DevExpress.Utils.PointFloat(175.0!, 231.7917!)
        Me.lblGHSInfo.Multiline = True
        Me.lblGHSInfo.Name = "lblGHSInfo"
        Me.lblGHSInfo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblGHSInfo.SizeF = New System.Drawing.SizeF(585.0!, 440.0!)
        Me.lblGHSInfo.StylePriority.UseFont = False
        Me.lblGHSInfo.Text = "lblGHSInfo"
        '
        'fldWeight
        '
        Me.fldWeight.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fldWeight.LocationFloat = New DevExpress.Utils.PointFloat(1198.959!, 252.7917!)
        Me.fldWeight.Name = "fldWeight"
        Me.fldWeight.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.fldWeight.SizeF = New System.Drawing.SizeF(176.0414!, 32.99998!)
        Me.fldWeight.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'fldNetweightCaption
        '
        Me.fldNetweightCaption.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fldNetweightCaption.LocationFloat = New DevExpress.Utils.PointFloat(1198.959!, 219.7917!)
        Me.fldNetweightCaption.Name = "fldNetweightCaption"
        Me.fldNetweightCaption.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.fldNetweightCaption.SizeF = New System.Drawing.SizeF(176.0415!, 32.99998!)
        Me.fldNetweightCaption.StylePriority.UseFont = False
        Me.fldNetweightCaption.Text = "NET WEIGHT:"
        Me.fldNetweightCaption.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'fldLotDesc2
        '
        Me.fldLotDesc2.CanGrow = False
        Me.fldLotDesc2.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fldLotDesc2.LocationFloat = New DevExpress.Utils.PointFloat(775.0001!, 122.0!)
        Me.fldLotDesc2.Name = "fldLotDesc2"
        Me.fldLotDesc2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.fldLotDesc2.SizeF = New System.Drawing.SizeF(375.3334!, 59.04168!)
        Me.fldLotDesc2.StylePriority.UseFont = False
        Me.fldLotDesc2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.fldLotDesc2.WordWrap = False
        '
        'fldWeightDesc
        '
        Me.fldWeightDesc.Angle = 270.0!
        Me.fldWeightDesc.CanGrow = False
        Me.fldWeightDesc.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fldWeightDesc.LocationFloat = New DevExpress.Utils.PointFloat(20.0!, 383.0!)
        Me.fldWeightDesc.Name = "fldWeightDesc"
        Me.fldWeightDesc.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.fldWeightDesc.SizeF = New System.Drawing.SizeF(30.0!, 439.0001!)
        Me.fldWeightDesc.StylePriority.UseTextAlignment = False
        Me.fldWeightDesc.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        Me.fldWeightDesc.WordWrap = False
        '
        'fldStandardWeight
        '
        Me.fldStandardWeight.Angle = 270.0!
        Me.fldStandardWeight.CanGrow = False
        Me.fldStandardWeight.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Stdweight")})
        Me.fldStandardWeight.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fldStandardWeight.LocationFloat = New DevExpress.Utils.PointFloat(21.0!, 383.0!)
        Me.fldStandardWeight.Name = "fldStandardWeight"
        Me.fldStandardWeight.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.fldStandardWeight.SizeF = New System.Drawing.SizeF(25.0!, 117.0!)
        Me.fldStandardWeight.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.fldStandardWeight.Visible = False
        '
        'fldLotDesc
        '
        Me.fldLotDesc.Angle = 270.0!
        Me.fldLotDesc.CanGrow = False
        Me.fldLotDesc.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fldLotDesc.LocationFloat = New DevExpress.Utils.PointFloat(20.0!, 25.0!)
        Me.fldLotDesc.Name = "fldLotDesc"
        Me.fldLotDesc.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.fldLotDesc.SizeF = New System.Drawing.SizeF(30.0!, 358.0!)
        Me.fldLotDesc.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.fldLotDesc.WordWrap = False
        '
        'fldLotNum
        '
        Me.fldLotNum.Angle = 270.0!
        Me.fldLotNum.CanGrow = False
        Me.fldLotNum.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Lotnumber")})
        Me.fldLotNum.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fldLotNum.LocationFloat = New DevExpress.Utils.PointFloat(21.0!, 25.0!)
        Me.fldLotNum.Name = "fldLotNum"
        Me.fldLotNum.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.fldLotNum.SizeF = New System.Drawing.SizeF(25.0!, 117.0!)
        Me.fldLotNum.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.fldLotNum.Visible = False
        '
        'XrLabel12
        '
        Me.XrLabel12.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Reactivity")})
        Me.XrLabel12.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel12.LocationFloat = New DevExpress.Utils.PointFloat(1330.0!, 746.0!)
        Me.XrLabel12.Name = "XrLabel12"
        Me.XrLabel12.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel12.SizeF = New System.Drawing.SizeF(50.0!, 38.0!)
        Me.XrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel11
        '
        Me.XrLabel11.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Fire")})
        Me.XrLabel11.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel11.LocationFloat = New DevExpress.Utils.PointFloat(1330.0!, 708.0!)
        Me.XrLabel11.Name = "XrLabel11"
        Me.XrLabel11.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel11.SizeF = New System.Drawing.SizeF(50.0!, 38.0!)
        Me.XrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel10
        '
        Me.XrLabel10.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Health")})
        Me.XrLabel10.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel10.LocationFloat = New DevExpress.Utils.PointFloat(1330.0!, 670.0!)
        Me.XrLabel10.Name = "XrLabel10"
        Me.XrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel10.SizeF = New System.Drawing.SizeF(50.0!, 38.0!)
        Me.XrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel9
        '
        Me.XrLabel9.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Personalprotection")})
        Me.XrLabel9.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(1330.0!, 784.0!)
        Me.XrLabel9.Name = "XrLabel9"
        Me.XrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel9.SizeF = New System.Drawing.SizeF(50.0!, 38.0!)
        Me.XrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'fldDescAll
        '
        Me.fldDescAll.Font = New System.Drawing.Font("Arial", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fldDescAll.LocationFloat = New DevExpress.Utils.PointFloat(175.0!, 74.62502!)
        Me.fldDescAll.Name = "fldDescAll"
        Me.fldDescAll.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.fldDescAll.SizeF = New System.Drawing.SizeF(1200.0!, 41.41666!)
        Me.fldDescAll.StylePriority.UseFont = False
        Me.fldDescAll.StylePriority.UseTextAlignment = False
        Me.fldDescAll.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'ItemName
        '
        Me.ItemName.Font = New System.Drawing.Font("Arial", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ItemName.LocationFloat = New DevExpress.Utils.PointFloat(175.0!, 17.00001!)
        Me.ItemName.Name = "ItemName"
        Me.ItemName.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.ItemName.SizeF = New System.Drawing.SizeF(1199.999!, 57.625!)
        Me.ItemName.StylePriority.UseFont = False
        Me.ItemName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.ItemName.WordWrap = False
        '
        'fldDOTHAZMATDesc
        '
        Me.fldDOTHAZMATDesc.Angle = 270.0!
        Me.fldDOTHAZMATDesc.CanGrow = False
        Me.fldDOTHAZMATDesc.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fldDOTHAZMATDesc.LocationFloat = New DevExpress.Utils.PointFloat(50.0!, 25.0!)
        Me.fldDOTHAZMATDesc.Name = "fldDOTHAZMATDesc"
        Me.fldDOTHAZMATDesc.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.fldDOTHAZMATDesc.SizeF = New System.Drawing.SizeF(68.0!, 797.0001!)
        Me.fldDOTHAZMATDesc.StylePriority.UseTextAlignment = False
        Me.fldDOTHAZMATDesc.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'fldHAZMATDESC
        '
        Me.fldHAZMATDESC.Angle = 270.0!
        Me.fldHAZMATDESC.CanGrow = False
        Me.fldHAZMATDESC.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Hazmatdesc")})
        Me.fldHAZMATDESC.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fldHAZMATDESC.LocationFloat = New DevExpress.Utils.PointFloat(125.0!, 233.0!)
        Me.fldHAZMATDESC.Name = "fldHAZMATDESC"
        Me.fldHAZMATDESC.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.fldHAZMATDESC.SizeF = New System.Drawing.SizeF(25.0!, 184.0!)
        Me.fldHAZMATDESC.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.fldHAZMATDESC.Visible = False
        '
        'fldDOTDESC
        '
        Me.fldDOTDESC.Angle = 270.0!
        Me.fldDOTDESC.CanGrow = False
        Me.fldDOTDESC.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Dotdesc")})
        Me.fldDOTDESC.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fldDOTDESC.LocationFloat = New DevExpress.Utils.PointFloat(125.0!, 33.0!)
        Me.fldDOTDESC.Name = "fldDOTDESC"
        Me.fldDOTDESC.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.fldDOTDESC.SizeF = New System.Drawing.SizeF(25.0!, 184.0!)
        Me.fldDOTDESC.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.fldDOTDESC.Visible = False
        '
        'ItemName2
        '
        Me.ItemName2.Angle = 270.0!
        Me.ItemName2.CanGrow = False
        Me.ItemName2.Font = New System.Drawing.Font("Arial", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ItemName2.LocationFloat = New DevExpress.Utils.PointFloat(118.0!, 24.99998!)
        Me.ItemName2.Name = "ItemName2"
        Me.ItemName2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.ItemName2.SizeF = New System.Drawing.SizeF(44.0!, 797.0!)
        Me.ItemName2.StylePriority.UseFont = False
        Me.ItemName2.StylePriority.UseTextAlignment = False
        Me.ItemName2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'fldHazMatID
        '
        Me.fldHazMatID.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Hazmatid")})
        Me.fldHazMatID.LocationFloat = New DevExpress.Utils.PointFloat(783.0!, 442.0!)
        Me.fldHazMatID.Name = "fldHazMatID"
        Me.fldHazMatID.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.fldHazMatID.SizeF = New System.Drawing.SizeF(25.0!, 25.0!)
        Me.fldHazMatID.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.fldHazMatID.Visible = False
        '
        'HazMatImage
        '
        Me.HazMatImage.Image = CType(resources.GetObject("HazMatImage.Image"), System.Drawing.Image)
        Me.HazMatImage.LocationFloat = New DevExpress.Utils.PointFloat(775.0001!, 183.625!)
        Me.HazMatImage.Name = "HazMatImage"
        Me.HazMatImage.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.HazMatImage.SizeF = New System.Drawing.SizeF(575.0!, 575.0!)
        Me.HazMatImage.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
        '
        'Title
        '
        Me.Title.BackColor = System.Drawing.Color.White
        Me.Title.BorderColor = System.Drawing.SystemColors.ControlText
        Me.Title.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Title.BorderWidth = 1.0!
        Me.Title.Font = New System.Drawing.Font("Times New Roman", 24.0!)
        Me.Title.ForeColor = System.Drawing.Color.Black
        Me.Title.Name = "Title"
        '
        'FieldCaption
        '
        Me.FieldCaption.BackColor = System.Drawing.Color.White
        Me.FieldCaption.BorderColor = System.Drawing.SystemColors.ControlText
        Me.FieldCaption.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.FieldCaption.BorderWidth = 1.0!
        Me.FieldCaption.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold)
        Me.FieldCaption.ForeColor = System.Drawing.Color.Black
        Me.FieldCaption.Name = "FieldCaption"
        '
        'PageInfo
        '
        Me.PageInfo.BackColor = System.Drawing.Color.White
        Me.PageInfo.BorderColor = System.Drawing.SystemColors.ControlText
        Me.PageInfo.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.PageInfo.BorderWidth = 1.0!
        Me.PageInfo.Font = New System.Drawing.Font("Times New Roman", 8.0!)
        Me.PageInfo.ForeColor = System.Drawing.Color.Black
        Me.PageInfo.Name = "PageInfo"
        '
        'DataField
        '
        Me.DataField.BackColor = System.Drawing.Color.White
        Me.DataField.BorderColor = System.Drawing.SystemColors.ControlText
        Me.DataField.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.DataField.BorderWidth = 1.0!
        Me.DataField.Font = New System.Drawing.Font("Times New Roman", 8.0!)
        Me.DataField.ForeColor = System.Drawing.SystemColors.ControlText
        Me.DataField.Name = "DataField"
        '
        'DOTImages
        '
        Me.DOTImages.ImageSize = New System.Drawing.Size(550, 550)
        Me.DOTImages.ImageStream = CType(resources.GetObject("DOTImages.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.DOTImages.Images.SetKeyName(0, "AmericoSymbol.png")
        Me.DOTImages.Images.SetKeyName(1, "label-8-corrosive.png")
        Me.DOTImages.Images.SetKeyName(2, "label-5.1-oxidizer.png")
        Me.DOTImages.Images.SetKeyName(3, "6-pg-iii.png")
        Me.DOTImages.Images.SetKeyName(5, "label-9-other-dangerous-goods.png")
        Me.DOTImages.Images.SetKeyName(6, "3-combustible.png")
        '
        'TopMarginBand1
        '
        Me.TopMarginBand1.HeightF = 0!
        Me.TopMarginBand1.Name = "TopMarginBand1"
        '
        'BottomMarginBand1
        '
        Me.BottomMarginBand1.HeightF = 0!
        Me.BottomMarginBand1.Name = "BottomMarginBand1"
        '
        'GHSImages
        '
        Me.GHSImages.ImageSize = New System.Drawing.Size(75, 75)
        Me.GHSImages.ImageStream = CType(resources.GetObject("GHSImages.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.GHSImages.Images.SetKeyName(0, "ExclamationMark.png")
        Me.GHSImages.Images.SetKeyName(1, "HealthHazard.png")
        Me.GHSImages.Images.SetKeyName(2, "SkullAndCrossbones.png")
        Me.GHSImages.Images.SetKeyName(3, "Corrosion.png")
        Me.GHSImages.Images.SetKeyName(4, "Flame.png")
        Me.GHSImages.Images.SetKeyName(5, "FlameOverCircle.png")
        Me.GHSImages.Images.SetKeyName(6, "Environment.png")
        Me.GHSImages.Images.SetKeyName(7, "ExplodingBomb.png")
        Me.GHSImages.Images.SetKeyName(8, "GasCylinder.png")
        '
        'bsRpt
        '
        Me.bsRpt.DataSource = GetType(AOS.BusinessObjects.ViewProductChemicalGHS)
        '
        'rptGHSProductLabelLarge
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMarginBand1, Me.BottomMarginBand1})
        Me.DataSource = Me.bsRpt
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Landscape = True
        Me.Margins = New System.Drawing.Printing.Margins(0, 0, 0, 0)
        Me.PageHeight = 850
        Me.PageWidth = 1400
        Me.PaperKind = System.Drawing.Printing.PaperKind.Legal
        Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
        Me.ShowPreviewMarginLines = False
        Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() {Me.Title, Me.FieldCaption, Me.PageInfo, Me.DataField})
        Me.Version = "17.1"
        CType(Me.DOTImages, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GHSImages, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsRpt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents Title As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents FieldCaption As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents PageInfo As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents DataField As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents HazMatImage As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents fldHazMatID As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents ItemName2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents fldDOTDESC As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents fldDOTHAZMATDesc As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents fldHAZMATDESC As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents ItemName As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents fldDescAll As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel12 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel11 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel10 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel9 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents fldLotDesc As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents fldLotNum As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents fldWeightDesc As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents fldStandardWeight As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents fldLotDesc2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents fldWeight As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents fldNetweightCaption As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents DOTImages As DevExpress.Utils.ImageCollection
    Friend WithEvents TopMarginBand1 As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMarginBand1 As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents bsRpt As System.Windows.Forms.BindingSource
    Friend WithEvents GHSSymbol1 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents lblGHSInfo As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents GHSSymbol5 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents GHSSymbol4 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents GHSSymbol3 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents GHSSymbol2 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents GHSImages As DevExpress.Utils.ImageCollection
    Friend WithEvents XrPanel1 As DevExpress.XtraReports.UI.XRPanel
    Friend WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel8 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblHazardousContainerWarning As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblDangerWord As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblProdIDChemID As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel13 As DevExpress.XtraReports.UI.XRLabel
End Class
