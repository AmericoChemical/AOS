<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddEditKit

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
        Dim KitidLabel As System.Windows.Forms.Label
        Dim KitNameLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddEditKit))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.eKitID = New DevExpress.XtraEditors.TextEdit()
        Me.bsKit = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComponentRibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btnSave = New DevExpress.XtraBars.BarButtonItem()
        Me.btnCancel = New DevExpress.XtraBars.BarButtonItem()
        Me.btnKitCompAdd = New DevExpress.XtraBars.BarButtonItem()
        Me.btnKitCompEdit = New DevExpress.XtraBars.BarButtonItem()
        Me.btnKitCompDelete = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup3 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RepositoryItemWeekOfMonth1 = New DevExpress.XtraScheduler.UI.RepositoryItemWeekOfMonth()
        Me.RepositoryItemAppointmentLabel1 = New DevExpress.XtraScheduler.UI.RepositoryItemAppointmentLabel()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.KitNameTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.grKitList = New DevExpress.XtraGrid.GridControl()
        Me.bsKitComponents = New System.Windows.Forms.BindingSource(Me.components)
        Me.viewKit = New CustomDevExGridView()
        Me.colComponentid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colComponentdesc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVendordesc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colComponentQty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit16 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.RepositoryItemLookUpEdit17 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.LargeRibbonImages = New DevExpress.Utils.ImageCollection(Me.components)
        KitidLabel = New System.Windows.Forms.Label()
        KitNameLabel = New System.Windows.Forms.Label()
        CType(Me.eKitID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsKit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComponentRibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemWeekOfMonth1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemAppointmentLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.KitNameTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.grKitList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsKitComponents, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.viewKit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LargeRibbonImages, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'KitidLabel
        '
        KitidLabel.AutoSize = True
        KitidLabel.Location = New System.Drawing.Point(97, 38)
        KitidLabel.Name = "KitidLabel"
        KitidLabel.Size = New System.Drawing.Size(33, 13)
        KitidLabel.TabIndex = 0
        KitidLabel.Text = "Kit ID"
        '
        'KitNameLabel
        '
        KitNameLabel.AutoSize = True
        KitNameLabel.Location = New System.Drawing.Point(81, 64)
        KitNameLabel.Name = "KitNameLabel"
        KitNameLabel.Size = New System.Drawing.Size(49, 13)
        KitNameLabel.TabIndex = 8
        KitNameLabel.Text = "Kit Name"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'eKitID
        '
        Me.eKitID.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsKit, "Kitid", True))
        Me.eKitID.Location = New System.Drawing.Point(132, 35)
        Me.eKitID.Name = "eKitID"
        Me.eKitID.Properties.ReadOnly = True
        Me.eKitID.Size = New System.Drawing.Size(64, 20)
        Me.eKitID.TabIndex = 1
        Me.eKitID.TabStop = False
        '
        'bsKit
        '
        Me.bsKit.DataSource = GetType(AOS.BusinessObjects.Kit)
        '
        'ComponentRibbonControl1
        '
        Me.ComponentRibbonControl1.ApplicationButtonText = Nothing
        Me.ComponentRibbonControl1.ExpandCollapseItem.Id = 0
        Me.ComponentRibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.ComponentRibbonControl1.ExpandCollapseItem, Me.btnSave, Me.btnCancel, Me.btnKitCompAdd, Me.btnKitCompEdit, Me.btnKitCompDelete})
        Me.ComponentRibbonControl1.LargeImages = Me.LargeRibbonImages
        Me.ComponentRibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.ComponentRibbonControl1.MaxItemId = 28
        Me.ComponentRibbonControl1.Name = "ComponentRibbonControl1"
        Me.ComponentRibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.ComponentRibbonControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemWeekOfMonth1, Me.RepositoryItemAppointmentLabel1})
        Me.ComponentRibbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide
        Me.ComponentRibbonControl1.ShowToolbarCustomizeItem = False
        Me.ComponentRibbonControl1.Size = New System.Drawing.Size(661, 95)
        Me.ComponentRibbonControl1.Toolbar.ShowCustomizeItem = False
        Me.ComponentRibbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden
        '
        'btnSave
        '
        Me.btnSave.Caption = " Save  Kit"
        Me.btnSave.Id = 4
        Me.btnSave.LargeImageIndex = 9
        Me.btnSave.Name = "btnSave"
        Me.btnSave.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'btnCancel
        '
        Me.btnCancel.Caption = "Cancel Kit"
        Me.btnCancel.Id = 5
        Me.btnCancel.LargeImageIndex = 10
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'btnKitCompAdd
        '
        Me.btnKitCompAdd.Caption = "Add New Kit Comp"
        Me.btnKitCompAdd.Id = 24
        Me.btnKitCompAdd.LargeImageIndex = 0
        Me.btnKitCompAdd.Name = "btnKitCompAdd"
        '
        'btnKitCompEdit
        '
        Me.btnKitCompEdit.Caption = "Edit Kit Comp"
        Me.btnKitCompEdit.Id = 25
        Me.btnKitCompEdit.LargeImageIndex = 1
        Me.btnKitCompEdit.Name = "btnKitCompEdit"
        Me.btnKitCompEdit.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'btnKitCompDelete
        '
        Me.btnKitCompDelete.Caption = "Delete Kit Comp"
        Me.btnKitCompDelete.Glyph = CType(resources.GetObject("btnKitCompDelete.Glyph"), System.Drawing.Image)
        Me.btnKitCompDelete.Id = 26
        Me.btnKitCompDelete.LargeImageIndex = 2
        Me.btnKitCompDelete.Name = "btnKitCompDelete"
        Me.btnKitCompDelete.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup2, Me.RibbonPageGroup3})
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
        Me.RibbonPageGroup2.Text = "Kit Management"
        '
        'RibbonPageGroup3
        '
        Me.RibbonPageGroup3.AllowMinimize = False
        Me.RibbonPageGroup3.AllowTextClipping = False
        Me.RibbonPageGroup3.ItemLinks.Add(Me.btnKitCompAdd)
        Me.RibbonPageGroup3.ItemLinks.Add(Me.btnKitCompEdit)
        Me.RibbonPageGroup3.ItemLinks.Add(Me.btnKitCompDelete)
        Me.RibbonPageGroup3.Name = "RibbonPageGroup3"
        Me.RibbonPageGroup3.ShowCaptionButton = False
        Me.RibbonPageGroup3.Text = "Kits Components"
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
        Me.GroupControl1.Controls.Add(KitNameLabel)
        Me.GroupControl1.Controls.Add(Me.eKitID)
        Me.GroupControl1.Controls.Add(KitidLabel)
        Me.GroupControl1.Controls.Add(Me.KitNameTextEdit)
        Me.GroupControl1.Location = New System.Drawing.Point(2, 101)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(659, 98)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "Kit Information"
        '
        'KitNameTextEdit
        '
        Me.KitNameTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsKit, "Kitname", True))
        Me.KitNameTextEdit.Location = New System.Drawing.Point(132, 61)
        Me.KitNameTextEdit.Name = "KitNameTextEdit"
        Me.KitNameTextEdit.Properties.MaxLength = 100
        Me.KitNameTextEdit.Size = New System.Drawing.Size(474, 20)
        Me.KitNameTextEdit.TabIndex = 4
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.grKitList)
        Me.GroupControl2.Location = New System.Drawing.Point(2, 205)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(659, 204)
        Me.GroupControl2.TabIndex = 10
        Me.GroupControl2.Text = "Kit Components"
        '
        'grKitList
        '
        Me.grKitList.DataSource = Me.bsKitComponents
        Me.grKitList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grKitList.Location = New System.Drawing.Point(2, 21)
        Me.grKitList.MainView = Me.viewKit
        Me.grKitList.Name = "grKitList"
        Me.grKitList.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit16, Me.RepositoryItemLookUpEdit17})
        Me.grKitList.Size = New System.Drawing.Size(655, 181)
        Me.grKitList.TabIndex = 1
        Me.grKitList.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.viewKit})
        '
        'viewKit
        '
        Me.viewKit.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colComponentid, Me.colComponentdesc, Me.colVendordesc, Me.colComponentQty})
        Me.viewKit.GridControl = Me.grKitList
        Me.viewKit.Name = "viewKit"
        Me.viewKit.OptionsBehavior.Editable = False
        Me.viewKit.OptionsSelection.MultiSelect = True
        Me.viewKit.OptionsView.ShowAutoFilterRow = True
        Me.viewKit.OptionsView.ShowGroupPanel = False
        '
        'colComponentid
        '
        Me.colComponentid.Caption = "Comp ID"
        Me.colComponentid.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colComponentid.FieldName = "Componentid"
        Me.colComponentid.Name = "colComponentid"
        Me.colComponentid.OptionsColumn.AllowEdit = False
        Me.colComponentid.Visible = True
        Me.colComponentid.VisibleIndex = 0
        Me.colComponentid.Width = 63
        '
        'colComponentdesc
        '
        Me.colComponentdesc.Caption = "Americo Desc"
        Me.colComponentdesc.FieldName = "Componentdesc"
        Me.colComponentdesc.Name = "colComponentdesc"
        Me.colComponentdesc.OptionsColumn.AllowEdit = False
        Me.colComponentdesc.Visible = True
        Me.colComponentdesc.VisibleIndex = 1
        Me.colComponentdesc.Width = 240
        '
        'colVendordesc
        '
        Me.colVendordesc.Caption = "Vendor Desc"
        Me.colVendordesc.FieldName = "Vendordesc"
        Me.colVendordesc.Name = "colVendordesc"
        Me.colVendordesc.OptionsColumn.AllowEdit = False
        Me.colVendordesc.Visible = True
        Me.colVendordesc.VisibleIndex = 2
        Me.colVendordesc.Width = 290
        '
        'colComponentQty
        '
        Me.colComponentQty.AppearanceCell.Options.UseTextOptions = True
        Me.colComponentQty.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colComponentQty.AppearanceHeader.Options.UseTextOptions = True
        Me.colComponentQty.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colComponentQty.Caption = "Comp Qty"
        Me.colComponentQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colComponentQty.FieldName = "Componentqty"
        Me.colComponentQty.Name = "colComponentQty"
        Me.colComponentQty.OptionsColumn.AllowEdit = False
        Me.colComponentQty.Visible = True
        Me.colComponentQty.VisibleIndex = 3
        Me.colComponentQty.Width = 103
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
        'LargeRibbonImages
        '
        Me.LargeRibbonImages.ImageSize = New System.Drawing.Size(32, 32)
        Me.LargeRibbonImages.ImageStream = CType(resources.GetObject("LargeRibbonImages.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        '
        'frmAddEditKit
        '
        Me.ClientSize = New System.Drawing.Size(661, 412)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.ComponentRibbonControl1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmAddEditKit"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Kit Information"
        CType(Me.eKitID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsKit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComponentRibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemWeekOfMonth1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemAppointmentLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.KitNameTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.grKitList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsKitComponents, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.viewKit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LargeRibbonImages, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents eKitID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ComponentRibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents btnSave As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnCancel As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents RepositoryItemWeekOfMonth1 As DevExpress.XtraScheduler.UI.RepositoryItemWeekOfMonth
    Friend WithEvents RepositoryItemAppointmentLabel1 As DevExpress.XtraScheduler.UI.RepositoryItemAppointmentLabel
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents btnKitCompAdd As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnKitCompEdit As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnKitCompDelete As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents grKitList As DevExpress.XtraGrid.GridControl
    Friend WithEvents viewKit As CustomDevExGridView
    Friend WithEvents colComponentid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colComponentdesc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVendordesc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit16 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemLookUpEdit17 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents bsKit As System.Windows.Forms.BindingSource
    Friend WithEvents bsKitComponents As System.Windows.Forms.BindingSource
    Friend WithEvents colComponentQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents KitNameTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents RibbonPageGroup3 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents LargeRibbonImages As DevExpress.Utils.ImageCollection
End Class
