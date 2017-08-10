<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddEditInvoiceMiscItem

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
        Dim ItempriceLabel As System.Windows.Forms.Label
        Dim UnitcostLabel As System.Windows.Forms.Label
        Dim ProductidLabel As System.Windows.Forms.Label
        Dim TaxableLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddEditInvoiceMiscItem))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.eTaxable = New DevExpress.XtraEditors.CheckEdit()
        Me.bsItem = New System.Windows.Forms.BindingSource(Me.components)
        Me.eChrgDesc = New DevExpress.XtraEditors.TextEdit()
        Me.eUnitCost = New DevExpress.XtraEditors.TextEdit()
        Me.eItemPrice = New DevExpress.XtraEditors.TextEdit()
        Me.eItemType = New DevExpress.XtraEditors.LookUpEdit()
        Me.bsItemTypes = New System.Windows.Forms.BindingSource(Me.components)
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btnNewCostRecord = New DevExpress.XtraBars.BarButtonItem()
        Me.btnEditCostRecord = New DevExpress.XtraBars.BarButtonItem()
        Me.btnDeleteCostRecord = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnSave = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnCancel = New DevExpress.XtraBars.BarButtonItem()
        Me.LargeRibbonImages = New DevExpress.Utils.ImageCollection(Me.components)
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        ItempriceLabel = New System.Windows.Forms.Label()
        UnitcostLabel = New System.Windows.Forms.Label()
        ProductidLabel = New System.Windows.Forms.Label()
        TaxableLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        CType(Me.eTaxable.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eChrgDesc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eUnitCost.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eItemPrice.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eItemType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsItemTypes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LargeRibbonImages, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ItempriceLabel
        '
        ItempriceLabel.AutoSize = True
        ItempriceLabel.Location = New System.Drawing.Point(10, 219)
        ItempriceLabel.Name = "ItempriceLabel"
        ItempriceLabel.Size = New System.Drawing.Size(52, 13)
        ItempriceLabel.TabIndex = 32
        ItempriceLabel.Text = "Unit Price"
        '
        'UnitcostLabel
        '
        UnitcostLabel.AutoSize = True
        UnitcostLabel.Location = New System.Drawing.Point(10, 193)
        UnitcostLabel.Name = "UnitcostLabel"
        UnitcostLabel.Size = New System.Drawing.Size(51, 13)
        UnitcostLabel.TabIndex = 31
        UnitcostLabel.Text = "Unit Cost"
        '
        'ProductidLabel
        '
        ProductidLabel.AutoSize = True
        ProductidLabel.Location = New System.Drawing.Point(10, 141)
        ProductidLabel.Name = "ProductidLabel"
        ProductidLabel.Size = New System.Drawing.Size(85, 13)
        ProductidLabel.TabIndex = 24
        ProductidLabel.Text = "Item Description"
        '
        'TaxableLabel
        '
        TaxableLabel.AutoSize = True
        TaxableLabel.Location = New System.Drawing.Point(10, 244)
        TaxableLabel.Name = "TaxableLabel"
        TaxableLabel.Size = New System.Drawing.Size(45, 13)
        TaxableLabel.TabIndex = 37
        TaxableLabel.Text = "Taxable"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(12, 102)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(56, 13)
        Label1.TabIndex = 39
        Label1.Text = "Item Type"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'eTaxable
        '
        Me.eTaxable.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsItem, "Taxable", True))
        Me.eTaxable.Location = New System.Drawing.Point(66, 242)
        Me.eTaxable.Name = "eTaxable"
        Me.eTaxable.Properties.Caption = ""
        Me.eTaxable.Size = New System.Drawing.Size(47, 19)
        Me.eTaxable.TabIndex = 4
        '
        'bsItem
        '
        Me.bsItem.DataSource = GetType(AOS.BusinessObjects.Invoiceitem)
        '
        'eChrgDesc
        '
        Me.eChrgDesc.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsItem, "Itemdescription", True))
        Me.eChrgDesc.Location = New System.Drawing.Point(12, 157)
        Me.eChrgDesc.Name = "eChrgDesc"
        Me.eChrgDesc.Size = New System.Drawing.Size(334, 20)
        Me.eChrgDesc.TabIndex = 1
        '
        'eUnitCost
        '
        Me.eUnitCost.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsItem, "Unitcost", True))
        Me.eUnitCost.Location = New System.Drawing.Point(68, 190)
        Me.eUnitCost.Name = "eUnitCost"
        Me.eUnitCost.Properties.Appearance.Options.UseTextOptions = True
        Me.eUnitCost.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.eUnitCost.Properties.DisplayFormat.FormatString = "c2"
        Me.eUnitCost.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.eUnitCost.Size = New System.Drawing.Size(51, 20)
        Me.eUnitCost.TabIndex = 2
        '
        'eItemPrice
        '
        Me.eItemPrice.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsItem, "Itemprice", True))
        Me.eItemPrice.Location = New System.Drawing.Point(68, 216)
        Me.eItemPrice.Name = "eItemPrice"
        Me.eItemPrice.Properties.Appearance.Options.UseTextOptions = True
        Me.eItemPrice.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.eItemPrice.Properties.DisplayFormat.FormatString = "c2"
        Me.eItemPrice.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.eItemPrice.Size = New System.Drawing.Size(51, 20)
        Me.eItemPrice.TabIndex = 3
        '
        'eItemType
        '
        Me.eItemType.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsItem, "Itemtype", True))
        Me.eItemType.Location = New System.Drawing.Point(12, 118)
        Me.eItemType.Name = "eItemType"
        Me.eItemType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.eItemType.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Itemtype", "Item type", 54, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.eItemType.Properties.DataSource = Me.bsItemTypes
        Me.eItemType.Properties.DisplayMember = "Itemtype"
        Me.eItemType.Properties.DropDownRows = 10
        Me.eItemType.Properties.NullText = ""
        Me.eItemType.Properties.PopupSizeable = False
        Me.eItemType.Properties.PopupWidth = 107
        Me.eItemType.Properties.ShowFooter = False
        Me.eItemType.Properties.ShowHeader = False
        Me.eItemType.Properties.ValueMember = "Itemtype"
        Me.eItemType.Size = New System.Drawing.Size(107, 20)
        Me.eItemType.TabIndex = 0
        '
        'bsItemTypes
        '
        Me.bsItemTypes.DataSource = GetType(AOS.BusinessObjects.ListItemtypeCollection)
        '
        'RibbonControl1
        '
        Me.RibbonControl1.ApplicationButtonText = Nothing
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.btnNewCostRecord, Me.btnEditCostRecord, Me.btnDeleteCostRecord, Me.rbtnSave, Me.rbtnCancel})
        Me.RibbonControl1.LargeImages = Me.LargeRibbonImages
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.MaxItemId = 6
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide
        Me.RibbonControl1.ShowToolbarCustomizeItem = False
        Me.RibbonControl1.Size = New System.Drawing.Size(358, 94)
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
        'rbtnSave
        '
        Me.rbtnSave.Caption = "Save"
        Me.rbtnSave.Id = 4
        Me.rbtnSave.LargeImageIndex = 0
        Me.rbtnSave.Name = "rbtnSave"
        '
        'rbtnCancel
        '
        Me.rbtnCancel.Caption = "Cancel"
        Me.rbtnCancel.Id = 5
        Me.rbtnCancel.LargeImageIndex = 1
        Me.rbtnCancel.Name = "rbtnCancel"
        '
        'LargeRibbonImages
        '
        Me.LargeRibbonImages.ImageSize = New System.Drawing.Size(32, 32)
        Me.LargeRibbonImages.ImageStream = CType(resources.GetObject("LargeRibbonImages.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
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
        Me.RibbonPageGroup2.ItemLinks.Add(Me.rbtnSave)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.rbtnCancel)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.ShowCaptionButton = False
        Me.RibbonPageGroup2.Text = "Actions"
        '
        'frmAddEditInvoiceMiscItem
        '
        Me.ClientSize = New System.Drawing.Size(358, 282)
        Me.ControlBox = False
        Me.Controls.Add(Me.RibbonControl1)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.eItemType)
        Me.Controls.Add(Me.eItemPrice)
        Me.Controls.Add(Me.eUnitCost)
        Me.Controls.Add(Me.eChrgDesc)
        Me.Controls.Add(TaxableLabel)
        Me.Controls.Add(Me.eTaxable)
        Me.Controls.Add(ItempriceLabel)
        Me.Controls.Add(UnitcostLabel)
        Me.Controls.Add(ProductidLabel)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmAddEditInvoiceMiscItem"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Miscellaneous Charge"
        CType(Me.eTaxable.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eChrgDesc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eUnitCost.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eItemPrice.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eItemType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsItemTypes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LargeRibbonImages, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents bsItem As System.Windows.Forms.BindingSource
    Friend WithEvents eTaxable As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents eChrgDesc As DevExpress.XtraEditors.TextEdit
    Friend WithEvents eUnitCost As DevExpress.XtraEditors.TextEdit
    Friend WithEvents eItemPrice As DevExpress.XtraEditors.TextEdit
    Friend WithEvents bsItemTypes As System.Windows.Forms.BindingSource
    Friend WithEvents eItemType As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents btnNewCostRecord As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnEditCostRecord As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnDeleteCostRecord As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rbtnSave As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rbtnCancel As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents LargeRibbonImages As DevExpress.Utils.ImageCollection
End Class
