<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddNewWorkOrderItem

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
        Me.components = New System.ComponentModel.Container
        Dim ProductidLabel As System.Windows.Forms.Label
        Dim QtycontainersLabel As System.Windows.Forms.Label
        Dim ContainerLabel As System.Windows.Forms.Label
        Dim UnitcostLabel As System.Windows.Forms.Label
        Dim ItempriceLabel As System.Windows.Forms.Label
        Dim UnitorcontainerLabel As System.Windows.Forms.Label
        Dim UnitsLabel As System.Windows.Forms.Label
        Dim UomLabel As System.Windows.Forms.Label
        Dim BillableLabel As System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.eProduct = New DevExpress.XtraEditors.LookUpEdit
        Me.bsItem = New System.Windows.Forms.BindingSource(Me.components)
        Me.bsProducts = New System.Windows.Forms.BindingSource(Me.components)
        Me.eQty = New DevExpress.XtraEditors.TextEdit
        Me.DefaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
        Me.eContainer = New DevExpress.XtraEditors.TextEdit
        Me.eUnitCost = New DevExpress.XtraEditors.ButtonEdit
        Me.eItemPrice = New DevExpress.XtraEditors.ButtonEdit
        Me.eUC = New DevExpress.XtraEditors.TextEdit
        Me.eUnits = New DevExpress.XtraEditors.TextEdit
        Me.BillableCheckEdit = New DevExpress.XtraEditors.CheckEdit
        Me.bsProductCosts = New System.Windows.Forms.BindingSource(Me.components)
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl
        Me.btnNewCostRecord = New DevExpress.XtraBars.BarButtonItem
        Me.btnEditCostRecord = New DevExpress.XtraBars.BarButtonItem
        Me.btnDeleteCostRecord = New DevExpress.XtraBars.BarButtonItem
        Me.btnSave = New DevExpress.XtraBars.BarButtonItem
        Me.btnCancel = New DevExpress.XtraBars.BarButtonItem
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup
        Me.eUOM = New DevExpress.XtraEditors.TextEdit
        ProductidLabel = New System.Windows.Forms.Label
        QtycontainersLabel = New System.Windows.Forms.Label
        ContainerLabel = New System.Windows.Forms.Label
        UnitcostLabel = New System.Windows.Forms.Label
        ItempriceLabel = New System.Windows.Forms.Label
        UnitorcontainerLabel = New System.Windows.Forms.Label
        UnitsLabel = New System.Windows.Forms.Label
        UomLabel = New System.Windows.Forms.Label
        BillableLabel = New System.Windows.Forms.Label
        CType(Me.eProduct.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eQty.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eContainer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eUnitCost.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eItemPrice.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eUC.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eUnits.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BillableCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsProductCosts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eUOM.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProductidLabel
        '
        ProductidLabel.AutoSize = True
        ProductidLabel.Location = New System.Drawing.Point(123, 112)
        ProductidLabel.Name = "ProductidLabel"
        ProductidLabel.Size = New System.Drawing.Size(44, 13)
        ProductidLabel.TabIndex = 1
        ProductidLabel.Text = "Product"
        '
        'QtycontainersLabel
        '
        QtycontainersLabel.AutoSize = True
        QtycontainersLabel.Location = New System.Drawing.Point(10, 112)
        QtycontainersLabel.Name = "QtycontainersLabel"
        QtycontainersLabel.Size = New System.Drawing.Size(49, 13)
        QtycontainersLabel.TabIndex = 5
        QtycontainersLabel.Text = "Quantity"
        '
        'ContainerLabel
        '
        ContainerLabel.AutoSize = True
        ContainerLabel.Location = New System.Drawing.Point(257, 154)
        ContainerLabel.Name = "ContainerLabel"
        ContainerLabel.Size = New System.Drawing.Size(54, 13)
        ContainerLabel.TabIndex = 6
        ContainerLabel.Text = "Container"
        '
        'UnitcostLabel
        '
        UnitcostLabel.AutoSize = True
        UnitcostLabel.Location = New System.Drawing.Point(13, 154)
        UnitcostLabel.Name = "UnitcostLabel"
        UnitcostLabel.Size = New System.Drawing.Size(51, 13)
        UnitcostLabel.TabIndex = 7
        UnitcostLabel.Text = "Unit Cost"
        '
        'ItempriceLabel
        '
        ItempriceLabel.AutoSize = True
        ItempriceLabel.Location = New System.Drawing.Point(13, 200)
        ItempriceLabel.Name = "ItempriceLabel"
        ItempriceLabel.Size = New System.Drawing.Size(52, 13)
        ItempriceLabel.TabIndex = 9
        ItempriceLabel.Text = "Unit Price"
        '
        'UnitorcontainerLabel
        '
        UnitorcontainerLabel.AutoSize = True
        UnitorcontainerLabel.Location = New System.Drawing.Point(84, 112)
        UnitorcontainerLabel.Name = "UnitorcontainerLabel"
        UnitorcontainerLabel.Size = New System.Drawing.Size(25, 13)
        UnitorcontainerLabel.TabIndex = 11
        UnitorcontainerLabel.Text = "U/C"
        '
        'UnitsLabel
        '
        UnitsLabel.AutoSize = True
        UnitsLabel.Location = New System.Drawing.Point(206, 154)
        UnitsLabel.Name = "UnitsLabel"
        UnitsLabel.Size = New System.Drawing.Size(31, 13)
        UnitsLabel.TabIndex = 13
        UnitsLabel.Text = "Units"
        '
        'UomLabel
        '
        UomLabel.AutoSize = True
        UomLabel.Location = New System.Drawing.Point(126, 154)
        UomLabel.Name = "UomLabel"
        UomLabel.Size = New System.Drawing.Size(30, 13)
        UomLabel.TabIndex = 15
        UomLabel.Text = "UOM"
        '
        'BillableLabel
        '
        BillableLabel.AutoSize = True
        BillableLabel.Location = New System.Drawing.Point(123, 200)
        BillableLabel.Name = "BillableLabel"
        BillableLabel.Size = New System.Drawing.Size(39, 13)
        BillableLabel.TabIndex = 20
        BillableLabel.Text = "Billable"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'eProduct
        '
        Me.eProduct.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsItem, "Productid", True))
        Me.eProduct.Location = New System.Drawing.Point(126, 128)
        Me.eProduct.Name = "eProduct"
        Me.eProduct.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.eProduct.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Productid", "ID", 64, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Productdesc", "Description", 200, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Desc2", "Addn Desc", 100), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Container", "Container", 85, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.eProduct.Properties.DataSource = Me.bsProducts
        Me.eProduct.Properties.DisplayMember = "Productdesc"
        Me.eProduct.Properties.NullText = ""
        Me.eProduct.Properties.PopupWidth = 400
        Me.eProduct.Properties.ValueMember = "Productid"
        Me.eProduct.Size = New System.Drawing.Size(212, 20)
        Me.eProduct.TabIndex = 2
        '
        'bsItem
        '
        Me.bsItem.DataSource = GetType(AOS.BusinessObjects.Workorderitem)
        '
        'bsProducts
        '
        Me.bsProducts.DataSource = GetType(AOS.BusinessObjects.ProductCollection)
        '
        'eQty
        '
        Me.eQty.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsItem, "Qty", True))
        Me.eQty.Location = New System.Drawing.Point(12, 128)
        Me.eQty.Name = "eQty"
        Me.eQty.Properties.Appearance.Options.UseTextOptions = True
        Me.eQty.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.eQty.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.eQty.Size = New System.Drawing.Size(58, 20)
        Me.eQty.TabIndex = 0
        '
        'DefaultLookAndFeel1
        '
        Me.DefaultLookAndFeel1.LookAndFeel.SkinName = "Money Twins"
        '
        'eContainer
        '
        Me.eContainer.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsItem, "Container", True))
        Me.eContainer.Location = New System.Drawing.Point(260, 170)
        Me.eContainer.Name = "eContainer"
        Me.eContainer.Properties.ReadOnly = True
        Me.eContainer.Size = New System.Drawing.Size(78, 20)
        Me.eContainer.TabIndex = 7
        '
        'eUnitCost
        '
        Me.eUnitCost.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsItem, "Unitcost", True))
        Me.eUnitCost.Location = New System.Drawing.Point(13, 170)
        Me.eUnitCost.Name = "eUnitCost"
        Me.eUnitCost.Properties.Appearance.Options.UseTextOptions = True
        Me.eUnitCost.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.eUnitCost.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "Update", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing)})
        Me.eUnitCost.Properties.DisplayFormat.FormatString = "c3"
        Me.eUnitCost.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.eUnitCost.Size = New System.Drawing.Size(96, 20)
        Me.eUnitCost.TabIndex = 4
        '
        'eItemPrice
        '
        Me.eItemPrice.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsItem, "Itemprice", True))
        Me.eItemPrice.Location = New System.Drawing.Point(13, 216)
        Me.eItemPrice.Name = "eItemPrice"
        Me.eItemPrice.Properties.Appearance.Options.UseTextOptions = True
        Me.eItemPrice.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.eItemPrice.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "Update", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing)})
        Me.eItemPrice.Properties.DisplayFormat.FormatString = "c3"
        Me.eItemPrice.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.eItemPrice.Size = New System.Drawing.Size(96, 20)
        Me.eItemPrice.TabIndex = 5
        '
        'eUC
        '
        Me.eUC.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsItem, "Unitorcontainer", True))
        Me.eUC.Location = New System.Drawing.Point(82, 128)
        Me.eUC.Name = "eUC"
        Me.eUC.Properties.Mask.EditMask = "U|C"
        Me.eUC.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx
        Me.eUC.Properties.Mask.ShowPlaceHolders = False
        Me.eUC.Size = New System.Drawing.Size(27, 20)
        Me.eUC.TabIndex = 1
        '
        'eUnits
        '
        Me.eUnits.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsItem, "Units", True))
        Me.eUnits.Location = New System.Drawing.Point(209, 170)
        Me.eUnits.Name = "eUnits"
        Me.eUnits.Properties.ReadOnly = True
        Me.eUnits.Size = New System.Drawing.Size(45, 20)
        Me.eUnits.TabIndex = 14
        '
        'BillableCheckEdit
        '
        Me.BillableCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsItem, "Billable", True))
        Me.BillableCheckEdit.EditValue = 0
        Me.BillableCheckEdit.Location = New System.Drawing.Point(132, 217)
        Me.BillableCheckEdit.Name = "BillableCheckEdit"
        Me.BillableCheckEdit.Properties.Caption = ""
        Me.BillableCheckEdit.Size = New System.Drawing.Size(24, 18)
        Me.BillableCheckEdit.TabIndex = 6
        '
        'bsProductCosts
        '
        Me.bsProductCosts.DataSource = GetType(AOS.BusinessObjects.ProductcostCollection)
        '
        'RibbonControl1
        '
        Me.RibbonControl1.ApplicationButtonKeyTip = ""
        Me.RibbonControl1.ApplicationIcon = Nothing
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnNewCostRecord, Me.btnEditCostRecord, Me.btnDeleteCostRecord, Me.btnSave, Me.btnCancel})
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.MaxItemId = 6
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl1.SelectedPage = Me.RibbonPage1
        Me.RibbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide
        Me.RibbonControl1.ShowToolbarCustomizeItem = False
        Me.RibbonControl1.Size = New System.Drawing.Size(357, 94)
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
        Me.btnCancel.Id = 5
        Me.btnCancel.LargeGlyph = Global.AOS.My.Resources.Resources.CancelChanges
        Me.btnCancel.Name = "btnCancel"
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup2})
        Me.RibbonPage1.KeyTip = ""
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "RibbonPage1"
        '
        'RibbonPageGroup2
        '
        Me.RibbonPageGroup2.AllowTextClipping = False
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btnSave)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btnCancel)
        Me.RibbonPageGroup2.KeyTip = ""
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.ShowCaptionButton = False
        Me.RibbonPageGroup2.Text = "Actions"
        '
        'eUOM
        '
        Me.eUOM.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsItem, "Uom", True))
        Me.eUOM.Location = New System.Drawing.Point(126, 170)
        Me.eUOM.Name = "eUOM"
        Me.eUOM.Properties.ReadOnly = True
        Me.eUOM.Size = New System.Drawing.Size(77, 20)
        Me.eUOM.TabIndex = 23
        '
        'frmAddNewWorkOrderItem
        '
        Me.ClientSize = New System.Drawing.Size(357, 251)
        Me.ControlBox = False
        Me.Controls.Add(Me.eUOM)
        Me.Controls.Add(Me.RibbonControl1)
        Me.Controls.Add(BillableLabel)
        Me.Controls.Add(Me.BillableCheckEdit)
        Me.Controls.Add(UomLabel)
        Me.Controls.Add(UnitsLabel)
        Me.Controls.Add(Me.eUnits)
        Me.Controls.Add(UnitorcontainerLabel)
        Me.Controls.Add(Me.eUC)
        Me.Controls.Add(ItempriceLabel)
        Me.Controls.Add(Me.eItemPrice)
        Me.Controls.Add(UnitcostLabel)
        Me.Controls.Add(Me.eUnitCost)
        Me.Controls.Add(ContainerLabel)
        Me.Controls.Add(Me.eContainer)
        Me.Controls.Add(QtycontainersLabel)
        Me.Controls.Add(Me.eQty)
        Me.Controls.Add(ProductidLabel)
        Me.Controls.Add(Me.eProduct)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmAddNewWorkOrderItem"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Work Order Item Information"
        CType(Me.eProduct.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsProducts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eQty.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eContainer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eUnitCost.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eItemPrice.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eUC.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eUnits.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BillableCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsProductCosts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eUOM.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents bsProducts As System.Windows.Forms.BindingSource
    Friend WithEvents bsItem As System.Windows.Forms.BindingSource
    Friend WithEvents eProduct As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents eQty As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DefaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
    Friend WithEvents eContainer As DevExpress.XtraEditors.TextEdit
    Friend WithEvents eUnitCost As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents eItemPrice As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents eUC As DevExpress.XtraEditors.TextEdit
    Friend WithEvents eUnits As DevExpress.XtraEditors.TextEdit
    Friend WithEvents BillableCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents bsProductCosts As System.Windows.Forms.BindingSource
    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents btnNewCostRecord As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnEditCostRecord As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnDeleteCostRecord As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnSave As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnCancel As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents eUOM As DevExpress.XtraEditors.TextEdit
End Class
