<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVendorList
    Inherits DevExpress.XtraEditors.XtraForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVendorList))
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.rbtnSelectVendor = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnCancel = New DevExpress.XtraBars.BarButtonItem()
        Me.LargeRibbonImages = New DevExpress.Utils.ImageCollection(Me.components)
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.bsVendors = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView1 = New CustomDevExGridView()
        Me.colVendorid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVendorname = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVendorcity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVendorstate = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LargeRibbonImages, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsVendors, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonControl1
        '
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.rbtnSelectVendor, Me.rbtnCancel})
        Me.RibbonControl1.LargeImages = Me.LargeRibbonImages
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.MaxItemId = 3
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide
        Me.RibbonControl1.ShowToolbarCustomizeItem = False
        Me.RibbonControl1.Size = New System.Drawing.Size(764, 95)
        Me.RibbonControl1.Toolbar.ShowCustomizeItem = False
        Me.RibbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden
        '
        'rbtnSelectVendor
        '
        Me.rbtnSelectVendor.Caption = "Select Vendor"
        Me.rbtnSelectVendor.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.rbtnSelectVendor.Id = 1
        Me.rbtnSelectVendor.LargeImageIndex = 7
        Me.rbtnSelectVendor.Name = "rbtnSelectVendor"
        '
        'rbtnCancel
        '
        Me.rbtnCancel.Caption = "Cancel"
        Me.rbtnCancel.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.rbtnCancel.Id = 2
        Me.rbtnCancel.LargeImageIndex = 8
        Me.rbtnCancel.Name = "rbtnCancel"
        '
        'LargeRibbonImages
        '
        Me.LargeRibbonImages.ImageSize = New System.Drawing.Size(32, 32)
        Me.LargeRibbonImages.ImageStream = CType(resources.GetObject("LargeRibbonImages.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "RibbonPage1"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.AllowMinimize = False
        Me.RibbonPageGroup1.AllowTextClipping = False
        Me.RibbonPageGroup1.ItemLinks.Add(Me.rbtnSelectVendor)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.rbtnCancel)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.ShowCaptionButton = False
        Me.RibbonPageGroup1.Text = "Action"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.GridControl1)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(0, 95)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(764, 313)
        Me.GroupControl1.TabIndex = 1
        Me.GroupControl1.Text = "Select a Vendor from the List:"
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.bsVendors
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(2, 22)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.MenuManager = Me.RibbonControl1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(760, 289)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'bsVendors
        '
        Me.bsVendors.DataSource = GetType(AOS.BusinessObjects.VendorCollection)
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colVendorid, Me.colVendorname, Me.colVendorcity, Me.colVendorstate})
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.OptionsView.ShowIndicator = False
        '
        'colVendorid
        '
        Me.colVendorid.Caption = "ID"
        Me.colVendorid.FieldName = "Vendorid"
        Me.colVendorid.Name = "colVendorid"
        Me.colVendorid.OptionsColumn.FixedWidth = True
        Me.colVendorid.Visible = True
        Me.colVendorid.VisibleIndex = 0
        Me.colVendorid.Width = 35
        '
        'colVendorname
        '
        Me.colVendorname.Caption = "Vendor Name"
        Me.colVendorname.FieldName = "Vendorname"
        Me.colVendorname.Name = "colVendorname"
        Me.colVendorname.Visible = True
        Me.colVendorname.VisibleIndex = 1
        Me.colVendorname.Width = 432
        '
        'colVendorcity
        '
        Me.colVendorcity.Caption = "City"
        Me.colVendorcity.FieldName = "Vendorcity"
        Me.colVendorcity.Name = "colVendorcity"
        Me.colVendorcity.Visible = True
        Me.colVendorcity.VisibleIndex = 2
        Me.colVendorcity.Width = 243
        '
        'colVendorstate
        '
        Me.colVendorstate.Caption = "State"
        Me.colVendorstate.FieldName = "Vendorstate"
        Me.colVendorstate.Name = "colVendorstate"
        Me.colVendorstate.OptionsColumn.FixedWidth = True
        Me.colVendorstate.Visible = True
        Me.colVendorstate.VisibleIndex = 3
        Me.colVendorstate.Width = 50
        '
        'frmVendorList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(764, 408)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.RibbonControl1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmVendorList"
        Me.Text = "Vendor List"
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LargeRibbonImages, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsVendors, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents rbtnSelectVendor As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rbtnCancel As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents LargeRibbonImages As DevExpress.Utils.ImageCollection
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents bsVendors As BindingSource
    Friend WithEvents GridView1 As CustomDevExGridView
    Friend WithEvents colVendorid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVendorname As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVendorcity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVendorstate As DevExpress.XtraGrid.Columns.GridColumn
End Class
