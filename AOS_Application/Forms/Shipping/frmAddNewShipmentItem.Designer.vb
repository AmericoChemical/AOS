<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddNewShipmentItem

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ProductidLabel As System.Windows.Forms.Label
        Dim QtycontainersLabel As System.Windows.Forms.Label
        Dim BatchnumberLabel As System.Windows.Forms.Label
        Dim StdweightLabel As System.Windows.Forms.Label
        Dim TotalweightLabel As System.Windows.Forms.Label
        Dim Ld1Label As System.Windows.Forms.Label
        Dim Ld2Label As System.Windows.Forms.Label
        Dim Ld3Label As System.Windows.Forms.Label
        Dim ContainerLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim BillableLabel As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Dim Label8 As System.Windows.Forms.Label
        Dim Label9 As System.Windows.Forms.Label
        Dim Label10 As System.Windows.Forms.Label
        Dim Label11 As System.Windows.Forms.Label
        Dim Label12 As System.Windows.Forms.Label
        Dim Label13 As System.Windows.Forms.Label
        Dim Label14 As System.Windows.Forms.Label
        Dim Label15 As System.Windows.Forms.Label
        Dim Label17 As System.Windows.Forms.Label
        Dim Label18 As System.Windows.Forms.Label
        Dim Label19 As System.Windows.Forms.Label
        Dim Label20 As System.Windows.Forms.Label
        Dim Label21 As System.Windows.Forms.Label
        Dim Label23 As System.Windows.Forms.Label
        Dim Label24 As System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.bsItem = New System.Windows.Forms.BindingSource(Me.components)
        Me.bsProducts = New System.Windows.Forms.BindingSource(Me.components)
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btnSave = New DevExpress.XtraBars.BarButtonItem()
        Me.btnCancel = New DevExpress.XtraBars.BarButtonItem()
        Me.BarStaticItem1 = New DevExpress.XtraBars.BarStaticItem()
        Me.BarStaticItem2 = New DevExpress.XtraBars.BarStaticItem()
        Me.BarStaticItem3 = New DevExpress.XtraBars.BarStaticItem()
        Me.rTxtShipmentNumber = New DevExpress.XtraBars.BarStaticItem()
        Me.rtxtPurchaseOrder = New DevExpress.XtraBars.BarStaticItem()
        Me.rTxtCustomerName = New DevExpress.XtraBars.BarStaticItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.pItemTypeSelector = New DevExpress.XtraEditors.PanelControl()
        Me.rbS = New DevExpress.XtraEditors.CheckEdit()
        Me.rbM = New DevExpress.XtraEditors.CheckEdit()
        Me.rbE = New DevExpress.XtraEditors.CheckEdit()
        Me.rbP = New DevExpress.XtraEditors.CheckEdit()
        Me.pProductScreen = New DevExpress.XtraEditors.PanelControl()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.BillableCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.eTareWgt = New DevExpress.XtraEditors.TextEdit()
        Me.ContainerTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.Ld3TextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.Ld2TextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.Ld1TextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.TotalweightTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.StdweightTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.BatchnumberTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.eQty = New DevExpress.XtraEditors.TextEdit()
        Me.ProductdescTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.eProductID = New DevExpress.XtraEditors.LookUpEdit()
        Me.pMiscScreen = New DevExpress.XtraEditors.PanelControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.mBillable = New DevExpress.XtraEditors.CheckEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.mTotalWeight = New DevExpress.XtraEditors.TextEdit()
        Me.mQty = New DevExpress.XtraEditors.TextEdit()
        Me.mProductDesc = New DevExpress.XtraEditors.TextEdit()
        Me.pEmptyReturns = New DevExpress.XtraEditors.PanelControl()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.CheckEdit1 = New DevExpress.XtraEditors.CheckEdit()
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit2 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit3 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit4 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit5 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit6 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit7 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit8 = New DevExpress.XtraEditors.TextEdit()
        Me.eEmptyQty = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit10 = New DevExpress.XtraEditors.TextEdit()
        Me.luEmptyProductID = New DevExpress.XtraEditors.LookUpEdit()
        Me.pSamples = New DevExpress.XtraEditors.PanelControl()
        Me.GroupControl4 = New DevExpress.XtraEditors.GroupControl()
        Me.CheckEdit2 = New DevExpress.XtraEditors.CheckEdit()
        Me.sContainer = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit12 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit13 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit14 = New DevExpress.XtraEditors.TextEdit()
        Me.sTotalWeight = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit17 = New DevExpress.XtraEditors.TextEdit()
        Me.sQty = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit19 = New DevExpress.XtraEditors.TextEdit()
        Me.luSampleProductID = New DevExpress.XtraEditors.LookUpEdit()
        ProductidLabel = New System.Windows.Forms.Label()
        QtycontainersLabel = New System.Windows.Forms.Label()
        BatchnumberLabel = New System.Windows.Forms.Label()
        StdweightLabel = New System.Windows.Forms.Label()
        TotalweightLabel = New System.Windows.Forms.Label()
        Ld1Label = New System.Windows.Forms.Label()
        Ld2Label = New System.Windows.Forms.Label()
        Ld3Label = New System.Windows.Forms.Label()
        ContainerLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        BillableLabel = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        Label7 = New System.Windows.Forms.Label()
        Label8 = New System.Windows.Forms.Label()
        Label9 = New System.Windows.Forms.Label()
        Label10 = New System.Windows.Forms.Label()
        Label11 = New System.Windows.Forms.Label()
        Label12 = New System.Windows.Forms.Label()
        Label13 = New System.Windows.Forms.Label()
        Label14 = New System.Windows.Forms.Label()
        Label15 = New System.Windows.Forms.Label()
        Label17 = New System.Windows.Forms.Label()
        Label18 = New System.Windows.Forms.Label()
        Label19 = New System.Windows.Forms.Label()
        Label20 = New System.Windows.Forms.Label()
        Label21 = New System.Windows.Forms.Label()
        Label23 = New System.Windows.Forms.Label()
        Label24 = New System.Windows.Forms.Label()
        CType(Me.bsItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pItemTypeSelector, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pItemTypeSelector.SuspendLayout()
        CType(Me.rbS.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rbM.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rbE.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rbP.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pProductScreen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pProductScreen.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.BillableCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eTareWgt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ContainerTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ld3TextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ld2TextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ld1TextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TotalweightTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StdweightTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BatchnumberTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eQty.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductdescTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eProductID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pMiscScreen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pMiscScreen.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.mBillable.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mTotalWeight.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mQty.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mProductDesc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pEmptyReturns, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pEmptyReturns.SuspendLayout()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit5.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit6.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit7.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit8.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eEmptyQty.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit10.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.luEmptyProductID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pSamples, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pSamples.SuspendLayout()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl4.SuspendLayout()
        CType(Me.CheckEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sContainer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit12.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit13.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit14.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sTotalWeight.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit17.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sQty.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit19.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.luSampleProductID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProductidLabel
        '
        ProductidLabel.AutoSize = True
        ProductidLabel.Location = New System.Drawing.Point(158, 27)
        ProductidLabel.Name = "ProductidLabel"
        ProductidLabel.Size = New System.Drawing.Size(48, 13)
        ProductidLabel.TabIndex = 4
        ProductidLabel.Text = "Product:"
        '
        'QtycontainersLabel
        '
        QtycontainersLabel.AutoSize = True
        QtycontainersLabel.Location = New System.Drawing.Point(14, 27)
        QtycontainersLabel.Name = "QtycontainersLabel"
        QtycontainersLabel.Size = New System.Drawing.Size(53, 13)
        QtycontainersLabel.TabIndex = 8
        QtycontainersLabel.Text = "Quantity:"
        '
        'BatchnumberLabel
        '
        BatchnumberLabel.AutoSize = True
        BatchnumberLabel.Location = New System.Drawing.Point(140, 79)
        BatchnumberLabel.Name = "BatchnumberLabel"
        BatchnumberLabel.Size = New System.Drawing.Size(66, 13)
        BatchnumberLabel.TabIndex = 10
        BatchnumberLabel.Text = "Lot Number:"
        '
        'StdweightLabel
        '
        StdweightLabel.AutoSize = True
        StdweightLabel.Location = New System.Drawing.Point(374, 53)
        StdweightLabel.Name = "StdweightLabel"
        StdweightLabel.Size = New System.Drawing.Size(50, 13)
        StdweightLabel.TabIndex = 14
        StdweightLabel.Text = "Std Wgt:"
        '
        'TotalweightLabel
        '
        TotalweightLabel.AutoSize = True
        TotalweightLabel.Location = New System.Drawing.Point(9, 53)
        TotalweightLabel.Name = "TotalweightLabel"
        TotalweightLabel.Size = New System.Drawing.Size(58, 13)
        TotalweightLabel.TabIndex = 16
        TotalweightLabel.Text = "Total Wgt:"
        '
        'Ld1Label
        '
        Ld1Label.AutoSize = True
        Ld1Label.Location = New System.Drawing.Point(28, 105)
        Ld1Label.Name = "Ld1Label"
        Ld1Label.Size = New System.Drawing.Size(39, 13)
        Ld1Label.TabIndex = 20
        Ld1Label.Text = "Line 1:"
        '
        'Ld2Label
        '
        Ld2Label.AutoSize = True
        Ld2Label.Location = New System.Drawing.Point(28, 131)
        Ld2Label.Name = "Ld2Label"
        Ld2Label.Size = New System.Drawing.Size(39, 13)
        Ld2Label.TabIndex = 22
        Ld2Label.Text = "Line 2:"
        '
        'Ld3Label
        '
        Ld3Label.AutoSize = True
        Ld3Label.Location = New System.Drawing.Point(28, 157)
        Ld3Label.Name = "Ld3Label"
        Ld3Label.Size = New System.Drawing.Size(39, 13)
        Ld3Label.TabIndex = 24
        Ld3Label.Text = "Line 3:"
        '
        'ContainerLabel
        '
        ContainerLabel.AutoSize = True
        ContainerLabel.Location = New System.Drawing.Point(148, 53)
        ContainerLabel.Name = "ContainerLabel"
        ContainerLabel.Size = New System.Drawing.Size(58, 13)
        ContainerLabel.TabIndex = 28
        ContainerLabel.Text = "Container:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(491, 53)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(56, 13)
        Label1.TabIndex = 34
        Label1.Text = "Tare Wgt:"
        '
        'BillableLabel
        '
        BillableLabel.AutoSize = True
        BillableLabel.Location = New System.Drawing.Point(24, 78)
        BillableLabel.Name = "BillableLabel"
        BillableLabel.Size = New System.Drawing.Size(43, 13)
        BillableLabel.TabIndex = 35
        BillableLabel.Text = "Billable:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(28, 105)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(43, 13)
        Label2.TabIndex = 37
        Label2.Text = "Billable:"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(24, 78)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(43, 13)
        Label3.TabIndex = 35
        Label3.Text = "Billable:"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(491, 53)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(56, 13)
        Label4.TabIndex = 34
        Label4.Text = "Tare Wgt:"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Location = New System.Drawing.Point(167, 53)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(58, 13)
        Label5.TabIndex = 28
        Label5.Text = "Container:"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Location = New System.Drawing.Point(28, 157)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(39, 13)
        Label6.TabIndex = 24
        Label6.Text = "Line 3:"
        '
        'Label7
        '
        Label7.AutoSize = True
        Label7.Location = New System.Drawing.Point(28, 131)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(39, 13)
        Label7.TabIndex = 22
        Label7.Text = "Line 2:"
        '
        'Label8
        '
        Label8.AutoSize = True
        Label8.Location = New System.Drawing.Point(28, 105)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(39, 13)
        Label8.TabIndex = 20
        Label8.Text = "Line 1:"
        '
        'Label9
        '
        Label9.AutoSize = True
        Label9.Location = New System.Drawing.Point(9, 53)
        Label9.Name = "Label9"
        Label9.Size = New System.Drawing.Size(58, 13)
        Label9.TabIndex = 16
        Label9.Text = "Total Wgt:"
        '
        'Label10
        '
        Label10.AutoSize = True
        Label10.Location = New System.Drawing.Point(374, 53)
        Label10.Name = "Label10"
        Label10.Size = New System.Drawing.Size(50, 13)
        Label10.TabIndex = 14
        Label10.Text = "Std Wgt:"
        '
        'Label11
        '
        Label11.AutoSize = True
        Label11.Location = New System.Drawing.Point(159, 79)
        Label11.Name = "Label11"
        Label11.Size = New System.Drawing.Size(66, 13)
        Label11.TabIndex = 10
        Label11.Text = "Lot Number:"
        '
        'Label12
        '
        Label12.AutoSize = True
        Label12.Location = New System.Drawing.Point(14, 27)
        Label12.Name = "Label12"
        Label12.Size = New System.Drawing.Size(53, 13)
        Label12.TabIndex = 8
        Label12.Text = "Quantity:"
        '
        'Label13
        '
        Label13.AutoSize = True
        Label13.Location = New System.Drawing.Point(142, 27)
        Label13.Name = "Label13"
        Label13.Size = New System.Drawing.Size(83, 13)
        Label13.TabIndex = 4
        Label13.Text = "Last Contained:"
        '
        'Label14
        '
        Label14.AutoSize = True
        Label14.Location = New System.Drawing.Point(159, 79)
        Label14.Name = "Label14"
        Label14.Size = New System.Drawing.Size(66, 13)
        Label14.TabIndex = 10
        Label14.Text = "Lot Number:"
        '
        'Label15
        '
        Label15.AutoSize = True
        Label15.Location = New System.Drawing.Point(24, 78)
        Label15.Name = "Label15"
        Label15.Size = New System.Drawing.Size(43, 13)
        Label15.TabIndex = 35
        Label15.Text = "Billable:"
        '
        'Label17
        '
        Label17.AutoSize = True
        Label17.Location = New System.Drawing.Point(167, 53)
        Label17.Name = "Label17"
        Label17.Size = New System.Drawing.Size(58, 13)
        Label17.TabIndex = 28
        Label17.Text = "Container:"
        '
        'Label18
        '
        Label18.AutoSize = True
        Label18.Location = New System.Drawing.Point(28, 157)
        Label18.Name = "Label18"
        Label18.Size = New System.Drawing.Size(39, 13)
        Label18.TabIndex = 24
        Label18.Text = "Line 3:"
        '
        'Label19
        '
        Label19.AutoSize = True
        Label19.Location = New System.Drawing.Point(28, 131)
        Label19.Name = "Label19"
        Label19.Size = New System.Drawing.Size(39, 13)
        Label19.TabIndex = 22
        Label19.Text = "Line 2:"
        '
        'Label20
        '
        Label20.AutoSize = True
        Label20.Location = New System.Drawing.Point(28, 105)
        Label20.Name = "Label20"
        Label20.Size = New System.Drawing.Size(39, 13)
        Label20.TabIndex = 20
        Label20.Text = "Line 1:"
        '
        'Label21
        '
        Label21.AutoSize = True
        Label21.Location = New System.Drawing.Point(9, 53)
        Label21.Name = "Label21"
        Label21.Size = New System.Drawing.Size(58, 13)
        Label21.TabIndex = 16
        Label21.Text = "Total Wgt:"
        '
        'Label23
        '
        Label23.AutoSize = True
        Label23.Location = New System.Drawing.Point(14, 27)
        Label23.Name = "Label23"
        Label23.Size = New System.Drawing.Size(53, 13)
        Label23.TabIndex = 8
        Label23.Text = "Quantity:"
        '
        'Label24
        '
        Label24.AutoSize = True
        Label24.Location = New System.Drawing.Point(177, 26)
        Label24.Name = "Label24"
        Label24.Size = New System.Drawing.Size(48, 13)
        Label24.TabIndex = 4
        Label24.Text = "Product:"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'bsItem
        '
        Me.bsItem.DataSource = GetType(AOS.BusinessObjects.Shipmentdetail)
        '
        'bsProducts
        '
        Me.bsProducts.DataSource = GetType(AOS.BusinessObjects.ProductCollection)
        '
        'RibbonControl1
        '
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.ExpandCollapseItem.Name = ""
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.btnSave, Me.btnCancel, Me.BarStaticItem1, Me.BarStaticItem2, Me.BarStaticItem3, Me.rTxtShipmentNumber, Me.rtxtPurchaseOrder, Me.rTxtCustomerName})
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.MaxItemId = 23
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide
        Me.RibbonControl1.ShowToolbarCustomizeItem = False
        Me.RibbonControl1.Size = New System.Drawing.Size(616, 95)
        Me.RibbonControl1.Toolbar.ShowCustomizeItem = False
        Me.RibbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden
        '
        'btnSave
        '
        Me.btnSave.Caption = "Save"
        Me.btnSave.Id = 4
        Me.btnSave.LargeGlyph = Global.AOS.My.Resources.Resources.SaveChanges
        Me.btnSave.Name = "btnSave"
        '
        'btnCancel
        '
        Me.btnCancel.Caption = "Cancel"
        Me.btnCancel.Id = 16
        Me.btnCancel.LargeGlyph = Global.AOS.My.Resources.Resources.CancelChanges
        Me.btnCancel.Name = "btnCancel"
        '
        'BarStaticItem1
        '
        Me.BarStaticItem1.Caption = "Shipment Number"
        Me.BarStaticItem1.Id = 17
        Me.BarStaticItem1.Name = "BarStaticItem1"
        Me.BarStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near
        '
        'BarStaticItem2
        '
        Me.BarStaticItem2.Caption = "Customer PO"
        Me.BarStaticItem2.Id = 18
        Me.BarStaticItem2.Name = "BarStaticItem2"
        Me.BarStaticItem2.TextAlignment = System.Drawing.StringAlignment.Near
        '
        'BarStaticItem3
        '
        Me.BarStaticItem3.Caption = "Customer Name"
        Me.BarStaticItem3.Id = 19
        Me.BarStaticItem3.Name = "BarStaticItem3"
        Me.BarStaticItem3.TextAlignment = System.Drawing.StringAlignment.Near
        '
        'rTxtShipmentNumber
        '
        Me.rTxtShipmentNumber.Caption = "999999 - 12/31/2099"
        Me.rTxtShipmentNumber.Id = 20
        Me.rTxtShipmentNumber.Name = "rTxtShipmentNumber"
        Me.rTxtShipmentNumber.TextAlignment = System.Drawing.StringAlignment.Near
        '
        'rtxtPurchaseOrder
        '
        Me.rtxtPurchaseOrder.Caption = "ABCDEFGHIJK"
        Me.rtxtPurchaseOrder.Id = 21
        Me.rtxtPurchaseOrder.Name = "rtxtPurchaseOrder"
        Me.rtxtPurchaseOrder.TextAlignment = System.Drawing.StringAlignment.Near
        '
        'rTxtCustomerName
        '
        Me.rTxtCustomerName.Caption = "Americo Chemical Products, Inc."
        Me.rTxtCustomerName.Id = 22
        Me.rTxtCustomerName.Name = "rTxtCustomerName"
        Me.rTxtCustomerName.TextAlignment = System.Drawing.StringAlignment.Near
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup2, Me.RibbonPageGroup1})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "RibbonPage1"
        '
        'RibbonPageGroup2
        '
        Me.RibbonPageGroup2.AllowTextClipping = False
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btnSave)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btnCancel)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.ShowCaptionButton = False
        Me.RibbonPageGroup2.Text = "Actions"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.AllowTextClipping = False
        Me.RibbonPageGroup1.ItemLinks.Add(Me.BarStaticItem1)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.BarStaticItem3)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.BarStaticItem2)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.rTxtShipmentNumber, True)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.rTxtCustomerName)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.rtxtPurchaseOrder)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.ShowCaptionButton = False
        Me.RibbonPageGroup1.Text = "Shipment Information"
        '
        'pItemTypeSelector
        '
        Me.pItemTypeSelector.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.pItemTypeSelector.Controls.Add(Me.rbS)
        Me.pItemTypeSelector.Controls.Add(Me.rbM)
        Me.pItemTypeSelector.Controls.Add(Me.rbE)
        Me.pItemTypeSelector.Controls.Add(Me.rbP)
        Me.pItemTypeSelector.Dock = System.Windows.Forms.DockStyle.Top
        Me.pItemTypeSelector.Location = New System.Drawing.Point(0, 95)
        Me.pItemTypeSelector.Name = "pItemTypeSelector"
        Me.pItemTypeSelector.Size = New System.Drawing.Size(616, 31)
        Me.pItemTypeSelector.TabIndex = 25
        '
        'rbS
        '
        Me.rbS.Location = New System.Drawing.Point(295, 6)
        Me.rbS.MenuManager = Me.RibbonControl1
        Me.rbS.Name = "rbS"
        Me.rbS.Properties.Caption = "Sample"
        Me.rbS.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio
        Me.rbS.Properties.RadioGroupIndex = 23
        Me.rbS.Size = New System.Drawing.Size(97, 19)
        Me.rbS.TabIndex = 9
        Me.rbS.TabStop = False
        '
        'rbM
        '
        Me.rbM.Location = New System.Drawing.Point(192, 6)
        Me.rbM.MenuManager = Me.RibbonControl1
        Me.rbM.Name = "rbM"
        Me.rbM.Properties.Caption = "Miscellaneous"
        Me.rbM.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio
        Me.rbM.Properties.RadioGroupIndex = 23
        Me.rbM.Size = New System.Drawing.Size(97, 19)
        Me.rbM.TabIndex = 8
        Me.rbM.TabStop = False
        '
        'rbE
        '
        Me.rbE.Location = New System.Drawing.Point(77, 6)
        Me.rbE.MenuManager = Me.RibbonControl1
        Me.rbE.Name = "rbE"
        Me.rbE.Properties.Caption = "Empty Container"
        Me.rbE.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio
        Me.rbE.Properties.RadioGroupIndex = 23
        Me.rbE.Size = New System.Drawing.Size(109, 19)
        Me.rbE.TabIndex = 7
        Me.rbE.TabStop = False
        '
        'rbP
        '
        Me.rbP.EditValue = True
        Me.rbP.Location = New System.Drawing.Point(3, 6)
        Me.rbP.MenuManager = Me.RibbonControl1
        Me.rbP.Name = "rbP"
        Me.rbP.Properties.Caption = "Product"
        Me.rbP.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio
        Me.rbP.Properties.RadioGroupIndex = 23
        Me.rbP.Size = New System.Drawing.Size(68, 19)
        Me.rbP.TabIndex = 6
        '
        'pProductScreen
        '
        Me.pProductScreen.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.pProductScreen.Controls.Add(Me.GroupControl2)
        Me.pProductScreen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pProductScreen.Location = New System.Drawing.Point(0, 126)
        Me.pProductScreen.Name = "pProductScreen"
        Me.pProductScreen.Size = New System.Drawing.Size(616, 190)
        Me.pProductScreen.TabIndex = 26
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(BatchnumberLabel)
        Me.GroupControl2.Controls.Add(BillableLabel)
        Me.GroupControl2.Controls.Add(Me.BillableCheckEdit)
        Me.GroupControl2.Controls.Add(Label1)
        Me.GroupControl2.Controls.Add(Me.eTareWgt)
        Me.GroupControl2.Controls.Add(ContainerLabel)
        Me.GroupControl2.Controls.Add(Me.ContainerTextEdit)
        Me.GroupControl2.Controls.Add(Ld3Label)
        Me.GroupControl2.Controls.Add(Me.Ld3TextEdit)
        Me.GroupControl2.Controls.Add(Ld2Label)
        Me.GroupControl2.Controls.Add(Me.Ld2TextEdit)
        Me.GroupControl2.Controls.Add(Ld1Label)
        Me.GroupControl2.Controls.Add(Me.Ld1TextEdit)
        Me.GroupControl2.Controls.Add(TotalweightLabel)
        Me.GroupControl2.Controls.Add(Me.TotalweightTextEdit)
        Me.GroupControl2.Controls.Add(StdweightLabel)
        Me.GroupControl2.Controls.Add(Me.StdweightTextEdit)
        Me.GroupControl2.Controls.Add(Me.BatchnumberTextEdit)
        Me.GroupControl2.Controls.Add(QtycontainersLabel)
        Me.GroupControl2.Controls.Add(Me.eQty)
        Me.GroupControl2.Controls.Add(Me.ProductdescTextEdit)
        Me.GroupControl2.Controls.Add(ProductidLabel)
        Me.GroupControl2.Controls.Add(Me.eProductID)
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl2.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(616, 190)
        Me.GroupControl2.TabIndex = 0
        Me.GroupControl2.Text = "Product Item"
        '
        'BillableCheckEdit
        '
        Me.BillableCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsItem, "Billable", True))
        Me.BillableCheckEdit.Location = New System.Drawing.Point(71, 76)
        Me.BillableCheckEdit.MenuManager = Me.RibbonControl1
        Me.BillableCheckEdit.Name = "BillableCheckEdit"
        Me.BillableCheckEdit.Properties.Caption = ""
        Me.BillableCheckEdit.Size = New System.Drawing.Size(75, 19)
        Me.BillableCheckEdit.TabIndex = 36
        '
        'eTareWgt
        '
        Me.eTareWgt.Location = New System.Drawing.Point(547, 50)
        Me.eTareWgt.MenuManager = Me.RibbonControl1
        Me.eTareWgt.Name = "eTareWgt"
        Me.eTareWgt.Properties.ReadOnly = True
        Me.eTareWgt.Size = New System.Drawing.Size(55, 20)
        Me.eTareWgt.TabIndex = 35
        '
        'ContainerTextEdit
        '
        Me.ContainerTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsItem, "Container", True))
        Me.ContainerTextEdit.Location = New System.Drawing.Point(212, 50)
        Me.ContainerTextEdit.MenuManager = Me.RibbonControl1
        Me.ContainerTextEdit.Name = "ContainerTextEdit"
        Me.ContainerTextEdit.Properties.ReadOnly = True
        Me.ContainerTextEdit.Size = New System.Drawing.Size(156, 20)
        Me.ContainerTextEdit.TabIndex = 29
        '
        'Ld3TextEdit
        '
        Me.Ld3TextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsItem, "Ld3", True))
        Me.Ld3TextEdit.Location = New System.Drawing.Point(73, 154)
        Me.Ld3TextEdit.MenuManager = Me.RibbonControl1
        Me.Ld3TextEdit.Name = "Ld3TextEdit"
        Me.Ld3TextEdit.Properties.ReadOnly = True
        Me.Ld3TextEdit.Size = New System.Drawing.Size(529, 20)
        Me.Ld3TextEdit.TabIndex = 25
        '
        'Ld2TextEdit
        '
        Me.Ld2TextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsItem, "Ld2", True))
        Me.Ld2TextEdit.Location = New System.Drawing.Point(73, 128)
        Me.Ld2TextEdit.MenuManager = Me.RibbonControl1
        Me.Ld2TextEdit.Name = "Ld2TextEdit"
        Me.Ld2TextEdit.Properties.ReadOnly = True
        Me.Ld2TextEdit.Size = New System.Drawing.Size(529, 20)
        Me.Ld2TextEdit.TabIndex = 23
        '
        'Ld1TextEdit
        '
        Me.Ld1TextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsItem, "Ld1", True))
        Me.Ld1TextEdit.Location = New System.Drawing.Point(73, 102)
        Me.Ld1TextEdit.MenuManager = Me.RibbonControl1
        Me.Ld1TextEdit.Name = "Ld1TextEdit"
        Me.Ld1TextEdit.Properties.ReadOnly = True
        Me.Ld1TextEdit.Size = New System.Drawing.Size(529, 20)
        Me.Ld1TextEdit.TabIndex = 21
        '
        'TotalweightTextEdit
        '
        Me.TotalweightTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsItem, "Totalweight", True))
        Me.TotalweightTextEdit.Location = New System.Drawing.Point(73, 50)
        Me.TotalweightTextEdit.MenuManager = Me.RibbonControl1
        Me.TotalweightTextEdit.Name = "TotalweightTextEdit"
        Me.TotalweightTextEdit.Properties.ReadOnly = True
        Me.TotalweightTextEdit.Size = New System.Drawing.Size(62, 20)
        Me.TotalweightTextEdit.TabIndex = 17
        '
        'StdweightTextEdit
        '
        Me.StdweightTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsItem, "Stdweight", True))
        Me.StdweightTextEdit.Location = New System.Drawing.Point(430, 50)
        Me.StdweightTextEdit.MenuManager = Me.RibbonControl1
        Me.StdweightTextEdit.Name = "StdweightTextEdit"
        Me.StdweightTextEdit.Properties.ReadOnly = True
        Me.StdweightTextEdit.Size = New System.Drawing.Size(55, 20)
        Me.StdweightTextEdit.TabIndex = 15
        '
        'BatchnumberTextEdit
        '
        Me.BatchnumberTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsItem, "Batchnumber", True))
        Me.BatchnumberTextEdit.Location = New System.Drawing.Point(212, 76)
        Me.BatchnumberTextEdit.MenuManager = Me.RibbonControl1
        Me.BatchnumberTextEdit.Name = "BatchnumberTextEdit"
        Me.BatchnumberTextEdit.Size = New System.Drawing.Size(156, 20)
        Me.BatchnumberTextEdit.TabIndex = 11
        '
        'eQty
        '
        Me.eQty.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsItem, "Qtycontainers", True))
        Me.eQty.Location = New System.Drawing.Point(73, 24)
        Me.eQty.MenuManager = Me.RibbonControl1
        Me.eQty.Name = "eQty"
        Me.eQty.Size = New System.Drawing.Size(62, 20)
        Me.eQty.TabIndex = 9
        '
        'ProductdescTextEdit
        '
        Me.ProductdescTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsItem, "Productdesc", True))
        Me.ProductdescTextEdit.Location = New System.Drawing.Point(295, 24)
        Me.ProductdescTextEdit.MenuManager = Me.RibbonControl1
        Me.ProductdescTextEdit.Name = "ProductdescTextEdit"
        Me.ProductdescTextEdit.Properties.ReadOnly = True
        Me.ProductdescTextEdit.Size = New System.Drawing.Size(307, 20)
        Me.ProductdescTextEdit.TabIndex = 7
        '
        'eProductID
        '
        Me.eProductID.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsItem, "Productid", True))
        Me.eProductID.Location = New System.Drawing.Point(212, 24)
        Me.eProductID.MenuManager = Me.RibbonControl1
        Me.eProductID.Name = "eProductID"
        Me.eProductID.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.eProductID.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Productid", "Prod ID", 50, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Productdesc", "Description", 150, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Container", "Container", 75, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Desc2", "Addn Desc", 125, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.eProductID.Properties.DataSource = Me.bsProducts
        Me.eProductID.Properties.DisplayMember = "Productid"
        Me.eProductID.Properties.NullText = ""
        Me.eProductID.Properties.PopupWidth = 400
        Me.eProductID.Properties.ValueMember = "Productid"
        Me.eProductID.Size = New System.Drawing.Size(77, 20)
        Me.eProductID.TabIndex = 5
        '
        'pMiscScreen
        '
        Me.pMiscScreen.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.pMiscScreen.Controls.Add(Me.GroupControl1)
        Me.pMiscScreen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pMiscScreen.Location = New System.Drawing.Point(0, 126)
        Me.pMiscScreen.Name = "pMiscScreen"
        Me.pMiscScreen.Size = New System.Drawing.Size(616, 190)
        Me.pMiscScreen.TabIndex = 27
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Label2)
        Me.GroupControl1.Controls.Add(Me.mBillable)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.mTotalWeight)
        Me.GroupControl1.Controls.Add(Me.mQty)
        Me.GroupControl1.Controls.Add(Me.mProductDesc)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(616, 190)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "Miscellaneous Item"
        '
        'mBillable
        '
        Me.mBillable.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsItem, "Billable", True))
        Me.mBillable.Location = New System.Drawing.Point(75, 103)
        Me.mBillable.MenuManager = Me.RibbonControl1
        Me.mBillable.Name = "mBillable"
        Me.mBillable.Properties.Caption = ""
        Me.mBillable.Size = New System.Drawing.Size(75, 19)
        Me.mBillable.TabIndex = 38
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(16, 79)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(51, 13)
        Me.LabelControl3.TabIndex = 5
        Me.LabelControl3.Text = "Total Wgt:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(12, 53)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(57, 13)
        Me.LabelControl2.TabIndex = 4
        Me.LabelControl2.Text = "Description:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(21, 27)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(46, 13)
        Me.LabelControl1.TabIndex = 3
        Me.LabelControl1.Text = "Quantity:"
        '
        'mTotalWeight
        '
        Me.mTotalWeight.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsItem, "Totalweight", True))
        Me.mTotalWeight.Location = New System.Drawing.Point(77, 76)
        Me.mTotalWeight.MenuManager = Me.RibbonControl1
        Me.mTotalWeight.Name = "mTotalWeight"
        Me.mTotalWeight.Size = New System.Drawing.Size(58, 20)
        Me.mTotalWeight.TabIndex = 2
        '
        'mQty
        '
        Me.mQty.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsItem, "Qtycontainers", True))
        Me.mQty.Location = New System.Drawing.Point(77, 24)
        Me.mQty.MenuManager = Me.RibbonControl1
        Me.mQty.Name = "mQty"
        Me.mQty.Size = New System.Drawing.Size(58, 20)
        Me.mQty.TabIndex = 1
        '
        'mProductDesc
        '
        Me.mProductDesc.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsItem, "Productdesc", True))
        Me.mProductDesc.Location = New System.Drawing.Point(77, 50)
        Me.mProductDesc.MenuManager = Me.RibbonControl1
        Me.mProductDesc.Name = "mProductDesc"
        Me.mProductDesc.Size = New System.Drawing.Size(525, 20)
        Me.mProductDesc.TabIndex = 0
        '
        'pEmptyReturns
        '
        Me.pEmptyReturns.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.pEmptyReturns.Controls.Add(Me.GroupControl3)
        Me.pEmptyReturns.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pEmptyReturns.Location = New System.Drawing.Point(0, 126)
        Me.pEmptyReturns.Name = "pEmptyReturns"
        Me.pEmptyReturns.Size = New System.Drawing.Size(616, 190)
        Me.pEmptyReturns.TabIndex = 29
        '
        'GroupControl3
        '
        Me.GroupControl3.Controls.Add(Label11)
        Me.GroupControl3.Controls.Add(Label3)
        Me.GroupControl3.Controls.Add(Me.CheckEdit1)
        Me.GroupControl3.Controls.Add(Label4)
        Me.GroupControl3.Controls.Add(Me.TextEdit1)
        Me.GroupControl3.Controls.Add(Label5)
        Me.GroupControl3.Controls.Add(Me.TextEdit2)
        Me.GroupControl3.Controls.Add(Label6)
        Me.GroupControl3.Controls.Add(Me.TextEdit3)
        Me.GroupControl3.Controls.Add(Label7)
        Me.GroupControl3.Controls.Add(Me.TextEdit4)
        Me.GroupControl3.Controls.Add(Label8)
        Me.GroupControl3.Controls.Add(Me.TextEdit5)
        Me.GroupControl3.Controls.Add(Label9)
        Me.GroupControl3.Controls.Add(Me.TextEdit6)
        Me.GroupControl3.Controls.Add(Label10)
        Me.GroupControl3.Controls.Add(Me.TextEdit7)
        Me.GroupControl3.Controls.Add(Me.TextEdit8)
        Me.GroupControl3.Controls.Add(Label12)
        Me.GroupControl3.Controls.Add(Me.eEmptyQty)
        Me.GroupControl3.Controls.Add(Me.TextEdit10)
        Me.GroupControl3.Controls.Add(Label13)
        Me.GroupControl3.Controls.Add(Me.luEmptyProductID)
        Me.GroupControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl3.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(616, 190)
        Me.GroupControl3.TabIndex = 0
        Me.GroupControl3.Text = "Empty Containers / Returns"
        '
        'CheckEdit1
        '
        Me.CheckEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsItem, "Billable", True))
        Me.CheckEdit1.Location = New System.Drawing.Point(71, 76)
        Me.CheckEdit1.MenuManager = Me.RibbonControl1
        Me.CheckEdit1.Name = "CheckEdit1"
        Me.CheckEdit1.Properties.Caption = ""
        Me.CheckEdit1.Size = New System.Drawing.Size(75, 19)
        Me.CheckEdit1.TabIndex = 36
        '
        'TextEdit1
        '
        Me.TextEdit1.Location = New System.Drawing.Point(547, 50)
        Me.TextEdit1.MenuManager = Me.RibbonControl1
        Me.TextEdit1.Name = "TextEdit1"
        Me.TextEdit1.Properties.ReadOnly = True
        Me.TextEdit1.Size = New System.Drawing.Size(55, 20)
        Me.TextEdit1.TabIndex = 35
        '
        'TextEdit2
        '
        Me.TextEdit2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsItem, "Container", True))
        Me.TextEdit2.Location = New System.Drawing.Point(231, 50)
        Me.TextEdit2.MenuManager = Me.RibbonControl1
        Me.TextEdit2.Name = "TextEdit2"
        Me.TextEdit2.Properties.ReadOnly = True
        Me.TextEdit2.Size = New System.Drawing.Size(137, 20)
        Me.TextEdit2.TabIndex = 29
        '
        'TextEdit3
        '
        Me.TextEdit3.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsItem, "Ld3", True))
        Me.TextEdit3.Location = New System.Drawing.Point(73, 154)
        Me.TextEdit3.MenuManager = Me.RibbonControl1
        Me.TextEdit3.Name = "TextEdit3"
        Me.TextEdit3.Properties.ReadOnly = True
        Me.TextEdit3.Size = New System.Drawing.Size(529, 20)
        Me.TextEdit3.TabIndex = 25
        '
        'TextEdit4
        '
        Me.TextEdit4.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsItem, "Ld2", True))
        Me.TextEdit4.Location = New System.Drawing.Point(73, 128)
        Me.TextEdit4.MenuManager = Me.RibbonControl1
        Me.TextEdit4.Name = "TextEdit4"
        Me.TextEdit4.Properties.ReadOnly = True
        Me.TextEdit4.Size = New System.Drawing.Size(529, 20)
        Me.TextEdit4.TabIndex = 23
        '
        'TextEdit5
        '
        Me.TextEdit5.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsItem, "Ld1", True))
        Me.TextEdit5.Location = New System.Drawing.Point(73, 102)
        Me.TextEdit5.MenuManager = Me.RibbonControl1
        Me.TextEdit5.Name = "TextEdit5"
        Me.TextEdit5.Properties.ReadOnly = True
        Me.TextEdit5.Size = New System.Drawing.Size(529, 20)
        Me.TextEdit5.TabIndex = 21
        '
        'TextEdit6
        '
        Me.TextEdit6.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsItem, "Totalweight", True))
        Me.TextEdit6.Location = New System.Drawing.Point(73, 50)
        Me.TextEdit6.MenuManager = Me.RibbonControl1
        Me.TextEdit6.Name = "TextEdit6"
        Me.TextEdit6.Properties.ReadOnly = True
        Me.TextEdit6.Size = New System.Drawing.Size(62, 20)
        Me.TextEdit6.TabIndex = 17
        '
        'TextEdit7
        '
        Me.TextEdit7.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsItem, "Stdweight", True))
        Me.TextEdit7.Location = New System.Drawing.Point(430, 50)
        Me.TextEdit7.MenuManager = Me.RibbonControl1
        Me.TextEdit7.Name = "TextEdit7"
        Me.TextEdit7.Properties.ReadOnly = True
        Me.TextEdit7.Size = New System.Drawing.Size(55, 20)
        Me.TextEdit7.TabIndex = 15
        '
        'TextEdit8
        '
        Me.TextEdit8.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsItem, "Batchnumber", True))
        Me.TextEdit8.Location = New System.Drawing.Point(231, 75)
        Me.TextEdit8.MenuManager = Me.RibbonControl1
        Me.TextEdit8.Name = "TextEdit8"
        Me.TextEdit8.Size = New System.Drawing.Size(137, 20)
        Me.TextEdit8.TabIndex = 11
        '
        'eEmptyQty
        '
        Me.eEmptyQty.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsItem, "Qtycontainers", True))
        Me.eEmptyQty.Location = New System.Drawing.Point(73, 24)
        Me.eEmptyQty.MenuManager = Me.RibbonControl1
        Me.eEmptyQty.Name = "eEmptyQty"
        Me.eEmptyQty.Size = New System.Drawing.Size(62, 20)
        Me.eEmptyQty.TabIndex = 9
        '
        'TextEdit10
        '
        Me.TextEdit10.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsItem, "Productdesc", True))
        Me.TextEdit10.Location = New System.Drawing.Point(314, 24)
        Me.TextEdit10.MenuManager = Me.RibbonControl1
        Me.TextEdit10.Name = "TextEdit10"
        Me.TextEdit10.Properties.ReadOnly = True
        Me.TextEdit10.Size = New System.Drawing.Size(288, 20)
        Me.TextEdit10.TabIndex = 7
        '
        'luEmptyProductID
        '
        Me.luEmptyProductID.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsItem, "Productid", True))
        Me.luEmptyProductID.Location = New System.Drawing.Point(231, 24)
        Me.luEmptyProductID.MenuManager = Me.RibbonControl1
        Me.luEmptyProductID.Name = "luEmptyProductID"
        Me.luEmptyProductID.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.luEmptyProductID.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Productid", "Prod ID", 50, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Productdesc", "Description", 150, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Container", "Container", 75, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Desc2", "Addn Desc", 125, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.luEmptyProductID.Properties.DataSource = Me.bsProducts
        Me.luEmptyProductID.Properties.DisplayMember = "Productid"
        Me.luEmptyProductID.Properties.NullText = ""
        Me.luEmptyProductID.Properties.PopupWidth = 400
        Me.luEmptyProductID.Properties.ValueMember = "Productid"
        Me.luEmptyProductID.Size = New System.Drawing.Size(77, 20)
        Me.luEmptyProductID.TabIndex = 5
        '
        'pSamples
        '
        Me.pSamples.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.pSamples.Controls.Add(Me.GroupControl4)
        Me.pSamples.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pSamples.Location = New System.Drawing.Point(0, 126)
        Me.pSamples.Name = "pSamples"
        Me.pSamples.Size = New System.Drawing.Size(616, 190)
        Me.pSamples.TabIndex = 31
        '
        'GroupControl4
        '
        Me.GroupControl4.Controls.Add(Label14)
        Me.GroupControl4.Controls.Add(Label15)
        Me.GroupControl4.Controls.Add(Me.CheckEdit2)
        Me.GroupControl4.Controls.Add(Label17)
        Me.GroupControl4.Controls.Add(Me.sContainer)
        Me.GroupControl4.Controls.Add(Label18)
        Me.GroupControl4.Controls.Add(Me.TextEdit12)
        Me.GroupControl4.Controls.Add(Label19)
        Me.GroupControl4.Controls.Add(Me.TextEdit13)
        Me.GroupControl4.Controls.Add(Label20)
        Me.GroupControl4.Controls.Add(Me.TextEdit14)
        Me.GroupControl4.Controls.Add(Label21)
        Me.GroupControl4.Controls.Add(Me.sTotalWeight)
        Me.GroupControl4.Controls.Add(Me.TextEdit17)
        Me.GroupControl4.Controls.Add(Label23)
        Me.GroupControl4.Controls.Add(Me.sQty)
        Me.GroupControl4.Controls.Add(Me.TextEdit19)
        Me.GroupControl4.Controls.Add(Label24)
        Me.GroupControl4.Controls.Add(Me.luSampleProductID)
        Me.GroupControl4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl4.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl4.Name = "GroupControl4"
        Me.GroupControl4.Size = New System.Drawing.Size(616, 190)
        Me.GroupControl4.TabIndex = 0
        Me.GroupControl4.Text = "Samples"
        '
        'CheckEdit2
        '
        Me.CheckEdit2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsItem, "Billable", True))
        Me.CheckEdit2.Location = New System.Drawing.Point(71, 76)
        Me.CheckEdit2.MenuManager = Me.RibbonControl1
        Me.CheckEdit2.Name = "CheckEdit2"
        Me.CheckEdit2.Properties.Caption = ""
        Me.CheckEdit2.Size = New System.Drawing.Size(75, 19)
        Me.CheckEdit2.TabIndex = 36
        '
        'sContainer
        '
        Me.sContainer.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsItem, "Container", True))
        Me.sContainer.Location = New System.Drawing.Point(231, 50)
        Me.sContainer.MenuManager = Me.RibbonControl1
        Me.sContainer.Name = "sContainer"
        Me.sContainer.Size = New System.Drawing.Size(137, 20)
        Me.sContainer.TabIndex = 29
        '
        'TextEdit12
        '
        Me.TextEdit12.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsItem, "Ld3", True))
        Me.TextEdit12.Location = New System.Drawing.Point(73, 154)
        Me.TextEdit12.MenuManager = Me.RibbonControl1
        Me.TextEdit12.Name = "TextEdit12"
        Me.TextEdit12.Properties.ReadOnly = True
        Me.TextEdit12.Size = New System.Drawing.Size(529, 20)
        Me.TextEdit12.TabIndex = 25
        '
        'TextEdit13
        '
        Me.TextEdit13.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsItem, "Ld2", True))
        Me.TextEdit13.Location = New System.Drawing.Point(73, 128)
        Me.TextEdit13.MenuManager = Me.RibbonControl1
        Me.TextEdit13.Name = "TextEdit13"
        Me.TextEdit13.Properties.ReadOnly = True
        Me.TextEdit13.Size = New System.Drawing.Size(529, 20)
        Me.TextEdit13.TabIndex = 23
        '
        'TextEdit14
        '
        Me.TextEdit14.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsItem, "Ld1", True))
        Me.TextEdit14.Location = New System.Drawing.Point(73, 102)
        Me.TextEdit14.MenuManager = Me.RibbonControl1
        Me.TextEdit14.Name = "TextEdit14"
        Me.TextEdit14.Properties.ReadOnly = True
        Me.TextEdit14.Size = New System.Drawing.Size(529, 20)
        Me.TextEdit14.TabIndex = 21
        '
        'sTotalWeight
        '
        Me.sTotalWeight.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsItem, "Totalweight", True))
        Me.sTotalWeight.Location = New System.Drawing.Point(73, 50)
        Me.sTotalWeight.MenuManager = Me.RibbonControl1
        Me.sTotalWeight.Name = "sTotalWeight"
        Me.sTotalWeight.Size = New System.Drawing.Size(62, 20)
        Me.sTotalWeight.TabIndex = 17
        '
        'TextEdit17
        '
        Me.TextEdit17.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsItem, "Batchnumber", True))
        Me.TextEdit17.Location = New System.Drawing.Point(231, 75)
        Me.TextEdit17.MenuManager = Me.RibbonControl1
        Me.TextEdit17.Name = "TextEdit17"
        Me.TextEdit17.Size = New System.Drawing.Size(137, 20)
        Me.TextEdit17.TabIndex = 11
        '
        'sQty
        '
        Me.sQty.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsItem, "Qtycontainers", True))
        Me.sQty.Location = New System.Drawing.Point(73, 24)
        Me.sQty.MenuManager = Me.RibbonControl1
        Me.sQty.Name = "sQty"
        Me.sQty.Size = New System.Drawing.Size(62, 20)
        Me.sQty.TabIndex = 9
        '
        'TextEdit19
        '
        Me.TextEdit19.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsItem, "Productdesc", True))
        Me.TextEdit19.Location = New System.Drawing.Point(314, 24)
        Me.TextEdit19.MenuManager = Me.RibbonControl1
        Me.TextEdit19.Name = "TextEdit19"
        Me.TextEdit19.Properties.ReadOnly = True
        Me.TextEdit19.Size = New System.Drawing.Size(288, 20)
        Me.TextEdit19.TabIndex = 7
        '
        'luSampleProductID
        '
        Me.luSampleProductID.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsItem, "Productid", True))
        Me.luSampleProductID.Location = New System.Drawing.Point(231, 24)
        Me.luSampleProductID.MenuManager = Me.RibbonControl1
        Me.luSampleProductID.Name = "luSampleProductID"
        Me.luSampleProductID.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.luSampleProductID.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Productid", "Prod ID", 50, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Productdesc", "Description", 150, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Container", "Container", 75, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Desc2", "Addn Desc", 125, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.luSampleProductID.Properties.DataSource = Me.bsProducts
        Me.luSampleProductID.Properties.DisplayMember = "Productid"
        Me.luSampleProductID.Properties.NullText = ""
        Me.luSampleProductID.Properties.PopupWidth = 400
        Me.luSampleProductID.Properties.ValueMember = "Productid"
        Me.luSampleProductID.Size = New System.Drawing.Size(77, 20)
        Me.luSampleProductID.TabIndex = 5
        '
        'frmAddNewShipmentItem
        '
        Me.ClientSize = New System.Drawing.Size(616, 316)
        Me.ControlBox = False
        Me.Controls.Add(Me.pProductScreen)
        Me.Controls.Add(Me.pSamples)
        Me.Controls.Add(Me.pEmptyReturns)
        Me.Controls.Add(Me.pMiscScreen)
        Me.Controls.Add(Me.pItemTypeSelector)
        Me.Controls.Add(Me.RibbonControl1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmAddNewShipmentItem"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Shipment Item Information"
        CType(Me.bsItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsProducts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pItemTypeSelector, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pItemTypeSelector.ResumeLayout(False)
        CType(Me.rbS.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rbM.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rbE.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rbP.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pProductScreen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pProductScreen.ResumeLayout(False)
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.BillableCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eTareWgt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ContainerTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ld3TextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ld2TextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ld1TextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TotalweightTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StdweightTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BatchnumberTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eQty.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductdescTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eProductID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pMiscScreen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pMiscScreen.ResumeLayout(False)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.mBillable.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mTotalWeight.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mQty.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mProductDesc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pEmptyReturns, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pEmptyReturns.ResumeLayout(False)
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        Me.GroupControl3.PerformLayout()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit5.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit6.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit7.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit8.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eEmptyQty.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit10.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.luEmptyProductID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pSamples, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pSamples.ResumeLayout(False)
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl4.ResumeLayout(False)
        Me.GroupControl4.PerformLayout()
        CType(Me.CheckEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sContainer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit12.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit13.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit14.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sTotalWeight.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit17.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sQty.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit19.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.luSampleProductID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents bsProducts As System.Windows.Forms.BindingSource
    Friend WithEvents bsItem As System.Windows.Forms.BindingSource
    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents btnSave As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents btnCancel As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents pItemTypeSelector As DevExpress.XtraEditors.PanelControl
    Friend WithEvents pProductScreen As DevExpress.XtraEditors.PanelControl
    Friend WithEvents pMiscScreen As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents ContainerTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Ld3TextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Ld2TextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Ld1TextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TotalweightTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents StdweightTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents BatchnumberTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents eQty As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ProductdescTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents eProductID As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents BarStaticItem1 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents BarStaticItem2 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents BarStaticItem3 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents rTxtShipmentNumber As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents rtxtPurchaseOrder As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents rTxtCustomerName As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents eTareWgt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents mTotalWeight As DevExpress.XtraEditors.TextEdit
    Friend WithEvents mQty As DevExpress.XtraEditors.TextEdit
    Friend WithEvents mProductDesc As DevExpress.XtraEditors.TextEdit
    Friend WithEvents BillableCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents mBillable As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents pEmptyReturns As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents CheckEdit1 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit3 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit4 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit5 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit6 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit7 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit8 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents eEmptyQty As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit10 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents luEmptyProductID As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents rbM As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents rbE As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents rbP As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents rbS As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents pSamples As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GroupControl4 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents CheckEdit2 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents sContainer As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit12 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit13 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit14 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents sTotalWeight As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit17 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents sQty As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit19 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents luSampleProductID As DevExpress.XtraEditors.LookUpEdit
End Class
