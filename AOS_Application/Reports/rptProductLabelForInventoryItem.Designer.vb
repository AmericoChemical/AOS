<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class rptProductLabelForInventoryItem
    Inherits DevExpress.XtraReports.UI.XtraReport

    'XtraReport overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptProductLabelForInventoryItem))
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.fldWeight = New DevExpress.XtraReports.UI.XRLabel()
        Me.fldNetweightCaption = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel13 = New DevExpress.XtraReports.UI.XRLabel()
        Me.fldLotDesc2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.fldWeightDesc = New DevExpress.XtraReports.UI.XRLabel()
        Me.fldStandardWeight = New DevExpress.XtraReports.UI.XRLabel()
        Me.bsRpt = New System.Windows.Forms.BindingSource(Me.components)
        Me.fldLotDesc = New DevExpress.XtraReports.UI.XRLabel()
        Me.fldLotNum = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel12 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel11 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel10 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel9 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.fldDescAll = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.fldUNLine = New DevExpress.XtraReports.UI.XRLabel()
        Me.fldDOTHAZMATDesc = New DevExpress.XtraReports.UI.XRLabel()
        Me.fldHAZMATDESC = New DevExpress.XtraReports.UI.XRLabel()
        Me.fldDOTDESC = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.fldHazMatID = New DevExpress.XtraReports.UI.XRLabel()
        Me.HazMatImage = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.Title = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.FieldCaption = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.PageInfo = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.DataField = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.ImageCollection1 = New DevExpress.Utils.ImageCollection(Me.components)
        Me.TopMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMarginBand1 = New DevExpress.XtraReports.UI.BottomMarginBand()
        CType(Me.bsRpt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImageCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.fldWeight, Me.fldNetweightCaption, Me.XrLabel13, Me.fldLotDesc2, Me.fldWeightDesc, Me.fldStandardWeight, Me.fldLotDesc, Me.fldLotNum, Me.XrLabel12, Me.XrLabel11, Me.XrLabel10, Me.XrLabel9, Me.XrLabel8, Me.XrLabel7, Me.XrLabel6, Me.XrLabel4, Me.fldDescAll, Me.XrLabel5, Me.fldUNLine, Me.fldDOTHAZMATDesc, Me.fldHAZMATDESC, Me.fldDOTDESC, Me.XrLabel3, Me.XrLabel2, Me.XrLabel1, Me.fldHazMatID, Me.HazMatImage})
        Me.Detail.HeightF = 880.0!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'fldWeight
        '
        Me.fldWeight.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fldWeight.LocationFloat = New DevExpress.Utils.PointFloat(226.0417!, 165.0!)
        Me.fldWeight.Name = "fldWeight"
        Me.fldWeight.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.fldWeight.SizeF = New System.Drawing.SizeF(248.9583!, 33.0!)
        Me.fldWeight.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'fldNetweightCaption
        '
        Me.fldNetweightCaption.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fldNetweightCaption.LocationFloat = New DevExpress.Utils.PointFloat(226.0417!, 132.0!)
        Me.fldNetweightCaption.Name = "fldNetweightCaption"
        Me.fldNetweightCaption.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.fldNetweightCaption.SizeF = New System.Drawing.SizeF(248.9583!, 33.0!)
        Me.fldNetweightCaption.Text = "NET WEIGHT:"
        Me.fldNetweightCaption.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel13
        '
        Me.XrLabel13.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel13.LocationFloat = New DevExpress.Utils.PointFloat(533.0!, 775.0!)
        Me.XrLabel13.Name = "XrLabel13"
        Me.XrLabel13.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel13.SizeF = New System.Drawing.SizeF(317.0!, 25.0!)
        Me.XrLabel13.Text = "FOR INDUSTRIAL USE ONLY"
        Me.XrLabel13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'fldLotDesc2
        '
        Me.fldLotDesc2.CanGrow = False
        Me.fldLotDesc2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fldLotDesc2.LocationFloat = New DevExpress.Utils.PointFloat(533.0!, 800.0!)
        Me.fldLotDesc2.Name = "fldLotDesc2"
        Me.fldLotDesc2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.fldLotDesc2.SizeF = New System.Drawing.SizeF(317.0!, 33.0!)
        Me.fldLotDesc2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.fldLotDesc2.WordWrap = False
        '
        'fldWeightDesc
        '
        Me.fldWeightDesc.Angle = 270.0!
        Me.fldWeightDesc.CanGrow = False
        Me.fldWeightDesc.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fldWeightDesc.LocationFloat = New DevExpress.Utils.PointFloat(15.0!, 383.0!)
        Me.fldWeightDesc.Name = "fldWeightDesc"
        Me.fldWeightDesc.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.fldWeightDesc.SizeF = New System.Drawing.SizeF(30.0!, 300.0!)
        Me.fldWeightDesc.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.fldWeightDesc.WordWrap = False
        '
        'fldStandardWeight
        '
        Me.fldStandardWeight.Angle = 270.0!
        Me.fldStandardWeight.CanGrow = False
        Me.fldStandardWeight.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Me.bsRpt, "Stdweight")})
        Me.fldStandardWeight.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fldStandardWeight.LocationFloat = New DevExpress.Utils.PointFloat(8.0!, 383.0!)
        Me.fldStandardWeight.Name = "fldStandardWeight"
        Me.fldStandardWeight.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.fldStandardWeight.SizeF = New System.Drawing.SizeF(25.0!, 117.0!)
        Me.fldStandardWeight.Text = "fldStandardWeight"
        Me.fldStandardWeight.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.fldStandardWeight.Visible = False
        '
        'bsRpt
        '
        Me.bsRpt.DataSource = GetType(AOS.BusinessObjects.ViewRptProductLabelForInventoryItem)
        '
        'fldLotDesc
        '
        Me.fldLotDesc.Angle = 270.0!
        Me.fldLotDesc.CanGrow = False
        Me.fldLotDesc.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fldLotDesc.LocationFloat = New DevExpress.Utils.PointFloat(15.0!, 25.0!)
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
        Me.fldLotNum.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Me.bsRpt, "Lotnumber")})
        Me.fldLotNum.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fldLotNum.LocationFloat = New DevExpress.Utils.PointFloat(8.0!, 25.0!)
        Me.fldLotNum.Name = "fldLotNum"
        Me.fldLotNum.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.fldLotNum.SizeF = New System.Drawing.SizeF(25.0!, 117.0!)
        Me.fldLotNum.Text = "fldLotNum"
        Me.fldLotNum.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.fldLotNum.Visible = False
        '
        'XrLabel12
        '
        Me.XrLabel12.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Me.bsRpt, "Reactivity")})
        Me.XrLabel12.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel12.LocationFloat = New DevExpress.Utils.PointFloat(1330.0!, 752.0!)
        Me.XrLabel12.Name = "XrLabel12"
        Me.XrLabel12.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel12.SizeF = New System.Drawing.SizeF(50.0!, 38.0!)
        Me.XrLabel12.Text = "XrLabel12"
        Me.XrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel11
        '
        Me.XrLabel11.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Me.bsRpt, "Fire")})
        Me.XrLabel11.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel11.LocationFloat = New DevExpress.Utils.PointFloat(1330.0!, 713.0!)
        Me.XrLabel11.Name = "XrLabel11"
        Me.XrLabel11.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel11.SizeF = New System.Drawing.SizeF(50.0!, 38.0!)
        Me.XrLabel11.Text = "XrLabel11"
        Me.XrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel10
        '
        Me.XrLabel10.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Me.bsRpt, "Health")})
        Me.XrLabel10.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel10.LocationFloat = New DevExpress.Utils.PointFloat(1330.0!, 674.0!)
        Me.XrLabel10.Name = "XrLabel10"
        Me.XrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel10.SizeF = New System.Drawing.SizeF(50.0!, 38.0!)
        Me.XrLabel10.Text = "XrLabel10"
        Me.XrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel9
        '
        Me.XrLabel9.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Me.bsRpt, "Personalprotection")})
        Me.XrLabel9.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(1330.0!, 791.0!)
        Me.XrLabel9.Name = "XrLabel9"
        Me.XrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel9.SizeF = New System.Drawing.SizeF(50.0!, 38.0!)
        Me.XrLabel9.Text = "XrLabel9"
        Me.XrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel8
        '
        Me.XrLabel8.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Me.bsRpt, "Handling")})
        Me.XrLabel8.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(458.0!, 267.0!)
        Me.XrLabel8.Multiline = True
        Me.XrLabel8.Name = "XrLabel8"
        Me.XrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel8.SizeF = New System.Drawing.SizeF(309.0!, 500.0!)
        Me.XrLabel8.Text = "XrLabel8"
        Me.XrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel7
        '
        Me.XrLabel7.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Me.bsRpt, "Precautions")})
        Me.XrLabel7.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(175.0!, 267.0!)
        Me.XrLabel7.Multiline = True
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel7.SizeF = New System.Drawing.SizeF(275.0!, 500.0!)
        Me.XrLabel7.Text = "XrLabel7"
        Me.XrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel6
        '
        Me.XrLabel6.CanGrow = False
        Me.XrLabel6.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Me.bsRpt, "Warning")})
        Me.XrLabel6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(500.0!, 132.0!)
        Me.XrLabel6.Multiline = True
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel6.SizeF = New System.Drawing.SizeF(500.0!, 96.20833!)
        Me.XrLabel6.Text = "XrLabel6"
        Me.XrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel4
        '
        Me.XrLabel4.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Me.bsRpt, "Productid")})
        Me.XrLabel4.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(1192.0!, 17.00001!)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(166.0!, 66.99998!)
        Me.XrLabel4.StylePriority.UseFont = False
        Me.XrLabel4.Text = "XrLabel4"
        Me.XrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'fldDescAll
        '
        Me.fldDescAll.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fldDescAll.LocationFloat = New DevExpress.Utils.PointFloat(175.0!, 86.0!)
        Me.fldDescAll.Multiline = True
        Me.fldDescAll.Name = "fldDescAll"
        Me.fldDescAll.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.fldDescAll.SizeF = New System.Drawing.SizeF(1200.0!, 41.0!)
        Me.fldDescAll.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel5
        '
        Me.XrLabel5.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Me.bsRpt, "Productdesc")})
        Me.XrLabel5.Font = New System.Drawing.Font("Arial", 39.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(175.0!, 17.0!)
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel5.SizeF = New System.Drawing.SizeF(1017.0!, 67.0!)
        Me.XrLabel5.Text = "XrLabel5"
        Me.XrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.XrLabel5.WordWrap = False
        '
        'fldUNLine
        '
        Me.fldUNLine.Angle = 270.0!
        Me.fldUNLine.CanGrow = False
        Me.fldUNLine.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Me.bsRpt, "Unline")})
        Me.fldUNLine.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fldUNLine.LocationFloat = New DevExpress.Utils.PointFloat(47.0!, 25.0!)
        Me.fldUNLine.Name = "fldUNLine"
        Me.fldUNLine.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.fldUNLine.SizeF = New System.Drawing.SizeF(30.0!, 742.0!)
        Me.fldUNLine.Text = "fldUNLine"
        Me.fldUNLine.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.fldUNLine.WordWrap = False
        '
        'fldDOTHAZMATDesc
        '
        Me.fldDOTHAZMATDesc.Angle = 270.0!
        Me.fldDOTHAZMATDesc.CanGrow = False
        Me.fldDOTHAZMATDesc.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fldDOTHAZMATDesc.LocationFloat = New DevExpress.Utils.PointFloat(77.99999!, 25.0!)
        Me.fldDOTHAZMATDesc.Name = "fldDOTHAZMATDesc"
        Me.fldDOTHAZMATDesc.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.fldDOTHAZMATDesc.SizeF = New System.Drawing.SizeF(40.0!, 804.0!)
        Me.fldDOTHAZMATDesc.StylePriority.UseTextAlignment = False
        Me.fldDOTHAZMATDesc.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'fldHAZMATDESC
        '
        Me.fldHAZMATDESC.Angle = 270.0!
        Me.fldHAZMATDESC.CanGrow = False
        Me.fldHAZMATDESC.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Me.bsRpt, "Hazmatdesc")})
        Me.fldHAZMATDESC.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fldHAZMATDESC.LocationFloat = New DevExpress.Utils.PointFloat(125.0!, 233.0!)
        Me.fldHAZMATDESC.Name = "fldHAZMATDESC"
        Me.fldHAZMATDESC.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.fldHAZMATDESC.SizeF = New System.Drawing.SizeF(25.0!, 184.0!)
        Me.fldHAZMATDESC.Text = "fldHAZMATDESC"
        Me.fldHAZMATDESC.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.fldHAZMATDESC.Visible = False
        '
        'fldDOTDESC
        '
        Me.fldDOTDESC.Angle = 270.0!
        Me.fldDOTDESC.CanGrow = False
        Me.fldDOTDESC.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Me.bsRpt, "Dotdesc")})
        Me.fldDOTDESC.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fldDOTDESC.LocationFloat = New DevExpress.Utils.PointFloat(125.0!, 33.0!)
        Me.fldDOTDESC.Name = "fldDOTDESC"
        Me.fldDOTDESC.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.fldDOTDESC.SizeF = New System.Drawing.SizeF(25.0!, 184.0!)
        Me.fldDOTDESC.Text = "fldDOTDESC"
        Me.fldDOTDESC.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.fldDOTDESC.Visible = False
        '
        'XrLabel3
        '
        Me.XrLabel3.Angle = 270.0!
        Me.XrLabel3.CanGrow = False
        Me.XrLabel3.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Me.bsRpt, "Productdesc")})
        Me.XrLabel3.Font = New System.Drawing.Font("Arial", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(78.0!, 25.0!)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(84.0!, 804.0!)
        Me.XrLabel3.StylePriority.UseTextAlignment = False
        Me.XrLabel3.Text = "XrLabel3"
        Me.XrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel2
        '
        Me.XrLabel2.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(1169.292!, 233.0!)
        Me.XrLabel2.Multiline = True
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(205.7083!, 63.0!)
        Me.XrLabel2.Text = "24 Hr EMERGENCY NUMBER: " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "CHEMTREC: 800/424-9300"
        Me.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel1
        '
        Me.XrLabel1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(1018.625!, 132.0!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(339.3751!, 96.20833!)
        Me.XrLabel1.Text = resources.GetString("XrLabel1.Text")
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'fldHazMatID
        '
        Me.fldHazMatID.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Me.bsRpt, "Hazmatid")})
        Me.fldHazMatID.LocationFloat = New DevExpress.Utils.PointFloat(783.0!, 442.0!)
        Me.fldHazMatID.Name = "fldHazMatID"
        Me.fldHazMatID.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.fldHazMatID.SizeF = New System.Drawing.SizeF(25.0!, 25.0!)
        Me.fldHazMatID.Text = "fldHazMatID"
        Me.fldHazMatID.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.fldHazMatID.Visible = False
        '
        'HazMatImage
        '
        Me.HazMatImage.Image = CType(resources.GetObject("HazMatImage.Image"), System.Drawing.Image)
        Me.HazMatImage.LocationFloat = New DevExpress.Utils.PointFloat(775.0001!, 233.0!)
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
        'ImageCollection1
        '
        Me.ImageCollection1.ImageSize = New System.Drawing.Size(550, 550)
        Me.ImageCollection1.ImageStream = CType(resources.GetObject("ImageCollection1.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.ImageCollection1.Images.SetKeyName(0, "AmericoSymbol.png")
        Me.ImageCollection1.Images.SetKeyName(1, "label-8-corrosive.png")
        Me.ImageCollection1.Images.SetKeyName(2, "label-5.1-oxidizer.png")
        Me.ImageCollection1.Images.SetKeyName(3, "6-pg-iii.png")
        Me.ImageCollection1.Images.SetKeyName(5, "label-9-other-dangerous-goods.png")
        Me.ImageCollection1.Images.SetKeyName(6, "3-combustible.png")
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
        'rptProductLabelForInventoryItem
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMarginBand1, Me.BottomMarginBand1})
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Landscape = True
        Me.Margins = New System.Drawing.Printing.Margins(0, 0, 0, 0)
        Me.PageHeight = 850
        Me.PageWidth = 1400
        Me.PaperKind = System.Drawing.Printing.PaperKind.Legal
        Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
        Me.ShowPreviewMarginLines = False
        Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() {Me.Title, Me.FieldCaption, Me.PageInfo, Me.DataField})
        Me.Version = "15.1"
        CType(Me.bsRpt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImageCollection1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents Title As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents FieldCaption As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents PageInfo As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents DataField As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents HazMatImage As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents fldHazMatID As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents fldDOTDESC As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents fldDOTHAZMATDesc As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents fldHAZMATDESC As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents fldUNLine As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents fldDescAll As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel8 As DevExpress.XtraReports.UI.XRLabel
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
    Friend WithEvents XrLabel13 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents ImageCollection1 As DevExpress.Utils.ImageCollection
    Friend WithEvents TopMarginBand1 As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMarginBand1 As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents bsRpt As System.Windows.Forms.BindingSource
End Class
