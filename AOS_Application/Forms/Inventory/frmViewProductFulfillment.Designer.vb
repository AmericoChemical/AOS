<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmviewProductFulfillment

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
        Dim ProductDescriptionLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmviewProductFulfillment))
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.eProductID = New DevExpress.XtraEditors.TextEdit()
        Me.bsProduct = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComponentRibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btnClose = New DevExpress.XtraBars.BarButtonItem()
        Me.btnProductFulfillmentAdd = New DevExpress.XtraBars.BarButtonItem()
        Me.btnProductFulfillmentEdit = New DevExpress.XtraBars.BarButtonItem()
        Me.btnProductFulfillmentDelete = New DevExpress.XtraBars.BarButtonItem()
        Me.btnRelabelInstructions = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup3 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup4 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RepositoryItemWeekOfMonth1 = New DevExpress.XtraScheduler.UI.RepositoryItemWeekOfMonth()
        Me.RepositoryItemAppointmentLabel1 = New DevExpress.XtraScheduler.UI.RepositoryItemAppointmentLabel()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.eProductDescription = New DevExpress.XtraEditors.TextEdit()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.grProductFulfillmentList = New DevExpress.XtraGrid.GridControl()
        Me.bsProductFulfillment = New System.Windows.Forms.BindingSource(Me.components)
        Me.viewProductFulfillment = New AOS.CustomClasses.CustomDevExGridView()
        Me.colProductid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProdcutDescription = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFulfillmenttype = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPriority = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAssociateProductID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAssociateProductDescription = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAssociatedproductcontainer = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKitid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStdlaborhrs = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit16 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.RepositoryItemLookUpEdit17 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.btnSave = New DevExpress.XtraBars.BarButtonItem()
        ProductidLabel = New System.Windows.Forms.Label()
        ProductDescriptionLabel = New System.Windows.Forms.Label()
        CType(Me.eProductID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsProduct, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComponentRibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemWeekOfMonth1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemAppointmentLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.eProductDescription.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.grProductFulfillmentList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsProductFulfillment, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.viewProductFulfillment, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit17, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProductidLabel
        '
        ProductidLabel.AutoSize = True
        ProductidLabel.Location = New System.Drawing.Point(61, 32)
        ProductidLabel.Name = "ProductidLabel"
        ProductidLabel.Size = New System.Drawing.Size(58, 13)
        ProductidLabel.TabIndex = 0
        ProductidLabel.Text = "Product ID"
        '
        'ProductDescriptionLabel
        '
        ProductDescriptionLabel.AutoSize = True
        ProductDescriptionLabel.Location = New System.Drawing.Point(19, 59)
        ProductDescriptionLabel.Name = "ProductDescriptionLabel"
        ProductDescriptionLabel.Size = New System.Drawing.Size(100, 13)
        ProductDescriptionLabel.TabIndex = 8
        ProductDescriptionLabel.Text = "Product Description"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'eProductID
        '
        Me.eProductID.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsProduct, "Productid", True))
        Me.eProductID.Location = New System.Drawing.Point(125, 29)
        Me.eProductID.Name = "eProductID"
        Me.eProductID.Properties.ReadOnly = True
        Me.eProductID.Size = New System.Drawing.Size(64, 20)
        Me.eProductID.TabIndex = 1
        Me.eProductID.TabStop = False
        '
        'bsProduct
        '
        Me.bsProduct.DataSource = GetType(AOS.BusinessObjects.Product)
        '
        'ComponentRibbonControl1
        '
        Me.ComponentRibbonControl1.ApplicationButtonText = Nothing
        Me.ComponentRibbonControl1.ExpandCollapseItem.Id = 0
        Me.ComponentRibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.ComponentRibbonControl1.ExpandCollapseItem, Me.btnClose, Me.btnProductFulfillmentAdd, Me.btnProductFulfillmentEdit, Me.btnProductFulfillmentDelete, Me.btnRelabelInstructions})
        Me.ComponentRibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.ComponentRibbonControl1.MaxItemId = 29
        Me.ComponentRibbonControl1.Name = "ComponentRibbonControl1"
        Me.ComponentRibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.ComponentRibbonControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemWeekOfMonth1, Me.RepositoryItemAppointmentLabel1})
        Me.ComponentRibbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide
        Me.ComponentRibbonControl1.ShowToolbarCustomizeItem = False
        Me.ComponentRibbonControl1.Size = New System.Drawing.Size(757, 116)
        Me.ComponentRibbonControl1.Toolbar.ShowCustomizeItem = False
        Me.ComponentRibbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden
        '
        'btnClose
        '
        Me.btnClose.Caption = "Close"
        Me.btnClose.Id = 5
        Me.btnClose.ImageOptions.LargeImage = Global.AOS.My.Resources.Resources.Close
        Me.btnClose.Name = "btnClose"
        Me.btnClose.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'btnProductFulfillmentAdd
        '
        Me.btnProductFulfillmentAdd.Caption = "Add New Product Fulfillment"
        Me.btnProductFulfillmentAdd.Id = 24
        Me.btnProductFulfillmentAdd.ImageOptions.LargeImage = Global.AOS.My.Resources.Resources.NewRecord
        Me.btnProductFulfillmentAdd.Name = "btnProductFulfillmentAdd"
        '
        'btnProductFulfillmentEdit
        '
        Me.btnProductFulfillmentEdit.Caption = "Edit Product Fulfillment"
        Me.btnProductFulfillmentEdit.Id = 25
        Me.btnProductFulfillmentEdit.ImageOptions.LargeImage = Global.AOS.My.Resources.Resources.EditData
        Me.btnProductFulfillmentEdit.Name = "btnProductFulfillmentEdit"
        Me.btnProductFulfillmentEdit.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'btnProductFulfillmentDelete
        '
        Me.btnProductFulfillmentDelete.Caption = "Delete Product Fulfillment"
        Me.btnProductFulfillmentDelete.Id = 26
        Me.btnProductFulfillmentDelete.ImageOptions.Image = CType(resources.GetObject("btnProductFulfillmentDelete.ImageOptions.Image"), System.Drawing.Image)
        Me.btnProductFulfillmentDelete.Name = "btnProductFulfillmentDelete"
        Me.btnProductFulfillmentDelete.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'btnRelabelInstructions
        '
        Me.btnRelabelInstructions.Caption = "Relabel Instructions"
        Me.btnRelabelInstructions.Id = 28
        Me.btnRelabelInstructions.ImageOptions.LargeImage = CType(resources.GetObject("btnRelabelInstructions.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnRelabelInstructions.Name = "btnRelabelInstructions"
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup2, Me.RibbonPageGroup3, Me.RibbonPageGroup4})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "RibbonPage1"
        '
        'RibbonPageGroup2
        '
        Me.RibbonPageGroup2.AllowMinimize = False
        Me.RibbonPageGroup2.AllowTextClipping = False
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btnClose)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.ShowCaptionButton = False
        Me.RibbonPageGroup2.Text = "Action"
        '
        'RibbonPageGroup3
        '
        Me.RibbonPageGroup3.AllowMinimize = False
        Me.RibbonPageGroup3.AllowTextClipping = False
        Me.RibbonPageGroup3.ItemLinks.Add(Me.btnProductFulfillmentAdd)
        Me.RibbonPageGroup3.ItemLinks.Add(Me.btnProductFulfillmentEdit)
        Me.RibbonPageGroup3.ItemLinks.Add(Me.btnProductFulfillmentDelete)
        Me.RibbonPageGroup3.Name = "RibbonPageGroup3"
        Me.RibbonPageGroup3.ShowCaptionButton = False
        Me.RibbonPageGroup3.Text = "Product Fulfillment Items"
        '
        'RibbonPageGroup4
        '
        Me.RibbonPageGroup4.AllowMinimize = False
        Me.RibbonPageGroup4.AllowTextClipping = False
        Me.RibbonPageGroup4.ItemLinks.Add(Me.btnRelabelInstructions)
        Me.RibbonPageGroup4.Name = "RibbonPageGroup4"
        Me.RibbonPageGroup4.ShowCaptionButton = False
        Me.RibbonPageGroup4.Text = "Relabel Instr."
        '
        'RepositoryItemWeekOfMonth1
        '
        Me.RepositoryItemWeekOfMonth1.AutoHeight = False
        Me.RepositoryItemWeekOfMonth1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemWeekOfMonth1.Name = "RepositoryItemWeekOfMonth1"
        '
        'RepositoryItemAppointmentLabel1
        '
        Me.RepositoryItemAppointmentLabel1.AutoHeight = False
        Me.RepositoryItemAppointmentLabel1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemAppointmentLabel1.Name = "RepositoryItemAppointmentLabel1"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.eProductDescription)
        Me.GroupControl1.Controls.Add(ProductDescriptionLabel)
        Me.GroupControl1.Controls.Add(Me.eProductID)
        Me.GroupControl1.Controls.Add(ProductidLabel)
        Me.GroupControl1.Location = New System.Drawing.Point(2, 101)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(749, 86)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "Product Information"
        '
        'eProductDescription
        '
        Me.eProductDescription.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsProduct, "Productdesc", True))
        Me.eProductDescription.Location = New System.Drawing.Point(125, 56)
        Me.eProductDescription.Name = "eProductDescription"
        Me.eProductDescription.Properties.ReadOnly = True
        Me.eProductDescription.Size = New System.Drawing.Size(444, 20)
        Me.eProductDescription.TabIndex = 9
        Me.eProductDescription.TabStop = False
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.grProductFulfillmentList)
        Me.GroupControl2.Location = New System.Drawing.Point(2, 193)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(749, 216)
        Me.GroupControl2.TabIndex = 1
        Me.GroupControl2.Text = "Product Fulfillment Information"
        '
        'grProductFulfillmentList
        '
        Me.grProductFulfillmentList.DataSource = Me.bsProductFulfillment
        Me.grProductFulfillmentList.Dock = System.Windows.Forms.DockStyle.Fill
        GridLevelNode1.RelationName = "Level1"
        Me.grProductFulfillmentList.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.grProductFulfillmentList.Location = New System.Drawing.Point(2, 20)
        Me.grProductFulfillmentList.MainView = Me.viewProductFulfillment
        Me.grProductFulfillmentList.Name = "grProductFulfillmentList"
        Me.grProductFulfillmentList.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit16, Me.RepositoryItemLookUpEdit17})
        Me.grProductFulfillmentList.Size = New System.Drawing.Size(745, 194)
        Me.grProductFulfillmentList.TabIndex = 0
        Me.grProductFulfillmentList.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.viewProductFulfillment})
        '
        'bsProductFulfillment
        '
        Me.bsProductFulfillment.DataSource = GetType(AOS.BusinessObjects.ViewProductFulfillmentCollection)
        '
        'viewProductFulfillment
        '
        Me.viewProductFulfillment.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colProductid, Me.colProdcutDescription, Me.colFulfillmenttype, Me.colPriority, Me.colAssociateProductID, Me.colAssociateProductDescription, Me.colAssociatedproductcontainer, Me.colKitid, Me.colStdlaborhrs})
        Me.viewProductFulfillment.GridControl = Me.grProductFulfillmentList
        Me.viewProductFulfillment.Name = "viewProductFulfillment"
        Me.viewProductFulfillment.OptionsBehavior.Editable = False
        Me.viewProductFulfillment.OptionsSelection.MultiSelect = True
        Me.viewProductFulfillment.OptionsView.ShowGroupPanel = False
        '
        'colProductid
        '
        Me.colProductid.Caption = "Product ID"
        Me.colProductid.FieldName = "Productid"
        Me.colProductid.Name = "colProductid"
        Me.colProductid.OptionsColumn.AllowEdit = False
        Me.colProductid.Width = 68
        '
        'colProdcutDescription
        '
        Me.colProdcutDescription.Caption = "Product Description"
        Me.colProdcutDescription.FieldName = "Product"
        Me.colProdcutDescription.Name = "colProdcutDescription"
        Me.colProdcutDescription.Width = 151
        '
        'colFulfillmenttype
        '
        Me.colFulfillmenttype.Caption = "Fulfillment Type"
        Me.colFulfillmenttype.FieldName = "Fulfillmenttype"
        Me.colFulfillmenttype.Name = "colFulfillmenttype"
        Me.colFulfillmenttype.OptionsColumn.AllowEdit = False
        Me.colFulfillmenttype.Visible = True
        Me.colFulfillmenttype.VisibleIndex = 0
        Me.colFulfillmenttype.Width = 86
        '
        'colPriority
        '
        Me.colPriority.Caption = "Priority"
        Me.colPriority.FieldName = "Priority"
        Me.colPriority.Name = "colPriority"
        Me.colPriority.Visible = True
        Me.colPriority.VisibleIndex = 1
        Me.colPriority.Width = 47
        '
        'colAssociateProductID
        '
        Me.colAssociateProductID.Caption = "Associate Product ID"
        Me.colAssociateProductID.FieldName = "Associatedproductid"
        Me.colAssociateProductID.Name = "colAssociateProductID"
        Me.colAssociateProductID.Visible = True
        Me.colAssociateProductID.VisibleIndex = 2
        Me.colAssociateProductID.Width = 113
        '
        'colAssociateProductDescription
        '
        Me.colAssociateProductDescription.Caption = "Associate Product Description"
        Me.colAssociateProductDescription.FieldName = "Associatedproduct"
        Me.colAssociateProductDescription.Name = "colAssociateProductDescription"
        Me.colAssociateProductDescription.OptionsColumn.AllowEdit = False
        Me.colAssociateProductDescription.Visible = True
        Me.colAssociateProductDescription.VisibleIndex = 3
        Me.colAssociateProductDescription.Width = 391
        '
        'colAssociatedproductcontainer
        '
        Me.colAssociatedproductcontainer.Caption = "Container"
        Me.colAssociatedproductcontainer.FieldName = "Associatedproductcontainer"
        Me.colAssociatedproductcontainer.Name = "colAssociatedproductcontainer"
        Me.colAssociatedproductcontainer.Visible = True
        Me.colAssociatedproductcontainer.VisibleIndex = 4
        '
        'colKitid
        '
        Me.colKitid.Caption = "Kit"
        Me.colKitid.FieldName = "Kitid"
        Me.colKitid.Name = "colKitid"
        Me.colKitid.Visible = True
        Me.colKitid.VisibleIndex = 5
        '
        'colStdlaborhrs
        '
        Me.colStdlaborhrs.Caption = "Labor Hrs"
        Me.colStdlaborhrs.FieldName = "Stdlaborhrs"
        Me.colStdlaborhrs.Name = "colStdlaborhrs"
        Me.colStdlaborhrs.Visible = True
        Me.colStdlaborhrs.VisibleIndex = 6
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
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.AllowMinimize = False
        Me.RibbonPageGroup1.AllowTextClipping = False
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.ShowCaptionButton = False
        Me.RibbonPageGroup1.Tag = "8"
        '
        'btnSave
        '
        Me.btnSave.Caption = " Save Product Fulfillment"
        Me.btnSave.Id = 4
        Me.btnSave.ImageOptions.LargeImage = Global.AOS.My.Resources.Resources.SaveChanges
        Me.btnSave.Name = "btnSave"
        Me.btnSave.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'frmviewProductFulfillment
        '
        Me.ClientSize = New System.Drawing.Size(757, 412)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.ComponentRibbonControl1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmviewProductFulfillment"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Product Fulfillment Records"
        CType(Me.eProductID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsProduct, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComponentRibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemWeekOfMonth1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemAppointmentLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.eProductDescription.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.grProductFulfillmentList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsProductFulfillment, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.viewProductFulfillment, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit17, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents eProductID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ComponentRibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents btnClose As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents RepositoryItemWeekOfMonth1 As DevExpress.XtraScheduler.UI.RepositoryItemWeekOfMonth
    Friend WithEvents RepositoryItemAppointmentLabel1 As DevExpress.XtraScheduler.UI.RepositoryItemAppointmentLabel
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents btnProductFulfillmentAdd As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnProductFulfillmentEdit As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnProductFulfillmentDelete As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents grProductFulfillmentList As DevExpress.XtraGrid.GridControl
    Friend WithEvents viewProductFulfillment As CustomDevExGridView
    Friend WithEvents colProductid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFulfillmenttype As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPriority As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit16 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemLookUpEdit17 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents bsProduct As System.Windows.Forms.BindingSource
    Friend WithEvents bsProductFulfillment As System.Windows.Forms.BindingSource
    Friend WithEvents colAssociateProductDescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RibbonPageGroup3 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup4 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents eProductDescription As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnSave As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents colProdcutDescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAssociateProductID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnRelabelInstructions As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents colKitid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStdlaborhrs As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAssociatedproductcontainer As DevExpress.XtraGrid.Columns.GridColumn
End Class
