<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddPrchItemsToPO

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
        Me.btnSelect = New DevExpress.XtraBars.BarButtonItem()
        Me.btnCancel = New DevExpress.XtraBars.BarButtonItem()
        Me.btnSplitItem = New DevExpress.XtraBars.BarButtonItem()
        Me.btnAllocate = New DevExpress.XtraBars.BarButtonItem()
        Me.btnUnallocate = New DevExpress.XtraBars.BarButtonItem()
        Me.btnMiscCharge = New DevExpress.XtraBars.BarButtonItem()
        Me.btnCOAText = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.grPendingPurchaseOrders = New DevExpress.XtraGrid.GridControl()
        Me.bsPendingPOs = New System.Windows.Forms.BindingSource(Me.components)
        Me.grvPurchaseOrders = New AOS.CustomClasses.CustomDevExGridView()
        Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colComponentQty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.bsVendorList = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn16 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn18 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit16 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.RepositoryItemLookUpEdit17 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.colShipname = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colShipcity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colShipstate = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.grPendingPurchaseOrders, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsPendingPOs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grvPurchaseOrders, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsVendorList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit17, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.btnSelect, Me.btnCancel, Me.btnSplitItem, Me.btnAllocate, Me.btnUnallocate, Me.btnMiscCharge, Me.btnCOAText})
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.MaxItemId = 14
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide
        Me.RibbonControl1.Size = New System.Drawing.Size(1232, 95)
        Me.RibbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden
        '
        'btnSelect
        '
        Me.btnSelect.Caption = "Select"
        Me.btnSelect.Id = 0
        Me.btnSelect.LargeGlyph = Global.AOS.My.Resources.Resources.SaveChanges
        Me.btnSelect.Name = "btnSelect"
        '
        'btnCancel
        '
        Me.btnCancel.Caption = "Cancel"
        Me.btnCancel.Id = 1
        Me.btnCancel.LargeGlyph = Global.AOS.My.Resources.Resources.CancelChanges
        Me.btnCancel.Name = "btnCancel"
        '
        'btnSplitItem
        '
        Me.btnSplitItem.Caption = "Split Item"
        Me.btnSplitItem.Id = 2
        Me.btnSplitItem.LargeGlyph = Global.AOS.My.Resources.Resources.List__2_
        Me.btnSplitItem.Name = "btnSplitItem"
        '
        'btnAllocate
        '
        Me.btnAllocate.Caption = "Allocate"
        Me.btnAllocate.Id = 6
        Me.btnAllocate.LargeGlyph = Global.AOS.My.Resources.Resources.Quarantine
        Me.btnAllocate.Name = "btnAllocate"
        '
        'btnUnallocate
        '
        Me.btnUnallocate.Caption = "Unallocate"
        Me.btnUnallocate.Id = 7
        Me.btnUnallocate.LargeGlyph = Global.AOS.My.Resources.Resources.Unquarantine
        Me.btnUnallocate.Name = "btnUnallocate"
        '
        'btnMiscCharge
        '
        Me.btnMiscCharge.Caption = "Misc" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Item"
        Me.btnMiscCharge.Id = 8
        Me.btnMiscCharge.LargeGlyph = Global.AOS.My.Resources.Resources.NewDocumentHS
        Me.btnMiscCharge.Name = "btnMiscCharge"
        '
        'btnCOAText
        '
        Me.btnCOAText.Caption = "COA Text"
        Me.btnCOAText.Id = 11
        Me.btnCOAText.LargeGlyph = Global.AOS.My.Resources.Resources.document_edit
        Me.btnCOAText.Name = "btnCOAText"
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "RibbonPage1"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.AllowTextClipping = False
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnSelect)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnCancel)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.ShowCaptionButton = False
        Me.RibbonPageGroup1.Text = "Actions"
        '
        'PanelControl1
        '
        Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl1.Controls.Add(Me.GroupControl2)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(0, 95)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1232, 319)
        Me.PanelControl1.TabIndex = 1
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.grPendingPurchaseOrders)
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl2.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(1232, 319)
        Me.GroupControl2.TabIndex = 4
        Me.GroupControl2.Text = "Purchase Orders "
        '
        'grPendingPurchaseOrders
        '
        Me.grPendingPurchaseOrders.DataSource = Me.bsPendingPOs
        Me.grPendingPurchaseOrders.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grPendingPurchaseOrders.Location = New System.Drawing.Point(2, 22)
        Me.grPendingPurchaseOrders.MainView = Me.grvPurchaseOrders
        Me.grPendingPurchaseOrders.Name = "grPendingPurchaseOrders"
        Me.grPendingPurchaseOrders.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit16, Me.RepositoryItemLookUpEdit17, Me.RepositoryItemLookUpEdit1})
        Me.grPendingPurchaseOrders.Size = New System.Drawing.Size(1228, 295)
        Me.grPendingPurchaseOrders.TabIndex = 2
        Me.grPendingPurchaseOrders.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grvPurchaseOrders})
        '
        'bsPendingPOs
        '
        Me.bsPendingPOs.DataSource = GetType(AOS.BusinessObjects.PurchaseCollection)
        '
        'grvPurchaseOrders
        '
        Me.grvPurchaseOrders.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn13, Me.col1, Me.colComponentQty, Me.col3, Me.GridColumn6, Me.GridColumn16, Me.GridColumn18, Me.colShipname, Me.colShipcity, Me.colShipstate})
        Me.grvPurchaseOrders.GridControl = Me.grPendingPurchaseOrders
        Me.grvPurchaseOrders.Name = "grvPurchaseOrders"
        Me.grvPurchaseOrders.OptionsBehavior.Editable = False
        Me.grvPurchaseOrders.OptionsView.ShowAutoFilterRow = True
        Me.grvPurchaseOrders.OptionsView.ShowGroupPanel = False
        '
        'GridColumn13
        '
        Me.GridColumn13.Caption = "Type"
        Me.GridColumn13.FieldName = "Purchasetype"
        Me.GridColumn13.Name = "GridColumn13"
        Me.GridColumn13.Visible = True
        Me.GridColumn13.VisibleIndex = 0
        Me.GridColumn13.Width = 80
        '
        'col1
        '
        Me.col1.Caption = "PO #"
        Me.col1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.col1.FieldName = "Purchasenumber"
        Me.col1.Name = "col1"
        Me.col1.OptionsColumn.AllowEdit = False
        Me.col1.Visible = True
        Me.col1.VisibleIndex = 1
        Me.col1.Width = 70
        '
        'colComponentQty
        '
        Me.colComponentQty.Caption = "PO Date"
        Me.colComponentQty.DisplayFormat.FormatString = "d"
        Me.colComponentQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colComponentQty.FieldName = "Purchasedate"
        Me.colComponentQty.Name = "colComponentQty"
        Me.colComponentQty.OptionsColumn.AllowEdit = False
        Me.colComponentQty.OptionsColumn.FixedWidth = True
        Me.colComponentQty.Visible = True
        Me.colComponentQty.VisibleIndex = 2
        Me.colComponentQty.Width = 65
        '
        'col3
        '
        Me.col3.Caption = "Vendor"
        Me.col3.ColumnEdit = Me.RepositoryItemLookUpEdit1
        Me.col3.FieldName = "Vendorid"
        Me.col3.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
        Me.col3.Name = "col3"
        Me.col3.OptionsColumn.AllowEdit = False
        Me.col3.Visible = True
        Me.col3.VisibleIndex = 3
        Me.col3.Width = 348
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.DataSource = Me.bsVendorList
        Me.RepositoryItemLookUpEdit1.DisplayMember = "Vendorname"
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        Me.RepositoryItemLookUpEdit1.NullText = ""
        Me.RepositoryItemLookUpEdit1.ValueMember = "Vendorid"
        '
        'bsVendorList
        '
        Me.bsVendorList.DataSource = GetType(AOS.BusinessObjects.VendorCollection)
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Expected In"
        Me.GridColumn6.DisplayFormat.FormatString = "d"
        Me.GridColumn6.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn6.FieldName = "Expectedindate"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.OptionsColumn.FixedWidth = True
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 4
        Me.GridColumn6.Width = 70
        '
        'GridColumn16
        '
        Me.GridColumn16.Caption = "Status"
        Me.GridColumn16.FieldName = "Purchasestatus"
        Me.GridColumn16.Name = "GridColumn16"
        Me.GridColumn16.OptionsColumn.FixedWidth = True
        Me.GridColumn16.Visible = True
        Me.GridColumn16.VisibleIndex = 5
        Me.GridColumn16.Width = 70
        '
        'GridColumn18
        '
        Me.GridColumn18.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn18.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn18.Caption = "Total $"
        Me.GridColumn18.DisplayFormat.FormatString = "c2"
        Me.GridColumn18.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn18.FieldName = "Total"
        Me.GridColumn18.Name = "GridColumn18"
        Me.GridColumn18.Visible = True
        Me.GridColumn18.VisibleIndex = 6
        Me.GridColumn18.Width = 78
        '
        'RepositoryItemLookUpEdit16
        '
        Me.RepositoryItemLookUpEdit16.AutoHeight = False
        Me.RepositoryItemLookUpEdit16.DisplayMember = "Productdesc"
        Me.RepositoryItemLookUpEdit16.Name = "RepositoryItemLookUpEdit16"
        Me.RepositoryItemLookUpEdit16.NullText = ""
        Me.RepositoryItemLookUpEdit16.ReadOnly = True
        Me.RepositoryItemLookUpEdit16.ValueMember = "Productid"
        '
        'RepositoryItemLookUpEdit17
        '
        Me.RepositoryItemLookUpEdit17.AutoHeight = False
        Me.RepositoryItemLookUpEdit17.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit17.DisplayMember = "Desc2"
        Me.RepositoryItemLookUpEdit17.Name = "RepositoryItemLookUpEdit17"
        Me.RepositoryItemLookUpEdit17.NullText = ""
        Me.RepositoryItemLookUpEdit17.ValueMember = "Productid"
        '
        'colShipname
        '
        Me.colShipname.Caption = "Ship To"
        Me.colShipname.FieldName = "Shipname"
        Me.colShipname.Name = "colShipname"
        Me.colShipname.Visible = True
        Me.colShipname.VisibleIndex = 7
        Me.colShipname.Width = 179
        '
        'colShipcity
        '
        Me.colShipcity.Caption = "City"
        Me.colShipcity.FieldName = "Shipcity"
        Me.colShipcity.Name = "colShipcity"
        Me.colShipcity.Visible = True
        Me.colShipcity.VisibleIndex = 8
        Me.colShipcity.Width = 136
        '
        'colShipstate
        '
        Me.colShipstate.Caption = "State"
        Me.colShipstate.FieldName = "Shipstate"
        Me.colShipstate.Name = "colShipstate"
        Me.colShipstate.Visible = True
        Me.colShipstate.VisibleIndex = 9
        Me.colShipstate.Width = 71
        '
        'frmAddPrchItemsToPO
        '
        Me.ClientSize = New System.Drawing.Size(1232, 414)
        Me.ControlBox = False
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.RibbonControl1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmAddPrchItemsToPO"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Add to Existing Purchase Order"
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.grPendingPurchaseOrders, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsPendingPOs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grvPurchaseOrders, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsVendorList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit17, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnSelect As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnCancel As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnSplitItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnAllocate As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnUnallocate As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnMiscCharge As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnCOAText As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents grPendingPurchaseOrders As DevExpress.XtraGrid.GridControl
    Friend WithEvents grvPurchaseOrders As CustomDevExGridView
    Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colComponentQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn16 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn18 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit16 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemLookUpEdit17 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents bsPendingPOs As System.Windows.Forms.BindingSource
    Friend WithEvents bsVendorList As System.Windows.Forms.BindingSource
    Friend WithEvents colShipname As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colShipcity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colShipstate As DevExpress.XtraGrid.Columns.GridColumn
End Class
