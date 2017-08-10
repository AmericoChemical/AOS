<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChemicalProductLinks

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmChemicalProductLinks))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btnReturn = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnAddNewProduct = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnEditProduct = New DevExpress.XtraBars.BarButtonItem()
        Me.Ribbon_LargeImages = New DevExpress.Utils.ImageCollection(Me.components)
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.bsChem = New System.Windows.Forms.BindingSource(Me.components)
        Me.bsProducts = New System.Windows.Forms.BindingSource(Me.components)
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit()
        Me.eChemicalName = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New AOS.CustomClasses.CustomDevExGridView()
        Me.colProductid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProductdesc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colContainer = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProductstatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rbtnDeleteChemicalProductLink = New DevExpress.XtraBars.BarButtonItem()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ribbon_LargeImages, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsChem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eChemicalName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'RibbonControl1
        '
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.btnReturn, Me.rbtnAddNewProduct, Me.rbtnEditProduct, Me.rbtnDeleteChemicalProductLink})
        Me.RibbonControl1.LargeImages = Me.Ribbon_LargeImages
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.MaxItemId = 12
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide
        Me.RibbonControl1.ShowToolbarCustomizeItem = False
        Me.RibbonControl1.Size = New System.Drawing.Size(596, 95)
        Me.RibbonControl1.Toolbar.ShowCustomizeItem = False
        Me.RibbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden
        '
        'btnReturn
        '
        Me.btnReturn.Caption = "Return"
        Me.btnReturn.Id = 4
        Me.btnReturn.LargeImageIndex = 51
        Me.btnReturn.Name = "btnReturn"
        '
        'rbtnAddNewProduct
        '
        Me.rbtnAddNewProduct.Caption = "Add New Product Link"
        Me.rbtnAddNewProduct.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.rbtnAddNewProduct.Id = 9
        Me.rbtnAddNewProduct.LargeImageIndex = 2
        Me.rbtnAddNewProduct.Name = "rbtnAddNewProduct"
        '
        'rbtnEditProduct
        '
        Me.rbtnEditProduct.Caption = " Edit  Product Link"
        Me.rbtnEditProduct.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.rbtnEditProduct.Id = 10
        Me.rbtnEditProduct.LargeImageIndex = 3
        Me.rbtnEditProduct.Name = "rbtnEditProduct"
        '
        'Ribbon_LargeImages
        '
        Me.Ribbon_LargeImages.ImageSize = New System.Drawing.Size(32, 32)
        Me.Ribbon_LargeImages.ImageStream = CType(resources.GetObject("Ribbon_LargeImages.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
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
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btnReturn)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.ShowCaptionButton = False
        Me.RibbonPageGroup2.Text = "Actions"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.AllowMinimize = False
        Me.RibbonPageGroup1.AllowTextClipping = False
        Me.RibbonPageGroup1.ItemLinks.Add(Me.rbtnAddNewProduct)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.rbtnEditProduct)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.rbtnDeleteChemicalProductLink)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.ShowCaptionButton = False
        Me.RibbonPageGroup1.Text = "Product Mgmt"
        '
        'bsChem
        '
        Me.bsChem.DataSource = GetType(AOS.BusinessObjects.Chemical)
        '
        'bsProducts
        '
        Me.bsProducts.DataSource = GetType(AOS.BusinessObjects.ViewChemicalProductLinkCollection)
        '
        'TextEdit1
        '
        Me.TextEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsChem, "Chemicalid", True))
        Me.TextEdit1.Location = New System.Drawing.Point(116, 110)
        Me.TextEdit1.MenuManager = Me.RibbonControl1
        Me.TextEdit1.Name = "TextEdit1"
        Me.TextEdit1.Properties.ReadOnly = True
        Me.TextEdit1.Size = New System.Drawing.Size(58, 20)
        Me.TextEdit1.TabIndex = 1
        '
        'eChemicalName
        '
        Me.eChemicalName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.eChemicalName.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsChem, "Chemicalname", True))
        Me.eChemicalName.Location = New System.Drawing.Point(180, 110)
        Me.eChemicalName.MenuManager = Me.RibbonControl1
        Me.eChemicalName.Name = "eChemicalName"
        Me.eChemicalName.Properties.ReadOnly = True
        Me.eChemicalName.Size = New System.Drawing.Size(401, 20)
        Me.eChemicalName.TabIndex = 4
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(18, 113)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(93, 13)
        Me.LabelControl1.TabIndex = 10
        Me.LabelControl1.Text = "Chemical ID / Name"
        '
        'GridControl1
        '
        Me.GridControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridControl1.DataSource = Me.bsProducts
        Me.GridControl1.Location = New System.Drawing.Point(18, 136)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.MenuManager = Me.RibbonControl1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(563, 191)
        Me.GridControl1.TabIndex = 12
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colProductid, Me.colProductdesc, Me.colContainer, Me.colProductstatus})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colProductid
        '
        Me.colProductid.Caption = "Prod ID"
        Me.colProductid.FieldName = "Productid"
        Me.colProductid.Name = "colProductid"
        Me.colProductid.Visible = True
        Me.colProductid.VisibleIndex = 0
        Me.colProductid.Width = 57
        '
        'colProductdesc
        '
        Me.colProductdesc.Caption = "Product Description"
        Me.colProductdesc.FieldName = "Productdesc"
        Me.colProductdesc.Name = "colProductdesc"
        Me.colProductdesc.Visible = True
        Me.colProductdesc.VisibleIndex = 1
        Me.colProductdesc.Width = 308
        '
        'colContainer
        '
        Me.colContainer.Caption = "Container"
        Me.colContainer.FieldName = "Container"
        Me.colContainer.Name = "colContainer"
        Me.colContainer.Visible = True
        Me.colContainer.VisibleIndex = 2
        Me.colContainer.Width = 125
        '
        'colProductstatus
        '
        Me.colProductstatus.Caption = "Status"
        Me.colProductstatus.FieldName = "Productstatus"
        Me.colProductstatus.Name = "colProductstatus"
        Me.colProductstatus.Visible = True
        Me.colProductstatus.VisibleIndex = 3
        Me.colProductstatus.Width = 54
        '
        'rbtnDeleteChemicalProductLink
        '
        Me.rbtnDeleteChemicalProductLink.Caption = "Delete Product Link"
        Me.rbtnDeleteChemicalProductLink.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.rbtnDeleteChemicalProductLink.Id = 11
        Me.rbtnDeleteChemicalProductLink.LargeImageIndex = 4
        Me.rbtnDeleteChemicalProductLink.Name = "rbtnDeleteChemicalProductLink"
        '
        'frmChemicalProductLinks
        '
        Me.ClientSize = New System.Drawing.Size(596, 344)
        Me.ControlBox = False
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.eChemicalName)
        Me.Controls.Add(Me.TextEdit1)
        Me.Controls.Add(Me.RibbonControl1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmChemicalProductLinks"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Chemical / Product Links"
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ribbon_LargeImages, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsChem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsProducts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eChemicalName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents btnReturn As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents bsChem As System.Windows.Forms.BindingSource
    Friend WithEvents Ribbon_LargeImages As DevExpress.Utils.ImageCollection
    Friend WithEvents bsProducts As System.Windows.Forms.BindingSource
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents eChemicalName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents rbtnAddNewProduct As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rbtnEditProduct As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As CustomDevExGridView
    Friend WithEvents colProductid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProductdesc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colContainer As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProductstatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rbtnDeleteChemicalProductLink As DevExpress.XtraBars.BarButtonItem
End Class
