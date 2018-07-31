<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddEditMaterialItem

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
        Dim MaterialdescLabel As System.Windows.Forms.Label
        Dim MaterialidLabel As System.Windows.Forms.Label
        Dim MaterialuomLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddEditMaterialItem))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.bsItem = New System.Windows.Forms.BindingSource(Me.components)
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btnSave = New DevExpress.XtraBars.BarButtonItem()
        Me.btnCancel = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnAddNewProduct = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnEditProductLink = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnDeleteProductLink = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnChangeMaterialStatus = New DevExpress.XtraBars.BarButtonItem()
        Me.ImageCollection1 = New DevExpress.Utils.ImageCollection(Me.components)
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.MaterialdescTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.MaterialidTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.MaterialuomTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.bsProducts = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.eStatus = New DevExpress.XtraEditors.TextEdit()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.grProducts = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New CustomDevExGridView()
        Me.colMaterialid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProductid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProductdesc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colContainer = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnits = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Priority = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUom = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMpnote = New DevExpress.XtraGrid.Columns.GridColumn()
        MaterialdescLabel = New System.Windows.Forms.Label()
        MaterialidLabel = New System.Windows.Forms.Label()
        MaterialuomLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        CType(Me.bsItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImageCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MaterialdescTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MaterialidTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MaterialuomTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.eStatus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.grProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MaterialdescLabel
        '
        MaterialdescLabel.AutoSize = True
        MaterialdescLabel.Location = New System.Drawing.Point(21, 54)
        MaterialdescLabel.Name = "MaterialdescLabel"
        MaterialdescLabel.Size = New System.Drawing.Size(75, 13)
        MaterialdescLabel.TabIndex = 13
        MaterialdescLabel.Text = "Material Desc:"
        '
        'MaterialidLabel
        '
        MaterialidLabel.AutoSize = True
        MaterialidLabel.Location = New System.Drawing.Point(33, 28)
        MaterialidLabel.Name = "MaterialidLabel"
        MaterialidLabel.Size = New System.Drawing.Size(63, 13)
        MaterialidLabel.TabIndex = 14
        MaterialidLabel.Text = "Material ID:"
        '
        'MaterialuomLabel
        '
        MaterialuomLabel.AutoSize = True
        MaterialuomLabel.Location = New System.Drawing.Point(9, 80)
        MaterialuomLabel.Name = "MaterialuomLabel"
        MaterialuomLabel.Size = New System.Drawing.Size(87, 13)
        MaterialuomLabel.TabIndex = 15
        MaterialuomLabel.Text = "Unit of Measure:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(684, 28)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(42, 13)
        Label1.TabIndex = 17
        Label1.Text = "Status:"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'bsItem
        '
        Me.bsItem.DataSource = GetType(AOS.BusinessObjects.Material)
        '
        'RibbonControl1
        '
        Me.RibbonControl1.ApplicationButtonText = Nothing
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.btnSave, Me.btnCancel, Me.rbtnAddNewProduct, Me.rbtnEditProductLink, Me.rbtnDeleteProductLink, Me.rbtnChangeMaterialStatus})
        Me.RibbonControl1.LargeImages = Me.ImageCollection1
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.MaxItemId = 10
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide
        Me.RibbonControl1.ShowToolbarCustomizeItem = False
        Me.RibbonControl1.Size = New System.Drawing.Size(814, 95)
        Me.RibbonControl1.Toolbar.ShowCustomizeItem = False
        Me.RibbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden
        '
        'btnSave
        '
        Me.btnSave.Caption = "Save"
        Me.btnSave.Id = 4
        Me.btnSave.LargeImageIndex = 0
        Me.btnSave.Name = "btnSave"
        '
        'btnCancel
        '
        Me.btnCancel.Caption = "Cancel"
        Me.btnCancel.Id = 5
        Me.btnCancel.LargeImageIndex = 1
        Me.btnCancel.Name = "btnCancel"
        '
        'rbtnAddNewProduct
        '
        Me.rbtnAddNewProduct.Caption = " Add   Product Link"
        Me.rbtnAddNewProduct.Id = 6
        Me.rbtnAddNewProduct.LargeImageIndex = 3
        Me.rbtnAddNewProduct.Name = "rbtnAddNewProduct"
        '
        'rbtnEditProductLink
        '
        Me.rbtnEditProductLink.Caption = " Edit  Product Link"
        Me.rbtnEditProductLink.Id = 7
        Me.rbtnEditProductLink.LargeImageIndex = 4
        Me.rbtnEditProductLink.Name = "rbtnEditProductLink"
        '
        'rbtnDeleteProductLink
        '
        Me.rbtnDeleteProductLink.Caption = "Delete Product Link"
        Me.rbtnDeleteProductLink.Id = 8
        Me.rbtnDeleteProductLink.LargeImageIndex = 5
        Me.rbtnDeleteProductLink.Name = "rbtnDeleteProductLink"
        '
        'rbtnChangeMaterialStatus
        '
        Me.rbtnChangeMaterialStatus.Caption = "Change Status"
        Me.rbtnChangeMaterialStatus.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.rbtnChangeMaterialStatus.Id = 9
        Me.rbtnChangeMaterialStatus.LargeImageIndex = 2
        Me.rbtnChangeMaterialStatus.Name = "rbtnChangeMaterialStatus"
        '
        'ImageCollection1
        '
        Me.ImageCollection1.ImageSize = New System.Drawing.Size(32, 32)
        Me.ImageCollection1.ImageStream = CType(resources.GetObject("ImageCollection1.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
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
        Me.RibbonPageGroup2.ItemLinks.Add(Me.rbtnChangeMaterialStatus, True)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.ShowCaptionButton = False
        Me.RibbonPageGroup2.Text = "Actions"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.ItemLinks.Add(Me.rbtnAddNewProduct)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.rbtnEditProductLink)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.rbtnDeleteProductLink)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.Text = "Material Product Links"
        '
        'MaterialdescTextEdit
        '
        Me.MaterialdescTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsItem, "Materialdesc", True))
        Me.MaterialdescTextEdit.Location = New System.Drawing.Point(99, 51)
        Me.MaterialdescTextEdit.MenuManager = Me.RibbonControl1
        Me.MaterialdescTextEdit.Name = "MaterialdescTextEdit"
        Me.MaterialdescTextEdit.Size = New System.Drawing.Size(394, 20)
        Me.MaterialdescTextEdit.TabIndex = 14
        '
        'MaterialidTextEdit
        '
        Me.MaterialidTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsItem, "Materialid", True))
        Me.MaterialidTextEdit.Location = New System.Drawing.Point(99, 25)
        Me.MaterialidTextEdit.MenuManager = Me.RibbonControl1
        Me.MaterialidTextEdit.Name = "MaterialidTextEdit"
        Me.MaterialidTextEdit.Properties.ReadOnly = True
        Me.MaterialidTextEdit.Size = New System.Drawing.Size(52, 20)
        Me.MaterialidTextEdit.TabIndex = 15
        Me.MaterialidTextEdit.TabStop = False
        '
        'MaterialuomTextEdit
        '
        Me.MaterialuomTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsItem, "Materialuom", True))
        Me.MaterialuomTextEdit.Location = New System.Drawing.Point(99, 77)
        Me.MaterialuomTextEdit.MenuManager = Me.RibbonControl1
        Me.MaterialuomTextEdit.Name = "MaterialuomTextEdit"
        Me.MaterialuomTextEdit.Size = New System.Drawing.Size(52, 20)
        Me.MaterialuomTextEdit.TabIndex = 16
        '
        'bsProducts
        '
        Me.bsProducts.DataSource = GetType(AOS.BusinessObjects.ViewMaterialProductInfoCollection)
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Label1)
        Me.GroupControl1.Controls.Add(Me.eStatus)
        Me.GroupControl1.Controls.Add(MaterialidLabel)
        Me.GroupControl1.Controls.Add(Me.MaterialidTextEdit)
        Me.GroupControl1.Controls.Add(MaterialuomLabel)
        Me.GroupControl1.Controls.Add(MaterialdescLabel)
        Me.GroupControl1.Controls.Add(Me.MaterialdescTextEdit)
        Me.GroupControl1.Controls.Add(Me.MaterialuomTextEdit)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl1.Location = New System.Drawing.Point(0, 95)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(814, 106)
        Me.GroupControl1.TabIndex = 19
        Me.GroupControl1.Text = "Material Information"
        '
        'eStatus
        '
        Me.eStatus.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsItem, "Materialstatus", True))
        Me.eStatus.Location = New System.Drawing.Point(732, 25)
        Me.eStatus.MenuManager = Me.RibbonControl1
        Me.eStatus.Name = "eStatus"
        Me.eStatus.Properties.ReadOnly = True
        Me.eStatus.Size = New System.Drawing.Size(70, 20)
        Me.eStatus.TabIndex = 18
        Me.eStatus.TabStop = False
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.grProducts)
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl2.Location = New System.Drawing.Point(0, 201)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(814, 342)
        Me.GroupControl2.TabIndex = 20
        Me.GroupControl2.Text = "Products Linked to Material Item"
        '
        'grProducts
        '
        Me.grProducts.DataSource = Me.bsProducts
        Me.grProducts.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grProducts.Location = New System.Drawing.Point(2, 22)
        Me.grProducts.MainView = Me.GridView1
        Me.grProducts.MenuManager = Me.RibbonControl1
        Me.grProducts.Name = "grProducts"
        Me.grProducts.Size = New System.Drawing.Size(810, 318)
        Me.grProducts.TabIndex = 0
        Me.grProducts.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colMaterialid, Me.colProductid, Me.colProductdesc, Me.colContainer, Me.colUnits, Me.Priority, Me.colUom, Me.colMpnote})
        Me.GridView1.GridControl = Me.grProducts
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.OptionsView.ShowIndicator = False
        '
        'colMaterialid
        '
        Me.colMaterialid.FieldName = "Materialid"
        Me.colMaterialid.Name = "colMaterialid"
        '
        'colProductid
        '
        Me.colProductid.Caption = "Prod ID"
        Me.colProductid.FieldName = "Productid"
        Me.colProductid.Name = "colProductid"
        Me.colProductid.Visible = True
        Me.colProductid.VisibleIndex = 0
        Me.colProductid.Width = 56
        '
        'colProductdesc
        '
        Me.colProductdesc.Caption = "Product Description"
        Me.colProductdesc.FieldName = "Productdesc"
        Me.colProductdesc.Name = "colProductdesc"
        Me.colProductdesc.Visible = True
        Me.colProductdesc.VisibleIndex = 1
        Me.colProductdesc.Width = 278
        '
        'colContainer
        '
        Me.colContainer.Caption = "Container"
        Me.colContainer.FieldName = "Container"
        Me.colContainer.Name = "colContainer"
        Me.colContainer.Visible = True
        Me.colContainer.VisibleIndex = 2
        Me.colContainer.Width = 88
        '
        'colUnits
        '
        Me.colUnits.Caption = "Units"
        Me.colUnits.FieldName = "Units"
        Me.colUnits.Name = "colUnits"
        Me.colUnits.Visible = True
        Me.colUnits.VisibleIndex = 3
        Me.colUnits.Width = 39
        '
        'Priority
        '
        Me.Priority.Caption = "Priority"
        Me.Priority.FieldName = "Priority"
        Me.Priority.Name = "Priority"
        Me.Priority.Visible = True
        Me.Priority.VisibleIndex = 5
        Me.Priority.Width = 48
        '
        'colUom
        '
        Me.colUom.Caption = "UOM"
        Me.colUom.FieldName = "Uom"
        Me.colUom.Name = "colUom"
        Me.colUom.Visible = True
        Me.colUom.VisibleIndex = 4
        Me.colUom.Width = 42
        '
        'colMpnote
        '
        Me.colMpnote.Caption = "Notes"
        Me.colMpnote.FieldName = "Mpnote"
        Me.colMpnote.Name = "colMpnote"
        Me.colMpnote.Visible = True
        Me.colMpnote.VisibleIndex = 6
        Me.colMpnote.Width = 259
        '
        'frmAddEditMaterialItem
        '
        Me.ClientSize = New System.Drawing.Size(814, 543)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.RibbonControl1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmAddEditMaterialItem"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Material Item Information"
        CType(Me.bsItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImageCollection1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MaterialdescTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MaterialidTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MaterialuomTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsProducts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.eStatus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.grProducts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents bsItem As System.Windows.Forms.BindingSource
    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents btnSave As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnCancel As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents MaterialdescTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents MaterialidTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents MaterialuomTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents rbtnAddNewProduct As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rbtnEditProductLink As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rbtnDeleteProductLink As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents bsProducts As System.Windows.Forms.BindingSource
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents grProducts As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As CustomDevExGridView
    Friend WithEvents colMaterialid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProductid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProductdesc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colContainer As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnits As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUom As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Priority As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ImageCollection1 As DevExpress.Utils.ImageCollection
    Friend WithEvents rbtnChangeMaterialStatus As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents eStatus As DevExpress.XtraEditors.TextEdit
    Friend WithEvents colMpnote As DevExpress.XtraGrid.Columns.GridColumn
End Class
