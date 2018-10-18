<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddEditProductFulfillment

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
        Dim FulfillmentypeLabel As System.Windows.Forms.Label
        Dim PriorityLabel As System.Windows.Forms.Label
        Dim AssociateproductidLabel As System.Windows.Forms.Label
        Dim ProductDescriptionLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim lKit As System.Windows.Forms.Label
        Dim lLabor As System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ComponentRibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btnSave = New DevExpress.XtraBars.BarButtonItem()
        Me.btnCancel = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RepositoryItemWeekOfMonth1 = New DevExpress.XtraScheduler.UI.RepositoryItemWeekOfMonth()
        Me.RepositoryItemAppointmentLabel1 = New DevExpress.XtraScheduler.UI.RepositoryItemAppointmentLabel()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.eLabor = New DevExpress.XtraEditors.TextEdit()
        Me.bsProductFulfillmentPlan = New System.Windows.Forms.BindingSource(Me.components)
        Me.eKit = New DevExpress.XtraEditors.LookUpEdit()
        Me.bsKits = New System.Windows.Forms.BindingSource(Me.components)
        Me.eProductDescription = New DevExpress.XtraEditors.TextEdit()
        Me.bsProducts = New System.Windows.Forms.BindingSource(Me.components)
        Me.eProductID = New DevExpress.XtraEditors.TextEdit()
        Me.AssociateProductLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.bsAssociateProducts = New System.Windows.Forms.BindingSource(Me.components)
        Me.eFulfillmentType = New DevExpress.XtraEditors.LookUpEdit()
        Me.bsFulfillmentType = New System.Windows.Forms.BindingSource(Me.components)
        Me.PriorityTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        FulfillmentypeLabel = New System.Windows.Forms.Label()
        PriorityLabel = New System.Windows.Forms.Label()
        AssociateproductidLabel = New System.Windows.Forms.Label()
        ProductDescriptionLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        lKit = New System.Windows.Forms.Label()
        lLabor = New System.Windows.Forms.Label()
        CType(Me.ComponentRibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemWeekOfMonth1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemAppointmentLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.eLabor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsProductFulfillmentPlan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eKit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsKits, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eProductDescription.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eProductID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AssociateProductLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsAssociateProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eFulfillmentType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsFulfillmentType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PriorityTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FulfillmentypeLabel
        '
        FulfillmentypeLabel.AutoSize = True
        FulfillmentypeLabel.Location = New System.Drawing.Point(32, 83)
        FulfillmentypeLabel.Name = "FulfillmentypeLabel"
        FulfillmentypeLabel.Size = New System.Drawing.Size(82, 13)
        FulfillmentypeLabel.TabIndex = 4
        FulfillmentypeLabel.Text = "Fulfillment Type"
        '
        'PriorityLabel
        '
        PriorityLabel.AutoSize = True
        PriorityLabel.Location = New System.Drawing.Point(73, 109)
        PriorityLabel.Name = "PriorityLabel"
        PriorityLabel.Size = New System.Drawing.Size(41, 13)
        PriorityLabel.TabIndex = 6
        PriorityLabel.Text = "Priority"
        '
        'AssociateproductidLabel
        '
        AssociateproductidLabel.AutoSize = True
        AssociateproductidLabel.Location = New System.Drawing.Point(15, 135)
        AssociateproductidLabel.Name = "AssociateproductidLabel"
        AssociateproductidLabel.Size = New System.Drawing.Size(99, 13)
        AssociateproductidLabel.TabIndex = 8
        AssociateproductidLabel.Text = "Associated Product"
        '
        'ProductDescriptionLabel
        '
        ProductDescriptionLabel.AutoSize = True
        ProductDescriptionLabel.Location = New System.Drawing.Point(14, 58)
        ProductDescriptionLabel.Name = "ProductDescriptionLabel"
        ProductDescriptionLabel.Size = New System.Drawing.Size(100, 13)
        ProductDescriptionLabel.TabIndex = 2
        ProductDescriptionLabel.Text = "Product Description"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(56, 31)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(58, 13)
        Label1.TabIndex = 0
        Label1.Text = "Product ID"
        '
        'lKit
        '
        lKit.AutoSize = True
        lKit.Location = New System.Drawing.Point(194, 109)
        lKit.Name = "lKit"
        lKit.Size = New System.Drawing.Size(30, 13)
        lKit.TabIndex = 12
        lKit.Text = "Kit #"
        '
        'lLabor
        '
        lLabor.AutoSize = True
        lLabor.Location = New System.Drawing.Point(300, 109)
        lLabor.Name = "lLabor"
        lLabor.Size = New System.Drawing.Size(72, 13)
        lLabor.TabIndex = 13
        lLabor.Text = "Std Labor Hrs"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'ComponentRibbonControl1
        '
        Me.ComponentRibbonControl1.ApplicationButtonText = Nothing
        Me.ComponentRibbonControl1.ExpandCollapseItem.Id = 0
        Me.ComponentRibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.ComponentRibbonControl1.ExpandCollapseItem, Me.btnSave, Me.btnCancel})
        Me.ComponentRibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.ComponentRibbonControl1.MaxItemId = 28
        Me.ComponentRibbonControl1.Name = "ComponentRibbonControl1"
        Me.ComponentRibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.ComponentRibbonControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemWeekOfMonth1, Me.RepositoryItemAppointmentLabel1})
        Me.ComponentRibbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide
        Me.ComponentRibbonControl1.ShowToolbarCustomizeItem = False
        Me.ComponentRibbonControl1.Size = New System.Drawing.Size(463, 116)
        Me.ComponentRibbonControl1.Toolbar.ShowCustomizeItem = False
        Me.ComponentRibbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden
        '
        'btnSave
        '
        Me.btnSave.Caption = " Save  Product Fulfillment"
        Me.btnSave.Id = 4
        Me.btnSave.ImageOptions.LargeImage = Global.AOS.My.Resources.Resources.SaveChanges
        Me.btnSave.Name = "btnSave"
        Me.btnSave.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'btnCancel
        '
        Me.btnCancel.Caption = "Cancel Product Fulfillment"
        Me.btnCancel.Id = 5
        Me.btnCancel.ImageOptions.LargeImage = Global.AOS.My.Resources.Resources.CancelChanges
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup2})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "RibbonPage1"
        '
        'RibbonPageGroup2
        '
        Me.RibbonPageGroup2.AllowMinimize = False
        Me.RibbonPageGroup2.AllowTextClipping = False
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btnSave)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btnCancel)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.ShowCaptionButton = False
        Me.RibbonPageGroup2.Text = "Product Fulfillment Management"
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
        Me.GroupControl1.Controls.Add(lLabor)
        Me.GroupControl1.Controls.Add(lKit)
        Me.GroupControl1.Controls.Add(Me.eLabor)
        Me.GroupControl1.Controls.Add(Me.eKit)
        Me.GroupControl1.Controls.Add(Me.eProductDescription)
        Me.GroupControl1.Controls.Add(ProductDescriptionLabel)
        Me.GroupControl1.Controls.Add(Me.eProductID)
        Me.GroupControl1.Controls.Add(Label1)
        Me.GroupControl1.Controls.Add(Me.AssociateProductLookUpEdit)
        Me.GroupControl1.Controls.Add(Me.eFulfillmentType)
        Me.GroupControl1.Controls.Add(AssociateproductidLabel)
        Me.GroupControl1.Controls.Add(PriorityLabel)
        Me.GroupControl1.Controls.Add(Me.PriorityTextEdit)
        Me.GroupControl1.Controls.Add(FulfillmentypeLabel)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(0, 116)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(463, 203)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "Product Fulfillment Information"
        '
        'eLabor
        '
        Me.eLabor.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsProductFulfillmentPlan, "Stdlaborhrs", True))
        Me.eLabor.Location = New System.Drawing.Point(378, 106)
        Me.eLabor.Name = "eLabor"
        Me.eLabor.Properties.DisplayFormat.FormatString = "n2"
        Me.eLabor.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.eLabor.Properties.MaxLength = 9
        Me.eLabor.Size = New System.Drawing.Size(64, 20)
        Me.eLabor.TabIndex = 3
        '
        'bsProductFulfillmentPlan
        '
        Me.bsProductFulfillmentPlan.DataSource = GetType(AOS.BusinessObjects.Productfulfillmentplan)
        '
        'eKit
        '
        Me.eKit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsProductFulfillmentPlan, "Kitid", True))
        Me.eKit.Location = New System.Drawing.Point(230, 106)
        Me.eKit.Name = "eKit"
        Me.eKit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.eKit.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kitid", "Kit #", 50, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kitname", "Kit Name", 150, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.eKit.Properties.DataSource = Me.bsKits
        Me.eKit.Properties.DisplayMember = "Kitid"
        Me.eKit.Properties.DropDownRows = 10
        Me.eKit.Properties.NullText = ""
        Me.eKit.Properties.PopupWidth = 200
        Me.eKit.Properties.ShowFooter = False
        Me.eKit.Properties.ValueMember = "Kitid"
        Me.eKit.Size = New System.Drawing.Size(57, 20)
        Me.eKit.TabIndex = 2
        '
        'bsKits
        '
        Me.bsKits.DataSource = GetType(AOS.BusinessObjects.KitCollection)
        '
        'eProductDescription
        '
        Me.eProductDescription.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsProducts, "Productdesc", True))
        Me.eProductDescription.Location = New System.Drawing.Point(120, 54)
        Me.eProductDescription.Name = "eProductDescription"
        Me.eProductDescription.Properties.ReadOnly = True
        Me.eProductDescription.Size = New System.Drawing.Size(322, 20)
        Me.eProductDescription.TabIndex = 3
        Me.eProductDescription.TabStop = False
        '
        'bsProducts
        '
        Me.bsProducts.DataSource = GetType(AOS.BusinessObjects.ViewPriceListProductsCollection)
        '
        'eProductID
        '
        Me.eProductID.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsProducts, "Productid", True))
        Me.eProductID.Location = New System.Drawing.Point(120, 28)
        Me.eProductID.Name = "eProductID"
        Me.eProductID.Properties.ReadOnly = True
        Me.eProductID.Size = New System.Drawing.Size(64, 20)
        Me.eProductID.TabIndex = 1
        Me.eProductID.TabStop = False
        '
        'AssociateProductLookUpEdit
        '
        Me.AssociateProductLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsProductFulfillmentPlan, "Associatedproductid", True))
        Me.AssociateProductLookUpEdit.Location = New System.Drawing.Point(120, 132)
        Me.AssociateProductLookUpEdit.Name = "AssociateProductLookUpEdit"
        Me.AssociateProductLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.AssociateProductLookUpEdit.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Productid", "ID", 64, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Productdesc", "Description", 120, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Container", 60, "Container")})
        Me.AssociateProductLookUpEdit.Properties.DataSource = Me.bsAssociateProducts
        Me.AssociateProductLookUpEdit.Properties.DisplayMember = "Productdesc"
        Me.AssociateProductLookUpEdit.Properties.NullText = ""
        Me.AssociateProductLookUpEdit.Properties.PopupWidth = 400
        Me.AssociateProductLookUpEdit.Properties.ValueMember = "Productid"
        Me.AssociateProductLookUpEdit.Size = New System.Drawing.Size(322, 20)
        Me.AssociateProductLookUpEdit.TabIndex = 4
        '
        'bsAssociateProducts
        '
        Me.bsAssociateProducts.DataSource = GetType(AOS.BusinessObjects.ViewPriceListProductsCollection)
        '
        'eFulfillmentType
        '
        Me.eFulfillmentType.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsProductFulfillmentPlan, "Fulfillmenttypeid", True))
        Me.eFulfillmentType.Location = New System.Drawing.Point(120, 80)
        Me.eFulfillmentType.Name = "eFulfillmentType"
        Me.eFulfillmentType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.eFulfillmentType.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Fulfillmenttypeid", 5, "Fulfillment Type ID"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Fulfillmenttype", "Fulfillment Type", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", 30, "Description")})
        Me.eFulfillmentType.Properties.DataSource = Me.bsFulfillmentType
        Me.eFulfillmentType.Properties.DisplayMember = "Fulfillmenttype"
        Me.eFulfillmentType.Properties.DropDownRows = 10
        Me.eFulfillmentType.Properties.NullText = ""
        Me.eFulfillmentType.Properties.PopupWidth = 200
        Me.eFulfillmentType.Properties.ShowFooter = False
        Me.eFulfillmentType.Properties.ValueMember = "Fulfillmenttypeid"
        Me.eFulfillmentType.Size = New System.Drawing.Size(322, 20)
        Me.eFulfillmentType.TabIndex = 0
        '
        'bsFulfillmentType
        '
        Me.bsFulfillmentType.DataSource = GetType(AOS.BusinessObjects.ListFulfillmenttype)
        '
        'PriorityTextEdit
        '
        Me.PriorityTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsProductFulfillmentPlan, "Priority", True))
        Me.PriorityTextEdit.Location = New System.Drawing.Point(120, 106)
        Me.PriorityTextEdit.Name = "PriorityTextEdit"
        Me.PriorityTextEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PriorityTextEdit.Properties.Mask.EditMask = "d"
        Me.PriorityTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.PriorityTextEdit.Properties.MaxLength = 9
        Me.PriorityTextEdit.Size = New System.Drawing.Size(64, 20)
        Me.PriorityTextEdit.TabIndex = 1
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.AllowMinimize = False
        Me.RibbonPageGroup1.AllowTextClipping = False
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.ShowCaptionButton = False
        Me.RibbonPageGroup1.Tag = "8"
        '
        'frmAddEditProductFulfillment
        '
        Me.ClientSize = New System.Drawing.Size(463, 319)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.ComponentRibbonControl1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmAddEditProductFulfillment"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Product Fulfillment Information"
        CType(Me.ComponentRibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemWeekOfMonth1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemAppointmentLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.eLabor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsProductFulfillmentPlan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eKit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsKits, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eProductDescription.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsProducts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eProductID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AssociateProductLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsAssociateProducts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eFulfillmentType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsFulfillmentType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PriorityTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ComponentRibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents btnSave As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnCancel As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents RepositoryItemWeekOfMonth1 As DevExpress.XtraScheduler.UI.RepositoryItemWeekOfMonth
    Friend WithEvents RepositoryItemAppointmentLabel1 As DevExpress.XtraScheduler.UI.RepositoryItemAppointmentLabel
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents bsFulfillmentType As System.Windows.Forms.BindingSource
    Friend WithEvents PriorityTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents eFulfillmentType As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents bsAssociateProducts As System.Windows.Forms.BindingSource
    Friend WithEvents AssociateProductLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents bsProductFulfillmentPlan As System.Windows.Forms.BindingSource
    Friend WithEvents eProductDescription As DevExpress.XtraEditors.TextEdit
    Friend WithEvents eProductID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents bsProducts As System.Windows.Forms.BindingSource
    Friend WithEvents eLabor As DevExpress.XtraEditors.TextEdit
    Friend WithEvents eKit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents bsKits As BindingSource
End Class
