<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEnterGrossWeight

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
        Dim WarehouselocationLabel1 As System.Windows.Forms.Label
        Dim UnitcostLabel1 As System.Windows.Forms.Label
        Dim LotnumberLabel As System.Windows.Forms.Label
        Dim ContainerLabel As System.Windows.Forms.Label
        Dim UnitorcontainerLabel As System.Windows.Forms.Label
        Dim UnitsLabel As System.Windows.Forms.Label
        Dim UomLabel As System.Windows.Forms.Label
        Dim QtyreceivedLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.eProduct = New DevExpress.XtraEditors.LookUpEdit()
        Me.bsItem = New System.Windows.Forms.BindingSource(Me.components)
        Me.bsProducts = New System.Windows.Forms.BindingSource(Me.components)
        Me.WarehouselocationLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.bsLocations = New System.Windows.Forms.BindingSource(Me.components)
        Me.LotnumberTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.eContainer = New DevExpress.XtraEditors.TextEdit()
        Me.UnitorcontainerTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.eUOM = New DevExpress.XtraEditors.TextEdit()
        Me.eUnitCost = New DevExpress.XtraEditors.ButtonEdit()
        Me.eUnits = New DevExpress.XtraEditors.TextEdit()
        Me.QtyreceivedTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btnNewCostRecord = New DevExpress.XtraBars.BarButtonItem()
        Me.btnEditCostRecord = New DevExpress.XtraBars.BarButtonItem()
        Me.btnDeleteCostRecord = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.eInventoryClass = New DevExpress.XtraEditors.LookUpEdit()
        Me.bsInventoryClass = New System.Windows.Forms.BindingSource(Me.components)
        Me.eProductDesc = New DevExpress.XtraEditors.TextEdit()
        ProductidLabel = New System.Windows.Forms.Label()
        WarehouselocationLabel1 = New System.Windows.Forms.Label()
        UnitcostLabel1 = New System.Windows.Forms.Label()
        LotnumberLabel = New System.Windows.Forms.Label()
        ContainerLabel = New System.Windows.Forms.Label()
        UnitorcontainerLabel = New System.Windows.Forms.Label()
        UnitsLabel = New System.Windows.Forms.Label()
        UomLabel = New System.Windows.Forms.Label()
        QtyreceivedLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        CType(Me.eProduct.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WarehouselocationLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsLocations, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LotnumberTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eContainer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnitorcontainerTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eUOM.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eUnitCost.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eUnits.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QtyreceivedTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eInventoryClass.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsInventoryClass, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eProductDesc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProductidLabel
        '
        ProductidLabel.AutoSize = True
        ProductidLabel.Location = New System.Drawing.Point(17, 108)
        ProductidLabel.Name = "ProductidLabel"
        ProductidLabel.Size = New System.Drawing.Size(44, 13)
        ProductidLabel.TabIndex = 1
        ProductidLabel.Text = "Product"
        '
        'WarehouselocationLabel1
        '
        WarehouselocationLabel1.AutoSize = True
        WarehouselocationLabel1.Location = New System.Drawing.Point(17, 286)
        WarehouselocationLabel1.Name = "WarehouselocationLabel1"
        WarehouselocationLabel1.Size = New System.Drawing.Size(21, 13)
        WarehouselocationLabel1.TabIndex = 21
        WarehouselocationLabel1.Text = "Bin"
        '
        'UnitcostLabel1
        '
        UnitcostLabel1.AutoSize = True
        UnitcostLabel1.Location = New System.Drawing.Point(17, 186)
        UnitcostLabel1.Name = "UnitcostLabel1"
        UnitcostLabel1.Size = New System.Drawing.Size(51, 13)
        UnitcostLabel1.TabIndex = 23
        UnitcostLabel1.Text = "Unit Cost"
        '
        'LotnumberLabel
        '
        LotnumberLabel.AutoSize = True
        LotnumberLabel.Location = New System.Drawing.Point(17, 312)
        LotnumberLabel.Name = "LotnumberLabel"
        LotnumberLabel.Size = New System.Drawing.Size(62, 13)
        LotnumberLabel.TabIndex = 24
        LotnumberLabel.Text = "Lot Number"
        '
        'ContainerLabel
        '
        ContainerLabel.AutoSize = True
        ContainerLabel.Location = New System.Drawing.Point(17, 160)
        ContainerLabel.Name = "ContainerLabel"
        ContainerLabel.Size = New System.Drawing.Size(54, 13)
        ContainerLabel.TabIndex = 25
        ContainerLabel.Text = "Container"
        '
        'UnitorcontainerLabel
        '
        UnitorcontainerLabel.AutoSize = True
        UnitorcontainerLabel.Location = New System.Drawing.Point(17, 252)
        UnitorcontainerLabel.Name = "UnitorcontainerLabel"
        UnitorcontainerLabel.Size = New System.Drawing.Size(25, 13)
        UnitorcontainerLabel.TabIndex = 26
        UnitorcontainerLabel.Text = "U/C"
        '
        'UnitsLabel
        '
        UnitsLabel.AutoSize = True
        UnitsLabel.Location = New System.Drawing.Point(206, 160)
        UnitsLabel.Name = "UnitsLabel"
        UnitsLabel.Size = New System.Drawing.Size(31, 13)
        UnitsLabel.TabIndex = 27
        UnitsLabel.Text = "Units"
        '
        'UomLabel
        '
        UomLabel.AutoSize = True
        UomLabel.Location = New System.Drawing.Point(207, 186)
        UomLabel.Name = "UomLabel"
        UomLabel.Size = New System.Drawing.Size(30, 13)
        UomLabel.TabIndex = 28
        UomLabel.Text = "UOM"
        '
        'QtyreceivedLabel
        '
        QtyreceivedLabel.AutoSize = True
        QtyreceivedLabel.Location = New System.Drawing.Point(17, 226)
        QtyreceivedLabel.Name = "QtyreceivedLabel"
        QtyreceivedLabel.Size = New System.Drawing.Size(52, 13)
        QtyreceivedLabel.TabIndex = 31
        QtyreceivedLabel.Text = "Qty Recv"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(17, 339)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(51, 13)
        Label1.TabIndex = 34
        Label1.Text = "Inv Class"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(17, 134)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(60, 13)
        Label2.TabIndex = 37
        Label2.Text = "Description"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'eProduct
        '
        Me.eProduct.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsItem, "Productid", True))
        Me.eProduct.Location = New System.Drawing.Point(85, 105)
        Me.eProduct.Name = "eProduct"
        Me.eProduct.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.eProduct.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Productid", "Prod ID", 65, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Productdesc", "Description", 200, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Desc2", 100, "Addn Desc"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Container", "Container", 85, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.eProduct.Properties.DataSource = Me.bsProducts
        Me.eProduct.Properties.DisplayMember = "Productid"
        Me.eProduct.Properties.DropDownRows = 15
        Me.eProduct.Properties.NullText = ""
        Me.eProduct.Properties.PopupWidth = 400
        Me.eProduct.Properties.ValueMember = "Productid"
        Me.eProduct.Size = New System.Drawing.Size(69, 20)
        Me.eProduct.TabIndex = 2
        '
        'bsItem
        '
        Me.bsItem.DataSource = GetType(AOS.BusinessObjects.Receiveritem)
        '
        'bsProducts
        '
        Me.bsProducts.DataSource = GetType(AOS.BusinessObjects.ProductCollection)
        '
        'WarehouselocationLookUpEdit
        '
        Me.WarehouselocationLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsItem, "Warehouselocation", True))
        Me.WarehouselocationLookUpEdit.Location = New System.Drawing.Point(85, 283)
        Me.WarehouselocationLookUpEdit.Name = "WarehouselocationLookUpEdit"
        Me.WarehouselocationLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.WarehouselocationLookUpEdit.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Warehouselocation", "Bin", 50, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.WarehouselocationLookUpEdit.Properties.DataSource = Me.bsLocations
        Me.WarehouselocationLookUpEdit.Properties.DisplayMember = "Warehouselocation"
        Me.WarehouselocationLookUpEdit.Properties.DropDownRows = 10
        Me.WarehouselocationLookUpEdit.Properties.NullText = ""
        Me.WarehouselocationLookUpEdit.Properties.PopupSizeable = False
        Me.WarehouselocationLookUpEdit.Properties.PopupWidth = 100
        Me.WarehouselocationLookUpEdit.Properties.ShowFooter = False
        Me.WarehouselocationLookUpEdit.Properties.ValueMember = "Warehouselocation"
        Me.WarehouselocationLookUpEdit.Size = New System.Drawing.Size(69, 20)
        Me.WarehouselocationLookUpEdit.TabIndex = 22
        '
        'bsLocations
        '
        Me.bsLocations.DataSource = GetType(AOS.BusinessObjects.ListWarehouselocationCollection)
        '
        'LotnumberTextEdit
        '
        Me.LotnumberTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsItem, "Lotnumber", True))
        Me.LotnumberTextEdit.Location = New System.Drawing.Point(85, 309)
        Me.LotnumberTextEdit.Name = "LotnumberTextEdit"
        Me.LotnumberTextEdit.Size = New System.Drawing.Size(116, 20)
        Me.LotnumberTextEdit.TabIndex = 25
        '
        'eContainer
        '
        Me.eContainer.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsItem, "Container", True))
        Me.eContainer.Location = New System.Drawing.Point(85, 157)
        Me.eContainer.Name = "eContainer"
        Me.eContainer.Properties.ReadOnly = True
        Me.eContainer.Size = New System.Drawing.Size(116, 20)
        Me.eContainer.TabIndex = 26
        '
        'UnitorcontainerTextEdit
        '
        Me.UnitorcontainerTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsItem, "Unitorcontainer", True))
        Me.UnitorcontainerTextEdit.Location = New System.Drawing.Point(85, 249)
        Me.UnitorcontainerTextEdit.Name = "UnitorcontainerTextEdit"
        Me.UnitorcontainerTextEdit.Properties.Mask.EditMask = "C|U"
        Me.UnitorcontainerTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx
        Me.UnitorcontainerTextEdit.Properties.Mask.ShowPlaceHolders = False
        Me.UnitorcontainerTextEdit.Size = New System.Drawing.Size(25, 20)
        Me.UnitorcontainerTextEdit.TabIndex = 27
        '
        'eUOM
        '
        Me.eUOM.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsItem, "Uom", True))
        Me.eUOM.Location = New System.Drawing.Point(243, 183)
        Me.eUOM.Name = "eUOM"
        Me.eUOM.Properties.ReadOnly = True
        Me.eUOM.Size = New System.Drawing.Size(47, 20)
        Me.eUOM.TabIndex = 29
        '
        'eUnitCost
        '
        Me.eUnitCost.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsItem, "Unitcost", True))
        Me.eUnitCost.Location = New System.Drawing.Point(85, 183)
        Me.eUnitCost.Name = "eUnitCost"
        Me.eUnitCost.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "Update", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "", Nothing, Nothing, False)})
        Me.eUnitCost.Properties.ReadOnly = True
        Me.eUnitCost.Size = New System.Drawing.Size(116, 20)
        Me.eUnitCost.TabIndex = 30
        '
        'eUnits
        '
        Me.eUnits.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsItem, "Units", True))
        Me.eUnits.Location = New System.Drawing.Point(243, 157)
        Me.eUnits.Name = "eUnits"
        Me.eUnits.Properties.ReadOnly = True
        Me.eUnits.Size = New System.Drawing.Size(47, 20)
        Me.eUnits.TabIndex = 31
        '
        'QtyreceivedTextEdit
        '
        Me.QtyreceivedTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsItem, "Qtyreceived", True))
        Me.QtyreceivedTextEdit.Location = New System.Drawing.Point(85, 223)
        Me.QtyreceivedTextEdit.Name = "QtyreceivedTextEdit"
        Me.QtyreceivedTextEdit.Size = New System.Drawing.Size(69, 20)
        Me.QtyreceivedTextEdit.TabIndex = 32
        '
        'RibbonControl1
        '
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.ExpandCollapseItem.Name = ""
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.btnNewCostRecord, Me.btnEditCostRecord, Me.btnDeleteCostRecord, Me.BarButtonItem1, Me.BarButtonItem2})
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.MaxItemId = 6
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide
        Me.RibbonControl1.ShowToolbarCustomizeItem = False
        Me.RibbonControl1.Size = New System.Drawing.Size(309, 94)
        Me.RibbonControl1.Toolbar.ShowCustomizeItem = False
        Me.RibbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden
        '
        'btnNewCostRecord
        '
        Me.btnNewCostRecord.Caption = "New Cost Record"
        Me.btnNewCostRecord.Id = 0
        Me.btnNewCostRecord.LargeGlyph = Global.AOS.My.Resources.Resources.NewRecord
        Me.btnNewCostRecord.Name = "btnNewCostRecord"
        '
        'btnEditCostRecord
        '
        Me.btnEditCostRecord.Caption = "Edit Cost Record"
        Me.btnEditCostRecord.Glyph = Global.AOS.My.Resources.Resources.Edit
        Me.btnEditCostRecord.Id = 1
        Me.btnEditCostRecord.Name = "btnEditCostRecord"
        '
        'btnDeleteCostRecord
        '
        Me.btnDeleteCostRecord.Caption = "Delete Cost Record"
        Me.btnDeleteCostRecord.Glyph = Global.AOS.My.Resources.Resources.Delete
        Me.btnDeleteCostRecord.Id = 2
        Me.btnDeleteCostRecord.Name = "btnDeleteCostRecord"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Save"
        Me.BarButtonItem1.Id = 4
        Me.BarButtonItem1.LargeGlyph = Global.AOS.My.Resources.Resources.SaveChanges
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "Cancel"
        Me.BarButtonItem2.Id = 5
        Me.BarButtonItem2.LargeGlyph = Global.AOS.My.Resources.Resources.CancelChanges
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup2})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "RibbonPage1"
        '
        'RibbonPageGroup2
        '
        Me.RibbonPageGroup2.AllowTextClipping = False
        Me.RibbonPageGroup2.ItemLinks.Add(Me.BarButtonItem1)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.BarButtonItem2)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.ShowCaptionButton = False
        Me.RibbonPageGroup2.Text = "Actions"
        '
        'eInventoryClass
        '
        Me.eInventoryClass.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsItem, "Inventoryclass", True))
        Me.eInventoryClass.Location = New System.Drawing.Point(85, 336)
        Me.eInventoryClass.MenuManager = Me.RibbonControl1
        Me.eInventoryClass.Name = "eInventoryClass"
        Me.eInventoryClass.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.eInventoryClass.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("LookupDesc", "Lookup Desc", 70, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.eInventoryClass.Properties.DataSource = Me.bsInventoryClass
        Me.eInventoryClass.Properties.DisplayMember = "LookupDesc"
        Me.eInventoryClass.Properties.NullText = ""
        Me.eInventoryClass.Properties.ValueMember = "LookupValue"
        Me.eInventoryClass.Size = New System.Drawing.Size(116, 20)
        Me.eInventoryClass.TabIndex = 33
        '
        'bsInventoryClass
        '
        Me.bsInventoryClass.DataSource = GetType(AOS.BusinessObjects.ListInventoryclassCollection)
        '
        'eProductDesc
        '
        Me.eProductDesc.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsItem, "Productdesc", True))
        Me.eProductDesc.Location = New System.Drawing.Point(85, 131)
        Me.eProductDesc.Name = "eProductDesc"
        Me.eProductDesc.Properties.ReadOnly = True
        Me.eProductDesc.Size = New System.Drawing.Size(205, 20)
        Me.eProductDesc.TabIndex = 36
        '
        'frmAddNewReceiverItem
        '
        Me.ClientSize = New System.Drawing.Size(309, 373)
        Me.ControlBox = False
        Me.Controls.Add(Label2)
        Me.Controls.Add(Me.eProductDesc)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.eInventoryClass)
        Me.Controls.Add(Me.RibbonControl1)
        Me.Controls.Add(QtyreceivedLabel)
        Me.Controls.Add(Me.QtyreceivedTextEdit)
        Me.Controls.Add(Me.eUnits)
        Me.Controls.Add(Me.eUnitCost)
        Me.Controls.Add(UomLabel)
        Me.Controls.Add(Me.eUOM)
        Me.Controls.Add(UnitsLabel)
        Me.Controls.Add(UnitorcontainerLabel)
        Me.Controls.Add(Me.UnitorcontainerTextEdit)
        Me.Controls.Add(ContainerLabel)
        Me.Controls.Add(Me.eContainer)
        Me.Controls.Add(LotnumberLabel)
        Me.Controls.Add(Me.LotnumberTextEdit)
        Me.Controls.Add(UnitcostLabel1)
        Me.Controls.Add(WarehouselocationLabel1)
        Me.Controls.Add(Me.WarehouselocationLookUpEdit)
        Me.Controls.Add(ProductidLabel)
        Me.Controls.Add(Me.eProduct)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmAddNewReceiverItem"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Receiver Item Information"
        CType(Me.eProduct.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsProducts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WarehouselocationLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsLocations, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LotnumberTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eContainer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnitorcontainerTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eUOM.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eUnitCost.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eUnits.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QtyreceivedTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eInventoryClass.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsInventoryClass, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eProductDesc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents bsProducts As System.Windows.Forms.BindingSource
    Friend WithEvents bsItem As System.Windows.Forms.BindingSource
    Friend WithEvents eProduct As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents WarehouselocationLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents bsLocations As System.Windows.Forms.BindingSource
    Friend WithEvents LotnumberTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents eContainer As DevExpress.XtraEditors.TextEdit
    Friend WithEvents UnitorcontainerTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents eUOM As DevExpress.XtraEditors.TextEdit
    Friend WithEvents eUnitCost As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents eUnits As DevExpress.XtraEditors.TextEdit
    Friend WithEvents QtyreceivedTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents btnNewCostRecord As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnEditCostRecord As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnDeleteCostRecord As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents eInventoryClass As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents bsInventoryClass As System.Windows.Forms.BindingSource
    Friend WithEvents eProductDesc As DevExpress.XtraEditors.TextEdit
End Class
