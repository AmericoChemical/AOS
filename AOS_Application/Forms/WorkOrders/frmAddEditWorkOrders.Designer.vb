<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddEditWorkOrders

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
        Dim CustomerpoLabel As System.Windows.Forms.Label
        Dim WorkordertypeLabel As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Dim OnholdLabel As System.Windows.Forms.Label
        Dim OnholdreasonLabel As System.Windows.Forms.Label
        Dim Label15 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddEditWorkOrders))
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject3 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject4 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject5 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject6 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.bsWorkOrder = New System.Windows.Forms.BindingSource(Me.components)
        Me.bsFOB = New System.Windows.Forms.BindingSource(Me.components)
        Me.bsCarriers = New System.Windows.Forms.BindingSource(Me.components)
        Me.bsCustomers = New System.Windows.Forms.BindingSource(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.bsWorkOrderItems = New System.Windows.Forms.BindingSource(Me.components)
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btnSave = New DevExpress.XtraBars.BarButtonItem()
        Me.btnCancel = New DevExpress.XtraBars.BarButtonItem()
        Me.btnAddWOItem = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnEditMatchingItems = New DevExpress.XtraBars.BarButtonItem()
        Me.btnDeleteWOItem = New DevExpress.XtraBars.BarButtonItem()
        Me.btnPrintWorkOrder = New DevExpress.XtraBars.BarButtonItem()
        Me.bTxtOrderStatus = New DevExpress.XtraBars.BarStaticItem()
        Me.bTxtWorkOrderNum = New DevExpress.XtraBars.BarStaticItem()
        Me.bTxtWorkOrderDate = New DevExpress.XtraBars.BarStaticItem()
        Me.rbtnChangeWorkOrderDate = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnChangeHoldStatus = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem5 = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnEditSingleItem = New DevExpress.XtraBars.BarButtonItem()
        Me.btnEditAll = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnAutoPlan = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnEditPlan = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnPrintPlan = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnEmailPlan = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnChangePlannedShipDate = New DevExpress.XtraBars.BarButtonItem()
        Me.btnPrintWorkOrderDocs = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnPickItems = New DevExpress.XtraBars.BarButtonItem()
        Me.WorkOrderImages = New DevExpress.Utils.ImageCollection(Me.components)
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup3 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup5 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup4 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.GroupControl4 = New DevExpress.XtraEditors.GroupControl()
        Me.grWorkOrderItems = New DevExpress.XtraGrid.GridControl()
        Me.grvWorkOrderItems = New AOS.CustomClasses.CustomDevExGridView()
        Me.colItemtype = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colWorkorderitemnumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colWorkordernumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProductid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProductdesc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colContainer = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInvitemnumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemHyperLinkEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit()
        Me.colItemstatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSourcetype = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSourcedocument = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemHyperLinkEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit()
        Me.colSourceStatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCustomerpo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcUnitPrice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcExtPrice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.colItemid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colItemdescription = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIshazardous = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnits = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUom = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colExpr1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCustitemid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnitcost = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colExtprofit = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAvailable = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colExpectedIn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDateNeeded = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEstCompDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNeededBy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.luProductDesc = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.luContainer = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.luStdgallons = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.RepositoryItemHyperLinkEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit()
        Me.pnlLegend = New DevExpress.XtraEditors.PanelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.eGrossWgt = New DevExpress.XtraEditors.TextEdit()
        Me.lblPinkLegend = New DevExpress.XtraEditors.LabelControl()
        Me.lblColorMapping = New DevExpress.XtraEditors.LabelControl()
        Me.lblPinkColor = New DevExpress.XtraEditors.ColorEdit()
        Me.pnlTopWorkOrderInformation = New DevExpress.XtraEditors.PanelControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage5 = New DevExpress.XtraTab.XtraTabPage()
        Me.eGeneralNotes = New DevExpress.XtraEditors.MemoEdit()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.eProdFulfillmentNotes = New DevExpress.XtraEditors.MemoEdit()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.eAccountingNotes = New DevExpress.XtraEditors.MemoEdit()
        Me.XtraTabPage3 = New DevExpress.XtraTab.XtraTabPage()
        Me.eTransportationNotes = New DevExpress.XtraEditors.MemoEdit()
        Me.XtraTabPage4 = New DevExpress.XtraTab.XtraTabPage()
        Me.eBillOfLadingNotes = New DevExpress.XtraEditors.MemoEdit()
        Me.eOrderType = New DevExpress.XtraEditors.LookUpEdit()
        Me.bsListOrderTypes = New System.Windows.Forms.BindingSource(Me.components)
        Me.OnholdreasonTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.OnholdCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.grpTransportation = New DevExpress.XtraEditors.GroupControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.CheckEdit1 = New DevExpress.XtraEditors.CheckEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.eOrSoonerFlag = New DevExpress.XtraEditors.CheckEdit()
        Me.lblCharges = New DevExpress.XtraEditors.LabelControl()
        Me.lblSalesperson = New DevExpress.XtraEditors.LabelControl()
        Me.lblCarrier = New DevExpress.XtraEditors.LabelControl()
        Me.lblAddToInvoice = New DevExpress.XtraEditors.LabelControl()
        Me.lblCustomerBilled = New DevExpress.XtraEditors.LabelControl()
        Me.lblLogistics = New DevExpress.XtraEditors.LabelControl()
        Me.lblDeliveryDate = New DevExpress.XtraEditors.LabelControl()
        Me.lblShippedDate = New DevExpress.XtraEditors.LabelControl()
        Me.eTransportType = New DevExpress.XtraEditors.LookUpEdit()
        Me.bsListTransportTypes = New System.Windows.Forms.BindingSource(Me.components)
        Me.eFreightOnInvoice = New DevExpress.XtraEditors.CheckEdit()
        Me.eCustomerBilled = New DevExpress.XtraEditors.CheckEdit()
        Me.ePlannedDeliveryDate = New DevExpress.XtraEditors.DateEdit()
        Me.ePlannedShippedDate = New DevExpress.XtraEditors.DateEdit()
        Me.eFOB = New DevExpress.XtraEditors.LookUpEdit()
        Me.eLogistics = New DevExpress.XtraEditors.LookUpEdit()
        Me.bsLogistics = New System.Windows.Forms.BindingSource(Me.components)
        Me.eCarrier = New DevExpress.XtraEditors.LookUpEdit()
        Me.eSalesperson = New DevExpress.XtraEditors.LookUpEdit()
        Me.bsListSalespersons = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.btnUpdateCustomerPOAllItems = New DevExpress.XtraEditors.SimpleButton()
        Me.eShipPhone = New DevExpress.XtraEditors.TextEdit()
        Me.eShipCountry = New DevExpress.XtraEditors.TextEdit()
        Me.eShipZip = New DevExpress.XtraEditors.TextEdit()
        Me.eShipState = New DevExpress.XtraEditors.TextEdit()
        Me.eCustPO = New DevExpress.XtraEditors.TextEdit()
        Me.eShipCity = New DevExpress.XtraEditors.TextEdit()
        Me.eShipAddr2 = New DevExpress.XtraEditors.TextEdit()
        Me.eShipAddr1 = New DevExpress.XtraEditors.TextEdit()
        Me.eShipContact = New DevExpress.XtraEditors.TextEdit()
        Me.eCustomer = New DevExpress.XtraEditors.LookUpEdit()
        Me.lblEditInfo = New DevExpress.XtraEditors.LabelControl()
        Me.Note16_ImageCollection = New DevExpress.Utils.ImageCollection(Me.components)
        Me.bsNotes = New System.Windows.Forms.BindingSource(Me.components)
        Me.bsVendors = New System.Windows.Forms.BindingSource(Me.components)
        Me.bsWorkOrderType = New System.Windows.Forms.BindingSource(Me.components)
        Me.SmallImages = New DevExpress.Utils.ImageCollection(Me.components)
        Me.Timer_Lookups = New System.Windows.Forms.Timer(Me.components)
        CustomerpoLabel = New System.Windows.Forms.Label()
        WorkordertypeLabel = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        Label7 = New System.Windows.Forms.Label()
        OnholdLabel = New System.Windows.Forms.Label()
        OnholdreasonLabel = New System.Windows.Forms.Label()
        Label15 = New System.Windows.Forms.Label()
        CType(Me.bsWorkOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsFOB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsCarriers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsCustomers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsWorkOrderItems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WorkOrderImages, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl4.SuspendLayout()
        CType(Me.grWorkOrderItems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grvWorkOrderItems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemHyperLinkEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemHyperLinkEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.luProductDesc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.luContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.luStdgallons, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemHyperLinkEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnlLegend, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlLegend.SuspendLayout()
        CType(Me.eGrossWgt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblPinkColor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnlTopWorkOrderInformation, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTopWorkOrderInformation.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage5.SuspendLayout()
        CType(Me.eGeneralNotes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.eProdFulfillmentNotes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.eAccountingNotes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage3.SuspendLayout()
        CType(Me.eTransportationNotes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage4.SuspendLayout()
        CType(Me.eBillOfLadingNotes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eOrderType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsListOrderTypes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OnholdreasonTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OnholdCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpTransportation, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpTransportation.SuspendLayout()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eOrSoonerFlag.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eTransportType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsListTransportTypes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eFreightOnInvoice.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eCustomerBilled.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ePlannedDeliveryDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ePlannedDeliveryDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ePlannedShippedDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ePlannedShippedDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eFOB.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eLogistics.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsLogistics, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eCarrier.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eSalesperson.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsListSalespersons, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.eShipPhone.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eShipCountry.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eShipZip.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eShipState.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eCustPO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eShipCity.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eShipAddr2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eShipAddr1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eShipContact.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eCustomer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Note16_ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsNotes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsVendors, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsWorkOrderType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SmallImages, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CustomerpoLabel
        '
        CustomerpoLabel.AutoSize = True
        CustomerpoLabel.Location = New System.Drawing.Point(6, 182)
        CustomerpoLabel.Name = "CustomerpoLabel"
        CustomerpoLabel.Size = New System.Drawing.Size(46, 13)
        CustomerpoLabel.TabIndex = 15
        CustomerpoLabel.Text = "Cust PO"
        '
        'WorkordertypeLabel
        '
        WorkordertypeLabel.AutoSize = True
        WorkordertypeLabel.Location = New System.Drawing.Point(23, 30)
        WorkordertypeLabel.Name = "WorkordertypeLabel"
        WorkordertypeLabel.Size = New System.Drawing.Size(31, 13)
        WorkordertypeLabel.TabIndex = 0
        WorkordertypeLabel.Text = "Type"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(6, 156)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(28, 13)
        Label2.TabIndex = 13
        Label2.Text = "Attn"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(6, 54)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(36, 13)
        Label3.TabIndex = 1
        Label3.Text = "Addr1"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(6, 80)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(36, 13)
        Label4.TabIndex = 3
        Label4.Text = "Addr2"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Location = New System.Drawing.Point(6, 104)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(26, 13)
        Label5.TabIndex = 5
        Label5.Text = "CSZ"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Location = New System.Drawing.Point(5, 130)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(34, 13)
        Label6.TabIndex = 9
        Label6.Text = "Cntry"
        '
        'Label7
        '
        Label7.AutoSize = True
        Label7.Location = New System.Drawing.Point(181, 130)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(25, 13)
        Label7.TabIndex = 11
        Label7.Text = "Phn"
        '
        'OnholdLabel
        '
        OnholdLabel.AutoSize = True
        OnholdLabel.Location = New System.Drawing.Point(236, 30)
        OnholdLabel.Name = "OnholdLabel"
        OnholdLabel.Size = New System.Drawing.Size(41, 13)
        OnholdLabel.TabIndex = 3
        OnholdLabel.Text = "Onhold"
        '
        'OnholdreasonLabel
        '
        OnholdreasonLabel.AutoSize = True
        OnholdreasonLabel.Location = New System.Drawing.Point(315, 30)
        OnholdreasonLabel.Name = "OnholdreasonLabel"
        OnholdreasonLabel.Size = New System.Drawing.Size(43, 13)
        OnholdreasonLabel.TabIndex = 5
        OnholdreasonLabel.Text = "Reason"
        '
        'Label15
        '
        Label15.AutoSize = True
        Label15.Location = New System.Drawing.Point(6, 28)
        Label15.Name = "Label15"
        Label15.Size = New System.Drawing.Size(61, 13)
        Label15.TabIndex = 0
        Label15.Text = "Trans Type"
        '
        'bsWorkOrder
        '
        Me.bsWorkOrder.DataSource = GetType(AOS.BusinessObjects.Workorder)
        '
        'bsFOB
        '
        Me.bsFOB.DataSource = GetType(AOS.BusinessObjects.ListFobCollection)
        '
        'bsCarriers
        '
        Me.bsCarriers.DataSource = GetType(AOS.BusinessObjects.CarrierCollection)
        '
        'bsCustomers
        '
        Me.bsCustomers.DataSource = GetType(AOS.BusinessObjects.CustomerCollection)
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'bsWorkOrderItems
        '
        Me.bsWorkOrderItems.DataSource = GetType(AOS.BusinessObjects.ViewWorkOrderItemsScreenCollection)
        '
        'RibbonControl1
        '
        Me.RibbonControl1.ApplicationButtonText = Nothing
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.btnSave, Me.btnCancel, Me.btnAddWOItem, Me.rbtnEditMatchingItems, Me.btnDeleteWOItem, Me.btnPrintWorkOrder, Me.bTxtOrderStatus, Me.bTxtWorkOrderNum, Me.bTxtWorkOrderDate, Me.rbtnChangeWorkOrderDate, Me.rbtnChangeHoldStatus, Me.BarButtonItem1, Me.BarButtonItem2, Me.BarButtonItem3, Me.BarButtonItem4, Me.BarButtonItem5, Me.rbtnEditSingleItem, Me.btnEditAll, Me.rbtnAutoPlan, Me.rbtnEditPlan, Me.rbtnPrintPlan, Me.rbtnEmailPlan, Me.rbtnChangePlannedShipDate, Me.btnPrintWorkOrderDocs, Me.rbtnPickItems})
        Me.RibbonControl1.LargeImages = Me.WorkOrderImages
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.MaxItemId = 33
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide
        Me.RibbonControl1.Size = New System.Drawing.Size(1592, 95)
        Me.RibbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden
        '
        'btnSave
        '
        Me.btnSave.Caption = "Save  Order"
        Me.btnSave.Id = 0
        Me.btnSave.LargeImageIndex = 6
        Me.btnSave.LargeWidth = 60
        Me.btnSave.Name = "btnSave"
        '
        'btnCancel
        '
        Me.btnCancel.Caption = "Cancel Order"
        Me.btnCancel.Id = 1
        Me.btnCancel.LargeImageIndex = 7
        Me.btnCancel.LargeWidth = 60
        Me.btnCancel.Name = "btnCancel"
        '
        'btnAddWOItem
        '
        Me.btnAddWOItem.Caption = "Add New Product"
        Me.btnAddWOItem.Id = 2
        Me.btnAddWOItem.LargeImageIndex = 12
        Me.btnAddWOItem.Name = "btnAddWOItem"
        '
        'rbtnEditMatchingItems
        '
        Me.rbtnEditMatchingItems.Caption = "Edit Matching Items"
        Me.rbtnEditMatchingItems.Id = 3
        Me.rbtnEditMatchingItems.LargeImageIndex = 24
        Me.rbtnEditMatchingItems.Name = "rbtnEditMatchingItems"
        '
        'btnDeleteWOItem
        '
        Me.btnDeleteWOItem.Caption = "Delete Item"
        Me.btnDeleteWOItem.Id = 4
        Me.btnDeleteWOItem.LargeImageIndex = 19
        Me.btnDeleteWOItem.LargeWidth = 50
        Me.btnDeleteWOItem.Name = "btnDeleteWOItem"
        '
        'btnPrintWorkOrder
        '
        Me.btnPrintWorkOrder.Caption = "Print Work Order"
        Me.btnPrintWorkOrder.Enabled = False
        Me.btnPrintWorkOrder.Id = 9
        Me.btnPrintWorkOrder.LargeImageIndex = 5
        Me.btnPrintWorkOrder.LargeWidth = 65
        Me.btnPrintWorkOrder.Name = "btnPrintWorkOrder"
        '
        'bTxtOrderStatus
        '
        Me.bTxtOrderStatus.Caption = "APPROVED"
        Me.bTxtOrderStatus.Id = 10
        Me.bTxtOrderStatus.Name = "bTxtOrderStatus"
        Me.bTxtOrderStatus.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'bTxtWorkOrderNum
        '
        Me.bTxtWorkOrderNum.Caption = "12345"
        Me.bTxtWorkOrderNum.Id = 11
        Me.bTxtWorkOrderNum.ItemAppearance.Hovered.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bTxtWorkOrderNum.ItemAppearance.Hovered.Options.UseFont = True
        Me.bTxtWorkOrderNum.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bTxtWorkOrderNum.ItemAppearance.Normal.Options.UseFont = True
        Me.bTxtWorkOrderNum.Name = "bTxtWorkOrderNum"
        Me.bTxtWorkOrderNum.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'bTxtWorkOrderDate
        '
        Me.bTxtWorkOrderDate.Caption = "12/31/2099"
        Me.bTxtWorkOrderDate.Id = 12
        Me.bTxtWorkOrderDate.ItemAppearance.Hovered.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bTxtWorkOrderDate.ItemAppearance.Hovered.Options.UseFont = True
        Me.bTxtWorkOrderDate.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bTxtWorkOrderDate.ItemAppearance.Normal.Options.UseFont = True
        Me.bTxtWorkOrderDate.Name = "bTxtWorkOrderDate"
        Me.bTxtWorkOrderDate.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'rbtnChangeWorkOrderDate
        '
        Me.rbtnChangeWorkOrderDate.Caption = "Change Work Order Date"
        Me.rbtnChangeWorkOrderDate.Id = 13
        Me.rbtnChangeWorkOrderDate.LargeImageIndex = 22
        Me.rbtnChangeWorkOrderDate.Name = "rbtnChangeWorkOrderDate"
        '
        'rbtnChangeHoldStatus
        '
        Me.rbtnChangeHoldStatus.Caption = "Change On Hold Status"
        Me.rbtnChangeHoldStatus.Id = 14
        Me.rbtnChangeHoldStatus.LargeImageIndex = 21
        Me.rbtnChangeHoldStatus.Name = "rbtnChangeHoldStatus"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Add New Sample"
        Me.BarButtonItem1.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.BarButtonItem1.Id = 15
        Me.BarButtonItem1.LargeImageIndex = 13
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "Add New Reagent"
        Me.BarButtonItem2.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.BarButtonItem2.Id = 16
        Me.BarButtonItem2.LargeImageIndex = 16
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "Add New Equipment"
        Me.BarButtonItem3.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.BarButtonItem3.Id = 17
        Me.BarButtonItem3.LargeImageIndex = 15
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'BarButtonItem4
        '
        Me.BarButtonItem4.Caption = "Add New Empty Item"
        Me.BarButtonItem4.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.BarButtonItem4.Id = 18
        Me.BarButtonItem4.LargeImageIndex = 14
        Me.BarButtonItem4.Name = "BarButtonItem4"
        '
        'BarButtonItem5
        '
        Me.BarButtonItem5.Caption = "Add New Misc Item"
        Me.BarButtonItem5.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.BarButtonItem5.Id = 19
        Me.BarButtonItem5.LargeImageIndex = 17
        Me.BarButtonItem5.Name = "BarButtonItem5"
        '
        'rbtnEditSingleItem
        '
        Me.rbtnEditSingleItem.Caption = "Edit Single Item"
        Me.rbtnEditSingleItem.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.rbtnEditSingleItem.Id = 21
        Me.rbtnEditSingleItem.LargeImageIndex = 18
        Me.rbtnEditSingleItem.Name = "rbtnEditSingleItem"
        '
        'btnEditAll
        '
        Me.btnEditAll.Caption = "Edit All"
        Me.btnEditAll.Id = 22
        Me.btnEditAll.LargeImageIndex = 23
        Me.btnEditAll.Name = "btnEditAll"
        '
        'rbtnAutoPlan
        '
        Me.rbtnAutoPlan.Caption = "Auto" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Plan"
        Me.rbtnAutoPlan.Id = 13
        Me.rbtnAutoPlan.LargeImageIndex = 0
        Me.rbtnAutoPlan.Name = "rbtnAutoPlan"
        '
        'rbtnEditPlan
        '
        Me.rbtnEditPlan.Caption = "Edit" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Plan"
        Me.rbtnEditPlan.Id = 13
        Me.rbtnEditPlan.LargeImageIndex = 0
        Me.rbtnEditPlan.Name = "rbtnEditPlan"
        '
        'rbtnPrintPlan
        '
        Me.rbtnPrintPlan.Caption = "Print" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Plan"
        Me.rbtnPrintPlan.Id = 23
        Me.rbtnPrintPlan.LargeImageIndex = 0
        Me.rbtnPrintPlan.Name = "rbtnPrintPlan"
        '
        'rbtnEmailPlan
        '
        Me.rbtnEmailPlan.Caption = "Email Plan"
        Me.rbtnEmailPlan.Id = 24
        Me.rbtnEmailPlan.LargeImageIndex = 0
        Me.rbtnEmailPlan.Name = "rbtnEmailPlan"
        '
        'rbtnChangePlannedShipDate
        '
        Me.rbtnChangePlannedShipDate.Caption = "Change Planned Ship Date"
        Me.rbtnChangePlannedShipDate.Id = 30
        Me.rbtnChangePlannedShipDate.LargeImageIndex = 22
        Me.rbtnChangePlannedShipDate.Name = "rbtnChangePlannedShipDate"
        '
        'btnPrintWorkOrderDocs
        '
        Me.btnPrintWorkOrderDocs.Caption = "Print WO Docs"
        Me.btnPrintWorkOrderDocs.Enabled = False
        Me.btnPrintWorkOrderDocs.Id = 31
        Me.btnPrintWorkOrderDocs.LargeImageIndex = 5
        Me.btnPrintWorkOrderDocs.Name = "btnPrintWorkOrderDocs"
        '
        'rbtnPickItems
        '
        Me.rbtnPickItems.Caption = "Pick Items for Shipment"
        Me.rbtnPickItems.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.rbtnPickItems.Id = 32
        Me.rbtnPickItems.LargeImageIndex = 11
        Me.rbtnPickItems.Name = "rbtnPickItems"
        '
        'WorkOrderImages
        '
        Me.WorkOrderImages.ImageSize = New System.Drawing.Size(32, 32)
        Me.WorkOrderImages.ImageStream = CType(resources.GetObject("WorkOrderImages.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup3, Me.RibbonPageGroup1, Me.RibbonPageGroup2, Me.RibbonPageGroup5, Me.RibbonPageGroup4})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "RibbonPage1"
        '
        'RibbonPageGroup3
        '
        Me.RibbonPageGroup3.AllowMinimize = False
        Me.RibbonPageGroup3.AllowTextClipping = False
        Me.RibbonPageGroup3.ItemLinks.Add(Me.bTxtWorkOrderNum)
        Me.RibbonPageGroup3.ItemLinks.Add(Me.bTxtWorkOrderDate)
        Me.RibbonPageGroup3.ItemLinks.Add(Me.bTxtOrderStatus)
        Me.RibbonPageGroup3.Name = "RibbonPageGroup3"
        Me.RibbonPageGroup3.ShowCaptionButton = False
        Me.RibbonPageGroup3.Text = "Order Info"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.AllowTextClipping = False
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnSave, True)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnCancel)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnPrintWorkOrder, True)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnPrintWorkOrderDocs)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.ShowCaptionButton = False
        Me.RibbonPageGroup1.Text = "Work Order"
        '
        'RibbonPageGroup2
        '
        Me.RibbonPageGroup2.AllowMinimize = False
        Me.RibbonPageGroup2.AllowTextClipping = False
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btnAddWOItem)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.BarButtonItem1)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.BarButtonItem4)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.BarButtonItem5)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.BarButtonItem2)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.BarButtonItem3)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.rbtnEditMatchingItems, True)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.rbtnEditSingleItem)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btnDeleteWOItem, True)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.ShowCaptionButton = False
        Me.RibbonPageGroup2.Text = "Work Order Items"
        '
        'RibbonPageGroup5
        '
        Me.RibbonPageGroup5.AllowMinimize = False
        Me.RibbonPageGroup5.AllowTextClipping = False
        Me.RibbonPageGroup5.ItemLinks.Add(Me.rbtnAutoPlan)
        Me.RibbonPageGroup5.ItemLinks.Add(Me.rbtnEditPlan)
        Me.RibbonPageGroup5.ItemLinks.Add(Me.rbtnPrintPlan, True)
        Me.RibbonPageGroup5.ItemLinks.Add(Me.rbtnEmailPlan)
        Me.RibbonPageGroup5.Name = "RibbonPageGroup5"
        Me.RibbonPageGroup5.ShowCaptionButton = False
        Me.RibbonPageGroup5.Text = "Fulfillment Plan"
        '
        'RibbonPageGroup4
        '
        Me.RibbonPageGroup4.AllowMinimize = False
        Me.RibbonPageGroup4.AllowTextClipping = False
        Me.RibbonPageGroup4.ItemLinks.Add(Me.rbtnChangeWorkOrderDate)
        Me.RibbonPageGroup4.ItemLinks.Add(Me.rbtnChangePlannedShipDate, True)
        Me.RibbonPageGroup4.ItemLinks.Add(Me.rbtnChangeHoldStatus, True)
        Me.RibbonPageGroup4.ItemLinks.Add(Me.btnEditAll)
        Me.RibbonPageGroup4.ItemLinks.Add(Me.rbtnPickItems, True)
        Me.RibbonPageGroup4.Name = "RibbonPageGroup4"
        Me.RibbonPageGroup4.ShowCaptionButton = False
        Me.RibbonPageGroup4.Text = "Order Management"
        '
        'PanelControl1
        '
        Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl1.Controls.Add(Me.GroupControl4)
        Me.PanelControl1.Controls.Add(Me.pnlTopWorkOrderInformation)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(0, 95)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1592, 557)
        Me.PanelControl1.TabIndex = 1
        '
        'GroupControl4
        '
        Me.GroupControl4.Controls.Add(Me.grWorkOrderItems)
        Me.GroupControl4.Controls.Add(Me.pnlLegend)
        Me.GroupControl4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl4.Location = New System.Drawing.Point(0, 278)
        Me.GroupControl4.Name = "GroupControl4"
        Me.GroupControl4.Size = New System.Drawing.Size(1592, 279)
        Me.GroupControl4.TabIndex = 1
        Me.GroupControl4.Text = "Work Order Items"
        '
        'grWorkOrderItems
        '
        Me.grWorkOrderItems.DataSource = Me.bsWorkOrderItems
        Me.grWorkOrderItems.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grWorkOrderItems.Location = New System.Drawing.Point(2, 51)
        Me.grWorkOrderItems.MainView = Me.grvWorkOrderItems
        Me.grWorkOrderItems.Name = "grWorkOrderItems"
        Me.grWorkOrderItems.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.luProductDesc, Me.luContainer, Me.luStdgallons, Me.RepositoryItemCheckEdit1, Me.RepositoryItemLookUpEdit1, Me.RepositoryItemCheckEdit2, Me.RepositoryItemHyperLinkEdit1, Me.RepositoryItemHyperLinkEdit2, Me.RepositoryItemHyperLinkEdit3})
        Me.grWorkOrderItems.Size = New System.Drawing.Size(1588, 226)
        Me.grWorkOrderItems.TabIndex = 0
        Me.grWorkOrderItems.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grvWorkOrderItems})
        '
        'grvWorkOrderItems
        '
        Me.grvWorkOrderItems.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colItemtype, Me.GridColumn1, Me.colWorkorderitemnumber, Me.colWorkordernumber, Me.colProductid, Me.colProductdesc, Me.colContainer, Me.colQty, Me.colInvitemnumber, Me.colItemstatus, Me.colSourcetype, Me.colSourcedocument, Me.colSourceStatus, Me.colCustomerpo, Me.gcUnitPrice, Me.gcExtPrice, Me.GridColumn2, Me.colItemid, Me.colItemdescription, Me.colIshazardous, Me.colUnits, Me.colUom, Me.colExpr1, Me.colCustitemid, Me.colUnitcost, Me.colExtprofit, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.colAvailable, Me.colExpectedIn, Me.colDateNeeded, Me.colEstCompDate, Me.colNeededBy})
        Me.grvWorkOrderItems.GridControl = Me.grWorkOrderItems
        Me.grvWorkOrderItems.Name = "grvWorkOrderItems"
        Me.grvWorkOrderItems.OptionsBehavior.Editable = False
        Me.grvWorkOrderItems.OptionsView.ShowFooter = True
        Me.grvWorkOrderItems.OptionsView.ShowGroupPanel = False
        Me.grvWorkOrderItems.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colItemtype, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colItemtype
        '
        Me.colItemtype.Caption = "Type"
        Me.colItemtype.FieldName = "Itemtype"
        Me.colItemtype.Name = "colItemtype"
        Me.colItemtype.OptionsColumn.AllowEdit = False
        Me.colItemtype.OptionsColumn.FixedWidth = True
        Me.colItemtype.Visible = True
        Me.colItemtype.VisibleIndex = 1
        Me.colItemtype.Width = 56
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "U/C"
        Me.GridColumn1.FieldName = "Unitorcontainer"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.AllowEdit = False
        Me.GridColumn1.OptionsColumn.FixedWidth = True
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 3
        Me.GridColumn1.Width = 30
        '
        'colWorkorderitemnumber
        '
        Me.colWorkorderitemnumber.Caption = "Seq"
        Me.colWorkorderitemnumber.FieldName = "Workorderitemnumber"
        Me.colWorkorderitemnumber.Name = "colWorkorderitemnumber"
        Me.colWorkorderitemnumber.OptionsColumn.FixedWidth = True
        Me.colWorkorderitemnumber.Visible = True
        Me.colWorkorderitemnumber.VisibleIndex = 0
        Me.colWorkorderitemnumber.Width = 45
        '
        'colWorkordernumber
        '
        Me.colWorkordernumber.FieldName = "Workordernumber"
        Me.colWorkordernumber.Name = "colWorkordernumber"
        Me.colWorkordernumber.OptionsColumn.FixedWidth = True
        '
        'colProductid
        '
        Me.colProductid.Caption = "Prod ID"
        Me.colProductid.FieldName = "Productid"
        Me.colProductid.Name = "colProductid"
        Me.colProductid.OptionsColumn.FixedWidth = True
        Me.colProductid.Width = 46
        '
        'colProductdesc
        '
        Me.colProductdesc.Caption = "Prod Desc"
        Me.colProductdesc.FieldName = "Productdesc"
        Me.colProductdesc.Name = "colProductdesc"
        Me.colProductdesc.Width = 178
        '
        'colContainer
        '
        Me.colContainer.Caption = "Container"
        Me.colContainer.FieldName = "Container"
        Me.colContainer.Name = "colContainer"
        Me.colContainer.OptionsColumn.AllowEdit = False
        Me.colContainer.OptionsColumn.FixedWidth = True
        Me.colContainer.Visible = True
        Me.colContainer.VisibleIndex = 4
        Me.colContainer.Width = 60
        '
        'colQty
        '
        Me.colQty.Caption = "Qty"
        Me.colQty.FieldName = "Qty"
        Me.colQty.Name = "colQty"
        Me.colQty.OptionsColumn.AllowEdit = False
        Me.colQty.OptionsColumn.FixedWidth = True
        Me.colQty.Visible = True
        Me.colQty.VisibleIndex = 2
        Me.colQty.Width = 52
        '
        'colInvitemnumber
        '
        Me.colInvitemnumber.AppearanceCell.Options.UseTextOptions = True
        Me.colInvitemnumber.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colInvitemnumber.Caption = "Item #"
        Me.colInvitemnumber.ColumnEdit = Me.RepositoryItemHyperLinkEdit2
        Me.colInvitemnumber.FieldName = "Invitemnumber"
        Me.colInvitemnumber.Name = "colInvitemnumber"
        Me.colInvitemnumber.OptionsColumn.AllowEdit = False
        Me.colInvitemnumber.OptionsColumn.FixedWidth = True
        Me.colInvitemnumber.Visible = True
        Me.colInvitemnumber.VisibleIndex = 10
        Me.colInvitemnumber.Width = 55
        '
        'RepositoryItemHyperLinkEdit2
        '
        Me.RepositoryItemHyperLinkEdit2.AutoHeight = False
        Me.RepositoryItemHyperLinkEdit2.Name = "RepositoryItemHyperLinkEdit2"
        '
        'colItemstatus
        '
        Me.colItemstatus.Caption = "Inv Status"
        Me.colItemstatus.FieldName = "Itemstatus"
        Me.colItemstatus.Name = "colItemstatus"
        Me.colItemstatus.OptionsColumn.AllowEdit = False
        Me.colItemstatus.OptionsColumn.FixedWidth = True
        Me.colItemstatus.Visible = True
        Me.colItemstatus.VisibleIndex = 12
        Me.colItemstatus.Width = 74
        '
        'colSourcetype
        '
        Me.colSourcetype.AppearanceCell.Options.UseTextOptions = True
        Me.colSourcetype.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colSourcetype.Caption = "Src Type"
        Me.colSourcetype.FieldName = "Sourcetype"
        Me.colSourcetype.Name = "colSourcetype"
        Me.colSourcetype.OptionsColumn.AllowEdit = False
        Me.colSourcetype.OptionsColumn.FixedWidth = True
        Me.colSourcetype.Visible = True
        Me.colSourcetype.VisibleIndex = 7
        Me.colSourcetype.Width = 53
        '
        'colSourcedocument
        '
        Me.colSourcedocument.AppearanceCell.Options.UseTextOptions = True
        Me.colSourcedocument.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colSourcedocument.Caption = "Src Doc"
        Me.colSourcedocument.ColumnEdit = Me.RepositoryItemHyperLinkEdit3
        Me.colSourcedocument.FieldName = "Sourcedocument"
        Me.colSourcedocument.Name = "colSourcedocument"
        Me.colSourcedocument.OptionsColumn.AllowEdit = False
        Me.colSourcedocument.OptionsColumn.FixedWidth = True
        Me.colSourcedocument.Visible = True
        Me.colSourcedocument.VisibleIndex = 8
        Me.colSourcedocument.Width = 50
        '
        'RepositoryItemHyperLinkEdit3
        '
        Me.RepositoryItemHyperLinkEdit3.AutoHeight = False
        Me.RepositoryItemHyperLinkEdit3.Name = "RepositoryItemHyperLinkEdit3"
        '
        'colSourceStatus
        '
        Me.colSourceStatus.Caption = "Src Status"
        Me.colSourceStatus.FieldName = "Sourcestatus"
        Me.colSourceStatus.Name = "colSourceStatus"
        Me.colSourceStatus.OptionsColumn.FixedWidth = True
        Me.colSourceStatus.Visible = True
        Me.colSourceStatus.VisibleIndex = 9
        Me.colSourceStatus.Width = 70
        '
        'colCustomerpo
        '
        Me.colCustomerpo.Caption = "Cust PO"
        Me.colCustomerpo.FieldName = "Customerpo"
        Me.colCustomerpo.Name = "colCustomerpo"
        Me.colCustomerpo.OptionsColumn.AllowEdit = False
        Me.colCustomerpo.OptionsColumn.FixedWidth = True
        Me.colCustomerpo.Visible = True
        Me.colCustomerpo.VisibleIndex = 13
        Me.colCustomerpo.Width = 70
        '
        'gcUnitPrice
        '
        Me.gcUnitPrice.AppearanceHeader.Options.UseTextOptions = True
        Me.gcUnitPrice.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.gcUnitPrice.Caption = "Ext Cost"
        Me.gcUnitPrice.DisplayFormat.FormatString = "c2"
        Me.gcUnitPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.gcUnitPrice.FieldName = "Extcost"
        Me.gcUnitPrice.Name = "gcUnitPrice"
        Me.gcUnitPrice.OptionsColumn.AllowEdit = False
        Me.gcUnitPrice.OptionsColumn.FixedWidth = True
        Me.gcUnitPrice.Visible = True
        Me.gcUnitPrice.VisibleIndex = 18
        Me.gcUnitPrice.Width = 53
        '
        'gcExtPrice
        '
        Me.gcExtPrice.AppearanceHeader.Options.UseTextOptions = True
        Me.gcExtPrice.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.gcExtPrice.Caption = "Ext Price"
        Me.gcExtPrice.DisplayFormat.FormatString = "c2"
        Me.gcExtPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.gcExtPrice.FieldName = "Extprice"
        Me.gcExtPrice.Name = "gcExtPrice"
        Me.gcExtPrice.OptionsColumn.AllowEdit = False
        Me.gcExtPrice.OptionsColumn.FixedWidth = True
        Me.gcExtPrice.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Extprice", "$ {0:#,#.#0}")})
        Me.gcExtPrice.Visible = True
        Me.gcExtPrice.VisibleIndex = 19
        Me.gcExtPrice.Width = 53
        '
        'GridColumn2
        '
        Me.GridColumn2.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn2.Caption = "Billable"
        Me.GridColumn2.ColumnEdit = Me.RepositoryItemCheckEdit2
        Me.GridColumn2.FieldName = "Billable"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.AllowEdit = False
        Me.GridColumn2.OptionsColumn.FixedWidth = True
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 21
        Me.GridColumn2.Width = 42
        '
        'RepositoryItemCheckEdit2
        '
        Me.RepositoryItemCheckEdit2.AutoHeight = False
        Me.RepositoryItemCheckEdit2.Caption = "Check"
        Me.RepositoryItemCheckEdit2.Name = "RepositoryItemCheckEdit2"
        '
        'colItemid
        '
        Me.colItemid.Caption = "Item ID"
        Me.colItemid.FieldName = "Itemid"
        Me.colItemid.Name = "colItemid"
        Me.colItemid.OptionsColumn.AllowEdit = False
        Me.colItemid.OptionsColumn.FixedWidth = True
        Me.colItemid.Visible = True
        Me.colItemid.VisibleIndex = 5
        Me.colItemid.Width = 50
        '
        'colItemdescription
        '
        Me.colItemdescription.Caption = "Item Description"
        Me.colItemdescription.FieldName = "Itemdescription"
        Me.colItemdescription.Name = "colItemdescription"
        Me.colItemdescription.OptionsColumn.AllowEdit = False
        Me.colItemdescription.Visible = True
        Me.colItemdescription.VisibleIndex = 6
        Me.colItemdescription.Width = 295
        '
        'colIshazardous
        '
        Me.colIshazardous.AppearanceHeader.Options.UseTextOptions = True
        Me.colIshazardous.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colIshazardous.Caption = "Haz"
        Me.colIshazardous.FieldName = "Ishazardous"
        Me.colIshazardous.Name = "colIshazardous"
        Me.colIshazardous.OptionsColumn.AllowEdit = False
        Me.colIshazardous.OptionsColumn.FixedWidth = True
        Me.colIshazardous.Visible = True
        Me.colIshazardous.VisibleIndex = 22
        Me.colIshazardous.Width = 28
        '
        'colUnits
        '
        Me.colUnits.FieldName = "Units"
        Me.colUnits.Name = "colUnits"
        Me.colUnits.OptionsColumn.FixedWidth = True
        Me.colUnits.Width = 31
        '
        'colUom
        '
        Me.colUom.FieldName = "Uom"
        Me.colUom.Name = "colUom"
        Me.colUom.OptionsColumn.FixedWidth = True
        Me.colUom.Width = 30
        '
        'colExpr1
        '
        Me.colExpr1.Caption = "LOT #"
        Me.colExpr1.FieldName = "Lotnumber"
        Me.colExpr1.Name = "colExpr1"
        Me.colExpr1.OptionsColumn.AllowEdit = False
        Me.colExpr1.OptionsColumn.FixedWidth = True
        Me.colExpr1.Visible = True
        Me.colExpr1.VisibleIndex = 11
        Me.colExpr1.Width = 65
        '
        'colCustitemid
        '
        Me.colCustitemid.Caption = "Cust Item #"
        Me.colCustitemid.FieldName = "Custitemid"
        Me.colCustitemid.Name = "colCustitemid"
        Me.colCustitemid.OptionsColumn.AllowEdit = False
        Me.colCustitemid.OptionsColumn.FixedWidth = True
        Me.colCustitemid.Visible = True
        Me.colCustitemid.VisibleIndex = 14
        Me.colCustitemid.Width = 74
        '
        'colUnitcost
        '
        Me.colUnitcost.AppearanceHeader.Options.UseTextOptions = True
        Me.colUnitcost.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colUnitcost.Caption = "Unit Cost"
        Me.colUnitcost.DisplayFormat.FormatString = "c3"
        Me.colUnitcost.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colUnitcost.FieldName = "Unitcost"
        Me.colUnitcost.Name = "colUnitcost"
        Me.colUnitcost.OptionsColumn.FixedWidth = True
        Me.colUnitcost.Width = 67
        '
        'colExtprofit
        '
        Me.colExtprofit.AppearanceHeader.Options.UseTextOptions = True
        Me.colExtprofit.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colExtprofit.Caption = "Margin"
        Me.colExtprofit.DisplayFormat.FormatString = "c2"
        Me.colExtprofit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colExtprofit.FieldName = "Extprofit"
        Me.colExtprofit.Name = "colExtprofit"
        Me.colExtprofit.OptionsColumn.AllowEdit = False
        Me.colExtprofit.OptionsColumn.FixedWidth = True
        Me.colExtprofit.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Extprofit", "$ {0:#,#.#0}")})
        Me.colExtprofit.Visible = True
        Me.colExtprofit.VisibleIndex = 20
        Me.colExtprofit.Width = 50
        '
        'GridColumn3
        '
        Me.GridColumn3.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn3.Caption = "Std Unit $"
        Me.GridColumn3.DisplayFormat.FormatString = "c2"
        Me.GridColumn3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn3.FieldName = "Standardunitcost"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.AllowEdit = False
        Me.GridColumn3.OptionsColumn.FixedWidth = True
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 15
        Me.GridColumn3.Width = 58
        '
        'GridColumn4
        '
        Me.GridColumn4.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn4.Caption = "Act Unit $"
        Me.GridColumn4.DisplayFormat.FormatString = "c2"
        Me.GridColumn4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn4.FieldName = "Actualunitcost"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.OptionsColumn.AllowEdit = False
        Me.GridColumn4.OptionsColumn.FixedWidth = True
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 16
        Me.GridColumn4.Width = 58
        '
        'GridColumn5
        '
        Me.GridColumn5.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn5.Caption = "Unit Price $"
        Me.GridColumn5.DisplayFormat.FormatString = "c2"
        Me.GridColumn5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn5.FieldName = "Unitprice"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.OptionsColumn.AllowEdit = False
        Me.GridColumn5.OptionsColumn.FixedWidth = True
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 17
        Me.GridColumn5.Width = 68
        '
        'colAvailable
        '
        Me.colAvailable.Caption = "Available"
        Me.colAvailable.DisplayFormat.FormatString = "d"
        Me.colAvailable.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colAvailable.FieldName = "Available"
        Me.colAvailable.Name = "colAvailable"
        Me.colAvailable.OptionsColumn.FixedWidth = True
        Me.colAvailable.Visible = True
        Me.colAvailable.VisibleIndex = 23
        Me.colAvailable.Width = 65
        '
        'colExpectedIn
        '
        Me.colExpectedIn.Caption = "Expected In"
        Me.colExpectedIn.FieldName = "Expectedindate"
        Me.colExpectedIn.Name = "colExpectedIn"
        Me.colExpectedIn.OptionsColumn.FixedWidth = True
        '
        'colDateNeeded
        '
        Me.colDateNeeded.Caption = "Date Needed"
        Me.colDateNeeded.FieldName = "Dateneeded"
        Me.colDateNeeded.Name = "colDateNeeded"
        Me.colDateNeeded.OptionsColumn.FixedWidth = True
        '
        'colEstCompDate
        '
        Me.colEstCompDate.Caption = "EstCompDate"
        Me.colEstCompDate.FieldName = "Estimatedcompletiondate"
        Me.colEstCompDate.Name = "colEstCompDate"
        Me.colEstCompDate.OptionsColumn.FixedWidth = True
        '
        'colNeededBy
        '
        Me.colNeededBy.Caption = "NeededBy"
        Me.colNeededBy.FieldName = "Neededby"
        Me.colNeededBy.Name = "colNeededBy"
        Me.colNeededBy.OptionsColumn.FixedWidth = True
        '
        'luProductDesc
        '
        Me.luProductDesc.AutoHeight = False
        Me.luProductDesc.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.luProductDesc.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Productdesc", "Productdesc", 65, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.luProductDesc.DisplayMember = "Productdesc"
        Me.luProductDesc.Name = "luProductDesc"
        Me.luProductDesc.NullText = ""
        Me.luProductDesc.ReadOnly = True
        Me.luProductDesc.ShowFooter = False
        Me.luProductDesc.ShowHeader = False
        Me.luProductDesc.ShowLines = False
        Me.luProductDesc.ValueMember = "Productid"
        '
        'luContainer
        '
        Me.luContainer.AutoHeight = False
        Me.luContainer.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.luContainer.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Container", "Container", 53, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.luContainer.DisplayMember = "Container"
        Me.luContainer.Name = "luContainer"
        Me.luContainer.NullText = ""
        Me.luContainer.ReadOnly = True
        Me.luContainer.ShowFooter = False
        Me.luContainer.ShowHeader = False
        Me.luContainer.ValueMember = "Productid"
        '
        'luStdgallons
        '
        Me.luStdgallons.AutoHeight = False
        Me.luStdgallons.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.luStdgallons.DisplayMember = "Stdgallons"
        Me.luStdgallons.Name = "luStdgallons"
        Me.luStdgallons.NullText = ""
        Me.luStdgallons.ReadOnly = True
        Me.luStdgallons.ValueMember = "Productid"
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Caption = "Check"
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.DisplayMember = "Desc2"
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        Me.RepositoryItemLookUpEdit1.NullText = ""
        Me.RepositoryItemLookUpEdit1.ValueMember = "Productid"
        '
        'RepositoryItemHyperLinkEdit1
        '
        Me.RepositoryItemHyperLinkEdit1.AutoHeight = False
        Me.RepositoryItemHyperLinkEdit1.Name = "RepositoryItemHyperLinkEdit1"
        '
        'pnlLegend
        '
        Me.pnlLegend.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.pnlLegend.Controls.Add(Me.LabelControl2)
        Me.pnlLegend.Controls.Add(Me.eGrossWgt)
        Me.pnlLegend.Controls.Add(Me.lblPinkLegend)
        Me.pnlLegend.Controls.Add(Me.lblColorMapping)
        Me.pnlLegend.Controls.Add(Me.lblPinkColor)
        Me.pnlLegend.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlLegend.Location = New System.Drawing.Point(2, 22)
        Me.pnlLegend.Name = "pnlLegend"
        Me.pnlLegend.Size = New System.Drawing.Size(1588, 29)
        Me.pnlLegend.TabIndex = 8
        '
        'LabelControl2
        '
        Me.LabelControl2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl2.Location = New System.Drawing.Point(1453, 6)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(50, 13)
        Me.LabelControl2.TabIndex = 7
        Me.LabelControl2.Text = "Gross Wgt"
        '
        'eGrossWgt
        '
        Me.eGrossWgt.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.eGrossWgt.Location = New System.Drawing.Point(1509, 3)
        Me.eGrossWgt.MenuManager = Me.RibbonControl1
        Me.eGrossWgt.Name = "eGrossWgt"
        Me.eGrossWgt.Properties.Appearance.Options.UseTextOptions = True
        Me.eGrossWgt.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.eGrossWgt.Properties.DisplayFormat.FormatString = "n0"
        Me.eGrossWgt.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.eGrossWgt.Properties.ReadOnly = True
        Me.eGrossWgt.Size = New System.Drawing.Size(69, 20)
        Me.eGrossWgt.TabIndex = 6
        Me.eGrossWgt.TabStop = False
        '
        'lblPinkLegend
        '
        Me.lblPinkLegend.Location = New System.Drawing.Point(123, 6)
        Me.lblPinkLegend.Name = "lblPinkLegend"
        Me.lblPinkLegend.Size = New System.Drawing.Size(51, 13)
        Me.lblPinkLegend.TabIndex = 5
        Me.lblPinkLegend.Text = "Late Items"
        '
        'lblColorMapping
        '
        Me.lblColorMapping.Location = New System.Drawing.Point(9, 6)
        Me.lblColorMapping.Name = "lblColorMapping"
        Me.lblColorMapping.Size = New System.Drawing.Size(72, 13)
        Me.lblColorMapping.TabIndex = 4
        Me.lblColorMapping.Text = "Color Mapping:"
        '
        'lblPinkColor
        '
        Me.lblPinkColor.EditValue = System.Drawing.Color.Pink
        Me.lblPinkColor.Location = New System.Drawing.Point(89, 4)
        Me.lblPinkColor.MenuManager = Me.RibbonControl1
        Me.lblPinkColor.Name = "lblPinkColor"
        Me.lblPinkColor.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.lblPinkColor.Properties.Appearance.Options.UseBackColor = True
        Me.lblPinkColor.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.lblPinkColor.Properties.ReadOnly = True
        Me.lblPinkColor.Size = New System.Drawing.Size(28, 18)
        Me.lblPinkColor.TabIndex = 0
        Me.lblPinkColor.TabStop = False
        '
        'pnlTopWorkOrderInformation
        '
        Me.pnlTopWorkOrderInformation.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.pnlTopWorkOrderInformation.Controls.Add(Me.GroupControl1)
        Me.pnlTopWorkOrderInformation.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTopWorkOrderInformation.Location = New System.Drawing.Point(0, 0)
        Me.pnlTopWorkOrderInformation.Name = "pnlTopWorkOrderInformation"
        Me.pnlTopWorkOrderInformation.Size = New System.Drawing.Size(1592, 278)
        Me.pnlTopWorkOrderInformation.TabIndex = 5
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.XtraTabControl1)
        Me.GroupControl1.Controls.Add(Me.eOrderType)
        Me.GroupControl1.Controls.Add(OnholdreasonLabel)
        Me.GroupControl1.Controls.Add(Me.OnholdreasonTextEdit)
        Me.GroupControl1.Controls.Add(OnholdLabel)
        Me.GroupControl1.Controls.Add(Me.OnholdCheckEdit)
        Me.GroupControl1.Controls.Add(Me.grpTransportation)
        Me.GroupControl1.Controls.Add(Me.GroupControl3)
        Me.GroupControl1.Controls.Add(WorkordertypeLabel)
        Me.GroupControl1.Controls.Add(Me.lblEditInfo)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(1592, 278)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "Work Order Information"
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Location = New System.Drawing.Point(601, 57)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage5
        Me.XtraTabControl1.Size = New System.Drawing.Size(799, 213)
        Me.XtraTabControl1.TabIndex = 9
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage5, Me.XtraTabPage1, Me.XtraTabPage2, Me.XtraTabPage3, Me.XtraTabPage4})
        '
        'XtraTabPage5
        '
        Me.XtraTabPage5.Controls.Add(Me.eGeneralNotes)
        Me.XtraTabPage5.Name = "XtraTabPage5"
        Me.XtraTabPage5.Size = New System.Drawing.Size(794, 187)
        Me.XtraTabPage5.Text = "General"
        '
        'eGeneralNotes
        '
        Me.eGeneralNotes.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsWorkOrder, "Ordernotes", True))
        Me.eGeneralNotes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.eGeneralNotes.Location = New System.Drawing.Point(0, 0)
        Me.eGeneralNotes.Name = "eGeneralNotes"
        Me.eGeneralNotes.Size = New System.Drawing.Size(794, 187)
        Me.eGeneralNotes.TabIndex = 0
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.eProdFulfillmentNotes)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.XtraTabPage1.Size = New System.Drawing.Size(794, 187)
        Me.XtraTabPage1.Text = "Production / Fulfillment"
        '
        'eProdFulfillmentNotes
        '
        Me.eProdFulfillmentNotes.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsWorkOrder, "Prodfulfillmentnotes", True))
        Me.eProdFulfillmentNotes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.eProdFulfillmentNotes.Location = New System.Drawing.Point(3, 3)
        Me.eProdFulfillmentNotes.Name = "eProdFulfillmentNotes"
        Me.eProdFulfillmentNotes.Size = New System.Drawing.Size(788, 181)
        Me.eProdFulfillmentNotes.TabIndex = 26
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.eAccountingNotes)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.XtraTabPage2.Size = New System.Drawing.Size(794, 187)
        Me.XtraTabPage2.Text = "Accounting"
        '
        'eAccountingNotes
        '
        Me.eAccountingNotes.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsWorkOrder, "Accountingnotes", True))
        Me.eAccountingNotes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.eAccountingNotes.Location = New System.Drawing.Point(3, 3)
        Me.eAccountingNotes.Name = "eAccountingNotes"
        Me.eAccountingNotes.Size = New System.Drawing.Size(788, 181)
        Me.eAccountingNotes.TabIndex = 26
        '
        'XtraTabPage3
        '
        Me.XtraTabPage3.Controls.Add(Me.eTransportationNotes)
        Me.XtraTabPage3.Name = "XtraTabPage3"
        Me.XtraTabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.XtraTabPage3.Size = New System.Drawing.Size(794, 187)
        Me.XtraTabPage3.Text = "Transportation"
        '
        'eTransportationNotes
        '
        Me.eTransportationNotes.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsWorkOrder, "Transportationnotes", True))
        Me.eTransportationNotes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.eTransportationNotes.Location = New System.Drawing.Point(3, 3)
        Me.eTransportationNotes.Name = "eTransportationNotes"
        Me.eTransportationNotes.Size = New System.Drawing.Size(788, 181)
        Me.eTransportationNotes.TabIndex = 84
        '
        'XtraTabPage4
        '
        Me.XtraTabPage4.Controls.Add(Me.eBillOfLadingNotes)
        Me.XtraTabPage4.Name = "XtraTabPage4"
        Me.XtraTabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.XtraTabPage4.Size = New System.Drawing.Size(794, 187)
        Me.XtraTabPage4.Text = "Bill-of-Lading"
        '
        'eBillOfLadingNotes
        '
        Me.eBillOfLadingNotes.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsWorkOrder, "Billofladingnotes", True))
        Me.eBillOfLadingNotes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.eBillOfLadingNotes.Location = New System.Drawing.Point(3, 3)
        Me.eBillOfLadingNotes.Name = "eBillOfLadingNotes"
        Me.eBillOfLadingNotes.Size = New System.Drawing.Size(788, 181)
        Me.eBillOfLadingNotes.TabIndex = 82
        '
        'eOrderType
        '
        Me.eOrderType.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsWorkOrder, "Ordertype", True))
        Me.eOrderType.Location = New System.Drawing.Point(63, 28)
        Me.eOrderType.MenuManager = Me.RibbonControl1
        Me.eOrderType.Name = "eOrderType"
        Me.eOrderType.Properties.AllowMouseWheel = False
        Me.eOrderType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.eOrderType.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ordertype", 100, "Type")})
        Me.eOrderType.Properties.DataSource = Me.bsListOrderTypes
        Me.eOrderType.Properties.DisplayMember = "Ordertype"
        Me.eOrderType.Properties.DropDownRows = 5
        Me.eOrderType.Properties.NullText = ""
        Me.eOrderType.Properties.PopupWidth = 100
        Me.eOrderType.Properties.ShowFooter = False
        Me.eOrderType.Properties.ShowHeader = False
        Me.eOrderType.Properties.ValueMember = "Ordertype"
        Me.eOrderType.Size = New System.Drawing.Size(153, 20)
        Me.eOrderType.TabIndex = 1
        '
        'bsListOrderTypes
        '
        Me.bsListOrderTypes.DataSource = GetType(AOS.BusinessObjects.ListOrdertypeCollection)
        '
        'OnholdreasonTextEdit
        '
        Me.OnholdreasonTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsWorkOrder, "Onholdreason", True))
        Me.OnholdreasonTextEdit.Location = New System.Drawing.Point(364, 28)
        Me.OnholdreasonTextEdit.MenuManager = Me.RibbonControl1
        Me.OnholdreasonTextEdit.Name = "OnholdreasonTextEdit"
        Me.OnholdreasonTextEdit.Properties.ReadOnly = True
        Me.OnholdreasonTextEdit.Size = New System.Drawing.Size(214, 20)
        Me.OnholdreasonTextEdit.TabIndex = 6
        '
        'OnholdCheckEdit
        '
        Me.OnholdCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsWorkOrder, "Onhold", True))
        Me.OnholdCheckEdit.Location = New System.Drawing.Point(283, 28)
        Me.OnholdCheckEdit.MenuManager = Me.RibbonControl1
        Me.OnholdCheckEdit.Name = "OnholdCheckEdit"
        Me.OnholdCheckEdit.Properties.Caption = ""
        Me.OnholdCheckEdit.Properties.ReadOnly = True
        Me.OnholdCheckEdit.Size = New System.Drawing.Size(75, 19)
        Me.OnholdCheckEdit.TabIndex = 4
        '
        'grpTransportation
        '
        Me.grpTransportation.Controls.Add(Me.LabelControl3)
        Me.grpTransportation.Controls.Add(Me.CheckEdit1)
        Me.grpTransportation.Controls.Add(Me.LabelControl1)
        Me.grpTransportation.Controls.Add(Me.eOrSoonerFlag)
        Me.grpTransportation.Controls.Add(Me.lblCharges)
        Me.grpTransportation.Controls.Add(Me.lblSalesperson)
        Me.grpTransportation.Controls.Add(Me.lblCarrier)
        Me.grpTransportation.Controls.Add(Me.lblAddToInvoice)
        Me.grpTransportation.Controls.Add(Me.lblCustomerBilled)
        Me.grpTransportation.Controls.Add(Me.lblLogistics)
        Me.grpTransportation.Controls.Add(Me.lblDeliveryDate)
        Me.grpTransportation.Controls.Add(Me.lblShippedDate)
        Me.grpTransportation.Controls.Add(Label15)
        Me.grpTransportation.Controls.Add(Me.eTransportType)
        Me.grpTransportation.Controls.Add(Me.eFreightOnInvoice)
        Me.grpTransportation.Controls.Add(Me.eCustomerBilled)
        Me.grpTransportation.Controls.Add(Me.ePlannedDeliveryDate)
        Me.grpTransportation.Controls.Add(Me.ePlannedShippedDate)
        Me.grpTransportation.Controls.Add(Me.eFOB)
        Me.grpTransportation.Controls.Add(Me.eLogistics)
        Me.grpTransportation.Controls.Add(Me.eCarrier)
        Me.grpTransportation.Controls.Add(Me.eSalesperson)
        Me.grpTransportation.Location = New System.Drawing.Point(312, 57)
        Me.grpTransportation.Name = "grpTransportation"
        Me.grpTransportation.Size = New System.Drawing.Size(283, 209)
        Me.grpTransportation.TabIndex = 7
        Me.grpTransportation.Text = "Transportation Planning Information"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(192, 54)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(71, 13)
        Me.LabelControl3.TabIndex = 82
        Me.LabelControl3.Text = "Freeze Protect"
        '
        'CheckEdit1
        '
        Me.CheckEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsWorkOrder, "Freezeprotectflag", True))
        Me.CheckEdit1.Location = New System.Drawing.Point(171, 51)
        Me.CheckEdit1.MenuManager = Me.RibbonControl1
        Me.CheckEdit1.Name = "CheckEdit1"
        Me.CheckEdit1.Properties.Caption = ""
        Me.CheckEdit1.Size = New System.Drawing.Size(20, 19)
        Me.CheckEdit1.TabIndex = 81
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(192, 80)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(54, 13)
        Me.LabelControl1.TabIndex = 80
        Me.LabelControl1.Text = "(or sooner)"
        '
        'eOrSoonerFlag
        '
        Me.eOrSoonerFlag.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsWorkOrder, "Orsoonerflag", True))
        Me.eOrSoonerFlag.Location = New System.Drawing.Point(171, 77)
        Me.eOrSoonerFlag.MenuManager = Me.RibbonControl1
        Me.eOrSoonerFlag.Name = "eOrSoonerFlag"
        Me.eOrSoonerFlag.Properties.Caption = ""
        Me.eOrSoonerFlag.Size = New System.Drawing.Size(20, 19)
        Me.eOrSoonerFlag.TabIndex = 79
        '
        'lblCharges
        '
        Me.lblCharges.Location = New System.Drawing.Point(9, 104)
        Me.lblCharges.Name = "lblCharges"
        Me.lblCharges.Size = New System.Drawing.Size(43, 13)
        Me.lblCharges.TabIndex = 6
        Me.lblCharges.Text = "Freight $"
        '
        'lblSalesperson
        '
        Me.lblSalesperson.Location = New System.Drawing.Point(9, 104)
        Me.lblSalesperson.Name = "lblSalesperson"
        Me.lblSalesperson.Size = New System.Drawing.Size(58, 13)
        Me.lblSalesperson.TabIndex = 78
        Me.lblSalesperson.Text = "Salesperson"
        '
        'lblCarrier
        '
        Me.lblCarrier.Location = New System.Drawing.Point(9, 182)
        Me.lblCarrier.Name = "lblCarrier"
        Me.lblCarrier.Size = New System.Drawing.Size(33, 13)
        Me.lblCarrier.TabIndex = 14
        Me.lblCarrier.Text = "Carrier"
        '
        'lblAddToInvoice
        '
        Me.lblAddToInvoice.Location = New System.Drawing.Point(179, 130)
        Me.lblAddToInvoice.Name = "lblAddToInvoice"
        Me.lblAddToInvoice.Size = New System.Drawing.Size(72, 13)
        Me.lblAddToInvoice.TabIndex = 10
        Me.lblAddToInvoice.Text = "Add To Invoice"
        '
        'lblCustomerBilled
        '
        Me.lblCustomerBilled.Location = New System.Drawing.Point(80, 130)
        Me.lblCustomerBilled.Name = "lblCustomerBilled"
        Me.lblCustomerBilled.Size = New System.Drawing.Size(73, 13)
        Me.lblCustomerBilled.TabIndex = 8
        Me.lblCustomerBilled.Text = "Customer Billed"
        '
        'lblLogistics
        '
        Me.lblLogistics.Location = New System.Drawing.Point(9, 156)
        Me.lblLogistics.Name = "lblLogistics"
        Me.lblLogistics.Size = New System.Drawing.Size(40, 13)
        Me.lblLogistics.TabIndex = 12
        Me.lblLogistics.Text = "Logistics"
        '
        'lblDeliveryDate
        '
        Me.lblDeliveryDate.Location = New System.Drawing.Point(9, 80)
        Me.lblDeliveryDate.Name = "lblDeliveryDate"
        Me.lblDeliveryDate.Size = New System.Drawing.Size(65, 13)
        Me.lblDeliveryDate.TabIndex = 4
        Me.lblDeliveryDate.Text = "Delivery Date"
        '
        'lblShippedDate
        '
        Me.lblShippedDate.Location = New System.Drawing.Point(9, 54)
        Me.lblShippedDate.Name = "lblShippedDate"
        Me.lblShippedDate.Size = New System.Drawing.Size(46, 13)
        Me.lblShippedDate.TabIndex = 2
        Me.lblShippedDate.Text = "Ship Date"
        '
        'eTransportType
        '
        Me.eTransportType.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsWorkOrder, "Transporttype", True))
        Me.eTransportType.Location = New System.Drawing.Point(80, 26)
        Me.eTransportType.MenuManager = Me.RibbonControl1
        Me.eTransportType.Name = "eTransportType"
        Me.eTransportType.Properties.AllowMouseWheel = False
        Me.eTransportType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.eTransportType.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Transporttype", 100, "Type")})
        Me.eTransportType.Properties.DataSource = Me.bsListTransportTypes
        Me.eTransportType.Properties.DisplayMember = "Transporttype"
        Me.eTransportType.Properties.DropDownRows = 8
        Me.eTransportType.Properties.NullText = ""
        Me.eTransportType.Properties.PopupSizeable = False
        Me.eTransportType.Properties.PopupWidth = 137
        Me.eTransportType.Properties.ShowFooter = False
        Me.eTransportType.Properties.ShowHeader = False
        Me.eTransportType.Properties.ValueMember = "Transporttype"
        Me.eTransportType.Size = New System.Drawing.Size(193, 20)
        Me.eTransportType.TabIndex = 1
        '
        'bsListTransportTypes
        '
        Me.bsListTransportTypes.DataSource = GetType(AOS.BusinessObjects.ListTransporttypeCollection)
        '
        'eFreightOnInvoice
        '
        Me.eFreightOnInvoice.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsWorkOrder, "Freightoninvoice", True))
        Me.eFreightOnInvoice.Location = New System.Drawing.Point(253, 128)
        Me.eFreightOnInvoice.MenuManager = Me.RibbonControl1
        Me.eFreightOnInvoice.Name = "eFreightOnInvoice"
        Me.eFreightOnInvoice.Properties.Caption = ""
        Me.eFreightOnInvoice.Size = New System.Drawing.Size(20, 19)
        Me.eFreightOnInvoice.TabIndex = 11
        '
        'eCustomerBilled
        '
        Me.eCustomerBilled.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsWorkOrder, "Freightbillcustomer", True))
        Me.eCustomerBilled.Location = New System.Drawing.Point(152, 127)
        Me.eCustomerBilled.MenuManager = Me.RibbonControl1
        Me.eCustomerBilled.Name = "eCustomerBilled"
        Me.eCustomerBilled.Properties.Caption = ""
        Me.eCustomerBilled.Size = New System.Drawing.Size(21, 19)
        Me.eCustomerBilled.TabIndex = 9
        '
        'ePlannedDeliveryDate
        '
        Me.ePlannedDeliveryDate.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsWorkOrder, "Deliverydate", True))
        Me.ePlannedDeliveryDate.EditValue = Nothing
        Me.ePlannedDeliveryDate.Location = New System.Drawing.Point(80, 77)
        Me.ePlannedDeliveryDate.Name = "ePlannedDeliveryDate"
        Me.ePlannedDeliveryDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ePlannedDeliveryDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.ePlannedDeliveryDate.Size = New System.Drawing.Size(85, 20)
        Me.ePlannedDeliveryDate.TabIndex = 5
        '
        'ePlannedShippedDate
        '
        Me.ePlannedShippedDate.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsWorkOrder, "Plannedshipdate", True))
        Me.ePlannedShippedDate.EditValue = Nothing
        Me.ePlannedShippedDate.Location = New System.Drawing.Point(80, 51)
        Me.ePlannedShippedDate.Name = "ePlannedShippedDate"
        Me.ePlannedShippedDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ePlannedShippedDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.ePlannedShippedDate.Size = New System.Drawing.Size(85, 20)
        Me.ePlannedShippedDate.TabIndex = 3
        '
        'eFOB
        '
        Me.eFOB.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsWorkOrder, "Fob", True))
        Me.eFOB.Location = New System.Drawing.Point(80, 101)
        Me.eFOB.Name = "eFOB"
        Me.eFOB.Properties.AllowMouseWheel = False
        Me.eFOB.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.eFOB.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("FOBOption", "FOBOption", 71, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.eFOB.Properties.DataSource = Me.bsFOB
        Me.eFOB.Properties.DisplayMember = "FOBOption"
        Me.eFOB.Properties.NullText = ""
        Me.eFOB.Properties.ShowFooter = False
        Me.eFOB.Properties.ShowHeader = False
        Me.eFOB.Properties.ShowLines = False
        Me.eFOB.Properties.ValueMember = "FOBOption"
        Me.eFOB.Size = New System.Drawing.Size(193, 20)
        Me.eFOB.TabIndex = 7
        '
        'eLogistics
        '
        Me.eLogistics.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsWorkOrder, "Logisticsid", True))
        Me.eLogistics.Location = New System.Drawing.Point(80, 152)
        Me.eLogistics.Name = "eLogistics"
        Me.eLogistics.Properties.AllowMouseWheel = False
        Me.eLogistics.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, True, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Global.AOS.My.Resources.Resources.record_edit, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "", Nothing, Nothing, True), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, True, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Global.AOS.My.Resources.Resources.record_add, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject2, "", Nothing, Nothing, True)})
        Me.eLogistics.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Logisticsname", "Logisticsname", 76, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.eLogistics.Properties.DataSource = Me.bsLogistics
        Me.eLogistics.Properties.DisplayMember = "Logisticsname"
        Me.eLogistics.Properties.NullText = ""
        Me.eLogistics.Properties.ValueMember = "Logisticsid"
        Me.eLogistics.Size = New System.Drawing.Size(193, 22)
        Me.eLogistics.TabIndex = 13
        '
        'bsLogistics
        '
        Me.bsLogistics.DataSource = GetType(AOS.BusinessObjects.LogisticsCollection)
        '
        'eCarrier
        '
        Me.eCarrier.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsWorkOrder, "Carrierid", True))
        Me.eCarrier.Location = New System.Drawing.Point(80, 178)
        Me.eCarrier.Name = "eCarrier"
        Me.eCarrier.Properties.AllowMouseWheel = False
        Me.eCarrier.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "Edit Freight Carrier", -1, True, True, True, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Global.AOS.My.Resources.Resources.transport_edit, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject3, "", Nothing, Nothing, True), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "Add New Freight Carrier", -1, True, True, True, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Global.AOS.My.Resources.Resources.transport_add, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject4, "", Nothing, Nothing, True)})
        Me.eCarrier.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CarrierID", "Carrier ID", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CarrierName", "Carrier Name", 200, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.eCarrier.Properties.DataSource = Me.bsCarriers
        Me.eCarrier.Properties.DisplayMember = "CarrierName"
        Me.eCarrier.Properties.NullText = ""
        Me.eCarrier.Properties.ValueMember = "CarrierID"
        Me.eCarrier.Size = New System.Drawing.Size(193, 22)
        Me.eCarrier.TabIndex = 15
        '
        'eSalesperson
        '
        Me.eSalesperson.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsWorkOrder, "Salespersonid", True))
        Me.eSalesperson.Location = New System.Drawing.Point(80, 101)
        Me.eSalesperson.MenuManager = Me.RibbonControl1
        Me.eSalesperson.Name = "eSalesperson"
        Me.eSalesperson.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.eSalesperson.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Salespersonfullname", 100, "Name")})
        Me.eSalesperson.Properties.DataSource = Me.bsListSalespersons
        Me.eSalesperson.Properties.DisplayMember = "Salespersonfullname"
        Me.eSalesperson.Properties.DropDownRows = 8
        Me.eSalesperson.Properties.NullText = ""
        Me.eSalesperson.Properties.PopupSizeable = False
        Me.eSalesperson.Properties.PopupWidth = 137
        Me.eSalesperson.Properties.ShowFooter = False
        Me.eSalesperson.Properties.ShowHeader = False
        Me.eSalesperson.Properties.ValueMember = "Salespersonid"
        Me.eSalesperson.Size = New System.Drawing.Size(193, 20)
        Me.eSalesperson.TabIndex = 74
        '
        'bsListSalespersons
        '
        Me.bsListSalespersons.DataSource = GetType(AOS.BusinessObjects.SalespersonCollection)
        '
        'GroupControl3
        '
        Me.GroupControl3.Controls.Add(Me.btnUpdateCustomerPOAllItems)
        Me.GroupControl3.Controls.Add(Label7)
        Me.GroupControl3.Controls.Add(Me.eShipPhone)
        Me.GroupControl3.Controls.Add(Label6)
        Me.GroupControl3.Controls.Add(Label5)
        Me.GroupControl3.Controls.Add(Label4)
        Me.GroupControl3.Controls.Add(Label3)
        Me.GroupControl3.Controls.Add(Me.eShipCountry)
        Me.GroupControl3.Controls.Add(Me.eShipZip)
        Me.GroupControl3.Controls.Add(Me.eShipState)
        Me.GroupControl3.Controls.Add(Me.eCustPO)
        Me.GroupControl3.Controls.Add(CustomerpoLabel)
        Me.GroupControl3.Controls.Add(Me.eShipCity)
        Me.GroupControl3.Controls.Add(Me.eShipAddr2)
        Me.GroupControl3.Controls.Add(Me.eShipAddr1)
        Me.GroupControl3.Controls.Add(Label2)
        Me.GroupControl3.Controls.Add(Me.eShipContact)
        Me.GroupControl3.Controls.Add(Me.eCustomer)
        Me.GroupControl3.Location = New System.Drawing.Point(12, 57)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(294, 209)
        Me.GroupControl3.TabIndex = 2
        Me.GroupControl3.Text = "Destination / Customer"
        '
        'btnUpdateCustomerPOAllItems
        '
        Me.btnUpdateCustomerPOAllItems.Location = New System.Drawing.Point(179, 180)
        Me.btnUpdateCustomerPOAllItems.Name = "btnUpdateCustomerPOAllItems"
        Me.btnUpdateCustomerPOAllItems.Size = New System.Drawing.Size(106, 19)
        Me.btnUpdateCustomerPOAllItems.TabIndex = 17
        Me.btnUpdateCustomerPOAllItems.Text = "Update All Items"
        '
        'eShipPhone
        '
        Me.eShipPhone.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsWorkOrder, "Shipphone", True))
        Me.eShipPhone.Location = New System.Drawing.Point(210, 127)
        Me.eShipPhone.Name = "eShipPhone"
        Me.eShipPhone.Properties.ReadOnly = True
        Me.eShipPhone.Size = New System.Drawing.Size(76, 20)
        Me.eShipPhone.TabIndex = 12
        Me.eShipPhone.TabStop = False
        '
        'eShipCountry
        '
        Me.eShipCountry.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsWorkOrder, "Shipcountry", True))
        Me.eShipCountry.Location = New System.Drawing.Point(52, 127)
        Me.eShipCountry.Name = "eShipCountry"
        Me.eShipCountry.Properties.ReadOnly = True
        Me.eShipCountry.Size = New System.Drawing.Size(121, 20)
        Me.eShipCountry.TabIndex = 10
        Me.eShipCountry.TabStop = False
        '
        'eShipZip
        '
        Me.eShipZip.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsWorkOrder, "Shippostalcode", True))
        Me.eShipZip.Location = New System.Drawing.Point(210, 101)
        Me.eShipZip.Name = "eShipZip"
        Me.eShipZip.Properties.ReadOnly = True
        Me.eShipZip.Size = New System.Drawing.Size(76, 20)
        Me.eShipZip.TabIndex = 8
        Me.eShipZip.TabStop = False
        '
        'eShipState
        '
        Me.eShipState.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsWorkOrder, "Shipstateprov", True))
        Me.eShipState.Location = New System.Drawing.Point(179, 101)
        Me.eShipState.Name = "eShipState"
        Me.eShipState.Properties.ReadOnly = True
        Me.eShipState.Size = New System.Drawing.Size(25, 20)
        Me.eShipState.TabIndex = 7
        Me.eShipState.TabStop = False
        '
        'eCustPO
        '
        Me.eCustPO.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsWorkOrder, "Customerpo", True))
        Me.eCustPO.Location = New System.Drawing.Point(52, 179)
        Me.eCustPO.Name = "eCustPO"
        Me.eCustPO.Size = New System.Drawing.Size(121, 20)
        Me.eCustPO.TabIndex = 16
        '
        'eShipCity
        '
        Me.eShipCity.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsWorkOrder, "Shipcity", True))
        Me.eShipCity.Location = New System.Drawing.Point(52, 101)
        Me.eShipCity.Name = "eShipCity"
        Me.eShipCity.Properties.ReadOnly = True
        Me.eShipCity.Size = New System.Drawing.Size(121, 20)
        Me.eShipCity.TabIndex = 6
        Me.eShipCity.TabStop = False
        '
        'eShipAddr2
        '
        Me.eShipAddr2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsWorkOrder, "Shipaddress2", True))
        Me.eShipAddr2.Location = New System.Drawing.Point(52, 77)
        Me.eShipAddr2.Name = "eShipAddr2"
        Me.eShipAddr2.Properties.ReadOnly = True
        Me.eShipAddr2.Size = New System.Drawing.Size(234, 20)
        Me.eShipAddr2.TabIndex = 4
        Me.eShipAddr2.TabStop = False
        '
        'eShipAddr1
        '
        Me.eShipAddr1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsWorkOrder, "Shipaddress1", True))
        Me.eShipAddr1.Location = New System.Drawing.Point(52, 51)
        Me.eShipAddr1.Name = "eShipAddr1"
        Me.eShipAddr1.Properties.ReadOnly = True
        Me.eShipAddr1.Size = New System.Drawing.Size(234, 20)
        Me.eShipAddr1.TabIndex = 2
        Me.eShipAddr1.TabStop = False
        '
        'eShipContact
        '
        Me.eShipContact.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsWorkOrder, "Shipcontact", True))
        Me.eShipContact.Location = New System.Drawing.Point(52, 153)
        Me.eShipContact.Name = "eShipContact"
        Me.eShipContact.Size = New System.Drawing.Size(234, 20)
        Me.eShipContact.TabIndex = 14
        '
        'eCustomer
        '
        Me.eCustomer.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsWorkOrder, "Custid", True))
        Me.eCustomer.Location = New System.Drawing.Point(8, 24)
        Me.eCustomer.Name = "eCustomer"
        Me.eCustomer.Properties.AllowMouseWheel = False
        Me.eCustomer.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, True, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Global.AOS.My.Resources.Resources.customer_edit, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject5, "", Nothing, Nothing, True), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, True, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Global.AOS.My.Resources.Resources.customer_add, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject6, "", Nothing, Nothing, True)})
        Me.eCustomer.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Custname", "Customer Name", 250, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Custshipcity", 100, "City"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Custshipstateprov", 50, "State")})
        Me.eCustomer.Properties.DataSource = Me.bsCustomers
        Me.eCustomer.Properties.DisplayMember = "Custname"
        Me.eCustomer.Properties.NullText = ""
        Me.eCustomer.Properties.PopupWidth = 400
        Me.eCustomer.Properties.ValueMember = "Custid"
        Me.eCustomer.Size = New System.Drawing.Size(278, 22)
        Me.eCustomer.TabIndex = 0
        '
        'lblEditInfo
        '
        Me.lblEditInfo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblEditInfo.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblEditInfo.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblEditInfo.Location = New System.Drawing.Point(880, 28)
        Me.lblEditInfo.Name = "lblEditInfo"
        Me.lblEditInfo.Size = New System.Drawing.Size(703, 20)
        Me.lblEditInfo.TabIndex = 8
        '
        'Note16_ImageCollection
        '
        Me.Note16_ImageCollection.ImageStream = CType(resources.GetObject("Note16_ImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        '
        'bsNotes
        '
        Me.bsNotes.DataSource = GetType(AOS.BusinessObjects.NoteCollection)
        Me.bsNotes.Sort = ""
        '
        'bsVendors
        '
        Me.bsVendors.DataSource = GetType(AOS.BusinessObjects.VendorCollection)
        '
        'bsWorkOrderType
        '
        Me.bsWorkOrderType.DataSource = GetType(AOS.BusinessObjects.ListWorkordertypeCollection)
        '
        'SmallImages
        '
        Me.SmallImages.ImageStream = CType(resources.GetObject("SmallImages.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        '
        'Timer_Lookups
        '
        Me.Timer_Lookups.Enabled = True
        Me.Timer_Lookups.Interval = 60000
        '
        'frmAddEditWorkOrders
        '
        Me.ClientSize = New System.Drawing.Size(1592, 652)
        Me.ControlBox = False
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.RibbonControl1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmAddEditWorkOrders"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Work Order Information"
        CType(Me.bsWorkOrder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsFOB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsCarriers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsCustomers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsWorkOrderItems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WorkOrderImages, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl4.ResumeLayout(False)
        CType(Me.grWorkOrderItems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grvWorkOrderItems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemHyperLinkEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemHyperLinkEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.luProductDesc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.luContainer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.luStdgallons, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemHyperLinkEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnlLegend, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlLegend.ResumeLayout(False)
        Me.pnlLegend.PerformLayout()
        CType(Me.eGrossWgt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblPinkColor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnlTopWorkOrderInformation, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTopWorkOrderInformation.ResumeLayout(False)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage5.ResumeLayout(False)
        CType(Me.eGeneralNotes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage1.ResumeLayout(False)
        CType(Me.eProdFulfillmentNotes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        CType(Me.eAccountingNotes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage3.ResumeLayout(False)
        CType(Me.eTransportationNotes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage4.ResumeLayout(False)
        CType(Me.eBillOfLadingNotes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eOrderType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsListOrderTypes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OnholdreasonTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OnholdCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpTransportation, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpTransportation.ResumeLayout(False)
        Me.grpTransportation.PerformLayout()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eOrSoonerFlag.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eTransportType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsListTransportTypes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eFreightOnInvoice.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eCustomerBilled.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ePlannedDeliveryDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ePlannedDeliveryDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ePlannedShippedDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ePlannedShippedDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eFOB.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eLogistics.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsLogistics, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eCarrier.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eSalesperson.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsListSalespersons, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        Me.GroupControl3.PerformLayout()
        CType(Me.eShipPhone.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eShipCountry.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eShipZip.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eShipState.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eCustPO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eShipCity.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eShipAddr2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eShipAddr1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eShipContact.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eCustomer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Note16_ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsNotes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsVendors, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsWorkOrderType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SmallImages, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents bsWorkOrder As System.Windows.Forms.BindingSource
    Friend WithEvents bsWorkOrderItems As System.Windows.Forms.BindingSource
    Friend WithEvents bsCustomers As System.Windows.Forms.BindingSource
    Friend WithEvents bsCarriers As System.Windows.Forms.BindingSource
    Friend WithEvents bsFOB As System.Windows.Forms.BindingSource
    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GroupControl4 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents grWorkOrderItems As DevExpress.XtraGrid.GridControl
    Friend WithEvents grvWorkOrderItems As CustomDevExGridView
    Friend WithEvents luProductDesc As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents luContainer As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents luStdgallons As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents pnlTopWorkOrderInformation As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents eCarrier As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents ePlannedShippedDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents ePlannedDeliveryDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents eCustomer As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents eCustPO As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnSave As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnCancel As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnAddWOItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rbtnEditMatchingItems As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnDeleteWOItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents eLogistics As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents bsLogistics As System.Windows.Forms.BindingSource
    Friend WithEvents eProdFulfillmentNotes As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents bsNotes As System.Windows.Forms.BindingSource
    Friend WithEvents btnPrintWorkOrder As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents WorkOrderImages As DevExpress.Utils.ImageCollection
    Friend WithEvents bsWorkOrderType As System.Windows.Forms.BindingSource
    Friend WithEvents SmallImages As DevExpress.Utils.ImageCollection
    Friend WithEvents grpTransportation As DevExpress.XtraEditors.GroupControl
    Friend WithEvents eFOB As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents Note16_ImageCollection As DevExpress.Utils.ImageCollection
    Friend WithEvents bsVendors As System.Windows.Forms.BindingSource
    Friend WithEvents Timer_Lookups As System.Windows.Forms.Timer
    Friend WithEvents eShipContact As DevExpress.XtraEditors.TextEdit
    Friend WithEvents colWorkorderitemnumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colWorkordernumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProductid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProductdesc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colContainer As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInvitemnumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colItemstatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSourcetype As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSourcedocument As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCustomerpo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents eCustomerBilled As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents eFreightOnInvoice As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents eShipCountry As DevExpress.XtraEditors.TextEdit
    Friend WithEvents eShipZip As DevExpress.XtraEditors.TextEdit
    Friend WithEvents eShipState As DevExpress.XtraEditors.TextEdit
    Friend WithEvents eShipCity As DevExpress.XtraEditors.TextEdit
    Friend WithEvents eShipAddr2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents eShipAddr1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents bTxtOrderStatus As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents bTxtWorkOrderNum As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents bTxtWorkOrderDate As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents RibbonPageGroup3 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents eShipPhone As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblEditInfo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents OnholdreasonTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents OnholdCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents gcUnitPrice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcExtPrice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents rbtnChangeWorkOrderDate As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rbtnAutoPlan As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rbtnEditPlan As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rbtnPrintPlan As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup5 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup4 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents rbtnChangeHoldStatus As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents eOrderType As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents eTransportType As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents bsListOrderTypes As System.Windows.Forms.BindingSource
    Friend WithEvents bsListTransportTypes As System.Windows.Forms.BindingSource
    Friend WithEvents eSalesperson As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents bsListSalespersons As System.Windows.Forms.BindingSource
    Friend WithEvents lblShippedDate As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblCharges As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblSalesperson As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblCarrier As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblAddToInvoice As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblCustomerBilled As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblLogistics As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblDeliveryDate As DevExpress.XtraEditors.LabelControl
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem4 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem5 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents eBillOfLadingNotes As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents eAccountingNotes As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents eTransportationNotes As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents rbtnEditSingleItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents colItemtype As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colItemid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colItemdescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIshazardous As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnits As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUom As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colExpr1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCustitemid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage3 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage4 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage5 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents eGeneralNotes As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents colUnitcost As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colExtprofit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnEditAll As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents colSourceStatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rbtnEmailPlan As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents colAvailable As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colExpectedIn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDateNeeded As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents pnlLegend As DevExpress.XtraEditors.PanelControl
    Friend WithEvents lblPinkLegend As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblColorMapping As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblPinkColor As DevExpress.XtraEditors.ColorEdit
    Friend WithEvents rbtnChangePlannedShipDate As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents colEstCompDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNeededBy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemHyperLinkEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
    Friend WithEvents RepositoryItemHyperLinkEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
    Friend WithEvents RepositoryItemHyperLinkEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
    Friend WithEvents btnPrintWorkOrderDocs As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rbtnPickItems As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents eOrSoonerFlag As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents eGrossWgt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnUpdateCustomerPOAllItems As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents CheckEdit1 As DevExpress.XtraEditors.CheckEdit
End Class
