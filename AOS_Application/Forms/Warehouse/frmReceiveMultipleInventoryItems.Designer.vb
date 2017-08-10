<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmReceiveMultipleInventoryItems

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReceiveMultipleInventoryItems))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btnBack = New DevExpress.XtraBars.BarButtonItem()
        Me.LargeRibbonImages = New DevExpress.Utils.ImageCollection(Me.components)
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.lblModified = New DevExpress.XtraEditors.LabelControl()
        Me.lblCreated = New DevExpress.XtraEditors.LabelControl()
        Me.GroupControl8 = New DevExpress.XtraEditors.GroupControl()
        Me.grInventoryItems = New DevExpress.XtraGrid.GridControl()
        Me.bsInventoryItems = New System.Windows.Forms.BindingSource(Me.components)
        Me.grvInventoryItems = New AOS.CustomClasses.CustomDevExGridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Lotnumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.VENDORWEIGHT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colItemstatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemHyperLinkEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LargeRibbonImages, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl8.SuspendLayout()
        CType(Me.grInventoryItems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsInventoryItems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grvInventoryItems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemHyperLinkEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'RibbonControl1
        '
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.btnBack})
        Me.RibbonControl1.LargeImages = Me.LargeRibbonImages
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.MaxItemId = 9
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide
        Me.RibbonControl1.ShowToolbarCustomizeItem = False
        Me.RibbonControl1.Size = New System.Drawing.Size(897, 95)
        Me.RibbonControl1.Toolbar.ShowCustomizeItem = False
        Me.RibbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden
        '
        'btnBack
        '
        Me.btnBack.Caption = "Back"
        Me.btnBack.Id = 6
        Me.btnBack.LargeImageIndex = 0
        Me.btnBack.Name = "btnBack"
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
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btnBack)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.ShowCaptionButton = False
        Me.RibbonPageGroup2.Text = "Actions"
        '
        'lblModified
        '
        Me.lblModified.Location = New System.Drawing.Point(18, 526)
        Me.lblModified.Name = "lblModified"
        Me.lblModified.Size = New System.Drawing.Size(0, 13)
        Me.lblModified.TabIndex = 59
        '
        'lblCreated
        '
        Me.lblCreated.Location = New System.Drawing.Point(18, 507)
        Me.lblCreated.Name = "lblCreated"
        Me.lblCreated.Size = New System.Drawing.Size(0, 13)
        Me.lblCreated.TabIndex = 58
        '
        'GroupControl8
        '
        Me.GroupControl8.Controls.Add(Me.grInventoryItems)
        Me.GroupControl8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl8.Location = New System.Drawing.Point(0, 95)
        Me.GroupControl8.Name = "GroupControl8"
        Me.GroupControl8.Size = New System.Drawing.Size(897, 235)
        Me.GroupControl8.TabIndex = 63
        Me.GroupControl8.Text = "Double Click on a Single Item to Enter Receiving Information"
        '
        'grInventoryItems
        '
        Me.grInventoryItems.DataSource = Me.bsInventoryItems
        Me.grInventoryItems.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grInventoryItems.Location = New System.Drawing.Point(2, 22)
        Me.grInventoryItems.LookAndFeel.SkinName = "Money Twins"
        Me.grInventoryItems.MainView = Me.grvInventoryItems
        Me.grInventoryItems.Name = "grInventoryItems"
        Me.grInventoryItems.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemHyperLinkEdit1, Me.RepositoryItemCheckEdit1})
        Me.grInventoryItems.Size = New System.Drawing.Size(893, 211)
        Me.grInventoryItems.TabIndex = 5
        Me.grInventoryItems.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grvInventoryItems})
        '
        'bsInventoryItems
        '
        Me.bsInventoryItems.DataSource = GetType(AOS.BusinessObjects.ViewInvItemListCollection)
        '
        'grvInventoryItems
        '
        Me.grvInventoryItems.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn2, Me.Lotnumber, Me.VENDORWEIGHT, Me.colItemstatus})
        Me.grvInventoryItems.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None
        Me.grvInventoryItems.GridControl = Me.grInventoryItems
        Me.grvInventoryItems.Name = "grvInventoryItems"
        Me.grvInventoryItems.OptionsBehavior.Editable = False
        Me.grvInventoryItems.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.grvInventoryItems.OptionsSelection.MultiSelect = True
        Me.grvInventoryItems.OptionsView.ShowGroupPanel = False
        Me.grvInventoryItems.OptionsView.ShowIndicator = False
        '
        'GridColumn1
        '
        Me.GridColumn1.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GridColumn1.Caption = "Item #"
        Me.GridColumn1.FieldName = "Invitemnumber"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.AllowEdit = False
        Me.GridColumn1.OptionsColumn.FixedWidth = True
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 70
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Item Type"
        Me.GridColumn3.FieldName = "Itemtype"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.AllowEdit = False
        Me.GridColumn3.OptionsColumn.FixedWidth = True
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 1
        Me.GridColumn3.Width = 60
        '
        'GridColumn4
        '
        Me.GridColumn4.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn4.Caption = "Item ID"
        Me.GridColumn4.FieldName = "Itemid"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.OptionsColumn.AllowEdit = False
        Me.GridColumn4.OptionsColumn.FixedWidth = True
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 2
        Me.GridColumn4.Width = 50
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Item Description"
        Me.GridColumn5.FieldName = "Itemdescription"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.OptionsColumn.AllowEdit = False
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 3
        Me.GridColumn5.Width = 391
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Container"
        Me.GridColumn2.FieldName = "Container"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.AllowEdit = False
        Me.GridColumn2.OptionsColumn.FixedWidth = True
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 4
        Me.GridColumn2.Width = 80
        '
        'Lotnumber
        '
        Me.Lotnumber.Caption = "Lot #"
        Me.Lotnumber.FieldName = "Lotnumber"
        Me.Lotnumber.Name = "Lotnumber"
        Me.Lotnumber.OptionsColumn.FixedWidth = True
        Me.Lotnumber.Visible = True
        Me.Lotnumber.VisibleIndex = 5
        Me.Lotnumber.Width = 80
        '
        'VENDORWEIGHT
        '
        Me.VENDORWEIGHT.Caption = "Vendor Lbl Wgt"
        Me.VENDORWEIGHT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.VENDORWEIGHT.FieldName = "Vendorweight"
        Me.VENDORWEIGHT.Name = "VENDORWEIGHT"
        Me.VENDORWEIGHT.OptionsColumn.FixedWidth = True
        Me.VENDORWEIGHT.Visible = True
        Me.VENDORWEIGHT.VisibleIndex = 6
        Me.VENDORWEIGHT.Width = 85
        '
        'colItemstatus
        '
        Me.colItemstatus.Caption = "Status"
        Me.colItemstatus.FieldName = "Itemstatus"
        Me.colItemstatus.Name = "colItemstatus"
        Me.colItemstatus.Visible = True
        Me.colItemstatus.VisibleIndex = 7
        Me.colItemstatus.Width = 77
        '
        'RepositoryItemHyperLinkEdit1
        '
        Me.RepositoryItemHyperLinkEdit1.AutoHeight = False
        Me.RepositoryItemHyperLinkEdit1.Name = "RepositoryItemHyperLinkEdit1"
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Caption = "Check"
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'frmReceiveMultipleInventoryItems
        '
        Me.ClientSize = New System.Drawing.Size(897, 330)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupControl8)
        Me.Controls.Add(Me.lblModified)
        Me.Controls.Add(Me.lblCreated)
        Me.Controls.Add(Me.RibbonControl1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmReceiveMultipleInventoryItems"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Receive Multiple Inventory Items"
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LargeRibbonImages, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl8.ResumeLayout(False)
        CType(Me.grInventoryItems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsInventoryItems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grvInventoryItems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemHyperLinkEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents lblModified As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblCreated As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl8 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents grInventoryItems As DevExpress.XtraGrid.GridControl
    Friend WithEvents grvInventoryItems As CustomDevExGridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemHyperLinkEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Lotnumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents VENDORWEIGHT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents bsInventoryItems As System.Windows.Forms.BindingSource
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents btnBack As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colItemstatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LargeRibbonImages As DevExpress.Utils.ImageCollection
End Class
