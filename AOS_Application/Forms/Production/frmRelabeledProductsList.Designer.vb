<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRelabeledProductsList

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRelabeledProductsList))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.bs = New System.Windows.Forms.BindingSource(Me.components)
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btnCancel = New DevExpress.XtraBars.BarButtonItem()
        Me.LargeRibbonImages = New DevExpress.Utils.ImageCollection(Me.components)
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.grvItemList = New AOS.CustomClasses.CustomDevExGridView()
        Me.colFulfillmentplanid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRlblid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRlbldesc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProductid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProductdesc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKitid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStdlaborhrs = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.bs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LargeRibbonImages, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grvItemList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'bs
        '
        Me.bs.DataSource = GetType(AOS.BusinessObjects.ViewRelabeledProductsListCollection)
        '
        'RibbonControl1
        '
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.btnCancel})
        Me.RibbonControl1.LargeImages = Me.LargeRibbonImages
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.MaxItemId = 7
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide
        Me.RibbonControl1.ShowToolbarCustomizeItem = False
        Me.RibbonControl1.Size = New System.Drawing.Size(1109, 117)
        Me.RibbonControl1.Toolbar.ShowCustomizeItem = False
        Me.RibbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden
        '
        'btnCancel
        '
        Me.btnCancel.Caption = "Close"
        Me.btnCancel.Id = 5
        Me.btnCancel.ImageOptions.LargeImageIndex = 1
        Me.btnCancel.Name = "btnCancel"
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
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btnCancel)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.ShowCaptionButton = False
        Me.RibbonPageGroup2.Text = "Actions"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.GridControl1)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(0, 117)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(1109, 438)
        Me.GroupControl1.TabIndex = 1
        Me.GroupControl1.Text = "Vendor Purchase History"
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.bs
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(2, 22)
        Me.GridControl1.MainView = Me.grvItemList
        Me.GridControl1.MenuManager = Me.RibbonControl1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(1105, 414)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grvItemList})
        '
        'grvItemList
        '
        Me.grvItemList.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFulfillmentplanid, Me.colRlblid, Me.colRlbldesc, Me.colProductid, Me.colProductdesc, Me.colKitid, Me.colStdlaborhrs, Me.GridColumn1})
        Me.grvItemList.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus
        Me.grvItemList.GridControl = Me.GridControl1
        Me.grvItemList.Name = "grvItemList"
        Me.grvItemList.OptionsBehavior.Editable = False
        Me.grvItemList.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.grvItemList.OptionsView.ShowAutoFilterRow = True
        Me.grvItemList.OptionsView.ShowGroupPanel = False
        Me.grvItemList.OptionsView.ShowIndicator = False
        '
        'colFulfillmentplanid
        '
        Me.colFulfillmentplanid.FieldName = "Fulfillmentplanid"
        Me.colFulfillmentplanid.Name = "colFulfillmentplanid"
        '
        'colRlblid
        '
        Me.colRlblid.Caption = "Relabeled ID"
        Me.colRlblid.FieldName = "Rlblid"
        Me.colRlblid.Name = "colRlblid"
        Me.colRlblid.Visible = True
        Me.colRlblid.VisibleIndex = 0
        Me.colRlblid.Width = 72
        '
        'colRlbldesc
        '
        Me.colRlbldesc.Caption = "Relabeled Description"
        Me.colRlbldesc.FieldName = "Rlbldesc"
        Me.colRlbldesc.Name = "colRlbldesc"
        Me.colRlbldesc.Visible = True
        Me.colRlbldesc.VisibleIndex = 1
        Me.colRlbldesc.Width = 392
        '
        'colProductid
        '
        Me.colProductid.Caption = "End Prod ID"
        Me.colProductid.FieldName = "Productid"
        Me.colProductid.Name = "colProductid"
        Me.colProductid.Visible = True
        Me.colProductid.VisibleIndex = 3
        Me.colProductid.Width = 72
        '
        'colProductdesc
        '
        Me.colProductdesc.Caption = "End Product Description"
        Me.colProductdesc.FieldName = "Productdesc"
        Me.colProductdesc.Name = "colProductdesc"
        Me.colProductdesc.Visible = True
        Me.colProductdesc.VisibleIndex = 4
        Me.colProductdesc.Width = 358
        '
        'colKitid
        '
        Me.colKitid.Caption = "Kit #"
        Me.colKitid.FieldName = "Kitid"
        Me.colKitid.Name = "colKitid"
        Me.colKitid.Visible = True
        Me.colKitid.VisibleIndex = 5
        Me.colKitid.Width = 57
        '
        'colStdlaborhrs
        '
        Me.colStdlaborhrs.Caption = "Labor Hrs"
        Me.colStdlaborhrs.FieldName = "Stdlaborhrs"
        Me.colStdlaborhrs.Name = "colStdlaborhrs"
        Me.colStdlaborhrs.Visible = True
        Me.colStdlaborhrs.VisibleIndex = 6
        Me.colStdlaborhrs.Width = 80
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Container"
        Me.GridColumn1.FieldName = "Rlblcontainer"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 2
        Me.GridColumn1.Width = 72
        '
        'frmRelabeledProductsList
        '
        Me.ClientSize = New System.Drawing.Size(1109, 555)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.RibbonControl1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmRelabeledProductsList"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Relabeled Products List"
        CType(Me.bs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LargeRibbonImages, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grvItemList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents bs As System.Windows.Forms.BindingSource
    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents btnCancel As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents LargeRibbonImages As DevExpress.Utils.ImageCollection
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents grvItemList As CustomDevExGridView
    Friend WithEvents colFulfillmentplanid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRlblid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRlbldesc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProductid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProductdesc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKitid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStdlaborhrs As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
End Class
