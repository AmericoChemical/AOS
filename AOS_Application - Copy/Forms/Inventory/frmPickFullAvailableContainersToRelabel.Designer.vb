<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPickFullAvailableContainersToRelabel

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
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btnClose = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnRelabel = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.bsItems = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView2 = New CustomDevExGridView()
        Me.colInvitemnumber1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProductid3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProductdesc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colContainer = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colShipmentnumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colShipmentdate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colShippeddate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colReceiveddate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLotnumber1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colWarehouselocation1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colWarehousenumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAllocateddate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colReceivernumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colItemstatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInventoryclass = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colClassdesc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnitsremaining = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colReceiverdocument = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colReceiverdocumenttype = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPonumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPurchasereleasenumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVendorname = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPodate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colChangeableponumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAllocateddocument = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colWorkordernumber1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colWorkordercustomer = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colShiptocustomer = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.RepositoryItemLookUpEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.RepositoryItemLookUpEdit5 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.RepositoryItemCheckEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.RepositoryItemLookUpEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsItems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'RibbonControl1
        '
        Me.RibbonControl1.ApplicationButtonText = Nothing
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.btnClose, Me.rbtnRelabel})
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.MaxItemId = 8
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide
        Me.RibbonControl1.ShowToolbarCustomizeItem = False
        Me.RibbonControl1.Size = New System.Drawing.Size(929, 96)
        Me.RibbonControl1.Toolbar.ShowCustomizeItem = False
        Me.RibbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden
        '
        'btnClose
        '
        Me.btnClose.Caption = "Close"
        Me.btnClose.Id = 4
        Me.btnClose.LargeGlyph = Global.AOS.My.Resources.Resources.Close
        Me.btnClose.Name = "btnClose"
        '
        'rbtnRelabel
        '
        Me.rbtnRelabel.Caption = "Mark Selected Item to Relabel"
        Me.rbtnRelabel.Id = 6
        Me.rbtnRelabel.LargeGlyph = Global.AOS.My.Resources.Resources.Quarantine
        Me.rbtnRelabel.Name = "rbtnRelabel"
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
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btnClose)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.ShowCaptionButton = False
        Me.RibbonPageGroup2.Text = "Actions"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.AllowTextClipping = False
        Me.RibbonPageGroup1.ItemLinks.Add(Me.rbtnRelabel)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.ShowCaptionButton = False
        Me.RibbonPageGroup1.Text = "Inventory"
        '
        'bsItems
        '
        Me.bsItems.DataSource = GetType(AOS.BusinessObjects.ViewInvItemDetailsCollection)
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.GridControl1)
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl2.Location = New System.Drawing.Point(0, 96)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(929, 338)
        Me.GroupControl2.TabIndex = 2
        Me.GroupControl2.Text = "Available Inventory Items"
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.bsItems
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(2, 21)
        Me.GridControl1.MainView = Me.GridView2
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit2, Me.RepositoryItemLookUpEdit3, Me.RepositoryItemLookUpEdit5, Me.RepositoryItemCheckEdit2, Me.RepositoryItemLookUpEdit4})
        Me.GridControl1.Size = New System.Drawing.Size(925, 315)
        Me.GridControl1.TabIndex = 7
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colInvitemnumber1, Me.colProductid3, Me.colProductdesc, Me.colContainer, Me.colShipmentnumber, Me.colShipmentdate, Me.colShippeddate, Me.colReceiveddate, Me.colLotnumber1, Me.colWarehouselocation1, Me.colWarehousenumber, Me.colAllocateddate, Me.colReceivernumber, Me.colItemstatus, Me.colInventoryclass, Me.colClassdesc, Me.colUnitsremaining, Me.colReceiverdocument, Me.colReceiverdocumenttype, Me.colPonumber, Me.colPurchasereleasenumber, Me.colVendorname, Me.colPodate, Me.colChangeableponumber, Me.colAllocateddocument, Me.colWorkordernumber1, Me.colWorkordercustomer, Me.colShiptocustomer})
        Me.GridView2.GridControl = Me.GridControl1
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsBehavior.Editable = False
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        Me.GridView2.OptionsView.ShowIndicator = False
        '
        'colInvitemnumber1
        '
        Me.colInvitemnumber1.FieldName = "Invitemnumber"
        Me.colInvitemnumber1.Name = "colInvitemnumber1"
        '
        'colProductid3
        '
        Me.colProductid3.Caption = "Prod ID"
        Me.colProductid3.FieldName = "Productid"
        Me.colProductid3.Name = "colProductid3"
        Me.colProductid3.OptionsColumn.AllowEdit = False
        Me.colProductid3.Visible = True
        Me.colProductid3.VisibleIndex = 1
        Me.colProductid3.Width = 69
        '
        'colProductdesc
        '
        Me.colProductdesc.Caption = "Product Description"
        Me.colProductdesc.FieldName = "Productdesc"
        Me.colProductdesc.Name = "colProductdesc"
        Me.colProductdesc.OptionsColumn.AllowEdit = False
        Me.colProductdesc.Visible = True
        Me.colProductdesc.VisibleIndex = 2
        Me.colProductdesc.Width = 283
        '
        'colContainer
        '
        Me.colContainer.FieldName = "Container"
        Me.colContainer.Name = "colContainer"
        Me.colContainer.OptionsColumn.AllowEdit = False
        Me.colContainer.Visible = True
        Me.colContainer.VisibleIndex = 3
        Me.colContainer.Width = 145
        '
        'colShipmentnumber
        '
        Me.colShipmentnumber.FieldName = "Shipmentnumber"
        Me.colShipmentnumber.Name = "colShipmentnumber"
        '
        'colShipmentdate
        '
        Me.colShipmentdate.FieldName = "Shipmentdate"
        Me.colShipmentdate.Name = "colShipmentdate"
        '
        'colShippeddate
        '
        Me.colShippeddate.FieldName = "Shippeddate"
        Me.colShippeddate.Name = "colShippeddate"
        '
        'colReceiveddate
        '
        Me.colReceiveddate.Caption = "Received"
        Me.colReceiveddate.FieldName = "Receiveddate"
        Me.colReceiveddate.Name = "colReceiveddate"
        Me.colReceiveddate.OptionsColumn.AllowEdit = False
        Me.colReceiveddate.Visible = True
        Me.colReceiveddate.VisibleIndex = 0
        Me.colReceiveddate.Width = 71
        '
        'colLotnumber1
        '
        Me.colLotnumber1.Caption = "Lot Number"
        Me.colLotnumber1.FieldName = "Lotnumber"
        Me.colLotnumber1.Name = "colLotnumber1"
        Me.colLotnumber1.OptionsColumn.AllowEdit = False
        Me.colLotnumber1.Visible = True
        Me.colLotnumber1.VisibleIndex = 4
        Me.colLotnumber1.Width = 187
        '
        'colWarehouselocation1
        '
        Me.colWarehouselocation1.Caption = "Bin"
        Me.colWarehouselocation1.FieldName = "Warehouselocation"
        Me.colWarehouselocation1.Name = "colWarehouselocation1"
        Me.colWarehouselocation1.OptionsColumn.AllowEdit = False
        Me.colWarehouselocation1.Visible = True
        Me.colWarehouselocation1.VisibleIndex = 5
        Me.colWarehouselocation1.Width = 123
        '
        'colWarehousenumber
        '
        Me.colWarehousenumber.FieldName = "Warehousenumber"
        Me.colWarehousenumber.Name = "colWarehousenumber"
        '
        'colAllocateddate
        '
        Me.colAllocateddate.FieldName = "Allocateddate"
        Me.colAllocateddate.Name = "colAllocateddate"
        '
        'colReceivernumber
        '
        Me.colReceivernumber.FieldName = "Receivernumber"
        Me.colReceivernumber.Name = "colReceivernumber"
        '
        'colItemstatus
        '
        Me.colItemstatus.Caption = "Status"
        Me.colItemstatus.FieldName = "Itemstatus"
        Me.colItemstatus.Name = "colItemstatus"
        Me.colItemstatus.OptionsColumn.AllowEdit = False
        Me.colItemstatus.Visible = True
        Me.colItemstatus.VisibleIndex = 6
        Me.colItemstatus.Width = 130
        '
        'colInventoryclass
        '
        Me.colInventoryclass.FieldName = "Inventoryclass"
        Me.colInventoryclass.Name = "colInventoryclass"
        '
        'colClassdesc
        '
        Me.colClassdesc.FieldName = "Classdesc"
        Me.colClassdesc.Name = "colClassdesc"
        '
        'colUnitsremaining
        '
        Me.colUnitsremaining.FieldName = "Unitsremaining"
        Me.colUnitsremaining.Name = "colUnitsremaining"
        '
        'colReceiverdocument
        '
        Me.colReceiverdocument.FieldName = "Receiverdocument"
        Me.colReceiverdocument.Name = "colReceiverdocument"
        '
        'colReceiverdocumenttype
        '
        Me.colReceiverdocumenttype.FieldName = "Receiverdocumenttype"
        Me.colReceiverdocumenttype.Name = "colReceiverdocumenttype"
        '
        'colPonumber
        '
        Me.colPonumber.FieldName = "Ponumber"
        Me.colPonumber.Name = "colPonumber"
        '
        'colPurchasereleasenumber
        '
        Me.colPurchasereleasenumber.FieldName = "Purchasereleasenumber"
        Me.colPurchasereleasenumber.Name = "colPurchasereleasenumber"
        '
        'colVendorname
        '
        Me.colVendorname.FieldName = "Vendorname"
        Me.colVendorname.Name = "colVendorname"
        '
        'colPodate
        '
        Me.colPodate.FieldName = "Podate"
        Me.colPodate.Name = "colPodate"
        '
        'colChangeableponumber
        '
        Me.colChangeableponumber.FieldName = "Changeableponumber"
        Me.colChangeableponumber.Name = "colChangeableponumber"
        '
        'colAllocateddocument
        '
        Me.colAllocateddocument.FieldName = "Allocateddocument"
        Me.colAllocateddocument.Name = "colAllocateddocument"
        '
        'colWorkordernumber1
        '
        Me.colWorkordernumber1.FieldName = "Workordernumber"
        Me.colWorkordernumber1.Name = "colWorkordernumber1"
        '
        'colWorkordercustomer
        '
        Me.colWorkordercustomer.FieldName = "Workordercustomer"
        Me.colWorkordercustomer.Name = "colWorkordercustomer"
        '
        'colShiptocustomer
        '
        Me.colShiptocustomer.FieldName = "Shiptocustomer"
        Me.colShiptocustomer.Name = "colShiptocustomer"
        '
        'RepositoryItemLookUpEdit2
        '
        Me.RepositoryItemLookUpEdit2.AutoHeight = False
        Me.RepositoryItemLookUpEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit2.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Productdesc", "Productdesc", 65, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.RepositoryItemLookUpEdit2.DisplayMember = "Productdesc"
        Me.RepositoryItemLookUpEdit2.LookAndFeel.SkinName = "Money Twins"
        Me.RepositoryItemLookUpEdit2.Name = "RepositoryItemLookUpEdit2"
        Me.RepositoryItemLookUpEdit2.NullText = ""
        Me.RepositoryItemLookUpEdit2.ReadOnly = True
        Me.RepositoryItemLookUpEdit2.ShowFooter = False
        Me.RepositoryItemLookUpEdit2.ShowHeader = False
        Me.RepositoryItemLookUpEdit2.ShowLines = False
        Me.RepositoryItemLookUpEdit2.ValueMember = "Productid"
        '
        'RepositoryItemLookUpEdit3
        '
        Me.RepositoryItemLookUpEdit3.AutoHeight = False
        Me.RepositoryItemLookUpEdit3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit3.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Container", "Container", 53, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.RepositoryItemLookUpEdit3.DisplayMember = "Container"
        Me.RepositoryItemLookUpEdit3.LookAndFeel.SkinName = "Money Twins"
        Me.RepositoryItemLookUpEdit3.Name = "RepositoryItemLookUpEdit3"
        Me.RepositoryItemLookUpEdit3.NullText = ""
        Me.RepositoryItemLookUpEdit3.ReadOnly = True
        Me.RepositoryItemLookUpEdit3.ShowFooter = False
        Me.RepositoryItemLookUpEdit3.ShowHeader = False
        Me.RepositoryItemLookUpEdit3.ValueMember = "Productid"
        '
        'RepositoryItemLookUpEdit5
        '
        Me.RepositoryItemLookUpEdit5.AutoHeight = False
        Me.RepositoryItemLookUpEdit5.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit5.DisplayMember = "Stdgallons"
        Me.RepositoryItemLookUpEdit5.LookAndFeel.SkinName = "Money Twins"
        Me.RepositoryItemLookUpEdit5.Name = "RepositoryItemLookUpEdit5"
        Me.RepositoryItemLookUpEdit5.NullText = ""
        Me.RepositoryItemLookUpEdit5.ReadOnly = True
        Me.RepositoryItemLookUpEdit5.ValueMember = "Productid"
        '
        'RepositoryItemCheckEdit2
        '
        Me.RepositoryItemCheckEdit2.AutoHeight = False
        Me.RepositoryItemCheckEdit2.Caption = "Check"
        Me.RepositoryItemCheckEdit2.LookAndFeel.SkinName = "Money Twins"
        Me.RepositoryItemCheckEdit2.Name = "RepositoryItemCheckEdit2"
        '
        'RepositoryItemLookUpEdit4
        '
        Me.RepositoryItemLookUpEdit4.AutoHeight = False
        Me.RepositoryItemLookUpEdit4.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit4.DisplayMember = "Desc2"
        Me.RepositoryItemLookUpEdit4.LookAndFeel.SkinName = "Money Twins"
        Me.RepositoryItemLookUpEdit4.Name = "RepositoryItemLookUpEdit4"
        Me.RepositoryItemLookUpEdit4.NullText = ""
        Me.RepositoryItemLookUpEdit4.ValueMember = "Productid"
        '
        'frmPickFullAvailableContainersToRelabel
        '
        Me.ClientSize = New System.Drawing.Size(929, 434)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.RibbonControl1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmPickFullAvailableContainersToRelabel"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Select Inventory Items to Relabel"
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsItems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents btnClose As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents bsItems As System.Windows.Forms.BindingSource
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents rbtnRelabel As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As CustomDevExGridView
    Friend WithEvents colInvitemnumber1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProductid3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProductdesc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colContainer As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colShipmentnumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colShipmentdate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colShippeddate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReceiveddate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLotnumber1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colWarehouselocation1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colWarehousenumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAllocateddate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReceivernumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colItemstatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInventoryclass As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colClassdesc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnitsremaining As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReceiverdocument As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReceiverdocumenttype As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPonumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPurchasereleasenumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVendorname As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPodate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colChangeableponumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAllocateddocument As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colWorkordernumber1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colWorkordercustomer As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colShiptocustomer As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemLookUpEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemLookUpEdit5 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemCheckEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents RepositoryItemLookUpEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
End Class
